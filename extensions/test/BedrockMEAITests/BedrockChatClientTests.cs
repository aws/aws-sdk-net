using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Documents;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.Extensions.AI;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.BedrockRuntime;

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
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();
        IChatClient client = mockRuntime.Object.AsIChatClient(modelId);

        Assert.NotNull(client);
        Assert.Equal("aws.bedrock", client.GetService<ChatClientMetadata>()?.ProviderName);
        Assert.Equal(modelId, client.GetService<ChatClientMetadata>()?.DefaultModelId);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void AsIChatClient_GetService()
    {
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();
        IChatClient client = mockRuntime.Object.AsIChatClient();

        Assert.Same(mockRuntime.Object, client.GetService<IAmazonBedrockRuntime>());
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
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();
        ConverseRequest capturedRequest = null;

        mockRuntime
            .Setup(x => x.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
            .Callback<ConverseRequest, CancellationToken>((req, ct) => capturedRequest = req)
            .ReturnsAsync(new ConverseResponse
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
                                        ["name"] = new Document("John Doe"),
                                        ["age"] = new Document(30)
                                    })
                                }
                            }
                        }
                    }
                },
                StopReason = new StopReason("tool_use")
            });

        var client = mockRuntime.Object.AsIChatClient("claude-3");
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
        await client.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(capturedRequest);
        var tool = capturedRequest.ToolConfig.Tools[0];
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

        // Verify the mock was called
        mockRuntime.Verify(x => x.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ModelReturnsToolUse_ExtractsJsonCorrectly()
    {
        // Arrange
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();

        // Setup mock to return tool use with structured data
        mockRuntime
            .Setup(x => x.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ConverseResponse
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
            });

        var client = mockRuntime.Object.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Get weather") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

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
    public async Task ResponseFormat_Json_WithTools_ThrowsArgumentException()
    {
        // Arrange
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();
        var client = mockRuntime.Object.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };

        // Create test tool
        var tool = new TestAIFunction("test", "Test tool", JsonDocument.Parse("{}").RootElement);

        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.Json,
            Tools = new[] { tool }
        };

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(async () =>
            await client.GetResponseAsync(messages, options));
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_UnsupportedModel_ThrowsNotSupportedException()
    {
        // Arrange
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();

        // Setup mock to throw BedrockRuntimeException with toolChoice error
        mockRuntime
            .Setup(x => x.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
            .ThrowsAsync(new AmazonBedrockRuntimeException("ValidationException: toolChoice is not supported by this model")
            {
                ErrorCode = "ValidationException"
            });

        var client = mockRuntime.Object.AsIChatClient("titan");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<NotSupportedException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("does not support ResponseFormat", ex.Message);
        Assert.Contains("ToolChoice", ex.Message);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ForStreaming_ThrowsNotSupportedException()
    {
        // Arrange
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();
        var client = mockRuntime.Object.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Test") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Act & Assert
        await Assert.ThrowsAsync<NotSupportedException>(async () =>
        {
            await foreach (var update in client.GetStreamingResponseAsync(messages, options))
            {
                // Should not reach here
            }
        });
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_ModelReturnsText_ThrowsInvalidOperationException()
    {
        // Arrange - Model returns text instead of tool_use
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();

        mockRuntime
            .Setup(x => x.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ConverseResponse
            {
                Output = new ConverseOutput
                {
                    Message = new Message
                    {
                        Role = ConversationRole.Assistant,
                        Content = new List<ContentBlock>
                        {
                            new ContentBlock { Text = "Here is some text" }
                        }
                    }
                },
                StopReason = new StopReason("end_turn")
            });

        var client = mockRuntime.Object.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Generate data") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("did not return structured output", ex.Message);
        Assert.Contains("end_turn", ex.Message);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WrongToolName_ThrowsInvalidOperationException()
    {
        // Arrange - Model uses wrong tool name
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();

        mockRuntime
            .Setup(x => x.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ConverseResponse
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
                                    ToolUseId = "wrong-id",
                                    Name = "wrong_tool_name",
                                    Input = new Document(new Dictionary<string, Document>
                                    {
                                        ["data"] = new Document("value")
                                    })
                                }
                            }
                        }
                    }
                },
                StopReason = new StopReason("tool_use")
            });

        var client = mockRuntime.Object.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Generate data") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Act & Assert
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("did not return structured output", ex.Message);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_EmptyToolInput_ReturnsEmptyJson()
    {
        // Arrange - Tool with empty input
        var mockRuntime = new Mock<IAmazonBedrockRuntime>();

        mockRuntime
            .Setup(x => x.ConverseAsync(It.IsAny<ConverseRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ConverseResponse
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
                                    ToolUseId = "empty-id",
                                    Name = "generate_response",
                                    Input = new Document(new Dictionary<string, Document>())
                                }
                            }
                        }
                    }
                },
                StopReason = new StopReason("tool_use")
            });

        var client = mockRuntime.Object.AsIChatClient("claude-3");
        var messages = new[] { new ChatMessage(ChatRole.User, "Generate data") };
        var options = new ChatOptions { ResponseFormat = ChatResponseFormat.Json };

        // Act
        var response = await client.GetResponseAsync(messages, options);

        // Assert - Empty object is valid JSON
        Assert.NotNull(response.Text);
        var json = JsonDocument.Parse(response.Text);
        Assert.Equal(JsonValueKind.Object, json.RootElement.ValueKind);
    }

    #endregion
}

/// <summary>
/// Tests using HTTP-layer mocking to test actual Converse API response scenarios.
/// This allows testing beyond the happy path with realistic service responses.
/// Based on Peter's (peterrsongg) suggestion to test different response structures.
/// </summary>
public class BedrockChatClientHttpMockedTests : IClassFixture<BedrockChatClientHttpMockedTests.HttpMockFixture>
{
    private readonly HttpMockFixture _fixture;

    public BedrockChatClientHttpMockedTests(HttpMockFixture fixture)
    {
        _fixture = fixture;
    }

    /// <summary>
    /// Helper method to inject stubbed web response data into a request's state
    /// </summary>
    private static void InjectMockedResponse(ConverseRequest request, StubWebResponseData webResponseData)
    {
        var interfaceType = typeof(IAmazonWebServiceRequest);
        var requestStatePropertyInfo = interfaceType.GetProperty("RequestState");
        var requestState = (Dictionary<string, object>)requestStatePropertyInfo.GetValue(request);
        requestState["response"] = webResponseData;
    }

    #region HTTP Mocking Infrastructure (Based on Peter's Working Code)

    /// <summary>
    /// Pipeline customizer that replaces the HTTP handler with a mock implementation
    /// </summary>
    private class MockPipelineCustomizer : IRuntimePipelineCustomizer
    {
        public string UniqueName => "BedrockMEAIMockPipeline";

        public void Customize(Type type, RuntimePipeline pipeline)
        {
#if BCL
            // On .NET Framework, use Stream
            pipeline.ReplaceHandler<HttpHandler<Stream>>(
                new HttpHandler<Stream>(new MockHttpRequestFactory(), new object()));
#else
            // On .NET Core/.NET 5+, use HttpContent
            pipeline.ReplaceHandler<HttpHandler<HttpContent>>(
                new HttpHandler<HttpContent>(new MockHttpRequestFactory(), new object()));
#endif
        }
    }

    /// <summary>
    /// Factory for creating mock HTTP requests
    /// </summary>
#if BCL
    private class MockHttpRequestFactory : IHttpRequestFactory<Stream>
    {
        public IHttpRequest<Stream> CreateHttpRequest(Uri requestUri)
        {
            return new MockHttpRequest(requestUri);
        }
#else
    private class MockHttpRequestFactory : IHttpRequestFactory<HttpContent>
    {
        public IHttpRequest<HttpContent> CreateHttpRequest(Uri requestUri)
        {
            return new MockHttpRequest(requestUri);
        }
#endif

        public void Dispose()
        {
            // No resources to dispose
        }
    }

    /// <summary>
    /// Mock HTTP request that retrieves stubbed response data from request state
    /// </summary>
#if BCL
    private class MockHttpRequest : IHttpRequest<Stream>
#else
    private class MockHttpRequest : IHttpRequest<HttpContent>
#endif
    {
        private IWebResponseData _webResponseData;

        public MockHttpRequest(Uri requestUri)
        {
            RequestUri = requestUri;
        }

        public string Method { get; set; }
        public Uri RequestUri { get; set; }
        public Version HttpProtocolVersion { get; set; }

        public void ConfigureRequest(IRequestContext requestContext)
        {
            // Retrieve the stubbed response from request state
            // This is the critical line that Peter identified (line 60 in his comment)
            var request = requestContext.OriginalRequest as IAmazonWebServiceRequest;
            if (request != null && request.RequestState.ContainsKey("response"))
            {
                _webResponseData = request.RequestState["response"] as IWebResponseData;
            }
        }

        public void SetRequestHeaders(IDictionary<string, string> headers)
        {
            // Not needed for mock
        }

#if BCL
        public Stream GetRequestContent()
        {
            return new MemoryStream();
        }
#else
        public HttpContent GetRequestContent()
        {
            return null;
        }
#endif

        public IWebResponseData GetResponse()
        {
            return GetResponseAsync(CancellationToken.None).Result;
        }

        public Task<IWebResponseData> GetResponseAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(_webResponseData);
        }

#if BCL
        public void WriteToRequestBody(Stream requestContent, Stream contentStream,
            IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            // Not needed for mock
        }

        public void WriteToRequestBody(Stream requestContent, byte[] content,
            IDictionary<string, string> contentHeaders)
        {
            // Not needed for mock
        }

        public Task WriteToRequestBodyAsync(Stream requestContent, Stream contentStream,
            IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            return Task.CompletedTask;
        }

        public Task WriteToRequestBodyAsync(Stream requestContent, byte[] content,
            IDictionary<string, string> contentHeaders, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
#else
        public void WriteToRequestBody(HttpContent requestContent, Stream contentStream,
            IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            // Not needed for mock
        }

        public void WriteToRequestBody(HttpContent requestContent, byte[] content,
            IDictionary<string, string> contentHeaders)
        {
            // Not needed for mock
        }

        public Task WriteToRequestBodyAsync(HttpContent requestContent, Stream contentStream,
            IDictionary<string, string> contentHeaders, IRequestContext requestContext)
        {
            return Task.CompletedTask;
        }

        public Task WriteToRequestBodyAsync(HttpContent requestContent, byte[] content,
            IDictionary<string, string> contentHeaders, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }
#endif

        public IHttpRequestStreamHandle SetupHttpRequestStreamPublisher(
            IDictionary<string, string> contentHeaders, IHttpRequestStreamPublisher publisher)
        {
            throw new NotImplementedException();
        }

        public void Abort()
        {
            // Not needed for mock
        }

#if BCL
        public Task<Stream> GetRequestContentAsync()
        {
            return Task.FromResult<Stream>(new MemoryStream());
        }

        public Task<Stream> GetRequestContentAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult<Stream>(new MemoryStream());
        }
#else
        public Task<HttpContent> GetRequestContentAsync()
        {
            return Task.FromResult<HttpContent>(null);
        }

        public Task<HttpContent> GetRequestContentAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult<HttpContent>(null);
        }
#endif

        public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval,
            object sender, EventHandler<StreamTransferProgressArgs> callback)
        {
            return originalStream;
        }

        public void Dispose()
        {
            // Nothing to dispose
        }
    }

    /// <summary>
    /// Stubbed web response data for testing different response scenarios
    /// </summary>
    private class StubWebResponseData : IWebResponseData
    {
        private readonly IHttpResponseBody _httpResponseBody;

        public StubWebResponseData(string jsonResponse, Dictionary<string, string> headers = null,
            HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            StatusCode = statusCode;
            IsSuccessStatusCode = (int)statusCode >= 200 && (int)statusCode < 300;
            JsonResponse = jsonResponse;
            Headers = headers ?? new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            ContentType = "application/json";
            ContentLength = jsonResponse?.Length ?? 0;

            _httpResponseBody = new HttpResponseBody(jsonResponse);
        }

        public Dictionary<string, string> Headers { get; set; }
        public string JsonResponse { get; }
        public long ContentLength { get; set; }
        public string ContentType { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; set; }

        public IHttpResponseBody ResponseBody => _httpResponseBody;

        public string[] GetHeaderNames()
        {
            return Headers.Keys.ToArray();
        }

        public bool IsHeaderPresent(string headerName)
        {
            return Headers.ContainsKey(headerName);
        }

        public string GetHeaderValue(string headerName)
        {
            return Headers.ContainsKey(headerName) ? Headers[headerName] : null;
        }
    }

    /// <summary>
    /// HTTP response body implementation for stubbed responses
    /// </summary>
    private class HttpResponseBody : IHttpResponseBody
    {
        private readonly string _jsonResponse;
        private Stream _stream;

        public HttpResponseBody(string jsonResponse)
        {
            _jsonResponse = jsonResponse ?? string.Empty;
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }

        public Stream OpenResponse()
        {
            _stream = new MemoryStream(Encoding.UTF8.GetBytes(_jsonResponse));
            return _stream;
        }

        public Task<Stream> OpenResponseAsync()
        {
            return Task.FromResult(OpenResponse());
        }
    }

    #endregion

    #region ResponseFormat with HTTP Mocking Tests

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WithActualConverseResponse_ParsesCorrectly()
    {
        // Arrange - This is a real Converse API response with tool_use
        var converseResponse = """
            {
                "output": {
                    "message": {
                        "role": "assistant",
                        "content": [
                            {
                                "toolUse": {
                                    "toolUseId": "tooluse_12345",
                                    "name": "generate_response",
                                    "input": {
                                        "name": "Alice Johnson",
                                        "age": 28,
                                        "city": "Seattle"
                                    }
                                }
                            }
                        ]
                    }
                },
                "stopReason": "tool_use",
                "usage": {
                    "inputTokens": 125,
                    "outputTokens": 45,
                    "totalTokens": 170
                }
            }
            """;

        var chatClient = _fixture.BedrockRuntimeClient.AsIChatClient("anthropic.claude-3-sonnet-20240229-v1:0");
        var messages = new[] { new ChatMessage(ChatRole.User, "Generate a person") };

        var schemaJson = """
            {
                "type": "object",
                "properties": {
                    "name": { "type": "string" },
                    "age": { "type": "number" },
                    "city": { "type": "string" }
                },
                "required": ["name", "age"]
            }
            """;
        var schemaElement = JsonDocument.Parse(schemaJson).RootElement;

        var request = new ConverseRequest();
        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.ForJsonSchema(schemaElement,
                schemaName: "PersonSchema",
                schemaDescription: "A person with demographic information"),
            RawRepresentationFactory = _ => request
        };

        // Inject the stubbed response
        var webResponseData = new StubWebResponseData(converseResponse);
        InjectMockedResponse(request, webResponseData);

        // Act
        var response = await chatClient.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response);
        Assert.NotNull(response.Text);

        // Verify the JSON structure
        var json = JsonDocument.Parse(response.Text);
        Assert.Equal("Alice Johnson", json.RootElement.GetProperty("name").GetString());
        Assert.Equal(28, json.RootElement.GetProperty("age").GetInt32());
        Assert.Equal("Seattle", json.RootElement.GetProperty("city").GetString());

        // Verify usage metadata
        var usage = response.Usage;
        Assert.NotNull(usage);
        Assert.Equal(125, usage.InputTokenCount);
        Assert.Equal(45, usage.OutputTokenCount);
        Assert.Equal(170, usage.TotalTokenCount);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WithNestedObjects_ParsesCorrectly()
    {
        // Arrange - Test with nested JSON structure
        var converseResponse = """
            {
                "output": {
                    "message": {
                        "role": "assistant",
                        "content": [
                            {
                                "toolUse": {
                                    "toolUseId": "tooluse_nested",
                                    "name": "generate_response",
                                    "input": {
                                        "user": {
                                            "name": "Bob Smith",
                                            "contact": {
                                                "email": "bob@example.com",
                                                "phone": "555-0123"
                                            }
                                        },
                                        "metadata": {
                                            "timestamp": "2024-01-15T10:30:00Z",
                                            "version": 1
                                        }
                                    }
                                }
                            }
                        ]
                    }
                },
                "stopReason": "tool_use",
                "usage": {
                    "inputTokens": 200,
                    "outputTokens": 80,
                    "totalTokens": 280
                }
            }
            """;

        var chatClient = _fixture.BedrockRuntimeClient.AsIChatClient("anthropic.claude-3-sonnet-20240229-v1:0");
        var messages = new[] { new ChatMessage(ChatRole.User, "Generate user data") };

        var request = new ConverseRequest();
        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.Json,
            RawRepresentationFactory = _ => request
        };

        var webResponseData = new StubWebResponseData(converseResponse);
        InjectMockedResponse(request, webResponseData);

        // Act
        var response = await chatClient.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response.Text);
        var json = JsonDocument.Parse(response.Text);

        var user = json.RootElement.GetProperty("user");
        Assert.Equal("Bob Smith", user.GetProperty("name").GetString());

        var contact = user.GetProperty("contact");
        Assert.Equal("bob@example.com", contact.GetProperty("email").GetString());
        Assert.Equal("555-0123", contact.GetProperty("phone").GetString());

        var metadata = json.RootElement.GetProperty("metadata");
        Assert.Equal("2024-01-15T10:30:00Z", metadata.GetProperty("timestamp").GetString());
        Assert.Equal(1, metadata.GetProperty("version").GetInt32());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WithArrayData_ParsesCorrectly()
    {
        // Arrange - Test with arrays in JSON response
        var converseResponse = """
            {
                "output": {
                    "message": {
                        "role": "assistant",
                        "content": [
                            {
                                "toolUse": {
                                    "toolUseId": "tooluse_array",
                                    "name": "generate_response",
                                    "input": {
                                        "items": ["apple", "banana", "orange"],
                                        "prices": [1.99, 0.99, 2.49],
                                        "inventory": {
                                            "warehouse": "A",
                                            "quantities": [100, 250, 75]
                                        }
                                    }
                                }
                            }
                        ]
                    }
                },
                "stopReason": "tool_use",
                "usage": {
                    "inputTokens": 50,
                    "outputTokens": 30,
                    "totalTokens": 80
                }
            }
            """;

        var chatClient = _fixture.BedrockRuntimeClient.AsIChatClient("anthropic.claude-3-sonnet-20240229-v1:0");
        var messages = new[] { new ChatMessage(ChatRole.User, "List items") };

        var request = new ConverseRequest();
        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.Json,
            RawRepresentationFactory = _ => request
        };

        var webResponseData = new StubWebResponseData(converseResponse);
        InjectMockedResponse(request, webResponseData);

        // Act
        var response = await chatClient.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response.Text);
        var json = JsonDocument.Parse(response.Text);

        var items = json.RootElement.GetProperty("items");
        Assert.Equal(JsonValueKind.Array, items.ValueKind);
        Assert.Equal(3, items.GetArrayLength());
        Assert.Equal("apple", items[0].GetString());
        Assert.Equal("banana", items[1].GetString());
        Assert.Equal("orange", items[2].GetString());

        var prices = json.RootElement.GetProperty("prices");
        Assert.Equal(3, prices.GetArrayLength());
        Assert.Equal(1.99, prices[0].GetDouble(), precision: 2);

        var inventory = json.RootElement.GetProperty("inventory");
        var quantities = inventory.GetProperty("quantities");
        Assert.Equal(3, quantities.GetArrayLength());
        Assert.Equal(100, quantities[0].GetInt32());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WithMinimalSchema_ParsesCorrectly()
    {
        // Arrange - Test simple JSON response
        var converseResponse = """
            {
                "output": {
                    "message": {
                        "role": "assistant",
                        "content": [
                            {
                                "toolUse": {
                                    "toolUseId": "tooluse_simple",
                                    "name": "generate_response",
                                    "input": {
                                        "message": "Hello, World!",
                                        "status": "success"
                                    }
                                }
                            }
                        ]
                    }
                },
                "stopReason": "tool_use",
                "usage": {
                    "inputTokens": 10,
                    "outputTokens": 5,
                    "totalTokens": 15
                }
            }
            """;

        var chatClient = _fixture.BedrockRuntimeClient.AsIChatClient("anthropic.claude-3-haiku-20240307-v1:0");
        var messages = new[] { new ChatMessage(ChatRole.User, "Say hello") };

        var request = new ConverseRequest();
        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.Json,
            RawRepresentationFactory = _ => request
        };

        var webResponseData = new StubWebResponseData(converseResponse);
        InjectMockedResponse(request, webResponseData);

        // Act
        var response = await chatClient.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response.Text);
        var json = JsonDocument.Parse(response.Text);
        Assert.Equal("Hello, World!", json.RootElement.GetProperty("message").GetString());
        Assert.Equal("success", json.RootElement.GetProperty("status").GetString());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_WithComplexSchema_ValidatesStructure()
    {
        // Arrange - Test with detailed schema validation
        var converseResponse = """
            {
                "output": {
                    "message": {
                        "role": "assistant",
                        "content": [
                            {
                                "toolUse": {
                                    "toolUseId": "tooluse_complex",
                                    "name": "generate_response",
                                    "input": {
                                        "id": "usr_123",
                                        "username": "testuser",
                                        "email": "test@example.com",
                                        "profile": {
                                            "firstName": "Test",
                                            "lastName": "User",
                                            "age": 25,
                                            "preferences": {
                                                "theme": "dark",
                                                "notifications": true
                                            }
                                        },
                                        "roles": ["admin", "user"],
                                        "active": true
                                    }
                                }
                            }
                        ]
                    }
                },
                "stopReason": "tool_use",
                "usage": {
                    "inputTokens": 300,
                    "outputTokens": 150,
                    "totalTokens": 450
                }
            }
            """;

        var chatClient = _fixture.BedrockRuntimeClient.AsIChatClient("anthropic.claude-3-sonnet-20240229-v1:0");
        var messages = new[] { new ChatMessage(ChatRole.User, "Generate user profile") };

        var schemaJson = """
            {
                "type": "object",
                "properties": {
                    "id": { "type": "string" },
                    "username": { "type": "string" },
                    "email": { "type": "string", "format": "email" },
                    "profile": {
                        "type": "object",
                        "properties": {
                            "firstName": { "type": "string" },
                            "lastName": { "type": "string" },
                            "age": { "type": "number" },
                            "preferences": { "type": "object" }
                        },
                        "required": ["firstName", "lastName"]
                    },
                    "roles": {
                        "type": "array",
                        "items": { "type": "string" }
                    },
                    "active": { "type": "boolean" }
                },
                "required": ["id", "username", "email"]
            }
            """;
        var schemaElement = JsonDocument.Parse(schemaJson).RootElement;

        var request = new ConverseRequest();
        var options = new ChatOptions
        {
            ResponseFormat = ChatResponseFormat.ForJsonSchema(schemaElement,
                schemaName: "UserProfile",
                schemaDescription: "Complete user profile with preferences"),
            RawRepresentationFactory = _ => request
        };

        var webResponseData = new StubWebResponseData(converseResponse);
        InjectMockedResponse(request, webResponseData);

        // Act
        var response = await chatClient.GetResponseAsync(messages, options);

        // Assert
        Assert.NotNull(response.Text);
        var json = JsonDocument.Parse(response.Text);

        // Verify required fields
        Assert.Equal("usr_123", json.RootElement.GetProperty("id").GetString());
        Assert.Equal("testuser", json.RootElement.GetProperty("username").GetString());
        Assert.Equal("test@example.com", json.RootElement.GetProperty("email").GetString());

        // Verify nested profile
        var profile = json.RootElement.GetProperty("profile");
        Assert.Equal("Test", profile.GetProperty("firstName").GetString());
        Assert.Equal("User", profile.GetProperty("lastName").GetString());
        Assert.Equal(25, profile.GetProperty("age").GetInt32());

        // Verify nested preferences
        var preferences = profile.GetProperty("preferences");
        Assert.Equal("dark", preferences.GetProperty("theme").GetString());
        Assert.True(preferences.GetProperty("notifications").GetBoolean());

        // Verify array
        var roles = json.RootElement.GetProperty("roles");
        Assert.Equal(2, roles.GetArrayLength());
        Assert.Equal("admin", roles[0].GetString());
        Assert.Equal("user", roles[1].GetString());

        // Verify boolean
        Assert.True(json.RootElement.GetProperty("active").GetBoolean());
    }

    #endregion

    /// <summary>
    /// Test fixture that registers the HTTP mocking pipeline customizer
    /// </summary>
    public class HttpMockFixture : IDisposable
    {
        private readonly MockPipelineCustomizer _customizer;

        public HttpMockFixture()
        {
            // Register the mock pipeline customizer globally
            _customizer = new MockPipelineCustomizer();
            Runtime.Internal.RuntimePipelineCustomizerRegistry.Instance.Register(_customizer);

            // Create the Bedrock Runtime client - it will use the mocked pipeline
            BedrockRuntimeClient = new AmazonBedrockRuntimeClient();
        }

        public IAmazonBedrockRuntime BedrockRuntimeClient { get; private set; }

        public void Dispose()
        {
            // Clean up
            Runtime.Internal.RuntimePipelineCustomizerRegistry.Instance.Deregister(_customizer);
            BedrockRuntimeClient?.Dispose();
        }
    }
}