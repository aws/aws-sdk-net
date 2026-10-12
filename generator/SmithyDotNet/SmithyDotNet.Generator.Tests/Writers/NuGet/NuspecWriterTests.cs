using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Writers.NuGet;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.NuGet;

[Collection(nameof(CloudTrailModelCollection))]
public class NuspecWriterTests
{
    private readonly CloudTrailModelFixture _fixture;
    private readonly string _nuspecFile;

    public NuspecWriterTests(CloudTrailModelFixture fixture)
    {
        _fixture = fixture;
        var writer = new NuspecWriter(fixture.Context);
        _nuspecFile = writer.Write();
    }

    [Fact]
    public void NuspecContainsCorrectMetadata()
    {
        AssertHelper("""<?xml version="1.0" encoding="utf-8"?>""");
        AssertHelper("<package>");
        AssertHelper("<id>AWSSDK.CloudTrailData</id>");
        AssertHelper("<title>AWSSDK - CloudTrailData</title>");
        AssertHelper("<version>4.0.100.3</version>");
        AssertHelper("<authors>Amazon Web Services</authors>");
        AssertHelper("<description>Add CloudTrail Data Service to enable users to ingest activity events from non-AWS sources into CloudTrail Lake.</description>");
        AssertHelper("<language>en-US</language>");
        AssertHelper("""<license type="expression">Apache-2.0</license>""");
        AssertHelper("<projectUrl>https://github.com/aws/aws-sdk-net/</projectUrl>");
        AssertHelper("<tags>AWS Amazon cloud CloudTrailData aws-sdk-v4</tags>");
        AssertHelper("<icon>images\\AWSLogo.png</icon>");
        AssertHelper("""<dependency id="AWSSDK.Core" version="[4.0.100.3, 5.0)" />""");
        AssertHelper("</metadata>");
    }

    [Fact]
    public void NuspecContainsCorrectFileElements()
    {
        AssertHelper("""<file src="..\..\..\nuget-content\AWSLogo.png" target="images\" />""");
        AssertHelper("""<file src="..\..\..\code-analysis\ServiceAnalysis\CloudTrailData\bin\Release\*.dll" target="analyzers\dotnet\cs" exclude="**\Microsoft.CodeAnalysis.*;**\System.Collections.Immutable.*;**\System.Reflection.Metadata.*;**\System.Composition.*" />""");
        AssertHelper("""<file src="..\..\..\code-analysis\NuGetInstallScripts\*.ps1" target="tools\" />""");
        AssertHelper("""<file src=".\bin\Release\net472\AWSSDK.CloudTrailData.dll" target="lib\net472" />""");
        AssertHelper("""<file src=".\bin\Release\net472\AWSSDK.CloudTrailData.xml" target="lib\net472" />""");
        AssertHelper("""<file src=".\bin\Release\net472\AWSSDK.CloudTrailData.pdb" target="lib\net472" />""");
        AssertHelper("""<file src=".\bin\Release\net8.0\AWSSDK.CloudTrailData.dll" target="lib\net8.0" />""");
        AssertHelper("""<file src=".\bin\Release\net8.0\AWSSDK.CloudTrailData.xml" target="lib\net8.0" />""");
        AssertHelper("""<file src=".\bin\Release\net8.0\AWSSDK.CloudTrailData.pdb" target="lib\net8.0" />""");
        AssertHelper("""<file src="nuget-readme.md" target="" />""");
    }

    [Fact]
    public void Nuspec_RpcV2Cbor_DependsOnCborExtension()
    {
        var nuspec = new NuspecWriter(TestModels.Context("Codegen/rpcv2cbor-model.json")).Write();
        Assert.Contains("""<dependency id="AWSSDK.Extensions.CborProtocol" version="[4.0.100.14, 5.0)" />""", nuspec);
    }

    // Each framework's group carries the AWS dependencies (a service dependency at the version the service's own entry
    // pins, before Core, as in C2J) and that framework's packages; a package without targets applies to its whole family.
    [Theory]
    [InlineData("net472", "Fx.Pkg")]
    [InlineData("netstandard2.0", "Ns.Pkg", "All.Pkg")]
    [InlineData("netcoreapp3.1", "All.Pkg")]
    [InlineData("net8.0", "All.Pkg")]
    public void Nuspec_EveryFrameworkGroupHasAwsDependenciesAndItsPackages(string tfm, params string[] packages)
    {
        var metadata = new ServiceMetadata
        {
            Dependencies = ["SQS"],
            NugetDependencies = new NugetDependencies
            {
                NetStandard = [new NugetDependency { Name = "Ns.Pkg", Version = "2.0.0", Targets = ["netstandard2.0"] }, new NugetDependency { Name = "All.Pkg", Version = "3.0.0" }],
                NetFramework = [new NugetDependency { Name = "Fx.Pkg", Version = "1.0.0" }],
            },
        };
        var dependencyVersions = new Dictionary<string, string>();
        dependencyVersions["SQS"] = "4.0.1.2";
        var serviceVersions = new Dictionary<string, ServiceVersion>();
        serviceVersions["CloudTrailData"] = new ServiceVersion { Version = "4.0.100.3", Dependencies = dependencyVersions };
        var manifest = new SdkVersionManifest { CoreVersion = "4.0.100.3", ServiceVersions = serviceVersions };
        var nuspec = new NuspecWriter(new GenerationContext(_fixture.Index, manifest, metadata)).Write();

        var start = nuspec.IndexOf($"""<group targetFramework="{tfm}">""", StringComparison.Ordinal);
        Assert.True(start >= 0);
        var group = nuspec[start..nuspec.IndexOf("</group>", start, StringComparison.Ordinal)];
        var sqs = group.IndexOf("""<dependency id="AWSSDK.SQS" version="[4.0.1.2, 5.0)" />""", StringComparison.Ordinal);
        var core = group.IndexOf("""<dependency id="AWSSDK.Core" version="[4.0.100.3, 5.0)" />""", StringComparison.Ordinal);
        Assert.True(0 <= sqs && sqs < core);
        Assert.Equal(packages.Contains("Fx.Pkg"), group.Contains("""<dependency id="Fx.Pkg" version="1.0.0" />""", StringComparison.Ordinal));
        Assert.Equal(packages.Contains("Ns.Pkg"), group.Contains("""<dependency id="Ns.Pkg" version="2.0.0" />""", StringComparison.Ordinal));
        Assert.Equal(packages.Contains("All.Pkg"), group.Contains("""<dependency id="All.Pkg" version="3.0.0" />""", StringComparison.Ordinal));
    }

    // The CloudTrailData manifest pins only Core.
    [Theory]
    [InlineData("SQS", "netstandard2.0", "no 'SQS' dependency version for service 'CloudTrailData'")]
    [InlineData(null, "net9.0", "targets 'net9.0'")]
    public void Nuspec_UnresolvableDependency_Throws(string? dependency, string target, string expectedInMessage)
    {
        var metadata = new ServiceMetadata
        {
            Dependencies = dependency is null ? [] : [dependency],
            NugetDependencies = new NugetDependencies { NetStandard = [new NugetDependency { Name = "Ns.Pkg", Version = "2.0.0", Targets = [target] }] },
        };
        var context = new GenerationContext(_fixture.Index, _fixture.Context.Manifest, metadata);

        var ex = Assert.Throws<GeneratorException>(() => new NuspecWriter(context).Write());
        Assert.Contains(expectedInMessage, ex.Message);
    }

    // DefaultToPreview puts every package in preview; the label gets the '-' the file omits.
    [Theory]
    [InlineData(true, false, false, "<version>4.0.100.3-preview</version>")]
    [InlineData(false, true, false, """<dependency id="AWSSDK.Core" version="[4.0.100.3-preview, 5.0-preview)" />""")]
    [InlineData(false, true, false, """<dependency id="AWSSDK.SQS" version="[4.0.1.2-preview, 5.0-preview)" />""")]
    [InlineData(false, false, true, """<dependency id="AWSSDK.SQS" version="[4.0.1.2-preview, 5.0-preview)" />""")]
    [InlineData(false, false, false, """<dependency id="AWSSDK.SQS" version="[4.0.1.2, 5.0)" />""")]
    public void Nuspec_PreviewLabelFollowsEachEntry(bool serviceInPreview, bool defaultToPreview, bool dependencyInPreview, string expected)
    {
        var dependencyVersions = new Dictionary<string, string>();
        dependencyVersions["SQS"] = "4.0.1.2";
        var serviceVersions = new Dictionary<string, ServiceVersion>();
        serviceVersions["CloudTrailData"] = new ServiceVersion { Version = "4.0.100.3", Dependencies = dependencyVersions, InPreview = serviceInPreview };
        serviceVersions["SQS"] = new ServiceVersion { Version = "4.0.1.2", InPreview = dependencyInPreview };
        var manifest = new SdkVersionManifest { CoreVersion = "4.0.100.3", PreviewLabel = "preview", DefaultToPreview = defaultToPreview, ServiceVersions = serviceVersions };

        var nuspec = new NuspecWriter(new GenerationContext(_fixture.Index, manifest, new ServiceMetadata { Dependencies = ["SQS"] })).Write();

        Assert.Contains(expected, nuspec);
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
