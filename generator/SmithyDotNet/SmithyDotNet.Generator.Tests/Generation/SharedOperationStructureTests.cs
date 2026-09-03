using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

/// <summary>
/// Guards the standalone-class emission for structures that double as an operation input/output.
/// When other generated code references such a shape through a member (drs SourceServer via
/// SourceServersList, lambda FunctionConfiguration via FunctionList and GetFunctionResponse),
/// the member properties are typed with the plain class name, so C2J ships the standalone class
/// alongside the {Op}Request/{Op}Response wrappers and the generator must too — otherwise the
/// service fails with CS0246, or worse, compiles while silently dropping public API (pinpoint).
/// An op input/output nothing else references stays wrapper-only, matching C2J (kinesis
/// EnhancedMonitoringOutput has no standalone class).
/// </summary>
public class SharedOperationStructureTests : IDisposable
{
    private readonly string _outputDir;
    private readonly string _codeAnalysisDir;
    private readonly IReadOnlyList<string> _written;

    public SharedOperationStructureTests()
    {
        var context = TestModels.Context("Codegen/shared-op-structure-model.json");
        var defaultConfigurationModes = DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

        _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _codeAnalysisDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");

        var generator = new ServiceGenerator(context, "shared-op-structure-model.json", "4.0.0.0", defaultConfigurationModes);
        _written = generator.Generate(_outputDir, _codeAnalysisDir, testsOutputPath: null, TestContext.Current.CancellationToken);
    }

    public void Dispose()
    {
        foreach (var dir in new[] { _outputDir, _codeAnalysisDir })
        {
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, recursive: true);
            }
        }
    }

    private void AssertWritten(string fileName) =>
        Assert.Contains(fileName, _written.Select(Path.GetFileName));

    private void AssertNotWritten(string fileName) =>
        Assert.DoesNotContain(fileName, _written.Select(Path.GetFileName));

    [Fact]
    public void OperationOutputReferencedThroughMembers_GetsStandaloneClassAndWrappers()
    {
        // Item is CreateItem's output AND referenced by ListItemsOutput.items (list element) and
        // GetItemOutput.item (direct member) — both property types need the plain class.
        AssertWritten("Item.g.cs");
        AssertWritten("CreateItemRequest.g.cs");
        AssertWritten("CreateItemResponse.g.cs");
    }

    [Fact]
    public void OperationOutputReferencedNowhere_StaysWrapperOnly()
    {
        // PurgeSummary is PurgeItems' output and nothing else references it: C2J ships only the
        // wrapper, so emitting a standalone class would add public API C2J does not have.
        AssertNotWritten("PurgeSummary.g.cs");
        AssertWritten("PurgeItemsResponse.g.cs");
    }

    [Fact]
    public void TraitedInputOutputShapes_NeverGetStandaloneClasses()
    {
        // @input/@output-traited shapes are wrapper-only by construction, referenced or not.
        AssertNotWritten("CreateItemInput.g.cs");
        AssertNotWritten("ListItemsOutput.g.cs");
        AssertNotWritten("GetItemOutput.g.cs");
    }
}
