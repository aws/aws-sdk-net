using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// ec2Query: the awsQuery request with EC2's parameter names and flattened lists, and an XML response with the
// output members directly under {Op}Response (no Result element, no ResponseMetadata).
public class Ec2QueryCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static readonly GenerationContext Context = TestModels.Context("Codegen/ec2-model.json");

    private static string RequestMarshaller(string operationName) =>
        new QueryRequestMarshallerWriter(Context, ModelFileName)
            .Write(Context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    private static string ResponseUnmarshaller(GenerationContext context, string operationName) =>
        new QueryResponseUnmarshallerWriter(context, ModelFileName)
            .Write(context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

    [Theory]
    [InlineData("customName", "QueryNamed")]
    [InlineData("Renamed", "XmlNamed")]
    [InlineData("Plain", "Plain")]
    public void Request_ParameterNames(string parameter, string property)
    {
        Assert.Contains($"""request.Parameters.Add("{parameter}", StringUtils.FromString(publicRequest.{property}));""", RequestMarshaller("DoThing"));
    }

    [Fact]
    public void Request_ListsDropTheItemSegment()
    {
        Assert.Contains("""request.Parameters.Add("Items" + "." + index0, StringUtils.FromString(item0));""", RequestMarshaller("DoThing"));
    }

    [Fact]
    public void Response_ReadsMembersUnderTheRoot()
    {
        var source = ResponseUnmarshaller(Context, "DoThing");

        Assert.Contains("public partial class DoThingResponseUnmarshaller : EC2ResponseUnmarshaller", source);
        Assert.Contains("targetDepth = 2;", source);
        Assert.Contains("while (context.ReadAtDepth(originalDepth))", source);
        Assert.DoesNotContain("DoThingResult", source);
        Assert.DoesNotContain("ResponseMetadata", source);
    }

    [Theory]
    [InlineData("greeting")]
    [InlineData("resultValue")]
    public void Response_ElementNamesStartLowerCase(string element)
    {
        Assert.Contains($"""if (context.TestExpression("{element}", targetDepth))""", ResponseUnmarshaller(Context, "DoThing"));
    }

    [Fact]
    public void StructureUnmarshaller_ElementNamesStartLowerCase()
    {
        var source = new XmlStructureUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Structures[ShapeId.Parse("com.example#Attachment")], TestContext.Current.CancellationToken);

        Assert.Contains("""if (context.TestExpression("state", targetDepth))""", source);
    }

    [Fact]
    public void Response_MapsAreReadOneEntryAtATime()
    {
        Assert.Contains("""if (context.TestExpression("tags/entry", targetDepth))""", ResponseUnmarshaller(Context, "DoThing"));
    }

    [Fact]
    public void ExceptionUnmarshaller_UsesTheAwsQueryBody()
    {
        var source = new XmlExceptionUnmarshallerWriter(Context, ModelFileName)
            .Write(Context.Errors[ShapeId.Parse("com.example#BadThing")], TestContext.Current.CancellationToken);

        Assert.Contains("return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse());", source);
        Assert.Contains("while (context.ReadAtDepth(originalDepth))", source);
        Assert.Contains("""if (context.TestExpression("reason", targetDepth))""", source);
    }

    [Fact]
    public void Response_ErrorsAreBuiltFromTheEnvelope()
    {
        var source = ResponseUnmarshaller(Context, "DoThing");

        Assert.Contains("""if (errorResponse.Code != null && errorResponse.Code.Equals("BadThing"))""", source);
        Assert.Contains("return new BadThingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);", source);
        Assert.Contains("return new AmazonExampleException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);", source);
        Assert.DoesNotContain("contextCopy", source);
        Assert.DoesNotContain("GetResponseBodyBytes", source);
        Assert.DoesNotContain("errorResponse.InnerException", source);
    }

    [Fact]
    public void Response_WrappedOutputIsReadFromTheWholeBody()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["AttachThing"] = new OperationModifier { UseWrappingResult = true, WrappedResultShape = "Attachment", WrappedResultMember = "Attachment" };
        var context = TestModels.Context(TestModels.Load("Codegen/ec2-model.json"), customizations);

        var source = ResponseUnmarshaller(context, "AttachThing");

        Assert.Contains("""if (context.TestExpression(".", targetDepth))""", source);
        Assert.Contains("unmarshalledObject.Attachment = AttachmentUnmarshaller.Instance.Unmarshall(context);", source);
    }
}
