using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SmithyDotNet.Generator.Writers.CodeAnalysis;

namespace SmithyDotNet.Generator.Tests.Writers.CodeAnalysis;

[Collection(nameof(CloudTrailModelCollection))]
public class CodeAnalysisAssemblyInfoWriterTests
{
    private readonly string _codeAnalysisAssemblyInfoWriter;
    public CodeAnalysisAssemblyInfoWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new CodeAnalysisAssemblyInfoWriter(fixture.Context);
        _codeAnalysisAssemblyInfoWriter = writer.Write();
    }

    [Fact]
    public void CodeAnalysisAssemblyInfoIsCorrect()
    {
        AssertHelper("[assembly: AssemblyTitle(\"AWSSDK.CloudTrailData\")]");
        AssertHelper($"[assembly: AssemblyDescription(\"Code analysis project file for AWSSDK.CloudTrailData\")]");
        AssertHelper("[assembly: AssemblyConfiguration(\"\")]");
        AssertHelper("[assembly: AssemblyProduct(\"Amazon Web Services SDK for .NET\")]");
        AssertHelper("[assembly: AssemblyCompany(\"Amazon.com, Inc\")]");
        AssertHelper("[assembly: AssemblyCopyright(\"Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.\")]");
        AssertHelper("[assembly: AssemblyTrademark(\"\")]");
        AssertHelper("[assembly: AssemblyCulture(\"\")]");
        AssertHelper("[assembly: ComVisible(false)]");
        AssertHelper("[assembly: AssemblyVersion(\"4.0\")]");
        AssertHelper("[assembly: AssemblyFileVersion(\"4.0.100.3\")]");
    }

    private void AssertHelper(string expected)
    {
        Assert.Contains(expected, _codeAnalysisAssemblyInfoWriter);
    }
}
