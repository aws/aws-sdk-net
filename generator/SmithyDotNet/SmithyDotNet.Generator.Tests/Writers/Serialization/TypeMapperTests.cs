using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

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
        ["test#RangedInt"] = TestModels.DeserializeShape("""{ "type": "integer", "traits": { "smithy.api#range": { "min": 1, "max": 1000 } } }"""),
        ["test#SecretString"] = TestModels.DeserializeShape("""{ "type": "string", "traits": { "smithy.api#sensitive": {} } }"""),
        ["test#BoundedString"] = TestModels.DeserializeShape("""{ "type": "string", "traits": { "smithy.api#length": { "min": 1, "max": 64 } } }"""),
        ["test#FractionalRatio"] = TestModels.DeserializeShape("""{ "type": "float", "traits": { "smithy.api#range": { "min": 0.01, "max": 99.99 } } }"""),
        ["test#IntegralLiteralPercent"] = TestModels.DeserializeShape("""{ "type": "double", "traits": { "smithy.api#range": { "min": 0.0, "max": 100.0 } } }"""),
        ["test#MixedRatio"] = TestModels.DeserializeShape("""{ "type": "double", "traits": { "smithy.api#range": { "min": 0.01, "max": 100 } } }"""),
        ["test#ScientificBound"] = TestModels.DeserializeShape("""{ "type": "double", "traits": { "smithy.api#range": { "min": 0, "max": 1E+17 } } }"""),
        ["smithy.api#String"] = new StringShape(),
    };

    private static readonly StructureShape Structure = (StructureShape)TestModels.DeserializeShape(Model);

    private readonly GenerationContext _context;

    public TypeMapperTests()
    {
        // The enum type-mapping tests ride the codegen model's DoEnums operation: category is a string
        // enum (maps to its ConstantClass, marshals as a string), priority is an intEnum (maps to int?),
        // and Status stays reachable so it resolves as a collection element target below.
        _context = TestModels.Context("Codegen/codegen-model.json");
    }

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
        Assert.Equal("""[Obsolete("Use name instead")]""", Obsolete("legacy"));
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
        var sensitiveBounded = TestModels.DeserializeShape("""{ "type": "string", "traits": { "smithy.api#sensitive": {}, "smithy.api#length": { "min": 2, "max": 8 } } }""");
        var result = TypeMapper.BuildAwsProperty(member, sensitiveBounded);
        Assert.NotNull(result);
        Assert.StartsWith("[AWSProperty(", result);
        Assert.Contains("Required=true", result);
        Assert.Contains("Sensitive=true", result);
        Assert.Contains("Min=2", result);
        Assert.Contains("Max=8", result);
    }

    [Theory]
    [InlineData("boolean", "bool?")]
    [InlineData("integer", "int?")]
    [InlineData("long", "long?")]
    [InlineData("float", "float?")]
    [InlineData("double", "double?")]
    [InlineData("timestamp", "DateTime?")]
    public void MapScalar_SupportedScalars_MapToNullableValueTypes(string smithyType, string expected)
    {
        var shape = TestModels.DeserializeShape($$"""{ "type": "{{smithyType}}" }""");
        Assert.Equal(expected, TypeMapper.MapScalar(shape));
    }

    // MapScalar only maps the primitive value scalars and timestamp above. Everything else returns
    // null: string maps via a dedicated path, aggregates are never scalars, and the remaining scalars
    // are not supported yet (MapType throws for them).
    [Theory]
    [InlineData("""{ "type": "byte" }""")]
    [InlineData("""{ "type": "short" }""")]
    [InlineData("""{ "type": "bigInteger" }""")]
    [InlineData("""{ "type": "bigDecimal" }""")]
    [InlineData("""{ "type": "blob" }""")]
    [InlineData("""{ "type": "document" }""")]
    [InlineData("""{ "type": "string" }""")]
    [InlineData("""{ "type": "structure", "members": {} }""")]
    public void MapScalar_NonValueScalars_ReturnNull(string json)
    {
        Assert.Null(TypeMapper.MapScalar(TestModels.DeserializeShape(json)));
    }

    [Fact]
    public void EnumMember_MapsToConstantClass_IntEnumMapsToInt()
    {
        var request = _context.Operations.Single(o => o.Name == "DoEnums").Input;
        var members = TypeMapper.ResolveMembers(request, _context);

        var category = members.Single(m => m.ModeledName == "category");
        Assert.Equal("Category", category.Type.DotNetType);
        Assert.True(category.Type.IsEnum);
        Assert.Equal("string", category.Type.MarshalType);

        var priority = members.Single(m => m.ModeledName == "priority");
        Assert.Equal("int?", priority.Type.DotNetType);
        Assert.False(priority.Type.IsEnum);
    }

    [Fact]
    public void BlobMember_MapsToMemoryStream_AndIsNotScalar()
    {
        var blob = TestModels.DeserializeShape("""{ "type": "blob" }""");
        Assert.Equal("MemoryStream", TypeMapper.MapType(ShapeId.Parse("test#Body"), blob, _context));

        // Through a member, the TypeDescriptor flags a blob so it stays off the scalar (un)marshal paths.
        var context = TestModels.Context("Codegen/payload-model.json");
        var op = context.Operations.Single(o => o.Name == "DoBlobPayload");
        var body = TypeMapper.ResolveMembers(op.Input, context).Single(m => m.ModeledName == "body");
        Assert.Equal("MemoryStream", body.Type.DotNetType);
        Assert.True(body.Type.IsBlob);
        Assert.False(body.Type.IsScalar);
    }

    [Theory]
    [InlineData("com.example#Status")]   // string enum element
    [InlineData("com.example#Priority")] // intEnum element
    [InlineData("smithy.api#Integer")]   // value-type element
    public void UnsupportedCollectionElement_Throws(string elementTarget)
    {
        // The marshaller writers only route string and structure list elements; an enum element would
        // map to its ConstantClass and a value-type element to a primitive, neither of which
        // WriteListElement can emit. MapType must fail loud here rather than mapping the type and
        // blowing up deep in the writer.
        var list = TestModels.DeserializeShape($$"""{ "type": "list", "member": { "target": "{{elementTarget}}" } }""");
        var id = ShapeId.Parse("com.example#EnumList");
        Assert.Throws<GeneratorException>(() => TypeMapper.MapType(id, list, _context));
    }

    [Fact]
    public void ResolveMembers_EqualsMember_FlaggedToHideBaseMember()
    {
        // A member named "equals" collides with object.Equals on EVERY structure, not just exceptions, so
        // ResolveMembers flags it shape-agnostically; siblings are untouched. The emitted `new` keyword is
        // covered by RichExceptionCodegenTests.ShadowingMembers_EmittedWithNewModifier — this pins the flag
        // that feeds it, and is the only coverage of the non-exception path.
        var context = TestModels.Context("Codegen/codegen-model.json");
        var op = context.Operations.Single(o => o.Name == "DoShadow");
        var members = TypeMapper.ResolveMembers(op.Input, context);

        Assert.True(members.Single(m => m.PropertyName == "Equals").HidesBaseMember);
        Assert.False(members.Single(m => m.PropertyName == "Name").HidesBaseMember);
    }
}
