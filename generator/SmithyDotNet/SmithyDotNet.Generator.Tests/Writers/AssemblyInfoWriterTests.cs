using Microsoft.CodeAnalysis.CSharp;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

[Collection(nameof(CloudTrailModelCollection))]
public class AssemblyInfoWriterTests
{
    private const string ServiceFileVersion = "4.0.100.3";

    private readonly string _output;

    public AssemblyInfoWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new AssemblyInfoWriter(fixture.Context, ServiceFileVersion);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsAssemblyTitle()
    {
        Assert.Contains("[assembly: AssemblyTitle(\"AWSSDK.CloudTrailData\")]", _output);
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
        Assert.Contains("[assembly: AssemblyVersion(\"4.0\")]", _output);
    }

    [Fact]
    public void EmitsAssemblyFileVersion()
    {
        Assert.Contains($"[assembly: AssemblyFileVersion(\"{ServiceFileVersion}\")]", _output);
    }

    [Fact]
    public void EmitsComVisible()
    {
        Assert.Contains("[assembly: ComVisible(false)]", _output);
    }

    [Fact]
    public void EmitsCompanyAndCopyright()
    {
        Assert.Contains("[assembly: AssemblyCompany(\"Amazon.com, Inc\")]", _output);
        Assert.Contains("[assembly: AssemblyCopyright(\"Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.\")]", _output);
    }

    [Fact]
    public void EmitsProduct()
    {
        Assert.Contains("[assembly: AssemblyProduct(\"Amazon Web Services SDK for .NET\")]", _output);
    }

    [Fact]
    public void DoesNotEmitInternalsVisibleTo()
    {
        Assert.DoesNotContain("InternalsVisibleTo", _output);
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
