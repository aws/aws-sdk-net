using System.Text.Json;
using System.Text.RegularExpressions;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Writers.EndpointDiscovery;
using SmithyDotNet.Generator.Writers.Service;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.EndpointDiscovery;

/// <summary>
/// Pins the endpoint discovery output, which matches C2J's DynamoDB and Timestream files in behaviour. In the model,
/// DescribeEndpoints is the discovery operation and also carries <c>clientDiscoveredEndpoint</c>, which must be
/// ignored; ListThings doesn't use discovery.
/// </summary>
public class EndpointDiscoveryCodegenTests
{
    private const string ModelPath = "Codegen/endpoint-discovery-model.json";
    private const string ModelFileName = "example-2023-01-01.normal.json";

    [Fact]
    public void Marshaller_PinsTheRequiredFlag()
    {
        var context = TestModels.Context(ModelPath);
        var getThing = context.Operations.Single(o => o.Name == "GetThing");

        var source = new EndpointDiscoveryMarshallerWriter(context, ModelFileName).Write(getThing, required: true, TestContext.Current.CancellationToken);

        Assert.Contains("""
            namespace Amazon.Example.Model.Internal.MarshallTransformations
            {
                /// <summary>
                /// Endpoint discovery parameters for GetThing operation
                /// </summary>
                public partial class GetThingEndpointDiscoveryMarshaller : IMarshaller<EndpointDiscoveryDataBase, GetThingRequest>, IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest>
                {
                    /// <summary>
                    /// Marshall the request object to its endpoint discovery data.
                    /// </summary>
                    public EndpointDiscoveryDataBase Marshall(AmazonWebServiceRequest input)
                    {
                        return this.Marshall((GetThingRequest)input);
                    }

                    /// <summary>
                    /// Marshall the request object to its endpoint discovery data.
                    /// </summary>
                    public EndpointDiscoveryDataBase Marshall(GetThingRequest publicRequest)
                    {
                        return new EndpointDiscoveryData(true);
                    }

                    private static GetThingEndpointDiscoveryMarshaller _instance = new GetThingEndpointDiscoveryMarshaller();

                    /// <summary>
                    /// Gets the singleton.
                    /// </summary>
                    public static GetThingEndpointDiscoveryMarshaller Instance => _instance;
                }
            }
            """.ReplaceLineEndings("\n"), source.ReplaceLineEndings("\n"), StringComparison.Ordinal);
    }

    [Fact]
    public void Client_ResolvesEndpointsThroughTheDiscoveryOperation()
    {
        var source = new ClientClassWriter(TestModels.Context(ModelPath), ModelFileName).Write(TestContext.Current.CancellationToken).ReplaceLineEndings("\n");

        Assert.Contains("""
                    protected override IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
                    {
                        return EndpointDiscoveryResolver.ResolveEndpoints(context, () =>
                        {
                            var response = DescribeEndpoints(new DescribeEndpointsRequest());
                            if (response.HttpStatusCode != HttpStatusCode.OK || response.Endpoints == null)
                            {
                                return null;
                            }

                            var endpoints = new List<DiscoveryEndpointBase>();
                            foreach (var endpoint in response.Endpoints)
                            {
                                endpoints.Add(new DiscoveryEndpoint(endpoint.Address, endpoint.CachePeriodInMinutes.GetValueOrDefault()));
                            }

                            return endpoints;
                        });
                    }
            """.ReplaceLineEndings("\n"), source, StringComparison.Ordinal);

        Assert.Contains("""
                        options.ResponseUnmarshaller = GetThingResponseUnmarshaller.Instance;
                        options.EndpointDiscoveryMarshaller = GetThingEndpointDiscoveryMarshaller.Instance;
                        options.EndpointOperation = EndpointOperation;

            """.ReplaceLineEndings("\n"), source, StringComparison.Ordinal);

        // Both sync arms and the async method of each discovered operation, and no other operation.
        string[] wired = ["GetThing", "GetThing", "GetThing", "PutThing", "PutThing", "PutThing"];
        Assert.Equal(wired, Regex.Matches(source, @"options\.EndpointDiscoveryMarshaller = (\w+)EndpointDiscoveryMarshaller\.Instance;").Select(m => m.Groups[1].Value).Order(StringComparer.Ordinal));
        Assert.Equal(wired.Length, Regex.Count(source, Regex.Escape("options.EndpointOperation = EndpointOperation;")));
    }

    private static ServiceShape Service(SmithyModel model) => Assert.IsType<ServiceShape>(model.Shapes["com.example#Example_20230101"]);

    private static GenerationContext CustomizedContext(SmithyModel model, CustomizationsModel customizations)
    {
        CustomizationTransform.Apply(model, customizations);
        return new GenerationContext(new ServiceIndex(model), TestManifests.Example(), customizations: customizations);
    }

    private static string ClientSource(GenerationContext context) =>
        new ClientClassWriter(context, ModelFileName).Write(TestContext.Current.CancellationToken).ReplaceLineEndings("\n");

    // The members are looked up by the names the Smithy spec fixes; a renamed one keeps that name, so the client
    // reads its renamed property.
    [Fact]
    public void Client_RenamedDiscoveryMember_ReadsNewProperty()
    {
        var customizations = new CustomizationsModel
        {
            ShapeModifiers = { ["DescribeEndpointsResponse"] = new ShapeModifier { Modify = [new() { ["Endpoints"] = new PropertyModifier { EmitPropertyName = "EndpointList" } }] } },
        };
        var context = CustomizedContext(TestModels.Load(ModelPath), customizations);

        var source = ClientSource(context);
        Assert.Contains("foreach (var endpoint in response.EndpointList)", source, StringComparison.Ordinal);
        Assert.DoesNotContain("response.Endpoints", source, StringComparison.Ordinal);
    }

    // DiscoveryEndpoint takes (string, long), so a swapped Address or CachePeriodInMinutes would not compile.
    [Theory]
    [InlineData("Address", "System.Uri", "string")]
    [InlineData("CachePeriodInMinutes", "int?", "long?")]
    public void Client_SwappedDiscoveryEndpointMember_Throws(string member, string swappedType, string requiredType)
    {
        var customizations = new CustomizationsModel { DataTypeSwaps = { ["Endpoint"] = new() { [member] = new DataTypeSwap { Type = swappedType } } } };
        var context = CustomizedContext(TestModels.Load(ModelPath), customizations);

        var ex = Assert.Throws<GeneratorException>(() => ClientSource(context));
        Assert.Contains($"'Endpoint.{member}' is '{swappedType}', but must be '{requiredType}'", ex.Message, StringComparison.Ordinal);
    }

    // An h2-only service guards every operation to net8, the discovery operation included (CS0103 otherwise).
    [Fact]
    public void Client_Http2OnlyService_GuardsTheEndpointOperationToNet8()
    {
        var model = TestModels.Load(ModelPath);
        var service = Service(model);
        service.Traits["aws.protocols#awsJson1_0"] = JsonSerializer.SerializeToElement(new { http = new[] { "h2" } });

        var source = new ClientClassWriter(TestModels.Context(model), ModelFileName).Write(TestContext.Current.CancellationToken).ReplaceLineEndings("\n");

        Assert.Matches(@"#if NET8_0_OR_GREATER\n(\s*///.*\n)+\s*protected override IEnumerable<DiscoveryEndpointBase> EndpointOperation\(", source);
        Assert.Matches(@"return endpoints;\n\s*\}\);\n\s*\}\n\s*#endif\n", source);
    }

    [Fact]
    public void Client_WithoutEndpointDiscovery_HasNoEndpointOperation()
    {
        var source = new ClientClassWriter(TestModels.Context("Codegen/awsjson10-model.json"), ModelFileName).Write(TestContext.Current.CancellationToken);

        Assert.DoesNotContain("EndpointOperation", source, StringComparison.Ordinal);
        Assert.DoesNotContain("EndpointDiscoveryMarshaller", source, StringComparison.Ordinal);
    }

    [Fact]
    public void ServiceGenerator_EmitsAMarshallerPerDiscoveredOperation()
    {
        var root = Directory.CreateTempSubdirectory("endpoint-discovery-").FullName;
        try
        {
            var defaultConfigurationModes = DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");
            var generator = new ServiceGenerator(TestModels.Context(ModelPath), ModelFileName, "4.0.0.0", defaultConfigurationModes);
            var written = generator.Generate(Path.Combine(root, "src"), Path.Combine(root, "analysis"), testsOutputPath: null, TestContext.Current.CancellationToken);

            var marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
            string[] expected = [Path.Combine(marshalling, "GetThingEndpointDiscoveryMarshaller.g.cs"), Path.Combine(marshalling, "PutThingEndpointDiscoveryMarshaller.g.cs")];
            Assert.Equal(expected, written.Where(path => path.EndsWith("EndpointDiscoveryMarshaller.g.cs", StringComparison.Ordinal)).Order(StringComparer.Ordinal));
            Assert.Contains("new EndpointDiscoveryData(true);", File.ReadAllText(Path.Combine(root, "src", expected[0])), StringComparison.Ordinal);
            Assert.Contains("new EndpointDiscoveryData(false);", File.ReadAllText(Path.Combine(root, "src", expected[1])), StringComparison.Ordinal);
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [Fact]
    public void DiscoveryOperationWithInputMembers_Throws()
    {
        var model = TestModels.Load(ModelPath);
        var request = Assert.IsType<StructureShape>(model.Shapes["com.example#DescribeEndpointsRequest"]);
        request.Members["Operation"] = new MemberShape { Target = ShapeId.Parse("smithy.api#String") };

        var ex = Assert.Throws<GeneratorException>(() => TestModels.Context(model));
        Assert.Contains("'DescribeEndpoints' has input members, which are not supported yet", ex.Message, StringComparison.Ordinal);
    }

    // Core evicts a cached endpoint only on HTTP 421, so any other discovery error would never refresh it.
    [Fact]
    public void DiscoveryErrorThatIsNotHttp421_Throws()
    {
        var model = TestModels.Load(ModelPath);
        var error = Assert.IsType<StructureShape>(model.Shapes["com.example#InvalidEndpointException"]);
        error.Traits["smithy.api#httpError"] = JsonSerializer.SerializeToElement(400);

        var ex = Assert.Throws<GeneratorException>(() => TestModels.Context(model));
        Assert.Contains("error 'com.example#InvalidEndpointException' is not an HTTP 421 error", ex.Message, StringComparison.Ordinal);
    }

    [Fact]
    public void DiscoveredOperationWithoutServiceDiscovery_Throws()
    {
        var model = TestModels.Load(ModelPath);
        Service(model).Traits.Remove("aws.api#clientEndpointDiscovery");

        var ex = Assert.Throws<GeneratorException>(() => TestModels.Context(model));
        Assert.Contains("has aws.api#clientDiscoveredEndpoint, but the service has no aws.api#clientEndpointDiscovery", ex.Message, StringComparison.Ordinal);
    }

    [Fact]
    public void DiscoveryOperationMissingFromTheService_Throws()
    {
        var model = TestModels.Load(ModelPath);
        var service = Service(model);
        service.Traits["aws.api#clientEndpointDiscovery"] = JsonSerializer.SerializeToElement(new { operation = "com.example#Missing" });

        var ex = Assert.Throws<GeneratorException>(() => TestModels.Context(model));
        Assert.Contains("names operation 'com.example#Missing', which the service does not have", ex.Message, StringComparison.Ordinal);
    }
}
