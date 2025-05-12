using Microsoft.Extensions.AI;
using System;
using Xunit;

namespace Amazon.BedrockRuntime;

public class BedrockChatClientTests
{
    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void AsIChatClient_InvalidArguments_Throws()
    {
        Assert.Throws<ArgumentNullException>("runtime", () => AmazonBedrockRuntimeExtensions.AsIChatClient(null));
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData(null)]
    [InlineData("claude")]
    public void AsIChatClient_ReturnsInstance(string modelId)
    {
        IAmazonBedrockRuntime runtime = new AmazonBedrockRuntimeClient("awsAccessKeyId", "awsSecretAccessKey", RegionEndpoint.USEast1);
        IChatClient client = runtime.AsIChatClient(modelId);

        Assert.NotNull(client);
        Assert.Equal("aws.bedrock", client.GetService<ChatClientMetadata>()?.ProviderName);
        Assert.Equal(modelId, client.GetService<ChatClientMetadata>()?.DefaultModelId);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void AsIChatClient_GetService()
    {
        IAmazonBedrockRuntime runtime = new AmazonBedrockRuntimeClient("awsAccessKeyId", "awsSecretAccessKey", RegionEndpoint.USEast1);
        IChatClient client = runtime.AsIChatClient();

        Assert.Same(runtime, client.GetService<AmazonBedrockRuntimeClient>());
        Assert.Same(runtime, client.GetService<IAmazonBedrockRuntime>());
        Assert.Same(client, client.GetService<IChatClient>());

        Assert.Null(client.GetService<string>());

        Assert.Null(client.GetService<AmazonBedrockRuntimeClient>("key"));
        Assert.Null(client.GetService<IAmazonBedrockRuntime>("key"));
        Assert.Null(client.GetService<IChatClient>("key"));
    }
}
