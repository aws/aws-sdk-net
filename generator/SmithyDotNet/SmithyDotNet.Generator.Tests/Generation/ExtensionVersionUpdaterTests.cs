using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Manifests;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class ExtensionVersionUpdaterTests : IDisposable
{
    private readonly string _extensionsRoot = Path.Combine(Path.GetTempPath(), $"smithy-extensions-test-{Guid.NewGuid():N}");
    private readonly string _nuspecPath;
    private readonly string _assemblyInfoPath;

    // The fixtures are renamed into place: a .cs file under TestData would be compiled into the tests, and .nuspec is git-ignored.
    public ExtensionVersionUpdaterTests()
    {
        var extensionDir = Path.Combine(_extensionsRoot, "AWSSDK.Extensions.Sample");
        Directory.CreateDirectory(Path.Combine(extensionDir, "Properties"));
        _nuspecPath = Path.Combine(extensionDir, "AWSSDK.Extensions.Sample.nuspec");
        _assemblyInfoPath = Path.Combine(extensionDir, "Properties", "AssemblyInfo.cs");
        File.Copy("TestData/Extensions/extension.nuspec.xml", _nuspecPath);
        File.Copy("TestData/Extensions/AssemblyInfo.txt", _assemblyInfoPath);
        // Has no nuspec and no _sdk-versions.json entry, so it's skipped rather than failing the run.
        Directory.CreateDirectory(Path.Combine(_extensionsRoot, "AWSSDK.Extensions.Unshipped"));
    }

    public void Dispose()
    {
        Directory.Delete(_extensionsRoot, recursive: true);
    }

    private static SdkVersionManifest Manifest(string version, string? droppedDependency = null, string? addedDependency = null)
    {
        var dependencies = new Dictionary<string, string> { ["Core"] = "4.0.102.11", ["S3"] = "4.0.5.0" };
        if (droppedDependency is not null)
        {
            dependencies.Remove(droppedDependency);
        }
        if (addedDependency is not null)
        {
            dependencies[addedDependency] = "4.0.0.0";
        }
        var extensions = new Dictionary<string, ServiceVersion>();
        extensions["Extensions.Sample"] = new ServiceVersion { Version = version, AssemblyVersionOverride = "4.1", Dependencies = dependencies };
        return new SdkVersionManifest { ExtensionVersions = extensions };
    }

    [Fact]
    public void StampsTheVersionAndTheAwsDependencies()
    {
        ExtensionVersionUpdater.Update(_extensionsRoot, Manifest("4.0.1.1"));

        var nuspec = File.ReadAllText(_nuspecPath);
        Assert.Contains("<version>4.0.1.1</version>", nuspec);
        Assert.Contains("""<dependency id="AWSSDK.Core" version="4.0.102.11" />""", nuspec);
        Assert.Contains("""<dependency id="AWSSDK.S3" version="4.0.5.0" />""", nuspec);
        Assert.Contains("""<dependency id="Newtonsoft.Json" version="13.0.3" />""", nuspec);
        // Every target framework's group is stamped, not just the first.
        Assert.DoesNotContain("4.0.102.10", nuspec);
        var assemblyInfo = File.ReadAllText(_assemblyInfoPath);
        Assert.Contains("""[assembly: AssemblyVersion("4.1")]""", assemblyInfo);
        Assert.Contains("""[assembly: AssemblyFileVersion("4.0.1.1")]""", assemblyInfo);
    }

    // The checks run before the save, so a failing nuspec is left as it was. A misnamed folder sorts before the Sample,
    // so it fails before the Sample is updated.
    [Theory]
    [InlineData("4.0.1.0", null, null, null, "AWSSDK.Extensions.Sample's dependencies changed but its version didn't.")]
    [InlineData("4.0.1.1", "S3", null, null, "AWSSDK.Extensions.Sample's nuspec depends on AWSSDK.S3, which its _sdk-versions.json entry doesn't list.")]
    [InlineData("4.0.1.1", null, "DynamoDBv2", null, "AWSSDK.Extensions.Sample's _sdk-versions.json entry lists DynamoDBv2, which its nuspec doesn't depend on.")]
    [InlineData("4.0.1.1", null, null, "AWSSDK.Analytics", "AWSSDK.Analytics has a nuspec but isn't named AWSSDK.Extensions.*.")]
    public void Invalid_Throws(string version, string? droppedDependency, string? addedDependency, string? misnamedFolder, string expectedMessage)
    {
        if (misnamedFolder is not null)
        {
            Directory.CreateDirectory(Path.Combine(_extensionsRoot, misnamedFolder));
            File.Copy("TestData/Extensions/extension.nuspec.xml", Path.Combine(_extensionsRoot, misnamedFolder, $"{misnamedFolder}.nuspec"));
        }

        var ex = Assert.Throws<GeneratorException>(() => ExtensionVersionUpdater.Update(_extensionsRoot, Manifest(version, droppedDependency, addedDependency)));

        Assert.Equal(expectedMessage, ex.Message);
        Assert.Equal(File.ReadAllText("TestData/Extensions/extension.nuspec.xml"), File.ReadAllText(_nuspecPath));
    }
}
