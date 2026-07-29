using SmithyDotNet.Generator.Writers.NuGet;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.NuGet;

[Collection(nameof(CloudTrailModelCollection))]
public class NuspecWriterTests
{
    private readonly string _nuspecFile;

    public NuspecWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new NuspecWriter(fixture.Context);
        _nuspecFile = writer.Write();
    }

    [Fact]
    public void NuspecContainsCorrectMetadata()
    {
        AssertHelper("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
        AssertHelper("<package>");
        AssertHelper("<id>AWSSDK.CloudTrailData</id>");
        AssertHelper("<title>AWSSDK - CloudTrailData</title>");
        AssertHelper("<version>4.0.100.3</version>");
        AssertHelper("<authors>Amazon Web Services</authors>");
        AssertHelper("<description>Add CloudTrail Data Service to enable users to ingest activity events from non-AWS sources into CloudTrail Lake.</description>");
        AssertHelper("<language>en-US</language>");
        AssertHelper("<license type=\"expression\">Apache-2.0</license>");
        AssertHelper("<projectUrl>https://github.com/aws/aws-sdk-net/</projectUrl>");
        AssertHelper("<tags>AWS Amazon cloud CloudTrailData aws-sdk-v4</tags>");
        AssertHelper("<icon>images\\AWSLogo.png</icon>");
        AssertHelper("<dependency id=\"AWSSDK.Core\" version=\"[4.0.100.3, 5.0)\" />");
        AssertHelper("</metadata>");
    }

    [Fact]
    public void NuspecContainsCorrectFileElements()
    {
        AssertHelper("<file src=\"..\\..\\..\\nuget-content\\AWSLogo.png\" target=\"images\\\" />");
        AssertHelper("<file src=\"..\\..\\..\\code-analysis\\ServiceAnalysis\\CloudTrailData\\bin\\Release\\*.dll\" target=\"analyzers\\dotnet\\cs\" exclude=\"**\\Microsoft.CodeAnalysis.*;**\\System.Collections.Immutable.*;**\\System.Reflection.Metadata.*;**\\System.Composition.*\" />");
        AssertHelper("<file src=\"..\\..\\..\\code-analysis\\NuGetInstallScripts\\*.ps1\" target=\"tools\\\" />");
        AssertHelper("<file src=\".\\bin\\Release\\net472\\AWSSDK.CloudTrailData.dll\" target=\"lib\\net472\" />");
        AssertHelper("<file src=\".\\bin\\Release\\net472\\AWSSDK.CloudTrailData.xml\" target=\"lib\\net472\" />");
        AssertHelper("<file src=\".\\bin\\Release\\net472\\AWSSDK.CloudTrailData.pdb\" target=\"lib\\net472\" />");
        AssertHelper("<file src=\".\\bin\\Release\\net8.0\\AWSSDK.CloudTrailData.dll\" target=\"lib\\net8.0\" />");
        AssertHelper("<file src=\".\\bin\\Release\\net8.0\\AWSSDK.CloudTrailData.xml\" target=\"lib\\net8.0\" />");
        AssertHelper("<file src=\".\\bin\\Release\\net8.0\\AWSSDK.CloudTrailData.pdb\" target=\"lib\\net8.0\" />");
        AssertHelper("<file src=\"nuget-readme.md\" target=\"\" />");
    }

    [Fact]
    public void NuspecReferencesReadme()
    {
        AssertHelper("<readme>nuget-readme.md</readme>");
    }

    private void AssertHelper(string substring)
    {
        Assert.Contains(substring, _nuspecFile);
    }
}
