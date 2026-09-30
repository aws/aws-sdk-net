using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Protocols;
using SmithyDotNet.Generator.Model;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class UnsupportedTraitValidatorTests
{
    // A @sparse list of collections would marshal with a foreach over a possibly-null element;
    // the validator rejects it up front (unsupported-trait-model.json's SparseMatrix list of Row).
    [Fact]
    public void Validate_SparseListOfCollections_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));

        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, AWSProtocol.AwsJson1_0));
        Assert.Contains("@sparse (list of collections)", ex.Message);
    }

    // Event-stream codegen is only proven for restJson1; a @streaming union on any other protocol
    // fails loud until that protocol verifies its own event-stream path.
    [Fact]
    public void Validate_EventStreamOnNonRestJson1Service_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));

        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, AWSProtocol.AwsJson1_0));
        Assert.Contains("@streaming (event stream)", ex.Message);
    }

    // The discovery marshaller doesn't pass discovery ids yet (unsupported-trait-model.json's DoThingRequest.tableName).
    [Fact]
    public void Validate_EndpointDiscoveryId_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));
        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, AWSProtocol.AwsJson1_0));
        Assert.Contains("clientEndpointDiscoveryId", ex.Message);
    }

    [Fact]
    public void Validate_DocumentOnRpcV2CborService_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/rpcv2cbor-model.json"));
        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, AWSProtocol.RpcV2Cbor));
        Assert.Contains("document (rpcv2Cbor)", ex.Message);
    }

    [Fact]
    public void Validate_StreamingBlobOnRpcV2CborService_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/payload-model.json"));
        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, AWSProtocol.RpcV2Cbor));
        Assert.Contains("@streaming (blob, rpcv2Cbor)", ex.Message);
    }

    [Fact]
    public void Validate_DocumentOnRestJson1Service_DoesNotThrow()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/document-model.json"));
        UnsupportedTraitValidator.Validate(index, AWSProtocol.RestJson1);
    }

    [Fact]
    public void Validate_EventStreamOnRestJson1Service_DoesNotThrow()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/event-stream-restjson1-model.json"));

        UnsupportedTraitValidator.Validate(index, AWSProtocol.RestJson1);
    }
}
