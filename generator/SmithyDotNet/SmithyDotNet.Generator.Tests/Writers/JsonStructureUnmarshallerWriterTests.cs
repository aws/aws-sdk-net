using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class JsonStructureUnmarshallerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string Namespace = "com.amazonaws.cloudtraildata";

    private readonly string _auditEventUnmarshaller;

    public JsonStructureUnmarshallerWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new JsonStructureUnmarshallerWriter(fixture.Context, ModelFileName);
        _auditEventUnmarshaller = WriteJsonStructureUnmarshaller(fixture.Context, writer, "AuditEventResultEntry");
    }

    private static string WriteJsonStructureUnmarshaller(GenerationContext context, JsonStructureUnmarshallerWriter writer, string shapeName)
    {
        var shapeId = ShapeId.Parse($"{Namespace}#{shapeName}");
        return writer.Write(context.Structures[shapeId], shapeId, TestContext.Current.CancellationToken);
    }

    [Fact]
    public void UnmarshallerHasCorrectSignature()
    {
        Assert.Contains("public partial class AuditEventResultEntryUnmarshaller : IJsonUnmarshaller<AuditEventResultEntry, JsonUnmarshallerContext>", _auditEventUnmarshaller);
    }

    [Fact]
    public void UnmarshallerContainsCorrectNamespaceAndUsings()
    {
        Assert.Contains("namespace Amazon.CloudTrailData.Model.Internal.MarshallTransformations", _auditEventUnmarshaller);
        Assert.Contains("using System.Text.Json;", _auditEventUnmarshaller);
        Assert.Contains("using Amazon.Runtime.Internal.Util;", _auditEventUnmarshaller);
        Assert.Contains("using Amazon.Runtime.Internal.Transform;", _auditEventUnmarshaller);
        Assert.Contains("using Amazon.Runtime.Internal;", _auditEventUnmarshaller);
        Assert.Contains("using Amazon.Runtime;", _auditEventUnmarshaller);
        Assert.Contains("using Amazon.CloudTrailData.Model", _auditEventUnmarshaller);
        Assert.Contains("#pragma warning disable CS0612,CS0618", _auditEventUnmarshaller);
    }

    [Fact]
    public void UnmarshallerContainsProperUnmarshallMethodAndComments()
    {
        Assert.Contains("/// <summary>", _auditEventUnmarshaller);
        Assert.Contains("/// Unmarshall the response from the service to the response class", _auditEventUnmarshaller);
        Assert.Contains("/// </summary>", _auditEventUnmarshaller);
        Assert.Contains("/// <returns>The unmarshalled object</returns>", _auditEventUnmarshaller);
        Assert.Contains("public AuditEventResultEntry Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)", _auditEventUnmarshaller);
    }

    [Fact]
    public void UnmarshallMethodContentsContainsCorrectPrelude()
    {
        Assert.Contains("AuditEventResultEntry unmarshalledObject = new AuditEventResultEntry();", _auditEventUnmarshaller);
        Assert.Contains("if (context.IsEmptyResponse) return null;", _auditEventUnmarshaller);
        Assert.Contains("context.Read(ref reader);", _auditEventUnmarshaller);
        Assert.Contains("if (context.CurrentTokenType == JsonTokenType.Null) return null;", _auditEventUnmarshaller);
        Assert.Contains("int targetDepth = context.CurrentDepth;", _auditEventUnmarshaller);
    }

    [Fact]
    public void UnmarshallMethodContainsCorrectReadLogic()
    {
        Assert.Contains("while (context.ReadAtDepth(targetDepth, ref reader))", _auditEventUnmarshaller);
        Assert.Contains("if (context.TestExpression(\"eventID\", targetDepth, ref reader))", _auditEventUnmarshaller);
        Assert.Contains("var unmarshaller = StringUnmarshaller.Instance;", _auditEventUnmarshaller);
        Assert.Contains("unmarshalledObject.EventID = unmarshaller.Unmarshall(context, ref reader);", _auditEventUnmarshaller);
        Assert.Contains("continue;", _auditEventUnmarshaller);
        Assert.Contains("if (context.TestExpression(\"id\", targetDepth, ref reader))", _auditEventUnmarshaller);
        Assert.Contains("var unmarshaller = StringUnmarshaller.Instance;", _auditEventUnmarshaller);
        Assert.Contains("unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);", _auditEventUnmarshaller);
        Assert.Contains("continue;", _auditEventUnmarshaller);
        Assert.Contains("return unmarshalledObject;", _auditEventUnmarshaller);
    }

    [Fact]
    public void UnmarshallContainsInstance()
    {
        Assert.Contains("/// <summary>", _auditEventUnmarshaller);
        Assert.Contains("/// Gets the singleton", _auditEventUnmarshaller);
        Assert.Contains("/// </summary>", _auditEventUnmarshaller);
        Assert.Contains("private static AuditEventResultEntryUnmarshaller _instance = new AuditEventResultEntryUnmarshaller();", _auditEventUnmarshaller);
        Assert.Contains("public static AuditEventResultEntryUnmarshaller Instance => return _instance;", _auditEventUnmarshaller);
    }
}
