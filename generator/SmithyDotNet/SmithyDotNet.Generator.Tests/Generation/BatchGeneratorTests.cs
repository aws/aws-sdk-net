using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class BatchGeneratorTests : IDisposable
{
    private readonly string _repoRoot;

    public BatchGeneratorTests()
    {
        _repoRoot = Path.Combine(Path.GetTempPath(), $"smithy-batch-test-{Guid.NewGuid():N}");
        SeedRepoSkeleton();
    }

    public void Dispose()
    {
        if (Directory.Exists(_repoRoot))
        {
            Directory.Delete(_repoRoot, recursive: true);
        }
    }

    [Fact]
    public void EmptyServiceListIsNoOp()
    {
        WriteControlFile();

        var generated = new BatchGenerator(_repoRoot).Run(TestContext.Current.CancellationToken);
        Assert.Empty(generated);
        Assert.False(Directory.Exists(Path.Combine(_repoRoot, "sdk", "src", "Services", "CloudTrailData", "Generated")));
    }

    [Fact]
    public void MissingControlFileIsNoOp()
    {
        var generated = new BatchGenerator(_repoRoot).Run(TestContext.Current.CancellationToken);
        Assert.Empty(generated);
    }

    [Fact]
    public void GeneratesListedServiceIntoRealSdkPaths()
    {
        WriteControlFile("CloudTrailData");

        var generated = new BatchGenerator(_repoRoot).Run(TestContext.Current.CancellationToken);
        Assert.Equal(["CloudTrailData"], generated);
        Assert.True(File.Exists(Path.Combine(_repoRoot, "sdk", "src", "Services", "CloudTrailData", "Generated", "IAmazonCloudTrailData.g.cs")));
        Assert.True(File.Exists(Path.Combine(_repoRoot, "sdk", "code-analysis", "ServiceAnalysis", "CloudTrailData", "AWSSDK.CloudTrailData.CodeAnalysis.csproj")));
        Assert.True(File.Exists(Path.Combine(_repoRoot, "sdk", "test", "Services", "CloudTrailData", "UnitTests", "Generated", "Endpoints", "CloudTrailDataEndpointProviderTests.g.cs")));
    }

    [Fact]
    public void WipesStaleGeneratedTreesButKeepsCustom()
    {
        WriteControlFile("CloudTrailData");

        var sourceRoot = Path.Combine(_repoRoot, "sdk", "src", "Services", "CloudTrailData");
        var codeAnalysisRoot = Path.Combine(_repoRoot, "sdk", "code-analysis", "ServiceAnalysis", "CloudTrailData");
        var testsRoot = Path.Combine(_repoRoot, "sdk", "test", "Services", "CloudTrailData");

        // Stale C2J output in all three trees, the superseded C2J solution, and a hand-written file.
        SeedFile(Path.Combine(sourceRoot, "Generated", "_bcl", "Stale.cs"), "// stale");
        SeedFile(Path.Combine(codeAnalysisRoot, "Generated", "Stale.cs"), "// stale");
        SeedFile(Path.Combine(testsRoot, "UnitTests", "Generated", "Stale.cs"), "// stale");
        SeedFile(Path.Combine(sourceRoot, "CloudTrailData.sln"), "stale c2j solution");
        SeedFile(Path.Combine(sourceRoot, "Custom", "HandWritten.cs"), "// keep me");

        new BatchGenerator(_repoRoot).Run(TestContext.Current.CancellationToken);

        Assert.False(File.Exists(Path.Combine(sourceRoot, "Generated", "_bcl", "Stale.cs")));
        Assert.False(File.Exists(Path.Combine(codeAnalysisRoot, "Generated", "Stale.cs")));
        Assert.False(File.Exists(Path.Combine(testsRoot, "UnitTests", "Generated", "Stale.cs")));
        Assert.False(File.Exists(Path.Combine(sourceRoot, "CloudTrailData.sln")));
        Assert.True(File.Exists(Path.Combine(sourceRoot, "CloudTrailData.slnx")));
        Assert.True(File.Exists(Path.Combine(sourceRoot, "Custom", "HandWritten.cs")));
    }

    [Fact]
    public void UnmatchedListedServiceThrows()
    {
        WriteControlFile("NoSuchService");

        var ex = Assert.Throws<GeneratorException>(() => new BatchGenerator(_repoRoot).Run(TestContext.Current.CancellationToken));
        Assert.Contains("NoSuchService", ex.Message);
    }

    [Fact]
    public void UnlistedModelIsSkipped()
    {
        WriteControlFile();

        var generated = new BatchGenerator(_repoRoot).Run(TestContext.Current.CancellationToken);
        Assert.Empty(generated);
    }

    // A repeated or case-variant entry must not schedule the same service twice (it would race on
    // the same output dirs); it resolves to a single generation.
    [Fact]
    public void DuplicateOrCaseVariantEntriesGenerateOnce()
    {
        WriteControlFile("CloudTrailData", "cloudtraildata");

        var generated = new BatchGenerator(_repoRoot).Run(TestContext.Current.CancellationToken);
        Assert.Equal(["CloudTrailData"], generated);
    }

    // Builds the minimal repo layout BatchGenerator expects, reusing the TestData fixtures: the
    // CloudTrailData Smithy model + metadata sidecar in its C2J-style model dir, the version
    // manifest, the default-configuration file, and the TFM props.
    private void SeedRepoSkeleton()
    {
        var modelDir = Path.Combine(SdkTreeLayout.ModelsRoot(_repoRoot), "cloudtrail-data");
        Directory.CreateDirectory(modelDir);
        File.Copy("TestData/cloudtrail-data-model.json", Path.Combine(modelDir, SdkTreeLayout.SmithyModelFileName));
        File.Copy("TestData/metadata.json", Path.Combine(modelDir, "metadata.json"));

        SeedFile(SdkTreeLayout.VersionManifestPath(_repoRoot), JsonSerializer.Serialize(TestManifests.CloudTrailData()));

        var coreDir = Path.Combine(SdkTreeLayout.SdkRoot(_repoRoot), "src", "Core");
        Directory.CreateDirectory(coreDir);
        File.Copy("TestData/sdk-default-configuration.json", Path.Combine(coreDir, "sdk-default-configuration.json"));
        File.Copy("TestData/Directory.Build.props", Path.Combine(SdkTreeLayout.SdkRoot(_repoRoot), "Directory.Build.props"));
    }

    private void WriteControlFile(params string[] services)
    {
        var json = JsonSerializer.Serialize(new MigratedServicesFile { Services = services });
        SeedFile(Path.Combine(SdkTreeLayout.ModelsRoot(_repoRoot), SdkTreeLayout.MigratedServicesFileName), json);
    }

    private static void SeedFile(string path, string contents)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(path) ?? ".");
        File.WriteAllText(path, contents);
    }
}
