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

using System.Diagnostics;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// Measures operations per CPU-second for E2E benchmarks.
/// Stops when EITHER minIterations OR minCpuSeconds is reached (first wins).
/// Fast ops run until 5s CPU; slow ops stop as soon as 5s CPU is hit.
/// CPU time is only checked every checkInterval iterations to avoid overhead.
/// </summary>
public static class CpuTimeRunner
{
    public record CpuTimeResult(
        string BenchmarkName,
        int Iterations,
        double WallClockSeconds,
        double CpuTimeSeconds,
        double OpsPerWallSec,
        double OpsPerCpuSec,
        double CpuToWallRatio
    );

    /// <summary>
    /// Runs an async benchmark until EITHER minIterations OR minCpuSeconds is reached.
    /// Warmup is run first and discarded.
    /// </summary>
    public static async Task<CpuTimeResult> MeasureAsync(
        string name,
        Func<Task> operation,
        int warmupIterations = 100,
        int minIterations = 50000,
        double minCpuSeconds = 5.0,
        int checkInterval = 100)
    {
        // Warmup: let JIT, tiered compilation, and caches stabilize
        for (int i = 0; i < warmupIterations; i++)
        {
            await operation();
        }

        // Force GC to start clean
        GC.Collect(2, GCCollectionMode.Forced, true, true);
        GC.WaitForPendingFinalizers();
        GC.Collect(2, GCCollectionMode.Forced, true, true);

        // Capture starting CPU time and wall clock
        var process = Process.GetCurrentProcess();
        var cpuBefore = process.TotalProcessorTime;
        var wallBefore = Stopwatch.GetTimestamp();
        int iterations = 0;

        // Run until EITHER condition is met (first one wins)
        while (true)
        {
            await operation();
            iterations++;

            if (iterations % checkInterval == 0)
            {
                process.Refresh();
                double elapsed = (process.TotalProcessorTime - cpuBefore).TotalSeconds;
                if (iterations >= minIterations || elapsed >= minCpuSeconds)
                    break;
            }
        }

        // Capture final values
        var wallAfter = Stopwatch.GetTimestamp();
        process.Refresh();
        var cpuAfter = process.TotalProcessorTime;

        var wallSeconds = (wallAfter - wallBefore) / (double)Stopwatch.Frequency;
        var cpuSeconds = (cpuAfter - cpuBefore).TotalSeconds;

        return new CpuTimeResult(
            BenchmarkName: name,
            Iterations: iterations,
            WallClockSeconds: wallSeconds,
            CpuTimeSeconds: cpuSeconds,
            OpsPerWallSec: iterations / wallSeconds,
            OpsPerCpuSec: iterations / cpuSeconds,
            CpuToWallRatio: cpuSeconds / wallSeconds
        );
    }

    /// <summary>
    /// Prints results in a table format and computes geometric mean.
    /// </summary>
    public static void PrintResults(IList<CpuTimeResult> results, string suiteName)
    {
        Console.WriteLine();
        Console.WriteLine($"=== CPU Time Results: {suiteName} ===");
        Console.WriteLine($"{"Benchmark",-45} {"Iters",8} {"Wall(s)",9} {"CPU(s)",9} {"Ops/Wall-s",12} {"Ops/CPU-s",12} {"CPU/Wall",8}");
        Console.WriteLine(new string('-', 105));

        double geoMeanProduct = 1.0;
        int count = 0;

        foreach (var r in results)
        {
            Console.WriteLine($"{r.BenchmarkName,-45} {r.Iterations,8} {r.WallClockSeconds,9:F4} {r.CpuTimeSeconds,9:F4} {r.OpsPerWallSec,12:F0} {r.OpsPerCpuSec,12:F0} {r.CpuToWallRatio,8:F4}");
            geoMeanProduct *= r.OpsPerCpuSec;
            count++;
        }

        var geoMean = Math.Pow(geoMeanProduct, 1.0 / count);
        Console.WriteLine(new string('-', 105));
        Console.WriteLine($"{"Geometric Mean (ops/CPU-sec)",-45} {"",8} {"",9} {"",9} {"",12} {geoMean,12:F0}");
        Console.WriteLine();
        Console.WriteLine($"CPU/Wall ratio interpretation:");
        Console.WriteLine($"  ~1.0 = single-threaded, CPU-bound (good: wall and CPU time agree)");
        Console.WriteLine($"  >1.0 = multi-threaded work (CPU time > wall time)");
        Console.WriteLine($"  <1.0 = I/O waits or sleeps (should not happen with mocked HTTP)");
    }
}
