using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Shapes;

/// <summary>
/// Drives the enum path in the shared codegen model (the DoEnums operation): the
/// <see cref="ServiceEnumerationsWriter"/> emission (ConstantClass declarations, member naming, the
/// <c>Equals</c>/<c>new</c> guard, intEnum exclusion, unreachable-enum collection, the throw on a
/// missing value) plus the marshaller/unmarshaller writers that route an enum member through the
/// string path. Type-mapping is covered by <see cref="Serialization.TypeMapperTests"/>.
/// </summary>
public class EnumCodegenTests
{
    private const string ModelFileName = "enums.json";

    private readonly GenerationContext _context;
    private readonly string _enums;
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;

    public EnumCodegenTests()
    {
        // InstanceType's member KEYS deliberately differ from the generated property names (e.g. AWS ->
        // AmazonWebServices) to prove the writer derives the property name from the smithy.api#enumValue
        // wire value, not the member name. Priority is an intEnum: C2J emits no ConstantClass for it. OrphanExceptionReason is
        // referenced by no operation, proving enum collection scans every model shape, not the reachable set.
        _context = TestModels.Context("Codegen/codegen-model.json");
        _enums = new ServiceEnumerationsWriter(_context, ModelFileName).Write(TestContext.Current.CancellationToken);

        var operation = _context.Operations.Single(o => o.Name == "DoEnums");
        _requestMarshaller = new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void Emission_DeclaresConstantClassPerEnum()
    {
        Assert.Contains("public class Category : ConstantClass", _enums);
        Assert.Contains("public class InstanceType : ConstantClass", _enums);
        Assert.Contains("public class Status : ConstantClass", _enums);
    }

    [Fact]
    public void Emission_NamesPropertiesFromTheWireValueNotTheMemberName()
    {
        Assert.Contains("""public static readonly InstanceType T2Micro = new InstanceType("t2.micro");""", _enums);
        Assert.Contains("""public static readonly InstanceType AmazonWebServices = new InstanceType("amazon-web-services");""", _enums);
        Assert.Contains("""public static readonly InstanceType GENERAL_PURPOSE = new InstanceType("GENERAL_PURPOSE");""", _enums);
        Assert.Contains("""public static readonly InstanceType AB = new InstanceType("a.b");""", _enums);
    }

    [Fact]
    public void Emission_EqualsMemberGetsNewKeyword()
    {
        // A member named Equals must be emitted with `new` so it does not hide object.Equals.
        Assert.Contains("""public new static readonly InstanceType Equals = new InstanceType("Equals");""", _enums);
    }

    [Fact]
    public void Emission_EmitsConstantClassScaffolding()
    {
        Assert.Contains("public InstanceType(string value)", _enums);
        Assert.Contains(": base(value)", _enums);
        Assert.Contains("public static InstanceType FindValue(string value)", _enums);
        Assert.Contains("return FindValue<InstanceType>(value);", _enums);
        Assert.Contains("public static implicit operator InstanceType(string value)", _enums);
        // The constructor must stay documented: the generated service builds with
        // GenerateDocumentationFile + TreatWarningsAsErrors, so an undocumented public member is a
        // CS1591 build error - and these string checks compile the generator, not the emitted service.
        Assert.Contains("Constructs a custom InstanceType for a value", _enums);
    }

    [Fact]
    public void Emission_IntEnumProducesNoConstantClass()
    {
        // C2J emits a ConstantClass only for string enums; an intEnum maps to a plain integer.
        Assert.DoesNotContain("class Priority", _enums);
        Assert.DoesNotContain("new Priority(", _enums);
    }

    [Fact]
    public void Emission_IncludesEnumUnreachableFromAnyOperation()
    {
        // C2J emits a ConstantClass for every model enum shape, reachable or not. Some real models carry
        // orphan *ExceptionReason enums that no operation references (e.g. identitystore,
        // bcm-pricing-calculator), so collection scans all shapes rather than the reachable set.
        Assert.Contains("public class OrphanExceptionReason : ConstantClass", _enums);
    }

    [Fact]
    public void Emission_EnumMemberWithoutValue_Throws()
    {
        // C2J has no value to fall back to, so a member missing smithy.api#enumValue is an error rather
        // than a silent default to the Smithy member name. The bad enum needs its own model — in the
        // shared one it would break every emission test above.
        var context = TestModels.Context("Codegen/enum-missing-value-model.json");
        var writer = new ServiceEnumerationsWriter(context, ModelFileName);
        Assert.Throws<GeneratorException>(() => writer.Write(TestContext.Current.CancellationToken));
    }

    [Fact]
    public void RequestMarshaller_BodyEnum_WritesStringValue()
    {
        Assert.Contains("if (publicRequest.IsSetCategory())", _requestMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(publicRequest.Category);", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_QueryEnum_UsesFromString()
    {
        Assert.Contains("""request.Parameters.Add("status", StringUtils.FromString(publicRequest.Filter));""", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_HeaderEnum_AssignedDirectly()
    {
        // MarshalType is "string", so the enum is assigned directly (implicit ConstantClass->string).
        Assert.Contains("""request.Headers["x-status"] = publicRequest.Tag;""", _requestMarshaller);
    }

    [Fact]
    public void RequestMarshaller_LabelEnum_UsesFromString()
    {
        Assert.Contains("""request.AddPathResource("{kind}", StringUtils.FromString(publicRequest.Kind));""", _requestMarshaller);
    }

    [Fact]
    public void StructureMarshaller_RoutesEnumThroughStringAndIntEnumThroughNumber()
    {
        // A nested structure with an enum member (marshals as a string) and an intEnum member (a plain
        // int). Without MarshalType dispatch the enum member would miss the "string" case and throw.
        var detail = (StructureShape)TestModels.DeserializeShape("""
            { "type": "structure", "members": {
                "state": { "target": "com.example#Status" },
                "rank":  { "target": "com.example#Priority" } } }
            """);
        var marshaller = new JsonStructureMarshallerWriter(_context, ModelFileName)
            .Write(detail, ShapeId.Parse("com.example#Detail"), TestContext.Current.CancellationToken);

        Assert.Contains("context.Writer.WriteStringValue(requestObject.State);", marshaller);
        Assert.Contains("context.Writer.WriteNumberValue(requestObject.Rank.Value);", marshaller);
    }

    [Fact]
    public void ResponseUnmarshaller_Enum_UsesStringUnmarshaller()
    {
        // C2J unmarshals an enum member with StringUnmarshaller, assigning to the ConstantClass member
        // via the implicit string->ConstantClass conversion.
        Assert.Contains("var unmarshaller = StringUnmarshaller.Instance;", _responseUnmarshaller);
        Assert.Contains("unmarshalledObject.ResultStatus = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    [Fact]
    public void ShapeConverter_DeserializesEnumAndIntEnum()
    {
        var enumShape = TestModels.DeserializeShape("""
            { "type": "enum", "members": { "A": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "a-value" } } } }
            """);
        var enumMember = Assert.IsType<EnumShape>(enumShape).Members["A"];
        Assert.Equal("a-value", enumMember.GetEnumValue());

        var intEnum = TestModels.DeserializeShape("""
            { "type": "intEnum", "members": { "ONE": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": 1 } } } }
            """);
        Assert.IsType<IntEnumShape>(intEnum);
    }

    [Fact]
    public void GetEnumValue_OnIntEnumMember_ReturnsNull()
    {
        // An intEnum member's enumValue is an integer; GetStringTrait returns null for a non-string value
        // rather than throwing, so an intEnum member never reads as a string.
        var intEnum = (IntEnumShape)TestModels.DeserializeShape("""
            { "type": "intEnum", "members": { "ONE": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": 1 } } } }
            """);
        Assert.Null(intEnum.Members["ONE"].GetEnumValue());
    }

    [Fact]
    public void GetEnumValue_ReturnsNullWhenTraitAbsent()
    {
        // A member with no enumValue trait yields null; the enum writer then throws (C2J has no value to
        // carry).
        var enumShape = (EnumShape)TestModels.DeserializeShape("""
            { "type": "enum", "members": { "BARE": { "target": "smithy.api#Unit" } } }
            """);
        Assert.Null(enumShape.Members["BARE"].GetEnumValue());
    }
}
