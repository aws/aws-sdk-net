using Microsoft.Extensions.AI;
using System;
using Xunit;

namespace Amazon.BedrockRuntime;

public class BedrockEmbeddingGeneratorTests
{
    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void AsIEmbeddingGenerator_InvalidArguments_Throws()
    {
        Assert.Throws<ArgumentNullException>("runtime", () => AmazonBedrockRuntimeExtensions.AsIEmbeddingGenerator(null));
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData(null, null)]
    [InlineData("titan", null)]
    [InlineData(null, 42)]
    [InlineData("titan", 42)]
    public void AsIEmbeddingGenerator_ReturnsInstance(string modelId, int? dimensions)
    {
        IAmazonBedrockRuntime runtime = new AmazonBedrockRuntimeClient("awsAccessKeyId", "awsSecretAccessKey", RegionEndpoint.USEast1);
        IEmbeddingGenerator<string, Embedding<float>> generator = runtime.AsIEmbeddingGenerator(modelId, dimensions);

        Assert.NotNull(generator);
        Assert.Equal("aws.bedrock", generator.GetService<EmbeddingGeneratorMetadata>()?.ProviderName);
        Assert.Equal(modelId, generator.GetService<EmbeddingGeneratorMetadata>()?.DefaultModelId);
        Assert.Equal(dimensions, generator.GetService<EmbeddingGeneratorMetadata>()?.DefaultModelDimensions);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void AsIEmbeddingGenerator_GetService()
    {
        IAmazonBedrockRuntime runtime = new AmazonBedrockRuntimeClient("awsAccessKeyId", "awsSecretAccessKey", RegionEndpoint.USEast1);
        IEmbeddingGenerator<string, Embedding<float>> generator = runtime.AsIEmbeddingGenerator();

        Assert.Same(runtime, generator.GetService<AmazonBedrockRuntimeClient>());
        Assert.Same(runtime, generator.GetService<IAmazonBedrockRuntime>());
        Assert.Same(generator, generator.GetService<IEmbeddingGenerator<string, Embedding<float>>>());

        Assert.Null(generator.GetService<string>());

        Assert.Null(generator.GetService<AmazonBedrockRuntimeClient>("key"));
        Assert.Null(generator.GetService<IAmazonBedrockRuntime>("key"));
        Assert.Null(generator.GetService<IEmbeddingGenerator<string, Embedding<float>>>("key"));
    }
}
