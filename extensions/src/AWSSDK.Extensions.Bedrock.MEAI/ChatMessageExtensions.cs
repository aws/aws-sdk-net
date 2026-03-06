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

namespace Amazon.BedrockRuntime;

/// <summary>Provides extensions for working with <see cref="ChatMessage"/> instances.</summary>
public static class ChatMessageExtensions
{
	/// <summary>Enables prompt caching for the specified <see cref="ChatMessage"/> instance.</summary>
	/// <param name="message">The chat message to enable caching for.</param>
	/// <param name="cacheTTL">The cache time to live...defaults to 5 minutes.</param>
	/// <returns>The <see cref="ChatMessage"/> instance with caching enabled.</returns>
	/// <remarks>
	/// This method adds a cache point marker to the message's additional properties. Prompt caching
	/// allows Bedrock to cache the prompt tokens for reuse in subsequent requests, reducing costs
	/// and latency. The model must support prompt caching and the message must be within the minimum token threshold for caching.
	/// </remarks>
	public static ChatMessage UsePromptCaching(this ChatMessage message, CacheTTL? cacheTTL = null)
	{
		cacheTTL ??= CacheTTL.FIVE_MINUTES;
		message.AdditionalProperties ??= [];

		message.AdditionalProperties.Add(nameof(ContentBlock.CachePoint), new CachePointBlock { Type = CachePointType.Default, Ttl = cacheTTL });

		return message;
	}
}
