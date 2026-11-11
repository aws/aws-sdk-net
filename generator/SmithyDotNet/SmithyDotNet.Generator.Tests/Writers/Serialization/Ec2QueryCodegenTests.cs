using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Writers.Serialization;
using SmithyDotNet.Generator.Writers.Service;
using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Serialization;

// ec2Query: the awsQuery request with EC2's parameter names and flattened lists, and an XML response with the
// output members directly under {Op}Response (no Result element, no ResponseMetadata).
public class Ec2QueryCodegenTests
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private static readonly GenerationContext Context = TestModels.Context("Codegen/ec2-model.json");

    // The EC2-only hooks, each set up the way ec2.customizations.json uses it.
    private static readonly GenerationContext HooksContext = CreateHooksContext();

    private static GenerationContext CreateHooksContext()
    {
        var customizations = new CustomizationsModel();
        customizations.ShapeSubstitutions["AttributeValue"] = new ShapeSubstitution { EmitAsShape = "String", EmitFromMember = "Value", ListMemberSuffixExclusions = ["PutThing"] };
        customizations.ShapeSubstitutions["SpotSpec"] = new ShapeSubstitution { EmitAsShape = "Spec" };

        var spec = TestCustomizations.RenameMember("Groups", "AllGroups");
        TestCustomizations.Inject("Groups", new PropertyInjector { Shape = "NameList", LocationName = "group", Documentation = "The group names." }, spec);
        customizations.ShapeModifiers["Spec"] = spec;

        // Applies only while DoThing's SpotSpec member is marshalled as a Spec.
        var spotSpec = TestCustomizations.Modify("Groups", new PropertyModifier { EmitPropertyName = "AllGroups", CustomMarshall = true });
        TestCustomizations.Modify("Kind", new PropertyModifier { LocationName = "type" }, spotSpec);
        TestCustomizations.Inject("Groups", new PropertyInjector { Shape = "NameList", CustomMarshall = true }, spotSpec);
        customizations.ShapeModifiers["SpotSpec"] = spotSpec;

        var values = new Dictionary<string, MarshallNameOverride>();
        values["Values"] = new MarshallNameOverride { MarshallName = "value" };
        var overrides = new Dictionary<string, Dictionary<string, MarshallNameOverride>>();
        overrides["PutThingRequest"] = values;
        customizations.OperationModifiers["PutThing"] = new OperationModifier { MarshallNameOverrides = [overrides] };

        return TestModels.Context(TestModels.Load("Codegen/ec2-model.json"), customizations);
    }

    private static string RequestMarshaller(string operationName) => RequestMarshaller(Context, operationName);

    private static string RequestMarshaller(GenerationContext context, string operationName) =>
        new QueryRequestMarshallerWriter(context, ModelFileName)
            .Write(context.Operations.Single(o => o.Name == operationName), TestContext.Current.CancellationToken);

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

    // The wrapper itself is not emitted; a member or list of it is typed as its value.
    [Fact]
    public void RequestClass_UnwrappedValuesAreTheValueType()
    {
        var source = new OperationWriter(HooksContext, ModelFileName)
            .WriteRequest(HooksContext.Operations.Single(o => o.Name == "DoThing"), TestContext.Current.CancellationToken);

        Assert.Contains("public string Wrapped { get; set; }", source);
        Assert.Contains("public List<string> Values { get; set; }", source);
        Assert.DoesNotContain(ShapeId.Parse("com.example#AttributeValue"), HooksContext.Structures.Keys);
    }

    [Fact]
    public void Request_UnwrappedValueKeepsItsWrapperElement()
    {
        var source = RequestMarshaller(HooksContext, "DoThing");

        Assert.Contains("""request.Parameters.Add("Wrapped.Value", StringUtils.FromString(publicRequest.Wrapped));""", source);
        Assert.Contains("""request.Parameters.Add("Values" + "." + index0 + ".Value", StringUtils.FromString(item0));""", source);
    }

    // PutThing both renames its Values (upper-cased, as C2J does) and drops the item suffix.
    [Fact]
    public void Request_OperationOverridesNameAndDropsListSuffix()
    {
        Assert.Contains("""request.Parameters.Add("Value" + "." + index0, StringUtils.FromString(item0));""", RequestMarshaller(HooksContext, "PutThing"));
    }

    [Fact]
    public void Request_SubstitutedStructureUsesTheOldNamesModifiers()
    {
        var source = RequestMarshaller(HooksContext, "DoThing");

        Assert.Contains("""request.Parameters.Add("Spec" + ".Type", StringUtils.FromString(publicRequest.Spec.Kind));""", source);
        Assert.DoesNotContain("AllGroups", source);
        Assert.DoesNotContain("publicRequest.Spec.Groups", source);
    }

    [Fact]
    public void Response_UnwrappedValueIsReadInsideItsWrapperElement()
    {
        var source = ResponseUnmarshaller(HooksContext, "DoThing");

        Assert.Contains("""if (context.TestExpression("wrapped/value", targetDepth))""", source);
        Assert.Contains("""if (context.TestExpression("values/item/value", targetDepth))""", source);
    }

    // The injected Groups takes the name, so the modeled one moves to AllGroups and keeps its groups element.
    [Fact]
    public void StructureUnmarshaller_ReadsInjectedAndRenamedMembers()
    {
        var source = new XmlStructureUnmarshallerWriter(HooksContext, ModelFileName)
            .Write(HooksContext.Structures[ShapeId.Parse("com.example#Spec")], TestContext.Current.CancellationToken);

        Assert.Contains("""if (context.TestExpression("group/GroupName", targetDepth))""", source);
        Assert.Contains("""if (context.TestExpression("groups/item", targetDepth))""", source);
        Assert.Contains("unmarshalledObject.AllGroups.Add(", source);
        // SpotSpec's locationName renames Kind in requests only.
        Assert.Contains("""if (context.TestExpression("kind", targetDepth))""", source);
    }

    [Fact]
    public void StructureClass_HasInjectedAndRenamedMembers()
    {
        var source = new StructureWriter(HooksContext, ModelFileName)
            .Write(HooksContext.Structures[ShapeId.Parse("com.example#Spec")], TestContext.Current.CancellationToken);

        Assert.Contains("Gets and sets the property Groups. The group names.", source);
        Assert.Contains("public List<string> Groups { get; set; }", source);
        Assert.Contains("public List<string> AllGroups { get; set; }", source);
    }
}
