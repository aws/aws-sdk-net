using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Generation.ProjectFiles;
using SmithyDotNet.Generator.Writers.Core;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Core;

public class CoreVersionWriterTests
{
    private static readonly CoreVersionWriter Writer = new(new SdkVersionManifest { CoreVersion = "4.0.102.11", OverrideCoreVersion = "4.1.0", DefaultToPreview = true, PreviewLabel = "preview",
        ExtensionVersions = new Dictionary<string, ServiceVersion> { ["Extensions.Numerics"] = new() { Version = "4.0.0.2" } } });

    // The assembly version is major.minor of OverrideCoreVersion, not of the file version.
    [Fact]
    public void StampsTheAssemblyInfo()
    {
        var output = Writer.WriteAssemblyInfo();

        Assert.Contains("""[assembly: AssemblyVersion("4.1")]""", output);
        Assert.Contains("""[assembly: AssemblyFileVersion("4.0.102.11")]""", output);
    }

    [Fact]
    public void StampsInternalSdkUtils()
    {
        Assert.Contains("""internal const string CoreVersionNumber = "4.0.102.11";""", Writer.WriteInternalSdkUtils());
    }

    [Fact]
    public void LabelsTheNuspecVersionUnderDefaultToPreview()
    {
        Assert.Contains("<version>4.0.102.11-preview</version>", Writer.WriteNuspec());
    }

    // Core needs AWSSDK.Extensions.Numerics (for BigDecimal) on every target framework, at the version in _sdk-versions.json
    // (preview-labeled here because the manifest sets DefaultToPreview).
    [Fact]
    public void DependsOnNumericsOnEveryTargetFramework()
    {
        var dependency = """<dependency id="AWSSDK.Extensions.Numerics" version="[4.0.0.2-preview, 5.0-preview)" />""";

        Assert.Equal(TargetPlatforms.Platforms.Count, Writer.WriteNuspec().Split(dependency).Length - 1);
    }
}
