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

    #region Synthetic Tool Creation Tests

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WithoutSchema_CreatesSyntheticToolWithGenericObjectSchema()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Act
        try
        {
            await client.GetResponseAsync(messages, options);
        }
        catch
        {
            // We're testing request creation, not response processing
        }

        // Assert - Verify synthetic tool was created correctly
        Assert.NotNull(mock.CapturedRequest);
        Assert.NotNull(mock.CapturedRequest.ToolConfig);
        Assert.NotNull(mock.CapturedRequest.ToolConfig.Tools);
        Assert.Single(mock.CapturedRequest.ToolConfig.Tools);

        var tool = mock.CapturedRequest.ToolConfig.Tools[0];
        Assert.NotNull(tool.ToolSpec);
        Assert.Equal("generate_response", tool.ToolSpec.Name);
        Assert.Equal("Generate response in specified format", tool.ToolSpec.Description);

        // Verify schema is generic object schema
        var schema = tool.ToolSpec.InputSchema.Json;
        Assert.True(schema.IsDictionary());
        var schemaDict = schema.AsDictionary();
        Assert.True(schemaDict.ContainsKey("type"));
        Assert.Equal("object", schemaDict["type"].AsString());
        Assert.True(schemaDict.ContainsKey("additionalProperties"));
        Assert.True(schemaDict["additionalProperties"].AsBool());

        // Verify ToolChoice forces the synthetic tool
        Assert.NotNull(mock.CapturedRequest.ToolConfig.ToolChoice);
        Assert.NotNull(mock.CapturedRequest.ToolConfig.ToolChoice.Tool);
        Assert.Equal("generate_response", mock.CapturedRequest.ToolConfig.ToolChoice.Tool.Name);
    }

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
    public async Task ResponseFormat_Json_WithTools_ThrowsArgumentException()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };

        var toolSchema = JsonDocument.Parse("""{"type": "object"}""").RootElement;
        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.Json,
            Tools = new List<AITool>
            {
                new TestAIFunction("test_tool", "Test", toolSchema)
            }
        };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<ArgumentException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("ResponseFormat cannot be used with Tools", ex.Message);
        Assert.Contains("Bedrock's tool mechanism", ex.Message);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Text_DoesNotCreateSyntheticTool()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Text };

        // Act
        await client.GetResponseAsync(messages, options);

        // Assert - No synthetic tool should be created for Text format
        Assert.True(mock.CapturedRequest.ToolConfig == null ||
                   mock.CapturedRequest.ToolConfig.Tools == null ||
                   mock.CapturedRequest.ToolConfig.Tools.Count == 0);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_NotSet_DoesNotCreateSyntheticTool()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };

        // Act
        await client.GetResponseAsync(messages);

        // Assert
        Assert.True(mock.CapturedRequest.ToolConfig == null ||
                   mock.CapturedRequest.ToolConfig.Tools == null ||
                   mock.CapturedRequest.ToolConfig.Tools.Count == 0);
    }

    #endregion

    #region Response Extraction Tests

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

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ModelReturnsComplexNestedData_ExtractsCorrectly()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Setup complex nested structure
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
                                    ["user"] = new Document(new Dictionary<string, Document>
                                    {
                                        ["name"] = new Document("John"),
                                        ["age"] = new Document(30),
                                        ["active"] = new Document(true)
                                    }),
                                    ["scores"] = new Document(new Document[]
                                    {
                                        new Document(85),
                                        new Document(92),
                                        new Document(78)
                                    }),
                                    ["metadata"] = new Document(new Dictionary<string, Document>
                                    {
                                        ["version"] = new Document(1.5),
                                        ["tags"] = new Document(new Document[]
                                        {
                                            new Document("test"),
                                            new Document("production")
                                        })
                                    })
                                })
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use")
        };

        // Act
        var response = await client.GetResponseAsync(messages, options);
        var json = JsonDocument.Parse(response.Text);

        // Assert nested object
        var user = json.RootElement.GetProperty("user");
        Assert.Equal("John", user.GetProperty("name").GetString());
        Assert.Equal(30, user.GetProperty("age").GetInt32());
        Assert.True(user.GetProperty("active").GetBoolean());

        // Assert array
        var scores = json.RootElement.GetProperty("scores");
        Assert.Equal(JsonValueKind.Array, scores.ValueKind);
        Assert.Equal(3, scores.GetArrayLength());
        Assert.Equal(85, scores[0].GetInt32());

        // Assert nested object with array
        var metadata = json.RootElement.GetProperty("metadata");
        Assert.Equal(1.5, metadata.GetProperty("version").GetDouble());
        var tags = metadata.GetProperty("tags");
        Assert.Equal(2, tags.GetArrayLength());
        Assert.Equal("test", tags[0].GetString());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ModelReturnsNoToolUse_ThrowsInvalidOperationException()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Mock returns text instead of tool use
        mock.ResponseFactory = req => new ConverseResponse
        {
            Output = new ConverseOutput
            {
                Message = new Message
                {
                    Role = ConversationRole.Assistant,
                    Content = new List<ContentBlock>
                    {
                        new ContentBlock { Text = "Regular text response" }
                    }
                }
            },
            StopReason = new StopReason("end_turn")
        };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("did not return structured output", ex.Message);
        Assert.Contains("StopReason", ex.Message);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ModelReturnsWrongToolName_ThrowsInvalidOperationException()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Mock returns tool use with wrong name
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
                                Name = "different_tool", // Wrong name!
                                Input = new Document(new Dictionary<string, Document>())
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use")
        };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("did not return structured output", ex.Message);
    }

    #endregion

    #region Document to JSON Conversion Tests

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task DocumentToJson_AllPrimitiveTypes_ConvertCorrectly()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

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
                                    ["stringVal"] = new Document("hello"),
                                    ["intVal"] = new Document(42),
                                    ["longVal"] = new Document(9876543210L),
                                    ["doubleVal"] = new Document(3.14159),
                                    ["boolTrue"] = new Document(true),
                                    ["boolFalse"] = new Document(false)
                                })
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use")
        };

        // Act
        var response = await client.GetResponseAsync(messages, options);
        var json = JsonDocument.Parse(response.Text);

        // Assert all types
        Assert.Equal("hello", json.RootElement.GetProperty("stringVal").GetString());
        Assert.Equal(42, json.RootElement.GetProperty("intVal").GetInt32());
        Assert.Equal(9876543210L, json.RootElement.GetProperty("longVal").GetInt64());
        Assert.Equal(3.14159, json.RootElement.GetProperty("doubleVal").GetDouble(), precision: 5);
        Assert.True(json.RootElement.GetProperty("boolTrue").GetBoolean());
        Assert.False(json.RootElement.GetProperty("boolFalse").GetBoolean());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task DocumentToJson_EmptyObjects_ConvertCorrectly()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

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
                                    ["emptyObject"] = new Document(new Dictionary<string, Document>()),
                                    ["emptyArray"] = new Document(new Document[] { })
                                })
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use")
        };

        // Act
        var response = await client.GetResponseAsync(messages, options);
        var json = JsonDocument.Parse(response.Text);

        // Assert
        Assert.Equal(JsonValueKind.Object, json.RootElement.GetProperty("emptyObject").ValueKind);
        Assert.Empty(json.RootElement.GetProperty("emptyObject").EnumerateObject());

        Assert.Equal(JsonValueKind.Array, json.RootElement.GetProperty("emptyArray").ValueKind);
        Assert.Equal(0, json.RootElement.GetProperty("emptyArray").GetArrayLength());
    }

    #endregion

    #region Error Handling Tests

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ValidationExceptionWithToolChoice_ThrowsNotSupportedException()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("amazon.titan-text");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Simulate model that doesn't support ToolChoice
        mock.ExceptionToThrow = new AmazonBedrockRuntimeException("ValidationException: toolChoice is not supported for this model")
        {
            ErrorCode = "ValidationException"
        };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<NotSupportedException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("does not support ResponseFormat", ex.Message);
        Assert.Contains("ToolChoice support", ex.Message);
        Assert.Contains("Claude 3+", ex.Message);
        Assert.Contains("Mistral Large", ex.Message);
        Assert.Contains("https://docs.aws.amazon.com/bedrock", ex.Message);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData("toolChoice")]
    [InlineData("tool_choice")]
    [InlineData("ToolChoice")]
    public async Task ResponseFormat_Json_ValidationExceptionWithToolChoiceVariations_AllDetected(string keyword)
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("test-model");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        mock.ExceptionToThrow = new AmazonBedrockRuntimeException($"ValidationException: {keyword} not supported")
        {
            ErrorCode = "ValidationException"
        };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<NotSupportedException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("does not support ResponseFormat", ex.Message);
        Assert.NotNull(ex.InnerException);
        Assert.IsType<AmazonBedrockRuntimeException>(ex.InnerException);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_OtherValidationException_RethrowsOriginal()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Different validation error
        mock.ExceptionToThrow = new AmazonBedrockRuntimeException("ValidationException: Invalid message format")
        {
            ErrorCode = "ValidationException"
        };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<AmazonBedrockRuntimeException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("Invalid message format", ex.Message);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_NonValidationException_RethrowsOriginal()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        mock.ExceptionToThrow = new AmazonBedrockRuntimeException("ThrottlingException: Rate limit exceeded")
        {
            ErrorCode = "ThrottlingException"
        };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<AmazonBedrockRuntimeException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Equal("ThrottlingException", ex.ErrorCode);
    }

    #endregion

    #region Streaming Tests

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_StreamingThrowsNotSupportedException()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<NotSupportedException>(async () =>
        {
            await foreach (var update in client.GetStreamingResponseAsync(messages, options))
            {
                Assert.Fail("Should not get here");
            }
        });

        Assert.Contains("ResponseFormat is not yet supported for streaming", ex.Message);
        Assert.Contains("GetResponseAsync", ex.Message);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Text_StreamingWorks()
    {
        // ResponseFormat.Text should NOT block streaming since it doesn't use synthetic tools
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Text };

        // Should not throw - will throw NotImplementedException from our mock instead
        await Assert.ThrowsAsync<NotImplementedException>(async () =>
        {
            await foreach (var update in client.GetStreamingResponseAsync(messages, options))
            {
            }
        });
    }

    #endregion

    #region Edge Cases and Integration

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_PreservesUsageMetadata()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

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
                                Input = new Document(new Dictionary<string, Document> { ["result"] = new Document("test") })
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use"),
            Usage = new TokenUsage
            {
                InputTokens = 100,
                OutputTokens = 50,
                TotalTokens = 150
            }
        };

        // Act
        var response = await client.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response.Usage);
        Assert.Equal(100, response.Usage.InputTokenCount);
        Assert.Equal(50, response.Usage.OutputTokenCount);
        Assert.Equal(150, response.Usage.TotalTokenCount);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_PreservesFinishReason()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

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
                                Input = new Document(new Dictionary<string, Document>())
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use")
        };

        // Act
        var response = await client.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response.FinishReason);
        Assert.Equal(ChatFinishReason.ToolCalls, response.FinishReason);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_EmptyInput_HandlesGracefully()
    {
        // Arrange
        var mock = new MockBedrockRuntime();
        var client = mock.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

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
                                Input = new Document(new Dictionary<string, Document>()) // Empty object
                            }
                        }
                    }
                }
            },
            StopReason = new StopReason("tool_use")
        };

        // Act
        var response = await client.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response.Text);
        var json = JsonDocument.Parse(response.Text);
        Assert.Equal(JsonValueKind.Object, json.RootElement.ValueKind);
        Assert.Empty(json.RootElement.EnumerateObject());
    }

    #endregion
}
