using SmithyDotNet.Generator.Generation;
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

        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index));
        Assert.Contains("@sparse (list of collections)", ex.Message);
    }

    // Event-stream codegen is only proven for restJson1; a @streaming union on any other protocol
    // fails loud until that protocol verifies its own event-stream path.
    [Fact]
    public void Validate_EventStreamOnNonRestJson1Service_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));

        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index));
        Assert.Contains("@streaming (event stream)", ex.Message);
    }

    [Fact]
    public void Validate_EndpointDiscovery_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));
        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index));
        Assert.Contains("clientEndpointDiscovery", ex.Message);
    }

    [Fact]
    public void Validate_EventStreamOnRestJson1Service_DoesNotThrow()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/event-stream-restjson1-model.json"));

        UnsupportedTraitValidator.Validate(index);
    }
}
