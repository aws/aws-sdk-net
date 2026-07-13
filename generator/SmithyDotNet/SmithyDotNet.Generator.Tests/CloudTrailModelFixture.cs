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

    public CloudTrailModelFixture()
    {
        Index = new ServiceIndex(Model);
        Context = new GenerationContext(Index, Manifest, Metadata);
    }

    // Mirrors generator/ServiceModels/cloudtrail-data/metadata.json so the context carries the same
    // metadata the generator would load at runtime.
    private static readonly ServiceMetadata Metadata = new()
    {
        Active = true,
        Synopsis = "Add CloudTrail Data Service to enable users to ingest activity events from non-AWS sources into CloudTrail Lake.",
        GenerateClientConstructors = true,
    };

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
