using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.Core;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Core;

public class CoreVersionWriterTests
{
    private static readonly CoreVersionWriter Writer = new(new SdkVersionManifest { CoreVersion = "4.0.102.11", OverrideCoreVersion = "4.1.0", DefaultToPreview = true, PreviewLabel = "preview" });

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
}
