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

#if NET8_0_OR_GREATER

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using Amazon.BedrockRuntime.Model;
using Amazon.Runtime.EventStreams;
using Microsoft.Extensions.AI;

#pragma warning disable MEAI001 // Type is for evaluation purposes only

namespace Amazon.BedrockRuntime;

/// <summary>Represents an <see cref="IRealtimeClientSession"/> for Amazon Bedrock Nova Sonic.</summary>
[Experimental("MEAI001")]
public sealed class BedrockNovaRealtimeSession : IRealtimeClientSession
{
    private readonly IAmazonBedrockRuntime _runtime;
    private readonly string _modelId;
    private readonly ChatClientMetadata _metadata;
    private string _promptName = Guid.NewGuid().ToString();
    private readonly SemaphoreSlim _sendSemaphore = new(1, 1);
    private readonly CancellationTokenSource _sessionCts = new();

    // Priority queue for time-sensitive events (tool results) that must bypass queued audio.
    // Nova Sonic generates speculative fallback responses if tool results don't arrive quickly.
    private readonly ConcurrentQueue<BidirectionalInputPayloadPart> _priorityOutbound = new();
    private volatile TaskCompletionSource? _priorityNotification;

    private Channel<BidirectionalInputPayloadPart>? _outboundChannel;
    private InvokeModelWithBidirectionalStreamResponse? _streamResponse;
    private bool _sessionStarted;
    private bool _promptStarted;
    private string? _audioContentName;
    private int _disposed; // 0 = not disposed, 1 = disposed (for Interlocked)

    /// <summary>Initializes a new instance of the <see cref="BedrockNovaRealtimeSession"/> class.</summary>
    /// <param name="runtime">The Amazon Bedrock Runtime client.</param>
    /// <param name="modelId">The model ID to use.</param>
    internal BedrockNovaRealtimeSession(IAmazonBedrockRuntime runtime, string modelId)
    {
        _runtime = runtime;
        _modelId = modelId;
        _metadata = new(AmazonBedrockRuntimeExtensions.ProviderName, defaultModelId: modelId);
    }

    /// <inheritdoc />
    public RealtimeSessionOptions? Options { get; private set; }

    /// <summary>Connects the session to the Bedrock bidirectional stream.</summary>
    /// <param name="options">Optional session options to pre-populate the outbound channel before connecting.
    /// This avoids a deadlock since the SDK may call BodyPublisher before returning.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    internal async Task ConnectAsync(RealtimeSessionOptions? options = null, CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        ObjectDisposedException.ThrowIf(Volatile.Read(ref _disposed) != 0, this);

        _outboundChannel = Channel.CreateUnbounded<BidirectionalInputPayloadPart>(
            new UnboundedChannelOptions { SingleReader = true });

        // Pre-populate the channel with session start events before invoking the SDK.
        // The SDK calls BodyPublisher (which reads from this channel) before returning,
        // so the channel must have data or the call will deadlock.
        if (options is not null)
        {
            await HandleSessionUpdateAsync(new SessionUpdateRealtimeClientMessage(options), cancellationToken)
                .ConfigureAwait(false);
        }

        var sessionToken = _sessionCts.Token;

        var request = new InvokeModelWithBidirectionalStreamRequest
        {
            ModelId = _modelId,
            BodyPublisher = async () =>
            {
                while (true)
                {
                    try
                    {
                        // Always check the priority queue first — tool results must bypass
                        // queued audio events to reach Nova Sonic before it commits to a
                        // speculative fallback response.
                        if (_priorityOutbound.TryDequeue(out var priorityPart))
                        {
                            return priorityPart;
                        }

                        // Set up notification so WritePriorityEventAsync can wake us
                        var tcs = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
                        _priorityNotification = tcs;

                        // Double-check after setting up notification (avoid race)
                        if (_priorityOutbound.TryDequeue(out var priorityPart2))
                        {
                            _priorityNotification = null;
                            return priorityPart2;
                        }

                        // Wait for either the normal channel or a priority notification
                        var normalReady = _outboundChannel!.Reader.WaitToReadAsync(sessionToken).AsTask();
                        await Task.WhenAny(normalReady, tcs.Task).ConfigureAwait(false);
                        _priorityNotification = null;

                        // Always prefer priority events
                        if (_priorityOutbound.TryDequeue(out var priorityPart3))
                        {
                            return priorityPart3;
                        }

                        // Fall back to normal channel
                        if (normalReady.IsCompletedSuccessfully)
                        {
                            if (!normalReady.Result)
                            {
                                // Channel completed — no more data will arrive
                                return null;
                            }

                            if (_outboundChannel.Reader.TryRead(out var part))
                            {
                                return part;
                            }
                        }

                        // Check if session is shutting down (avoids spin loop when
                        // WaitToReadAsync returns a faulted/cancelled task that
                        // Task.WhenAny doesn't propagate)
                        sessionToken.ThrowIfCancellationRequested();
                    }
                    catch (OperationCanceledException)
                    {
                        // Session shutting down — end the stream
                        return null;
                    }
                    catch (ChannelClosedException)
                    {
                        // Channel completed — end the stream
                        return null;
                    }
                }
            }
        };

        _streamResponse = await _runtime.InvokeModelWithBidirectionalStreamAsync(request, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task SendAsync(RealtimeClientMessage message, CancellationToken cancellationToken = default)
    {
        _ = message ?? throw new ArgumentNullException(nameof(message));
        cancellationToken.ThrowIfCancellationRequested();
        ObjectDisposedException.ThrowIf(Volatile.Read(ref _disposed) != 0, this);

        if (_outboundChannel is null)
        {
            throw new InvalidOperationException("Session is not connected. Call ConnectAsync first.");
        }

        try
        {
            await _sendSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
        }
        catch (ObjectDisposedException)
        {
            throw new ObjectDisposedException(nameof(BedrockNovaRealtimeSession));
        }

        try
        {
            // Recheck after acquiring semaphore to avoid race with DisposeAsync
            ObjectDisposedException.ThrowIf(Volatile.Read(ref _disposed) != 0, this);
            switch (message)
            {
                case SessionUpdateRealtimeClientMessage sessionUpdate:
                    await HandleSessionUpdateAsync(sessionUpdate, cancellationToken).ConfigureAwait(false);
                    break;

                case CreateConversationItemRealtimeClientMessage createItem:
                    await HandleCreateConversationItemAsync(createItem, cancellationToken).ConfigureAwait(false);
                    break;

                case InputAudioBufferAppendRealtimeClientMessage audioAppend:
                    await HandleAudioAppendAsync(audioAppend, cancellationToken).ConfigureAwait(false);
                    break;

                case InputAudioBufferCommitRealtimeClientMessage:
                    await HandleAudioCommitAsync(cancellationToken).ConfigureAwait(false);
                    break;

                case CreateResponseRealtimeClientMessage:
                    // Audio content stays open for the entire session (matching
                    // the official AWS sample). Send a small silence nudge to
                    // keep data flowing on the bidirectional stream.
                    await EnsureAudioContentStartedAsync(cancellationToken).ConfigureAwait(false);
                    await SendSilenceFrameAsync(cancellationToken).ConfigureAwait(false);
                    break;

                default:
                    if (message.RawRepresentation is string json)
                    {
                        await WriteEventAsync(json, cancellationToken).ConfigureAwait(false);
                    }
                    else if (message.RawRepresentation is byte[] bytes)
                    {
                        await WriteEventBytesAsync(bytes, cancellationToken).ConfigureAwait(false);
                    }
                    break;
            }
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
        {
            // The caller explicitly cancelled via their token — propagate.
            throw;
        }
        catch (Exception ex) when (ex is OperationCanceledException or ObjectDisposedException or ChannelClosedException)
        {
            // These exceptions are expected during session teardown and are swallowed:
            //   - OperationCanceledException: internal cancellation from disposal (not the caller's token).
            //   - ObjectDisposedException: DisposeAsync was called on another thread.
            //   - ChannelClosedException: the outbound channel was completed during shutdown.
        }
        finally
        {
            try
            {
                _sendSemaphore.Release();
            }
            catch (ObjectDisposedException)
            {
                // DisposeAsync was called concurrently and disposed the semaphore.
            }
        }
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<RealtimeServerMessage> GetStreamingResponseAsync(
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ObjectDisposedException.ThrowIf(Volatile.Read(ref _disposed) != 0, this);

        if (_streamResponse is null)
        {
            throw new InvalidOperationException("Session is not connected. Call ConnectAsync first.");
        }

        string? currentCompletionId = null;
        string? currentContentId = null;
        string? currentContentType = null;
        string? currentRole = null;
        var emittedAssistantTranscripts = new HashSet<string>(StringComparer.Ordinal);
        int outputIndex = 0;
        bool inResponse = false;
        UsageDetails? latestUsage = null;
        List<AIContent>? pendingToolCallContents = null;

        _streamResponse.Body.ChunkReceived += (_, _) => { };
        _streamResponse.Body.ExceptionReceived += (_, _) => { };
        _streamResponse.Body.EventReceived += (_, _) => { };

        IAsyncEnumerator<IEventStreamEvent> enumerator;
        try
        {
            enumerator = _streamResponse.Body.GetAsyncEnumerator(cancellationToken);
        }
        catch (Exception ex) when (ex is OperationCanceledException or ObjectDisposedException)
        {
            yield break;
        }

        while (true)
        {
            bool moved;
            try
            {
                moved = await enumerator.MoveNextAsync().ConfigureAwait(false);
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                // The caller explicitly cancelled via their token — propagate.
                // Dispose the enumerator before rethrowing.
                await enumerator.DisposeAsync().ConfigureAwait(false);
                throw;
            }
            catch (Exception ex) when (ex is OperationCanceledException or ObjectDisposedException or InvalidOperationException)
            {
                // These exceptions are expected during session teardown:
                //   - OperationCanceledException: internal cancellation from disposal.
                //   - ObjectDisposedException: stream was disposed.
                //   - InvalidOperationException: stream in invalid state during shutdown.
                await enumerator.DisposeAsync().ConfigureAwait(false);
                yield break;
            }

            if (!moved)
            {
                await enumerator.DisposeAsync().ConfigureAwait(false);
                yield break;
            }

            var ev = enumerator.Current;

            {
            if (ev is not BidirectionalOutputPayloadPart chunk || chunk.Bytes is null)
            {
                continue;
            }

            JsonDocument doc;
            try
            {
                doc = JsonDocument.Parse(chunk.Bytes);
            }
            catch (JsonException)
            {
                continue;
            }

            using (doc)
            {
                if (!doc.RootElement.TryGetProperty("event", out var eventElement))
                {
                    continue;
                }

                // Trace all incoming events for debugging

                if (eventElement.TryGetProperty("completionStart", out var completionStart))
                {
                    currentCompletionId = completionStart.TryGetProperty("completionId", out var cid) ? cid.GetString() : null;
                    outputIndex = 0;
                    inResponse = true;

                    yield return new ResponseCreatedRealtimeServerMessage(RealtimeServerMessageType.ResponseCreated)
                    {
                        ResponseId = currentCompletionId,
                        RawRepresentation = doc.RootElement.GetRawText()
                    };
                }
                else if (eventElement.TryGetProperty("completionEnd", out var completionEnd))
                {
                    string? stopReason = completionEnd.TryGetProperty("stopReason", out var sr) ? sr.GetString() : null;
                    string status = MapStopReason(stopReason);

                    yield return new ResponseCreatedRealtimeServerMessage(RealtimeServerMessageType.ResponseDone)
                    {
                        ResponseId = currentCompletionId,
                        Status = status,
                        Usage = latestUsage,
                        RawRepresentation = doc.RootElement.GetRawText()
                    };

                    inResponse = false;
                    latestUsage = null;
                    currentCompletionId = null;
                }
                else if (eventElement.TryGetProperty("contentStart", out var contentStart))
                {
                    currentContentId = contentStart.TryGetProperty("contentId", out var cntId) ? cntId.GetString() : null;
                    currentContentType = contentStart.TryGetProperty("type", out var ct) ? ct.GetString() : null;
                    currentRole = contentStart.TryGetProperty("role", out var r) ? r.GetString() : null;

                    // For TOOL content, the toolUse event carries the actual FunctionCallContent,
                    // so we skip emitting an empty ResponseOutputItemAdded here to avoid duplicates.
                    if (inResponse && !string.Equals(currentContentType, "TOOL", StringComparison.OrdinalIgnoreCase))
                    {
                        var item = new RealtimeConversationItem(
                            new List<AIContent>(),
                            id: currentContentId,
                            role: MapRole(currentRole));

                        yield return new ResponseOutputItemRealtimeServerMessage(RealtimeServerMessageType.ResponseOutputItemAdded)
                        {
                            ResponseId = currentCompletionId,
                            OutputIndex = outputIndex,
                            Item = item,
                            RawRepresentation = doc.RootElement.GetRawText()
                        };
                    }
                }
                else if (eventElement.TryGetProperty("contentEnd", out var contentEnd))
                {
                    string? contentStopReason = contentEnd.TryGetProperty("stopReason", out var csr) ? csr.GetString() : null;
                    string? endContentType = contentEnd.TryGetProperty("type", out var ect) ? ect.GetString() : null;

                    if (inResponse)
                    {
                        bool isToolContent = string.Equals(endContentType, "TOOL", StringComparison.OrdinalIgnoreCase)
                                          || string.Equals(currentContentType, "TOOL", StringComparison.OrdinalIgnoreCase);

                        var itemContents = new List<AIContent>();

                        if (isToolContent && pendingToolCallContents is { Count: > 0 })
                        {
                            // Nova Sonic requires tool results immediately — invoke tools directly
                            // and send results before yielding to the consumer, to avoid latency
                            // from the middleware chain that would cause the model to time out.
                            foreach (var pending in pendingToolCallContents)
                            {
                                if (pending is FunctionCallContent fcc)
                                {
                                    var tool = Options?.Tools?.OfType<AIFunction>()
                                        .FirstOrDefault(t => string.Equals(t.Name, fcc.Name, StringComparison.Ordinal));

                                    if (tool is not null)
                                    {
                                        object? result = null;
                                        try
                                        {
                                            result = await tool.InvokeAsync(
                                                fcc.Arguments is not null ? new AIFunctionArguments(fcc.Arguments) : new AIFunctionArguments(),
                                                cancellationToken).ConfigureAwait(false);
                                        }
                                        catch (Exception ex)
                                        {
                                            result = $"Error: {ex.Message}";
                                        }

                                        // Send tool result to Nova Sonic immediately via priority queue
                                        string toolContentName = Guid.NewGuid().ToString();
                                        SendToolResultInline(fcc.CallId, result, toolContentName);

                                        // Only emit FunctionResultContent — omit FunctionCallContent so the
                                        // middleware does NOT re-invoke and send a duplicate tool result.
                                        itemContents.Add(new FunctionResultContent(fcc.CallId, result));
                                    }
                                    else
                                    {
                                        // Tool not found locally — include FunctionCallContent
                                        // so the middleware can handle it
                                        itemContents.Add(fcc);
                                    }
                                }
                                else
                                {
                                    itemContents.Add(pending);
                                }
                            }

                            pendingToolCallContents = null;
                        }

                        var item = new RealtimeConversationItem(
                            itemContents,
                            id: currentContentId,
                            role: MapRole(currentRole));

                        yield return new ResponseOutputItemRealtimeServerMessage(RealtimeServerMessageType.ResponseOutputItemDone)
                        {
                            ResponseId = currentCompletionId,
                            OutputIndex = outputIndex,
                            Item = item,
                            RawRepresentation = doc.RootElement.GetRawText()
                        };

                        outputIndex++;
                    }

                    currentContentId = null;
                    currentContentType = null;
                    currentRole = null;
                }
                else if (eventElement.TryGetProperty("textOutput", out var textOutput))
                {
                    string? text = textOutput.TryGetProperty("content", out var tc) ? tc.GetString() : null;
                    string? itemId = textOutput.TryGetProperty("contentId", out var tid) ? tid.GetString() : null;

                    bool isUserTranscript = string.Equals(currentRole, "USER", StringComparison.OrdinalIgnoreCase);

                    if (isUserTranscript)
                    {
                        yield return new InputAudioTranscriptionRealtimeServerMessage(
                            RealtimeServerMessageType.InputAudioTranscriptionCompleted)
                        {
                            ItemId = itemId,
                            Transcription = text,
                            RawRepresentation = doc.RootElement.GetRawText()
                        };
                    }
                    else if (text is not null
                             && !text.TrimStart().StartsWith("{", StringComparison.Ordinal)
                             && emittedAssistantTranscripts.Add(text))
                    {
                        // Emit ASSISTANT transcript immediately. Skip:
                        // - JSON control messages (e.g. { "interrupted" : true })
                        // - Text already emitted (replayed at start of new completions)

                        yield return new OutputTextAudioRealtimeServerMessage(RealtimeServerMessageType.OutputAudioTranscriptionDelta)
                        {
                            Text = text,
                            ItemId = itemId,
                            ResponseId = currentCompletionId,
                            OutputIndex = outputIndex,
                            RawRepresentation = doc.RootElement.GetRawText()
                        };
                    }
                }
                else if (eventElement.TryGetProperty("audioOutput", out var audioOutput))
                {
                    string? audioData = audioOutput.TryGetProperty("content", out var ac) ? ac.GetString() : null;
                    string? itemId = audioOutput.TryGetProperty("contentId", out var aid) ? aid.GetString() : null;

                    yield return new OutputTextAudioRealtimeServerMessage(RealtimeServerMessageType.OutputAudioDelta)
                    {
                        Audio = audioData,
                        ItemId = itemId,
                        ResponseId = currentCompletionId,
                        OutputIndex = outputIndex,
                        RawRepresentation = doc.RootElement.GetRawText()
                    };
                }
                else if (eventElement.TryGetProperty("toolUse", out var toolUse))
                {
                    string? toolName = toolUse.TryGetProperty("toolName", out var tn) ? tn.GetString() : null;
                    string? toolUseId = toolUse.TryGetProperty("toolUseId", out var tuid) ? tuid.GetString() : null;
                    string? itemId = toolUse.TryGetProperty("contentId", out var tcid) ? tcid.GetString() : null;

                    IDictionary<string, object?>? toolArguments = null;
                    if (toolUse.TryGetProperty("content", out var tcc))
                    {
                        if (tcc.ValueKind == JsonValueKind.Object)
                        {
                            try
                            {

#pragma warning disable IL2026 // Tool arguments are dynamic JSON
                                toolArguments = JsonSerializer.Deserialize<Dictionary<string, object?>>(tcc.GetRawText());
#pragma warning restore IL2026
                            }
                            catch (JsonException)
                            {
                                // If deserialization fails, leave arguments as null
                            }
                        }
                        else if (tcc.ValueKind == JsonValueKind.String)
                        {
                            // The content may be a JSON-encoded string; try to parse it as an object
                            string? innerJson = tcc.GetString();
                            if (innerJson is not null)
                            {
                                try
                                {
#pragma warning disable IL2026 // Tool arguments are dynamic JSON
                                    toolArguments = JsonSerializer.Deserialize<Dictionary<string, object?>>(innerJson);
#pragma warning restore IL2026
                                }
                                catch (JsonException)
                                {
                                    // Not a JSON object string; leave arguments as null
                                }
                            }
                        }
                    }

                    var functionCall = new FunctionCallContent(toolUseId ?? string.Empty, toolName ?? string.Empty, toolArguments);

                    // Store for inline invocation at contentEnd(TOOL).
                    // Do NOT yield here — yielding would cause a round-trip through the consumer
                    // chain, adding latency that causes Nova Sonic to commit to speculative responses.
                    pendingToolCallContents ??= new List<AIContent>();
                    pendingToolCallContents.Add(functionCall);
                }
                else if (eventElement.TryGetProperty("usageEvent", out var usageEvent))
                {
                    latestUsage = ParseUsage(usageEvent);

                    yield return new RealtimeServerMessage
                    {
                        Type = RealtimeServerMessageType.RawContentOnly,
                        RawRepresentation = doc.RootElement.GetRawText()
                    };
                }
                else
                {
                    // Unknown event type - pass through as raw
                    yield return new RealtimeServerMessage
                    {
                        Type = RealtimeServerMessageType.RawContentOnly,
                        RawRepresentation = doc.RootElement.GetRawText()
                    };
                }
            }
            }
        }
    }

    /// <inheritdoc />
    object? IRealtimeClientSession.GetService(Type serviceType, object? serviceKey)
    {
        _ = serviceType ?? throw new ArgumentNullException(nameof(serviceType));

        return
            serviceKey is not null ? null :
            serviceType == typeof(ChatClientMetadata) ? _metadata :
            serviceType.IsInstanceOfType(this) ? this :
            serviceType.IsInstanceOfType(_runtime) ? _runtime :
            null;
    }

    /// <inheritdoc />
    public async ValueTask DisposeAsync()
    {
        if (Interlocked.CompareExchange(ref _disposed, 1, 0) != 0)
        {
            return;
        }

        // Cancel the session-lifetime token to stop the BodyPublisher
        try
        {
            _sessionCts.Cancel();
        }
        catch (ObjectDisposedException)
        {
            // Already disposed
        }

        try
        {
            // Acquire semaphore to ensure no concurrent sends are in progress,
            // and to safely read protocol state fields (_audioContentName, etc.)
            bool acquired = false;
            try
            {
                acquired = await _sendSemaphore.WaitAsync(TimeSpan.FromSeconds(5)).ConfigureAwait(false);
            }
            catch (ObjectDisposedException)
            {
                // Semaphore already disposed
            }

            try
            {
                // Send cleanup messages in correct protocol order
                if (_audioContentName is not null)
                {
                    await TrySendCloseAudioContentAsync().ConfigureAwait(false);
                }

                if (_promptStarted)
                {
                    await TrySendPromptEndAsync().ConfigureAwait(false);
                }

                if (_sessionStarted)
                {
                    await TrySendSessionEndAsync().ConfigureAwait(false);
                }
            }
            finally
            {
                if (acquired)
                {
                    try
                    {
                        _sendSemaphore.Release();
                    }
                    catch (ObjectDisposedException)
                    {
                        // Already disposed
                    }
                }
            }
        }
        catch
        {
            // Best-effort cleanup during disposal
        }
        finally
        {
            _outboundChannel?.Writer.TryComplete();
            _streamResponse?.Dispose();
            _sendSemaphore.Dispose();
            _sessionCts.Dispose();
        }
    }

    #region Send Handlers

    private async Task HandleSessionUpdateAsync(SessionUpdateRealtimeClientMessage sessionUpdate, CancellationToken cancellationToken)
    {
        var opts = sessionUpdate.Options;
        Options = opts;

        // Send sessionStart with inference configuration
        if (!_sessionStarted)
        {
            var wrapper = new NovaSonicEventWrapper
            {
                Event = new NovaSonicEvent
                {
                    SessionStart = new NovaSonicSessionStart
                    {
                        InferenceConfiguration = new NovaSonicInferenceConfig
                        {
                            MaxTokens = opts.MaxOutputTokens ?? 1024,
                            TopP = 0.9,
                            Temperature = 0.7
                        }
                    }
                }
            };

            await WriteEventAsync(JsonSerializer.Serialize(wrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
            _sessionStarted = true;
        }

        // Send promptStart with audio configuration and tools
        if (!_promptStarted)
        {
            int outputSampleRate = 24000;
            string? voiceId = opts.Voice;

            if (opts.OutputAudioFormat is not null)
            {
                outputSampleRate = opts.OutputAudioFormat.SampleRate;
            }

            var promptStartWrapper = BuildPromptStartEvent(voiceId, outputSampleRate, opts.Tools);
            await WriteEventAsync(JsonSerializer.Serialize(promptStartWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
            _promptStarted = true;
        }

        // Send system prompt if instructions are provided
        if (!string.IsNullOrEmpty(opts.Instructions))
        {
            await SendSystemPromptAsync(opts.Instructions, cancellationToken).ConfigureAwait(false);
        }
    }

    private async Task HandleCreateConversationItemAsync(CreateConversationItemRealtimeClientMessage createItem, CancellationToken cancellationToken)
    {
        await EnsurePromptStartedAsync(cancellationToken).ConfigureAwait(false);

        var item = createItem.Item;

        foreach (var content in item.Contents)
        {
            switch (content)
            {
                case TextContent textContent:
                {
                    string role = item.Role?.Value?.ToUpperInvariant() ?? "USER";
                    string contentName = Guid.NewGuid().ToString();

                    // Official AWS sample sends text content alongside open
                    // audio content — no need to close/reopen audio.
                    await SendTextContentAsync(textContent.Text ?? string.Empty, role, contentName, cancellationToken)
                        .ConfigureAwait(false);

                    // For USER text, ensure audio content is open and send
                    // silence to keep the stream flowing while model responds.
                    if (string.Equals(role, "USER", StringComparison.Ordinal))
                    {
                        await EnsureAudioContentStartedAsync(cancellationToken).ConfigureAwait(false);
                        await SendSilenceFrameAsync(cancellationToken).ConfigureAwait(false);
                    }

                    break;
                }

                case FunctionResultContent functionResult:
                {
                    string contentName = Guid.NewGuid().ToString();
                    await SendToolResultAsync(functionResult, contentName, cancellationToken).ConfigureAwait(false);

                    // After sending tool result, ensure audio content is open
                    // and send silence to keep the stream flowing while the
                    // model generates its response incorporating the tool result.
                    await EnsureAudioContentStartedAsync(cancellationToken).ConfigureAwait(false);
                    await SendSilenceFrameAsync(cancellationToken).ConfigureAwait(false);
                    break;
                }

                case DataContent dataContent when dataContent.MediaType?.StartsWith("audio/", StringComparison.OrdinalIgnoreCase) == true:
                {
                    // Audio content in conversation item - send as audio input
                    if (dataContent.Data is { Length: > 0 })
                    {
                        await EnsureAudioContentStartedAsync(cancellationToken).ConfigureAwait(false);

                        var audioWrapper = new NovaSonicEventWrapper
                        {
                            Event = new NovaSonicEvent
                            {
                                AudioInput = new NovaSonicAudioInput
                                {
                                    PromptName = _promptName,
                                    ContentName = _audioContentName,
                                    Content = Convert.ToBase64String(dataContent.Data.Span)
                                }
                            }
                        };

                        await WriteEventAsync(JsonSerializer.Serialize(audioWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
                    }
                    break;
                }
            }
        }
    }

    private async Task HandleAudioAppendAsync(InputAudioBufferAppendRealtimeClientMessage audioAppend, CancellationToken cancellationToken)
    {
        await EnsurePromptStartedAsync(cancellationToken).ConfigureAwait(false);

        await EnsureAudioContentStartedAsync(cancellationToken).ConfigureAwait(false);

        ReadOnlyMemory<byte> audioData;
        if (audioAppend.Content.Data is { Length: > 0 } data)
        {
            audioData = data;
        }
        else
        {
            return;
        }

        var audioWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                AudioInput = new NovaSonicAudioInput
                {
                    PromptName = _promptName,
                    ContentName = _audioContentName,
                    Content = Convert.ToBase64String(audioData.Span)
                }
            }
        };

        await WriteEventAsync(JsonSerializer.Serialize(audioWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
    }

    private async Task HandleAudioCommitAsync(CancellationToken cancellationToken)
    {
        if (_audioContentName is null)
        {
            return;
        }

        // Nova Sonic uses VAD (Voice Activity Detection) to detect speech
        // boundaries. Instead of closing the audio content (which the official
        // samples never do mid-conversation), send trailing silence so the
        // VAD can detect end-of-speech. The audio content stays open.
        int sampleRate = Options?.InputAudioFormat?.SampleRate ?? 16000;

        // Send ~1.5 seconds of silence for reliable VAD detection
        byte[] silence = new byte[sampleRate * 2 * 3 / 2]; // 1.5s, 16-bit mono

        var silenceWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                AudioInput = new NovaSonicAudioInput
                {
                    PromptName = _promptName,
                    ContentName = _audioContentName,
                    Content = Convert.ToBase64String(silence)
                }
            }
        };

        await WriteEventAsync(JsonSerializer.Serialize(silenceWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a brief silence frame on the open audio content.
    /// This keeps data flowing on the bidirectional stream so the model's
    /// response isn't stalled waiting for client writes.
    /// </summary>
    private async Task SendSilenceFrameAsync(CancellationToken cancellationToken)
    {
        if (_audioContentName is null)
        {
            return;
        }

        // ~500ms of silence at the configured sample rate
        int sampleRate = Options?.InputAudioFormat?.SampleRate ?? 16000;
        byte[] silence = new byte[sampleRate * 2 / 2]; // 500ms, 16-bit mono

        var silenceWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                AudioInput = new NovaSonicAudioInput
                {
                    PromptName = _promptName,
                    ContentName = _audioContentName,
                    Content = Convert.ToBase64String(silence)
                }
            }
        };

        await WriteEventAsync(JsonSerializer.Serialize(silenceWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
    }

    #endregion

    #region Protocol Helpers

    private NovaSonicEventWrapper BuildPromptStartEvent(string? voiceId, int outputSampleRate, IReadOnlyList<AITool>? tools)
    {
        var toolsList = new List<NovaSonicToolSpec>();
        if (tools is not null)
        {
            foreach (var tool in tools)
            {
                if (tool is AIFunction func)
                {
                    toolsList.Add(new NovaSonicToolSpec
                    {
                        ToolSpec = new NovaSonicToolSpecDetails
                        {
                            Name = func.Name,
                            Description = func.Description ?? string.Empty,
                            InputSchema = new NovaSonicInputSchema
                            {
                                Json = func.JsonSchema.GetRawText()
                            }
                        }
                    });
                }
            }
        }

        return new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                PromptStart = new NovaSonicPromptStart
                {
                    PromptName = _promptName,
                    TextOutputConfiguration = new NovaSonicMediaConfig { MediaType = "text/plain" },
                    AudioOutputConfiguration = new NovaSonicAudioOutputConfig
                    {
                        MediaType = "audio/lpcm",
                        SampleRateHertz = outputSampleRate,
                        SampleSizeBits = 16,
                        ChannelCount = 1,
                        VoiceId = voiceId ?? "matthew",
                        Encoding = "base64",
                        AudioType = "SPEECH"
                    },
                    ToolUseOutputConfiguration = new NovaSonicMediaConfig { MediaType = "application/json" },
                    ToolConfiguration = toolsList.Count > 0 ? new NovaSonicToolConfiguration { Tools = toolsList } : null
                }
            }
        };
    }

    private async Task SendSystemPromptAsync(string instructions, CancellationToken cancellationToken)
    {
        string contentName = Guid.NewGuid().ToString();

        await SendTextContentAsync(instructions, "SYSTEM", contentName, cancellationToken).ConfigureAwait(false);
    }

    private async Task SendTextContentAsync(string text, string role, string contentName, CancellationToken cancellationToken)
    {
        // Official AWS sample uses interactive = false for SYSTEM prompts,
        // interactive = true for USER text. TOOL results are handled separately.
        bool interactive = string.Equals(role, "USER", StringComparison.OrdinalIgnoreCase);
        var contentStartWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ContentStart = new NovaSonicContentStart
                {
                    PromptName = _promptName,
                    ContentName = contentName,
                    Type = "TEXT",
                    Interactive = interactive,
                    Role = role,
                    TextInputConfiguration = new NovaSonicMediaConfig { MediaType = "text/plain" }
                }
            }
        };
        await WriteEventAsync(JsonSerializer.Serialize(contentStartWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);

        // textInput
        var textWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                TextInput = new NovaSonicTextInput
                {
                    PromptName = _promptName,
                    ContentName = contentName,
                    Content = text
                }
            }
        };
        await WriteEventAsync(JsonSerializer.Serialize(textWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);

        // contentEnd
        var contentEndWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ContentEnd = new NovaSonicContentEnd
                {
                    PromptName = _promptName,
                    ContentName = contentName
                }
            }
        };
        await WriteEventAsync(JsonSerializer.Serialize(contentEndWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
    }

    private async Task SendToolResultAsync(FunctionResultContent functionResult, string contentName, CancellationToken cancellationToken)
    {

        // contentStart for tool result
        var contentStartWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ContentStart = new NovaSonicContentStart
                {
                    PromptName = _promptName,
                    ContentName = contentName,
                    Interactive = false,
                    Type = "TOOL",
                    Role = "TOOL",
                    ToolResultInputConfiguration = new NovaSonicToolResultInputConfig
                    {
                        ToolUseId = functionResult.CallId ?? string.Empty,
                        Type = "TEXT",
                        TextInputConfiguration = new NovaSonicMediaConfig { MediaType = "text/plain" }
                    }
                }
            }
        };
        await WriteEventAsync(JsonSerializer.Serialize(contentStartWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);

        // toolResult — content must be a JSON object string for Nova Sonic
        string resultContent = SerializeToolResult(functionResult.Result);
        var toolResultWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ToolResult = new NovaSonicToolResult
                {
                    PromptName = _promptName,
                    ContentName = contentName,
                    Content = resultContent
                }
            }
        };
        await WriteEventAsync(JsonSerializer.Serialize(toolResultWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);

        // contentEnd
        var contentEndWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ContentEnd = new NovaSonicContentEnd
                {
                    PromptName = _promptName,
                    ContentName = contentName
                }
            }
        };
        await WriteEventAsync(JsonSerializer.Serialize(contentEndWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a tool result directly to the outbound channel, bypassing the semaphore.
    /// Used from within GetStreamingResponseAsync to minimize latency — Nova Sonic
    /// generates speculative (fallback) responses if the tool result is not received quickly.
    /// Uses the priority queue to bypass any queued audio events.
    /// </summary>
    private void SendToolResultInline(string? callId, object? result, string contentName)
    {
        // Capture protocol state to local variables. These fields are mutated under
        // _sendSemaphore in other code paths, but this method is called from
        // GetStreamingResponseAsync (reader thread) without the semaphore.
        string promptName = _promptName;
        string? audioContentName = _audioContentName;

        // contentStart for tool result
        var contentStartWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ContentStart = new NovaSonicContentStart
                {
                    PromptName = promptName,
                    ContentName = contentName,
                    Interactive = false,
                    Type = "TOOL",
                    Role = "TOOL",
                    ToolResultInputConfiguration = new NovaSonicToolResultInputConfig
                    {
                        ToolUseId = callId ?? string.Empty,
                        Type = "TEXT",
                        TextInputConfiguration = new NovaSonicMediaConfig { MediaType = "text/plain" }
                    }
                }
            }
        };
        WritePriorityEvent(JsonSerializer.Serialize(contentStartWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper));

        // toolResult — content must be a JSON object string for Nova Sonic
        string resultContent = SerializeToolResult(result);
        var toolResultWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ToolResult = new NovaSonicToolResult
                {
                    PromptName = promptName,
                    ContentName = contentName,
                    Content = resultContent
                }
            }
        };
        WritePriorityEvent(JsonSerializer.Serialize(toolResultWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper));

        // contentEnd
        var contentEndWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ContentEnd = new NovaSonicContentEnd
                {
                    PromptName = promptName,
                    ContentName = contentName
                }
            }
        };
        WritePriorityEvent(JsonSerializer.Serialize(contentEndWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper));

        // Send a silence frame to keep the stream flowing while the model
        // generates its response with the tool result.
        if (audioContentName is not null)
        {
            int sampleRate = Options?.InputAudioFormat?.SampleRate ?? 16000;
            byte[] silence = new byte[sampleRate * 2 / 10]; // 100ms
            var silenceWrapper = new NovaSonicEventWrapper
            {
                Event = new NovaSonicEvent
                {
                    AudioInput = new NovaSonicAudioInput
                    {
                        PromptName = promptName,
                        ContentName = audioContentName,
                        Content = Convert.ToBase64String(silence)
                    }
                }
            };
            WritePriorityEvent(JsonSerializer.Serialize(silenceWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper));
        }
    }

    private async Task EnsureAudioContentStartedAsync(CancellationToken cancellationToken)
    {
        if (_audioContentName is not null)
        {
            return;
        }

        await EnsurePromptStartedAsync(cancellationToken).ConfigureAwait(false);

        _audioContentName = Guid.NewGuid().ToString();

        int inputSampleRate = Options?.InputAudioFormat?.SampleRate ?? 16000;

        var contentStartWrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                ContentStart = new NovaSonicContentStart
                {
                    PromptName = _promptName,
                    ContentName = _audioContentName,
                    Type = "AUDIO",
                    Interactive = true,
                    Role = "USER",
                    AudioInputConfiguration = new NovaSonicAudioInputConfig
                    {
                        MediaType = "audio/lpcm",
                        SampleRateHertz = inputSampleRate,
                        SampleSizeBits = 16,
                        ChannelCount = 1,
                        AudioType = "SPEECH",
                        Encoding = "base64"
                    }
                }
            }
        };

        await WriteEventAsync(JsonSerializer.Serialize(contentStartWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Ensures a prompt is active. If the prompt was closed after a turn (via promptEnd),
    /// automatically reopens it with a new promptName for the next turn.
    /// </summary>
    private async Task EnsurePromptStartedAsync(CancellationToken cancellationToken)
    {
        if (_promptStarted)
        {
            return;
        }

        if (!_sessionStarted || Options is null)
        {
            throw new InvalidOperationException(
                "Session has not been configured. Send a SessionUpdateRealtimeClientMessage before sending other messages.");
        }

        // Each prompt turn gets a unique promptName per the Nova Sonic protocol.
        _promptName = Guid.NewGuid().ToString();

        int outputSampleRate = Options.OutputAudioFormat?.SampleRate ?? 24000;
        string? voiceId = Options.Voice;

        var promptStartWrapper = BuildPromptStartEvent(voiceId, outputSampleRate, Options.Tools);
        await WriteEventAsync(JsonSerializer.Serialize(promptStartWrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper), cancellationToken).ConfigureAwait(false);
        _promptStarted = true;
    }

    private async Task SendPromptEndAsync(CancellationToken cancellationToken)
    {
        if (!_promptStarted)
        {
            return;
        }

        var wrapper = new NovaSonicEventWrapper
        {
            Event = new NovaSonicEvent
            {
                PromptEnd = new NovaSonicPromptEnd
                {
                    PromptName = _promptName
                }
            }
        };
        var json = JsonSerializer.Serialize(wrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper);

        await WriteEventAsync(json, cancellationToken).ConfigureAwait(false);
        _promptStarted = false;
    }

    private async Task WriteEventAsync(string json, CancellationToken cancellationToken)
    {
        if (_outboundChannel is null)
        {
            return;
        }

        var bytes = Encoding.UTF8.GetBytes(json);
        // MemoryStream wraps a managed byte array with no unmanaged resources.
        // Disposal is not required; the SDK consumes the stream in BodyPublisher.
        var part = new BidirectionalInputPayloadPart
        {
            Bytes = new MemoryStream(bytes)
        };

        try
        {
            await _outboundChannel.Writer.WriteAsync(part, cancellationToken).ConfigureAwait(false);
        }
        catch (ChannelClosedException)
        {
            // Channel already completed during shutdown
        }
    }

    private async Task WriteEventBytesAsync(byte[] bytes, CancellationToken cancellationToken)
    {
        if (_outboundChannel is null)
        {
            return;
        }

        var part = new BidirectionalInputPayloadPart
        {
            Bytes = new MemoryStream(bytes)
        };

        try
        {
            await _outboundChannel.Writer.WriteAsync(part, cancellationToken).ConfigureAwait(false);
        }
        catch (ChannelClosedException)
        {
            // Channel already completed during shutdown
        }
    }

    /// <summary>
    /// Writes an event to the priority queue, bypassing the normal outbound channel.
    /// The BodyPublisher always checks this queue first, ensuring tool results reach
    /// Nova Sonic before queued audio events.
    /// </summary>
    private void WritePriorityEvent(string json)
    {
        var bytes = Encoding.UTF8.GetBytes(json);
        var part = new BidirectionalInputPayloadPart
        {
            Bytes = new MemoryStream(bytes)
        };

        _priorityOutbound.Enqueue(part);

        // Wake up the BodyPublisher if it's waiting
        _priorityNotification?.TrySetResult();
    }

    private async Task TrySendCloseAudioContentAsync()
    {
        if (_audioContentName is null)
        {
            return;
        }

        try
        {
            var wrapper = new NovaSonicEventWrapper
            {
                Event = new NovaSonicEvent
                {
                    ContentEnd = new NovaSonicContentEnd
                    {
                        PromptName = _promptName,
                        ContentName = _audioContentName
                    }
                }
            };
            var json = JsonSerializer.Serialize(wrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper);

            await WriteEventAsync(json, CancellationToken.None).ConfigureAwait(false);
            _audioContentName = null;
        }
        catch
        {
            // Best-effort during disposal
        }
    }

    private async Task TrySendPromptEndAsync()
    {
        try
        {
            var wrapper = new NovaSonicEventWrapper
            {
                Event = new NovaSonicEvent
                {
                    PromptEnd = new NovaSonicPromptEnd
                    {
                        PromptName = _promptName
                    }
                }
            };
            var json = JsonSerializer.Serialize(wrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper);

            await WriteEventAsync(json, CancellationToken.None).ConfigureAwait(false);
        }
        catch
        {
            // Best-effort during disposal
        }
    }

    private async Task TrySendSessionEndAsync()
    {
        try
        {
            var wrapper = new NovaSonicEventWrapper
            {
                Event = new NovaSonicEvent
                {
                    SessionEnd = new NovaSonicSessionEnd()
                }
            };
            var json = JsonSerializer.Serialize(wrapper, NovaSonicJsonOptions.Context.NovaSonicEventWrapper);

            await WriteEventAsync(json, CancellationToken.None).ConfigureAwait(false);
        }
        catch
        {
            // Best-effort during disposal
        }
    }

    #endregion

    #region Mapping Helpers

    /// <summary>
    /// Serializes a function result into a JSON object string for Nova Sonic's toolResult.content.
    /// Nova Sonic requires this to be a JSON object (starting with '{'), not a primitive or array.
    /// </summary>
    private static string SerializeToolResult(object? result)
    {
        if (result is null)
        {
            return "{}";
        }

        if (result is JsonElement jsonElement)
        {
            if (jsonElement.ValueKind == JsonValueKind.Object)
            {
                return jsonElement.GetRawText();
            }

            // Non-object JsonElement (string, number, array, etc.) — wrap in an object
#pragma warning disable IL2026 // Tool result values are dynamic
            return JsonSerializer.Serialize(new NovaSonicToolResultWrapper { Result = jsonElement }, NovaSonicJsonOptions.Reflection);
#pragma warning restore IL2026
        }

        if (result is string strResult)
        {
            // Try to parse as JSON object first
            try
            {
                using var doc = JsonDocument.Parse(strResult);
                if (doc.RootElement.ValueKind == JsonValueKind.Object)
                {
                    return strResult;
                }
            }
            catch (JsonException)
            {
                // Not valid JSON
            }

#pragma warning disable IL2026 // Tool result values are dynamic
            return JsonSerializer.Serialize(new NovaSonicToolResultWrapper { Result = strResult }, NovaSonicJsonOptions.Reflection);
#pragma warning restore IL2026
        }

        // For other types, serialize and check if result is an object
        try
        {
#pragma warning disable IL2026 // Tool result values are dynamic
            string json = JsonSerializer.Serialize(result, NovaSonicJsonOptions.Reflection);
#pragma warning restore IL2026
            using var doc2 = JsonDocument.Parse(json);
            if (doc2.RootElement.ValueKind == JsonValueKind.Object)
            {
                return json;
            }

#pragma warning disable IL2026 // Tool result values are dynamic
            return JsonSerializer.Serialize(new NovaSonicToolResultWrapper { Result = result }, NovaSonicJsonOptions.Reflection);
#pragma warning restore IL2026
        }
        catch (JsonException)
        {
#pragma warning disable IL2026 // Tool result values are dynamic
            return JsonSerializer.Serialize(new NovaSonicToolResultWrapper { Result = result.ToString() }, NovaSonicJsonOptions.Reflection);
#pragma warning restore IL2026
        }
    }

    private static string MapStopReason(string? stopReason) =>
        stopReason?.ToUpperInvariant() switch
        {
            "END_TURN" => RealtimeResponseStatus.Completed,
            "INTERRUPTED" => RealtimeResponseStatus.Cancelled,
            "TOOL_USE" => RealtimeResponseStatus.Completed,
            _ => RealtimeResponseStatus.Completed
        };

    private static ChatRole? MapRole(string? role) =>
        role?.ToUpperInvariant() switch
        {
            "USER" => ChatRole.User,
            "ASSISTANT" => ChatRole.Assistant,
            "SYSTEM" => ChatRole.System,
            "TOOL" => ChatRole.Tool,
            _ => null
        };

    private static UsageDetails? ParseUsage(JsonElement usageElement)
    {
        int totalInputTokens = 0;
        int totalOutputTokens = 0;

        if (usageElement.TryGetProperty("totalInputTokens", out var inputTokens))
        {
            totalInputTokens = inputTokens.GetInt32();
        }

        if (usageElement.TryGetProperty("totalOutputTokens", out var outputTokens))
        {
            totalOutputTokens = outputTokens.GetInt32();
        }

        if (totalInputTokens == 0 && totalOutputTokens == 0)
        {
            return null;
        }

        return new UsageDetails
        {
            InputTokenCount = totalInputTokens,
            OutputTokenCount = totalOutputTokens,
            TotalTokenCount = totalInputTokens + totalOutputTokens
        };
    }

    #endregion
}

/// <summary>Provides JSON serializer options for Nova Sonic protocol events.</summary>
internal static class NovaSonicJsonOptions
{
    /// <summary>Gets the source-generated context configured with <see cref="JavaScriptEncoder.UnsafeRelaxedJsonEscaping"/>.</summary>
    /// <remarks>
    /// Uses <see cref="JavaScriptEncoder.UnsafeRelaxedJsonEscaping"/> to avoid Unicode escape sequences
    /// (e.g., <c>\u0022</c>) that some downstream parsers may not handle correctly when processing
    /// nested JSON strings such as <c>inputSchema.json</c>.
    /// </remarks>
    internal static readonly NovaSonicJsonContext Context = new(new JsonSerializerOptions
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    });

    /// <summary>Gets reflection-based options for serializing tool results with unknown types.</summary>
    internal static readonly JsonSerializerOptions Reflection = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };
}

#region Nova Sonic Protocol DTOs

internal sealed class NovaSonicEventWrapper
{
    [JsonPropertyName("event")]
    public NovaSonicEvent? Event { get; set; }
}

internal sealed class NovaSonicEvent
{
    public NovaSonicSessionStart? SessionStart { get; set; }
    public NovaSonicPromptStart? PromptStart { get; set; }
    public NovaSonicContentStart? ContentStart { get; set; }
    public NovaSonicTextInput? TextInput { get; set; }
    public NovaSonicAudioInput? AudioInput { get; set; }
    public NovaSonicToolResult? ToolResult { get; set; }
    public NovaSonicContentEnd? ContentEnd { get; set; }
    public NovaSonicPromptEnd? PromptEnd { get; set; }
    public NovaSonicSessionEnd? SessionEnd { get; set; }
}

internal sealed class NovaSonicSessionStart
{
    public NovaSonicInferenceConfig? InferenceConfiguration { get; set; }
}

internal sealed class NovaSonicInferenceConfig
{
    public int MaxTokens { get; set; }
    public double TopP { get; set; }
    public double Temperature { get; set; }
}

internal sealed class NovaSonicPromptStart
{
    public string? PromptName { get; set; }
    public NovaSonicMediaConfig? TextOutputConfiguration { get; set; }
    public NovaSonicAudioOutputConfig? AudioOutputConfiguration { get; set; }
    public NovaSonicMediaConfig? ToolUseOutputConfiguration { get; set; }
    public NovaSonicToolConfiguration? ToolConfiguration { get; set; }
}

internal sealed class NovaSonicMediaConfig
{
    public string? MediaType { get; set; }
}

internal sealed class NovaSonicAudioOutputConfig
{
    public string? MediaType { get; set; }
    public int SampleRateHertz { get; set; }
    public int SampleSizeBits { get; set; }
    public int ChannelCount { get; set; }
    public string? VoiceId { get; set; }
    public string? Encoding { get; set; }
    public string? AudioType { get; set; }
}

internal sealed class NovaSonicToolConfiguration
{
    public List<NovaSonicToolSpec>? Tools { get; set; }
}

internal sealed class NovaSonicToolSpec
{
    public NovaSonicToolSpecDetails? ToolSpec { get; set; }
}

internal sealed class NovaSonicToolSpecDetails
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public NovaSonicInputSchema? InputSchema { get; set; }
}

internal sealed class NovaSonicInputSchema
{
    public string? Json { get; set; }
}

internal sealed class NovaSonicContentStart
{
    public string? PromptName { get; set; }
    public string? ContentName { get; set; }
    public string? Type { get; set; }
    public bool Interactive { get; set; }
    public string? Role { get; set; }
    public NovaSonicMediaConfig? TextInputConfiguration { get; set; }
    public NovaSonicAudioInputConfig? AudioInputConfiguration { get; set; }
    public NovaSonicToolResultInputConfig? ToolResultInputConfiguration { get; set; }
}

internal sealed class NovaSonicAudioInputConfig
{
    public string? MediaType { get; set; }
    public int SampleRateHertz { get; set; }
    public int SampleSizeBits { get; set; }
    public int ChannelCount { get; set; }
    public string? Encoding { get; set; }
    public string? AudioType { get; set; }
}

internal sealed class NovaSonicToolResultInputConfig
{
    public string? ToolUseId { get; set; }
    public string? Type { get; set; }
    public NovaSonicMediaConfig? TextInputConfiguration { get; set; }
}

internal sealed class NovaSonicTextInput
{
    public string? PromptName { get; set; }
    public string? ContentName { get; set; }
    public string? Content { get; set; }
}

internal sealed class NovaSonicAudioInput
{
    public string? PromptName { get; set; }
    public string? ContentName { get; set; }
    public string? Content { get; set; }
}

internal sealed class NovaSonicToolResult
{
    public string? PromptName { get; set; }
    public string? ContentName { get; set; }
    public string? Content { get; set; }
}

internal sealed class NovaSonicContentEnd
{
    public string? PromptName { get; set; }
    public string? ContentName { get; set; }
}

internal sealed class NovaSonicPromptEnd
{
    public string? PromptName { get; set; }
}

internal sealed class NovaSonicSessionEnd { }

internal sealed class NovaSonicToolResultWrapper
{
    public object? Result { get; set; }
}

#endregion

[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    WriteIndented = false)]
[JsonSerializable(typeof(NovaSonicEventWrapper))]
[JsonSerializable(typeof(NovaSonicToolResultWrapper))]
internal partial class NovaSonicJsonContext : JsonSerializerContext
{
}

#endif
