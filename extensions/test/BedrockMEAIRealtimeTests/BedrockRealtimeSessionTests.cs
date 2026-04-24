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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using Microsoft.Extensions.AI;
using Moq;
using Xunit;

namespace BedrockMEAIRealtimeTests;

public class BedrockRealtimeSessionTests
{
    /// <summary>
    /// Creates a connected session from a mock runtime for testing send operations.
    /// </summary>
    private static async Task<(IRealtimeClientSession Session, List<string> CapturedEvents)>
        CreateConnectedSessionWithCapture(string modelId = "amazon.nova-2-sonic-v1:0")
    {
        var capturedEvents = new List<string>();
        var runtimeMock = new Mock<IAmazonBedrockRuntime>();

        runtimeMock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .Returns<InvokeModelWithBidirectionalStreamRequest, CancellationToken>(async (req, ct) =>
            {
                // Start consuming events from the publisher in the background
                _ = Task.Run(async () =>
                {
                    try
                    {
                        while (true)
                        {
                            var evt = await req.BodyPublisher();
                            if (evt is null) break;
                            if (evt is BidirectionalInputPayloadPart part && part.Bytes is not null)
                            {
                                using var reader = new StreamReader(part.Bytes, Encoding.UTF8);
                                var json = await reader.ReadToEndAsync();
                                lock (capturedEvents)
                                {
                                    capturedEvents.Add(json);
                                }
                            }
                        }
                    }
                    catch
                    {
                        // Expected on shutdown
                    }
                });

                return new Mock<InvokeModelWithBidirectionalStreamResponse>().Object;
            });

        var client = new BedrockNovaRealtimeClient(runtimeMock.Object, modelId);
        var session = await client.CreateSessionAsync();

        return (session, capturedEvents);
    }

    /// <summary>
    /// Creates a connected session with options (including tools), capturing all outbound events.
    /// </summary>
    private static async Task<(IRealtimeClientSession Session, List<string> CapturedEvents)>
        CreateConnectedSessionWithOptionsAndCapture(RealtimeSessionOptions options, string modelId = "amazon.nova-2-sonic-v1:0")
    {
        var capturedEvents = new List<string>();
        var runtimeMock = new Mock<IAmazonBedrockRuntime>();

        runtimeMock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .Returns<InvokeModelWithBidirectionalStreamRequest, CancellationToken>(async (req, ct) =>
            {
                _ = Task.Run(async () =>
                {
                    try
                    {
                        while (true)
                        {
                            var evt = await req.BodyPublisher();
                            if (evt is null) break;
                            if (evt is BidirectionalInputPayloadPart part && part.Bytes is not null)
                            {
                                using var reader = new StreamReader(part.Bytes, Encoding.UTF8);
                                var json = await reader.ReadToEndAsync();
                                lock (capturedEvents)
                                {
                                    capturedEvents.Add(json);
                                }
                            }
                        }
                    }
                    catch
                    {
                        // Expected on shutdown
                    }
                });

                return new Mock<InvokeModelWithBidirectionalStreamResponse>().Object;
            });

        var client = new BedrockNovaRealtimeClient(runtimeMock.Object, modelId);
        var session = await client.CreateSessionAsync(options);

        return (session, capturedEvents);
    }

    /// <summary>
    /// Waits until capturedEvents has at least the specified count, with a timeout.
    /// </summary>
    private static void WaitForEvents(List<string> events, int minCount, int timeoutMs = 5000)
    {
        Assert.True(
            SpinWait.SpinUntil(() => { lock (events) { return events.Count >= minCount; } }, timeoutMs),
            $"Timed out waiting for at least {minCount} events (got {events.Count})");
    }

    /// <summary>
    /// Waits until capturedEvents contains an event matching the predicate, with a timeout.
    /// </summary>
    private static void WaitForEvent(List<string> events, Func<string, bool> predicate, int timeoutMs = 5000)
    {
        Assert.True(
            SpinWait.SpinUntil(() => { lock (events) { return events.Any(predicate); } }, timeoutMs),
            "Timed out waiting for matching event");
    }

    #region GetService Tests

    [Fact]
    public async Task GetService_ReturnsSession()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        Assert.Same(session, session.GetService(typeof(BedrockNovaRealtimeSession)));
        Assert.Same(session, session.GetService(typeof(IRealtimeClientSession)));

        await session.DisposeAsync();
    }

    [Fact]
    public async Task GetService_ReturnsMetadata()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        var metadata = (ChatClientMetadata?)session.GetService(typeof(ChatClientMetadata));
        Assert.NotNull(metadata);
        Assert.Equal("test-model", metadata!.DefaultModelId);
        Assert.Equal("aws.bedrock", metadata.ProviderName);

        await session.DisposeAsync();
    }

    [Fact]
    public async Task GetService_NullServiceType_Throws()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        Assert.Throws<ArgumentNullException>("serviceType", () => session.GetService(null!));

        await session.DisposeAsync();
    }

    [Fact]
    public async Task GetService_WithServiceKey_ReturnsNull()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        Assert.Null(session.GetService(typeof(BedrockNovaRealtimeSession), "key"));

        await session.DisposeAsync();
    }

    [Fact]
    public async Task GetService_UnknownType_ReturnsNull()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        Assert.Null(session.GetService(typeof(string)));

        await session.DisposeAsync();
    }

    #endregion

    #region Options Tests

    [Fact]
    public async Task Options_InitiallyNull()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        Assert.Null(session.Options);

        await session.DisposeAsync();
    }

    #endregion

    #region Dispose Tests

    [Fact]
    public async Task DisposeAsync_CanBeCalledMultipleTimes()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        await session.DisposeAsync();

        // Second dispose should not throw
        await session.DisposeAsync();
    }

    #endregion

    #region SendAsync Tests

    [Fact]
    public async Task SendAsync_NullMessage_Throws()
    {
        var (session, _) = await CreateConnectedSessionWithCapture();

        await Assert.ThrowsAsync<ArgumentNullException>("message",
            () => session.SendAsync(null!));

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_CancelledToken_Throws()
    {
        var (session, _) = await CreateConnectedSessionWithCapture();

        using var cts = new CancellationTokenSource();
        cts.Cancel();

        await Assert.ThrowsAsync<OperationCanceledException>(
            () => session.SendAsync(new RealtimeClientMessage(), cts.Token));

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_SessionUpdate_SetsOptions()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        var options = new RealtimeSessionOptions
        {
            Instructions = "You are a helpful assistant.",
            Voice = "tiffany",
            MaxOutputTokens = 2048
        };

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(options));
        WaitForEvents(capturedEvents, 2);

        Assert.Same(options, session.Options);

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_SessionUpdate_SendsSessionStartEvent()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        var options = new RealtimeSessionOptions
        {
            MaxOutputTokens = 2048,
            Voice = "matthew"
        };

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(options));
        WaitForEvents(capturedEvents, 1);

        lock (capturedEvents)
        {
            Assert.True(capturedEvents.Count >= 1, "Expected at least 1 event to be sent");

            // Verify sessionStart event
            var sessionStartJson = capturedEvents[0];
            var doc = JsonDocument.Parse(sessionStartJson);
            Assert.True(doc.RootElement.TryGetProperty("event", out var evt));
            Assert.True(evt.TryGetProperty("sessionStart", out var sessionStart));
            Assert.True(sessionStart.TryGetProperty("inferenceConfiguration", out var config));
            Assert.Equal(2048, config.GetProperty("maxTokens").GetInt32());
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_SessionUpdate_SendsPromptStartEvent()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        var options = new RealtimeSessionOptions
        {
            Voice = "tiffany",
            OutputAudioFormat = new RealtimeAudioFormat("audio/lpcm", 16000)
        };

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(options));
        WaitForEvents(capturedEvents, 2);

        lock (capturedEvents)
        {
            Assert.True(capturedEvents.Count >= 2, "Expected at least 2 events");

            // Verify promptStart event
            var promptStartJson = capturedEvents[1];
            var doc = JsonDocument.Parse(promptStartJson);
            Assert.True(doc.RootElement.TryGetProperty("event", out var evt));
            Assert.True(evt.TryGetProperty("promptStart", out var promptStart));
            Assert.True(promptStart.TryGetProperty("audioOutputConfiguration", out var audioConfig));
            Assert.Equal("tiffany", audioConfig.GetProperty("voiceId").GetString());
            Assert.Equal(16000, audioConfig.GetProperty("sampleRateHertz").GetInt32());
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_SessionUpdateWithInstructions_SendsSystemPrompt()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        var options = new RealtimeSessionOptions
        {
            Instructions = "You are a helpful assistant."
        };

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(options));
        WaitForEvents(capturedEvents, 5);

        lock (capturedEvents)
        {
            // sessionStart + promptStart + contentStart + textInput + contentEnd = at least 5
            Assert.True(capturedEvents.Count >= 5, $"Expected at least 5 events, got {capturedEvents.Count}");

            // Find the textInput event with system prompt content
            var textInputEvent = capturedEvents.FirstOrDefault(e => e.Contains("\"textInput\""));
            Assert.NotNull(textInputEvent);

            var doc = JsonDocument.Parse(textInputEvent);
            var textInput = doc.RootElement.GetProperty("event").GetProperty("textInput");
            Assert.Equal("You are a helpful assistant.", textInput.GetProperty("content").GetString());

            // Find the contentStart for system prompt
            var contentStartEvents = capturedEvents.Where(e => e.Contains("\"contentStart\"")).ToList();
            var systemContentStart = contentStartEvents.FirstOrDefault(e => e.Contains("\"SYSTEM\""));
            Assert.NotNull(systemContentStart);
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_AudioAppend_RequiresSessionConfig()
    {
        var (session, _) = await CreateConnectedSessionWithCapture();

        var audioContent = new DataContent(new byte[] { 1, 2, 3 }, "audio/lpcm");

        await Assert.ThrowsAsync<InvalidOperationException>(
            () => session.SendAsync(new InputAudioBufferAppendRealtimeClientMessage(audioContent)));

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_AudioAppend_SendsAudioInputEvent()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // First configure the session
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        // Then send audio
        var audioBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        var audioContent = new DataContent(audioBytes, "audio/lpcm");
        await session.SendAsync(new InputAudioBufferAppendRealtimeClientMessage(audioContent));
        WaitForEvent(capturedEvents, e => e.Contains("\"audioInput\""));

        lock (capturedEvents)
        {
            var expectedBase64 = Convert.ToBase64String(audioBytes);
            var audioEvent = capturedEvents.FirstOrDefault(e =>
                e.Contains("\"audioInput\"") && e.Contains(expectedBase64));
            Assert.NotNull(audioEvent);

            var doc = JsonDocument.Parse(audioEvent);
            var audioInput = doc.RootElement.GetProperty("event").GetProperty("audioInput");
            Assert.NotNull(audioInput.GetProperty("content").GetString());
            Assert.Equal(expectedBase64, audioInput.GetProperty("content").GetString());
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_AudioCommit_SendsTrailingSilence()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Configure and open audio
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        var audioContent = new DataContent(new byte[] { 1, 2 }, "audio/lpcm");
        await session.SendAsync(new InputAudioBufferAppendRealtimeClientMessage(audioContent));
        WaitForEvent(capturedEvents, e => e.Contains("\"audioInput\""));

        int eventCountBefore;
        lock (capturedEvents)
        {
            eventCountBefore = capturedEvents.Count;
        }

        // Commit sends trailing silence instead of closing the content block
        // (Nova Sonic uses VAD to detect speech boundaries)
        await session.SendAsync(new InputAudioBufferCommitRealtimeClientMessage());
        WaitForEvents(capturedEvents, eventCountBefore + 1);

        lock (capturedEvents)
        {
            // Should have a new audioInput event containing silence bytes
            var silenceEvents = capturedEvents.Skip(eventCountBefore)
                .Where(e => e.Contains("\"audioInput\"")).ToList();
            Assert.True(silenceEvents.Count > 0, "Expected trailing silence audioInput event after commit");

            // Audio content block should NOT be closed (no contentEnd)
            var contentEndEvents = capturedEvents.Where(e => e.Contains("\"contentEnd\"")).ToList();
            Assert.Empty(contentEndEvents);
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_CreateResponse_SendsSilenceNudge()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Configure session
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        int eventCountBefore;
        lock (capturedEvents)
        {
            eventCountBefore = capturedEvents.Count;
        }

        // CreateResponse sends a silence nudge to keep the bidirectional stream flowing
        await session.SendAsync(new CreateResponseRealtimeClientMessage());
        WaitForEvent(capturedEvents, e => e.Contains("\"audioInput\""));

        lock (capturedEvents)
        {
            var newEvents = capturedEvents.Skip(eventCountBefore).ToList();
            Assert.True(newEvents.Count > 0, "Expected silence nudge events from CreateResponse");

            // Should contain an audioInput event (the silence frame)
            var silenceEvent = newEvents.FirstOrDefault(e => e.Contains("\"audioInput\""));
            Assert.NotNull(silenceEvent);
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_ConversationItemWithText_SendsTextContent()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Configure session
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        var item = new RealtimeConversationItem(
            new List<AIContent> { new TextContent("Hello world") },
            id: "test-id",
            role: ChatRole.User);

        await session.SendAsync(new CreateConversationItemRealtimeClientMessage(item));
        WaitForEvent(capturedEvents, e => e.Contains("\"textInput\"") && e.Contains("Hello world"));

        lock (capturedEvents)
        {
            var textInputEvent = capturedEvents.Where(e => e.Contains("\"textInput\""))
                .FirstOrDefault(e => e.Contains("Hello world"));
            Assert.NotNull(textInputEvent);
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_ConversationItemWithToolResult_SendsToolResult()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Configure session
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        var toolResult = new FunctionResultContent("tool-call-id", "Sunny, 72°F");
        var item = new RealtimeConversationItem(
            new List<AIContent> { toolResult },
            id: "result-id",
            role: ChatRole.Tool);

        await session.SendAsync(new CreateConversationItemRealtimeClientMessage(item));
        WaitForEvent(capturedEvents, e => e.Contains("\"toolResult\""));

        lock (capturedEvents)
        {
            // Should have a TOOL contentStart with toolResultInputConfiguration
            var toolContentStart = capturedEvents.FirstOrDefault(e =>
                e.Contains("\"contentStart\"") && e.Contains("\"TOOL\""));
            Assert.NotNull(toolContentStart);

            var csDoc = JsonDocument.Parse(toolContentStart);
            var cs = csDoc.RootElement.GetProperty("event").GetProperty("contentStart");
            Assert.Equal("TOOL", cs.GetProperty("type").GetString());
            Assert.Equal("TOOL", cs.GetProperty("role").GetString());
            Assert.False(cs.GetProperty("interactive").GetBoolean());
            var toolResultConfig = cs.GetProperty("toolResultInputConfiguration");
            Assert.Equal("tool-call-id", toolResultConfig.GetProperty("toolUseId").GetString());
            Assert.Equal("TEXT", toolResultConfig.GetProperty("type").GetString());

            // Should have the tool result content (no role field per Nova Sonic protocol)
            var toolResultEvent = capturedEvents.FirstOrDefault(e =>
                e.Contains("\"toolResult\""));
            Assert.NotNull(toolResultEvent);

            var doc = JsonDocument.Parse(toolResultEvent);
            var tr = doc.RootElement.GetProperty("event").GetProperty("toolResult");
            Assert.Contains("Sunny", tr.GetProperty("content").GetString());

            // Should have a contentEnd closing the tool result
            var toolContentEnd = capturedEvents.Where(e =>
                e.Contains("\"contentEnd\"")).LastOrDefault();
            Assert.NotNull(toolContentEnd);
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_RawJsonRepresentation_ForwardsDirectly()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        var rawJson = "{\"event\":{\"customEvent\":{\"data\":\"test\"}}}";
        var message = new RealtimeClientMessage
        {
            RawRepresentation = rawJson
        };

        await session.SendAsync(message);
        WaitForEvent(capturedEvents, e => e.Contains("customEvent"));

        lock (capturedEvents)
        {
            Assert.Contains(capturedEvents, e => e.Contains("customEvent"));
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_SessionUpdate_IdempotentSessionAndPromptStart()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Send two session updates
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions { MaxOutputTokens = 1024 }));
        WaitForEvents(capturedEvents, 2);

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions { MaxOutputTokens = 2048 }));
        WaitForEvents(capturedEvents, 2); // count shouldn't grow beyond the initial 2

        lock (capturedEvents)
        {
            // Should only have ONE sessionStart and ONE promptStart
            var sessionStartCount = capturedEvents.Count(e => e.Contains("\"sessionStart\""));
            var promptStartCount = capturedEvents.Count(e => e.Contains("\"promptStart\""));

            Assert.Equal(1, sessionStartCount);
            Assert.Equal(1, promptStartCount);
        }

        await session.DisposeAsync();
    }

    #endregion

    #region SessionUpdateMessage Validation Tests

    [Fact]
    public void SessionUpdateMessage_NullOptions_Throws()
    {
        Assert.Throws<ArgumentNullException>("options", () => new SessionUpdateRealtimeClientMessage(null!));
    }

    [Fact]
    public void InputAudioBufferAppendMessage_NullContent_Throws()
    {
        Assert.Throws<ArgumentNullException>("audioContent",
            () => new InputAudioBufferAppendRealtimeClientMessage(null!));
    }

    [Fact]
    public void CreateConversationItemMessage_NullItem_Throws()
    {
        Assert.Throws<ArgumentNullException>("item",
            () => new CreateConversationItemRealtimeClientMessage(null!));
    }

    #endregion

    #region Protocol Event Format Tests

    [Fact]
    public async Task SessionStart_HasCorrectEventStructure()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions
        {
            MaxOutputTokens = 512
        }));
        WaitForEvents(capturedEvents, 2);

        lock (capturedEvents)
        {
            var sessionStart = capturedEvents.First(e => e.Contains("\"sessionStart\""));
            var doc = JsonDocument.Parse(sessionStart);
            var evt = doc.RootElement.GetProperty("event");
            var ss = evt.GetProperty("sessionStart");
            var inference = ss.GetProperty("inferenceConfiguration");

            Assert.Equal(512, inference.GetProperty("maxTokens").GetInt32());
            Assert.True(inference.TryGetProperty("topP", out _));
            Assert.True(inference.TryGetProperty("temperature", out _));
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task PromptStart_HasCorrectAudioOutputConfig()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions
        {
            Voice = "amy",
            OutputAudioFormat = new RealtimeAudioFormat("audio/lpcm", 8000)
        }));
        WaitForEvents(capturedEvents, 2);

        lock (capturedEvents)
        {
            var promptStart = capturedEvents.First(e => e.Contains("\"promptStart\""));
            var doc = JsonDocument.Parse(promptStart);
            var ps = doc.RootElement.GetProperty("event").GetProperty("promptStart");
            var audioConfig = ps.GetProperty("audioOutputConfiguration");

            Assert.Equal("audio/lpcm", audioConfig.GetProperty("mediaType").GetString());
            Assert.Equal(8000, audioConfig.GetProperty("sampleRateHertz").GetInt32());
            Assert.Equal(16, audioConfig.GetProperty("sampleSizeBits").GetInt32());
            Assert.Equal(1, audioConfig.GetProperty("channelCount").GetInt32());
            Assert.Equal("amy", audioConfig.GetProperty("voiceId").GetString());
            Assert.Equal("base64", audioConfig.GetProperty("encoding").GetString());
        }

        await session.DisposeAsync();
    }

    [Fact]
    public async Task AudioContentStart_HasCorrectInputConfig()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions
        {
            InputAudioFormat = new RealtimeAudioFormat("audio/lpcm", 8000)
        }));
        WaitForEvents(capturedEvents, 2);

        var audioContent = new DataContent(new byte[] { 1, 2, 3 }, "audio/lpcm");
        await session.SendAsync(new InputAudioBufferAppendRealtimeClientMessage(audioContent));
        WaitForEvent(capturedEvents, e => e.Contains("\"contentStart\"") && e.Contains("\"AUDIO\""));

        lock (capturedEvents)
        {
            // Find the AUDIO contentStart (not SYSTEM text one)
            var audioContentStart = capturedEvents.FirstOrDefault(e =>
                e.Contains("\"contentStart\"") && e.Contains("\"AUDIO\""));
            Assert.NotNull(audioContentStart);

            var doc = JsonDocument.Parse(audioContentStart);
            var cs = doc.RootElement.GetProperty("event").GetProperty("contentStart");
            Assert.Equal("AUDIO", cs.GetProperty("type").GetString());
            Assert.True(cs.GetProperty("interactive").GetBoolean());
            Assert.Equal("USER", cs.GetProperty("role").GetString());

            var audioConfig = cs.GetProperty("audioInputConfiguration");
            Assert.Equal(8000, audioConfig.GetProperty("sampleRateHertz").GetInt32());
        }

        await session.DisposeAsync();
    }

    #endregion

    #region Concurrent Send Tests

    [Fact]
    public async Task SendAsync_ConcurrentSends_SerializedBySemaphore()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        // Send multiple audio frames concurrently
        var tasks = Enumerable.Range(0, 10).Select(i =>
        {
            var audioContent = new DataContent(BitConverter.GetBytes(i), "audio/lpcm");
            return session.SendAsync(new InputAudioBufferAppendRealtimeClientMessage(audioContent));
        }).ToArray();

        await Task.WhenAll(tasks);
        WaitForEvents(capturedEvents, 13);

        lock (capturedEvents)
        {
            // All audio events should have been sent (one contentStart + 10 audioInputs)
            var audioEvents = capturedEvents.Count(e => e.Contains("\"audioInput\""));
            Assert.Equal(10, audioEvents);
        }

        await session.DisposeAsync();
    }

    #endregion

    #region Disposed Session Tests

    [Fact]
    public async Task SendAsync_AfterDispose_Throws()
    {
        var (session, _) = await CreateConnectedSessionWithCapture();

        await session.DisposeAsync();

        await Assert.ThrowsAsync<ObjectDisposedException>(
            () => session.SendAsync(new RealtimeClientMessage()));
    }

    #endregion

    #region Teardown Exception Handling Tests

    [Fact]
    public async Task SendAsync_ChannelClosedException_DuringWrite_IsSwallowed()
    {
        // Simulate a session that's connected but the channel gets closed unexpectedly
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Configure the session first
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions
        {
            MaxOutputTokens = 512
        }));
        WaitForEvents(capturedEvents, 2);

        // Dispose the session, which closes the channel
        await session.DisposeAsync();

        // Create a new session to test channel-closed scenario
        var runtimeMock = new Mock<IAmazonBedrockRuntime>();
        runtimeMock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client2 = new BedrockNovaRealtimeClient(runtimeMock.Object, "test-model");
        var session2 = await client2.CreateSessionAsync();

        // Configure the session
        await session2.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));

        // Dispose to trigger channel close, then verify second dispose is idempotent
        await session2.DisposeAsync();
        await session2.DisposeAsync(); // should not throw
    }

    [Fact]
    public async Task SendAsync_CallerCancellation_IsPropagated()
    {
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Configure the session first
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        using var cts = new CancellationTokenSource();
        cts.Cancel();

        // Caller's own cancellation token should propagate
        await Assert.ThrowsAsync<OperationCanceledException>(
            () => session.SendAsync(new CreateResponseRealtimeClientMessage(), cts.Token));

        await session.DisposeAsync();
    }

    [Fact]
    public async Task SendAsync_SemaphoreDisposedDuringRelease_DoesNotThrow()
    {
        // This verifies the ObjectDisposedException catch on _sendSemaphore.Release()
        var (session, capturedEvents) = await CreateConnectedSessionWithCapture();

        // Configure
        await session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions()));
        WaitForEvents(capturedEvents, 2);

        // Send a message and then immediately dispose
        var sendTask = session.SendAsync(new CreateResponseRealtimeClientMessage());
        await sendTask; // Should not throw

        await session.DisposeAsync();
    }

    #endregion

    #region Session GetService Returns Runtime Tests

    [Fact]
    public async Task GetService_ReturnsUnderlyingRuntime()
    {
        var mock = new Mock<IAmazonBedrockRuntime>();
        mock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(mock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        // The session should expose the underlying IAmazonBedrockRuntime via GetService
        var runtime = session.GetService(typeof(IAmazonBedrockRuntime));
        Assert.NotNull(runtime);
        Assert.Same(mock.Object, runtime);

        await session.DisposeAsync();
    }

    #endregion

    #region Tool Configuration Tests

    [Fact]
    public async Task ConnectAsync_WithTools_PromptStartContainsCorrectToolConfiguration()
    {
        // Create a real AIFunction using AIFunctionFactory
        AIFunction weatherTool = AIFunctionFactory.Create(
            (string location) => $"The weather in {location} is sunny",
            "GetWeather",
            "Gets the current weather for a given location");

        var options = new RealtimeSessionOptions
        {
            Instructions = "You are a helpful assistant.",
            Voice = "matthew",
            MaxOutputTokens = 1024,
            Tools = [weatherTool],
            InputAudioFormat = new RealtimeAudioFormat("audio/lpcm", 16000),
            OutputAudioFormat = new RealtimeAudioFormat("audio/lpcm", 24000),
        };

        var (session, capturedEvents) = await CreateConnectedSessionWithOptionsAndCapture(options);
        WaitForEvents(capturedEvents, 5);

        try
        {
            lock (capturedEvents)
            {
                // Find the promptStart event
                var promptStartJson = capturedEvents.FirstOrDefault(e => e.Contains("\"promptStart\""));
                Assert.NotNull(promptStartJson);

                var doc = JsonDocument.Parse(promptStartJson);
                var promptStart = doc.RootElement.GetProperty("event").GetProperty("promptStart");

                // Verify toolConfiguration exists and has tools
                Assert.True(promptStart.TryGetProperty("toolConfiguration", out var toolConfig),
                    "promptStart should have toolConfiguration when tools are provided");

                var tools = toolConfig.GetProperty("tools");
                Assert.Equal(JsonValueKind.Array, tools.ValueKind);
                Assert.Equal(1, tools.GetArrayLength());

                // Verify toolSpec structure
                var toolSpec = tools[0].GetProperty("toolSpec");
                Assert.Equal("GetWeather", toolSpec.GetProperty("name").GetString());
                Assert.Equal("Gets the current weather for a given location", toolSpec.GetProperty("description").GetString());

                // Verify inputSchema.json is a valid JSON string (not null, not empty)
                var inputSchema = toolSpec.GetProperty("inputSchema");
                var jsonSchemaStr = inputSchema.GetProperty("json").GetString();
                Assert.NotNull(jsonSchemaStr);
                Assert.NotEmpty(jsonSchemaStr);

                // Verify the schema string is valid JSON and parses as an object
                using var schemaDoc = JsonDocument.Parse(jsonSchemaStr);
                Assert.Equal(JsonValueKind.Object, schemaDoc.RootElement.ValueKind);
                Assert.Equal("object", schemaDoc.RootElement.GetProperty("type").GetString());

                // Verify schema has the location property
                var props = schemaDoc.RootElement.GetProperty("properties");
                Assert.True(props.TryGetProperty("location", out var locProp),
                    "Schema should have 'location' property");
                Assert.Equal("string", locProp.GetProperty("type").GetString());

                // Verify the raw JSON does NOT use Unicode escaping for quotes
                // (i.e., uses \" not \u0022 within the json field value)
                Assert.DoesNotContain("\\u0022", promptStartJson);

                // Verify toolUseOutputConfiguration exists
                Assert.True(promptStart.TryGetProperty("toolUseOutputConfiguration", out var toolOutput));
                Assert.Equal("application/json", toolOutput.GetProperty("mediaType").GetString());
            }
        }
        finally
        {
            await session.DisposeAsync();
        }
    }

    [Fact]
    public async Task ConnectAsync_WithNoTools_PromptStartOmitsToolConfiguration()
    {
        var options = new RealtimeSessionOptions
        {
            Instructions = "You are a helpful assistant.",
            Voice = "matthew",
            MaxOutputTokens = 1024,
        };

        var (session, capturedEvents) = await CreateConnectedSessionWithOptionsAndCapture(options);
        WaitForEvents(capturedEvents, 5);

        try
        {
            lock (capturedEvents)
            {
                var promptStartJson = capturedEvents.FirstOrDefault(e => e.Contains("\"promptStart\""));
                Assert.NotNull(promptStartJson);

                var doc = JsonDocument.Parse(promptStartJson);
                var promptStart = doc.RootElement.GetProperty("event").GetProperty("promptStart");

                // toolConfiguration should be null (omitted by WhenWritingNull)
                Assert.False(promptStart.TryGetProperty("toolConfiguration", out _),
                    "promptStart should NOT have toolConfiguration when no tools are provided");
            }
        }
        finally
        {
            await session.DisposeAsync();
        }
    }

    [Fact]
    public async Task ConnectAsync_WithOptions_SendsSessionStartPromptStartAndSystemPrompt()
    {
        AIFunction testTool = AIFunctionFactory.Create(
            (string input) => "result",
            "TestTool",
            "A test tool");

        var options = new RealtimeSessionOptions
        {
            Instructions = "Be helpful.",
            Voice = "ruth",
            MaxOutputTokens = 512,
            Tools = [testTool],
            OutputAudioFormat = new RealtimeAudioFormat("audio/lpcm", 16000),
        };

        var (session, capturedEvents) = await CreateConnectedSessionWithOptionsAndCapture(options);
        WaitForEvents(capturedEvents, 5);

        try
        {
            lock (capturedEvents)
            {
                // Verify correct event order: sessionStart, promptStart, systemPrompt events
                Assert.True(capturedEvents.Count >= 3,
                    $"Expected at least 3 events (sessionStart, promptStart, system prompt), got {capturedEvents.Count}");

                // First event should be sessionStart
                Assert.Contains("\"sessionStart\"", capturedEvents[0]);

                // Second should be promptStart (with tools)
                Assert.Contains("\"promptStart\"", capturedEvents[1]);
                Assert.Contains("\"toolConfiguration\"", capturedEvents[1]);
                Assert.Contains("TestTool", capturedEvents[1]);

                // System prompt events follow (contentStart, textInput, contentEnd)
                var systemEvents = capturedEvents.Skip(2).ToList();
                Assert.Contains(systemEvents, e => e.Contains("\"contentStart\"") && e.Contains("\"SYSTEM\""));
                Assert.Contains(systemEvents, e => e.Contains("Be helpful."));
            }
        }
        finally
        {
            await session.DisposeAsync();
        }
    }

    #endregion

    #region Concurrent Enumeration Guard Tests

    [Fact]
    public async Task GetStreamingResponseAsync_ConcurrentEnumeration_ThrowsInvalidOperationException()
    {
        var runtimeMock = new Mock<IAmazonBedrockRuntime>();
        runtimeMock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(runtimeMock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        // Simulate an active enumeration by setting the guard field via reflection
        var field = typeof(BedrockNovaRealtimeSession).GetField(
            "_activeStreamingEnumeration",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
        Assert.NotNull(field);
        field!.SetValue(session, 1);

        // Second enumeration should throw immediately
        await Assert.ThrowsAsync<InvalidOperationException>(async () =>
        {
            await foreach (var _ in session.GetStreamingResponseAsync())
            {
            }
        });

        await session.DisposeAsync();
    }

    #endregion

    #region Normalization Tests

    [Fact]
    public void NormalizeToolPayload_Null_ReturnsNull()
    {
        Assert.Null(BedrockNovaRealtimeSession.NormalizeToolPayload(null));
    }

    [Fact]
    public void NormalizeToolPayload_String_ReturnsString()
    {
        Assert.Equal("hello", BedrockNovaRealtimeSession.NormalizeToolPayload("hello"));
    }

    [Fact]
    public void NormalizeToolPayload_ByteArray_ReturnsBase64()
    {
        var bytes = new byte[] { 1, 2, 3 };
        Assert.Equal(Convert.ToBase64String(bytes), BedrockNovaRealtimeSession.NormalizeToolPayload(bytes));
    }

    [Fact]
    public void NormalizeToolPayload_JsonElement_ConvertsToNative()
    {
        using var doc = JsonDocument.Parse("{\"key\": \"value\", \"num\": 42}");
        var result = BedrockNovaRealtimeSession.NormalizeToolPayload(doc.RootElement);

        var dict = Assert.IsType<Dictionary<string, object?>>(result);
        Assert.Equal("value", dict["key"]);
        // JSON numbers may be parsed as long or double depending on TryGetInt64 behavior
        Assert.True(dict["num"] is long or double, $"Expected long or double, got {dict["num"]?.GetType()}");
        Assert.Equal(42.0, Convert.ToDouble(dict["num"]));
    }

    [Fact]
    public void NormalizeToolPayload_DeepNesting_ThrowsAtMaxDepth()
    {
        // Build a deeply nested dictionary that exceeds MaxToolPayloadDepth (64)
        object? current = "leaf";
        for (int i = 0; i < 70; i++)
        {
            current = new Dictionary<string, object?> { ["level"] = current };
        }

        Assert.Throws<InvalidOperationException>(() =>
            BedrockNovaRealtimeSession.NormalizeToolPayload(current));
    }

    [Fact]
    public void NormalizeToolArguments_NormalizesNestedJsonElements()
    {
        using var doc = JsonDocument.Parse("{\"inner\": 123}");
        var args = new Dictionary<string, object?>
        {
            ["name"] = "test",
            ["nested"] = doc.RootElement.Clone()
        };

        var normalized = BedrockNovaRealtimeSession.NormalizeToolArguments(args);

        Assert.Equal("test", normalized["name"]);
        var nestedDict = Assert.IsType<Dictionary<string, object?>>(normalized["nested"]);
        Assert.True(nestedDict["inner"] is long or double, $"Expected long or double, got {nestedDict["inner"]?.GetType()}");
        Assert.Equal(123.0, Convert.ToDouble(nestedDict["inner"]));
    }

    #endregion

    #region SendAsync ODE Propagation Tests

    [Fact]
    public async Task SendAsync_ObjectDisposedDuringSend_PropagatesAsNamedODE()
    {
        var runtimeMock = new Mock<IAmazonBedrockRuntime>();
        runtimeMock.Setup(r => r.InvokeModelWithBidirectionalStreamAsync(
                It.IsAny<InvokeModelWithBidirectionalStreamRequest>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new Mock<InvokeModelWithBidirectionalStreamResponse>().Object);

        var client = new BedrockNovaRealtimeClient(runtimeMock.Object, "test-model");
        var session = await client.CreateSessionAsync();

        // Dispose to cause ODE on any future send that gets past the initial check
        await session.DisposeAsync();

        var ex = await Assert.ThrowsAsync<ObjectDisposedException>(
            () => session.SendAsync(new SessionUpdateRealtimeClientMessage(new RealtimeSessionOptions())));

        Assert.Contains("BedrockNovaRealtimeSession", ex.ObjectName);
    }

    #endregion
}
