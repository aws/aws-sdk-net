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
///   dotnet run -c Release                              # Run all serde benchmarks
///   dotnet run -c Release -- --filter *RestJson1*      # Run only RestJson1 benchmarks
///   dotnet run -c Release -- --filter *AwsJson*        # Run only AwsJson1.0 benchmarks
///   dotnet run -c Release -- --filter *RpcV2Cbor*      # Run only RpcV2Cbor benchmarks
///   dotnet run -c Release -- --filter *RestXml*        # Run only RestXml benchmarks
///   dotnet run -c Release -- --filter *AwsQuery*       # Run only AwsQuery benchmarks
///
/// Results are output to BenchmarkDotNet.Artifacts/results/ in CSV, GitHub Markdown, and HTML formats.
/// Each benchmark class uses [SimpleJob] with explicit warmupCount=10 and iterationCount=1000
/// to ensure verifiable, reproducible iteration counts meeting the minimum 1,000 requirement.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        var config = ManualConfig.Create(DefaultConfig.Instance);

        // Configure summary style for nanosecond reporting
        var summaryStyle = new SummaryStyle(
            cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
            printUnitsInHeader: false,
            timeUnit: Perfolizer.Horology.TimeUnit.Nanosecond,
            sizeUnit: SizeUnit.B);
        config.WithSummaryStyle(summaryStyle);

        // Add CSV exporter
        var csvConfig = new SummaryStyle(
            cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
            printUnitsInHeader: false,
            timeUnit: Perfolizer.Horology.TimeUnit.Nanosecond,
            sizeUnit: SizeUnit.B);
        config.AddExporter(new CsvExporter(CsvSeparator.CurrentCulture, csvConfig));

        // Add percentile columns (P100/Max = proxy for P99 in BDN v0.13.7)
        config.AddColumn(StatisticColumn.P50);
        config.AddColumn(StatisticColumn.P90);
        config.AddColumn(StatisticColumn.P95);
        config.AddColumn(StatisticColumn.Max);  // P100 = Max, proxy for P99

        // Run all serde benchmark classes via BenchmarkSwitcher
        BenchmarkSwitcher.FromTypes(new[]
        {
            typeof(RestJson1Benchmarks),
            typeof(AwsJson10Benchmarks),
            typeof(RpcV2CborBenchmarks),
            typeof(RestXmlBenchmarks),
            typeof(AwsQueryBenchmarks)
        }).Run(args, config);
    }
}
