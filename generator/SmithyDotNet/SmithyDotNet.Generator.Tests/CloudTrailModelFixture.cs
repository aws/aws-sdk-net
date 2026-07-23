using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
using SmithyDotNet.Generator.Model.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests;

public class CloudTrailModelFixture
{
    public static readonly JsonSerializerOptions Options = new()
    {
        Converters = { new ShapeConverter() },
    };

    private static readonly byte[] ModelBytes = File.ReadAllBytes("TestData/cloudtrail-data-model.json");

    public JsonDocument Document { get; } = JsonDocument.Parse(ModelBytes);

    public SmithyModel Model { get; } = JsonSerializer.Deserialize<SmithyModel>(ModelBytes, Options)
        ?? throw new InvalidOperationException("Failed to deserialize SmithyModel.");

    public ServiceIndex Index { get; }

    public GenerationContext Context { get; }

    public IReadOnlyList<ResolvedDefaultConfigurationMode> DefaultConfigurationModes { get; } =
        DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

    public CloudTrailModelFixture()
    {
        // TargetPlatforms reads the TFM set from a Directory.Build.props; TestData carries a minimal
        // stand-in. Writer tests share this collection fixture, so initializing here runs once before
        // any of them touch TargetPlatforms.
        TargetPlatforms.Initialize("TestData");

        Index = new ServiceIndex(Model);
        Context = new GenerationContext(Index, Manifest, Metadata);
    }

    private static readonly ServiceMetadata Metadata = ServiceMetadata.Load("TestData/metadata.json");

    // Mirrors the CloudTrailData entry in generator/ServiceModels/_sdk-versions.json so the context's
    // manifest carries the same version data the generator would resolve at runtime.
    private static readonly SdkVersionManifest Manifest = new()
    {
        CoreVersion = "4.0.100.3",
        ServiceVersions = new Dictionary<string, ServiceVersion>
        {
            ["CloudTrailData"] = new()
            {
                Version = "4.0.100.3",
                AssemblyVersionOverride = "4.0",
                Dependencies = new Dictionary<string, string> { ["Core"] = "4.0.100.3" },
                InPreview = false,
            },
        },
    };

    public Shape DeserializeShape(string shapeId)
    {
        var shape = Document
            .RootElement
            .GetProperty("shapes")
            .GetProperty(shapeId)
            .Deserialize<Shape>(Options);
        return shape is null ? throw new InvalidOperationException($"Shape '{shapeId}' deserialized to null.") : shape;
    }
}

[CollectionDefinition(nameof(CloudTrailModelCollection))]
public class CloudTrailModelCollection : ICollectionFixture<CloudTrailModelFixture>;
