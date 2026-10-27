using Microsoft.CodeAnalysis.CSharp;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Manifests;
using SmithyDotNet.Generator.Generation.ProjectFiles;
using SmithyDotNet.Generator.Writers.ProjectFiles;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.ProjectFiles;

[Collection(nameof(CloudTrailModelCollection))]
public class AssemblyInfoWriterTests
{
    private const string ServiceFileVersion = "4.0.100.3";

    private readonly CloudTrailModelFixture _fixture;
    private readonly string _output;

    public AssemblyInfoWriterTests(CloudTrailModelFixture fixture)
    {
        _fixture = fixture;
        var writer = new AssemblyInfoWriter(fixture.Context, ServiceFileVersion);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsAssemblyTitle()
    {
        Assert.Contains("""[assembly: AssemblyTitle("AWSSDK.CloudTrailData")]""", _output);
    }

    [Fact]
    public void EmitsPlatformConditionalDescriptions_DerivedFromTargetPlatforms()
    {
        var platforms = TargetPlatforms.Platforms;

        // First platform uses #if, the rest use #elif.
        Assert.Contains($"#if {platforms[0].Symbol}", _output);
        for (var i = 1; i < platforms.Count; i++)
        {
            Assert.Contains($"#elif {platforms[i].Symbol}", _output);
        }

        Assert.Contains("#error Unknown platform constant - unable to set correct AssemblyDescription", _output);
    }

    [Fact]
    public void DescriptionUsesServiceTitle()
    {
        foreach (var platform in TargetPlatforms.Platforms)
        {
            Assert.Contains($"The Amazon Web Services SDK for .NET ({platform.Label}) - AWS CloudTrail Data Service.", _output);
        }
    }

    [Fact]
    public void EmitsAssemblyVersionFromManifestOverride()
    {
        Assert.Contains("""[assembly: AssemblyVersion("4.0")]""", _output);
    }

    [Fact]
    public void EmitsAssemblyFileVersion()
    {
        Assert.Contains($"""[assembly: AssemblyFileVersion("{ServiceFileVersion}")]""", _output);
    }

    [Fact]
    public void EmitsComVisible()
    {
        Assert.Contains("[assembly: ComVisible(false)]", _output);
    }

    [Fact]
    public void EmitsCompanyAndCopyright()
    {
        Assert.Contains("""[assembly: AssemblyCompany("Amazon.com, Inc")]""", _output);
        Assert.Contains("""[assembly: AssemblyCopyright("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.")]""", _output);
    }

    [Fact]
    public void EmitsProduct()
    {
        Assert.Contains("""[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]""", _output);
    }

    [Fact]
    public void DoesNotEmitInternalsVisibleTo_WithoutMetadataEntries()
    {
        Assert.DoesNotContain("InternalsVisibleTo", _output);
    }

    [Fact]
    public void EmitsInternalsVisibleTo_PerMetadataEntry_WithSdkKeyUnlessGiven()
    {
        var metadata = new ServiceMetadata { InternalsVisibleTo = ["AWSSDK.UnitTests.Core", "DynamicProxyGenAssembly2, PublicKey=00240000c547cac3"] };
        var context = new GenerationContext(_fixture.Index, TestManifests.CloudTrailData(), metadata);
        var output = new AssemblyInfoWriter(context, ServiceFileVersion).Write(TestContext.Current.CancellationToken);

        Assert.Contains("""[assembly: InternalsVisibleTo("AWSSDK.UnitTests.Core, PublicKey=0024000004800000940000000602000000240000525341310004000001000100db5f59f098d27276c7833875a6263a3cc74ab17ba9a9df0b52aedbe7252745db7274d5271fd79c1f08f668ecfa8eaab5626fa76adc811d3c8fc55859b0d09d3bc0a84eecd0ba891f2b8a2fc55141cdcc37c2053d53491e650a479967c3622762977900eddbf1252ed08a2413f00a28f3a0752a81203f03ccb7f684db373518b4")]""", output);
        Assert.Contains("""[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=00240000c547cac3")]""", output);
    }

    [Theory]
    [MemberData(nameof(PlatformSymbols))]
    public void OutputIsSyntacticallyValidForEachPlatform(string symbol)
    {
        var options = CSharpParseOptions.Default.WithPreprocessorSymbols(symbol);
        var tree = CSharpSyntaxTree.ParseText(_output, options, cancellationToken: TestContext.Current.CancellationToken);
        Assert.Empty(tree.GetDiagnostics(TestContext.Current.CancellationToken));
    }

    public static TheoryData<string> PlatformSymbols
    {
        get
        {
            var data = new TheoryData<string>();
            foreach (var platform in TargetPlatforms.Platforms)
            {
                data.Add(platform.Symbol);
            }
            return data;
        }
    }
}
