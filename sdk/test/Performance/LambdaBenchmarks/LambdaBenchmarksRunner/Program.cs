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

var config = ManualConfig.Create(DefaultConfig.Instance);
var summaryStyle = new SummaryStyle(
    cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
    printUnitsInHeader: false,
    timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: SizeUnit.B);
config.WithSummaryStyle(summaryStyle);

// When exporting results, use milliseconds so that when pushing to CloudWatch we only have to parse ms
var csvConfig = new SummaryStyle(
    cultureInfo: System.Globalization.CultureInfo.InvariantCulture,
    printUnitsInHeader: false,
    timeUnit: Perfolizer.Horology.TimeUnit.Millisecond, sizeUnit: SizeUnit.B);
var csvExporter = new CsvExporter(CsvSeparator.CurrentCulture, csvConfig);
config.AddExporter(csvExporter);

config.AddColumn(StatisticColumn.P50);
config.AddColumn(StatisticColumn.P90);
config.AddColumn(StatisticColumn.P95);

BenchmarkRunner.Run<DynamoDBBenchmarksRunner>(config);
BenchmarkRunner.Run<S3BenchmarksRunner>(config);
BenchmarkRunner.Run<S3TransferUtilityBenchmarksRunner>(config);
