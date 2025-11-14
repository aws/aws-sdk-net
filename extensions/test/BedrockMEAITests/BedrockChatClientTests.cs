using Amazon.BedrockRuntime.Model;
using Amazon.Runtime.Documents;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.BedrockRuntime;

// Mock implementation to capture requests and control responses
internal sealed class MockBedrockRuntime : IAmazonBedrockRuntime
{
    public ConverseRequest CapturedRequest { get; private set; }
    public ConverseStreamRequest CapturedStreamRequest { get; private set; }
    public Func<ConverseRequest, ConverseResponse> ResponseFactory { get; set; }
    public Exception ExceptionToThrow { get; set; }

    public Task<ConverseResponse> ConverseAsync(ConverseRequest request, CancellationToken cancellationToken = default)
    {
        CapturedRequest = request;

        if (ExceptionToThrow != null)
        {
            throw ExceptionToThrow;
        }

        if (ResponseFactory != null)
        {
            return Task.FromResult(ResponseFactory(request));
        }

        // Default response
        return Task.FromResult(new ConverseResponse
        {
            Output = new ConverseOutput
            {
                Message = new Message
                {
                    Role = ConversationRole.Assistant,
                    Content = new List<ContentBlock>
                    {
                        new ContentBlock { Text = "Default response" }
                    }
                }
            },
            StopReason = new StopReason("end_turn")
        });
    }

    public Task<ConverseStreamResponse> ConverseStreamAsync(ConverseStreamRequest request, CancellationToken cancellationToken = default)
    {
        CapturedStreamRequest = request;
        throw new NotImplementedException("Stream testing not implemented in this mock");
    }

    public void Dispose() { }

    // Unused interface members - all throw NotImplementedException
    public IBedrockRuntimePaginatorFactory Paginators => throw new NotImplementedException();
    public Amazon.Runtime.IClientConfig Config => throw new NotImplementedException();

    // Sync methods
    public ApplyGuardrailResponse ApplyGuardrail(ApplyGuardrailRequest request) => throw new NotImplementedException();
    public ConverseResponse Converse(ConverseRequest request) => throw new NotImplementedException();
    public ConverseStreamResponse ConverseStream(ConverseStreamRequest request) => throw new NotImplementedException();
    public CountTokensResponse CountTokens(CountTokensRequest request) => throw new NotImplementedException();
    public GetAsyncInvokeResponse GetAsyncInvoke(GetAsyncInvokeRequest request) => throw new NotImplementedException();
    public InvokeModelResponse InvokeModel(InvokeModelRequest request) => throw new NotImplementedException();
    public InvokeModelWithResponseStreamResponse InvokeModelWithResponseStream(InvokeModelWithResponseStreamRequest request) => throw new NotImplementedException();
    public ListAsyncInvokesResponse ListAsyncInvokes(ListAsyncInvokesRequest request) => throw new NotImplementedException();
    public StartAsyncInvokeResponse StartAsyncInvoke(StartAsyncInvokeRequest request) => throw new NotImplementedException();

    // Async methods
    public Task<ApplyGuardrailResponse> ApplyGuardrailAsync(ApplyGuardrailRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<CountTokensResponse> CountTokensAsync(CountTokensRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<GetAsyncInvokeResponse> GetAsyncInvokeAsync(GetAsyncInvokeRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<InvokeModelResponse> InvokeModelAsync(InvokeModelRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<InvokeModelWithResponseStreamResponse> InvokeModelWithResponseStreamAsync(InvokeModelWithResponseStreamRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<ListAsyncInvokesResponse> ListAsyncInvokesAsync(ListAsyncInvokesRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Task<StartAsyncInvokeResponse> StartAsyncInvokeAsync(StartAsyncInvokeRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();

    // Endpoint determination
    public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(Amazon.Runtime.AmazonWebServiceRequest request) => throw new NotImplementedException();
}

// Simple test implementation of AIFunctionDeclaration
internal sealed class TestAIFunction : AIFunctionDeclaration
{
    public TestAIFunction(string name, string description, JsonElement jsonSchema)
    {
        Name = name;
        Description = description;
        JsonSchema = jsonSchema;
    }

    public override string Name { get; }
    public override string Description { get; }
    public override JsonElement JsonSchema { get; }
}

public class BedrockChatClientTests
{
    #region Basic Client Tests

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
        var mock = new MockBedrockRuntime();
        IChatClient client = mock.AsIChatClient(modelId);

        Assert.NotNull(client);
        Assert.Equal("aws.bedrock", client.GetService<ChatClientMetadata>()?.ProviderName);
        Assert.Equal(modelId, client.GetService<ChatClientMetadata>()?.DefaultModelId);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void AsIChatClient_GetService()
    {
        var mock = new MockBedrockRuntime();
        IChatClient client = mock.AsIChatClient();

        Assert.Same(mock, client.GetService<IAmazonBedrockRuntime>());
        Assert.Same(client, client.GetService<IChatClient>());
        Assert.Null(client.GetService<string>());
        Assert.Null(client.GetService<IAmazonBedrockRuntime>("key"));
    }

    #endregion

    #region ResponseFormat Tests

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WithSchema_CreatesSyntheticToolWithCorrectSchema()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };

        var schemaJson = """
            {
                "type": "object",
                "properties": {
                    "name": { "type": "string" },
                    "age": { "type": "number" }
                },
                "required": ["name"]
            }
            """;
        var schemaElement = JsonDocument.Parse(schemaJson).RootElement;
        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.ForJsonSchema(schemaElement,
                schemaName: "PersonSchema",
                schemaDescription: "A person object")
        };

        // Act
        try
        {
            await client.GetResponseAsync(messages, options);
        }
        catch
        {
            // We're testing request creation
        }

        // Assert
        var tool = mock.CapturedRequest.ToolConfig.Tools[0];
        Assert.Equal("generate_response", tool.ToolSpec.Name);
        Assert.Equal("A person object", tool.ToolSpec.Description);

        // Verify schema structure matches input
        var schema = tool.ToolSpec.InputSchema.Json;
        Assert.True(schema.IsDictionary());
        var schemaDict = schema.AsDictionary();

        Assert.Equal("object", schemaDict["type"].AsString());
        Assert.True(schemaDict.ContainsKey("properties"));

        var properties = schemaDict["properties"].AsDictionary();
        Assert.True(properties.ContainsKey("name"));
        Assert.True(properties.ContainsKey("age"));
        Assert.Equal("string", properties["name"].AsDictionary()["type"].AsString());
        Assert.Equal("number", properties["age"].AsDictionary()["type"].AsString());

        Assert.True(schemaDict.ContainsKey("required"));
        var required = schemaDict["required"].AsList();
        Assert.Single(required);
        Assert.Equal("name", required[0].AsString());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ModelReturnsToolUse_ExtractsJsonCorrectly()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Get weather") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Setup mock to return tool use with structured data
        mock.ResponseFactory = req => new ConverseResponse
        {
            Output = new ConverseOutput
            {
                Message = new Message
                {
                    Role = ConversationRole.Assistant,
                    Content = new List<ContentBlock>
                    {
                        new ContentBlock
                        {
                            ToolUse = new ToolUseBlock
                            {
                                ToolUseId = "test-id",
                                Name = "generate_response",
                                Input = new Document(new Dictionary<string, Document>
                                {
                                    ["city"] = new Document("Seattle"),
                                    ["temperature"] = new Document(72),
                                    ["conditions"] = new Document("sunny")
                                })
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use"),
            Usage = new TokenUsage { InputTokens = 10, OutputTokens = 20, TotalTokens = 30 }
        };

        // Act
        var response = await client.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response);
        Assert.NotNull(response.Text);

        // Parse the JSON to verify structure
        var json = JsonDocument.Parse(response.Text);
        Assert.Equal("Seattle", json.RootElement.GetProperty("city").GetString());
        Assert.Equal(72, json.RootElement.GetProperty("temperature").GetInt32());
        Assert.Equal("sunny", json.RootElement.GetProperty("conditions").GetString());
    }

    #endregion
}
