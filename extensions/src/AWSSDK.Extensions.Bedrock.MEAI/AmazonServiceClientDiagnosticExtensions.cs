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
using System.Reflection;
using Amazon.BedrockRuntime;
using Amazon.Runtime.Internal;

namespace Amazon.Runtime;

/// <summary>
/// Extension methods to enable AI-powered error diagnostics on AWS SDK service clients.
/// </summary>
public static class AmazonServiceClientDiagnosticExtensions
{
    /// <summary>
    /// Enables AI-powered diagnostics on this service client. When an AWS service call fails
    /// with an <see cref="AmazonServiceException"/>, the SDK will call Amazon Bedrock to generate
    /// actionable diagnostic advice and attach it to the exception's Data dictionary under
    /// <see cref="DiagnosticAdvisorHandler.DiagnosticAdviceKey"/>.
    /// </summary>
    /// <param name="client">The AWS service client to enable diagnostics on.</param>
    /// <param name="bedrockRuntime">The Bedrock Runtime client for generating diagnoses.</param>
    /// <param name="modelId">Optional model ID override. Defaults to Claude Haiku.</param>
    /// <returns>The same client instance for fluent chaining.</returns>
    public static AmazonServiceClient EnableAIDiagnostics(
        this AmazonServiceClient client,
        IAmazonBedrockRuntime bedrockRuntime,
        string? modelId = null)
    {
        if (client == null) throw new ArgumentNullException(nameof(client));
        if (bedrockRuntime == null) throw new ArgumentNullException(nameof(bedrockRuntime));

        var handler = modelId != null
            ? new DiagnosticAdvisorHandler(bedrockRuntime, modelId)
            : new DiagnosticAdvisorHandler(bedrockRuntime);

        var pipeline = (RuntimePipeline)typeof(AmazonServiceClient)
            .GetProperty("RuntimePipeline", BindingFlags.NonPublic | BindingFlags.Instance)!
            .GetValue(client)!;

        pipeline.AddHandlerBefore<ErrorHandler>(handler);

        return client;
    }
}
