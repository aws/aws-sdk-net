using System.Text.Json;
using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

public class RichExceptionCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";
    private const string Namespace = "com.example";

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
          "input": { "target": "smithy.api#Unit" },
          "output": { "target": "smithy.api#Unit" },
          "errors": [{ "target": "com.example#ResourceConflict" }],
          "traits": { "smithy.api#http": { "uri": "/things", "method": "POST" } }
        },
        "com.example#ResourceConflict": {
          "type": "structure",
          "members": {
            "message":      { "target": "smithy.api#String" },
            "resourceName": { "target": "smithy.api#String", "traits": { "smithy.api#jsonName": "resource_name" } },
            "attemptCount": { "target": "smithy.api#Integer" },
            "details":      { "target": "com.example#ConflictDetails" },
            "related":      { "target": "com.example#ResourceList" },
            "errorType":    { "target": "smithy.api#String" },
            "equals":       { "target": "smithy.api#String" },
            "retryable":    { "target": "smithy.api#String" },
            "requestId":    { "target": "smithy.api#String" },
            "errorCode":    { "target": "smithy.api#String" }
          },
          "traits": {
            "smithy.api#error": "client",
            "smithy.api#documentation": "The resource is in conflict."
          }
        },
        "com.example#ConflictDetails": {
          "type": "structure",
          "members": {
            "reason": { "target": "smithy.api#String" }
          }
        },
        "com.example#ResourceList": {
          "type": "list",
          "member": { "target": "com.example#RelatedResource" }
        },
        "com.example#RelatedResource": {
          "type": "structure",
          "members": {
            "arn": { "target": "smithy.api#String" }
          }
        }
      }
    }
    """;

    private readonly string _exceptionClass;
    private readonly string _exceptionUnmarshaller;

    public RichExceptionCodegenTests()
    {
        (_exceptionClass, _exceptionUnmarshaller) = Generate(ModelJson, "ResourceConflict");
    }

    private static (string ExceptionClass, string Unmarshaller) Generate(string modelJson, string errorShapeName)
    {
        var model = JsonSerializer.Deserialize<SmithyModel>(modelJson, CloudTrailModelFixture.Options)
            ?? throw new InvalidOperationException("Model deserialized to null.");
        var context = new GenerationContext(new ServiceIndex(model), new SdkVersionManifest
        {
            ServiceVersions = new Dictionary<string, ServiceVersion> { ["Example"] = new() { Version = "4.0.0.0" } },
        });

        var errorId = ShapeId.Parse($"{Namespace}#{errorShapeName}");
        var errorShape = context.Errors[errorId];
        var exceptionClass = new ExceptionWriter(context, ModelFileName)
            .WriteException(errorShape, errorId, TestContext.Current.CancellationToken);
        var unmarshaller = new JsonExceptionUnmarshallerWriter(context, ModelFileName)
            .Write(errorShape, errorId, TestContext.Current.CancellationToken);
        return (exceptionClass, unmarshaller);
    }

    [Fact]
    public void ExceptionClass_EmitsRichMembers()
    {
        Assert.Contains("public partial class ResourceConflictException : AmazonExampleException", _exceptionClass);
        Assert.Contains("public string ResourceName { get; set; }", _exceptionClass);
        Assert.Contains("public int? AttemptCount { get; set; }", _exceptionClass);
        Assert.Contains("public ConflictDetails Details { get; set; }", _exceptionClass);
        Assert.Contains("public List<RelatedResource> Related { get; set; } = AWSConfigs.InitializeCollections ? new List<RelatedResource>() : null;", _exceptionClass);

        Assert.DoesNotContain("IsSetMessage", _exceptionClass);
        Assert.DoesNotContain("public string Message", _exceptionClass);
    }

    [Fact]
    public void ExceptionClass_SerializationRoundTripsRichMembers()
    {
        // The serialization ctor and GetObjectData loop the same members, keyed on the .NET property name
        // (not the wire name) with the member's type token. message is not serialized — the base owns it.
        Assert.Contains("""this.ResourceName = (string)info.GetValue("ResourceName", typeof(string));""", _exceptionClass);
        Assert.Contains("""this.AttemptCount = (int?)info.GetValue("AttemptCount", typeof(int?));""", _exceptionClass);
        Assert.Contains("""this.Details = (ConflictDetails)info.GetValue("Details", typeof(ConflictDetails));""", _exceptionClass);
        Assert.Contains("""this.Related = (List<RelatedResource>)info.GetValue("Related", typeof(List<RelatedResource>));""", _exceptionClass);

        Assert.Contains("""info.AddValue("ResourceName", this.ResourceName);""", _exceptionClass);
        Assert.Contains("""info.AddValue("AttemptCount", this.AttemptCount);""", _exceptionClass);
        Assert.Contains("""info.AddValue("Details", this.Details);""", _exceptionClass);
        Assert.DoesNotContain("""info.AddValue("Message""", _exceptionClass);
    }

    [Fact]
    public void Unmarshaller_DispatchesRichMembers()
    {
        // @jsonName overrides the wire name while the assignment targets the .NET property; a nested
        // structure dispatches to its generated unmarshaller. (Scalar and list-of-structure dispatch ride
        // the shared response-path codegen already covered by ScalarMemberCodegenTests and
        // JsonResponseUnmarshallerWriterTests.)
        Assert.Contains("""if (context.TestExpression("resource_name", targetDepth, ref reader))""", _exceptionUnmarshaller);
        Assert.Contains("var unmarshaller = StringUnmarshaller.Instance;", _exceptionUnmarshaller);
        Assert.Contains("unmarshalledObject.ResourceName = unmarshaller.Unmarshall(context, ref reader);", _exceptionUnmarshaller);

        Assert.Contains("""if (context.TestExpression("details", targetDepth, ref reader))""", _exceptionUnmarshaller);
        Assert.Contains("var unmarshaller = ConflictDetailsUnmarshaller.Instance;", _exceptionUnmarshaller);
        Assert.Contains("unmarshalledObject.Details = unmarshaller.Unmarshall(context, ref reader);", _exceptionUnmarshaller);

        // message is read by JsonErrorResponseUnmarshaller into errorResponse.Message, not in the member loop.
        Assert.DoesNotContain("""TestExpression("message""", _exceptionUnmarshaller);
    }

    [Fact]
    public void ErrorTypeMember_IsRenamedToRequestErrorType_PropertyOnly()
    {
        // Property is renamed to avoid hiding AmazonServiceException.ErrorType.
        Assert.Contains("public string RequestErrorType { get; set; }", _exceptionClass);
        Assert.Contains("""this.RequestErrorType = (string)info.GetValue("RequestErrorType", typeof(string));""", _exceptionClass);
        Assert.Contains("""info.AddValue("RequestErrorType", this.RequestErrorType);""", _exceptionClass);

        // ...but the wire name stays "errorType" and the assignment targets the renamed property.
        Assert.Contains("""if (context.TestExpression("errorType", targetDepth, ref reader))""", _exceptionUnmarshaller);
        Assert.Contains("unmarshalledObject.RequestErrorType = unmarshaller.Unmarshall(context, ref reader);", _exceptionUnmarshaller);
    }

    [Fact]
    public void ShadowingMembers_EmittedWithNewModifier()
    {
        // Members named "equals" or "retryable" collide with inherited members (object.Equals,
        // AmazonServiceException.Retryable) and are emitted with the `new` modifier, matching
        // StructureGenerator.tt (the CloudHSM case). These ride two distinct code paths — Equals is
        // flagged structure-wide in TypeMapper, Retryable is flagged only on the exception path — so we
        // pin both. The "retryable" member is unrelated to the @retryable trait.
        Assert.Contains("public new string Equals { get; set; }", _exceptionClass);
        Assert.Contains("public new string Retryable { get; set; }", _exceptionClass);
    }

    [Fact]
    public void BaseOwnedMembers_NotAProperty_ButStillRoundTripped()
    {
        // RequestId and ErrorCode come from AmazonServiceException, so the derived exception declares no
        // property for them (StructureGenerator.tt skips them to avoid shadowing the base). But C2J's
        // ExceptionShape.Members set — used by ExceptionSerialization.t4 and JsonRPCExceptionUnmarshaller.tt
        // — removes only Message, so the inherited property is still serialized and read from the error
        // body into the base. We match that two-tier behavior.
        foreach (var propertyName in new[] { "RequestId", "ErrorCode" })
        {
            Assert.DoesNotContain($"public string {propertyName} {{ get; set; }}", _exceptionClass);
            Assert.Contains($"""this.{propertyName} = (string)info.GetValue("{propertyName}", typeof(string));""", _exceptionClass);
            Assert.Contains($"""info.AddValue("{propertyName}", this.{propertyName});""", _exceptionClass);
            Assert.Contains($"unmarshalledObject.{propertyName} = unmarshaller.Unmarshall(context, ref reader);", _exceptionUnmarshaller);
        }
    }

    [Fact]
    public void NoRetryableTrait_EmitsNoOverride()
    {
        // The shape carries no @retryable trait (only a member coincidentally named "retryable"), so no
        // RetryableDetails override is emitted — the member surfaces as `public new string Retryable`.
        Assert.DoesNotContain("override RetryableDetails Retryable", _exceptionClass);
    }

    [Fact]
    public void ClassSerializationAndUnmarshaller_AgreeOnMemberSet()
    {
        // The class exposes a property per non-base-owned member (7); the serialization ctor and
        // GetObjectData round-trip every serialized member including base-owned RequestId/ErrorCode (9);
        // and the unmarshaller tests one wire field per serialized member (9). If these drift apart the
        // class and its unmarshaller could silently disagree about which members exist.
        const int properties = 7;
        const int serialized = 9;
        Assert.Equal(properties, Regex.Count(_exceptionClass, @"\{ get; set; \}"));
        Assert.Equal(properties, Regex.Count(_exceptionClass, @"internal bool IsSet"));
        Assert.Equal(serialized, Regex.Count(_exceptionClass, @"info\.GetValue\("));
        Assert.Equal(serialized, Regex.Count(_exceptionClass, @"info\.AddValue\("));
        Assert.Equal(serialized, Regex.Count(_exceptionUnmarshaller, @"context\.TestExpression\("));
    }

    [Theory]
    [InlineData(""" "smithy.api#retryable": { "throttling": true } """, "new RetryableDetails(true)")]
    [InlineData(""" "smithy.api#retryable": { "throttling": false } """, "new RetryableDetails(false)")]
    [InlineData(""" "smithy.api#retryable": {} """, "new RetryableDetails(false)")]
    public void RetryableTrait_EmitsOverride(string retryableTrait, string expectedCtor)
    {
        // A non-null RetryableDetails override marks the exception retryable; the bool is throttling vs
        // plain retryable. An empty @retryable ({}) is retryable but not throttling. Uses a bare shape —
        // the @retryable trait can't coexist with a member named "retryable" (they'd both emit Retryable).
        var (exceptionClass, _) = Generate(BuildRetryableModel(retryableTrait), "Boom");

        Assert.Contains($"public override RetryableDetails Retryable {{ get; }} = {expectedCtor};", exceptionClass);
    }

    // A message-only error shape carrying the given @retryable trait, used only by the trait matrix above.
    private static string BuildRetryableModel(string retryableTrait) => $$"""
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
          "input": { "target": "smithy.api#Unit" },
          "output": { "target": "smithy.api#Unit" },
          "errors": [{ "target": "com.example#Boom" }],
          "traits": { "smithy.api#http": { "uri": "/things", "method": "POST" } }
        },
        "com.example#Boom": {
          "type": "structure",
          "members": { "message": { "target": "smithy.api#String" } },
          "traits": { "smithy.api#error": "client", {{retryableTrait}} }
        }
      }
    }
    """;
}
