using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class JsonExceptionUnmarshallerWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string Namespace = "com.amazonaws.cloudtraildata";

    private readonly string _exceptionUnmarshaller;

    public JsonExceptionUnmarshallerWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new JsonExceptionUnmarshallerWriter(fixture.Context, ModelFileName);
        var errorShape = fixture.Context.Errors.Single(e => e.Key.Name == "ChannelInsufficientPermission");
        _exceptionUnmarshaller = writer.Write(errorShape.Value, errorShape.Key);
    }

    [Fact]
    public void ExceptionUnmarshallerClassSignatureIsCorrect()
    {
        AssertHelper("namespace Amazon.CloudTrailData.Model.Internal.MarshallTransformations");
        AssertHelper("public partial class ChannelInsufficientPermissionExceptionUnmarshaller : IJsonErrorResponseUnmarshaller<ChannelInsufficientPermissionException, JsonUnmarshallerContext>");
    }

    [Fact]
    public void ExceptionUnmarshallerClassSummaryIsCorrect()
    {
        AssertHelper("/// <summary>");
        AssertHelper("/// Exception Unmarshaller for ChannelInsufficientPermissionException");
        AssertHelper("/// </summary>");
    }

    [Fact]
    public void ExceptionUnmarshallMethodIsCorrect()
    {
        AssertHelper("public ChannelInsufficientPermissionException Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)");
        AssertHelper("return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse(), ref reader);");
        AssertHelper("/// <summary>");
        AssertHelper("/// Unmarshall the exception from the service to the appropriate exception class");
        AssertHelper("/// </summary>");
    }

    [Fact]
    public void MainExceptionUnmarshallMethodIsCorrect()
    {
        AssertHelper("public ChannelInsufficientPermissionException Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)");
        AssertHelper("if (context.Stream.Length > 0)");
        AssertHelper("context.Read(ref reader);");
        AssertHelper("ChannelInsufficientPermissionException unmarshalledObject = new ChannelInsufficientPermissionException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);");
        AssertHelper("int targetDepth = context.CurrentDepth;");
        AssertHelper("if (context.Stream.Length > 0)");
        AssertHelper("while (context.ReadAtDepth(targetDepth, ref reader))");
        AssertHelper("return unmarshalledObject;");
    }

    [Fact]
    public void SingletonIsCorrect()
    {
        AssertHelper("private static ChannelInsufficientPermissionExceptionUnmarshaller _instance = new ChannelInsufficientPermissionExceptionUnmarshaller();");
        AssertHelper("public static ChannelInsufficientPermissionExceptionUnmarshaller Instance => _instance;");
        AssertHelper("/// <summary>");
        AssertHelper("/// Gets the singleton.");
        AssertHelper("/// </summary>");
    }

    [Fact]
    public void UsingsAreCorrect()
    {
        AssertHelper("using Amazon.CloudTrailData.Model;");
        AssertHelper("using Amazon.Runtime;");
        AssertHelper("using Amazon.Runtime.Internal;");
        AssertHelper("using Amazon.Runtime.Internal.Transform;");
        AssertHelper("using Amazon.Runtime.Internal.Util;");
        AssertHelper("using System.Text.Json;");
        AssertHelper("using Amazon.Util;");
        AssertHelper("#pragma warning disable CS0612,CS0618");
        AssertHelper("using System;");
        AssertHelper("using System.Collections.Generic;");
        AssertHelper("using System.Globalization;");
        AssertHelper("using System.IO;");
        AssertHelper("using System.Net;");
        AssertHelper("using System.Text;");
        AssertHelper("using System.Xml.Serialization;");
    }

    private void AssertHelper(string content)
    {
        Assert.Contains(content, _exceptionUnmarshaller);
    }
}

