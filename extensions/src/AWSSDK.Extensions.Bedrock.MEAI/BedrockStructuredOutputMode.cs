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

namespace Amazon.BedrockRuntime;

/// <summary>
/// Controls how <see cref="Microsoft.Extensions.AI.ChatOptions.ResponseFormat"/> (structured output)
/// is realized against the Amazon Bedrock Converse API.
/// </summary>
public enum BedrockStructuredOutputMode
{
    /// <summary>
    /// Use Bedrock native structured outputs via the request's <c>outputConfig.textFormat</c> field.
    /// This is the default.
    /// </summary>
    /// <remarks>
    /// Native structured outputs is supported on newer models (for example Anthropic Claude 4.5+ and a
    /// number of open-weight models) and is <b>not</b> supported on older models such as Claude 3.x,
    /// Amazon Titan, Meta Llama, Cohere, or AI21. Because <c>outputConfig</c> is orthogonal to
    /// <c>toolConfig</c>, this mode composes with user-provided tools and is supported for streaming.
    /// For models that do not support native structured outputs, use <see cref="SyntheticTool"/>.
    /// </remarks>
    Native = 0,

    /// <summary>
    /// Use the legacy synthetic forced-tool strategy: a synthetic tool carrying the response schema is
    /// added and forced via <c>toolConfig.toolChoice</c>, and its tool-use output is unwrapped as the
    /// structured result.
    /// </summary>
    /// <remarks>
    /// This mode works on models without native structured-output support, but because it consumes the
    /// single available forced tool it cannot be combined with user-provided
    /// <see cref="Microsoft.Extensions.AI.ChatOptions.Tools"/> and is not supported for streaming.
    /// </remarks>
    SyntheticTool = 1,
}
