using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers;
using SmithyDotNet.Generator.Writers.Endpoints;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

/// <summary>
/// The four endpoint context-parameter traits. Expected output is C2J's: the shipping
/// SimpleEmailServiceV2, NeptuneGraph, CloudFrontKeyValueStore and DynamoDB resolvers.
/// </summary>
public class EndpointContextParamsCodegenTests
{
    private const string ModelFileName = "example.json";
    private const string ServiceFileVersion = "4.0.0";

    private readonly GenerationContext _context = TestModels.Context("Codegen/endpoint-context-params-model.json");
    private readonly string _resolver;

    public EndpointContextParamsCodegenTests()
    {
        _resolver = new EndpointResolverWriter(_context, ModelFileName).Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsCommentHeadingTheOperationBlocks()
    {
        Assert.Contains("// Assign staticContextParams and contextParam per operation", _resolver);
    }

    [Fact]
    public void StaticParamsEmitConstantsWithNoRequestCast()
    {
        // NeptuneGraph's form: nothing reads the request, so C2J emits no cast.
        var block = Block("DoStaticOnly");

        Assert.Contains("""result.ApiType = "ControlPlane";""", block);
        Assert.Contains("result.UseControl = true;", block);
        Assert.DoesNotContain("requestContext.OriginalRequest", block);
        Assert.Contains("return result;", block);
    }

    [Fact]
    public void MemberContextParamCastsTheRequestAndReadsTheProperty()
    {
        // SimpleEmailServiceV2's form, verbatim: cast, assignment, return.
        var block = Block("DoContextParam");

        Assert.Contains("var request = (DoContextParamRequest)requestContext.OriginalRequest;", block);
        Assert.Contains("result.EndpointId = request.EndpointId;", block);

        Assert.DoesNotContain("Unrelated", block);
    }

    [Fact]
    public void StaticParamsPrecedeTheRequestCast()
    {
        var block = Block("DoBoth");
        var staticIndex = block.IndexOf("result.ApiType", StringComparison.Ordinal);
        var castIndex = block.IndexOf("var request =", StringComparison.Ordinal);

        Assert.InRange(staticIndex, 0, castIndex);
    }

    [Fact]
    public void OperationContextParamsCompileToTheC2JAccessors()
    {
        // Pinned against the shipping DynamoDB resolver, the only generated output using these.
        var block = Block("DoOperationPath");

        Assert.Contains("result.SimpleArn = request.CreationParameters?.TableName;", block);
        Assert.Contains("result.TableKeys = request.RequestItems?.Keys.ToList();", block);
        Assert.Contains("result.InnerNames = request.TransactItems?.Select(element => element?.Get?.TableName);", block);
        Assert.Contains("result.MapNames = request.ItemsByName?.Values.Select(element => element?.TableName);", block);

        // Each projects strings, so the assignment matches the stringArray parameter it feeds.
        Assert.Contains("result.TerminalList = request.Aliases?.Select(element => element);", block);
        Assert.Contains("result.TerminalMap = request.RequestItems?.Values.Select(element => element);", block);
        Assert.Contains("result.Flattened = request.AliasGroups?.SelectMany(element => element).Where(element => element != null);", block);
        // C2J emits "new [] {"; the Roslyn formatter normalizes it to "new[] {".
        Assert.Contains(
            "result.FlatNames = request.TransactItems?.Select(element => new[] { element?.ConditionCheck?.TableName, element?.Put?.TableName })?.SelectMany(element => element).Where(element => element != null);",
            block);
    }

    [Fact]
    public void OperationWithoutContextParamsGetsNoBlock()
    {
        Assert.DoesNotContain(Guard("DoNothing"), _resolver);
    }

    [Fact]
    public void ClientContextParamsAreAssignedFromConfig()
    {
        Assert.Contains("result.CustomSetting = config.CustomSetting;", _resolver);
        Assert.Contains("result.CustomFlag = config.CustomFlag;", _resolver);
    }

    [Fact]
    public void ClientContextParamsBecomeConfigProperties()
    {
        // C2J types a boolean client context param as a non-nullable bool on the config, even though
        // the same parameter is bool? on the endpoint parameters class.
        var config = new ConfigWriter(_context, ModelFileName, ServiceFileVersion).Write(TestContext.Current.CancellationToken);

        Assert.Contains("/// A custom setting.", config);
        Assert.Contains("public string CustomSetting { get; set; }", config);
        Assert.Contains("/// A custom flag.", config);
        Assert.Contains("public bool CustomFlag { get; set; }", config);
    }

    [Fact]
    public void RejectsAClientContextParamTypeTheSpecDisallows()
    {
        // Narrower than a rule-set parameter, which may also be stringArray.
        var exception = Assert.Throws<GeneratorException>(() => TestModels.Context(ProbeModel(clientParamType: "stringArray")));

        Assert.Contains("only 'string' and 'boolean' are allowed", exception.Message);
    }

    [Fact]
    public void ServiceWithoutContextParamsEmitsNoBlocksOrComment()
    {
        // Emitted only alongside real blocks, so an already-migrated resolver does not churn.
        var context = TestModels.Context("Codegen/hostprefix-model.json");
        Assert.Empty(context.OperationEndpointContexts);
        Assert.Empty(context.ClientContextParameters);
    }

    [Theory]
    // C2J emits ElementAtOrDefault but leaves the shape on the list, so later segments resolve to nothing.
    [InlineData("nested[0]", "array indexing")]
    // C2J puts the SelectMany inside the lambda, yielding a sequence of sequences.
    [InlineData("items[*].name[]", "directly inside a projection")]
    // C2J writes each selection against the projection's lambda variable, which doesn't exist here.
    [InlineData("[nested, items]", "outside a projection")]
    // Paths that don't agree with the model.
    [InlineData("missing.name", "is not on the resolved shape")]
    [InlineData("keys(nested)", "keys() needs a map member")]
    [InlineData("nested[*].name", "needs a list")]
    [InlineData("nested.*.name", "needs a map")]
    public void RejectsAPathItCannotTranslateFaithfully(string path, string expectedMessage)
    {
        var exception = Assert.Throws<GeneratorException>(() => TestModels.Context(ProbeModel(path)));

        Assert.Contains(expectedMessage, exception.Message);
    }

    // A placeholder template rather than an interpolated literal: the JSON is mostly braces. It carries
    // both an operationContextParams path and a clientContextParams entry so one model serves the
    // rejection tests; each substitutes the part it exercises and leaves the other valid.
    private const string ProbeModelTemplate = """
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#Example": {
              "type": "service",
              "version": "2023-01-01",
              "operations": [ { "target": "com.example#Probe" } ],
              "traits": {
                "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
                "aws.protocols#restJson1": {},
                "smithy.rules#clientContextParams": {
                  "Setting": { "type": "__TYPE__", "documentation": "A setting." }
                },
                "smithy.rules#endpointRuleSet": {
                  "version": "1.0",
                  "parameters": { "Setting": { "type": "string", "required": false } },
                  "rules": [
                    {
                      "conditions": [],
                      "type": "endpoint",
                      "endpoint": { "url": "https://example.amazonaws.com" }
                    }
                  ]
                }
              }
            },
            "com.example#Probe": {
              "type": "operation",
              "input": { "target": "com.example#ProbeRequest" },
              "output": { "target": "smithy.api#Unit" },
              "traits": {
                "smithy.api#http": { "uri": "/probe", "method": "POST" },
                "smithy.rules#operationContextParams": { "Target": { "path": "__PATH__" } }
              }
            },
            "com.example#ProbeRequest": {
              "type": "structure",
              "members": {
                "nested": { "target": "com.example#Nested" },
                "items": { "target": "com.example#NestedList" }
              }
            },
            "com.example#NestedList": {
              "type": "list",
              "member": { "target": "com.example#Nested" }
            },
            "com.example#Nested": {
              "type": "structure",
              "members": { "name": { "target": "smithy.api#String" } }
            }
          }
        }
        """;

    private static SmithyModel ProbeModel(string path = "nested.name", string clientParamType = "string")
    {
        var json = ProbeModelTemplate
            .Replace("__PATH__", path)
            .Replace("__TYPE__", clientParamType);

        return JsonSerializer.Deserialize<SmithyModel>(json, TestModels.Options)
            ?? throw new InvalidOperationException("Probe model deserialized to null.");
    }

    // e.g. requestContext.RequestName == "SendEmailRequest"
    private static string Guard(string operationName) =>
        $"requestContext.RequestName == {CodeWriter.Literal($"{operationName}Request")}";

    // The generated block for one operation, from its guard up to the closing return.
    private string Block(string operationName)
    {
        var start = _resolver.IndexOf(Guard(operationName), StringComparison.Ordinal);
        Assert.True(start >= 0, $"No endpoint context block emitted for {operationName}.");

        var end = _resolver.IndexOf("return result;", start, StringComparison.Ordinal);
        return _resolver[start..(end + "return result;".Length)];
    }
}
