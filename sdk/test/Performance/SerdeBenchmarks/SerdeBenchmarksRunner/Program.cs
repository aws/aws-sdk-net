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

using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using AWSSDK.Benchmarks.Serde;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// Entry point for the serde benchmark runner using BenchmarkDotNet.
/// 
/// Usage:
///   dotnet run -c Release -- --filter '*'                    # Run E2E benchmarks (default)
///   dotnet run -c Release -- --suite e2e --filter '*'        # Run E2E benchmarks (explicit)
///   dotnet run -c Release -- --suite serde --filter '*'      # Run only marshal/unmarshal benchmarks
///   dotnet run -c Release -- --filter '*RestJson1*'          # Run only RestJson1 benchmarks
///   dotnet run -c Release -- --suite serde --filter '*RestJson1*'  # Serde RestJson1 only
///   dotnet run -c Release -- --cpu-time                      # Run E2E with CPU time measurement
///   dotnet run -c Release -- --cpu-time --iterations 5000    # Custom iteration count
///   dotnet run -c Release -- --cpu-time --transport https    # Through the real HTTP client to a loopback fixture server
///   dotnet run -c Release -- --cpu-time --threads 4          # Concurrency regression check (shared client)
///
/// --cpu-time options:
///   --warmup N                Warmup iterations per case (default 100000)
///   --min-iterations N        Stop measuring after N iterations or S CPU seconds,
///   --min-cpu-seconds S       whichever comes first (defaults 50000 and 5)
///   --transport stub|https    stub (default): in-process MockHttpHandler. https: see README.md, HTTPS loopback mode
///   --https-server IP:PORT    The fixture server's HTTPS address (default 127.0.0.1:18443)
///   --fixture-control IP:PORT The fixture server's control address (default 127.0.0.1:18080)
///   --case-filter REGEX       Run only the cases whose name matches
///   --threads N               Concurrent workers per case on the shared client (default 1; N > 1 is a regression check)
///   --breakdown               Per-stage pipeline timing (requires --threads 1 and --transport stub)
///   --breakdown-csv PATH      Append the breakdown rows to a CSV file
///
/// Suites:
///   e2e    - Full SDK client pipeline with mocked HTTP (default)
///   serde  - Isolated marshaller/unmarshaller micro-benchmarks
///
/// Modes:
///   (default) - BenchmarkDotNet throughput/latency mode
///   --cpu-time - Measures ops/CPU-sec using Process.TotalProcessorTime
///
/// Results are output to BenchmarkDotNet.Artifacts/results/ in CSV, GitHub Markdown, and HTML formats.
/// </summary>
internal class Program
{
    private static readonly Type[] SerdeBenchmarkTypes = new[]
    {
        typeof(RestJson1Benchmarks),
        typeof(AwsJson10Benchmarks),
        typeof(RpcV2CborBenchmarks),
        typeof(RestXmlBenchmarks),
        typeof(AwsQueryBenchmarks)
    };

    private static readonly Type[] E2EBenchmarkTypes = new[]
    {
        typeof(RestJson1E2EBenchmarks),
        typeof(AwsJson10E2EBenchmarks),
        typeof(RpcV2CborE2EBenchmarks),
        typeof(RestXmlE2EBenchmarks),
        typeof(AwsQueryE2EBenchmarks)
    };

    static async Task<int> Main(string[] args)
    {
        // Parse custom arguments before passing remaining args to BDN
        var suite = "e2e";
        var cpuTimeMode = false;
        // ops/CPU-sec defaults: warmup 100000, then min 50000 iters OR 5s CPU (first wins). Tiered
        // compilation keeps recompiling hot methods in the background for a while after the first calls,
        // so a short warmup lets that JIT work (and slower code) land in the measured window, mostly for
        // the first cases of each protocol.
        var warmup = 100000;
        var minIterations = 50000;
        var minCpuSeconds = 5.0;
        // --cpu-time transport (see README.md, HTTPS loopback mode).
        var transport = "stub";
        var httpsServer = BenchmarkTransport.DefaultHttpsServer;
        var fixtureControl = BenchmarkTransport.DefaultFixtureControl;
        var transportOptionUsed = false;
        var threads = 1;
        System.Text.RegularExpressions.Regex? caseFilter = null;
        var breakdown = false;
        string? breakdownCsv = null;
        var bdnArgs = new List<string>();

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] is "--transport" or "--https-server" or "--fixture-control")
            {
                if (i + 1 >= args.Length)
                    return Fail($"{args[i]} requires a value");
                transportOptionUsed = true;
                var value = args[++i];
                if (args[i - 1] == "--transport") transport = value;
                else if (args[i - 1] == "--https-server") httpsServer = value;
                else fixtureControl = value;
            }
            else if (args[i] == "--suite" && i + 1 < args.Length)
            {
                suite = args[++i].ToLowerInvariant();
            }
            else if (args[i] == "--cpu-time")
            {
                cpuTimeMode = true;
            }
            else if ((args[i] == "--iterations" || args[i] == "--min-iterations") && i + 1 < args.Length)
            {
                minIterations = int.Parse(args[++i]);
            }
            else if (args[i] == "--min-cpu-seconds" && i + 1 < args.Length)
            {
                minCpuSeconds = double.Parse(args[++i], System.Globalization.CultureInfo.InvariantCulture);
            }
            else if (args[i] is "--case-filter" or "--breakdown-csv" or "--threads")
            {
                if (i + 1 >= args.Length)
                    return Fail($"{args[i]} requires a value");
                var option = args[i];
                var value = args[++i];
                if (option == "--case-filter")
                {
                    try { caseFilter = new System.Text.RegularExpressions.Regex(value); }
                    catch (ArgumentException e) { return Fail($"--case-filter: invalid regex '{value}': {e.Message}"); }
                }
                else if (option == "--breakdown-csv")
                {
                    breakdownCsv = value;
                }
                else if (!int.TryParse(value, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out threads))
                {
                    return Fail($"--threads must be an integer (got '{value}')");
                }
            }
            else if (args[i] == "--breakdown")
            {
                breakdown = true;
            }
            else if (args[i] == "--warmup" && i + 1 < args.Length)
            {
                warmup = int.Parse(args[++i]);
            }
            else
            {
                bdnArgs.Add(args[i]);
            }
        }

        if (transportOptionUsed && !cpuTimeMode)
            return Fail("--transport, --https-server and --fixture-control apply only with --cpu-time");
        if ((caseFilter != null || breakdown || breakdownCsv != null) && !cpuTimeMode)
            return Fail("--case-filter, --breakdown and --breakdown-csv apply only with --cpu-time");
        if (breakdownCsv != null && !breakdown)
            return Fail("--breakdown-csv requires --breakdown");
        if (threads != 1)
        {
            string? error =
                threads < 1 ? $"--threads must be >= 1 (got {threads})" :
                !cpuTimeMode ? "--threads applies only with --cpu-time" :
                breakdown ? "--breakdown requires --threads 1: the pipeline probes record into static, unsynchronized slots" :
                null;
            if (error != null)
                return Fail(error);
        }

        if (cpuTimeMode)
        {
            // Wire CLI config into the measurement runner (applies to all 71 cases).
            CpuTimeRunner.DefaultWarmupIterations = warmup;
            CpuTimeRunner.DefaultMinIterations = minIterations;
            CpuTimeRunner.DefaultMinCpuSeconds = minCpuSeconds;
            CpuTimeRunner.Threads = threads;
            CpuTimeRunner.Filter = caseFilter;
            if (threads > 1)
            {
                // Let all N workers start at once instead of waiting on thread-pool hill-climbing injection.
                ThreadPool.GetMinThreads(out var minWorker, out var minIo);
                ThreadPool.SetMinThreads(Math.Max(minWorker, threads + 1), minIo);
            }
            try
            {
                BenchmarkTransport.Configure(transport, httpsServer, fixtureControl);
                if (breakdown && BenchmarkTransport.Kind != BenchmarkTransportKind.Stub)
                    return Fail("--breakdown requires --transport stub: the transport stage is stamped by the in-process MockHttpHandler");
                if (BenchmarkTransport.Kind == BenchmarkTransportKind.Https)
                    BenchmarkTransport.CheckFixtureServer();
            }
            catch (Exception e) when (e is ArgumentException or InvalidOperationException)
            {
                return Fail(e.Message);
            }
            if (breakdown)
            {
                // Registered only once the options are valid: the probe customizer applies to every client built afterwards.
                PipelineBreakdown.OutputCsv = breakdownCsv;
                PipelineBreakdown.Register();
            }
            return await RunCpuTimeMode();
        }

        var types = suite switch
        {
            "e2e" => E2EBenchmarkTypes,
            "serde" => SerdeBenchmarkTypes,
            "all" => SerdeBenchmarkTypes.Concat(E2EBenchmarkTypes).ToArray(),
            _ => throw new ArgumentException($"Unknown suite '{suite}'. Valid: e2e, serde, all")
        };

        var config = ManualConfig.Create(DefaultConfig.Instance);

        // Configure summary style for nanosecond reporting
        var summaryStyle = new SummaryStyle(
            cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
            printUnitsInHeader: false,
            timeUnit: Perfolizer.Horology.TimeUnit.Nanosecond,
            sizeUnit: Perfolizer.Metrology.SizeUnit.B);
        config.WithSummaryStyle(summaryStyle);

        // Add CSV exporter
        var csvConfig = new SummaryStyle(
            cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
            printUnitsInHeader: false,
            timeUnit: Perfolizer.Horology.TimeUnit.Nanosecond,
            sizeUnit: Perfolizer.Metrology.SizeUnit.B);
        config.AddExporter(new CsvExporter(CsvSeparator.CurrentCulture, csvConfig));

        // Add percentile columns
        config.AddColumn(StatisticColumn.P50);
        config.AddColumn(StatisticColumn.P90);
        config.AddColumn(StatisticColumn.P95);
        config.AddColumn(StatisticColumn.Max);  // P100 = Max, upper-bound outlier indicator

        Console.WriteLine($"Running suite: {suite} ({types.Length} benchmark classes)");
        BenchmarkSwitcher.FromTypes(types).Run(bdnArgs.ToArray(), config);
        return 0;
    }

    /// <summary>Reports an invalid command line and returns exit code 2.</summary>
    private static int Fail(string message)
    {
        Console.Error.WriteLine($"error: {message}");
        return 2;
    }

    /// <summary>
    /// Runs all 71 E2E benchmarks using CpuTimeRunner (not BDN).
    /// Measures ops/CPU-sec per operation, reports geometric mean per protocol and overall.
    /// Returns the process exit code: 2 if no case ran.
    /// </summary>
    private static async Task<int> RunCpuTimeMode()
    {
        Console.WriteLine($"CPU Time Mode: min {CpuTimeRunner.DefaultMinIterations} iterations OR {CpuTimeRunner.DefaultMinCpuSeconds} sec CPU (first met wins)");
        Console.WriteLine($"Check interval: every 100 iterations");
        Console.WriteLine($"Warmup: {CpuTimeRunner.DefaultWarmupIterations} iterations");
        Console.WriteLine($"Transport: {BenchmarkTransport.Describe()}");
        if (CpuTimeRunner.Threads > 1)
        {
            Console.WriteLine($"Threads: {CpuTimeRunner.Threads} concurrent workers on the shared client (warmup split across workers; stop at {CpuTimeRunner.DefaultMinIterations}x{CpuTimeRunner.Threads} total ops OR {CpuTimeRunner.DefaultMinCpuSeconds}x{CpuTimeRunner.Threads} sec process CPU)");
            Console.WriteLine($"         Concurrency regression check only; not comparable to the single-threaded cross-SDK metric.");
        }
        Console.WriteLine($"Process: {Environment.ProcessPath}");
        Console.WriteLine($"Runtime: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");
        Console.WriteLine($"OS: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
        Console.WriteLine($"Arch: {System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}");
        Console.WriteLine();

        var allResults = (await CpuTimeBenchmarks.RunAll()).Where(r => r != null).Select(r => r!).ToList();
        if (allResults.Count == 0)
        {
            return Fail(CpuTimeRunner.Threads > 1
                ? $"no case ran: --case-filter '{CpuTimeRunner.Filter}' matched no case that --threads {CpuTimeRunner.Threads} runs"
                : $"no case ran: --case-filter '{CpuTimeRunner.Filter}' matched no case");
        }

        // Overall summary
        Console.WriteLine();
        Console.WriteLine($"=== Overall Summary (All Protocols) ===");
        var overallGeoMean = CpuTimeRunner.GeometricMean(allResults);
        var avgCpuWallRatio = allResults.Average(r => r.CpuToWallRatio);
        Console.WriteLine($"Total benchmarks: {allResults.Count}");
        Console.WriteLine($"Overall Geometric Mean (ops/CPU-sec): {overallGeoMean:F0}");
        Console.WriteLine($"Average CPU/Wall ratio: {avgCpuWallRatio:F4}");

        // Per-protocol geometric means
        Console.WriteLine();
        Console.WriteLine("Per-Protocol Geometric Means (ops/CPU-sec):");
        var protocols = allResults.GroupBy(r => r.BenchmarkName.Split('_')[0]);
        foreach (var group in protocols)
        {
            var protoGeo = CpuTimeRunner.GeometricMean(group);
            Console.WriteLine($"  {group.Key,-20} {protoGeo,12:F0} ops/CPU-sec ({group.Count()} benchmarks)");
        }

        Console.WriteLine();
        Console.WriteLine("FEASIBILITY VERDICT:");
        if (CpuTimeRunner.Threads > 1)
        {
            int n = CpuTimeRunner.Threads;
            if (avgCpuWallRatio >= 0.9 * n)
                Console.WriteLine($"  PASS - CPU/Wall ratio {avgCpuWallRatio:F3} is within 10% of {n} workers.");
            else
                Console.WriteLine($"  WARNING - CPU/Wall ratio {avgCpuWallRatio:F3} is below 90% of {n} workers. Workers were not all busy (contention, thread-pool starvation, or fewer free cores than workers).");
            return 0;
        }
        if (avgCpuWallRatio >= 0.95 && avgCpuWallRatio <= 1.05)
            Console.WriteLine("  PASS - CPU time and wall time align within 5%.");
        else if (avgCpuWallRatio > 1.05)
            Console.WriteLine($"  NOTE - CPU/Wall ratio > 1.0 ({avgCpuWallRatio:F3}). Multi-threaded async overhead. Still valid.");
        else
            Console.WriteLine($"  WARNING - CPU/Wall ratio < 0.95 ({avgCpuWallRatio:F3}). Investigate.");
        return 0;
    }
}
