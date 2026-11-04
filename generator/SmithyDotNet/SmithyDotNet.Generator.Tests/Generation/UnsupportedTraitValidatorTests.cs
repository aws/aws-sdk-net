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

    // The discovery marshaller doesn't pass discovery ids yet (unsupported-trait-model.json's DoThingRequest.tableName).
    [Fact]
    public void Validate_EndpointDiscoveryId_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));
        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, AWSProtocol.AwsJson1_0));
        Assert.Contains("clientEndpointDiscoveryId", ex.Message);
    }

    [Theory]
    [InlineData("rpcv2cbor-model.json", AWSProtocol.RpcV2Cbor, "document (rpcv2Cbor)")]
    [InlineData("document-model.json", AWSProtocol.RestXml, "document (restXml)")]
    [InlineData("document-model.json", AWSProtocol.AwsQuery, "document (awsQuery)")]
    [InlineData("document-model.json", AWSProtocol.Ec2Query, "document (ec2Query)")]
    public void Validate_Document_Throws(string model, AWSProtocol protocol, string expected)
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/" + model));
        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, protocol));
        Assert.Contains(expected, ex.Message);
    }

    // awsQuery and ec2Query have no streaming of any kind, so an event stream (a @streaming union) is rejected too.
    [Theory]
    [InlineData("payload-model.json", AWSProtocol.RpcV2Cbor, "@streaming (blob, rpcv2Cbor)")]
    [InlineData("payload-model.json", AWSProtocol.AwsQuery, "@streaming (blob, awsQuery)")]
    [InlineData("event-stream-restjson1-model.json", AWSProtocol.AwsQuery, "@streaming (event stream, awsQuery)")]
    [InlineData("payload-model.json", AWSProtocol.Ec2Query, "@streaming (blob, ec2Query)")]
    [InlineData("event-stream-restjson1-model.json", AWSProtocol.Ec2Query, "@streaming (event stream, ec2Query)")]
    public void Validate_Streaming_Throws(string model, AWSProtocol protocol, string expected)
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/" + model));
        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index, protocol));
        Assert.Contains(expected, ex.Message);
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
