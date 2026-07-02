using System.Text.Json;
using SmithyDotNet.Generator;
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
                    Conditions = [new EndpointCondition { Fn = "substring", Argv = [Json("\"x\"")] }],
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
}
