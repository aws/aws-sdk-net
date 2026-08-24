using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using Xunit;

namespace SmithyDotNet.Generator.Tests;

public class CloudTrailModelFixture
{
    private static readonly byte[] ModelBytes = File.ReadAllBytes("TestData/cloudtrail-data-model.json");

    public JsonDocument Document { get; } = JsonDocument.Parse(ModelBytes);

    public SmithyModel Model { get; } = JsonSerializer.Deserialize<SmithyModel>(ModelBytes, TestModels.Options)
        ?? throw new InvalidOperationException("Failed to deserialize SmithyModel.");

    public ServiceIndex Index { get; }

    public GenerationContext Context { get; }

    public IReadOnlyList<ResolvedDefaultConfigurationMode> DefaultConfigurationModes { get; } =
        DefaultConfigurationManifest.Load("TestData/sdk-default-configuration.json");

    public CloudTrailModelFixture()
    {
        Index = new ServiceIndex(Model);
        Context = new GenerationContext(Index, Manifest, Metadata);
    }

    private static readonly ServiceMetadata Metadata = ServiceMetadata.Load("TestData/metadata.json");

    private static readonly SdkVersionManifest Manifest = TestManifests.CloudTrailData();

    public Shape DeserializeShape(string shapeId)
    {
        var shape = Document
            .RootElement
            .GetProperty("shapes")
            .GetProperty(shapeId)
            .Deserialize<Shape>(TestModels.Options);
        return shape is null ? throw new InvalidOperationException($"Shape '{shapeId}' deserialized to null.") : shape;
    }
}

[CollectionDefinition(nameof(CloudTrailModelCollection))]
public class CloudTrailModelCollection : ICollectionFixture<CloudTrailModelFixture>;
