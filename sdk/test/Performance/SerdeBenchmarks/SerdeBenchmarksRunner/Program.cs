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
///
/// Suites:
///   e2e    - Full SDK client pipeline with mocked HTTP (default)
///   serde  - Isolated marshaller/unmarshaller micro-benchmarks
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

    static void Main(string[] args)
    {
        // Parse --suite argument before passing remaining args to BDN
        var suite = "e2e";
        var bdnArgs = new List<string>();
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] == "--suite" && i + 1 < args.Length)
            {
                suite = args[++i].ToLowerInvariant();
            }
            else
            {
                bdnArgs.Add(args[i]);
            }
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
}
