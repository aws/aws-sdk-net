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

using Microsoft.Extensions.AI;
using System;

namespace Amazon.BedrockRuntime;

/// <summary>Provides extensions for working with <see cref="IAmazonBedrockRuntime"/> instances.</summary>
public static class AmazonBedrockRuntimeExtensions
{
    /// <summary>Gets an <see cref="IChatClient"/> for the specified <see cref="IAmazonBedrockRuntime"/> instance.</summary>
    /// <param name="runtime">The runtime instance to be represented as an <see cref="IChatClient"/>.</param>
    /// <param name="modelId">
    /// The default model ID to use when no model is specified in a request. If not specified,
    /// a model must be provided in the <see cref="ChatOptions.ModelId"/> passed to <see cref="IChatClient.CompleteAsync"/>
    /// or <see cref="IChatClient.CompleteStreamingAsync"/>.
    /// </param>
    /// <returns>A <see cref="IChatClient"/> instance representing the <see cref="IAmazonBedrockRuntime"/> instance.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="runtime"/> is <see langword="null"/>.</exception>
    public static IChatClient AsChatClient(this IAmazonBedrockRuntime runtime, string? modelId = null) =>
        runtime is not null ? new BedrockChatClient(runtime, modelId) :
        throw new ArgumentNullException(nameof(runtime));

    /// <summary>Gets an <see cref="IChatClient"/> for the specified <see cref="IAmazonBedrockRuntime"/> instance.</summary>
    /// <param name="runtime">The runtime instance to be represented as an <see cref="IChatClient"/>.</param>
    /// <param name="modelId">
    /// The default model ID to use when no model is specified in a request. If not specified,
    /// a model must be provided in the <see cref="ChatOptions.ModelId"/> passed to <see cref="IChatClient.CompleteAsync"/>
    /// or <see cref="IChatClient.CompleteStreamingAsync"/>.
    /// </param>
    /// <param name="dimensions">
    /// The default number of dimensions to request be generated. This will be overridden by a <see cref="EmbeddingGenerationOptions.Dimensions"/>
    /// if that is specified to a request. If neither is specified, the default for the model will be used.
    /// </param>
    /// <returns>A <see cref="IChatClient"/> instance representing the <see cref="IAmazonBedrockRuntime"/> instance.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="runtime"/> is <see langword="null"/>.</exception>
    public static IEmbeddingGenerator<string, Embedding<float>> AsEmbeddingGenerator(
        this IAmazonBedrockRuntime runtime, string? modelId = null, int? dimensions = null) =>
        runtime is not null ? new BedrockEmbeddingGenerator(runtime, modelId, dimensions) :
        throw new ArgumentNullException(nameof(runtime));
}
