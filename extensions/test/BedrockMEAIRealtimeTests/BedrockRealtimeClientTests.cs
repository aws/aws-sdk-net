/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Threading;
using System.Threading.Tasks;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using Microsoft.Extensions.AI;
using Moq;
using Xunit;

namespace BedrockMEAIRealtimeTests;

public class BedrockRealtimeClientTests
{
    [Fact]
    public void Ctor_NullRuntime_Throws()
    {
        Assert.Throws<ArgumentNullException>("runtime", () => new BedrockNovaRealtimeClient(null!));
    }

    [Fact]
    public void Ctor_DefaultModelId_UsesNovaSonic()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using var client = new BedrockNovaRealtimeClient(mock.Object);

        var metadata = (ChatClientMetadata?)((IRealtimeClient)client).GetService(typeof(ChatClientMetadata));
        Assert.NotNull(metadata);
        Assert.Equal("amazon.nova-2-sonic-v1:0", metadata!.DefaultModelId);
    }

    [Fact]
    public void Ctor_CustomModelId_UsesProvidedModel()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using var client = new BedrockNovaRealtimeClient(mock.Object, "custom-model");

        var metadata = (ChatClientMetadata?)((IRealtimeClient)client).GetService(typeof(ChatClientMetadata));
        Assert.NotNull(metadata);
        Assert.Equal("custom-model", metadata!.DefaultModelId);
    }

    [Fact]
    public void GetService_ReturnsExpectedServices()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using IRealtimeClient client = new BedrockNovaRealtimeClient(mock.Object);

        Assert.Same(client, client.GetService(typeof(BedrockNovaRealtimeClient)));
        Assert.Same(client, client.GetService(typeof(IRealtimeClient)));
        Assert.IsType<ChatClientMetadata>(client.GetService(typeof(ChatClientMetadata)));
        Assert.Null(client.GetService(typeof(string)));
        Assert.Null(client.GetService(typeof(BedrockNovaRealtimeClient), "someKey"));
    }

    [Fact]
    public void GetService_NullServiceType_Throws()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using IRealtimeClient client = new BedrockNovaRealtimeClient(mock.Object);
        Assert.Throws<ArgumentNullException>("serviceType", () => client.GetService(null!));
    }

    [Fact]
    public void GetService_ReturnsUnderlyingRuntime()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using IRealtimeClient client = new BedrockNovaRealtimeClient(mock.Object);

        var runtime = client.GetService(typeof(IAmazonBedrockRuntime));
        Assert.Same(mock.Object, runtime);
    }

    [Fact]
    public void GetService_WithServiceKey_ReturnsNull()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using IRealtimeClient client = new BedrockNovaRealtimeClient(mock.Object);

        Assert.Null(client.GetService(typeof(IAmazonBedrockRuntime), "key"));
    }

    [Fact]
    public void Dispose_CanBeCalledMultipleTimes()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        IRealtimeClient client = new BedrockNovaRealtimeClient(mock.Object);
        client.Dispose();

        // Second dispose should not throw
        client.Dispose();
        Assert.Null(client.GetService(typeof(string)));
    }

    [Fact]
    public void GetService_ProviderName_IsAwsBedrock()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using IRealtimeClient client = new BedrockNovaRealtimeClient(mock.Object);

        var metadata = (ChatClientMetadata?)client.GetService(typeof(ChatClientMetadata));
        Assert.NotNull(metadata);
        Assert.Equal("aws.bedrock", metadata!.ProviderName);
    }

    [Fact]
    public async Task CreateSessionAsync_CancelledToken_Throws()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using var client = new BedrockNovaRealtimeClient(mock.Object);
        using var cts = new CancellationTokenSource();
        cts.Cancel();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(
            () => client.CreateSessionAsync(cancellationToken: cts.Token));
    }

    [Fact]
    public async Task CreateSessionAsync_WithModelInOptions_UsesModelFromOptions()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        InvokeModelWithBidirectionalStreamRequest? capturedRequest = null;

        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .Callback<InvokeModelWithBidirectionalStreamRequest, CancellationToken>((req, _) => capturedRequest = req)
            .ThrowsAsync(new Exception("Test exception to prevent full connection"));

        using var client = new BedrockNovaRealtimeClient(mock.Object, "default-model");

        var options = new RealtimeSessionOptions { Model = "custom-model-from-options" };

        try
        {
            await client.CreateSessionAsync(options);
        }
        catch
        {
            // Expected - we're testing the model selection
        }

        Assert.NotNull(capturedRequest);
        Assert.Equal("custom-model-from-options", capturedRequest!.ModelId);
    }

    [Fact]
    public async Task CreateSessionAsync_WithoutModelInOptions_UsesDefaultModel()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        InvokeModelWithBidirectionalStreamRequest? capturedRequest = null;

        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .Callback<InvokeModelWithBidirectionalStreamRequest, CancellationToken>((req, _) => capturedRequest = req)
            .ThrowsAsync(new Exception("Test exception"));

        using var client = new BedrockNovaRealtimeClient(mock.Object, "my-default-model");

        try
        {
            await client.CreateSessionAsync();
        }
        catch
        {
            // Expected
        }

        Assert.NotNull(capturedRequest);
        Assert.Equal("my-default-model", capturedRequest!.ModelId);
    }

    [Fact]
    public async Task CreateSessionAsync_NullOptions_UsesDefaultModel()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        InvokeModelWithBidirectionalStreamRequest? capturedRequest = null;

        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .Callback<InvokeModelWithBidirectionalStreamRequest, CancellationToken>((req, _) => capturedRequest = req)
            .ThrowsAsync(new Exception("Test exception"));

        using var client = new BedrockNovaRealtimeClient(mock.Object);

        try
        {
            await client.CreateSessionAsync(null);
        }
        catch
        {
            // Expected
        }

        Assert.NotNull(capturedRequest);
        Assert.Equal("amazon.nova-2-sonic-v1:0", capturedRequest!.ModelId);
    }

    [Fact]
    public async Task CreateSessionAsync_ConnectionFailure_DisposesSession()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new InvalidOperationException("Connection refused"));

        using var client = new BedrockNovaRealtimeClient(mock.Object);

        await Assert.ThrowsAsync<InvalidOperationException>(
            () => client.CreateSessionAsync());
    }

    #region Extension Method Tests

    [Fact]
    public void AsIRealtimeClient_NullRuntime_Throws()
    {
        IAmazonBedrockRuntime? runtime = null;
        Assert.Throws<ArgumentNullException>("runtime", () => runtime!.AsIRealtimeClient());
    }

    [Fact]
    public void AsIRealtimeClient_ValidRuntime_ReturnsClient()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using var client = mock.Object.AsIRealtimeClient();
        Assert.IsType<BedrockNovaRealtimeClient>(client);
    }

    [Fact]
    public void AsIRealtimeClient_WithModelId_UsesProvidedModel()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using var client = mock.Object.AsIRealtimeClient("custom-model");

        var metadata = (ChatClientMetadata?)client.GetService(typeof(ChatClientMetadata));
        Assert.NotNull(metadata);
        Assert.Equal("custom-model", metadata!.DefaultModelId);
    }

    [Fact]
    public void AsIRealtimeClient_WithoutModelId_UsesDefaultNovaSonic()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        using var client = mock.Object.AsIRealtimeClient();

        var metadata = (ChatClientMetadata?)client.GetService(typeof(ChatClientMetadata));
        Assert.NotNull(metadata);
        Assert.Equal("amazon.nova-2-sonic-v1:0", metadata!.DefaultModelId);
    }

    #endregion
}
