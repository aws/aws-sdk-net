using System.Text.Json;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers;
using SmithyDotNet.Generator.Writers.Endpoints;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Endpoints;

public class EndpointRulesCompilerTests
{
    // Deserializes the rule-set JSON the way trait deserialization does and compiles it.
    private static string Compile(string ruleSetJson)
    {
        var ruleSet = JsonSerializer.Deserialize<EndpointRuleSet>(ruleSetJson) ?? throw new InvalidOperationException("Rule set JSON deserialized to null.");
        var writer = new CodeWriter();
        EndpointRulesCompiler.WriteRules(writer, ruleSet);
        return writer.ToRawString();
    }

    // Compiles a single error rule guarded by one condition, so the assertions below can read the
    // compiled condition expression back out of the output.
    private static string CompileCondition(string fn, params string[] argvJson) =>
        Compile($$"""
            {
                "rules": [
                    {
                        "type": "error",
                        "conditions": [{"fn": "{{fn}}", "argv": [{{string.Join(", ", argvJson)}}]}],
                        "error": "unused"
                    }
                ]
            }
            """);

    [Fact]
    public void ThrowsOnUnsupportedFunction()
    {
        Assert.Throws<GeneratorException>(() => CompileCondition("aws.isVirtualHostableS3Bucket", """
            "x"
            """));
    }

    [Fact]
    public void EmitsFallbackThrowWhenRuleListIsEmpty()
    {
        var output = Compile("""
            {
                "rules": []
            }
            """);

        Assert.EndsWith("""throw new AmazonClientException("Cannot resolve endpoint");""", output.TrimEnd());
    }

    [Fact]
    public void ThrowsOnUnsupportedRuleType()
    {
        Assert.Throws<GeneratorException>(() => Compile("""
            {
                "rules": [{"type": "magic", "conditions": []}]
            }
            """));
    }

    [Fact]
    public void ThrowsOnFunctionArgumentThatIsNeitherRefNorFn()
    {
        Assert.Throws<GeneratorException>(() => CompileCondition("isSet", "{}"));
    }

    [Fact]
    public void ThrowsOnEndpointUrlThatIsNeitherTemplateRefNorFn()
    {
        Assert.Throws<GeneratorException>(() => Compile("""
            {
                "rules": [{"type": "endpoint", "conditions": [], "endpoint": {"url": {}}}]
            }
            """));
    }

    [Fact]
    public void StringEqualsEmitsEqualsCall()
    {
        var output = CompileCondition("stringEquals", """{"ref": "Region"}""", """
            "us-east-1"
            """);
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

    [Fact]
    public void EmitsFallbackThrowWhenLastRuleIsConditional()
    {
        var output = Compile("""
            {
                "rules": [
                    {
                        "type": "tree",
                        "conditions": [{"fn": "isSet", "argv": [{"ref": "Endpoint"}]}],
                        "rules": [{"type": "error", "conditions": [], "error": "custom endpoint unsupported"}]
                    }
                ]
            }
            """);
        Assert.EndsWith("""throw new AmazonClientException("Cannot resolve endpoint");""", output.TrimEnd());
    }

    [Fact]
    public void OmitsFallbackThrowWhenLastRuleIsUnconditional()
    {
        var output = Compile("""
            {
                "rules": [{"type": "error", "conditions": [], "error": "no endpoint"}]
            }
            """);
        Assert.DoesNotContain("Cannot resolve endpoint", output);
    }
}
