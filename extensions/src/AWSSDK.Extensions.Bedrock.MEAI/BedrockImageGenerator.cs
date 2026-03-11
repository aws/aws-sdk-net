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
using Microsoft.Extensions.AI;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.BedrockRuntime;

[Experimental("MEAI001")]
internal sealed partial class BedrockImageGenerator : IImageGenerator
{
    /// <summary>The wrapped <see cref="IAmazonBedrockRuntime"/> instance.</summary>
    private readonly IAmazonBedrockRuntime _runtime;
    /// <summary>Default model ID to use when no model is specified in the request.</summary>
    private readonly string? _modelId;
    /// <summary>Metadata describing the image generator.</summary>
    private readonly ImageGeneratorMetadata _metadata;

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockImageGenerator"/> class.
    /// </summary>
    /// <param name="runtime">The <see cref="IAmazonBedrockRuntime"/> instance to wrap.</param>
    /// <param name="defaultModelId">Model ID to use as the default when no model ID is specified in a request.</param>
    public BedrockImageGenerator(IAmazonBedrockRuntime runtime, string? defaultModelId)
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

    /// <inheritdoc />
    public object? GetService(Type serviceType, object? serviceKey)
    {
        if (serviceType is null)
        {
            throw new ArgumentNullException(nameof(serviceType));
        }

        return
            serviceKey is not null ? null :
            serviceType == typeof(ImageGeneratorMetadata) ? _metadata :
            serviceType.IsInstanceOfType(_runtime) ? _runtime :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    public async Task<ImageGenerationResponse> GenerateAsync(
        ImageGenerationRequest request, ImageGenerationOptions? options = null, CancellationToken cancellationToken = default)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        int numImages = options?.Count ?? 1;
        if (numImages < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(options), "The number of images must be at least 1.");
        }

        InvokeModelRequest invokeRequest = options?.RawRepresentationFactory?.Invoke(this) as InvokeModelRequest ?? new();
        invokeRequest.ModelId ??= options?.ModelId ?? _modelId;
        invokeRequest.Accept ??= "application/json";
        invokeRequest.ContentType ??= "application/json";
        if (invokeRequest.Body is null)
        {
            JsonObject body = new();

            // Each model has its own way of specifying the prompt and image generation parameters, unfortunately.
            // The following logic handles the most common cases today, but may need to be extended for
            // future models.

            if (invokeRequest.ModelId?.IndexOf("stability", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                // Stability AI models
                // https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters-stability-diffusion.html

                if (invokeRequest.ModelId?.IndexOf("stable-diffusion", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    JsonArray textPrompts = new();
                    for (int i = 0; i < numImages; i++)
                    {
                        textPrompts.Add((JsonNode)new JsonObject { ["text"] = request.Prompt ?? "" });
                    }
                    body["text_prompts"] = textPrompts;

                    if (options?.ImageSize?.Width is int width && options.ImageSize?.Height is int height)
                    {
                        body["width"] = width;
                        body["height"] = height;
                    }
                }
                else
                {
                    body["prompt"] = request.Prompt ?? "";
                }
            }
            else
            {
                // Amazon models (e.g. Titan, Nova Canvas)
                // https://docs.aws.amazon.com/bedrock/latest/userguide/model-parameters-titan.html

                JsonObject textToImageParams = new() { ["text"] = request.Prompt ?? "" };
                if (request.OriginalImages?.OfType<DataContent>().Where(d => d.HasTopLevelMediaType("image")).FirstOrDefault() is DataContent image)
                {
                    textToImageParams["conditionImage"] = image.Base64Data.ToString();
                }

                JsonObject imageGenerationConfig = new()
                {
                    ["seed"] =
#if NET
                        Random.Shared.Next(),
#else
                        new Random().Next(),
#endif
                };

                if (options?.ImageSize?.Width is int width && options.ImageSize?.Height is int height)
                {
                    imageGenerationConfig["width"] = width;
                    imageGenerationConfig["height"] = height;
                }

                if (numImages > 1)
                {
                    imageGenerationConfig["numberOfImages"] = Math.Min(numImages, 5);
                }

                body["taskType"] = "TEXT_IMAGE";
                body["textToImageParams"] = textToImageParams;
                body["imageGenerationConfig"] = imageGenerationConfig;
            }

            invokeRequest.Body = new MemoryStream(JsonSerializer.SerializeToUtf8Bytes(body, BedrockJsonContext.Default.JsonNode));
        }

        InvokeModelResponse rawResponse = await _runtime.InvokeModelAsync(invokeRequest, cancellationToken).ConfigureAwait(false);

        ImageGenerationResponse result = new() { RawRepresentation = rawResponse };

        using JsonDocument doc = JsonDocument.Parse(rawResponse.Body);
        JsonElement root = doc.RootElement;

        const string DefaultGeneratedImageMimeType = "image/png";

        if (root.TryGetProperty("artifacts", out JsonElement artifactElement) && artifactElement.ValueKind == JsonValueKind.Array)
        {
            foreach (var element in artifactElement.EnumerateArray())
            {
                if (element.TryGetProperty("base64", out JsonElement base64Element) &&
                    base64Element.ValueKind == JsonValueKind.String)
                {
                    result.Contents.Add(new DataContent(Convert.FromBase64String(base64Element.GetString()!), DefaultGeneratedImageMimeType));
                }
            }
        }
        else if (root.TryGetProperty("images", out JsonElement imagesElement) && imagesElement.ValueKind == JsonValueKind.Array)
        {
            foreach (var image in imagesElement.EnumerateArray())
            {
                if (image.ValueKind == JsonValueKind.String)
                {
                    result.Contents.Add(new DataContent(Convert.FromBase64String(image.GetString()!), DefaultGeneratedImageMimeType));
                }
            }
        }

        if (result.Contents is not { Count: > 0 })
        {
            throw new InvalidOperationException("Image generation did not produce any images.");
        }

        return result;
    }
}