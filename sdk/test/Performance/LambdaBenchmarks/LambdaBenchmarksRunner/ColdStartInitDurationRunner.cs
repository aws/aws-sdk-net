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
using System.Text.RegularExpressions;
using Amazon;
using Amazon.Lambda;
using Amazon.Lambda.Model;

namespace LambdaBenchmarksRunner;

/// <summary>
/// Custom runner for Lambda cold start benchmarks that reports the total Duration
/// (INIT + INVOKE) from Lambda's LogResult for cold start invocations.
///
/// The INIT Duration confirms a cold start occurred, but it only covers the Lambda
/// initialization phase (runtime bootstrap, assembly loading). It does not include
/// the actual SDK call that happens during the first INVOKE (HTTP stack setup,
/// first-time JIT of service client code, etc.). Therefore, we record the total
/// Duration from the REPORT line as the cold start benchmark metric, while using
/// the presence of Init Duration to confirm the invocation was indeed a cold start.
///
/// Usage:
///   dotnet run -c Release -- coldstart-initduration [--iterations 100] [--region us-east-1] [--prefix dotnet-perf] [--mode-suffix -r2r]
///
/// Mode suffixes:
///   (none)  = Standard compilation (default)
///   -r2r    = ReadyToRun pre-compilation
///   -aot    = NativeAOT ahead-of-time compilation
/// </summary>
public static class ColdStartInitDurationRunner
{
    public static async Task RunAsync(string[] args)
    {
        int iterations = 100;
        string region = "us-east-1";
        string prefix = "dotnet-perf";
        string modeSuffix = ""; // "", "-r2r", or "-aot"

        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "--iterations" when i + 1 < args.Length: iterations = int.Parse(args[++i]); break;
                case "--region" when i + 1 < args.Length: region = args[++i]; break;
                case "--prefix" when i + 1 < args.Length: prefix = args[++i]; break;
                case "--mode-suffix" when i + 1 < args.Length: modeSuffix = args[++i]; break;
            }
        }

        string modeLabel = modeSuffix switch
        {
            "-r2r" => "ReadyToRun",
            "-aot" => "NativeAOT",
            _ => "Standard"
        };

        var functions = new[]
        {
            (Name: $"{prefix}-sts-coldstart{modeSuffix}-x64", Service: "STS", Arch: "x86_64"),
            (Name: $"{prefix}-sts-coldstart{modeSuffix}-arm64", Service: "STS", Arch: "arm64"),
            (Name: $"{prefix}-s3-coldstart{modeSuffix}-x64", Service: "S3", Arch: "x86_64"),
            (Name: $"{prefix}-s3-coldstart{modeSuffix}-arm64", Service: "S3", Arch: "arm64"),
            (Name: $"{prefix}-ec2-coldstart{modeSuffix}-x64", Service: "EC2", Arch: "x86_64"),
            (Name: $"{prefix}-ec2-coldstart{modeSuffix}-arm64", Service: "EC2", Arch: "arm64"),
        };

        var regionEndpoint = RegionEndpoint.GetBySystemName(region);

        Console.WriteLine("========================================");
        Console.WriteLine($"Lambda Cold Start Total Duration Benchmark ({modeLabel})");
        Console.WriteLine("========================================");
        Console.WriteLine($"  Region:     {region}");
        Console.WriteLine($"  Iterations: {iterations}");
        Console.WriteLine($"  Prefix:     {prefix}");
        Console.WriteLine($"  Mode:       {modeLabel} (suffix: '{modeSuffix}')");
        Console.WriteLine($"  Metric:     Total Duration (INIT + INVOKE) for confirmed cold starts");
        Console.WriteLine();

        var allResults = new List<(string Function, string Service, string Arch, List<double> TotalDurations, List<double> InitDurations, List<int> MemoryUsedMBs)>();

        foreach (var func in functions)
        {
            // Create a fresh Lambda client per function to avoid signature expiration
            // on long-running benchmarks (each function takes ~8-10 minutes for 100 iterations)
            using var lambdaClient = new AmazonLambdaClient(regionEndpoint);

            Console.WriteLine($"--- {func.Name} ({func.Service} / {func.Arch}) ---");
            var totalDurations = new List<double>();
            var initDurations = new List<double>();
            var memoryUsedMBs = new List<int>();

            for (int iter = 1; iter <= iterations; iter++)
            {
                var result = await ForceColdStartAndGetMetrics(lambdaClient, func.Name);
                if (result.TotalDuration.HasValue)
                {
                    totalDurations.Add(result.TotalDuration.Value);
                    if (result.InitDuration.HasValue)
                        initDurations.Add(result.InitDuration.Value);
                    if (result.MaxMemoryUsedMB.HasValue)
                        memoryUsedMBs.Add(result.MaxMemoryUsedMB.Value);
                    if (iter % 10 == 0)
                        Console.WriteLine($"  Iteration {iter}: Total Duration = {result.TotalDuration.Value:F2} ms (Init = {result.InitDuration?.ToString("F2") ?? "N/A"} ms), Max Memory = {result.MaxMemoryUsedMB?.ToString() ?? "N/A"} MB");
                }
                else
                {
                    Console.WriteLine($"  Iteration {iter}: WARNING - no cold start detected (no Init Duration found)");
                }
            }

            if (totalDurations.Count > 0)
            {
                var totalStats = CalculateStats(totalDurations);
                var initStats = initDurations.Count > 0 ? CalculateStats(initDurations) : default;
                double avgMemMB = memoryUsedMBs.Count > 0 ? memoryUsedMBs.Average() : 0;
                Console.WriteLine($"  Total Duration: n={totalStats.Count}, mean={totalStats.Mean:F2}ms, p50={totalStats.P50:F2}ms, p90={totalStats.P90:F2}ms, p99={totalStats.P99:F2}ms, stddev={totalStats.StdDev:F2}ms");
                if (initDurations.Count > 0)
                    Console.WriteLine($"  Init Duration:  n={initStats.Count}, mean={initStats.Mean:F2}ms (for reference only)");
                Console.WriteLine($"  Avg Memory: {avgMemMB:F0}MB");
                allResults.Add((func.Name, func.Service, func.Arch, totalDurations, initDurations, memoryUsedMBs));
            }
            Console.WriteLine();
        }

        // Summary table
        Console.WriteLine("========================================");
        Console.WriteLine("SUMMARY — Total Duration (ms) for confirmed cold starts + Memory (MB)");
        Console.WriteLine("========================================");
        Console.WriteLine($"{"Function",-40} {"Arch",-8} {"Count",-6} {"Mean",-10} {"P50",-10} {"P90",-10} {"P99",-10} {"StdDev",-10} {"AvgMem",-10}");
        Console.WriteLine($"{"--------",-40} {"----",-8} {"-----",-6} {"----",-10} {"---",-10} {"---",-10} {"---",-10} {"------",-10} {"------",-10}");

        foreach (var (function, service, arch, totalDurations, initDurations, memoryMBs) in allResults)
        {
            var s = CalculateStats(totalDurations);
            double avgMem = memoryMBs.Count > 0 ? memoryMBs.Average() : 0;
            Console.WriteLine($"{service,-40} {arch,-8} {s.Count,-6} {s.Mean,-10:F2} {s.P50,-10:F2} {s.P90,-10:F2} {s.P99,-10:F2} {s.StdDev,-10:F2} {avgMem,-10:F0}");
        }

        // CSV output
        Console.WriteLine();
        Console.WriteLine("CSV:");
        Console.WriteLine("\"Function\",\"Service\",\"Architecture\",\"Count\",\"Mean_ms\",\"P50_ms\",\"P90_ms\",\"P99_ms\",\"StdDev_ms\",\"AvgMemoryMB\",\"MeanInitDuration_ms\"");
        foreach (var (function, service, arch, totalDurations, initDurations, memoryMBs) in allResults)
        {
            var s = CalculateStats(totalDurations);
            double avgMem = memoryMBs.Count > 0 ? memoryMBs.Average() : 0;
            double meanInit = initDurations.Count > 0 ? initDurations.Average() : 0;
            Console.WriteLine($"\"{function}\",\"{service}\",\"{arch}\",\"{s.Count}\",\"{s.Mean:F2}\",\"{s.P50:F2}\",\"{s.P90:F2}\",\"{s.P99:F2}\",\"{s.StdDev:F2}\",\"{avgMem:F0}\",\"{meanInit:F2}\"");
        }
    }

    /// <summary>
    /// Forces a cold start and extracts Total Duration, Init Duration, and Max Memory Used
    /// from the Lambda REPORT line in LogResult. The REPORT line format is:
    /// REPORT RequestId: xxx Duration: xxx ms Billed Duration: xxx ms Memory Size: 512 MB Max Memory Used: xxx MB Init Duration: xxx ms
    ///
    /// The presence of "Init Duration" in the REPORT line confirms this was a cold start.
    /// We record the "Duration" field (total execution time including INIT + INVOKE) as
    /// the benchmark metric, because the INIT phase alone does not capture the SDK's
    /// first-call overhead (HTTP stack setup, first-time JIT, credential resolution, etc.).
    /// </summary>
    private static async Task<(double? TotalDuration, double? InitDuration, int? MaxMemoryUsedMB)> ForceColdStartAndGetMetrics(IAmazonLambda client, string functionName)
    {
        const int maxRetries = 3;
        for (int retry = 0; retry < maxRetries; retry++)
        {
            try
            {
                // Wait for any in-progress updates before starting
                await WaitForFunctionUpdated(client, functionName);

                // Force cold start by updating environment variable
                await client.UpdateFunctionConfigurationAsync(new UpdateFunctionConfigurationRequest
                {
                    FunctionName = functionName,
                    Environment = new Amazon.Lambda.Model.Environment
                    {
                        Variables = new Dictionary<string, string>
                        {
                            ["BENCHMARK_ITERATION"] = Guid.NewGuid().ToString()
                        }
                    }
                });

                // Wait for update to complete
                await WaitForFunctionUpdated(client, functionName);

                // Invoke with Tail and extract metrics from REPORT line
                var response = await client.InvokeAsync(new InvokeRequest
                {
                    FunctionName = functionName,
                    LogType = LogType.Tail,
                    Payload = "{}"
                });

                if (!string.IsNullOrEmpty(response.LogResult))
                {
                    var logText = Encoding.UTF8.GetString(Convert.FromBase64String(response.LogResult));

                    // Confirm this was a cold start by checking for Init Duration
                    var initMatch = Regex.Match(logText, @"Init Duration:\s+([\d.]+)\s+ms");
                    if (initMatch.Success)
                    {
                        double initDuration = double.Parse(initMatch.Groups[1].Value);

                        // Extract the total Duration (this is our benchmark metric)
                        double? totalDuration = null;
                        var durationMatch = Regex.Match(logText, @"REPORT.*?Duration:\s+([\d.]+)\s+ms");
                        if (durationMatch.Success)
                            totalDuration = double.Parse(durationMatch.Groups[1].Value);

                        // Extract Max Memory Used from the same REPORT line
                        int? maxMemoryUsedMB = null;
                        var memMatch = Regex.Match(logText, @"Max Memory Used:\s+(\d+)\s+MB");
                        if (memMatch.Success)
                            maxMemoryUsedMB = int.Parse(memMatch.Groups[1].Value);

                        return (totalDuration, initDuration, maxMemoryUsedMB);
                    }
                }

                // No init duration found (warm start) — retry with backoff
                await Task.Delay(2000 * (retry + 1));
            }
            catch (Amazon.Lambda.Model.ResourceConflictException)
            {
                // Function update still in progress — wait and retry
                await Task.Delay(5000 * (retry + 1));
            }
            catch (Exception ex) when (ex.Message.Contains("Signature expired") || ex.Message.Contains("ResourceConflict"))
            {
                // Transient error — wait and retry
                await Task.Delay(5000 * (retry + 1));
            }
        }

        return (null, null, null);
    }

    private static async Task WaitForFunctionUpdated(IAmazonLambda client, string functionName)
    {
        var deadline = DateTime.UtcNow.AddSeconds(60);
        while (DateTime.UtcNow < deadline)
        {
            var config = await client.GetFunctionConfigurationAsync(new GetFunctionConfigurationRequest
            {
                FunctionName = functionName
            });
            if (config.LastUpdateStatus != LastUpdateStatus.InProgress && config.State != State.Pending)
                return;
            await Task.Delay(2000);
        }
    }

    private static (int Count, double Mean, double P50, double P90, double P99, double StdDev) CalculateStats(List<double> values)
    {
        var sorted = values.OrderBy(v => v).ToArray();
        int n = sorted.Length;
        double mean = sorted.Average();
        double sumSq = sorted.Sum(v => (v - mean) * (v - mean));
        double stdDev = Math.Sqrt(sumSq / n);

        return (n, mean,
            sorted[(int)(n * 0.50)],
            sorted[(int)(n * 0.90)],
            sorted[Math.Min((int)(n * 0.99), n - 1)],
            stdDev);
    }
}
