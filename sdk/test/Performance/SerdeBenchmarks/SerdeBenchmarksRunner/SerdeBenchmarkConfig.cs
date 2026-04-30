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
/// Shared BenchmarkDotNet configuration for serde benchmarks.
/// 
/// Configures RunStrategy.Throughput with 5 warmup iterations and max 15 measurement
/// iterations, letting BenchmarkDotNet automatically determine invocation counts for
/// accurate measurement of fast micro-benchmarks (μs-scale serde operations).
/// With 71 tests, this configuration targets ~12-18 minutes total runtime.
/// 
/// BDN Throughput mode reports P50, P90, P95 from per-iteration averages.
/// Max is included as an upper-bound outlier indicator.
/// </summary>
public class SerdeBenchmarkConfig : ManualConfig
{
    public SerdeBenchmarkConfig()
    {
        // Performance Baselines Report used: WarmupCount=10, no Min/MaxIterationCount (BDN auto)
        // Optimized for CI/build system runtime: WarmupCount=5, MinIter=5, MaxIter=20
        AddJob(Job.Default
            .WithStrategy(BenchmarkDotNet.Engines.RunStrategy.Throughput)
            .WithWarmupCount(5)
            .WithMinIterationCount(5)
            .WithMaxIterationCount(20));

        // Add percentile columns
        AddColumn(StatisticColumn.P50);
        AddColumn(StatisticColumn.P90);
        AddColumn(StatisticColumn.P95);
        AddColumn(StatisticColumn.Max);  // P100 = Max, useful as upper-bound outlier indicator

        WithSummaryStyle(SummaryStyle.Default
            .WithTimeUnit(TimeUnit.Nanosecond)
        );
    }
}
