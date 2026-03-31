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
using Amazon.BedrockRuntime.Model;
using Microsoft.Extensions.AI;

#pragma warning disable MEAI001 // Type is for evaluation purposes only

namespace Amazon.BedrockRuntime;

/// <summary>Represents an <see cref="IRealtimeClient"/> for Amazon Bedrock Nova Sonic.</summary>
[Experimental("MEAI001")]
public sealed class BedrockNovaRealtimeClient : IRealtimeClient
{
    /// <summary>The default model ID for Nova Sonic.</summary>
    internal const string DefaultNovaSonicModelId = "amazon.nova-2-sonic-v1:0";

    private readonly IAmazonBedrockRuntime _runtime;
    private readonly string _defaultModelId;
    private readonly ChatClientMetadata _metadata;
    private readonly bool _ownsRuntime;

    /// <summary>Initializes a new instance of the <see cref="BedrockNovaRealtimeClient"/> class.</summary>
    /// <param name="runtime">The Amazon Bedrock Runtime client.</param>
    /// <param name="defaultModelId">
    /// The default model ID. If <see langword="null"/>, defaults to <c>amazon.nova-sonic-v1:0</c>.
    /// </param>
    /// <exception cref="ArgumentNullException"><paramref name="runtime"/> is <see langword="null"/>.</exception>
    public BedrockNovaRealtimeClient(IAmazonBedrockRuntime runtime, string? defaultModelId = null)
    {
        _runtime = runtime ?? throw new ArgumentNullException(nameof(runtime));
        _defaultModelId = defaultModelId ?? DefaultNovaSonicModelId;
        _metadata = new(AmazonBedrockRuntimeExtensions.ProviderName, defaultModelId: _defaultModelId);
    }

    /// <summary>Initializes a new instance using AWS access keys and region.</summary>
    /// <param name="accessKeyId">The AWS access key ID.</param>
    /// <param name="secretAccessKey">The AWS secret access key.</param>
    /// <param name="regionName">The AWS region (e.g. "us-east-1").</param>
    /// <param name="defaultModelId">
    /// The default model ID. If <see langword="null"/>, defaults to <c>amazon.nova-sonic-v1:0</c>.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="accessKeyId"/>, <paramref name="secretAccessKey"/>, or <paramref name="regionName"/> is <see langword="null"/> or empty.
    /// </exception>
    public BedrockNovaRealtimeClient(string accessKeyId, string secretAccessKey, string regionName, string? defaultModelId = null)
    {
        if (string.IsNullOrEmpty(accessKeyId)) throw new ArgumentNullException(nameof(accessKeyId));
        if (string.IsNullOrEmpty(secretAccessKey)) throw new ArgumentNullException(nameof(secretAccessKey));
        if (string.IsNullOrEmpty(regionName)) throw new ArgumentNullException(nameof(regionName));

        var credentials = new Amazon.Runtime.BasicAWSCredentials(accessKeyId, secretAccessKey);
        var config = new AmazonBedrockRuntimeConfig
        {
            RegionEndpoint = Amazon.RegionEndpoint.GetBySystemName(regionName),
            Timeout = TimeSpan.FromMinutes(10) // Bidirectional streaming requires a large HTTP timeout
        };
        _runtime = new AmazonBedrockRuntimeClient(credentials, config);
        _defaultModelId = defaultModelId ?? DefaultNovaSonicModelId;
        _metadata = new(AmazonBedrockRuntimeExtensions.ProviderName, defaultModelId: _defaultModelId);
        _ownsRuntime = true;
    }

    /// <inheritdoc />
    public async Task<IRealtimeClientSession> CreateSessionAsync(
        RealtimeSessionOptions? options = null,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        string modelId = options?.Model ?? _defaultModelId;

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
        if (_ownsRuntime && _runtime is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}

#endif
