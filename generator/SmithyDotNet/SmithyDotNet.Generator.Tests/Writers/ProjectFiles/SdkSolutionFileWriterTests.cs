using SmithyDotNet.Generator.Writers.ProjectFiles;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.ProjectFiles;

public class SdkSolutionFileWriterTests : IDisposable
{
    private readonly string _sdkRoot = Path.Combine(Path.GetTempPath(), $"smithy-sln-test-{Guid.NewGuid():N}");
    private readonly string _output;

    // TestData/Solutions/AWSSDK.NetStandard.sln is the existing solution, holding ACMPCA's GUIDs but not AccessAnalyzer's.
    public SdkSolutionFileWriterTests()
    {
        Touch("src", "Core", "AWSSDK.Core.NetStandard.csproj");
        Touch("src", "Services", "ACMPCA", "AWSSDK.ACMPCA.NetStandard.csproj");
        Touch("src", "Services", "AccessAnalyzer", "AWSSDK.AccessAnalyzer.NetStandard.csproj");
        Touch("test", "Services", "ACMPCA", "UnitTests", "AWSSDK.UnitTests.ACMPCA.NetStandard.csproj");
        Touch("test", "UnitTests", "AWSSDK.UnitTests.NetStandard.csproj");
        File.Copy("TestData/Solutions/AWSSDK.NetStandard.sln", Path.Combine(_sdkRoot, "AWSSDK.NetStandard.sln"));
        _output = new SdkSolutionFileWriter(_sdkRoot).Write("NetStandard");
    }

    public void Dispose()
    {
        Directory.Delete(_sdkRoot, recursive: true);
    }

    private void Touch(params string[] path)
    {
        var file = Path.Combine([_sdkRoot, .. path]);
        Directory.CreateDirectory(Path.GetDirectoryName(file) ?? throw new InvalidOperationException(file));
        File.WriteAllText(file, "<Project />");
    }

    // The reused GUIDs also key the project's build entries and its nesting under the service and Services folders.
    [Fact]
    public void ReusesTheExistingSolutionsGuids()
    {
        Assert.Contains("""Project("{2150E333-8FDC-42A3-9474-1A3956D46DE8}") = "ACMPCA", "ACMPCA", "{22222222-2222-2222-2222-222222222222}""", _output);
        Assert.Contains("""Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "AWSSDK.ACMPCA.NetStandard", "src/Services/ACMPCA/AWSSDK.ACMPCA.NetStandard.csproj", "{11111111-1111-1111-1111-111111111111}""", _output);
        Assert.Contains("{11111111-1111-1111-1111-111111111111}.Release|Any CPU.Build.0 = Release|Any CPU", _output);
        Assert.Contains("{11111111-1111-1111-1111-111111111111} = {22222222-2222-2222-2222-222222222222}", _output);
        Assert.Contains("{22222222-2222-2222-2222-222222222222} = {939EC5C2-8345-43E2-8F97-72EEEBEEA0AB}", _output);
        Assert.Contains("SolutionGuid = {33333333-3333-3333-3333-333333333333}", _output);
    }

    // AccessAnalyzer's GUIDs are new in the first run, so a second run must read them back rather than make new ones.
    [Fact]
    public void KeepsItsOwnGuidsOnTheNextRun()
    {
        File.WriteAllText(Path.Combine(_sdkRoot, "AWSSDK.NetStandard.sln"), _output);

        Assert.Equal(_output, new SdkSolutionFileWriter(_sdkRoot).Write("NetStandard"));
    }

    // C2J sorts by culture, not ordinal, which puts AccessAnalyzer before ACMPCA.
    [Fact]
    public void OrdersServicesAsC2JDoes()
    {
        var accessAnalyzer = _output.IndexOf("""= "AccessAnalyzer", "AccessAnalyzer", """, StringComparison.Ordinal);
        var acmpca = _output.IndexOf("""= "ACMPCA", "ACMPCA", """, StringComparison.Ordinal);

        Assert.True(0 <= accessAnalyzer && accessAnalyzer < acmpca);
    }

    // A service's own test projects belong to its solution, not the SDK's.
    [Fact]
    public void ListsTheSharedTestProjectsButNotServiceTests()
    {
        Assert.Contains("""= "AWSSDK.UnitTests.NetStandard", "test/UnitTests/AWSSDK.UnitTests.NetStandard.csproj", """, _output);
        Assert.DoesNotContain("AWSSDK.UnitTests.ACMPCA", _output);
    }
}
