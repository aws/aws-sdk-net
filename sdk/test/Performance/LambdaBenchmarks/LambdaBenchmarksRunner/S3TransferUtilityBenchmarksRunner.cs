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

using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Amazon.S3;
using Amazon.S3.Util;

namespace LambdaBenchmarksRunner
{
    public class S3TransferUtilityBenchmarksRunner : LambdaBenchmarkBase
    {

        [Params(512, 1024)]  // 256MB lambda cannot fit the 100MB files created by Transfer utility tests in addition to build artifacts.
        public override int MemorySize { get; set; }

        private AmazonS3Client _s3Client;
        private string _bucketName;
        private string _payload;
        private string _uniqueId;

        private const string TransferUtilityUploadStreamFunctionName = "UploadStreamHandler";
        private const string S3TransferUtilityFunctionsPath = "LambdaBenchmarks::LambdaBenchmarks.S3TransferUtilityLambdaBenchmarks";

        public async Task GlobalSetup()
        {
            _s3Client = new AmazonS3Client();
            _uniqueId = new Random().Next().ToString("x");
            _bucketName = "lambda-benchmarks-" + _uniqueId;
            await _s3Client.PutBucketAsync(_bucketName);

            _payload = JsonSerializer.Serialize(new
            {
                bucketName = _bucketName,
            });
        }

        #region TransferUtilityUploadStream

        [GlobalSetup(Target = nameof(S3_TransferUtilityUploadStream))]
        public async Task SetupForTransferUtilityUploadStream()
        {
            await GlobalSetup();
            await InitializeLambdaFunction($"{TransferUtilityUploadStreamFunctionName}-{_uniqueId}", $"{S3TransferUtilityFunctionsPath}::{TransferUtilityUploadStreamFunctionName}");
        }

        [Benchmark]
        public async Task S3_TransferUtilityUploadStream()
        {
            await LambdaUtilities.ExecuteFunction(lambdaClient, CurrentFunctionName, _payload);
        }

        [GlobalCleanup(Target = nameof(S3_TransferUtilityUploadStream))]
        public async Task CleanupForTransferUtilityUploadStream()
        {
            await DeleteCurrentLambdaFunction();
            await GlobalCleanup();
        }

        #endregion

        public async Task GlobalCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_s3Client, _bucketName);
        }
    }
}
