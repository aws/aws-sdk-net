using SmithyDotNet.Generator.Writers;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Writers;

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
        // Enum generation is not implemented yet, so the namespace body must stay empty.
        Assert.EndsWith("namespace Amazon.CloudTrailData\n{\n}\n", _output.Replace("\r\n", "\n"));
    }
}
