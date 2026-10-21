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
    // Run-wide defaults, settable from the CLI (see Program). A caller may still override per invocation.
    public static int DefaultWarmupIterations = 100000;
    public static int DefaultMinIterations = 50000;
    public static double DefaultMinCpuSeconds = 5.0;
    // Optional case-name filter (regex); non-matching cases are skipped and return null.
    public static System.Text.RegularExpressions.Regex? Filter;
    // Concurrent workers per case (--threads). 1 = the original single-threaded loop below, unchanged.
    public static int Threads = 1;
    // Generated cases whose single shared request holds a MemoryStream (blob attributes, PutObject Body). The SDK
    // reads those streams by position, so concurrent calls on the same request object corrupt each other and throw.
    // That is invalid caller usage, not an SDK regression, so --threads > 1 skips them. Covering them would need a
    // per-worker request from the generator.
    private static readonly System.Text.RegularExpressions.Regex SharedStreamCase =
        new(@"_PutItemRequest_BinaryData_|_PutObject_");

    public static async Task<CpuTimeResult?> MeasureAsync(
        string name,
        Func<Task> operation,
        int warmupIterations = -1,
        int minIterations = -1,
        double minCpuSeconds = -1,
        int checkInterval = 100)
    {
        // Resolve configuration from the CLI-provided defaults unless the caller passed explicit values.
        if (warmupIterations < 0) warmupIterations = DefaultWarmupIterations;
        if (minIterations < 0) minIterations = DefaultMinIterations;
        if (minCpuSeconds < 0) minCpuSeconds = DefaultMinCpuSeconds;
        if (Filter != null && !Filter.IsMatch(name)) return null;
        if (Threads > 1)
        {
            if (SharedStreamCase.IsMatch(name))
            {
                Console.WriteLine($"[threads {Threads}] skipped {name}: its shared request holds a MemoryStream that concurrent calls would race on");
                return null;
            }
            return await MeasureConcurrentAsync(name, operation, warmupIterations, minIterations, minCpuSeconds, checkInterval, Threads);
        }
        if (PipelineBreakdown.Enabled) operation = PipelineBreakdown.Wrap(operation);

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
        if (PipelineBreakdown.Enabled) PipelineBreakdown.BeginMeasurement();

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
        if (PipelineBreakdown.Enabled) PipelineBreakdown.EndMeasurement(name, cpuSeconds / iterations);

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

    // Shared counters for one concurrent run. Fields (not captured locals) so Interlocked/Volatile get a plain ref.
    private sealed class ConcurrentRunState
    {
        public long CompletedOps;
        public int Stop;
    }

    /// <summary>
    /// Regression check for shared SDK state under concurrency (--threads N, N &gt; 1); not the cross-SDK metric.
    /// Same client and request as the single-threaded path. Warmup runs warmupIterations in total across the
    /// workers. The measured run stops once total ops &gt;= minIterations * threads or process CPU time
    /// &gt;= minCpuSeconds * threads. Each worker publishes its count and checks the stop condition every
    /// checkInterval of its own iterations; every completed op is counted, including those finished by other
    /// workers after the stop decision (wall and CPU are read after all workers have exited).
    /// </summary>
    private static async Task<CpuTimeResult> MeasureConcurrentAsync(
        string name,
        Func<Task> operation,
        int warmupIterations,
        int minIterations,
        double minCpuSeconds,
        int checkInterval,
        int threads)
    {
        var warmup = new Task[threads];
        for (int w = 0; w < threads; w++)
        {
            int count = warmupIterations / threads + (w < warmupIterations % threads ? 1 : 0);
            warmup[w] = Task.Run(async () =>
            {
                for (int i = 0; i < count; i++)
                    await operation();
            });
        }
        await Task.WhenAll(warmup);

        // Force GC to start clean
        GC.Collect(2, GCCollectionMode.Forced, true, true);
        GC.WaitForPendingFinalizers();
        GC.Collect(2, GCCollectionMode.Forced, true, true);

        long targetOps = (long)minIterations * threads;
        double targetCpuSeconds = minCpuSeconds * threads;
        var state = new ConcurrentRunState();
        var workers = new Task[threads];

        var process = Process.GetCurrentProcess();
        var cpuBefore = process.TotalProcessorTime;
        var wallBefore = Stopwatch.GetTimestamp();

        for (int w = 0; w < threads; w++)
        {
            workers[w] = Task.Run(async () =>
            {
                // Process is not thread-safe; each worker refreshes its own instance.
                var own = Process.GetCurrentProcess();
                int local = 0;
                while (true)
                {
                    await operation();
                    if (++local == checkInterval)
                    {
                        local = 0;
                        long total = Interlocked.Add(ref state.CompletedOps, checkInterval);
                        if (Volatile.Read(ref state.Stop) != 0)
                            break;
                        own.Refresh();
                        if (total >= targetOps || (own.TotalProcessorTime - cpuBefore).TotalSeconds >= targetCpuSeconds)
                        {
                            Volatile.Write(ref state.Stop, 1);
                            break;
                        }
                    }
                }
            });
        }
        await Task.WhenAll(workers);

        var wallAfter = Stopwatch.GetTimestamp();
        process.Refresh();
        var cpuAfter = process.TotalProcessorTime;

        long ops = Interlocked.Read(ref state.CompletedOps);
        var wallSeconds = (wallAfter - wallBefore) / (double)Stopwatch.Frequency;
        var cpuSeconds = (cpuAfter - cpuBefore).TotalSeconds;

        return new CpuTimeResult(
            BenchmarkName: name,
            Iterations: (int)ops,
            WallClockSeconds: wallSeconds,
            CpuTimeSeconds: cpuSeconds,
            OpsPerWallSec: ops / wallSeconds,
            OpsPerCpuSec: ops / cpuSeconds,
            CpuToWallRatio: cpuSeconds / wallSeconds
        );
    }

    /// <summary>
    /// Geometric mean computed in log space; the direct product of 71 values overflows double
    /// once the geomean exceeds ~21,900 ops/CPU-sec.
    /// </summary>
    public static double GeometricMean(IEnumerable<CpuTimeResult> results)
        => Math.Exp(results.Average(r => Math.Log(r.OpsPerCpuSec)));

    /// <summary>
    /// Prints results in a table format and computes geometric mean.
    /// </summary>
    public static void PrintResults(IList<CpuTimeResult?> resultsWithSkips, string suiteName)
    {
        var results = resultsWithSkips.Where(r => r != null).Select(r => r!).ToList();
        if (results.Count == 0) return;
        Console.WriteLine();
        Console.WriteLine(Threads > 1
            ? $"=== CPU Time Results: {suiteName} (Threads: {Threads}) ==="
            : $"=== CPU Time Results: {suiteName} ===");
        Console.WriteLine($"{"Benchmark",-45} {"Iters",8} {"Wall(s)",9} {"CPU(s)",9} {"Ops/Wall-s",12} {"Ops/CPU-s",12} {"CPU/Wall",8}");
        Console.WriteLine(new string('-', 105));

        double logSum = 0.0;
        int count = 0;

        foreach (var r in results)
        {
            Console.WriteLine($"{r.BenchmarkName,-45} {r.Iterations,8} {r.WallClockSeconds,9:F4} {r.CpuTimeSeconds,9:F4} {r.OpsPerWallSec,12:F0} {r.OpsPerCpuSec,12:F0} {r.CpuToWallRatio,8:F4}");
            logSum += Math.Log(r.OpsPerCpuSec);
            count++;
        }

        var geoMean = Math.Exp(logSum / count);
        Console.WriteLine(new string('-', 105));
        Console.WriteLine($"{"Geometric Mean (ops/CPU-sec)",-45} {"",8} {"",9} {"",9} {"",12} {geoMean,12:F0}");
        Console.WriteLine();
        if (Threads > 1)
        {
            Console.WriteLine($"CPU/Wall ratio interpretation ({Threads} concurrent workers):");
            Console.WriteLine($"  ~{Threads} = workers stayed busy (expected)");
            Console.WriteLine($"  well below {Threads} = workers blocked or starved (contention, thread-pool injection, or too few cores)");
            return;
        }
        Console.WriteLine($"CPU/Wall ratio interpretation:");
        Console.WriteLine($"  ~1.0 = single-threaded, CPU-bound (good: wall and CPU time agree)");
        Console.WriteLine($"  >1.0 = multi-threaded work (CPU time > wall time)");
        Console.WriteLine($"  <1.0 = I/O waits or sleeps (should not happen with mocked HTTP)");
    }
}
