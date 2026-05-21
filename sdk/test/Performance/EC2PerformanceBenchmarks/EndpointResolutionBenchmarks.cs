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

using Amazon.Runtime.Endpoints;
using Amazon.S3.Internal;
using Amazon.Lambda.Internal;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AWSSDK.Benchmarks
{
    /// <summary>
    /// Benchmarks for endpoint resolution across S3 and Lambda services.
    /// Measures the time to resolve an endpoint from endpoint parameters,
    /// testing increasingly complex rule evaluation paths.
    /// Results are reported in nanoseconds per operation.
    /// </summary>
    [MemoryDiagnoser]
    [SimpleJob(BenchmarkDotNet.Engines.RunStrategy.Throughput, warmupCount: 10)]
    public class EndpointResolutionBenchmarks
    {
        private readonly AmazonS3EndpointProvider _s3EndpointProvider = new();
        private readonly AmazonLambdaEndpointProvider _lambdaEndpointProvider = new();

        // Pre-built endpoint parameters for each test case to avoid setup overhead in benchmarks
        private EndpointParameters _s3VanillaVirtualAddressing = null!;
        private EndpointParameters _s3VanillaPathStyle = null!;
        private EndpointParameters _s3DataPlaneShortZone = null!;
        private EndpointParameters _s3VanillaAccessPointArn = null!;
        private EndpointParameters _s3OutpostsVanilla = null!;
        private EndpointParameters _lambdaUsEast1 = null!;
        private EndpointParameters _lambdaGovFipsDualStack = null!;

        [GlobalSetup]
        public void Setup()
        {
            // S3: vanilla virtual addressing@us-west-2
            _s3VanillaVirtualAddressing = new EndpointParameters();
            _s3VanillaVirtualAddressing["Region"] = "us-west-2";
            _s3VanillaVirtualAddressing["Bucket"] = "my-test-bucket";
            _s3VanillaVirtualAddressing["UseFIPS"] = false;
            _s3VanillaVirtualAddressing["UseDualStack"] = false;
            _s3VanillaVirtualAddressing["ForcePathStyle"] = false;
            _s3VanillaVirtualAddressing["Accelerate"] = false;
            _s3VanillaVirtualAddressing["UseGlobalEndpoint"] = false;
            _s3VanillaVirtualAddressing["DisableMultiRegionAccessPoints"] = false;

            // S3: vanilla path style@us-west-2
            _s3VanillaPathStyle = new EndpointParameters();
            _s3VanillaPathStyle["Region"] = "us-west-2";
            _s3VanillaPathStyle["Bucket"] = "my-test-bucket";
            _s3VanillaPathStyle["UseFIPS"] = false;
            _s3VanillaPathStyle["UseDualStack"] = false;
            _s3VanillaPathStyle["ForcePathStyle"] = true;
            _s3VanillaPathStyle["Accelerate"] = false;
            _s3VanillaPathStyle["UseGlobalEndpoint"] = false;
            _s3VanillaPathStyle["DisableMultiRegionAccessPoints"] = false;

            // S3: Data Plane with short zone name (S3 Express)
            _s3DataPlaneShortZone = new EndpointParameters();
            _s3DataPlaneShortZone["Region"] = "us-east-1";
            _s3DataPlaneShortZone["Bucket"] = "mybucket--use1-az1--x-s3";
            _s3DataPlaneShortZone["UseFIPS"] = false;
            _s3DataPlaneShortZone["UseDualStack"] = false;
            _s3DataPlaneShortZone["ForcePathStyle"] = false;
            _s3DataPlaneShortZone["Accelerate"] = false;
            _s3DataPlaneShortZone["UseGlobalEndpoint"] = false;
            _s3DataPlaneShortZone["DisableMultiRegionAccessPoints"] = false;

            // S3: vanilla access point arn@us-west-2
            _s3VanillaAccessPointArn = new EndpointParameters();
            _s3VanillaAccessPointArn["Region"] = "us-west-2";
            _s3VanillaAccessPointArn["Bucket"] = "arn:aws:s3:us-west-2:123456789012:accesspoint:myaccesspoint";
            _s3VanillaAccessPointArn["UseFIPS"] = false;
            _s3VanillaAccessPointArn["UseDualStack"] = false;
            _s3VanillaAccessPointArn["ForcePathStyle"] = false;
            _s3VanillaAccessPointArn["Accelerate"] = false;
            _s3VanillaAccessPointArn["UseGlobalEndpoint"] = false;
            _s3VanillaAccessPointArn["DisableMultiRegionAccessPoints"] = false;

            // S3: outposts vanilla test
            _s3OutpostsVanilla = new EndpointParameters();
            _s3OutpostsVanilla["Region"] = "us-west-2";
            _s3OutpostsVanilla["Bucket"] = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            _s3OutpostsVanilla["UseFIPS"] = false;
            _s3OutpostsVanilla["UseDualStack"] = false;
            _s3OutpostsVanilla["ForcePathStyle"] = false;
            _s3OutpostsVanilla["Accelerate"] = false;
            _s3OutpostsVanilla["UseGlobalEndpoint"] = false;
            _s3OutpostsVanilla["DisableMultiRegionAccessPoints"] = false;

            // Lambda: us-east-1 with FIPS disabled and DualStack disabled
            _lambdaUsEast1 = new EndpointParameters();
            _lambdaUsEast1["Region"] = "us-east-1";
            _lambdaUsEast1["UseFIPS"] = false;
            _lambdaUsEast1["UseDualStack"] = false;

            // Lambda: us-gov-east-1 with FIPS enabled and DualStack enabled
            _lambdaGovFipsDualStack = new EndpointParameters();
            _lambdaGovFipsDualStack["Region"] = "us-gov-east-1";
            _lambdaGovFipsDualStack["UseFIPS"] = true;
            _lambdaGovFipsDualStack["UseDualStack"] = true;
        }

        #region S3 Endpoint Resolution Benchmarks

        /// <summary>
        /// S3 endpoint resolution: vanilla virtual addressing in us-west-2.
        /// Tests the most common S3 endpoint resolution path.
        /// </summary>
        [Benchmark]
        public void S3_VanillaVirtualAddressing()
        {
            _s3EndpointProvider.ResolveEndpoint(_s3VanillaVirtualAddressing);
        }

        /// <summary>
        /// S3 endpoint resolution: vanilla path style in us-west-2.
        /// Tests path-style addressing endpoint resolution.
        /// </summary>
        [Benchmark]
        public void S3_VanillaPathStyle()
        {
            _s3EndpointProvider.ResolveEndpoint(_s3VanillaPathStyle);
        }

        /// <summary>
        /// S3 endpoint resolution: Data Plane with short zone name (S3 Express).
        /// Tests S3 Express One Zone endpoint resolution with availability zone parsing.
        /// </summary>
        [Benchmark]
        public void S3_DataPlaneShortZoneName()
        {
            _s3EndpointProvider.ResolveEndpoint(_s3DataPlaneShortZone);
        }

        /// <summary>
        /// S3 endpoint resolution: vanilla access point ARN in us-west-2.
        /// Tests ARN parsing and access point endpoint resolution.
        /// </summary>
        [Benchmark]
        public void S3_VanillaAccessPointArn()
        {
            _s3EndpointProvider.ResolveEndpoint(_s3VanillaAccessPointArn);
        }

        /// <summary>
        /// S3 endpoint resolution: S3 Outposts vanilla test.
        /// Tests the most complex endpoint resolution path with outpost ARN parsing.
        /// </summary>
        [Benchmark]
        public void S3_OutpostsVanilla()
        {
            _s3EndpointProvider.ResolveEndpoint(_s3OutpostsVanilla);
        }

        #endregion

        #region Lambda Endpoint Resolution Benchmarks

        /// <summary>
        /// Lambda endpoint resolution: us-east-1 with FIPS disabled and DualStack disabled.
        /// Tests the simplest Lambda endpoint resolution path.
        /// </summary>
        [Benchmark]
        public void Lambda_UsEast1_NoFips_NoDualStack()
        {
            _lambdaEndpointProvider.ResolveEndpoint(_lambdaUsEast1);
        }

        /// <summary>
        /// Lambda endpoint resolution: us-gov-east-1 with FIPS enabled and DualStack enabled.
        /// Tests GovCloud endpoint resolution with FIPS and DualStack.
        /// </summary>
        [Benchmark]
        public void Lambda_UsGovEast1_Fips_DualStack()
        {
            _lambdaEndpointProvider.ResolveEndpoint(_lambdaGovFipsDualStack);
        }

        #endregion
    }
}