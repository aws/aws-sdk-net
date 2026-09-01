using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class UnsupportedTraitValidatorTests
{
    // unsupported-trait-model.json's @streaming union sits two levels below the operation input
    // (DoThingRequest -> Config -> EventStream) - the depth the validator used to miss when it only
    // scanned top-level input/output/error members.
    [Fact]
    public void Validate_NestedEventStreamUnion_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));

        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index));
        Assert.Contains("@streaming", ex.Message);
    }

    // A @sparse list of collections would marshal with a foreach over a possibly-null element;
    // the validator rejects it up front (unsupported-trait-model.json's SparseMatrix list of Row).
    [Fact]
    public void Validate_SparseListOfCollections_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));

        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index));
        Assert.Contains("@sparse (list of collections)", ex.Message);
    }
}
