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
using Perfolizer.Horology;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// BenchmarkDotNet configuration for serde (marshal/unmarshal) benchmarks.
/// 
/// Uses OutOfProcess (default BDN toolchain) with WarmupCount=10 and BDN
/// auto-determined iteration counts for maximum measurement accuracy.
/// These benchmarks produce the baselines for cross-SDK performance comparison,
/// so speed and accuracy are prioritized over runtime.
/// 
/// With 71 tests, this configuration targets ~45-60 minutes total runtime.
/// </summary>
public class SerdeBenchmarkConfig : ManualConfig
{
    public SerdeBenchmarkConfig()
    {
        // OutOfProcess (Job.Default) for maximum speed — no InProcess overhead.
        // WarmupCount=10, BDN auto iterations for statistically stable results.
        AddJob(Job.Default
            .WithStrategy(BenchmarkDotNet.Engines.RunStrategy.Throughput)
            .WithWarmupCount(10));

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
