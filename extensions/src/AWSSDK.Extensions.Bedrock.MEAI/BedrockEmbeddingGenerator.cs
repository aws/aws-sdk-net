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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.BedrockRuntime;

internal sealed partial class BedrockEmbeddingGenerator : IEmbeddingGenerator<string, Embedding<float>>
{
    /// <summary>The wrapped <see cref="IAmazonBedrockRuntime"/> instance.</summary>
    private readonly IAmazonBedrockRuntime _runtime;
    /// <summary>Default model ID to use when no model is specified in the request.</summary>
    private readonly string? _modelId;
    /// <summary>Default number of dimensions to use when no number of dimensions is specified in the request.</summary>
    private readonly int? _dimensions;
    /// <summary>Metadata describing the embedding generator.</summary>
    private readonly EmbeddingGeneratorMetadata _metadata;

    /// <summary>
    /// Initializes a new instance of the <see cref="BedrockEmbeddingGenerator"/> class.
    /// </summary>
    /// <param name="runtime">The <see cref="IAmazonBedrockRuntime"/> instance to wrap.</param>
    /// <param name="defaultModelId">Model ID to use as the default when no model ID is specified in a request.</param>
    /// <param name="defaultModelDimensions">Number of dimensions to use when no number of dimensions is specified in a request.</param>
    public BedrockEmbeddingGenerator(IAmazonBedrockRuntime runtime, string? defaultModelId, int? defaultModelDimensions)
    {
        Debug.Assert(runtime is not null);

        _runtime = runtime!;
        _modelId = defaultModelId;
        _dimensions = defaultModelDimensions;

        _metadata = new(AmazonBedrockRuntimeExtensions.ProviderName, defaultModelId: defaultModelId, defaultModelDimensions: defaultModelDimensions);
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
            serviceType == typeof(EmbeddingGeneratorMetadata) ? _metadata :
            serviceType.IsInstanceOfType(_runtime) ? _runtime :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    /// <inheritdoc />
    public async Task<GeneratedEmbeddings<Embedding<float>>> GenerateAsync(
        IEnumerable<string> values, EmbeddingGenerationOptions? options = null, CancellationToken cancellationToken = default)
    {
        if (values is null)
        {
            throw new ArgumentNullException(nameof(values));
        }

        GeneratedEmbeddings<Embedding<float>> embeddings = [];
        int? totaltokens = null;

        foreach (string value in values)
        {
            InvokeModelRequest request = options?.RawRepresentationFactory?.Invoke(this) as InvokeModelRequest ?? new();
            request.ModelId ??= options?.ModelId ?? _modelId;
            request.Accept ??= "application/json";
            request.ContentType ??= "application/json";
            request.Body ??= new MemoryStream(JsonSerializer.SerializeToUtf8Bytes(new()
            {
                InputText = value,
                Dimensions = options?.Dimensions ?? _dimensions,
            }, BedrockJsonContext.Default.EmbeddingRequest));

            var response = await _runtime.InvokeModelAsync(request, cancellationToken).ConfigureAwait(false);

            var er = JsonSerializer.Deserialize(response.Body, BedrockJsonContext.Default.EmbeddingResponse);
            if (er?.Embedding is not null)
            {
                embeddings.Add(new(er.Embedding));

                if (er.InputTextTokenCount is int inputTokens)
                {
                    totaltokens ??= 0;
                    totaltokens += inputTokens;
                }
            }
        }

        if (totaltokens is not null)
        {
            embeddings.Usage = new() 
            {
                InputTokenCount = totaltokens.Value,
                TotalTokenCount = totaltokens.Value,
            };
        }

        return embeddings;
    }
}