using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model.Traits;
using System.Text.Json;

namespace SmithyDotNet.Generator.Writers.Endpoints;

/// <summary>
/// Emits the endpoint provider (e.g. <c>AmazonCloudTrailDataEndpointProvider</c>) for a service
/// carrying a <c>smithy.rules#endpointBdd</c> trait. This provider decodes a BDD node array and
/// resolves the endpoint by evaluating conditions on demand via <c>BddEvaluator</c>.
/// </summary>
public sealed class BddProviderWriter(GenerationContext context, string modelFileName)
{
    // Shared state for the expression emitter / template unroller (set at the top of Write, since
    // the writer is instantiated once per service). RenderRef reads both.
    private IReadOnlyDictionary<string, string> _fieldByAssign = new Dictionary<string, string>();
    private HashSet<string> _paramNames = [];

    /// <summary>
    /// Emits the BDD endpoint provider source. The BDD is required; callers gate on
    /// <see cref="GenerationContext.HasEndpointBdd"/>.
    /// </summary>
    public string Write(CancellationToken cancellationToken = default)
    {
        var bdd = context.EndpointBdd ?? throw new GeneratorException("BddProviderWriter requires an endpoint BDD.");
        var className = $"{context.ClientName}EndpointProvider";
        var parametersName = $"{context.BaseName}EndpointParameters";
        var assignFields = CollectAssignFields(bdd);
        _fieldByAssign = assignFields.ToDictionary(f => f.RawName, f => f.FieldName);
        _paramNames = [.. bdd.Parameters.Keys];

        var writer = new CodeWriter();
        FileHeader.WriteLicense(writer, modelFileName);
        FileHeader.WriteUsings(writer,
        [
            .. FileHeader.EndpointProviderUsings,
            "Amazon.Runtime.Internal.Endpoints",
            "Amazon.Runtime.Internal.Endpoints.StandardLibrary",
            $"{context.Namespace}.Endpoints",
        ]);
        writer.OpenNamespace($"{context.Namespace}.Internal", () =>
        {
            writer.OpenBlock($"public class {className} : IEndpointProvider, IBddConditionEvaluator<Context>", () =>
            {
                WriteContextClass(writer, parametersName, assignFields);
                writer.WriteLine();
                writer.WriteLine($"private static readonly int[] Nodes = BddNodeDecoder.Decode({CodeWriter.Literal(bdd.Nodes)});");
                writer.WriteLine($"private const int Root = {bdd.Root};");
                writer.WriteLine();
                writer.WriteLine("/// <summary>");
                writer.WriteLine($"/// Resolves the endpoint for {parametersName}.");
                writer.WriteLine("/// </summary>");
                writer.OpenBlock("public Endpoint ResolveEndpoint(EndpointParameters parameters)", () =>
                {
                    WriteGuards(writer, bdd);
                    writer.WriteLine();
                    writer.WriteLine($"var typed = ({context.BaseName}EndpointParameters)parameters;");
                    writer.WriteLine("var context = new Context(typed);");
                    writer.WriteLine("var result = BddEvaluator.Evaluate(Nodes, Root, this, context);");
                    WriteResultsSwitch(writer, bdd, assignFields);
                });
                writer.WriteLine();
                WriteEvaluateCondition(writer, bdd);
            });
        });

        return writer.ToFormattedString(cancellationToken);
    }

    /// <summary>How a resolved assign binding is emitted as a typed Context field.</summary>
    private sealed record AssignField(string RawName, string FieldName, string Type);

    /// <summary>
    /// Collects one typed field per distinct <c>assign</c> across the BDD's conditions, each named
    /// via <see cref="SdkNaming.ToPropertyIdentifier"/> and typed by its producing function.
    /// </summary>
    private static List<AssignField> CollectAssignFields(EndpointBdd bdd)
    {
        var usedNames = new Dictionary<string, int>();
        var seen = new HashSet<string>();
        var fields = new List<AssignField>();
        foreach (var condition in bdd.Conditions)
        {
            // The same assign can appear on several conditions (BDD node sharing); emit one field.
            if (condition.Assign is not { } assign || !seen.Add(assign))
            {
                continue;
            }

            var fieldName = SdkNaming.ToPropertyIdentifier(assign, usedNames);
            fields.Add(new AssignField(assign, fieldName, AssignFieldType(condition.Fn)));
        }

        return fields;
    }

    /// <summary>Maps an assigning function to the runtime type its result binds to.</summary>
    private static string AssignFieldType(string fn) => fn switch
    {
        "aws.partition" => "Partition",
        "aws.parseArn" => "Arn",
        "parseURL" => "URL",
        "substring" => "string",
        "uriEncode" => "string",
        "getAttr" => "object",
        "split" => "IList<string>",
        _ => throw new GeneratorException($"BDD assign uses unsupported function '{fn}'."),
    };

    /// <summary>
    /// Emits the per-resolve <c>Context</c>: the typed parameters plus one mutable field per assign,
    /// replacing the tree provider's loosely-typed <c>refs</c> dictionary.
    /// </summary>
    private static void WriteContextClass(CodeWriter writer, string parametersName, List<AssignField> assignFields)
    {
        writer.OpenBlock("private sealed class Context", () =>
        {
            writer.WriteLine($"public {parametersName} Parameters {{ get; }}");
            foreach (var field in assignFields)
            {
                writer.WriteLine($"public {field.Type} {field.FieldName} {{ get; set; }}");
            }

            writer.WriteLine();
            writer.OpenBlock($"public Context({parametersName} parameters)", () =>
            {
                writer.WriteLine("Parameters = parameters;");
            });
        });
    }

    private static void WriteGuards(CodeWriter writer, EndpointBdd bdd)
    {
        writer.OpenBlock("if (parameters == null)", () =>
        {
            writer.WriteLine("throw new ArgumentNullException(\"parameters\");");
        });

        // Required parameters must be present before traversal read them.
        foreach (var (name, parameter) in bdd.Parameters)
        {
            if (parameter.Required)
            {
                writer.OpenBlock($"if (parameters[\"{name}\"] == null)", () =>
                {
                    writer.WriteLine($"throw new AmazonClientException(\"{name} parameter must be set for endpoint resolution\");");
                });
            }
        }
    }

    private void WriteResultsSwitch(CodeWriter writer, EndpointBdd bdd, IReadOnlyList<AssignField> assignFields)
    {
        writer.OpenBlock("switch (result)", () =>
        {
            // Result index 0 is the implicit NoMatchRule (not serialized in bdd.Results).
            writer.WriteLine("case 0:");
            writer.Indent(() =>
                writer.WriteLine("""throw new AmazonClientException("Cannot resolve endpoint");"""));

            // Serialized results start at index 1: bdd.Results[i] => result index i + 1.
            for (var i = 0; i < bdd.Results.Count; i++)
            {
                var rule = bdd.Results[i];
                writer.WriteLine($"case {i + 1}:");
                writer.Indent(() => WriteResultBody(writer, rule));
            }

            writer.WriteLine("default:");
            writer.Indent(() =>
                writer.WriteLine("""throw new AmazonClientException("Cannot resolve endpoint");"""));
        });
    }

    private void WriteResultBody(CodeWriter writer, EndpointRule rule)
    {
        switch (rule.Type)
        {
            case "endpoint":
                var endpoint = rule.Endpoint ?? throw new GeneratorException("BDD endpoint result is missing its endpoint definition.");
                writer.WriteLine($"return new Endpoint({UnrollUrl(endpoint.Url)}, {UnrollJsonTemplate(endpoint.Properties)}, {UnrollJsonTemplate(endpoint.Headers)});");
                break;
            case "error":
                var error = rule.Error ?? throw new GeneratorException("BDD error result is missing its error message.");
                writer.WriteLine($"throw new AmazonClientException({UnrollTemplate(error)});");
                break;
            default:
                throw new GeneratorException($"Unsupported BDD result type '{rule.Type}' (results must be 'endpoint' or 'error').");
        }
    }

    private void WriteEvaluateCondition(CodeWriter writer, EndpointBdd bdd)
    {
        writer.WriteLine("/// <summary>");
        writer.WriteLine("/// Evaluates the BDD condition at <paramref name=\"conditionIndex\"/> against the context.");
        writer.WriteLine("/// </summary>");
        writer.OpenBlock("public bool EvaluateCondition(int conditionIndex, Context context)", () =>
        {
            writer.OpenBlock("switch (conditionIndex)", () =>
            {
                for (var i = 0; i < bdd.Conditions.Count; i++)
                {
                    var expr = BuildCondition(bdd.Conditions[i]);
                    writer.WriteLine($"case {i}:");
                    writer.Indent(() => writer.WriteLine($"return {expr};"));
                }

                writer.WriteLine("default:");
                writer.Indent(() =>
                    writer.WriteLine("""throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");"""));
            });
        });
    }

    private string BuildCondition(EndpointCondition condition)
    {
        var call = BuildCall(condition.Fn, condition.Argv);

        if (condition.Assign is { } assign)
        {
            return $"({RenderRef(assign)} = {call}) != null";
        }

        if (!IsBooleanFn(condition.Fn))
        {
            return $"{call} != null";
        }

        return call;
    }

    private string RenderRef(string name)
    {
        if (_fieldByAssign.TryGetValue(name, out var field))
        {
            return $"context.{field}";
        }
        if (_paramNames.Contains(name))
        {
            return $"context.Parameters.{name}";
        }
        throw new GeneratorException($"BDD ref '{name}' is neither a parameter nor an assign.");
    }

    private sealed record Fn(string Name, bool IsBoolean, string[] ArgCasts);

    private static readonly IReadOnlyDictionary<string, Fn> Functions = new Dictionary<string, Fn>
    {
        ["isSet"] = new("IsSet", true, []),
        ["booleanEquals"] = new("Equals", true, []),
        ["stringEquals"] = new("Equals", true, []),
        ["getAttr"] = new("GetAttr", false, []),
        ["not"] = new("!", true, []),
        ["aws.partition"] = new("Partition", false, ["string"]),
        ["aws.parseArn"] = new("ParseArn", false, ["string"]),
        ["parseURL"] = new("ParseURL", false, ["string"]),
        ["isValidHostLabel"] = new("IsValidHostLabel", true, ["string", "bool"]),
        ["substring"] = new("Substring", false, ["string", "int", "int", "bool"]),
        ["uriEncode"] = new("UriEncode", false, ["string"]),
        ["split"] = new("Split", false, ["string", "string"]),
        ["aws.isVirtualHostableS3Bucket"] = new("IsVirtualHostableS3Bucket", true, ["string", "bool"]),
    };

    // coalesce/ite are emitted as C# operators (?? and the ?: ternary) rather than Fn.* calls, so
    // they are boolean when their operands are. Everything else reads IsBoolean off Functions.
    private static bool IsBooleanFn(string fn) => fn switch
    {
        "coalesce" or "ite" => true,
        _ => Functions.TryGetValue(fn, out var spec) ? spec.IsBoolean
            : throw new GeneratorException($"BDD condition function '{fn}' is not supported yet."),
    };

    private string BuildCall(string fn, IReadOnlyList<JsonElement> argv)
    {
        // coalesce -> a ?? b ?? ... (no boxing for bool?); ite -> cond == true ? then : else.
        if (fn == "coalesce")
        {
            return string.Join(" ?? ", argv.Select(arg => BuildArgument(arg, spec: null, index: 0)));
        }
        if (fn == "ite")
        {
            if (argv.Count != 3)
            {
                throw new GeneratorException($"BDD function 'ite' expects exactly three arguments but got {argv.Count}.");
            }
            return $"{BuildArgument(argv[0], spec: null, index: 0)} == true "
                 + $"? {BuildArgument(argv[1], spec: null, index: 1)} "
                 + $": {BuildArgument(argv[2], spec: null, index: 2)}";
        }

        if (!Functions.TryGetValue(fn, out var fnSpec))
        {
            throw new GeneratorException($"BDD condition function '{fn}' is not supported yet.");
        }

        // "not" negates its single argument (e.g. !IsSet(...)) rather than emitting a call.
        if (fn == "not")
        {
            if (argv.Count != 1)
            {
                throw new GeneratorException($"BDD function 'not' expects exactly one argument but got {argv.Count}.");
            }
            return $"!{BuildArgument(argv[0], fnSpec, 0)}";
        }

        var args = argv.Select((arg, i) => BuildArgument(arg, fnSpec, i));
        return $"{fnSpec.Name}({string.Join(", ", args)})";
    }

    private string BuildArgument(JsonElement arg, Fn? spec, int index)
    {
        switch (arg.ValueKind)
        {
            case JsonValueKind.String:
                return UnrollTemplate(arg.GetString() ?? string.Empty);
            case JsonValueKind.Number:
                return arg.GetRawText();
            case JsonValueKind.True:
                return "true";
            case JsonValueKind.False:
                return "false";
            case JsonValueKind.Object:
                // Only reference and nested-function arguments carry the function's argument cast.
                var cast = spec is not null && index < spec.ArgCasts.Length ? $"({spec.ArgCasts[index]})" : string.Empty;
                if (arg.TryGetProperty("ref", out var reference))
                {
                    return $"{cast}{RenderRef(reference.GetString() ?? string.Empty)}";
                }
                if (arg.TryGetProperty("fn", out var nestedFn))
                {
                    return $"{cast}{BuildCall(nestedFn.GetString() ?? string.Empty, ReadArgv(arg))}";
                }
                throw new GeneratorException("BDD function argument object has neither a 'ref' nor an 'fn'.");
            default:
                throw new GeneratorException($"Unsupported BDD function argument of kind '{arg.ValueKind}'.");
        }
    }

    private static IReadOnlyList<JsonElement> ReadArgv(JsonElement functionObject) =>
        functionObject.TryGetProperty("argv", out var argv) && argv.ValueKind == JsonValueKind.Array
        ? argv.EnumerateArray().ToList()
        : [];

    // A URL is a template string, a {"ref": ...}, or a {"fn": ...}; the latter two are cast to string.
    private string UnrollUrl(JsonElement url)
    {
        if (url.ValueKind == JsonValueKind.String)
        {
            return UnrollTemplate(url.GetString() ?? string.Empty);
        }
        if (url.ValueKind == JsonValueKind.Object)
        {
            if (url.TryGetProperty("ref", out var reference))
            {
                return $"(string){RenderRef(reference.GetString() ?? string.Empty)}";
            }
            if (url.TryGetProperty("fn", out var fn))
            {
                return $"(string){BuildCall(fn.GetString() ?? string.Empty, ReadArgv(url))}";
            }
        }
        throw new GeneratorException("BDD endpoint URL is not a template string, a reference, or a function.");
    }

    // Endpoint properties/headers are a JSON string arg to the Endpoint ctor. Pilot results leave
    // both empty; emit null (the ctor's empty form). Rich JSON-template unrolling is deferred.
    private static string UnrollJsonTemplate(JsonElement? json)
    {
        if (json is { } value && value.ValueKind == JsonValueKind.Object && value.EnumerateObject().Any())
        {
            throw new GeneratorException("BDD endpoint properties/headers interpolation is not yet implemented.");
        }
        return "null";
    }

    // Reproduces Fn.Interpolate's grammar at generation time, emitting a C# $"..." interpolated
    // literal instead of resolving: {ref} -> {RenderRef(ref)}, {ref#path} -> Fn.GetAttr(...), with
    // {{ and }} as literal braces. A template with no placeholders becomes a plain string literal.
    private string UnrollTemplate(string template)
    {
        if (!template.Contains('{'))
        {
            return CodeWriter.Literal(template);
        }

        var body = new System.Text.StringBuilder();
        var i = 0;
        while (i < template.Length)
        {
            var c = template[i];
            if (c == '{' && i + 1 < template.Length && template[i + 1] == '{')
            {
                body.Append("{{");
                i += 2;
            }
            else if (c == '}' && i + 1 < template.Length && template[i + 1] == '}')
            {
                body.Append("}}");
                i += 2;
            }
            else if (c == '{')
            {
                var close = template.IndexOf('}', i + 1);
                if (close < 0)
                {
                    throw new GeneratorException($"BDD template is missing a closing brace: '{template}'.");
                }
                var placeholder = template.Substring(i + 1, close - i - 1);
                var hash = placeholder.IndexOf('#');
                if (hash >= 0)
                {
                    var refName = placeholder.Substring(0, hash);
                    var path = placeholder.Substring(hash + 1).Replace("#", string.Empty);
                    body.Append($"{{Fn.GetAttr({RenderRef(refName)}, \"{path}\")}}");
                }
                else
                {
                    body.Append($"{{{RenderRef(placeholder)}}}");
                }
                i = close + 1;
            }
            else
            {
                // Escape characters that are special inside a C# interpolated verbatim-free literal.
                body.Append(c switch
                {
                    '"' => "\\\"",
                    '\\' => "\\\\",
                    _ => c.ToString(),
                });
                i++;
            }
        }

        return $"$\"{body}\"";
    }
}
