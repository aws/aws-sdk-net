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

using Amazon.BedrockRuntime.Model;
using Amazon.Runtime.Documents;
using Amazon.Runtime.Internal.Util;
using Microsoft.Extensions.AI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.BedrockRuntime;

internal sealed partial class BedrockChatClient : IChatClient
{
    /// <summary>A default logger to use.</summary>
    private static readonly ILogger DefaultLogger = Logger.GetLogger(typeof(BedrockChatClient));

    /// <summary>The wrapped <see cref="IAmazonBedrockRuntime"/> instance.</summary>
    private readonly IAmazonBedrockRuntime _runtime;
    /// <summary>Default model ID to use when no model is specified in the request.</summary>
    private readonly string? _modelId;
    /// <summary>Metadata describing the chat client.</summary>
    private readonly ChatClientMetadata _metadata;

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockChatClient"/> class.
    /// </summary>
    /// <param name="runtime">The <see cref="IAmazonBedrockRuntime"/> instance to wrap.</param>
    /// <param name="defaultModelId">Model ID to use as the default when no model ID is specified in a request.</param>
    public BedrockChatClient(IAmazonBedrockRuntime runtime, string? defaultModelId)
    {
        Debug.Assert(runtime is not null);

        _runtime = runtime!;
        _modelId = defaultModelId;

        _metadata = new(AmazonBedrockRuntimeExtensions.ProviderName, defaultModelId: defaultModelId);
    }

    public void Dispose()
    {
        // Do not dispose of _runtime, as this instance doesn't own it.
    }

    /// <inheritdoc />
    public async Task<ChatResponse> GetResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options = null, CancellationToken cancellationToken = default)
    {
        if (messages is null)
        {
            throw new ArgumentNullException(nameof(messages));
        }

        ConverseRequest request = options?.RawRepresentationFactory?.Invoke(this) as ConverseRequest ?? new();
        request.ModelId ??= options?.ModelId ?? _modelId;
        request.Messages = CreateMessages(request.Messages, messages);
        request.System = CreateSystem(request.System, messages, options);
        request.ToolConfig = CreateToolConfig(request.ToolConfig, options);
        request.InferenceConfig = CreateInferenceConfiguration(request.InferenceConfig, options);
        request.AdditionalModelRequestFields = CreateAdditionalModelRequestFields(request.AdditionalModelRequestFields, options);

        var response = await _runtime.ConverseAsync(request, cancellationToken).ConfigureAwait(false);

        ChatMessage result = new()
        {
            CreatedAt = DateTimeOffset.UtcNow,
            RawRepresentation = response.Output?.Message,
            Role = ChatRole.Assistant,
            MessageId = Guid.NewGuid().ToString("N"),
        };

        if (response.Output?.Message?.Content is { } contents)
        {
            foreach (var content in contents)
            {
                if (content.Text is string text)
                {
                    result.Contents.Add(new TextContent(text) { RawRepresentation = content });
                }

                if (content.CitationsContent is { } citations &&
                    citations.Citations is { Count: > 0 } &&
                    citations.Content is { Count: > 0 })
                {
                    int count = Math.Min(citations.Citations.Count, citations.Content.Count);
                    for (int i = 0; i < count; i++)
                    {
                        TextContent tc = new(citations.Content[i]?.Text) { RawRepresentation = citations.Content[i] };
                        tc.Annotations = [new CitationAnnotation()
                        {
                            Title = citations.Citations[i].Title,
                            Snippet = citations.Citations[i].SourceContent?.Select(c => c.Text).FirstOrDefault(),
                        }];
                        result.Contents.Add(tc);
                    }
                }

                if (content.ReasoningContent is { ReasoningText.Text: not null } reasoningContent)
                {
                    TextReasoningContent trc = new(reasoningContent.ReasoningText.Text) { RawRepresentation = content };

                    if (reasoningContent.ReasoningText.Signature is string signature)
                    {
                        (trc.AdditionalProperties ??= [])[nameof(reasoningContent.ReasoningText.Signature)] = signature;
                    }

                    if (reasoningContent.RedactedContent is { } redactedContent)
                    {
                        (trc.AdditionalProperties ??= [])[nameof(reasoningContent.RedactedContent)] = redactedContent.ToArray();
                    }

                    result.Contents.Add(trc);
                }

                if (content.Image is { Source.Bytes: { } imageBytes, Format: { } imageFormat })
                {
                    result.Contents.Add(new DataContent(imageBytes.ToArray(), GetMimeType(imageFormat)) { RawRepresentation = content });
                }

                if (content.Video is { Source.Bytes: { } videoBytes, Format: { } videoFormat })
                {
                    result.Contents.Add(new DataContent(videoBytes.ToArray(), GetMimeType(videoFormat)) { RawRepresentation = content });
                }

                if (content.Document is { Source.Bytes: { } documentBytes, Format: { } documentFormat })
                {
                    result.Contents.Add(new DataContent(documentBytes.ToArray(), GetMimeType(documentFormat)) 
                    {
                        RawRepresentation = content,
                        Name = content.Document.Name 
                    });
                }

                if (content.ToolUse is { } toolUse)
                {
                    result.Contents.Add(new FunctionCallContent(toolUse.ToolUseId, toolUse.Name, DocumentToDictionary(toolUse.Input)) { RawRepresentation = content });
                }
            }
        }

        if (DocumentToDictionary(response.AdditionalModelResponseFields) is { } responseFieldsDictionary)
        {
            result.AdditionalProperties = new(responseFieldsDictionary);
        }

        return new(result)
        {
            CreatedAt = result.CreatedAt,
            FinishReason = response.StopReason is not null ? GetChatFinishReason(response.StopReason) : null,
            RawRepresentation = response,
            ResponseId = Guid.NewGuid().ToString("N"),
            Usage = response.Usage is TokenUsage usage ? CreateUsageDetails(usage) : null,
        };
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<ChatResponseUpdate> GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options = null, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (messages is null)
        {
            throw new ArgumentNullException(nameof(messages));
        }

        ConverseStreamRequest request = options?.RawRepresentationFactory?.Invoke(this) as ConverseStreamRequest ?? new();
        request.ModelId ??= options?.ModelId ?? _modelId;
        request.Messages = CreateMessages(request.Messages, messages);
        request.System = CreateSystem(request.System, messages, options);
        request.ToolConfig = CreateToolConfig(request.ToolConfig, options);
        request.InferenceConfig = CreateInferenceConfiguration(request.InferenceConfig, options);
        request.AdditionalModelRequestFields = CreateAdditionalModelRequestFields(request.AdditionalModelRequestFields, options);

        var result = await _runtime.ConverseStreamAsync(request, cancellationToken).ConfigureAwait(false);

        string? toolName = null;
        string? toolId = null;
        StringBuilder? toolInput = null;
        ChatFinishReason? finishReason = null;
        string messageId = Guid.NewGuid().ToString("N");
        string responseId = Guid.NewGuid().ToString("N");
        await foreach (var update in result.Stream.ConfigureAwait(false))
        {
            switch (update)
            {
                case MessageStartEvent messageStart:
                    yield return new()
                    {
                        CreatedAt = DateTimeOffset.UtcNow,
                        MessageId = messageId,
                        RawRepresentation = update,
                        ResponseId = responseId,
                        Role = ChatRole.Assistant,
                        FinishReason = finishReason,
                    };
                    break;

                case ContentBlockStartEvent contentBlockStart when contentBlockStart?.Start?.ToolUse is ToolUseBlockStart tubs:
                    toolName ??= tubs.Name;
                    toolId ??= tubs.ToolUseId;
                    break;

                case ContentBlockDeltaEvent contentBlockDelta when contentBlockDelta.Delta is not null:
                    if (contentBlockDelta.Delta.ToolUse is ToolUseBlockDelta tubd)
                    {
                        (toolInput ??= new()).Append(tubd.Input);
                    }

                    if (contentBlockDelta.Delta.Text is string text)
                    {
                        ChatResponseUpdate textUpdate = new(ChatRole.Assistant, text)
                        {
                            CreatedAt = DateTimeOffset.UtcNow,
                            MessageId = messageId,
                            RawRepresentation = update,
                            FinishReason = finishReason,
                            ResponseId = responseId,
                        };

                        if (contentBlockDelta.Delta.Citation is { } citation &&
                            (citation.Title is not null || citation.SourceContent is { Count: > 0 }))
                        {
                            textUpdate.Contents[0].Annotations = [new CitationAnnotation()
                            {
                                Title = citation.Title,
                                Snippet = citation.SourceContent?.Select(c => c.Text).FirstOrDefault(),
                            }];
                        }

                        yield return textUpdate;
                    }

                    if (contentBlockDelta.Delta.ReasoningContent is { Text: not null } reasoningContent)
                    {
                        TextReasoningContent trc = new(reasoningContent.Text);

                        if (reasoningContent.Signature is not null)
                        {
                            (trc.AdditionalProperties ??= [])[nameof(reasoningContent.Signature)] = reasoningContent.Signature;
                        }

                        if (reasoningContent.RedactedContent is { } redactedContent)
                        {
                            (trc.AdditionalProperties ??= [])[nameof(reasoningContent.RedactedContent)] = redactedContent.ToArray();
                        }

                        yield return new(ChatRole.Assistant, [trc])
                        {
                            CreatedAt = DateTimeOffset.UtcNow,
                            MessageId = messageId,
                            FinishReason = finishReason,
                            RawRepresentation = update,
                            ResponseId = responseId,
                        };
                    }
                    break;

                case ContentBlockStopEvent contentBlockStop:
                    if (toolName is not null && toolId is not null)
                    {
                        Dictionary<string, object?>? inputs = ParseToolInputs(toolInput?.ToString(), out Exception? parseError);
                        yield return new()
                        {
                            Contents = [new FunctionCallContent(toolId, toolName, inputs) { Exception = parseError }],
                            CreatedAt = DateTimeOffset.UtcNow,
                            MessageId = messageId,
                            FinishReason = finishReason,
                            RawRepresentation = update,
                            ResponseId = responseId,
                            Role = ChatRole.Assistant,
                        };
                    }

                    toolName = null;
                    toolId = null;
                    toolInput = null;
                    break;

                case MessageStopEvent messageStop:
                    if (messageStop.StopReason is not null)
                    {
                        finishReason ??= GetChatFinishReason(messageStop.StopReason);
                    }

                    AdditionalPropertiesDictionary? additionalProps = null;
                    if (DocumentToDictionary(messageStop.AdditionalModelResponseFields) is { } responseFieldsDictionary)
                    {
                        additionalProps = new(responseFieldsDictionary);
                    }

                    yield return new()
                    {
                        AdditionalProperties = additionalProps,
                        CreatedAt = DateTimeOffset.UtcNow,
                        MessageId = messageId,
                        FinishReason = finishReason,
                        RawRepresentation = update,
                        ResponseId = responseId,
                        Role = ChatRole.Assistant,
                    };
                    break;

                case ConverseStreamMetadataEvent metadata when metadata.Usage is TokenUsage usage:
                    yield return new(ChatRole.Assistant, [new UsageContent(CreateUsageDetails(usage))])
                    {
                        CreatedAt = DateTimeOffset.UtcNow,
                        FinishReason = finishReason,
                        MessageId = messageId,
                        RawRepresentation = update,
                        ResponseId = responseId,
                    };
                    break;
            }
        }
    }

    /// <inheritdoc />
    public object? GetService(Type serviceType, object? serviceKey)
    {
        if (serviceType is null)
        {
            throw new ArgumentNullException(nameof(serviceType));
        }

        return 
            serviceKey is not null ? null :
            serviceType == typeof(ChatClientMetadata) ? _metadata :
            serviceType.IsInstanceOfType(_runtime) ? _runtime :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    /// <summary>Creates a <see cref="UsageDetails"/> from a <see cref="TokenUsage"/>.</summary>
    private static UsageDetails CreateUsageDetails(TokenUsage usage)
    {
        UsageDetails ud = new()
        {
            InputTokenCount = usage.InputTokens,
            OutputTokenCount = usage.OutputTokens,
            TotalTokenCount = usage.TotalTokens,
        };

        if (usage.CacheReadInputTokens is int cacheReadTokens)
        {
            (ud.AdditionalCounts ??= []).Add(nameof(usage.CacheReadInputTokens), cacheReadTokens);
        }

        if (usage.CacheWriteInputTokens is int cacheWriteTokens)
        {
            (ud.AdditionalCounts ??= []).Add(nameof(usage.CacheWriteInputTokens), cacheWriteTokens);
        }

        return ud;
    }

    /// <summary>Converts a <see cref="StopReason"/> into a <see cref="ChatFinishReason"/>.</summary>
    private static ChatFinishReason GetChatFinishReason(StopReason stopReason) =>
        stopReason.Value switch
        {
            "content_filtered" => ChatFinishReason.ContentFilter,
            "guardrail_intervened" => ChatFinishReason.ContentFilter,
            "end_turn" => ChatFinishReason.Stop,
            "max_tokens" => ChatFinishReason.Length,
            "stop_sequence" => ChatFinishReason.Stop,
            "tool_use" => ChatFinishReason.ToolCalls,
            _ => new(stopReason.Value),
        };

    /// <summary>Creates a list of <see cref="SystemContentBlock"/> from the system messages in the provided <paramref name="messages"/>.</summary>
    private static List<SystemContentBlock> CreateSystem(List<SystemContentBlock>? rawMessages, IEnumerable<ChatMessage> messages, ChatOptions? options)
    {
        List<SystemContentBlock> system = rawMessages ?? [];

        if (options?.Instructions is { } instructions)
        {
            system.Add(new SystemContentBlock() { Text = instructions });
        }

        system.AddRange(messages
            .Where(m => m.Role == ChatRole.System && m.Contents.Any(c => c is TextContent))
            .Select(m => new SystemContentBlock() { Text = string.Concat(m.Contents.OfType<TextContent>()) }));

        return system;
    }

    /// <summary>Parses JSON tool input into a <see cref="Dictionary{String, Object}"/>.</summary>
    private static Dictionary<string, object?>? ParseToolInputs(string? jsonInput, out Exception? parseError)
    {
        parseError = null;
        if (jsonInput is not null)
        {
            try
            {
                return (Dictionary<string, object?>?)JsonSerializer.Deserialize(jsonInput, BedrockJsonContext.DefaultOptions.GetTypeInfo(typeof(Dictionary<string, object?>)));
            }
            catch (Exception e)
            {
                parseError = new InvalidOperationException($"Unable to parse input: {jsonInput}", e);
            }
        }

        return null;
    }

    /// <summary>Creates a list of <see cref="Message"/> from the provided <paramref name="chatMessages"/>.</summary>
    private static List<Message> CreateMessages(List<Message>? rawMessages, IEnumerable<ChatMessage> chatMessages)
    {
        List<Message> messages = rawMessages ?? [];

        foreach (ChatMessage chatMessage in chatMessages)
        {
            if (chatMessage.Role != ChatRole.System &&
                CreateContents(chatMessage) is { Count: > 0 } contents)
            {
                messages.Add(new()
                {
                    Role = chatMessage.Role == ChatRole.Assistant ? ConversationRole.Assistant : ConversationRole.User,
                    Content = contents,
                });
            }
        }

        return messages;
    }

    /// <summary>Creates a list of <see cref="ContentBlock"/>s from a <see cref="ChatMessage"/>.</summary>
    private static List<ContentBlock> CreateContents(ChatMessage message)
    {
        List<ContentBlock> contents = [];

        foreach (AIContent content in message.Contents)
        {
            switch (content)
            {
                case TextContent tc:
                    if (message.Role == ChatRole.Assistant)
                    {
                        string text = tc.Text.TrimEnd();
                        if (text.Length != 0)
                        {
                            contents.Add(new() { Text = text });
                        }
                    }
                    else
                    {
                        contents.Add(new() { Text = tc.Text });
                    }
                    break;

                case TextReasoningContent trc:
                    contents.Add(new()
                    {
                        ReasoningContent = new()
                        {
                            ReasoningText = new()
                            {
                                Text = trc.Text,
                                Signature = trc.AdditionalProperties?[nameof(ReasoningContentBlock.ReasoningText.Signature)] as string,
                            },
                            RedactedContent = trc.AdditionalProperties?[nameof(ReasoningContentBlock.RedactedContent)] is byte[] array ? new(array) : null,
                        }
                    });
                    break;

                case DataContent dc:
                    if (GetImageFormat(dc.MediaType) is ImageFormat imageFormat)
                    {
                        contents.Add(new()
                        {
                            Image = new()
                            {
                                Source = new() { Bytes = new(dc.Data.ToArray()) },
                                Format = imageFormat,
                            }
                        });
                    }
                    else if (GetVideoFormat(dc.MediaType) is VideoFormat videoFormat)
                    {
                        contents.Add(new()
                        {
                            Video = new()
                            {
                                Source = new() { Bytes = new(dc.Data.ToArray()) },
                                Format = videoFormat,
                            }
                        });
                    }
                    else if (GetDocumentFormat(dc.MediaType) is DocumentFormat docFormat)
                    {
                        contents.Add(new()
                        {
                            Document = new()
                            {
                                Source = new() { Bytes = new(dc.Data.ToArray()) },
                                Format = docFormat,
                                Name = dc.Name ?? "file",
                            }
                        });
                    }
                    break;

                case FunctionCallContent fcc:
                    contents.Add(new()
                    {
                        ToolUse = new()
                        {
                            ToolUseId = fcc.CallId,
                            Name = fcc.Name,
                            Input = DictionaryToDocument(fcc.Arguments),
                        }
                    });
                    break;

                case FunctionResultContent frc:
                    Document result = frc.Result switch
                    {
                        int i => i,
                        long l => l,
                        float f => f,
                        double d => d,
                        string s => s,
                        bool b => b,
                        JsonElement json => ToDocument(json),
                        { } other => ToDocument(JsonSerializer.SerializeToElement(other, BedrockJsonContext.DefaultOptions.GetTypeInfo(other.GetType()))),
                        _ => default,
                    };

                    contents.Add(new()
                    {
                        ToolResult = new()
                        {
                            ToolUseId = frc.CallId,
                            Content = [new() { Json = new Document(new Dictionary<string, Document>() { ["result"] = result }) }],
                        },
                    });
                    break;
            }
        }

        return contents;
    }

    /// <summary>Gets the <see cref="DocumentFormat"/> for the specified MIME type.</summary>
    private static DocumentFormat? GetDocumentFormat(string? mediaType) =>
        mediaType switch
        {
            "text/csv" => DocumentFormat.Csv,
            "text/html" => DocumentFormat.Html,
            "text/markdown" => DocumentFormat.Md,
            "text/plain" => DocumentFormat.Txt,
            "application/pdf" => DocumentFormat.Pdf,
            "application/msword" => DocumentFormat.Doc,
            "application/vnd.openxmlformats-officedocument.wordprocessingml.document" => DocumentFormat.Docx,
            "application/vnd.ms-excel" => DocumentFormat.Xls,
            "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" => DocumentFormat.Xlsx,
            _ => null,
        };

    /// <summary>Gets the MIME type for a <see cref="DocumentFormat"/>.</summary>
    private static string GetMimeType(DocumentFormat? format) =>
        format?.Value switch
        {
            "csv" => "text/csv",
            "html" => "text/html",
            "md" => "text/markdown",
            "pdf" => "application/pdf",
            "doc" => "application/msword",
            "docx" => "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
            "xls" => "application/vnd.ms-excel",
            "xlsx" => "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
            _ => "text/plain",
        };

    /// <summary>Gets the <see cref="ImageFormat"/> for the specified MIME type.</summary>
    private static ImageFormat? GetImageFormat(string? mediaType) =>
        mediaType switch
        {
            "image/jpeg" => ImageFormat.Jpeg,
            "image/png" => ImageFormat.Png,
            "image/gif" => ImageFormat.Gif,
            "image/webp" => ImageFormat.Webp,
            _ => null,
        };

    /// <summary>Gets the MIME type for a <see cref="ImageFormat"/>.</summary>
    private static string GetMimeType(ImageFormat? format) =>
        format?.Value switch
        {
            "png" => "image/png",
            "gif" => "image/gif",
            "webp" => "image/webp",
            _ => "image/jpeg",
        };

    /// <summary>Gets the <see cref="VideoFormat"/> for the specified MIME type.</summary>
    private static VideoFormat? GetVideoFormat(string? mediaType) =>
        mediaType switch
        {
            "video/x-flv" => VideoFormat.Flv,
            "video/x-matroska" => VideoFormat.Mkv,
            "video/quicktime" => VideoFormat.Mov,
            "video/mp4" => VideoFormat.Mp4,
            "video/mpeg" => VideoFormat.Mpeg,
            "video/3gpp" => VideoFormat.Three_gp,
            "video/webm" => VideoFormat.Webm,
            "video/x-ms-wmv" => VideoFormat.Wmv,
            _ => null,
        };

    /// <summary>Gets the MIME type for a <see cref="VideoFormat"/>.</summary>
    private static string GetMimeType(VideoFormat? format) =>
        format?.Value switch
        {
            "flv" => "video/x-flv",
            "mkv" => "video/x-matroska",
            "mov" => "video/quicktime",
            "mpeg" or "mpg" => "video/mpeg",
            "three_gp" => "video/3gpp",
            "webm" => "video/webm",
            "wmv" => "video/x-ms-wmv",
            _ => "video/mp4",
        };

    /// <summary>Converts a <see cref="Dictionary{String, Object}"/> to a <see cref="Document"/>.</summary>
    private static Document DictionaryToDocument(IDictionary<string, object?>? arguments)
    {
        Document inputs = new Document(new Dictionary<string, Document>());
        if (arguments is not null)
        {
            foreach (KeyValuePair<string, object?> argument in arguments)
            {
                switch (argument.Value)
                {
                    case bool argumentBool: inputs.Add(argument.Key, argumentBool); break;
                    case int argumentInt32: inputs.Add(argument.Key, argumentInt32); break;
                    case long argumentInt64: inputs.Add(argument.Key, argumentInt64); break;
                    case float argumentSingle: inputs.Add(argument.Key, argumentSingle); break;
                    case double argumentDouble: inputs.Add(argument.Key, argumentDouble); break;
                    case string argumentString: inputs.Add(argument.Key, argumentString); break;
                    case JsonElement json: inputs.Add(argument.Key, ToDocument(json)); break;
                }
            }
        }

        return inputs;
    }

    /// <summary>Converts a <see cref="Document"/> to a <see cref="Dictionary{String, Object}"/>.</summary>
    private static Dictionary<string, object?>? DocumentToDictionary(Document d)
    {
        if (d.IsDictionary())
        {
            return (Dictionary<string, object?>?)
                DocumentDictionaryToNode(d.AsDictionary())
                .Deserialize(BedrockJsonContext.DefaultOptions.GetTypeInfo(typeof(Dictionary<string, object?>)));
        }

        return null;
    }

    /// <summary>Converts a <see cref="Dictionary{String, Document}"/> to a <see cref="JsonNode"/>.</summary>
    private static JsonObject DocumentDictionaryToNode(Dictionary<string, Document> documentDictionary) =>
        new(documentDictionary.Select(entry => new KeyValuePair<string, JsonNode?>(entry.Key, DocumentToNode(entry.Value))));

    /// <summary>Converts a <see cref="Document"/> to a <see cref="JsonNode"/>.</summary>
    private static JsonNode? DocumentToNode(Document value) =>
        value.IsBool() ? value.AsBool() :
        value.IsInt() ? value.AsInt() :
        value.IsLong() ? value.AsLong() :
        value.IsDouble() ? value.AsDouble() :
        value.IsString() ? value.AsString() :
        value.IsList() ? new JsonArray(value.AsList().Select(DocumentToNode).ToArray()) :
        value.IsDictionary() ? DocumentDictionaryToNode(value.AsDictionary()) :
        null;

    /// <summary>Converts a <see cref="JsonElement"/> to a <see cref="Document"/>.</summary>
    private static Document ToDocument(JsonElement json)
    {
        switch (json.ValueKind)
        {
            case JsonValueKind.String:
                return json.GetString();

            case JsonValueKind.Number:
                return json.GetDouble();

            case JsonValueKind.True:
                return true;

            case JsonValueKind.False:
                return false;

            case JsonValueKind.Array:
                var elements = new Document[json.GetArrayLength()];
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = ToDocument(json[i]);
                }
                return elements;

            case JsonValueKind.Object:
                Dictionary<string, Document> props = [];
                foreach (var prop in json.EnumerateObject())
                {
                    props.Add(prop.Name, ToDocument(prop.Value));
                }
                return props;

            case JsonValueKind.Null:
            default:
                return string.Empty;
        }
    }

    /// <summary>Creates an <see cref="ToolConfiguration"/> from the specified options.</summary>
    private static ToolConfiguration? CreateToolConfig(ToolConfiguration? toolConfig, ChatOptions? options)
    {
        if (options?.Tools is { Count: > 0 } tools)
        {
            foreach (AITool tool in tools)
            {
                if (tool is not AIFunctionDeclaration f)
                {
                    continue;
                }

                Document inputs = default;
                List<Document> required = [];

                if (f.JsonSchema.TryGetProperty("properties", out JsonElement properties))
                {
                    foreach (JsonProperty parameter in properties.EnumerateObject())
                    {
                        inputs.Add(parameter.Name, ToDocument(parameter.Value));
                    }
                }

                if (f.JsonSchema.TryGetProperty("required", out JsonElement requiredProperties))
                {
                    foreach (JsonElement requiredProperty in requiredProperties.EnumerateArray())
                    {
                        required.Add(requiredProperty.GetString());
                    }
                }

                Dictionary<string, Document> schemaDictionary = new()
                {
                    ["type"] = new Document("object"),
                };

                if (inputs != default)
                {
                    schemaDictionary["properties"] = inputs;
                }

                if (required.Count > 0)
                {
                    schemaDictionary["required"] = new Document(required);
                }

                toolConfig ??= new();
                toolConfig.Tools ??= [];
                toolConfig.Tools.Add(new()
                {
                    ToolSpec = new ToolSpecification()
                    {
                        Name = f.Name,
                        Description = !string.IsNullOrEmpty(f.Description) ? f.Description : f.Name,
                        InputSchema = new()
                        {
                            Json = new(schemaDictionary)
                        },
                    },
                });
            }
        }

        if (toolConfig?.Tools is { Count: > 0 } && toolConfig.ToolChoice is null)
        {
            switch (options!.ToolMode)
            {
                case RequiredChatToolMode r:
                    toolConfig.ToolChoice = !string.IsNullOrWhiteSpace(r.RequiredFunctionName) ?
                        new ToolChoice() { Tool = new() { Name = r.RequiredFunctionName } } :
                        new ToolChoice() { Any = new() };
                    break;
            }
        }

        return toolConfig;
    }

    /// <summary>Creates an <see cref="InferenceConfiguration"/> from the specified options.</summary>
    private static InferenceConfiguration CreateInferenceConfiguration(InferenceConfiguration config, ChatOptions? options)
    {
        config ??= new();
        
        config.MaxTokens ??= options?.MaxOutputTokens;
        config.Temperature ??= options?.Temperature;
        config.TopP ??= options?.TopP;

        if (options?.StopSequences is { Count: > 0 } stopOptions)
        {
            if (config.StopSequences is null)
            {
                config.StopSequences = stopOptions.ToList();
            }
            else
            {
                config.StopSequences.AddRange(stopOptions);
            }
        }

        return config;
    }

    /// <summary>Creates a <see cref="Document"/> from the specified options to use as the additional model request options.</summary>
    private static Document CreateAdditionalModelRequestFields(Document d, ChatOptions? options)
    {
        if (options is not null)
        {
            if (options.TopK is int topK)
            {
                d.Add("k", topK);
            }

            if (options.FrequencyPenalty is float frequencyPenalty)
            {
                d.Add("frequency_penalty", frequencyPenalty);
            }

            if (options.PresencePenalty is float presencePenalty)
            {
                d.Add("presence_penalty", presencePenalty);
            }

            if (options.Seed is long seed)
            {
                d.Add("seed", seed);
            }

            if (options.AdditionalProperties is { } props)
            {
                foreach (KeyValuePair<string, object?> prop in props)
                {
                    switch (prop.Value)
                    {
                        case bool propBool: d.Add(prop.Key, propBool); break;
                        case int propInt32: d.Add(prop.Key, propInt32); break;
                        case long propInt64: d.Add(prop.Key, propInt64); break;
                        case float propSingle: d.Add(prop.Key, propSingle); break;
                        case double propDouble: d.Add(prop.Key, propDouble); break;
                        case string propString: d.Add(prop.Key, propString); break;
                        case null: d.Add(prop.Key, default); break;
                        case JsonElement json: d.Add(prop.Key, ToDocument(json)); break;
                        default:
                            try
                            {
                                d.Add(prop.Key, ToDocument(JsonSerializer.SerializeToElement(prop.Value, BedrockJsonContext.DefaultOptions.GetTypeInfo(prop.Value.GetType()))));
                            }
                            catch (Exception e)
                            {
                                DefaultLogger.Debug(e, "Unable to serialize ChatOptions.AdditionalProperties[\"{0}\"] of type {1}", prop.Key, prop.Value?.GetType());
                            }
                            break;
                    }
                }
            }
        }

        return d;
    }
}
