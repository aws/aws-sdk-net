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

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.Emit;

namespace AWSSDK.Benchmarks
{
    /// <summary>
    /// Shared BenchmarkDotNet configuration that uses InProcessEmitToolchain.
    /// 
    /// This is required because the AWS SDK for .NET v4 uses internal types
    /// (e.g., ThirdParty.RuntimeBackports.ArrayPoolBufferWriter) and has API
    /// changes (e.g., IAmazonService.CreateDefaultClientConfig()) that cannot
    /// be resolved when BenchmarkDotNet runs benchmarks in a separate process.
    /// 
    /// InProcessEmitToolchain runs benchmarks in the same process, avoiding
    /// assembly resolution issues while still providing accurate measurements.
    /// </summary>
    public class SdkBenchmarkConfig : ManualConfig
    {
        public SdkBenchmarkConfig()
        {
            AddJob(Job.Default.WithToolchain(InProcessEmitToolchain.Instance));
        }
    }
}