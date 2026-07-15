using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Writers.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.CodeAnalysis;

[Collection(nameof(CloudTrailModelCollection))]
public class CodeAnalysisProjectFileWriterTests
{
    private readonly string _codeAnalysisProjectFile;
    public CodeAnalysisProjectFileWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new CodeAnalysisProjectFileWriter(fixture.Context);
        // the writer's write method accepts a path to the csproj so that it doesn't generate a new guid 
        // if a guid exists. For the purposes of this test, just pass an empty string.
        _codeAnalysisProjectFile = writer.Write("");
    }

    [Fact]
    public void ProjectElementCorrect()
    {
        AssertHelper("<Project Sdk=\"Microsoft.NET.Sdk\">");
        AssertHelper("</Project>");
    }

    [Fact]
    public void PropertyGroupElementCorrect()
    {
        AssertHelper("<TargetFramework>netstandard2.0</TargetFramework>");
        AssertHelper("<EnforceExtendedAnalyzerRules>true</EnforceExtendedAnalyzerRules>");
        AssertHelper("<AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>");
        AssertHelper("<RootNamespace>Amazon.CloudTrailData.CodeAnalysis</RootNamespace>");
        AssertHelper("<AssemblyName>AWSSDK.CloudTrailData.CodeAnalysis</AssemblyName>");
    }

    [Fact]
    public void GenerateAssemblyAttributesDisabled()
    {
        AssertHelper("<GenerateAssemblyTitleAttribute>false</GenerateAssemblyTitleAttribute>");
        AssertHelper("<GenerateAssemblyConfigurationAttribute>false</GenerateAssemblyConfigurationAttribute>");
        AssertHelper("<GenerateAssemblyDescriptionAttribute>false</GenerateAssemblyDescriptionAttribute>");
        AssertHelper("<GenerateAssemblyProductAttribute>false</GenerateAssemblyProductAttribute>");
        AssertHelper("<GenerateAssemblyCompanyAttribute>false</GenerateAssemblyCompanyAttribute>");
        AssertHelper("<GenerateAssemblyCopyrightAttribute>false</GenerateAssemblyCopyrightAttribute>");
        AssertHelper("<GenerateAssemblyVersionAttribute>false</GenerateAssemblyVersionAttribute>");
        AssertHelper("<GenerateAssemblyFileVersionAttribute>false</GenerateAssemblyFileVersionAttribute>");
    }

    [Fact]
    public void ProjectGuidGenerated()
    {
        // "" is not an existing project file, so a fresh braced, uppercase GUID is generated.
        Assert.Matches(@"<ProjectGuid>\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}</ProjectGuid>", _codeAnalysisProjectFile);
    }

    [Fact]
    public void PackageReferencesCorrect()
    {
        AssertHelper("<PackageReference Include=\"Microsoft.CodeAnalysis.Analyzers\" Version=\"2.9.8\" />");
        AssertHelper("<PackageReference Include=\"Microsoft.CodeAnalysis.CSharp\" Version=\"3.3.1\" />");
    }

    [Fact]
    public void EmbeddedResourceCorrect()
    {
        AssertHelper("<EmbeddedResource Include=\"Generated/PropertyValueRules.xml\">");
        AssertHelper("<CopyToOutputDirectory>Always</CopyToOutputDirectory>");
        AssertHelper("</EmbeddedResource>");
    }

    [Fact]
    public void ProjectReferenceCorrect()
    {
        AssertHelper("<ProjectReference Include=\"../../SharedAnalysisCode/SharedAnalysisCode.csproj\" />");
    }

    private void AssertHelper(string expected)
    {
        Assert.Contains(expected, _codeAnalysisProjectFile);
    }
}
