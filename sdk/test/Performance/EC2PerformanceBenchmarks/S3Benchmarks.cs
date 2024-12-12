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

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using BenchmarkDotNet.Attributes;
using System.Text;

namespace AWSSDK.Benchmarks
{
    [MemoryDiagnoser]
    public class S3Benchmarks
    {
        private static string BasePath = Path.Combine(Path.GetTempPath(), "transferutility");
        private const string TestFile = "TestFile.txt";
        private string? _bucketName;
        private IAmazonS3? _s3Client;
        private ITransferUtility _transferClient;
        private GetObjectRequest? _getObjectRequest;
        private PutObjectRequest? _putObjectRequest;
        private static string FileName = Utils.GenerateName(@"S3Test\SmallFile");
        private static string FilePath = Path.Combine(BasePath, FileName);
        private string _transferUploadFullPath;
        private byte[] _data;
        private GetPreSignedUrlRequest _getPresignedUrlRequest;
        private TransferUtilityUploadRequest _transferUploadRequest;
        #region S3
        /// <summary>
        /// Benchmark dotnet does garbage collection after every benchmark so we have to new
        /// the clients and test resources every time
        /// </summary>
        public static void BaseClean(IDisposable client)
        {
            if (client != null)
            {
                client.Dispose();
            }
        }

        [GlobalSetup(Target = nameof(S3GetObjectAsync))]
        public async Task SetupForGetObject()
        {
            _s3Client = new AmazonS3Client();
            _bucketName = await Utils.CreateBucket(_s3Client).ConfigureAwait(false);
            long fileSize = Constants.KiloSize * 10;
            Utils.GenerateFile(FilePath, fileSize);
            var PutObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                FilePath = FilePath,
                Key = FilePath
            };
            await _s3Client.PutObjectAsync(PutObjectRequest).ConfigureAwait(false);
            _getObjectRequest = new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = FilePath
            };
        }

        /// <summary>
        /// Test GetObjectAsync on a 10KB File.
        /// </summary>
        [Benchmark]
        public async Task S3GetObjectAsync()
        {
            await _s3Client.GetObjectAsync(_getObjectRequest).ConfigureAwait(false);
        }

        [GlobalSetup(Target = nameof(S3PutObjectAsync))]
        public async Task SetupForPutObject()
        {
            _s3Client = new AmazonS3Client();
            _bucketName = await Utils.CreateBucket(_s3Client).ConfigureAwait(false);
            long fileSize = Constants.KiloSize * 10;
            Utils.GenerateFile(FilePath, fileSize);
            _putObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                FilePath = FilePath,
                Key = FilePath
            };
        }

        /// <summary>
        /// Test PutObjectAsync on a 10KB file. 
        /// </summary>
        [Benchmark]
        public async Task S3PutObjectAsync()
        {
            await _s3Client.PutObjectAsync(_putObjectRequest).ConfigureAwait(false);
        }

        [GlobalSetup(Target =nameof(S3GetPresignedUrl))]
        public async Task SetupForS3GetPresignedUrl()
        {
            _s3Client = new AmazonS3Client();
            _getPresignedUrlRequest = new GetPreSignedUrlRequest { BucketName = "FakeBucketName", Key = "foo", Expires = DateTime.UtcNow + TimeSpan.FromDays(2), Verb = HttpVerb.GET};
        }

        /// <summary>
        /// Test how long it takes to generate presignedUrl, to test a method with no network calls
        /// </summary>
        [Benchmark]
        public async Task S3GetPresignedUrl()
        {
            _s3Client.GetPreSignedURL(_getPresignedUrlRequest);
        }

        #endregion S3

        #region Transfer
        [GlobalSetup(Target = nameof(TransferUtilityUploadAsync))]
        public async Task SetupForTransferUtilityUpload()
        {
            _s3Client = new AmazonS3Client();
            _bucketName = await Utils.CreateBucket(_s3Client).ConfigureAwait(false);
            var transferUploadFile = Utils.GenerateName(@"ParallelUploadTests\BigFile");
            _transferUploadFullPath = Path.Combine(BasePath, transferUploadFile);
            Utils.GenerateFile(_transferUploadFullPath, Constants.MegSize * 100);
            _transferClient = new TransferUtility(_s3Client);
        }

        /// <summary>
        /// Test upload with Transfer Utility on a 100MB file.
        /// </summary>
        [Benchmark]
        [MinIterationCount(3), MaxIterationCount(20)]
        public async Task TransferUtilityUploadAsync()
        {
            await _transferClient.UploadAsync(_transferUploadFullPath, _bucketName).ConfigureAwait(false);
        }

        [GlobalSetup(Target = nameof(TransferUtilityUploadStreamAsync))]
        public async Task SetupForTestTransferUtilityUploadStream()
        {
            _s3Client = new AmazonS3Client();
            _bucketName = await Utils.CreateBucket(_s3Client).ConfigureAwait(false);
            int bufferSize = 100 * Constants.MegSize;
            _data = Encoding.UTF8.GetBytes(new string('A', bufferSize));
            _transferClient = new TransferUtility(_s3Client);
            var tempStream = new MemoryStream(_data);
            _transferUploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                AutoCloseStream = false,
                InputStream = tempStream,
                Key = "TestKey"
            };
        }

        /// <summary>
        /// Test uploading a 100MB stream using the Transfer Utility. 
        /// </summary>
        [Benchmark]
        [MinIterationCount(3), MaxIterationCount(20)]
        public async Task TransferUtilityUploadStreamAsync()
        {
            await _transferClient.UploadAsync(_transferUploadRequest);
        }

        [GlobalCleanup]
        public async Task Cleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_s3Client, _bucketName).ConfigureAwait(false);
            if (Directory.Exists(BasePath))
            {
                Directory.Delete(BasePath, true);
            }
        }
        #endregion
    }
}
