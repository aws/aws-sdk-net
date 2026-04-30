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

using System.Text;
using Amazon;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

namespace LambdaBenchmarksRunner;

/// <summary>
/// BenchmarkDotNet benchmarks for Lambda cold start times.
/// 
/// Measures the total duration (INIT + INVOKE) for Lambda functions that each
/// send a single request: STS GetCallerIdentity, S3 ListBuckets, EC2 DescribeRegions.
/// The presence of Init Duration in the REPORT line confirms the invocation was a
/// cold start, but we record the total Duration as the benchmark metric because the
/// INIT phase alone does not capture the SDK's first-call overhead (HTTP stack setup,
/// first-time JIT, credential resolution, etc.).
/// 
/// Prerequisites: Lambda functions must be pre-deployed using Deploy-LambdaColdStart.ps1.
/// 
/// Configuration:
///   - 512MB memory, .NET 8.0 runtime
///   - x86_64 and arm64 architectures (via [Params])
///   - Forces cold start each iteration by updating environment variable
///   - Reads total duration from LogResult (LogType=Tail), confirms cold start via Init Duration
///   - Minimum 100 iterations (network operation)
///
/// Region resolution (in order):
///   1. BENCHMARK_REGION environment variable (e.g. BENCHMARK_REGION=us-west-2)
///   2. SDK default region resolution (AWS_REGION, config file, etc.)
///   3. Falls back to us-east-1
///
/// Usage:
///   dotnet run -c Release -- --filter *ColdStart*
///   BENCHMARK_REGION=us-west-2 dotnet run -c Release -- --filter *ColdStart*
/// </summary>
/// <summary>
/// BenchmarkDotNet config for Lambda cold start benchmarks.
/// Uses InProcessEmitToolchain to avoid assembly resolution issues with v4 SDK.
/// </summary>
public class ColdStartBenchmarkConfig : ManualConfig
{
    public ColdStartBenchmarkConfig()
    {
        // Use InProcessEmitToolchain with extended timeout (2 hours) because each cold start
        // iteration takes ~30-60 seconds (update config + wait + invoke + parse logs).
        // 100 iterations × 3 functions × 2 architectures = ~600 iterations total.
        var toolchain = new InProcessEmitToolchain(TimeSpan.FromHours(2), logOutput: true);
        AddJob(Job.Default
            .WithToolchain(toolchain)
            .WithStrategy(RunStrategy.Monitoring)
            .WithWarmupCount(5)
            .WithIterationCount(100)
            .WithInvocationCount(1)
            .WithUnrollFactor(1));
    }
}

[Config(typeof(ColdStartBenchmarkConfig))]
[MemoryDiagnoser]
public class ColdStartBenchmarksRunner
{
    private AmazonLambdaClient _lambdaClient = null!;
    private int _iterationCount;

    [Params("x64", "arm64")]
    public string Architecture { get; set; } = null!;

    /// <summary>Prefix for Lambda function names. Must match Deploy-LambdaColdStart.ps1.</summary>
    [Params("dotnet-perf")]
    public string FunctionPrefix { get; set; } = null!;

    private string StsFunctionName => $"{FunctionPrefix}-sts-coldstart-{Architecture}";
    private string S3FunctionName => $"{FunctionPrefix}-s3-coldstart-{Architecture}";
    private string Ec2FunctionName => $"{FunctionPrefix}-ec2-coldstart-{Architecture}";

    [GlobalSetup]
    public void GlobalSetup()
    {
        var regionEnv = System.Environment.GetEnvironmentVariable("BENCHMARK_REGION");
        var region = !string.IsNullOrEmpty(regionEnv)
            ? RegionEndpoint.GetBySystemName(regionEnv)
            : RegionEndpoint.USEast1;
        _lambdaClient = new AmazonLambdaClient(region);
        _iterationCount = 0;
    }

    [IterationSetup]
    public void IterationSetup()
    {
        // No-op here — cold start forcing is done inside each benchmark method
        // because we have 3 separate functions and [IterationSetup] runs once per iteration
        _iterationCount++;
    }

    [GlobalCleanup]
    public void GlobalCleanup()
    {
        _lambdaClient?.Dispose();
    }

    [Benchmark]
    public async Task<double> STS_GetCallerIdentity_ColdStart()
    {
        return await ForceColdStartAndMeasureTotalDuration(StsFunctionName);
    }

    [Benchmark]
    public async Task<double> S3_ListBuckets_ColdStart()
    {
        return await ForceColdStartAndMeasureTotalDuration(S3FunctionName);
    }

    [Benchmark]
    public async Task<double> EC2_DescribeRegions_ColdStart()
    {
        return await ForceColdStartAndMeasureTotalDuration(Ec2FunctionName);
    }

    /// <summary>
    /// Forces a cold start by updating the function's environment variable,
    /// waits for the update, invokes the function with LogType=Tail,
    /// and extracts the total Duration from the log result.
    /// The presence of Init Duration confirms this was a cold start.
    /// Returns the total duration in milliseconds (INIT + INVOKE).
    /// </summary>
    private async Task<double> ForceColdStartAndMeasureTotalDuration(string functionName)
    {
        // Force cold start by updating environment variable
        var randomValue = Guid.NewGuid().ToString();
        await _lambdaClient.UpdateFunctionConfigurationAsync(new UpdateFunctionConfigurationRequest
        {
            FunctionName = functionName,
            Environment = new Amazon.Lambda.Model.Environment
            {
                Variables = new Dictionary<string, string>
                {
                    ["BENCHMARK_ITERATION"] = randomValue
                }
            }
        });

        // Wait for function to be updated
        await WaitForFunctionUpdated(functionName);

        // Invoke with Tail to get logs containing Duration and Init Duration
        const int maxRetries = 3;
        for (int retry = 0; retry < maxRetries; retry++)
        {
            var response = await _lambdaClient.InvokeAsync(new InvokeRequest
            {
                FunctionName = functionName,
                LogType = LogType.Tail,
                Payload = "{}"
            });

            if (!string.IsNullOrEmpty(response.LogResult))
            {
                var logText = Encoding.UTF8.GetString(Convert.FromBase64String(response.LogResult));

                // Confirm this was a cold start by checking for Init Duration
                var initMatch = System.Text.RegularExpressions.Regex.Match(logText, @"Init Duration:\s+([\d.]+)\s+ms");
                if (initMatch.Success)
                {
                    // Extract the total Duration (our benchmark metric)
                    var durationMatch = System.Text.RegularExpressions.Regex.Match(logText, @"REPORT.*?Duration:\s+([\d.]+)\s+ms");
                    if (durationMatch.Success)
                    {
                        return double.Parse(durationMatch.Groups[1].Value);
                    }
                }
            }

            // Retry with new env var if no init duration found (warm start)
            await Task.Delay(1000);
            randomValue = Guid.NewGuid().ToString();
            await _lambdaClient.UpdateFunctionConfigurationAsync(new UpdateFunctionConfigurationRequest
            {
                FunctionName = functionName,
                Environment = new Amazon.Lambda.Model.Environment
                {
                    Variables = new Dictionary<string, string>
                    {
                        ["BENCHMARK_ITERATION"] = randomValue
                    }
                }
            });
            await WaitForFunctionUpdated(functionName);
        }

        throw new Exception($"Could not get cold start Duration for {functionName} after {maxRetries} retries");
    }

    private async Task WaitForFunctionUpdated(string functionName)
    {
        const int pollIntervalMs = 2000;
        const int maxWaitMs = 60000;
        var deadline = DateTime.UtcNow.AddMilliseconds(maxWaitMs);

        while (DateTime.UtcNow < deadline)
        {
            var config = await _lambdaClient.GetFunctionConfigurationAsync(new GetFunctionConfigurationRequest
            {
                FunctionName = functionName
            });

            if (config.LastUpdateStatus != LastUpdateStatus.InProgress && config.State != State.Pending)
                return;

            await Task.Delay(pollIntervalMs);
        }

        throw new Exception($"Timeout waiting for {functionName} to be updated");
    }
}
