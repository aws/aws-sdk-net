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
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using Perfolizer.Horology;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet configuration for E2E benchmarks.
/// Uses InProcessEmitToolchain so benchmarks can run from a published DLL
/// without needing the source .csproj or dotnet SDK for child process generation.
/// BDN auto-determines warmup and iteration counts for statistically stable results.
/// </summary>
public class E2EBenchmarkConfig : ManualConfig
{
    public E2EBenchmarkConfig()
    {
        // InProcessEmitToolchain runs benchmarks in the same process.
        // This avoids BDN's need to find the .csproj and spawn child processes,
        // making it compatible with published/deployed artifacts.
        AddJob(Job.Default
            .WithToolchain(InProcessEmitToolchain.Instance));

        // Add percentile columns
        AddColumn(StatisticColumn.P50);
        AddColumn(StatisticColumn.P90);
        AddColumn(StatisticColumn.P95);
        AddColumn(StatisticColumn.Max);

        WithSummaryStyle(SummaryStyle.Default
            .WithTimeUnit(TimeUnit.Nanosecond)
        );
    }
}
