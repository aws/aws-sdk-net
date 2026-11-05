using SmithyDotNet.Generator.Writers.CodeAnalysis;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.CodeAnalysis;

public class CodeAnalysisSolutionFileWriterTests : IDisposable
{
    private readonly string _sdkRoot = Path.Combine(Path.GetTempPath(), $"smithy-ca-sln-test-{Guid.NewGuid():N}");

    public void Dispose()
    {
        Directory.Delete(_sdkRoot, recursive: true);
    }

    [Fact]
    public void TakesEachProjectsGuidFromItsProjectFile()
    {
        var project = Path.Combine(_sdkRoot, "code-analysis", "ServiceAnalysis", "S3", "AWSSDK.S3.CodeAnalysis.csproj");
        Directory.CreateDirectory(Path.GetDirectoryName(project) ?? throw new InvalidOperationException(project));
        File.WriteAllText(project, "<Project><PropertyGroup><ProjectGuid>{44444444-4444-4444-4444-444444444444}</ProjectGuid></PropertyGroup></Project>");

        var output = new CodeAnalysisSolutionFileWriter(_sdkRoot).Write();

        Assert.Contains("""= "AWSSDK.S3.CodeAnalysis", "code-analysis/ServiceAnalysis/S3/AWSSDK.S3.CodeAnalysis.csproj", "{44444444-4444-4444-4444-444444444444}""", output);
        Assert.Contains("{44444444-4444-4444-4444-444444444444} = {1523203C-CD16-4B4A-8F9D-8ECCA3A327AA}", output);
    }
}
