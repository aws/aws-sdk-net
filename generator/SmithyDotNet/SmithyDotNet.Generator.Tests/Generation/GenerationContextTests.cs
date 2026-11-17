using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Generation.ProjectFiles;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Traits;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

[Collection(nameof(CloudTrailModelCollection))]
public class GenerationContextTests
{
    private readonly GenerationContext _context;

    public GenerationContextTests(CloudTrailModelFixture fixture)
    {
        _context = fixture.Context;
    }

    [Fact]
    public void Namespace_DerivedFromSdkId()
    {
        Assert.Equal("Amazon.CloudTrailData", _context.Namespace);
    }

    [Fact]
    public void ClientName_DerivedFromSdkId()
    {
        Assert.Equal("AmazonCloudTrailData", _context.ClientName);
    }

    [Fact]
    public void BaseNameAndServiceName_EqualWithoutOverrides()
    {
        Assert.Equal("CloudTrailData", _context.BaseName);
        Assert.Equal("CloudTrailData", _context.ServiceName);
        Assert.Equal("AWSSDK.CloudTrailData", _context.AssemblyName);
    }

    [Fact]
    public void ResolveBaseName_WithoutMetadata_SanitizesSdkId()
    {
        Assert.Equal("CloudTrailData", GenerationContext.ResolveBaseName("CloudTrail Data", null));
    }

    [Fact]
    public void ResolveBaseName_PrefersBaseNameOverride()
    {
        var metadata = new ServiceMetadata { BaseName = "Elasticsearch", LegacyServiceId = "Elasticsearch Service" };
        Assert.Equal("Elasticsearch", GenerationContext.ResolveBaseName("Elasticsearch Service", metadata));
    }

    [Fact]
    public void ResolveBaseName_ThrowsOnEmptyBaseNameOverride()
    {
        var metadata = new ServiceMetadata { BaseName = "" };
        Assert.Throws<GeneratorException>(() => GenerationContext.ResolveBaseName("CloudTrail Data", metadata));
    }

    [Fact]
    public void ResolveBaseName_UsesLegacyServiceIdOverSdkId()
    {
        var metadata = new ServiceMetadata { LegacyServiceId = "Old Service Name" };
        Assert.Equal("OldServiceName", GenerationContext.ResolveBaseName("New Service Name", metadata));
    }

    [Fact]
    public void ResolveServiceName_StripsAmazonPrefixFromNamespaceOverride()
    {
        // sesv2: type names use the base-name, but the folder/package name follows the namespace.
        var metadata = new ServiceMetadata { BaseName = "SimpleEmailServiceV2", Namespace = "Amazon.SimpleEmailV2", LegacyServiceId = "SESv2" };
        Assert.Equal("SimpleEmailServiceV2", GenerationContext.ResolveBaseName("SESv2", metadata));
        Assert.Equal("SimpleEmailV2", GenerationContext.ResolveServiceName("SESv2", metadata));
    }

    [Fact]
    public void ResolveServiceName_WithoutNamespaceOverride_EqualsBaseName()
    {
        var metadata = new ServiceMetadata { LegacyServiceId = "SSO" };
        Assert.Equal("SSO", GenerationContext.ResolveServiceName("SSO", metadata));
    }

    [Fact]
    public void ExtensionDependencies_EmptyForRestJson1()
    {
        Assert.Empty(_context.ExtensionDependencies);
    }

    [Fact]
    public void ExtensionDependencies_CborProtocolForRpcV2Cbor()
    {
        var context = TestModels.Context("Codegen/rpcv2cbor-model.json");
        Assert.Equal(AWSProtocol.RpcV2Cbor, context.Protocol);
        Assert.False(context.UsesHttpBindings);
        Assert.Equal([SdkExtension.CborProtocol], context.ExtensionDependencies);
    }

    [Fact]
    public void Protocol_IsRestJson1()
    {
        Assert.Equal(AWSProtocol.RestJson1, _context.Protocol);
    }

    [Fact]
    public void UseWrappingResult_OutsideAwsJsonRpcV2CborAndEc2Query_Throws()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["GetThing"] = new OperationModifier { UseWrappingResult = true };

        var ex = Assert.Throws<GeneratorException>(() => new GenerationContext(new ServiceIndex(TestModels.Load("Codegen/codegen-model.json")), TestManifests.Example(), customizations: customizations));
        Assert.Contains("operationModifiers['GetThing'] wraps the output, which is only supported for awsJson, rpcv2Cbor and ec2Query.", ex.Message);
    }

    [Theory]
    [InlineData("Codegen/codegen-model.json")]
    [InlineData("Codegen/rpcv2cbor-model.json")]
    public void AllowEmptyResult_OutsideRestXml_Throws(string modelPath)
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["GetThing"] = new OperationModifier { AllowEmptyResult = true };

        var ex = Assert.Throws<GeneratorException>(() => new GenerationContext(new ServiceIndex(TestModels.Load(modelPath)), TestManifests.Example(), customizations: customizations));
        Assert.Contains("operationModifiers['GetThing'] allows an empty result, which is only supported for restXml.", ex.Message);
    }

    [Theory]
    [InlineData("Codegen/codegen-model.json")]
    [InlineData("Codegen/rpcv2cbor-model.json")]
    public void FlattenShapes_OutsideRestXml_Throws(string modelPath)
    {
        var customizations = new CustomizationsModel();
        customizations.FlattenShapes["GetThingRequest"] = ["details"];

        var ex = Assert.Throws<GeneratorException>(() => new GenerationContext(new ServiceIndex(TestModels.Load(modelPath)), TestManifests.Example(), customizations: customizations));
        Assert.Contains("flattenShapes['GetThingRequest'] flattens a payload, which is only supported for restXml.", ex.Message);
    }

    [Fact]
    public void Name_WithoutHttpBindings_Throws()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["GetThing"] = new OperationModifier { Name = "FetchThing" };

        var ex = Assert.Throws<GeneratorException>(() => new GenerationContext(new ServiceIndex(TestModels.Load("Codegen/rpcv2cbor-model.json")), TestManifests.Example(), customizations: customizations));
        Assert.Contains("operationModifiers['GetThing'] renames the operation, which is only supported for restXml and restJson1.", ex.Message);
    }

    [Fact]
    public void Name_OnRestJson1_RenamesOperation()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["DoLists"] = new OperationModifier { Name = "ListThings" };

        var context = new GenerationContext(new ServiceIndex(TestModels.Load("Codegen/codegen-model.json")), TestManifests.Example(), customizations: customizations);
        Assert.Contains(context.Operations, operation => operation.Name == "ListThings" && operation.Shape.Id.Name == "DoLists");
    }

    // SelectThing alone reaches SelectProgress, SelectFailed and the SelectEvents stream; NestedThing is shared with PutThing.
    [Fact]
    public void ClientMethodOnly_KeepsOperation_DropsShapesOnlyItReaches()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["SelectThing"] = new OperationModifier { ClientMethodOnly = true };

        var context = TestModels.Context(TestModels.Load("Codegen/restxml-model.json"), customizations);

        Assert.Contains(context.Operations, operation => operation.Name == "SelectThing");
        Assert.DoesNotContain(context.GeneratedOperations, operation => operation.Name == "SelectThing");
        Assert.Equal(context.Operations.Count - 1, context.GeneratedOperations.Count);
        Assert.Empty(context.ResponseEventStreams);
        Assert.DoesNotContain(context.Structures.Keys, id => id.Name is "SelectProgress" or "SelectEvents" or "RecordsEvent");
        Assert.Contains(context.Structures.Keys, id => id.Name == "NestedThing");
        Assert.DoesNotContain(context.Errors.Keys, id => id.Name == "SelectFailed");
    }

    // C2J still ships a flattened payload's class (S3's Delete, RestoreRequest), though nothing references it.
    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void FlattenedPayloadTarget_KeepsItsClassUnlessExcluded(bool excluded)
    {
        var customizations = new CustomizationsModel();
        customizations.FlattenShapes["GetPayloadResponse"] = ["details"];
        if (excluded)
        {
            customizations.ExcludeShapes.Add("PayloadThing");
        }

        var context = TestModels.Context(TestModels.Load("Codegen/restxml-model.json"), customizations);

        Assert.Equal(!excluded, context.Structures.Keys.Any(id => id.Name == "PayloadThing"));
    }

    [Fact]
    public void ApiVersion_DerivedFromServiceShape()
    {
        Assert.Equal("2021-08-11", _context.ApiVersion);
    }

    [Fact]
    public void EndpointPrefix_DerivedFromAwsServiceTrait()
    {
        Assert.Equal("cloudtrail-data", _context.EndpointPrefix);
    }

    [Fact]
    public void ServiceUid_DerivedFromSdkId_NotEndpointPrefix()
    {
        // sdkId "Example" (slug "example") vs endpointPrefix "svc" -- uid must follow sdkId.
        var context = TestModels.Context("Codegen/enum-missing-value-model.json");
        Assert.Equal("svc", context.EndpointPrefix);
        Assert.Equal("example-2023-01-01", context.ServiceUid);
    }

    [Fact]
    public void ServiceUid_UsesDocIdWhenPresent()
    {
        var context = TestModels.Context("Codegen/service-with-docid-model.json");
        Assert.Equal("monitoring-2010-08-01", context.ServiceUid);
    }

    [Fact]
    public void EndpointContextParams_AreEmptyForCloudTrailData()
    {
        // CloudTrailData uses no context params. If resolution over-fires, the resolver gains
        // per-operation blocks and the config gains properties that C2J never emitted, so guard the
        // common case explicitly.
        Assert.Empty(_context.ClientContextParameters);
        Assert.Empty(_context.OperationEndpointContexts);
    }

    [Fact]
    public void HasEndpointTests_IsTrueForCloudTrailData()
    {
        Assert.True(_context.HasEndpointTests);
        Assert.NotNull(_context.EndpointTests);
        Assert.Equal(21, _context.EndpointTests.TestCases.Count);
    }

    [Fact]
    public void ServiceDocumentation_IsPopulatedFromServiceShape()
    {
        Assert.NotNull(_context.ServiceDocumentation);
        Assert.Contains("CloudTrail Data Service", _context.ServiceDocumentation);
    }

    [Fact]
    public void Operations_ContainsPutAuditEvents()
    {
        var op = Assert.Single(_context.Operations);
        Assert.Equal("PutAuditEvents", op.Name);
    }

    [Fact]
    public void Structures_ExcludesInputOutputAndErrors()
    {
        Assert.Equal(5, _context.Structures.Count);
        Assert.DoesNotContain(_context.Structures.Values, s => s.IsInput());
        Assert.DoesNotContain(_context.Structures.Values, s => s.IsOutput());
        Assert.DoesNotContain(_context.Structures.Values, s => s.IsError());
    }

    [Fact]
    public void Errors_ContainsSixExceptions()
    {
        Assert.Equal(6, _context.Errors.Count);
    }

    [Fact]
    public void Structures_AreOrderedByShapeId()
    {
        var keys = _context.Structures.Keys.Select(id => id.AbsoluteName).ToList();
        Assert.Equal(keys.OrderBy(k => k, StringComparer.Ordinal), keys);
    }

    [Fact]
    public void Errors_AreOrderedByShapeId()
    {
        var keys = _context.Errors.Keys.Select(id => id.AbsoluteName).ToList();
        Assert.Equal(keys.OrderBy(k => k, StringComparer.Ordinal), keys);
    }

    [Fact]
    public void Resolve_ReturnsCorrectShape()
    {
        var id = ShapeId.Parse("com.amazonaws.cloudtraildata#AuditEvent");
        var shape = _context.Resolve(id);
        Assert.NotNull(shape);
    }

    [Fact]
    public void ToDotNetName_ReturnsShapeName()
    {
        var id = ShapeId.Parse("com.amazonaws.cloudtraildata#AuditEvent");
        Assert.Equal("AuditEvent", _context.ToDotNetName(id));
    }

    [Fact]
    public void ToDotNetName_AppliesServiceRename()
    {
        var context = TestModels.Context("Codegen/codegen-model.json");
        Assert.Equal("RenamedResource", context.ToDotNetName(ShapeId.Parse("com.example#RelatedResource")));
        Assert.Equal("ConflictDetails", context.ToDotNetName(ShapeId.Parse("com.example#ConflictDetails")));
    }

    [Fact]
    public void OperationWithUnitInputAndOutput_ResolvesToEmptyStructures()
    {
        // smithy.api#Unit is the modeled form of "no input/output"; it is a prelude shape, so it
        // never appears in the index and must resolve to an empty structure instead of throwing.
        // The fixture model has no Unit operations, so this uses the codegen model's DoConflict,
        // which models both its input and output as Unit.
        var context = TestModels.Context("Codegen/codegen-model.json");

        var operation = context.Operations.Single(o => o.Name == "DoConflict");
        Assert.Empty(operation.Input.Members);
        Assert.Empty(operation.Output.Members);
    }

    [Fact]
    public void OperationErrors_MergeServiceErrors_DedupedAndSortedByName()
    {
        // The model's service declares Throttling/AccessDenied/Validation and GetThing declares
        // ResourceNotFound/Validation: the resolved list is the union (Validation once), in name order.
        var context = TestModels.Context("Codegen/service-errors-model.json");

        var operation = context.Operations.Single(o => o.Name == "GetThing");
        Assert.Equal(
            ["AccessDeniedException", "ResourceNotFoundException", "ThrottlingException", "ValidationException"],
            operation.Errors.Select(e => e.Id.Name));
    }

    // Each pair maps to one class; the shape already named like the class is kept, whichever sorts first.
    [Fact]
    public void Errors_SharingAClassWithAnErrorNamedLikeIt_AreDropped()
    {
        var context = TestModels.Context("Codegen/service-errors-model.json");

        Assert.Contains(ShapeId.Parse("com.example#LimitExceededException"), context.Errors.Keys);
        Assert.DoesNotContain(ShapeId.Parse("com.example#LimitExceededFault"), context.Errors.Keys);
        Assert.Contains(ShapeId.Parse("com.example#MissingException"), context.Errors.Keys);
        Assert.DoesNotContain(ShapeId.Parse("com.example#Missing"), context.Errors.Keys);
    }
}
