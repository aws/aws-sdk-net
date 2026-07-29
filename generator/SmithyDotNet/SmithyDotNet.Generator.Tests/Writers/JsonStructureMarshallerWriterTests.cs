using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class JsonStructureMarshallerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string Namespace = "com.amazonaws.cloudtraildata";

    private readonly string _auditEventMarshaller;

    public JsonStructureMarshallerWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new JsonStructureMarshallerWriter(fixture.Context, ModelFileName);
        _auditEventMarshaller = WriteJsonStructureMarshaller(fixture.Context, writer, "AuditEvent");
    }

    private static string WriteJsonStructureMarshaller(GenerationContext context, JsonStructureMarshallerWriter writer, string shapeName)
    {
        var shapeId = ShapeId.Parse($"{Namespace}#{shapeName}");
        return writer.Write(context.Structures[shapeId], shapeId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void AuditEventMarshaller_EmitsExpectedPublicSurface()
    {
        Assert.Contains("namespace Amazon.CloudTrailData.Model.Internal.MarshallTransformations", _auditEventMarshaller);
        Assert.Contains("using Amazon.CloudTrailData.Model;", _auditEventMarshaller);
        Assert.Contains("public partial class AuditEventMarshaller : IRequestMarshaller<AuditEvent, JsonMarshallerContext>", _auditEventMarshaller);
        Assert.Contains("public void Marshall(AuditEvent requestObject, JsonMarshallerContext context)", _auditEventMarshaller);
        Assert.Contains("public readonly static AuditEventMarshaller Instance = new AuditEventMarshaller();", _auditEventMarshaller);
    }
    [Fact]
    public void AuditEventMarshaller_EmitsExpectedDocumentation()
    {
        Assert.Contains("/// <summary>", _auditEventMarshaller);
        Assert.Contains("/// AuditEvent Marshaller", _auditEventMarshaller);
        Assert.Contains("/// Marshall the structure from the request object to the service", _auditEventMarshaller);
        Assert.Contains("/// Singleton Marshaller", _auditEventMarshaller);
    }

    [Fact]
    public void AuditEventMarshaller_MarshallMethodIsCorrect()
    {
        Assert.Contains("if (requestObject.IsSetEventData())", _auditEventMarshaller);
        Assert.Contains("context.Writer.WritePropertyName(\"eventData\");", _auditEventMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(requestObject.EventData);", _auditEventMarshaller);
        Assert.Contains("if (requestObject.IsSetEventDataChecksum())", _auditEventMarshaller);
        Assert.Contains("context.Writer.WritePropertyName(\"eventDataChecksum\");", _auditEventMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(requestObject.EventDataChecksum);", _auditEventMarshaller);
        Assert.Contains("if (requestObject.IsSetId())", _auditEventMarshaller);
        Assert.Contains("context.Writer.WritePropertyName(\"id\");", _auditEventMarshaller);
        Assert.Contains("context.Writer.WriteStringValue(requestObject.Id);", _auditEventMarshaller);
    }
}
