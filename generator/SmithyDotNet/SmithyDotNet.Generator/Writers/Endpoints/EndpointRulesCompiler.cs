using System.Text.Json;
using SmithyDotNet.Generator.Model.Traits;

namespace SmithyDotNet.Generator.Writers.Endpoints;

/// <summary>
/// Compiles a Smithy endpoint rule set into the imperative body of <c>ResolveEndpoint</c>: each rule
/// becomes an <c>if</c> guarded by its conditions, resolving to a <c>return new Endpoint(...)</c> or a
/// <c>throw new AmazonClientException(...)</c>. The emitted code calls the runtime standard library
/// (<c>IsSet</c>, <c>Equals</c>, <c>GetAttr</c>, <c>Partition</c>, <c>Interpolate</c>, ...), imported
/// via <c>using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn</c>.
/// <para />
/// Only the rule-set functions CloudTrailData uses are supported; anything else fails loudly rather
/// than emitting code with unverified semantics. Add functions to <see cref="Functions"/> as more
/// services are onboarded.
/// </summary>
public static class EndpointRulesCompiler
{
    /// <summary>How a rule-set function maps to emitted C#.</summary>
    /// <param name="Name">The runtime method name (e.g. <c>booleanEquals</c> → <c>Equals</c>).</param>
    /// <param name="IsBoolean">Whether the call is already a boolean (a non-boolean condition is
    /// compared against null, mirroring the rules-engine "truthy" semantics).</param>
    /// <param name="ArgCasts">A per-argument cast (e.g. <c>Partition</c> takes <c>(string)</c>),
    /// applied only to reference and nested-function arguments.</param>
    private sealed record Fn(string Name, bool IsBoolean, string[] ArgCasts);

    private static readonly IReadOnlyDictionary<string, Fn> Functions = new Dictionary<string, Fn>
    {
        ["isSet"] = new("IsSet", IsBoolean: true, ArgCasts: []),
        ["booleanEquals"] = new("Equals", IsBoolean: true, ArgCasts: []),
        ["getAttr"] = new("GetAttr", IsBoolean: false, ArgCasts: []),
        ["aws.partition"] = new("Partition", IsBoolean: false, ArgCasts: ["string"]),
    };

    /// <summary>Emits the compiled rules into <paramref name="writer"/> at its current indent.</summary>
    public static void WriteRules(CodeWriter writer, EndpointRuleSet ruleSet)
    {
        foreach (var rule in ruleSet.Rules)
        {
            WriteRule(writer, rule);
        }
    }

    private static void WriteRule(CodeWriter writer, EndpointRule rule)
    {
        if (rule.Conditions.Count == 0)
        {
            WriteRuleBody(writer, rule);
            return;
        }

        // A rule fires only when all its conditions hold, so they AND together into one if.
        var condition = string.Join(" && ", rule.Conditions.Select(BuildCondition));
        writer.OpenBlock($"if ({condition})", () => WriteRuleBody(writer, rule));
    }

    private static void WriteRuleBody(CodeWriter writer, EndpointRule rule)
    {
        switch (rule.Type)
        {
            case "tree":
                foreach (var subRule in rule.Rules)
                {
                    WriteRule(writer, subRule);
                }
                break;
            case "endpoint":
                var endpoint = rule.Endpoint ?? throw new GeneratorException("Endpoint rule is missing its endpoint definition.");
                writer.WriteLine($"return new Endpoint({BuildUrl(endpoint.Url)}, {BuildJsonTemplate(endpoint.Properties)}, {BuildJsonTemplate(endpoint.Headers)});");
                break;
            case "error":
                var error = rule.Error ?? throw new GeneratorException("Error rule is missing its error message.");
                writer.WriteLine($"throw new AmazonClientException({QuoteOrInterpolate(error)});");
                break;
            default:
                throw new GeneratorException($"Unsupported endpoint rule type '{rule.Type}'.");
        }
    }

    private static string BuildCondition(EndpointCondition condition)
    {
        var call = BuildCall(condition.Fn, condition.Argv);

        // An assigning condition stores its result in refs and is truthy when non-null.
        if (condition.Assign is { } assign)
        {
            return $"(refs[\"{assign}\"] = {call}) != null";
        }

        // A non-boolean call used as a condition is truthy when non-null.
        if (!Functions[condition.Fn].IsBoolean)
        {
            return $"{call} != null";
        }

        return call;
    }

    private static string BuildCall(string fn, IReadOnlyList<JsonElement> argv)
    {
        if (!Functions.TryGetValue(fn, out var spec))
        {
            throw new GeneratorException($"Endpoint rule function '{fn}' is not supported yet.");
        }

        var args = argv.Select((arg, i) => BuildArgument(arg, spec, i));
        return $"{spec.Name}({string.Join(", ", args)})";
    }

    private static string BuildArgument(JsonElement arg, Fn spec, int index)
    {
        switch (arg.ValueKind)
        {
            case JsonValueKind.String:
                return QuoteOrInterpolate(arg.GetString() ?? string.Empty);
            case JsonValueKind.Number:
                return arg.GetRawText();
            case JsonValueKind.True:
                return "true";
            case JsonValueKind.False:
                return "false";
            case JsonValueKind.Object:
                // Only reference and nested-function arguments carry the function's argument cast.
                var cast = index < spec.ArgCasts.Length ? $"({spec.ArgCasts[index]})" : string.Empty;
                if (arg.TryGetProperty("ref", out var reference))
                {
                    return $"{cast}refs[\"{reference.GetString()}\"]";
                }
                if (arg.TryGetProperty("fn", out var nestedFn))
                {
                    return $"{cast}{BuildCall(nestedFn.GetString() ?? string.Empty, ReadArgv(arg))}";
                }
                throw new GeneratorException("Endpoint function argument object has neither a 'ref' nor an 'fn'.");
            default:
                throw new GeneratorException($"Unsupported endpoint function argument of kind '{arg.ValueKind}'.");
        }
    }

    // A URL is a template string, a {"ref": ...}, or a {"fn": ...}; the latter two are cast to string.
    private static string BuildUrl(JsonElement url)
    {
        if (url.ValueKind == JsonValueKind.String)
        {
            return QuoteOrInterpolate(url.GetString() ?? string.Empty);
        }
        if (url.ValueKind == JsonValueKind.Object)
        {
            if (url.TryGetProperty("ref", out var reference))
            {
                return $"(string)refs[\"{reference.GetString()}\"]";
            }
            if (url.TryGetProperty("fn", out var fn))
            {
                return $"(string){BuildCall(fn.GetString() ?? string.Empty, ReadArgv(url))}";
            }
        }
        throw new GeneratorException("Endpoint URL is not a template string, a reference, or a function.");
    }

    // Endpoint properties/headers are JSON templates interpolated at runtime. CloudTrailData leaves
    // both empty; an absent or empty object emits the empty template the existing SDK does.
    private static string BuildJsonTemplate(JsonElement? json)
    {
        if (json is not { } value || IsEmptyObject(value))
        {
            return "InterpolateJson(@\"\", refs)";
        }

        return $"InterpolateJson(@\"{value.GetRawText().Replace("\"", "\"\"")}\", refs)";
    }

    private static bool IsEmptyObject(JsonElement value) => value.ValueKind == JsonValueKind.Object && !value.EnumerateObject().Any();

    private static IReadOnlyList<JsonElement> ReadArgv(JsonElement functionObject) =>
        functionObject.TryGetProperty("argv", out var argv) && argv.ValueKind == JsonValueKind.Array
        ? argv.EnumerateArray().ToList()
        : [];

    // A template (containing "{...}" placeholders) becomes an Interpolate call over a verbatim string;
    // a plain string becomes a C# string literal.
    private static string QuoteOrInterpolate(string value)
    {
        if (value.Contains('{'))
        {
            return $"Interpolate(@\"{value.Replace("\"", "\"\"")}\", refs)";
        }

        return CodeWriter.Literal(value);
    }
}
