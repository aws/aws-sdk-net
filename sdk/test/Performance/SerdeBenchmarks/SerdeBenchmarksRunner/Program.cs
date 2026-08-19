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

    static async Task Main(string[] args)
    {
        // Parse custom arguments before passing remaining args to BDN
        var suite = "e2e";
        var cpuTimeMode = false;
        var iterations = 10000;
        var warmup = 1000;
        var bdnArgs = new List<string>();

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--suite" && i + 1 < args.Length)
            {
                suite = args[++i].ToLowerInvariant();
            }
            else if (args[i] == "--cpu-time")
            {
                cpuTimeMode = true;
            }
            else if (args[i] == "--iterations" && i + 1 < args.Length)
            {
                iterations = int.Parse(args[++i]);
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

        if (cpuTimeMode)
        {
            await RunCpuTimeMode();
            return;
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
    }

    /// <summary>
    /// Runs all 71 E2E benchmarks using CpuTimeRunner (not BDN).
    /// Measures ops/CPU-sec per operation, reports geometric mean per protocol and overall.
    /// </summary>
    private static async Task RunCpuTimeMode()
    {
        Console.WriteLine($"CPU Time Mode: min 1000 iterations OR 5 sec CPU (first met wins)");
        Console.WriteLine($"Check interval: every 100 iterations");
        Console.WriteLine($"Warmup: 100 iterations");
        Console.WriteLine($"Process: {Environment.ProcessPath}");
        Console.WriteLine($"Runtime: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");
        Console.WriteLine($"OS: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
        Console.WriteLine($"Arch: {System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}");
        Console.WriteLine();

        var allResults = await CpuTimeBenchmarks.RunAll();

        // Overall summary
        Console.WriteLine();
        Console.WriteLine($"=== Overall Summary (All Protocols) ===");
        var overallGeoMean = Math.Pow(
            allResults.Aggregate(1.0, (acc, r) => acc * r.OpsPerCpuSec),
            1.0 / allResults.Count);
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
            var protoGeo = Math.Pow(
                group.Aggregate(1.0, (acc, r) => acc * r.OpsPerCpuSec),
                1.0 / group.Count());
            Console.WriteLine($"  {group.Key,-20} {protoGeo,12:F0} ops/CPU-sec ({group.Count()} benchmarks)");
        }

        Console.WriteLine();
        Console.WriteLine("FEASIBILITY VERDICT:");
        if (avgCpuWallRatio >= 0.95 && avgCpuWallRatio <= 1.05)
            Console.WriteLine("  PASS - CPU time and wall time align within 5%.");
        else if (avgCpuWallRatio > 1.05)
            Console.WriteLine($"  NOTE - CPU/Wall ratio > 1.0 ({avgCpuWallRatio:F3}). Multi-threaded async overhead. Still valid.");
        else
            Console.WriteLine($"  WARNING - CPU/Wall ratio < 0.95 ({avgCpuWallRatio:F3}). Investigate.");
    }
}
