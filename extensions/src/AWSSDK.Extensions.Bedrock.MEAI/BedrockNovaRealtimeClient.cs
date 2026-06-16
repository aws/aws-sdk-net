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
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.AI;

#pragma warning disable MEAI001 // Type is for evaluation purposes only

namespace Amazon.BedrockRuntime;

/// <summary>Represents an <see cref="IRealtimeClient"/> for Amazon Bedrock Nova Sonic.</summary>
[Experimental("MEAI001")]
public sealed class BedrockNovaRealtimeClient : IRealtimeClient
{
    private readonly IAmazonBedrockRuntime _runtime;
    private readonly string? _defaultModelId;
    private readonly ChatClientMetadata _metadata;

    /// <summary>Initializes a new instance of the <see cref="BedrockNovaRealtimeClient"/> class.</summary>
    /// <param name="runtime">The Amazon Bedrock Runtime client.</param>
    /// <param name="defaultModelId">
    /// The default model ID. If <see langword="null"/>, a model must be provided in
    /// the <see cref="RealtimeSessionOptions.Model"/> passed to <see cref="CreateSessionAsync"/>.
    /// </param>
    /// <exception cref="ArgumentNullException"><paramref name="runtime"/> is <see langword="null"/>.</exception>
    public BedrockNovaRealtimeClient(IAmazonBedrockRuntime runtime, string? defaultModelId = null)
    {
        _runtime = runtime ?? throw new ArgumentNullException(nameof(runtime));
        _defaultModelId = defaultModelId;
        _metadata = new(AmazonBedrockRuntimeExtensions.ProviderName, defaultModelId: _defaultModelId);
    }

    /// <inheritdoc />
    public async Task<IRealtimeClientSession> CreateSessionAsync(
        RealtimeSessionOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        string modelId = options?.Model ?? _defaultModelId
            ?? throw new InvalidOperationException("No model ID was provided. Set a default model ID via the constructor or specify one in RealtimeSessionOptions.Model.");

        var session = new BedrockNovaRealtimeSession(_runtime, modelId);
        try
        {
            await session.ConnectAsync(options, cancellationToken).ConfigureAwait(false);
            return session;
        }
        catch
        {
            await session.DisposeAsync().ConfigureAwait(false);
            throw;
        }
    }

    /// <inheritdoc />
    object? IRealtimeClient.GetService(Type serviceType, object? serviceKey)
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
    public void Dispose()
    {
    }
}

#endif
