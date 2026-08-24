using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

/// <summary>
/// Guards that <see cref="ServiceGenerator"/> emits unmarshallers for structures reachable *only*
/// through an exception's rich members (a nested structure and a list-of-structure). The generated
/// exception unmarshaller references those <c>*Unmarshaller</c> types, so a missing file is a latent
/// compile break — one the writer-level string assertions in <c>RichExceptionCodegenTests</c> can't
/// catch because they never run the orchestration that decides which files to emit.
/// </summary>
public class RichExceptionServiceGeneratorTests : IDisposable
{
    private const string ModelFileName = "example-2023-01-01.normal.json";

    private readonly string _outputDir;
    private readonly string _codeAnalysisDir;
    private readonly IReadOnlyList<string> _written;

    public RichExceptionServiceGeneratorTests()
    {
        // ResourceConflict in the shared codegen model reaches two structures nothing else does:
        // ConflictDetails (nested) and RelatedResource (list element). Both must get unmarshallers.
        var context = TestModels.Context("Codegen/codegen-model.json");
        var defaultConfigurationModes = DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

        _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
        _codeAnalysisDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");

        var generator = new ServiceGenerator(context, ModelFileName, "4.0.0.0", defaultConfigurationModes);
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

    [Fact]
    public void EmitsUnmarshallersForStructuresReachableOnlyThroughException()
    {
        var marshalling = Path.Combine("Generated", "Model", "Internal", "MarshallTransformations");
        AssertWritten(Path.Combine(marshalling, "ResourceConflictExceptionUnmarshaller.g.cs"));
        AssertWritten(Path.Combine(marshalling, "ConflictDetailsUnmarshaller.g.cs"));
        AssertWritten(Path.Combine(marshalling, "RelatedResourceUnmarshaller.g.cs"));
    }

    private void AssertWritten(string relativePath)
    {
        Assert.True(File.Exists(Path.Combine(_outputDir, relativePath)), $"Expected file: {relativePath}");
        Assert.Contains(relativePath, _written);
    }
}
