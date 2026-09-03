using SmithyDotNet.Generator.Writers.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers.Shapes;

[Collection(nameof(CloudTrailModelCollection))]
public class ServiceEnumerationsWriterTests
{
    private const string ModelFileName = "cloudtrail-data-2021-08-11.normal.json";

    private readonly string _output;

    public ServiceEnumerationsWriterTests(CloudTrailModelFixture fixture)
    {
        var writer = new ServiceEnumerationsWriter(fixture.Context, ModelFileName);
        _output = writer.Write(TestContext.Current.CancellationToken);
    }

    [Fact]
    public void EmitsLicenseAndGenerationNotice()
    {
        Assert.Contains("Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.", _output);
        Assert.Contains($"This file is generated from the {ModelFileName} service model.", _output);
    }

    [Fact]
    public void EmitsUsings()
    {
        Assert.Contains("using System;", _output);
        Assert.Contains("using Amazon.Runtime;", _output);
    }

    [Fact]
    public void EmitsEmptyServiceNamespace()
    {
        // CloudTrailData carries no enum shapes, so the namespace body stays empty — the file is still
        // emitted to match the shipping SDK's generated file set. Enum emission is covered by
        // EnumCodegenTests and the enum-parity-check acceptance loop.
        Assert.EndsWith("namespace Amazon.CloudTrailData\n{\n}\n", _output.Replace("\r\n", "\n"));
    }
}
