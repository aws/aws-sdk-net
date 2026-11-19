using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Shapes;

[Collection(nameof(CloudTrailModelCollection))]
public class ExceptionWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";
    private const string Namespace = "com.amazonaws.cloudtraildata";

    private readonly CloudTrailModelFixture _fixture;
    private readonly string _serviceException;
    private readonly string _channelNotFound;

    public ExceptionWriterTests(CloudTrailModelFixture fixture)
    {
        _fixture = fixture;
        var writer = new ExceptionWriter(fixture.Context, ModelFileName);
        _serviceException = writer.WriteServiceException(TestContext.Current.CancellationToken);
        _channelNotFound = WriteException(fixture.Context, writer, "ChannelNotFound");
    }

    private static string WriteException(GenerationContext context, ExceptionWriter writer, string shapeName)
    {
        var shapeId = ShapeId.Parse($"{Namespace}#{shapeName}");
        return writer.WriteException(context.Errors[shapeId], TestContext.Current.CancellationToken);
    }

    [Fact]
    public void ServiceException_EmitsCorrectClassAndNamespace()
    {
        Assert.Contains("namespace Amazon.CloudTrailData", _serviceException);
        Assert.DoesNotContain("namespace Amazon.CloudTrailData.Model", _serviceException);
        Assert.Contains("public partial class AmazonCloudTrailDataException : AmazonServiceException", _serviceException);
    }

    [Fact]
    public void ServiceException_EmitsSerializableAttribute()
    {
        Assert.Contains("#if !NETSTANDARD", _serviceException);
        Assert.Contains("[Serializable]", _serviceException);
    }

    [Fact]
    public void ServiceException_EmitsSixConstructors()
    {
        Assert.Equal(6, Regex.Count(_serviceException, @"public AmazonCloudTrailDataException\("));
    }

    [Fact]
    public void ServiceException_EmitsSerializationConstructor()
    {
        Assert.Contains("protected AmazonCloudTrailDataException(System.Runtime.Serialization.SerializationInfo info", _serviceException);
    }

    [Fact]
    public void ServiceException_DoesNotEmitGetObjectData()
    {
        Assert.DoesNotContain("GetObjectData", _serviceException);
    }

    [Fact]
    public void OperationException_EmitsExpectedOutput()
    {
        // Should be in "Model" namespace.
        Assert.Contains("namespace Amazon.CloudTrailData.Model", _channelNotFound);

        // Should include class documentation from the model.
        Assert.Contains("The channel could not be found.", _channelNotFound);

        // Should emit overrides for serialization.
        Assert.Contains("public override void GetObjectData(", _channelNotFound);
        Assert.Contains("base.GetObjectData(info, context);", _channelNotFound);
    }

    [Fact]
    public void ToExceptionName_HandlesAllCases()
    {
        Assert.Equal("ChannelNotFoundException", ExceptionWriter.ToExceptionName("ChannelNotFound"));
        Assert.Equal("UnsupportedOperationException", ExceptionWriter.ToExceptionName("UnsupportedOperationException"));
        Assert.Equal("ServiceException", ExceptionWriter.ToExceptionName("ServiceFault"));
        Assert.Equal("MyFaultyException", ExceptionWriter.ToExceptionName("MyFaultyFault"));
    }

    [Fact]
    public void OperationException_WithCustomErrorHandling_TakesIds()
    {
        var customizations = new CustomizationsModel { Service = TestCustomizations.ErrorHandling() };
        var context = new GenerationContext(_fixture.Index, _fixture.Context.Manifest, _fixture.Context.Metadata, customizations);

        var source = WriteException(context, new ExceptionWriter(context, ModelFileName), "ChannelNotFound");

        Assert.Contains("public ChannelNotFoundException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode, string amazonId2, string amazonCfId) : base(message, innerException, errorType, errorCode, requestId, statusCode, amazonId2, amazonCfId) { }", source);
        Assert.DoesNotContain("amazonId2", _channelNotFound);
    }
}
