using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Manifests;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Output;

/// <summary>
/// An <c>excludeShapes</c> structure (S3 NotificationConfiguration) or enum (S3 Protocol) is hand-written: nothing is
/// emitted for it, but the structures it holds still are. Thing holds NestedThing.
/// </summary>
public class ExcludeShapesTests : IDisposable
{
    private readonly string _outputDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
    private readonly string _codeAnalysisDir = Path.Combine(Path.GetTempPath(), $"smithy-gen-test-{Guid.NewGuid():N}");
    private readonly IReadOnlyList<string> _written;

    public ExcludeShapesTests()
    {
        var customizations = new CustomizationsModel();
        customizations.ExcludeShapes.Add("Thing");
        customizations.ExcludeShapes.Add("ChecksumAlgorithm");
        // Its output event stream would make the restXml response unmarshaller writer throw.
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
    public void Structure_WritesNoClassOrUnmarshaller_ButItsNestedStructuresStillGetOne()
    {
        Assert.DoesNotContain(_written, path => Path.GetFileName(path) is "Thing.g.cs" or "ThingUnmarshaller.g.cs");
        Assert.Contains(_written, path => Path.GetFileName(path) == "NestedThingUnmarshaller.g.cs");

        // The response still reads it through the hand-written unmarshaller.
        var response = File.ReadAllText(Path.Combine(_outputDir, Assert.Single(_written, path => Path.GetFileName(path) == "PutThingResponseUnmarshaller.g.cs")));
        Assert.Contains("ThingUnmarshaller.Instance", response);
    }

    [Fact]
    public void Enum_WritesNoEnumClass()
    {
        var enums = File.ReadAllText(Path.Combine(_outputDir, Assert.Single(_written, path => Path.GetFileName(path) == "ServiceEnumerations.g.cs")));
        Assert.DoesNotContain("class ChecksumAlgorithm", enums);
    }
}
