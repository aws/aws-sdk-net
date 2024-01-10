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
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace LambdaBenchmarksRunner
{
    public class S3BenchmarksRunner : LambdaBenchmarkBase
    {
        private AmazonS3Client _s3Client;
        private string _bucketName;
        private string _payload;
        private string _uniqueId;

        private const string GetObjectFunctionName = "GetObjectHandler";
        private const string S3FunctionsPath = "LambdaBenchmarks::LambdaBenchmarks.S3LambdaBenchmarks";

        public async Task GlobalSetup()
        {
            _s3Client = new AmazonS3Client();
            _uniqueId = new Random().Next().ToString("x");
            _bucketName = "lambda-benchmarks-" + _uniqueId;
            await _s3Client.PutBucketAsync(_bucketName);
        }

        #region GetObject

        [GlobalSetup(Target = nameof(S3_GetObject))]
        public async Task SetupForGetObject()
        {
            await GlobalSetup();

            await InitializeLambdaFunction($"{GetObjectFunctionName}-{_uniqueId}", $"{S3FunctionsPath}::{GetObjectFunctionName}");

            var testFileKey = $"test-lambda-getobject-file-{_uniqueId}";
            var testContent = LambdaBenchmarks.Utilities.GenerateTestString(LambdaBenchmarks.Utilities.KBSize * 10);
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = testFileKey,
                ContentBody = testContent,
            };

            await _s3Client.PutObjectAsync(putObjectRequest);
            _payload = JsonSerializer.Serialize(new
            {
                bucketName = _bucketName,
                testFileKey,
            });
        }

        [Benchmark]
        public async Task S3_GetObject()
        {
            await LambdaUtilities.ExecuteFunction(lambdaClient, CurrentFunctionName, _payload);
        }

        [GlobalCleanup(Target = nameof(S3_GetObject))]
        public async Task CleanupForGetObject()
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
