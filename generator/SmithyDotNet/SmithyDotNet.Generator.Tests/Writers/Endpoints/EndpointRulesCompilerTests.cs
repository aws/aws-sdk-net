using System.Text.Json;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers;
using SmithyDotNet.Generator.Writers.Endpoints;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

public class EndpointRulesCompilerTests
{
    private static JsonElement Json(string raw) => JsonDocument.Parse(raw).RootElement.Clone();

    [Fact]
    public void ThrowsOnUnsupportedFunction()
    {
        var ruleSet = new EndpointRuleSet
        {
            Rules =
            [
                new EndpointRule
                {
                    Type = "error",
                    Conditions = [new EndpointCondition { Fn = "aws.isVirtualHostableS3Bucket", Argv = [Json("\"x\"")] }],
                    Error = "unused",
                },
            ],
        };

        Assert.Throws<GeneratorException>(() => EndpointRulesCompiler.WriteRules(new CodeWriter(), ruleSet));
    }

    [Fact]
    public void ThrowsOnUnsupportedRuleType()
    {
        var ruleSet = new EndpointRuleSet
        {
            Rules = [new EndpointRule { Type = "magic", Conditions = [] }],
        };

        Assert.Throws<GeneratorException>(() => EndpointRulesCompiler.WriteRules(new CodeWriter(), ruleSet));
    }

    [Fact]
    public void ThrowsOnFunctionArgumentThatIsNeitherRefNorFn()
    {
        var ruleSet = new EndpointRuleSet
        {
            Rules =
            [
                new EndpointRule
                {
                    Type = "error",
                    Conditions = [new EndpointCondition { Fn = "isSet", Argv = [Json("{}")] }],
                    Error = "unused",
                },
            ],
        };

        Assert.Throws<GeneratorException>(() => EndpointRulesCompiler.WriteRules(new CodeWriter(), ruleSet));
    }

    [Fact]
    public void ThrowsOnEndpointUrlThatIsNeitherTemplateRefNorFn()
    {
        var ruleSet = new EndpointRuleSet
        {
            Rules =
            [
                new EndpointRule
                {
                    Type = "endpoint",
                    Conditions = [],
                    Endpoint = new EndpointDefinition { Url = Json("{}") },
                },
            ],
        };

        Assert.Throws<GeneratorException>(() => EndpointRulesCompiler.WriteRules(new CodeWriter(), ruleSet));
    }

    // Emits the single error-rule body guarded by one condition, so the assertions below can read the
    // compiled condition expression back out of the writer.
    private static string CompileCondition(string fn, params string[] argvJson)
    {
        var ruleSet = new EndpointRuleSet
        {
            Rules =
            [
                new EndpointRule
                {
                    Type = "error",
                    Conditions = [new EndpointCondition { Fn = fn, Argv = [.. argvJson.Select(Json)] }],
                    Error = "unused",
                },
            ],
        };

        var writer = new CodeWriter();
        EndpointRulesCompiler.WriteRules(writer, ruleSet);
        return writer.ToRawString();
    }

    [Fact]
    public void StringEqualsEmitsEqualsCall()
    {
        var output = CompileCondition("stringEquals", """{"ref": "Region"}""", "\"us-east-1\"");
        Assert.Contains("""if (Equals(refs["Region"], "us-east-1"))""", output);
    }

    [Fact]
    public void NotEmitsNegatedArgument()
    {
        var output = CompileCondition("not", """{"fn": "isSet", "argv": [{"ref": "Region"}]}""");
        Assert.Contains("""if (!IsSet(refs["Region"]))""", output);
    }

    [Fact]
    public void ParseUrlEmitsCastCallTruthyComparedToNull()
    {
        // parseURL is non-boolean, so as a condition it is truthy when non-null; its arg is cast to string.
        var output = CompileCondition("parseURL", """{"ref": "Endpoint"}""");
        Assert.Contains("""if (ParseURL((string)refs["Endpoint"]) != null)""", output);
    }

    [Fact]
    public void ParseArnEmitsCastCallTruthyComparedToNull()
    {
        var output = CompileCondition("aws.parseArn", """{"ref": "Bucket"}""");
        Assert.Contains("""if (ParseArn((string)refs["Bucket"]) != null)""", output);
    }

    [Fact]
    public void IsValidHostLabelEmitsCastArgumentsAsBooleanCall()
    {
        // isValidHostLabel is boolean, so no "!= null"; its args are cast to (string) and (bool).
        var output = CompileCondition("isValidHostLabel", """{"ref": "Region"}""", "false");
        Assert.Contains("""if (IsValidHostLabel((string)refs["Region"], false))""", output);
    }

    [Fact]
    public void SubstringEmitsCastArgumentsTruthyComparedToNull()
    {
        // substring is non-boolean; its args are cast to (string), (int), (int), (bool). Integer
        // literals carry no cast.
        var output = CompileCondition("substring", """{"ref": "Region"}""", "0", "3", "false");
        Assert.Contains("""if (Substring((string)refs["Region"], 0, 3, false) != null)""", output);
    }

    [Fact]
    public void UriEncodeEmitsCastCallTruthyComparedToNull()
    {
        var output = CompileCondition("uriEncode", """{"ref": "Region"}""");
        Assert.Contains("""if (UriEncode((string)refs["Region"]) != null)""", output);
    }
}
