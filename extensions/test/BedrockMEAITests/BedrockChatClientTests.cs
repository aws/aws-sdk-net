using Amazon.BedrockRuntime.Model;
using Amazon.Runtime.Documents;
using Amazon.Runtime.EventStreams;
using Microsoft.Extensions.AI;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public async Task ResponseFormat_Json_UnsupportedModel_ThrowsValidationException()
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
        var ex = await Assert.ThrowsAsync<AmazonBedrockRuntimeException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Equal("ValidationException", ex.ErrorCode);
        Assert.Contains("toolChoice is not supported", ex.Message);
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

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task ResponseFormat_Json_NullToolInput_ThrowsInvalidOperationException()
    {
        // Arrange - ToolUse with default/null Input (edge case: malformed API response)
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
                                    ToolUseId = "null-input-id",
                                    Name = "generate_response",
                                    Input = default // Default/null Document
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

        // Act & Assert - Should throw InvalidOperationException, not NullReferenceException
        var ex = await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            await client.GetResponseAsync(messages, options));

        Assert.Contains("did not return structured output", ex.Message);
    }



    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void AsIChatClient_ValidArguments_CreatesIChatClientSuccessfully()
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient();
        Assert.NotNull(chatClient);
        Assert.Same(mock, chatClient.GetService<IAmazonBedrockRuntime>());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void IChatClient_GetService_InvalidArguments_Throws()
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient();
        Assert.NotNull(chatClient);

        Assert.Throws<ArgumentNullException>("serviceType", () => chatClient.GetService(null!));
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData(null)]
    [InlineData("anthropic.claude-3-sonnet-20240229-v1:0")]
    public void IChatClient_GetService_ReturnsExpectedInstance(string defaultModelId)
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient(defaultModelId);
        Assert.NotNull(chatClient);

        Assert.Same(mock, chatClient.GetService<IAmazonBedrockRuntime>());
        Assert.Same(chatClient, chatClient.GetService<IChatClient>());

        ChatClientMetadata metadata = chatClient.GetService<ChatClientMetadata>();
        Assert.NotNull(metadata);
        Assert.Equal("aws.bedrock", metadata.ProviderName);
        Assert.Equal(defaultModelId, metadata.DefaultModelId);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void IChatClient_Dispose_Nop()
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient();
        Assert.NotNull(chatClient);

        chatClient.Dispose();

        Assert.Same(mock, chatClient.GetService<IAmazonBedrockRuntime>());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_BasicRequest()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request => CreateResponse("Hello")
        };

        IChatClient chatClient = mock.AsIChatClient("anthropic.claude-3-sonnet-20240229-v1:0");
        ChatResponse result = await chatClient.GetResponseAsync("Hello");
        Assert.NotNull(result);
        Assert.NotNull(result.Messages);
        Assert.Single(result.Messages);
        Assert.Equal(ChatRole.Assistant, result.Messages[0].Role);
        Assert.NotNull(result.Messages[0].MessageId);
        Assert.NotNull(result.ResponseId);
        Assert.NotNull(result.CreatedAt);
        Assert.Equal("Hello", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_TextContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);
                Assert.Single(request.Messages[0].Content);
                Assert.Equal("What is the weather like?", request.Messages[0].Content[0].Text);

                var response = CreateResponse("It's sunny today.");
                response.StopReason = StopReason.End_turn;
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "What is the weather like?")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal(ChatRole.Assistant, result.Messages[0].Role);
        Assert.IsType<TextContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal("It's sunny today.", ((TextContent)result.Messages[0].Contents[0]).Text);
        Assert.Equal(ChatFinishReason.Stop, result.FinishReason);
        Assert.NotNull(result.Messages[0].RawRepresentation);
        Assert.NotNull(((TextContent)result.Messages[0].Contents[0]).RawRepresentation);
        Assert.NotNull(result.RawRepresentation);
        Assert.NotNull(result.Usage);
        Assert.Equal(10, result.Usage.InputTokenCount);
        Assert.Equal(5, result.Usage.OutputTokenCount);
        Assert.Equal(15, result.Usage.TotalTokenCount);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_EmptyMessages_CreatesDefaultMessage()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);
                Assert.Single(request.Messages[0].Content);
                Assert.Equal("\u200B", request.Messages[0].Content[0].Text);

                return CreateResponse("Empty input received");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("Empty input received", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_NullMessages_Throws()
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient("claude");

        await Assert.ThrowsAsync<ArgumentNullException>("messages", () => chatClient.GetResponseAsync(null!));
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_DataContent_Image()
    {
        byte[] imageData = [0x89, 0x50, 0x4E, 0x47];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);
                Assert.Equal(2, request.Messages[0].Content.Count);
                Assert.Equal("Describe this image", request.Messages[0].Content[0].Text);
                Assert.NotNull(request.Messages[0].Content[1].Image);
                Assert.Equal(ImageFormat.Png, request.Messages[0].Content[1].Image.Format);
                Assert.True(request.Messages[0].Content[1].Image.Source.Bytes.ToArray().SequenceEqual(imageData));

                return CreateResponse("I see an image.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new TextContent("Describe this image"),
                new DataContent(imageData, "image/png")
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("I see an image.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_DataContent_AllImageFormats()
    {
        var formats = new[]
        {
            ("image/jpeg", ImageFormat.Jpeg),
            ("image/png", ImageFormat.Png),
            ("image/gif", ImageFormat.Gif),
            ("image/webp", ImageFormat.Webp)
        };

        foreach (var (mimeType, expectedFormat) in formats)
        {
            byte[] imageData = [1, 2, 3, 4];
            bool verified = false;

            MockBedrockRuntime mock = new()
            {
                OnConverseRequest = request =>
                {
                    Assert.NotNull(request.Messages[0].Content[0].Image);
                    Assert.Equal(expectedFormat, request.Messages[0].Content[0].Image.Format);
                    verified = true;
                    return CreateResponse("OK");
                }
            };

            IChatClient chatClient = mock.AsIChatClient("claude");
            await chatClient.GetResponseAsync([new(ChatRole.User, [new DataContent(imageData, mimeType)])]);
            Assert.True(verified, $"Format {mimeType} not verified");
        }
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_DataContent_Document()
    {
        byte[] pdfData = [0x25, 0x50, 0x44, 0x46];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(2, request.Messages[0].Content.Count);
                Assert.Equal("Analyze this document", request.Messages[0].Content[0].Text);
                Assert.NotNull(request.Messages[0].Content[1].Document);
                Assert.Equal(DocumentFormat.Pdf, request.Messages[0].Content[1].Document.Format);
                Assert.True(request.Messages[0].Content[1].Document.Source.Bytes.ToArray().SequenceEqual(pdfData));
                Assert.Equal("file", request.Messages[0].Content[1].Document.Name);

                return CreateResponse("Document analyzed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new TextContent("Analyze this document"),
                new DataContent(pdfData, "application/pdf")
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("Document analyzed.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_DataContent_DocumentWithName()
    {
        byte[] pdfData = [1, 2, 3];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.Messages[0].Content[0].Document);
                Assert.Equal("report.pdf", request.Messages[0].Content[0].Document.Name);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        DataContent dataContent = new(pdfData, "application/pdf") { Name = "report.pdf" };
        await chatClient.GetResponseAsync([new(ChatRole.User, [dataContent])]);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_DataContent_Video()
    {
        byte[] videoData = [0x00, 0x00, 0x00, 0x18];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(2, request.Messages[0].Content.Count);
                Assert.NotNull(request.Messages[0].Content[1].Video);
                Assert.Equal(VideoFormat.Mp4, request.Messages[0].Content[1].Video.Format);

                return CreateResponse("Video processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new TextContent("Analyze this video"),
                new DataContent(videoData, "video/mp4")
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("Video processed.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesImageContent()
    {
        byte[] imageData = [1, 2, 3, 4];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Image = new ImageBlock
                                    {
                                        Format = ImageFormat.Png,
                                        Source = new ImageSource
                                        {
                                            Bytes = new MemoryStream(imageData)
                                        }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Send me an image")]);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal("image/png", dataContent.MediaType);
        Assert.True(dataContent.Data.ToArray().SequenceEqual(imageData));
        Assert.NotNull(dataContent.RawRepresentation);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesVideoContent()
    {
        byte[] videoData = [5, 6, 7, 8];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Video = new VideoBlock
                                    {
                                        Format = VideoFormat.Mp4,
                                        Source = new VideoSource
                                        {
                                            Bytes = new MemoryStream(videoData)
                                        }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Send me a video")]);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal("video/mp4", dataContent.MediaType);
        Assert.True(dataContent.Data.ToArray().SequenceEqual(videoData));
        Assert.NotNull(dataContent.RawRepresentation);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesDocumentContent()
    {
        byte[] docData = [9, 10, 11];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Document = new DocumentBlock
                                    {
                                        Format = DocumentFormat.Pdf,
                                        Name = "result.pdf",
                                        Source = new DocumentSource
                                        {
                                            Bytes = new MemoryStream(docData)
                                        }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Send me a document")]);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal("application/pdf", dataContent.MediaType);
        Assert.Equal("result.pdf", dataContent.Name);
        Assert.True(dataContent.Data.ToArray().SequenceEqual(docData));
        Assert.NotNull(dataContent.RawRepresentation);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void IChatClient_GetService_WithServiceKey_ReturnsNull()
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient();

        // When serviceKey is not null, should return null
        Assert.Null(chatClient.GetService(typeof(IAmazonBedrockRuntime), "someKey"));
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public void IChatClient_GetService_UnknownType_ReturnsNull()
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient();

        // Unknown type should return null
        Assert.Null(chatClient.GetService<string>());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_UsageWithCacheTokens()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var response = CreateResponse("OK");
                response.Usage = new TokenUsage
                {
                    InputTokens = 100,
                    OutputTokens = 50,
                    TotalTokens = 150,
                    CacheReadInputTokens = 25,
                    CacheWriteInputTokens = 10
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result.Usage);
        Assert.Equal(100, result.Usage.InputTokenCount);
        Assert.Equal(25, result.Usage.CachedInputTokenCount);
        Assert.Equal(50, result.Usage.OutputTokenCount);
        Assert.Equal(150, result.Usage.TotalTokenCount);
        Assert.NotNull(result.Usage.AdditionalCounts);
        Assert.Equal(10, result.Usage.AdditionalCounts["CacheWriteInputTokens"]);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_CustomFinishReason()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var response = CreateResponse("Custom");
                response.StopReason = new StopReason("custom_reason");
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.Equal("custom_reason", result.FinishReason?.Value);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_StopSequences_MergesWithExisting()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                // Should have merged stop sequences
                Assert.Contains("STOP1", request.InferenceConfig.StopSequences);
                Assert.Contains("STOP2", request.InferenceConfig.StopSequences);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        ChatOptions options = new()
        {
            StopSequences = ["STOP1", "STOP2"]
        };

        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")], options);
        Assert.NotNull(result);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData("text/csv")]
    [InlineData("text/html")]
    [InlineData("text/markdown")]
    [InlineData("text/plain")]
    [InlineData("application/msword")]
    [InlineData("application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
    [InlineData("application/vnd.ms-excel")]
    [InlineData("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
    public async Task IChatClient_GetResponseAsync_SendsDocumentContent_AllFormats(string mimeType)
    {
        byte[] docData = [1, 2, 3];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.Messages[0].Content[0].Document);
                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User, [new DataContent(docData, mimeType) { Name = "file" }])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData("image/gif")]
    [InlineData("image/webp")]
    public async Task IChatClient_GetResponseAsync_SendsImageContent_AllFormats(string mimeType)
    {
        byte[] imageData = [1, 2, 3];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.Messages[0].Content[0].Image);
                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User, [new DataContent(imageData, mimeType)])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData("video/x-flv")]
    [InlineData("video/x-matroska")]
    [InlineData("video/quicktime")]
    [InlineData("video/mpeg")]
    [InlineData("video/webm")]
    [InlineData("video/3gpp")]
    public async Task IChatClient_GetResponseAsync_SendsVideoContent_AllFormats(string mimeType)
    {
        byte[] videoData = [1, 2, 3];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.Messages[0].Content[0].Video);
                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User, [new DataContent(videoData, mimeType)])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_SendsFunctionCallContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Equal(2, request.Messages.Count);

                // First message is user
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);

                // Second message is assistant with tool use
                Assert.Equal(ConversationRole.Assistant, request.Messages[1].Role);
                var toolUse = request.Messages[1].Content[0].ToolUse;
                Assert.NotNull(toolUse);
                Assert.Equal("call_123", toolUse.ToolUseId);
                Assert.Equal("get_weather", toolUse.Name);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        FunctionCallContent funcCallContent = new("call_123", "get_weather",
            new Dictionary<string, object> { ["location"] = "Seattle" });

        ChatMessage[] messages =
        [
            new(ChatRole.User, "What's the weather?"),
            new(ChatRole.Assistant, [funcCallContent])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData("csv", "text/csv")]
    [InlineData("html", "text/html")]
    [InlineData("md", "text/markdown")]
    [InlineData("doc", "application/msword")]
    [InlineData("docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
    [InlineData("xls", "application/vnd.ms-excel")]
    [InlineData("xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
    public async Task IChatClient_GetResponseAsync_ReceivesDocumentContent_AllFormats(string formatValue, string expectedMimeType)
    {
        byte[] docData = [9, 10, 11];
        DocumentFormat format = new(formatValue);

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Document = new DocumentBlock
                                    {
                                        Format = format,
                                        Name = "result.doc",
                                        Source = new DocumentSource { Bytes = new MemoryStream(docData) }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal(expectedMimeType, dataContent.MediaType);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData("gif", "image/gif")]
    [InlineData("webp", "image/webp")]
    public async Task IChatClient_GetResponseAsync_ReceivesImageContent_AllFormats(string formatValue, string expectedMimeType)
    {
        byte[] imageData = [1, 2, 3];
        ImageFormat format = new(formatValue);

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Image = new ImageBlock
                                    {
                                        Format = format,
                                        Source = new ImageSource { Bytes = new MemoryStream(imageData) }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal(expectedMimeType, dataContent.MediaType);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData("flv", "video/x-flv")]
    [InlineData("mkv", "video/x-matroska")]
    [InlineData("mov", "video/quicktime")]
    [InlineData("mpeg", "video/mpeg")]
    [InlineData("webm", "video/webm")]
    [InlineData("three_gp", "video/3gpp")]
    public async Task IChatClient_GetResponseAsync_ReceivesVideoContent_AllFormats(string formatValue, string expectedMimeType)
    {
        byte[] videoData = [5, 6, 7, 8];
        VideoFormat format = new(formatValue);

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Video = new VideoBlock
                                    {
                                        Format = format,
                                        Source = new VideoSource { Bytes = new MemoryStream(videoData) }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        Assert.Equal(expectedMimeType, dataContent.MediaType);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesDocument_UnknownFormat()
    {
        byte[] docData = [9, 10, 11];
        DocumentFormat format = new("unknown_format");

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Document = new DocumentBlock
                                    {
                                        Format = format,
                                        Name = "result.doc",
                                        Source = new DocumentSource { Bytes = new MemoryStream(docData) }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        // Unknown format defaults to text/plain
        Assert.Equal("text/plain", dataContent.MediaType);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesImage_UnknownFormat()
    {
        byte[] imageData = [1, 2, 3];
        ImageFormat format = new("unknown_format");

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Image = new ImageBlock
                                    {
                                        Format = format,
                                        Source = new ImageSource { Bytes = new MemoryStream(imageData) }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        // Unknown format defaults to image/jpeg
        Assert.Equal("image/jpeg", dataContent.MediaType);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesVideo_UnknownFormat()
    {
        byte[] videoData = [5, 6, 7, 8];
        VideoFormat format = new("unknown_format");

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    Video = new VideoBlock
                                    {
                                        Format = format,
                                        Source = new VideoSource { Bytes = new MemoryStream(videoData) }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        var dataContent = Assert.IsType<DataContent>(Assert.Single(result.Messages[0].Contents));
        // Unknown format defaults to video/mp4
        Assert.Equal("video/mp4", dataContent.MediaType);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_SendsUnknownMimeType_SkipsContent()
    {
        byte[] data = [1, 2, 3];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                // Unknown MIME type content should not be in the request
                // since it doesn't match any known format
                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User, [new DataContent(data, "application/unknown-type")])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }
    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_TextReasoningContent()
    {
        string reasoningText = "Let me think step by step...";
        string signature = "sig123";

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    ReasoningContent = new ReasoningContentBlock
                                    {
                                        ReasoningText = new ReasoningTextBlock
                                        {
                                            Text = reasoningText,
                                            Signature = signature
                                        }
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };

                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "Think step by step about this problem.")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.IsType<TextReasoningContent>(Assert.Single(result.Messages[0].Contents));

        TextReasoningContent reasoningContent = (TextReasoningContent)result.Messages[0].Contents[0];
        Assert.Equal(reasoningText, reasoningContent.Text);
        Assert.Equal(signature, reasoningContent.ProtectedData);
        Assert.NotNull(reasoningContent.RawRepresentation);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_SendsTextReasoningContent()
    {
        string reasoningText = "I reasoned about this";
        string signature = "sig456";

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Equal(2, request.Messages.Count);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);
                Assert.Equal(ConversationRole.Assistant, request.Messages[1].Role);
                Assert.Single(request.Messages[1].Content);

                var reasoningBlock = request.Messages[1].Content[0];
                Assert.NotNull(reasoningBlock.ReasoningContent);
                Assert.Equal(reasoningText, reasoningBlock.ReasoningContent.ReasoningText.Text);
                Assert.Equal(signature, reasoningBlock.ReasoningContent.ReasoningText.Signature);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        ChatMessage[] messages =
        [
            new(ChatRole.User, "Question"),
            new(ChatRole.Assistant, [new TextReasoningContent(reasoningText) { ProtectedData = signature }])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_TextReasoningContent_WithRedactedContent()
    {
        byte[] redactedData = [1, 2, 3, 4];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var reasoningBlock = request.Messages[0].Content[0];
                Assert.NotNull(reasoningBlock.ReasoningContent);
                Assert.NotNull(reasoningBlock.ReasoningContent.RedactedContent);
                Assert.True(reasoningBlock.ReasoningContent.RedactedContent.ToArray().SequenceEqual(redactedData));

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        TextReasoningContent reasoningContent = new("Reasoning")
        {
            ProtectedData = "sig",
            AdditionalProperties = new AdditionalPropertiesDictionary()
            {
                [nameof(ReasoningContentBlock.RedactedContent)] = redactedData
            }
        };

        ChatMessage[] messages = [new(ChatRole.User, [reasoningContent])];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesReasoningContent_WithRedactedContent()
    {
        byte[] redactedData = [5, 6, 7];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    ReasoningContent = new ReasoningContentBlock
                                    {
                                        ReasoningText = new ReasoningTextBlock { Text = "Thinking...", Signature = "sig" },
                                        RedactedContent = new MemoryStream(redactedData)
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Think")]);

        Assert.NotNull(result);
        var reasoningContent = Assert.IsType<TextReasoningContent>(Assert.Single(result.Messages[0].Contents));
        Assert.NotNull(reasoningContent.AdditionalProperties);
        Assert.True(reasoningContent.AdditionalProperties.ContainsKey(nameof(ReasoningContentBlock.RedactedContent)));

        var received = (byte[])reasoningContent.AdditionalProperties[nameof(ReasoningContentBlock.RedactedContent)];
        Assert.True(received.SequenceEqual(redactedData));
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithCitationMetadata()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    CitationsContent = new CitationsContentBlock
                                    {
                                        Content =
                                        [
                                            new() { Text = "This is cited content." }
                                        ],
                                        Citations =
                                        [
                                            new() {
                                                Title = "Example Source",
                                                Source = "https://example.com",
                                                Location = new CitationLocation
                                                {
                                                    Web = new WebLocation
                                                    {
                                                        Url = "https://example.com"
                                                    }
                                                },
                                                SourceContent =
                                                [
                                                    new() { Text = "Source snippet" }
                                                ]
                                            }
                                        ]
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };

                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "Cite your sources")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        TextContent textContent = Assert.IsType<TextContent>(result.Messages[0].Contents[0]);
        Assert.Equal("This is cited content.", textContent.Text);
        Assert.NotNull(textContent.RawRepresentation);
        Assert.NotNull(textContent.Annotations);
        Assert.Single(textContent.Annotations);

        CitationAnnotation citation = Assert.IsType<CitationAnnotation>(textContent.Annotations[0]);
        Assert.Equal("Example Source", citation.Title);
        Assert.Equal("https://example.com/", citation.Url?.ToString());
        Assert.Equal("Source snippet", citation.Snippet);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithCitation_NoSourceContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    CitationsContent = new CitationsContentBlock
                                    {
                                        Content =
                                        [
                                            new() { Text = "Cited text." }
                                        ],
                                        Citations =
                                        [
                                            new() {
                                                Title = "My Source",
                                                Source = "fallback-source"
                                            }
                                        ]
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        TextContent textContent = Assert.IsType<TextContent>(result.Messages[0].Contents[0]);
        CitationAnnotation citation = Assert.IsType<CitationAnnotation>(Assert.Single(textContent.Annotations));
        Assert.Equal("fallback-source", citation.Snippet);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithSystemInstructions()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.System);
                Assert.Single(request.System);
                Assert.Equal("You are a helpful assistant.", request.System[0].Text);

                Assert.Single(request.Messages);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);

                return CreateResponse("I'm here to help!");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.System, "You are a helpful assistant."),
            new(ChatRole.User, "Hello")
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("I'm here to help!", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithInstructions_InOptions()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.System);
                Assert.Single(request.System);
                Assert.Equal("Be concise.", request.System[0].Text);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "Hello")];
        ChatOptions options = new() { Instructions = "Be concise." };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithChatOptions()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Equal("custom-model", request.ModelId);

                Assert.NotNull(request.InferenceConfig);
                Assert.Equal(0.7f, request.InferenceConfig.Temperature);
                Assert.Equal(0.9f, request.InferenceConfig.TopP);
                Assert.Equal(100, request.InferenceConfig.MaxTokens);
                Assert.NotNull(request.InferenceConfig.StopSequences);
                Assert.Contains("STOP", request.InferenceConfig.StopSequences);

                return CreateResponse("Response with options applied.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("default-model");
        ChatMessage[] messages = [new(ChatRole.User, "Test message")];

        ChatOptions options = new()
        {
            ModelId = "custom-model",
            Temperature = 0.7f,
            TopP = 0.9f,
            MaxOutputTokens = 100,
            StopSequences = ["STOP"]
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("Response with options applied.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithFinishReasons()
    {
        var finishReasons = new[]
        {
            (StopReason.End_turn, ChatFinishReason.Stop),
            (StopReason.Max_tokens, ChatFinishReason.Length),
            (StopReason.Stop_sequence, ChatFinishReason.Stop),
            (StopReason.Tool_use, ChatFinishReason.ToolCalls),
            (StopReason.Content_filtered, ChatFinishReason.ContentFilter),
            (StopReason.Guardrail_intervened, ChatFinishReason.ContentFilter)
        };

        foreach (var (stopReason, expectedFinishReason) in finishReasons)
        {
            MockBedrockRuntime mock = new()
            {
                OnConverseRequest = request =>
                {
                    var response = CreateResponse("Test");
                    response.StopReason = stopReason;
                    return response;
                }
            };

            IChatClient chatClient = mock.AsIChatClient("claude");
            ChatMessage[] messages = [new(ChatRole.User, "Test")];

            ChatResponse result = await chatClient.GetResponseAsync(messages);
            Assert.Equal(expectedFinishReason, result.FinishReason);
        }
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithAdditionalModelResponseFields()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var response = CreateResponse("Test");
                response.AdditionalModelResponseFields = new Document(new Dictionary<string, Document>
                {
                    ["custom_field"] = "custom_value",
                    ["number_field"] = 123
                });
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        Assert.NotNull(result.Messages[0].AdditionalProperties);
        // Values are JsonElement when deserialized from Document
        Assert.Equal("custom_value", ((JsonElement)result.Messages[0].AdditionalProperties["custom_field"]).GetString());
        Assert.Equal(123, ((JsonElement)result.Messages[0].AdditionalProperties["number_field"]).GetInt32());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_SystemMessageWithCachePoint()
    {
        CachePointBlock cachePoint = new() { Type = CachePointType.Default };

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                // Should have system messages including cache point
                Assert.True(request.System.Count >= 2);
                Assert.NotNull(request.System.Last().CachePoint);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        ChatMessage systemMessage = new(ChatRole.System, "System instruction")
        {
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                [nameof(ContentBlock.CachePoint)] = cachePoint
            }
        };

        ChatMessage[] messages = [systemMessage, new(ChatRole.User, "Test")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ToolWithoutProperties()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.ToolConfig);
                Assert.Single(request.ToolConfig.Tools);
                Assert.Equal("simple_tool", request.ToolConfig.Tools[0].ToolSpec.Name);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        // Create a simple tool with no properties
        var tool = AIFunctionFactory.Create(() => "result", "simple_tool");

        ChatOptions options = new()
        {
            Tools = [tool]
        };

        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")], options);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithRawRepresentationFactory()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                // Verify the custom model ID was used
                Assert.Equal("custom-model", request.ModelId);

                // Return empty stream
                MemoryStream stream = new();
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("default-model");

        ChatOptions options = new()
        {
            RawRepresentationFactory = client => new ConverseStreamRequest { ModelId = "custom-model" }
        };

        // Should not throw
        await foreach (var _ in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Test")], options))
        {
            // Consume stream
        }
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_AllContentTypesHaveRawRepresentation()
    {
        byte[] imageData = [1, 2, 3, 4];
        byte[] videoData = [5, 6, 7, 8];
        byte[] docData = [9, 10, 11];
        string reasoningText = "Thinking...";
        string signature = "sig123";

        ContentBlock textBlock = new() { Text = "Hello" };
        ContentBlock imageBlock = new()
        {
            Image = new ImageBlock
            {
                Format = ImageFormat.Png,
                Source = new ImageSource { Bytes = new MemoryStream(imageData) }
            }
        };
        ContentBlock videoBlock = new()
        {
            Video = new VideoBlock
            {
                Format = VideoFormat.Mp4,
                Source = new VideoSource { Bytes = new MemoryStream(videoData) }
            }
        };
        ContentBlock docBlock = new()
        {
            Document = new DocumentBlock
            {
                Format = DocumentFormat.Pdf,
                Name = "file.pdf",
                Source = new DocumentSource { Bytes = new MemoryStream(docData) }
            }
        };
        ContentBlock toolUseBlock = new()
        {
            ToolUse = new ToolUseBlock
            {
                ToolUseId = "tool_1",
                Name = "func",
                Input = new Document(new Dictionary<string, Document>())
            }
        };
        ContentBlock citationBlock = new()
        {
            CitationsContent = new CitationsContentBlock
            {
                Content = [new() { Text = "Cited" }],
                Citations = [new() { Title = "Source" }]
            }
        };
        ContentBlock reasoningBlock = new()
        {
            ReasoningContent = new ReasoningContentBlock
            {
                ReasoningText = new ReasoningTextBlock
                {
                    Text = reasoningText,
                    Signature = signature
                }
            }
        };

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                textBlock,
                                imageBlock,
                                videoBlock,
                                docBlock,
                                toolUseBlock,
                                citationBlock,
                                reasoningBlock
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        Assert.Equal(7, result.Messages[0].Contents.Count);

        Assert.Same(textBlock, result.Messages[0].Contents[0].RawRepresentation);
        Assert.Same(imageBlock, result.Messages[0].Contents[1].RawRepresentation);
        Assert.Same(videoBlock, result.Messages[0].Contents[2].RawRepresentation);
        Assert.Same(docBlock, result.Messages[0].Contents[3].RawRepresentation);
        Assert.Same(toolUseBlock, result.Messages[0].Contents[4].RawRepresentation);
        // Citation content RawRepresentation is the CitationGeneratedContent, not the ContentBlock
        Assert.Same(citationBlock.CitationsContent.Content[0], result.Messages[0].Contents[5].RawRepresentation);
        Assert.Same(reasoningBlock, result.Messages[0].Contents[6].RawRepresentation);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_RawRepresentation_Message()
    {
        Message rawMessage = null;

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new();
                rawMessage = new Message
                {
                    Role = ConversationRole.Assistant,
                    Content =
                    [
                        new() { Text = "Test" }
                    ]
                };
                response.Output = new ConverseOutput
                {
                    Message = rawMessage
                };
                response.Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        Assert.Same(rawMessage, result.Messages[0].RawRepresentation);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_RawRepresentation_Response()
    {
        ConverseResponse rawResponse = null;

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                rawResponse = new ConverseResponse
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() { Text = "Test" }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return rawResponse;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        Assert.Same(rawResponse, result.RawRepresentation);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_UsesRawRepresentation_WhenSending()
    {
        ContentBlock originalContentBlock = new() { Text = "Original text from raw" };

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Single(request.Messages[0].Content);
                Assert.Same(originalContentBlock, request.Messages[0].Content[0]);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        TextContent content = new("This text should be ignored")
        {
            RawRepresentation = originalContentBlock
        };

        ChatMessage[] messages = [new(ChatRole.User, [content])];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_HandlesWhitespaceOnlyText()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Single(request.Messages[0].Content);
                Assert.Equal("\u200b", request.Messages[0].Content[0].Text);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "   ")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_TrimsAssistantText()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Equal(2, request.Messages.Count);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);
                Assert.Equal(ConversationRole.Assistant, request.Messages[1].Role);

                Assert.Single(request.Messages[1].Content);
                Assert.Equal("Trimmed text", request.Messages[1].Content[0].Text);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User, "Hello"),
            new(ChatRole.Assistant, "Trimmed text   \n\n")
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_SkipsEmptyAssistantText()
    {
        // When an assistant message contains only whitespace, it should be skipped entirely
        // because sending an assistant message with empty content would fail the service.
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                // Only the user message should be sent; the whitespace-only assistant message is dropped
                Assert.Single(request.Messages);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User, "Hello"),
            new(ChatRole.Assistant, "   \n\n   ")
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_CachePointBlock_InMessages()
    {
        CachePointBlock cachePoint = new() { Type = CachePointType.Default };

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(2, request.Messages[0].Content.Count);
                Assert.Equal("Text before cache", request.Messages[0].Content[0].Text);
                Assert.NotNull(request.Messages[0].Content[1].CachePoint);
                Assert.Equal(CachePointType.Default, request.Messages[0].Content[1].CachePoint.Type);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        ChatMessage chatMessage = new(ChatRole.User, "Text before cache")
        {
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                [nameof(ContentBlock.CachePoint)] = cachePoint
            }
        };

        ChatResponse result = await chatClient.GetResponseAsync([chatMessage]);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_CachePointBlock_InSystemMessages()
    {
        CachePointBlock cachePoint = new() { Type = CachePointType.Default };

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.System);
                Assert.Equal(2, request.System.Count);
                Assert.Equal("System instruction", request.System[0].Text);
                Assert.NotNull(request.System[1].CachePoint);
                Assert.Equal(CachePointType.Default, request.System[1].CachePoint.Type);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        ChatMessage systemMessage = new(ChatRole.System, "System instruction")
        {
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                [nameof(ContentBlock.CachePoint)] = cachePoint
            }
        };

        ChatResponse result = await chatClient.GetResponseAsync([systemMessage, new(ChatRole.User, "Hello")]);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_CachePointBlock_InContent()
    {
        CachePointBlock cachePoint = new() { Type = CachePointType.Default };

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(3, request.Messages[0].Content.Count);
                Assert.Equal("Text 1", request.Messages[0].Content[0].Text);
                Assert.NotNull(request.Messages[0].Content[1].CachePoint);
                Assert.Equal("Text 2", request.Messages[0].Content[2].Text);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        TextContent content1 = new("Text 1")
        {
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                [nameof(ContentBlock.CachePoint)] = cachePoint
            }
        };

        TextContent content2 = new("Text 2");

        ChatMessage[] messages = [new(ChatRole.User, [content1, content2])];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithRawRepresentationFactory()
    {
        ConverseRequest factoryRequest = null;

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Same(factoryRequest, request);
                Assert.Equal("factory-model", request.ModelId);
                Assert.NotNull(request.InferenceConfig);
                Assert.Equal(0.5f, request.InferenceConfig.Temperature);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("default-model");

        ChatOptions options = new()
        {
            RawRepresentationFactory = (client) =>
            {
                factoryRequest = new ConverseRequest
                {
                    ModelId = "factory-model",
                    InferenceConfig = new InferenceConfiguration { Temperature = 0.5f }
                };
                return factoryRequest;
            }
        };

        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")], options);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_MultipleContentInCitations()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    CitationsContent = new CitationsContentBlock
                                    {
                                        Content =
                                        [
                                            new() { Text = "Content 1" },
                                            new() { Text = "Content 2" }
                                        ],
                                        Citations =
                                        [
                                            new() { Title = "Citation 1" },
                                            new() { Title = "Citation 2" }
                                        ]
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        Assert.Equal(2, result.Messages[0].Contents.Count);

        var content1 = Assert.IsType<TextContent>(result.Messages[0].Contents[0]);
        Assert.Equal("Content 1", content1.Text);
        var citation1 = Assert.IsType<CitationAnnotation>(Assert.Single(content1.Annotations));
        Assert.Equal("Citation 1", citation1.Title);

        var content2 = Assert.IsType<TextContent>(result.Messages[0].Contents[1]);
        Assert.Equal("Content 2", content2.Text);
        var citation2 = Assert.IsType<CitationAnnotation>(Assert.Single(content2.Annotations));
        Assert.Equal("Citation 2", citation2.Title);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_MismatchedCitationCounts_UsesMinimum()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new()
                {
                    Output = new ConverseOutput
                    {
                        Message = new Message
                        {
                            Role = ConversationRole.Assistant,
                            Content =
                            [
                                new() {
                                    CitationsContent = new CitationsContentBlock
                                    {
                                        Content =
                                        [
                                            new() { Text = "Content 1" },
                                            new() { Text = "Content 2" },
                                            new() { Text = "Content 3" }
                                        ],
                                        Citations =
                                        [
                                            new() { Title = "Citation 1" }
                                        ]
                                    }
                                }
                            ]
                        }
                    },
                    Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
                };
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        Assert.Single(result.Messages[0].Contents);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_SendsFunctionCall_WithComplexArguments()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                // Verify the tool definition was created correctly
                var toolSpec = request.ToolConfig?.Tools?[0]?.ToolSpec;
                Assert.NotNull(toolSpec);

                return CreateResponse("OK");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        // Create a function with array parameters
        var tool = AIFunctionFactory.Create(
            (string[] items, int count) => "result",
            "process_items",
            "Processes an array of items");

        ChatOptions options = new()
        {
            Tools = [tool]
        };

        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")], options);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_DocumentWithArrayValues()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var response = CreateResponse("OK");
                response.Output.Message.Content.Add(new ContentBlock
                {
                    ToolUse = new ToolUseBlock
                    {
                        ToolUseId = "tool_arr",
                        Name = "array_func",
                        Input = new Document(new Dictionary<string, Document>
                        {
                            ["items"] = new Document(new List<Document> { "a", "b", "c" })
                        })
                    }
                });
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        var funcCall = result.Messages[0].Contents.OfType<FunctionCallContent>().FirstOrDefault();
        Assert.NotNull(funcCall);
        Assert.NotNull(funcCall.Arguments);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_ReceivesNestedDictionary()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var response = CreateResponse("OK");
                response.AdditionalModelResponseFields = new Document(new Dictionary<string, Document>
                {
                    ["outer"] = new Document(new Dictionary<string, Document>
                    {
                        ["inner"] = "nested_value"
                    })
                });
                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        Assert.NotNull(result.Messages[0].AdditionalProperties);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionCallContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new();
                Document document = new(new Dictionary<string, Document>
                {
                    ["location"] = "San Francisco"
                });

                response.Output = new ConverseOutput
                {
                    Message = new Message
                    {
                        Role = ConversationRole.Assistant,
                        Content =
                        [
                            new() {
                                ToolUse = new ToolUseBlock
                                {
                                    ToolUseId = "tool_123",
                                    Name = "get_weather",
                                    Input = document
                                }
                            }
                        ]
                    }
                };
                response.Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 };

                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "What's the weather in San Francisco?")];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.IsType<FunctionCallContent>(Assert.Single(result.Messages[0].Contents));

        FunctionCallContent functionCall = (FunctionCallContent)result.Messages[0].Contents[0];
        Assert.Equal("get_weather", functionCall.Name);
        Assert.Equal("tool_123", functionCall.CallId);
        Assert.NotNull(functionCall.Arguments);
        Assert.Null(functionCall.Exception);
        Assert.NotNull(functionCall.RawRepresentation);
        // Arguments values are JsonElement when deserialized from Document
        Assert.Equal("San Francisco", ((JsonElement)functionCall.Arguments["location"]).GetString());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionCallContent_WithDeeplyNestedDocument()
    {
        // Note: JSON serialization has a default max depth of 64. Documents nested deeper than that
        // will fail during conversion. This test uses depth 50 which is within limits.
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                ConverseResponse response = new();
                var document = CreateDeeplyNestedDocument(50);

                response.Output = new ConverseOutput
                {
                    Message = new Message
                    {
                        Role = ConversationRole.Assistant,
                        Content =
                        [
                            new() {
                                ToolUse = new ToolUseBlock
                                {
                                    ToolUseId = "tool_nested",
                                    Name = "nested_tool",
                                    Input = document
                                }
                            }
                        ]
                    }
                };
                response.Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 };

                return response;
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatResponse result = await chatClient.GetResponseAsync([new(ChatRole.User, "Test")]);

        Assert.NotNull(result);
        FunctionCallContent functionCall = Assert.IsType<FunctionCallContent>(Assert.Single(result.Messages[0].Contents));

        Assert.Equal("nested_tool", functionCall.Name);
        Assert.Equal("tool_nested", functionCall.CallId);
        Assert.NotNull(functionCall.Arguments);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                Assert.Equal(ConversationRole.User, request.Messages[0].Role);
                Assert.Single(request.Messages[0].Content);
                Assert.NotNull(request.Messages[0].Content[0].ToolResult);
                Assert.Equal("call_123", request.Messages[0].Content[0].ToolResult.ToolUseId);

                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult.Content);
                Assert.Single(toolResult.Content);

                return CreateResponse("Based on the weather data, it's sunny.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_123", new { temperature = 72, condition = "sunny" })
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);

        Assert.NotNull(result);
        Assert.Equal("Based on the weather data, it's sunny.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithString()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.Equal("call_str", toolResult.ToolUseId);
                Assert.Single(toolResult.Content);
                Assert.Equal("Result text", toolResult.Content[0].Text);

                return CreateResponse("Got your result");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_str", "Result text")
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithDataContent()
    {
        byte[] imageData = [0x89, 0x50, 0x4E, 0x47];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.Single(request.Messages);
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.Equal("call_456", toolResult.ToolUseId);
                Assert.Single(toolResult.Content);
                Assert.NotNull(toolResult.Content[0].Image);
                Assert.Equal(ImageFormat.Png, toolResult.Content[0].Image.Format);
                Assert.True(toolResult.Content[0].Image.Source.Bytes.ToArray().SequenceEqual(imageData));

                return CreateResponse("Image processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_456", new DataContent(imageData, "image/png"))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Image processed.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithTextContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.Equal("call_text", toolResult.ToolUseId);
                Assert.NotNull(toolResult.Content);
                Assert.Single(toolResult.Content);

                // TextContent should be converted to ToolResultContentBlock with Text property
                Assert.Equal("Simple text result", toolResult.Content[0].Text);

                return CreateResponse("Text result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_text", new TextContent("Simple text result"))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Text result processed.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithMultipleAIContents()
    {
        byte[] data = [1, 2, 3];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.Equal("call_multi", toolResult.ToolUseId);
                Assert.Equal(2, toolResult.Content.Count);

                Assert.NotNull(toolResult.Content[0].Image);
                Assert.True(toolResult.Content[0].Image.Source.Bytes.ToArray().SequenceEqual(data));

                Assert.NotNull(toolResult.Content[1].Document);
                Assert.Equal(DocumentFormat.Pdf, toolResult.Content[1].Document.Format);

                return CreateResponse("Multi-content processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<AIContent> multiContent =
        [
            new DataContent(data, "image/png"),
            new DataContent(new byte[] { 4, 5 }, "application/pdf")
        ];

        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_multi", multiContent)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
        Assert.Equal("Multi-content processed.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithTools()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.ToolConfig);
                Assert.NotNull(request.ToolConfig.Tools);
                Assert.Single(request.ToolConfig.Tools);

                var tool = request.ToolConfig.Tools[0];
                Assert.NotNull(tool.ToolSpec);
                Assert.Equal("get_weather", tool.ToolSpec.Name);
                Assert.Equal("Gets weather information", tool.ToolSpec.Description);
                Assert.NotNull(tool.ToolSpec.InputSchema);

                var json = tool.ToolSpec.InputSchema.Json;
                Assert.True(json.IsDictionary());
                var dict = json.AsDictionary();
                Assert.Equal("object", dict["type"].AsString());

                return CreateResponse("I can use tools to help you.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "What tools do you have?")];

        ChatOptions options = new()
        {
            Tools =
            [
                AIFunctionFactory.Create((string location) => "the weather", "get_weather", "Gets weather information")
            ]
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("I can use tools to help you.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithToolMode_RequireSpecific()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.ToolConfig);
                Assert.NotNull(request.ToolConfig.ToolChoice);
                Assert.NotNull(request.ToolConfig.ToolChoice.Tool);
                Assert.Equal("get_weather", request.ToolConfig.ToolChoice.Tool.Name);

                return CreateResponse("Required mode with specific function.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "Test required tool mode")];

        ChatOptions options = new()
        {
            Tools = [AIFunctionFactory.Create((string location) => "the weather", "get_weather", "Gets weather information")],
            ToolMode = ChatToolMode.RequireSpecific("get_weather")
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);

        Assert.NotNull(result);
        Assert.Single(result.Messages);
        Assert.Equal("Required mode with specific function.", ((TextContent)result.Messages[0].Contents[0]).Text);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_WithToolMode_RequireAny()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                Assert.NotNull(request.ToolConfig);
                Assert.NotNull(request.ToolConfig.ToolChoice);
                Assert.NotNull(request.ToolConfig.ToolChoice.Any);

                return CreateResponse("Required mode any function.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "Test")];

        ChatOptions options = new()
        {
            Tools = [AIFunctionFactory.Create((string location) => "the weather", "get_weather", "Gets weather")],
            ToolMode = ChatToolMode.RequireAny
        };

        ChatResponse result = await chatClient.GetResponseAsync(messages, options);
        Assert.NotNull(result);
    }

    private static Document CreateDeeplyNestedDocument(int depth)
    {
        Dictionary<string, Document> dict = [];
        var current = dict;

        for (int i = 0; i < depth; i++)
        {
            Dictionary<string, Document> next = [];
            current[$"level{i}"] = new Document(next);
            current = next;
        }

        current["value"] = "final";
        return new Document(dict);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithReasoningContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.Equal("call_reason", toolResult.ToolUseId);
                Assert.Single(toolResult.Content);
                Assert.NotNull(toolResult.Content[0].Text);

                return CreateResponse("Reasoning result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_reason", new TextReasoningContent("Here's my reasoning..."))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithVideoContent()
    {
        byte[] videoData = [1, 2, 3, 4, 5];

        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.NotNull(toolResult.Content[0].Video);
                Assert.True(toolResult.Content[0].Video.Source.Bytes.ToArray().SequenceEqual(videoData));

                return CreateResponse("Video result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_video", new DataContent(videoData, "video/mp4"))
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithIntResult()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.True(toolResult.Content[0].Json.IsDictionary());
                var dict = toolResult.Content[0].Json.AsDictionary();
                // The value is stored as double since JsonSerializer uses double for numbers
                Assert.True(dict["result"].IsDouble() || dict["result"].IsInt());

                return CreateResponse("Int result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_int", 42)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithBoolResult()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.True(toolResult.Content[0].Json.IsDictionary());
                var dict = toolResult.Content[0].Json.AsDictionary();
                Assert.True(dict["result"].AsBool());

                return CreateResponse("Bool result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_bool", true)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithNullResult()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.True(toolResult.Content[0].Json.IsDictionary());

                return CreateResponse("Null result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_null", (object)null)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithJsonElementResult()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.True(toolResult.Content[0].Json.IsDictionary());

                return CreateResponse("JsonElement result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        JsonDocument jsonDoc = System.Text.Json.JsonDocument.Parse("{\"key\": \"value\"}");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_json", jsonDoc.RootElement)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithLongResult()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.True(toolResult.Content[0].Json.IsDictionary());
                var dict = toolResult.Content[0].Json.AsDictionary();
                Assert.True(dict["result"].IsLong() || dict["result"].IsDouble());

                return CreateResponse("Long result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_long", 9999999999L)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Theory]
    [Trait("UnitTest", "BedrockRuntime")]
    [InlineData(3.14f)]
    [InlineData(2.718281828)]
    public async Task IChatClient_GetResponseAsync_FunctionResultContent_WithFloatingPointResult(double value)
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseRequest = request =>
            {
                var toolResult = request.Messages[0].Content[0].ToolResult;
                Assert.NotNull(toolResult);
                Assert.True(toolResult.Content[0].Json.IsDictionary());

                return CreateResponse("Floating point result processed.");
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages =
        [
            new(ChatRole.User,
            [
                new FunctionResultContent("call_fp", value)
            ])
        ];

        ChatResponse result = await chatClient.GetResponseAsync(messages);
        Assert.NotNull(result);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_NullMessages_Throws()
    {
        MockBedrockRuntime mock = new();
        IChatClient chatClient = mock.AsIChatClient("claude");

        var enumerator = chatClient.GetStreamingResponseAsync(null).GetAsyncEnumerator();
        await Assert.ThrowsAsync<ArgumentNullException>("messages", () => enumerator.MoveNextAsync().AsTask());
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_BasicTextStreaming()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEvent(0),
                    CreateContentBlockDeltaEvent(0, "Hello"),
                    CreateContentBlockDeltaEvent(0, " world"),
                    CreateContentBlockDeltaEvent(0, "!"),
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEvent("end_turn"),
                    CreateMetadataEvent(10, 5)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");
        ChatMessage[] messages = [new(ChatRole.User, "Say hello")];

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync(messages))
        {
            updates.Add(update);
        }

        Assert.NotEmpty(updates);

        // Verify all updates have consistent messageId and responseId
        var messageIds = updates.Select(u => u.MessageId).Distinct().ToList();
        Assert.Single(messageIds);
        Assert.NotNull(messageIds[0]);

        var responseIds = updates.Select(u => u.ResponseId).Distinct().ToList();
        Assert.Single(responseIds);
        Assert.NotNull(responseIds[0]);

        // Verify role is set on updates
        Assert.All(updates.Where(u => u.Role.HasValue), u => Assert.Equal(ChatRole.Assistant, u.Role));

        List<ChatResponseUpdate> textUpdates = updates.Where(u => u.Contents.Any(c => c is TextContent)).ToList();
        Assert.Equal(3, textUpdates.Count);

        string fullText = string.Concat(textUpdates.Select(u => ((TextContent)u.Contents[0]).Text));
        Assert.Equal("Hello world!", fullText);

        Assert.Equal(ChatFinishReason.Stop, updates.Last(u => u.FinishReason != null).FinishReason);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithUsageMetadata()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEvent(0),
                    CreateContentBlockDeltaEvent(0, "Test"),
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEvent("end_turn"),
                    CreateMetadataEvent(100, 50)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Test")]))
        {
            updates.Add(update);
        }

        var usageUpdate = updates.FirstOrDefault(u => u.Contents.Any(c => c is UsageContent));
        Assert.NotNull(usageUpdate);

        UsageContent usageContent = (UsageContent)usageUpdate.Contents.First(c => c is UsageContent);
        Assert.Equal(100, usageContent.Details.InputTokenCount);
        Assert.Equal(50, usageContent.Details.OutputTokenCount);
        // TotalTokenCount is only set if the API returns it; the streaming API may not include it
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithToolUse()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEventWithToolUse(0, "tool_123", "get_weather"),
                    CreateContentBlockDeltaEventWithToolUse(0, "{\"location\":"),
                    CreateContentBlockDeltaEventWithToolUse(0, "\"Seattle\"}"),
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEvent("tool_use"),
                    CreateMetadataEvent(10, 5)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Weather?")]))
        {
            updates.Add(update);
        }

        var functionCallUpdate = updates.FirstOrDefault(u => u.Contents.Any(c => c is FunctionCallContent));
        Assert.NotNull(functionCallUpdate);

        FunctionCallContent functionCall = (FunctionCallContent)functionCallUpdate.Contents.First(c => c is FunctionCallContent);
        Assert.Equal("get_weather", functionCall.Name);
        Assert.Equal("tool_123", functionCall.CallId);
        Assert.NotNull(functionCall.Arguments);
        Assert.Null(functionCall.Exception);
        Assert.Equal("Seattle", ((JsonElement)functionCall.Arguments["location"]).GetString());

        // Verify finish reason is ToolCalls
        Assert.Equal(ChatFinishReason.ToolCalls, updates.Last(u => u.FinishReason != null).FinishReason);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithCitation()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEvent(0),
                    CreateContentBlockDeltaEventWithCitation(0, "Cited text", "Source Title", "Source snippet"),
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEvent("end_turn"),
                    CreateMetadataEvent(10, 5)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Test")]))
        {
            updates.Add(update);
        }

        var textUpdate = updates.FirstOrDefault(u => u.Contents.Any(c => c is TextContent tc && tc.Text == "Cited text"));
        Assert.NotNull(textUpdate);

        TextContent textContent = (TextContent)textUpdate.Contents.First(c => c is TextContent);
        Assert.NotNull(textContent.Annotations);
        Assert.Single(textContent.Annotations);
        var citation = Assert.IsType<CitationAnnotation>(textContent.Annotations[0]);
        Assert.Equal("Source Title", citation.Title);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithReasoningContent()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEvent(0),
                    CreateContentBlockDeltaEventWithReasoning(0, "Thinking...", "sig123", null),
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEvent("end_turn"),
                    CreateMetadataEvent(10, 5)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Test")]))
        {
            updates.Add(update);
        }

        var reasoningUpdate = updates.FirstOrDefault(u => u.Contents.Any(c => c is TextReasoningContent));
        Assert.NotNull(reasoningUpdate);

        TextReasoningContent reasoningContent = (TextReasoningContent)reasoningUpdate.Contents.First(c => c is TextReasoningContent);
        Assert.Equal("Thinking...", reasoningContent.Text);
        Assert.Equal("sig123", reasoningContent.ProtectedData);
        Assert.Equal(ChatRole.Assistant, reasoningUpdate.Role);
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithReasoningContentAndRedacted()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEvent(0),
                    CreateContentBlockDeltaEventWithReasoning(0, "Thinking...", null, "cmVkYWN0ZWQ="),  // base64 "redacted"
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEvent("end_turn"),
                    CreateMetadataEvent(10, 5)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Test")]))
        {
            updates.Add(update);
        }

        var reasoningUpdate = updates.FirstOrDefault(u => u.Contents.Any(c => c is TextReasoningContent));
        Assert.NotNull(reasoningUpdate);

        TextReasoningContent reasoningContent = (TextReasoningContent)reasoningUpdate.Contents.First(c => c is TextReasoningContent);
        Assert.NotNull(reasoningContent.AdditionalProperties);
        Assert.True(reasoningContent.AdditionalProperties.ContainsKey("RedactedContent"));
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithInvalidToolJson()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEventWithToolUse(0, "tool_err", "bad_tool"),
                    CreateContentBlockDeltaEventWithToolUse(0, "not valid json {{{"),
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEvent("tool_use"),
                    CreateMetadataEvent(10, 5)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Test")]))
        {
            updates.Add(update);
        }

        var functionCallUpdate = updates.FirstOrDefault(u => u.Contents.Any(c => c is FunctionCallContent));
        Assert.NotNull(functionCallUpdate);

        FunctionCallContent functionCall = (FunctionCallContent)functionCallUpdate.Contents.First(c => c is FunctionCallContent);
        Assert.Equal("bad_tool", functionCall.Name);
        Assert.NotNull(functionCall.Exception);  // Should have parse error
    }

    [Fact]
    [Trait("UnitTest", "BedrockRuntime")]
    public async Task IChatClient_GetStreamingResponseAsync_WithAdditionalResponseFields()
    {
        MockBedrockRuntime mock = new()
        {
            OnConverseStreamRequest = request =>
            {
                var stream = CreateEventStream(
                    CreateMessageStartEvent(),
                    CreateContentBlockStartEvent(0),
                    CreateContentBlockDeltaEvent(0, "Test"),
                    CreateContentBlockStopEvent(0),
                    CreateMessageStopEventWithAdditionalFields("end_turn"),
                    CreateMetadataEvent(10, 5)
                );
                return new ConverseStreamResponse { Stream = new ConverseStreamOutput(stream) };
            }
        };

        IChatClient chatClient = mock.AsIChatClient("claude");

        List<ChatResponseUpdate> updates = [];
        await foreach (ChatResponseUpdate update in chatClient.GetStreamingResponseAsync([new(ChatRole.User, "Test")]))
        {
            updates.Add(update);
        }

        // Should have received an update with additional properties
        var stopUpdate = updates.FirstOrDefault(u => u.FinishReason == ChatFinishReason.Stop && u.AdditionalProperties != null);
        Assert.NotNull(stopUpdate);
    }

    private static byte[] CreateContentBlockDeltaEventWithCitation(int contentBlockIndex, string text, string title, string snippet)
    {
        return CreateEventMessage("ContentBlockDelta", Encoding.UTF8.GetBytes($"{{\"contentBlockIndex\":{contentBlockIndex},\"delta\":{{\"text\":\"{text}\",\"citation\":{{\"title\":\"{title}\",\"sourceContent\":[{{\"text\":\"{snippet}\"}}]}}}}}}"));
    }

    private static byte[] CreateContentBlockDeltaEventWithReasoning(int contentBlockIndex, string text, string signature, string redactedContentBase64)
    {
        var sigPart = signature != null ? $",\"signature\":\"{signature}\"" : "";
        var redactedPart = redactedContentBase64 != null ? $",\"redactedContent\":\"{redactedContentBase64}\"" : "";
        return CreateEventMessage("ContentBlockDelta", Encoding.UTF8.GetBytes($"{{\"contentBlockIndex\":{contentBlockIndex},\"delta\":{{\"reasoningContent\":{{\"text\":\"{text}\"{sigPart}{redactedPart}}}}}}}"));
    }

    private static byte[] CreateMessageStopEventWithAdditionalFields(string stopReason) =>
        CreateEventMessage("MessageStop", Encoding.UTF8.GetBytes($"{{\"stopReason\":\"{stopReason}\",\"additionalModelResponseFields\":{{\"custom\":\"value\"}}}}"));

    private static Stream CreateEventStream(params byte[][] events)
    {
        MemoryStream ms = new();
        foreach (var evt in events)
        {
            ms.Write(evt, 0, evt.Length);
        }
        ms.Position = 0;
        return ms;
    }

    private static byte[] CreateMessageStartEvent() =>
        CreateEventMessage("MessageStart", Encoding.UTF8.GetBytes("""{"role":"assistant"}"""));

    private static byte[] CreateContentBlockStartEvent(int contentBlockIndex) =>
        CreateEventMessage("ContentBlockStart", Encoding.UTF8.GetBytes($"{{\"contentBlockIndex\":{contentBlockIndex},\"start\":{{\"text\":\"\"}}}}"));

    private static byte[] CreateContentBlockStartEventWithToolUse(int contentBlockIndex, string toolUseId, string name)
    {
        return CreateEventMessage("ContentBlockStart", Encoding.UTF8.GetBytes($"{{\"contentBlockIndex\":{contentBlockIndex},\"start\":{{\"toolUse\":{{\"toolUseId\":\"{toolUseId}\",\"name\":\"{name}\"}}}}}}"));
    }

    private static byte[] CreateContentBlockDeltaEvent(int contentBlockIndex, string text)
    {
        var escapedText = text.Replace("\"", "\\\"");
        return CreateEventMessage("ContentBlockDelta", Encoding.UTF8.GetBytes($"{{\"contentBlockIndex\":{contentBlockIndex},\"delta\":{{\"text\":\"{escapedText}\"}}}}"));
    }

    private static byte[] CreateContentBlockDeltaEventWithToolUse(int contentBlockIndex, string input)
    {
        var escapedInput = input.Replace("\"", "\\\"");
        return CreateEventMessage("ContentBlockDelta", Encoding.UTF8.GetBytes($"{{\"contentBlockIndex\":{contentBlockIndex},\"delta\":{{\"toolUse\":{{\"input\":\"{escapedInput}\"}}}}}}"));
    }

    private static byte[] CreateContentBlockStopEvent(int contentBlockIndex) =>
        CreateEventMessage("ContentBlockStop", Encoding.UTF8.GetBytes($"{{\"contentBlockIndex\":{contentBlockIndex}}}"));

    private static byte[] CreateMessageStopEvent(string stopReason) =>
        CreateEventMessage("MessageStop", Encoding.UTF8.GetBytes($"{{\"stopReason\":\"{stopReason}\"}}"));

    private static byte[] CreateMetadataEvent(int inputTokens, int outputTokens) =>
        CreateEventMessage("Metadata", Encoding.UTF8.GetBytes($"{{\"usage\":{{\"inputTokens\":{inputTokens},\"outputTokens\":{outputTokens}}}}}"));

    private static byte[] GetUtf8(string s) => Encoding.UTF8.GetBytes(s);

    private static byte[] CreateEventMessage(string eventType, byte[] payload)
    {
        EventStreamHeader messageTypeHeader = new(":message-type");
        messageTypeHeader.SetString("event");

        EventStreamHeader eventTypeHeader = new(":event-type");
        eventTypeHeader.SetString(eventType);

        EventStreamHeader contentTypeHeader = new(":content-type");
        contentTypeHeader.SetString("application/json");

        List<IEventStreamHeader> headers =
        [
            messageTypeHeader,
            eventTypeHeader,
            contentTypeHeader
        ];

        return new EventStreamMessage(headers, payload).ToByteArray();
    }

    private static ConverseResponse CreateResponse(string text)
    {
        ConverseResponse response = new()
        {
            Output = new ConverseOutput
            {
                Message = new Message
                {
                    Role = ConversationRole.Assistant,
                    Content = [new() { Text = text }]
                }
            },
            Usage = new TokenUsage { InputTokens = 10, OutputTokens = 5, TotalTokens = 15 }
        };
        return response;
    }
}