using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Manifests;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Output;

/// <summary>
/// An <c>operationModifiers</c> <c>clientMethodOnly</c> operation (S3 SelectObjectContent) gets its client methods and
/// nothing else. SelectThing's output event stream would make the restXml response unmarshaller writer throw.
/// </summary>
public class ClientMethodOnlyOperationTests : IDisposable
{
    private readonly string _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
    private readonly string _codeAnalysisDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
    private readonly IReadOnlyList<string> _written;

    public ClientMethodOnlyOperationTests()
    {
        var customizations = new CustomizationsModel();
        customizations.OperationModifiers["SelectThing"] = new OperationModifier { ClientMethodOnly = true };
        var context = TestModels.Context(TestModels.Load("Codegen/restxml-model.json"), customizations);
        var defaultConfigurationModes = DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

        var generator = new ServiceGenerator(context, "restxml-model.json", "4.0.0.0", defaultConfigurationModes);
        _written = generator.Generate(_outputDir, _codeAnalysisDir, testsOutputPath: null, TestContext.Current.CancellationToken);
    }

    public void Dispose()
    {
        foreach (var dir in new[] { _outputDir, _codeAnalysisDir })
        {
            if (Directory.Exists(dir))
            {
                Directory.Delete(dir, recursive: true);
            }
        }
    }

    [Fact]
    public void WritesClientMethods()
    {
        var client = File.ReadAllText(Path.Combine(_outputDir, Assert.Single(_written, path => Path.GetFileName(path) == "AmazonExampleClient.g.cs")));
        Assert.Contains("public virtual SelectThingResponse SelectThing(SelectThingRequest request)", client);
    }

    [Fact]
    public void WritesNothingElseForTheOperation()
    {
        Assert.DoesNotContain(_written, path => Path.GetFileName(path).StartsWith("Select", StringComparison.Ordinal) || Path.GetFileName(path).StartsWith("RecordsEvent", StringComparison.Ordinal));
        Assert.DoesNotContain(_written, path => Path.GetFileName(path) == "ExampleEventStreamException.g.cs");
        Assert.Contains(_written, path => Path.GetFileName(path) == "NestedThing.g.cs");
    }
}
