using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class UnsupportedTraitValidatorTests
{
    // unsupported-trait-model.json's @sparse list sits two levels below the operation input
    // (DoThingRequest -> Config -> SparseTagList) - the case the validator used to miss when it only
    // scanned top-level input/output/error members.
    [Fact]
    public void Validate_NestedSparseList_Throws()
    {
        var index = new ServiceIndex(TestModels.Load("Codegen/unsupported-trait-model.json"));

        var ex = Assert.Throws<GeneratorException>(() => UnsupportedTraitValidator.Validate(index));
        Assert.Contains("@sparse", ex.Message);
    }
}
