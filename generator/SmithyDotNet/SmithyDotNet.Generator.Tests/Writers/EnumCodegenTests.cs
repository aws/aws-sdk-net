using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

/// <summary>
/// Drives the enum path against an inline model: the <see cref="ServiceEnumerationsWriter"/> emission
/// (ConstantClass declarations, member munging, the <c>Equals</c>/<c>new</c> guard, intEnum exclusion,
/// unreachable-enum collection, the throw on a missing value) plus the marshaller/unmarshaller writers
/// that route an enum member through the string path. Type-mapping is covered by <see cref="TypeMapperTests"/>.
/// </summary>
public class EnumCodegenTests
{
    private const string ModelFileName = "enums.json";

    // InstanceType's member KEYS deliberately differ from the munged property names (e.g. AWS ->
    // AmazonWebServices) to prove the writer munges the smithy.api#enumValue wire value, not the
    // member name. Priority is an intEnum: C2J emits no ConstantClass for it. OrphanExceptionReason is
    // referenced by no operation, proving enum collection scans every model shape, not the reachable set.
    private const string ModelJson = """
    {
      "smithy": "2.0",
      "shapes": {
        "com.example#Example": {
          "type": "service",
          "version": "2023-01-01",
          "operations": [{ "target": "com.example#DoThing" }],
          "traits": {
            "aws.api#service": { "sdkId": "Example", "endpointPrefix": "example" },
            "aws.protocols#restJson1": {}
          }
        },
        "com.example#DoThing": {
          "type": "operation",
          "input": { "target": "com.example#DoThingRequest" },
          "output": { "target": "com.example#DoThingResponse" },
          "traits": { "smithy.api#http": { "uri": "/things/{kind}", "method": "POST" } }
        },
        "com.example#DoThingRequest": {
          "type": "structure",
          "members": {
            "kind":     { "target": "com.example#InstanceType", "traits": { "smithy.api#httpLabel": {}, "smithy.api#required": {} } },
            "filter":   { "target": "com.example#Status", "traits": { "smithy.api#httpQuery": "status" } },
            "tag":      { "target": "com.example#Status", "traits": { "smithy.api#httpHeader": "x-status" } },
            "category": { "target": "com.example#Category" },
            "priority": { "target": "com.example#Priority" }
          }
        },
        "com.example#DoThingResponse": {
          "type": "structure",
          "members": {
            "resultStatus": { "target": "com.example#Status" }
          }
        },
        "com.example#InstanceType": {
          "type": "enum",
          "members": {
            "T2MICRO": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "t2.micro" } },
            "AWS":     { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "amazon-web-services" } },
            "EQ":      { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "Equals" } },
            "GP":      { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "GENERAL_PURPOSE" } },
            "AB":      { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "a.b" } }
          }
        },
        "com.example#Status": {
          "type": "enum",
          "members": {
            "ACTIVE":   { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "ACTIVE" } },
            "INACTIVE": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "INACTIVE" } }
          }
        },
        "com.example#Category": {
          "type": "enum",
          "members": {
            "STANDARD": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "STANDARD" } }
          }
        },
        "com.example#Priority": {
          "type": "intEnum",
          "members": {
            "LOW":  { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": 1 } },
            "HIGH": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": 10 } }
          }
        },
        "com.example#OrphanExceptionReason": {
          "type": "enum",
          "members": {
            "UNKNOWN": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "UNKNOWN" } }
          }
        }
      }
    }
    """;

    private readonly GenerationContext _context;
    private readonly string _enums;
    private readonly string _requestMarshaller;
    private readonly string _responseUnmarshaller;

    public EnumCodegenTests()
    {
        _context = BuildContext(ModelJson);
        _enums = new ServiceEnumerationsWriter(_context, ModelFileName).Write(TestContext.Current.CancellationToken);

        var operation = _context.Operations.Single(o => o.Name == "DoThing");
        _requestMarshaller = new JsonRequestMarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
        _responseUnmarshaller = new JsonResponseUnmarshallerWriter(_context, ModelFileName)
            .Write(operation, TestContext.Current.CancellationToken);
    }

    private static GenerationContext BuildContext(string modelJson)
    {
        var model = JsonSerializer.Deserialize<SmithyModel>(modelJson, CloudTrailModelFixture.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        return new GenerationContext(new ServiceIndex(model), new SdkVersionManifest
        {
            ServiceVersions = new Dictionary<string, ServiceVersion> { ["Example"] = new() { Version = "4.0.0.0" } },
        });
    }

    // ---- Emission (ServiceEnumerationsWriter) ------------------------------------------------

    [Fact]
    public void Emission_DeclaresConstantClassPerEnum()
    {
        Assert.Contains("public class Category : ConstantClass", _enums);
        Assert.Contains("public class InstanceType : ConstantClass", _enums);
        Assert.Contains("public class Status : ConstantClass", _enums);
    }

    [Fact]
    public void Emission_MungesTheWireValueNotTheMemberName()
    {
        // Member key "T2MICRO" with enumValue "t2.micro" -> property T2Micro; key "AWS" -> AmazonWebServices.
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
        // than a silent default to the Smithy member name.
        var context = BuildContext("""
        {
          "smithy": "2.0",
          "shapes": {
            "com.example#Svc": {
              "type": "service", "version": "2023-01-01", "operations": [{ "target": "com.example#Op" }],
              "traits": { "aws.api#service": { "sdkId": "Example", "endpointPrefix": "svc" }, "aws.protocols#restJson1": {} }
            },
            "com.example#Op": {
              "type": "operation", "input": { "target": "com.example#OpRequest" }, "output": { "target": "com.example#OpResponse" },
              "traits": { "smithy.api#http": { "uri": "/x", "method": "POST" } }
            },
            "com.example#OpRequest": { "type": "structure", "members": {} },
            "com.example#OpResponse": { "type": "structure", "members": {} },
            "com.example#Bare": { "type": "enum", "members": { "NOVALUE": { "target": "smithy.api#Unit" } } }
          }
        }
        """);
        var writer = new ServiceEnumerationsWriter(context, ModelFileName);
        Assert.Throws<GeneratorException>(() => writer.Write(TestContext.Current.CancellationToken));
    }

    // ---- Marshalling: enum rides the string path ---------------------------------------------

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
        // A nested structure with an enum member (rides the string path) and an intEnum member (a plain
        // int). Without MarshalType dispatch the enum member would miss the "string" case and throw.
        var detail = (StructureShape)Deserialize("""
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
        Assert.Contains("response.ResultStatus = unmarshaller.Unmarshall(context, ref reader);", _responseUnmarshaller);
    }

    // ---- Shape deserialization ----------------------------------------------------------------

    [Fact]
    public void ShapeConverter_DeserializesEnumAndIntEnum()
    {
        var enumShape = Deserialize("""
            { "type": "enum", "members": { "A": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": "a-value" } } } }
            """);
        var enumMember = Assert.IsType<EnumShape>(enumShape).Members["A"];
        Assert.Equal("a-value", enumMember.GetEnumValue());

        var intEnum = Deserialize("""
            { "type": "intEnum", "members": { "ONE": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": 1 } } } }
            """);
        Assert.IsType<IntEnumShape>(intEnum);
    }

    [Fact]
    public void GetEnumValue_OnIntEnumMember_ReturnsNull()
    {
        // An intEnum member's enumValue is an integer; GetStringTrait returns null for a non-string value
        // rather than throwing, so an intEnum member never reads as a string.
        var intEnum = (IntEnumShape)Deserialize("""
            { "type": "intEnum", "members": { "ONE": { "target": "smithy.api#Unit", "traits": { "smithy.api#enumValue": 1 } } } }
            """);
        Assert.Null(intEnum.Members["ONE"].GetEnumValue());
    }

    [Fact]
    public void GetEnumValue_ReturnsNullWhenTraitAbsent()
    {
        // A member with no enumValue trait yields null; the enum writer then throws (C2J has no value to
        // carry).
        var enumShape = (EnumShape)Deserialize("""
            { "type": "enum", "members": { "BARE": { "target": "smithy.api#Unit" } } }
            """);
        Assert.Null(enumShape.Members["BARE"].GetEnumValue());
    }

    private static Shape Deserialize(string json) =>
        JsonSerializer.Deserialize<Shape>(json, CloudTrailModelFixture.Options)
        ?? throw new InvalidOperationException("Shape deserialized to null.");
}
