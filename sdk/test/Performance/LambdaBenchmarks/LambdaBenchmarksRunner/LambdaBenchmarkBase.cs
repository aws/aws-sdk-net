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

using Amazon.Lambda;
using Amazon.Lambda.Model;
using BenchmarkDotNet.Attributes;

namespace LambdaBenchmarksRunner;

public class LambdaBenchmarkBase
{
    private int _iterationCount { get; set; } = 0;
    protected AmazonLambdaClient lambdaClient { get; set; } = new AmazonLambdaClient();
    protected string CurrentFunctionName { get; set; }
    protected string CurrentFunctionHandler { get; set; }

    [Params(256, 512, 1024)]
    public virtual int MemorySize { get; set; }

    [Params("dotnet6")]
    public virtual string LambdaRuntime { get; set; }

    [Params("x86_64", "arm64")]
    public virtual string Architecture { get; set; }

    [Params(true, false)]
    public virtual bool ForceColdStart { get; set; }

    [IterationSetup]
    public void IterationSetup()
    {
        if (!ForceColdStart || string.IsNullOrEmpty(CurrentFunctionName) || string.IsNullOrEmpty(CurrentFunctionHandler)) return;

        var newTimeout = 30 + _iterationCount; // Use _iterationCount to make sure the timeout changes with every iteration

        // Change the timeout of the lambda function to force cold start
        // Cannot use async as it is not supported by IterationSetup
        LambdaUtilities.UpdateFunctionTimeout(lambdaClient, CurrentFunctionName, newTimeout).Wait();

        _iterationCount++;
    }

    public async Task InitializeLambdaFunction(string functionName, string functionHandler)
    {
        _iterationCount = 0;
        CurrentFunctionHandler = functionHandler;
        CurrentFunctionName = functionName;
        await LambdaUtilities.DeployFunction(lambdaClient, CurrentFunctionName, CurrentFunctionHandler, MemorySize, Architecture, LambdaRuntime);
    }

    public async Task DeleteCurrentLambdaFunction()
    {
        await lambdaClient.DeleteFunctionAsync(CurrentFunctionName);

        CurrentFunctionName = null;
        CurrentFunctionHandler = null;
    }
}
