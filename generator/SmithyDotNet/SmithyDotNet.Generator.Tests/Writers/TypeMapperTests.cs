using System.Text.Json;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

public class TypeMapperTests
{
    private const string Model = """
    {
        "type": "structure",
        "members": {
            "count":       { "target": "test#RangedInt" },
            "secret":      { "target": "test#SecretString" },
            "clientToken": { "target": "smithy.api#String", "traits": { "smithy.api#required": {}, "smithy.api#idempotencyToken": {} } },
            "name":        { "target": "test#BoundedString", "traits": { "smithy.api#required": {} } },
            "legacy":      { "target": "smithy.api#String", "traits": { "smithy.api#deprecated": { "message": "Use name instead", "since": "2024-01-01" } } },
            "legacyBare":  { "target": "smithy.api#String", "traits": { "smithy.api#deprecated": {} } },
            "ratio":       { "target": "test#FractionalRatio" },
            "percent":     { "target": "test#IntegralLiteralPercent" },
            "mixed":       { "target": "test#MixedRatio" },
            "scientific":  { "target": "test#ScientificBound" },
            "plain":       { "target": "smithy.api#String" }
        }
    }
    """;

    private static readonly Dictionary<string, Shape> Targets = new()
    {
        ["test#RangedInt"] = Deserialize("""{ "type": "integer", "traits": { "smithy.api#range": { "min": 1, "max": 1000 } } }"""),
        ["test#SecretString"] = Deserialize("""{ "type": "string", "traits": { "smithy.api#sensitive": {} } }"""),
        ["test#BoundedString"] = Deserialize("""{ "type": "string", "traits": { "smithy.api#length": { "min": 1, "max": 64 } } }"""),
        ["test#FractionalRatio"] = Deserialize("""{ "type": "float", "traits": { "smithy.api#range": { "min": 0.01, "max": 99.99 } } }"""),
        ["test#IntegralLiteralPercent"] = Deserialize("""{ "type": "double", "traits": { "smithy.api#range": { "min": 0.0, "max": 100.0 } } }"""),
        ["test#MixedRatio"] = Deserialize("""{ "type": "double", "traits": { "smithy.api#range": { "min": 0.01, "max": 100 } } }"""),
        ["test#ScientificBound"] = Deserialize("""{ "type": "double", "traits": { "smithy.api#range": { "min": 0, "max": 1E+17 } } }"""),
        ["smithy.api#String"] = new StringShape(),
    };

    private static readonly StructureShape Structure = (StructureShape)Deserialize(Model);

    private static Shape Deserialize(string json) =>
        JsonSerializer.Deserialize<Shape>(json, CloudTrailModelFixture.Options)
        ?? throw new InvalidOperationException("Shape deserialized to null.");

    private static string? AwsProperty(string memberName)
    {
        var member = Structure.Members[memberName];
        return TypeMapper.BuildAwsProperty(member, Targets[member.Target.AbsoluteName]);
    }

    private static string? Obsolete(string memberName)
    {
        var member = Structure.Members[memberName];
        return TypeMapper.BuildObsolete(memberName, member, Targets[member.Target.AbsoluteName]);
    }

    [Fact]
    public void Sensitive_TargetTrait_EmitsSensitive()
    {
        Assert.Equal("[AWSProperty(Sensitive=true)]", AwsProperty("secret"));
    }

    [Fact]
    public void Range_EmitsMinAndMax()
    {
        Assert.Equal("[AWSProperty(Min=1, Max=1000)]", AwsProperty("count"));
    }

    [Fact]
    public void FractionalRange_DoesNotThrowAndSkipsMinMax()
    {
        var result = AwsProperty("ratio");
        Assert.Null(result);
    }

    [Fact]
    public void IntegralLiteralRange_EmitsMinAndMax()
    {
        // Bounds written as decimal literals (0.0 / 100.0) but integral in value still emit, matching
        // the c2j  generator's output (e.g. ECS DrainPercent -> [AWSProperty(Min=0, Max=100)]).
        Assert.Equal("[AWSProperty(Min=0, Max=100)]", AwsProperty("percent"));
    }

    [Fact]
    public void MixedRange_SkipsFractionalBoundEmitsIntegralBound()
    {
        // min 0.01 can't be represented (skipped); max 100 is integral (emitted). Bounds are resolved
        // independently, so a single unrepresentable bound doesn't drop the other.
        Assert.Equal("[AWSProperty(Max=100)]", AwsProperty("mixed"));
    }

    [Fact]
    public void ScientificNotationBound_SkipsToMatchC2j()
    {
        Assert.Equal("[AWSProperty(Min=0)]", AwsProperty("scientific"));
    }

    [Fact]
    public void Length_EmitsMinAndMax()
    {
        Assert.Equal("[AWSProperty(Required=true, Min=1, Max=64)]", AwsProperty("name"));
    }

    [Fact]
    public void IdempotencyToken_SuppressesRequired()
    {
        // @required is present but the member is an idempotency token, so Required is dropped and no
        // other facet applies -> no attribute at all.
        Assert.Null(AwsProperty("clientToken"));
    }

    [Fact]
    public void Deprecated_WithMessage_EmitsObsoleteWithMessage()
    {
        Assert.Equal("[Obsolete(\"Use name instead\")]", Obsolete("legacy"));
    }

    [Fact]
    public void Deprecated_WithoutMessage_Throws()
    {
        Assert.Throws<GeneratorException>(() => Obsolete("legacyBare"));
    }

    [Fact]
    public void NoConstraints_EmitsNothing()
    {
        Assert.Null(AwsProperty("plain"));
        Assert.Null(Obsolete("plain"));
    }

    [Fact]
    public void MultipleFacets_AllEmitted()
    {
        var member = Structure.Members["name"];
        var sensitiveBounded = Deserialize("""{ "type": "string", "traits": { "smithy.api#sensitive": {}, "smithy.api#length": { "min": 2, "max": 8 } } }""");
        var result = TypeMapper.BuildAwsProperty(member, sensitiveBounded);
        Assert.NotNull(result);
        Assert.StartsWith("[AWSProperty(", result);
        Assert.Contains("Required=true", result);
        Assert.Contains("Sensitive=true", result);
        Assert.Contains("Min=2", result);
        Assert.Contains("Max=8", result);
    }

    [Fact]
    public void MapType_Integer_ReturnsNullableInt()
    {
        // Disabling Cannot convert null literal to non-nullable reference type, since we don't really
        // need the context here and it isn't used anywhere in this class.
#pragma warning disable CS8625 
        Assert.Equal("int?", TypeMapper.MapType(ShapeId.Parse("smithy.api#Integer"), new IntegerShape(), context: null));
#pragma warning restore CS8625
    }

    [Fact]
    public void IsSetExpression_NullableValueType_UsesHasValue()
    {
        Assert.Equal("this.Count.HasValue", SimpleScalarMember("Count", "int?").IsSetExpression);
    }

    [Fact]
    public void IsSetExpression_ReferenceType_UsesNullCheck()
    {
        Assert.Equal("this.Plain != null", SimpleScalarMember("Plain", "string").IsSetExpression);
    }

    private static Member SimpleScalarMember(string propertyName, string dotNetType) => new(
        PropertyName: propertyName,
        DotNetType: dotNetType,
        IsCollection: false,
        IsStructure: false,
        IsRequired: false,
        IsElementStructure: false,
        AwsProperty: null,
        Obsolete: null,
        Documentation: string.Empty,
        ModeledName: propertyName);
}
