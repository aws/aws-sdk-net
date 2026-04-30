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

using LambdaBenchmarksRunner;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Exporters.Csv;

// Support custom runner for cold start init duration reporting.
// This reports the Init Duration from Lambda's LogResult (the template-required metric).
// Usage: dotnet run -c Release -- coldstart-initduration [--iterations 100] [--region us-east-1]
if (args.Length > 0 && args[0] == "coldstart-initduration")
{
    await ColdStartInitDurationRunner.RunAsync(args.Skip(1).ToArray());
    return;
}

// BenchmarkDotNet benchmarks (all other commands)
var config = ManualConfig.Create(DefaultConfig.Instance);
var summaryStyle = new SummaryStyle(
    cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
    printUnitsInHeader: false,
    timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: Perfolizer.Metrology.SizeUnit.B);
config.WithSummaryStyle(summaryStyle);

var csvConfig = new SummaryStyle(
    cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
    printUnitsInHeader: false,
    timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: Perfolizer.Metrology.SizeUnit.B);
var csvExporter = new CsvExporter(CsvSeparator.CurrentCulture, csvConfig);
config.AddExporter(csvExporter);

config.AddColumn(StatisticColumn.P50);
config.AddColumn(StatisticColumn.P90);
config.AddColumn(StatisticColumn.P95);

BenchmarkSwitcher.FromTypes(new[]
{
    typeof(DynamoDBBenchmarksRunner),
    typeof(S3BenchmarksRunner),
    typeof(S3TransferUtilityBenchmarksRunner),
    typeof(ColdStartBenchmarksRunner)
}).Run(args, config);
