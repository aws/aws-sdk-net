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
using System.Threading.Tasks;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime;

/// <summary>
/// A pipeline handler that intercepts <see cref="AmazonServiceException"/>, calls Amazon Bedrock
/// to generate diagnostic advice, and attaches the advice to the exception's Data dictionary.
/// </summary>
public class DiagnosticAdvisorHandler : PipelineHandler
{
    /// <summary>
    /// Key used to store diagnostic advice in the exception's Data dictionary.
    /// </summary>
    public const string DiagnosticAdviceKey = "AWS.AI.DiagnosticAdvice";

    private readonly IAmazonBedrockRuntime _bedrockRuntime;
    private readonly string _modelId;

    /// <summary>
    /// Creates a new DiagnosticAdvisorHandler.
    /// </summary>
    /// <param name="bedrockRuntime">The Bedrock Runtime client for generating diagnoses.</param>
    /// <param name="modelId">The model ID to use. Defaults to Claude Haiku.</param>
    public DiagnosticAdvisorHandler(IAmazonBedrockRuntime bedrockRuntime, string modelId = "anthropic.claude-3-haiku-20240307-v1:0")
    {
        _bedrockRuntime = bedrockRuntime ?? throw new ArgumentNullException(nameof(bedrockRuntime));
        _modelId = modelId ?? throw new ArgumentNullException(nameof(modelId));
    }

    /// <inheritdoc/>
    public override void InvokeSync(IExecutionContext executionContext)
    {
        try
        {
            base.InvokeSync(executionContext);
        }
        catch (AmazonServiceException ex)
        {
            try
            {
                var advice = GetDiagnosticAdviceAsync(ex, executionContext).ConfigureAwait(false).GetAwaiter().GetResult();
                ex.Data[DiagnosticAdviceKey] = advice;
            }
            catch { /* Never mask the original exception */ }
            throw;
        }
    }

    /// <inheritdoc/>
    public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
    {
        try
        {
            return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        }
        catch (AmazonServiceException ex)
        {
            try
            {
                var advice = await GetDiagnosticAdviceAsync(ex, executionContext).ConfigureAwait(false);
                ex.Data[DiagnosticAdviceKey] = advice;
            }
            catch { /* Never mask the original exception */ }
            throw;
        }
    }

    internal async Task<string> GetDiagnosticAdviceAsync(AmazonServiceException ex, IExecutionContext executionContext)
    {
        var serviceName = executionContext.RequestContext.Request?.ServiceName ?? "Unknown";
        var operationName = executionContext.RequestContext.RequestName ?? "Unknown";

        var prompt = $@"An AWS SDK for .NET call failed:
- Service: {serviceName}
- Operation: {operationName}
- Error Code: {ex.ErrorCode}
- Status Code: {(int)ex.StatusCode} ({ex.StatusCode})
- Message: {ex.Message}
- Request ID: {ex.RequestId}

What is the most likely cause and how should the developer fix it?";

        var request = new ConverseRequest
        {
            ModelId = _modelId,
            Messages = new List<Message>
            {
                new Message
                {
                    Role = ConversationRole.User,
                    Content = new List<ContentBlock> { new ContentBlock { Text = prompt } }
                }
            },
            System = new List<SystemContentBlock>
            {
                new SystemContentBlock
                {
                    Text = "You are an AWS SDK diagnostics expert. Provide concise, actionable advice to resolve AWS SDK errors. Focus on the most likely root cause and specific steps to fix it. Keep responses under 200 words."
                }
            }
        };

        var response = await _bedrockRuntime.ConverseAsync(request).ConfigureAwait(false);

        return response.Output?.Message?.Content?.Count > 0
            ? response.Output.Message.Content[0].Text ?? string.Empty
            : string.Empty;
    }
}
