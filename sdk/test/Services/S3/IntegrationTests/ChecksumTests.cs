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
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.S3Control;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for putting flexible checksums to S3
    /// </summary>
    [TestClass]
    public class ChecksumTests : TestBase<AmazonS3Client>
    {
        private static string _bucketName;
        private static string _mrapArn;

        private static string _testContent = "Hello world";
        private const long MegSize = 1048576;

        private static IEnumerable<object[]> GetAlgorithmsToTest =>
            new List<object[]> {
                // TODO: Disabling CRT algorithms since we're still seeing issues with native dependencies in customer environments.
                //new object[] { CoreChecksumAlgorithm.CRC64NVME },
                //new object[] { CoreChecksumAlgorithm.CRC32C },

                new object[] { CoreChecksumAlgorithm.CRC32 },
                new object[] { CoreChecksumAlgorithm.SHA1 },
                new object[] { CoreChecksumAlgorithm.SHA256 }
            };

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _bucketName = S3TestUtils.CreateBucketWithWait(Client);
            _mrapArn = S3TestUtils.GetOrCreateTestMRAP(new AmazonS3ControlClient(RegionEndpoint.USWest2), Client);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            // Delete the objects in the MRAP bucket, but leave the
            // MRAP and bucket for future test runs
            S3TestUtils.DeleteObjects(Client, _mrapArn);

            // Delete the entire bucket used for the SigV4 tests
            AmazonS3Util.DeleteS3BucketWithObjects(Client, _bucketName);
        }

        /// <summary>
        /// Tests a SigV4 PutObject with the checksum placed in the header
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4SignedHeadersPut(CoreChecksumAlgorithm algorithm)
        {
            var putRequest = new PutObjectRequest()
            {
                BucketName = _bucketName,
                Key = $"sigv4-headers-{algorithm}",
                ContentBody = _testContent,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = false
            };

            PutAndGetChecksumTestHelper(algorithm, putRequest);
        }

        /// <summary>
        /// Tests a SigV4 PutObject with the checksum placed in the trailer
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4SignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            var putRequest = new PutObjectRequest()
            {
                BucketName = _bucketName,
                Key = $"sigv4-trailers-{algorithm}",
                ContentBody = _testContent,
                DisablePayloadSigning = false,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            };

            PutAndGetChecksumTestHelper(algorithm, putRequest);
        }

        /// <summary>
        /// Tests a SigV4 PutObject with an unsigned payload and the checksum in the trailer
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4UnsignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            var putRequest = new PutObjectRequest()
            {
                BucketName = _bucketName,
                Key = $"sigv4-unsignedcontent-trailers-{algorithm}",
                ContentBody = _testContent,
                DisablePayloadSigning = true,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            };

            PutAndGetChecksumTestHelper(algorithm, putRequest);
        }

        /// <summary>
        /// Tests a SigV4a PutObject with the checksum placed in the header
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4aSignedHeadersPut(CoreChecksumAlgorithm algorithm)
        {
            var putRequest = new PutObjectRequest()
            {
                BucketName = _mrapArn,
                Key = $"sigv4a-headers-{algorithm}",
                ContentBody = _testContent,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = false
            };

            PutAndGetChecksumTestHelper(algorithm, putRequest);
        }

        /// <summary>
        /// Tests a SigV4a PutObject with the checksum placed in the trailer
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4aSignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            var putRequest = new PutObjectRequest()
            {
                BucketName = _mrapArn,
                Key = $"sigv4a-trailers-{algorithm}",
                ContentBody = _testContent,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            };

            PutAndGetChecksumTestHelper(algorithm, putRequest);
        }

        /// <summary>
        /// Tests a SigV4a PutObject with an unsigned payload and the checksum in the trailer
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4aUnsignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            var putRequest = new PutObjectRequest()
            {
                BucketName = _mrapArn,
                Key = $"sigv4a-unsignedcontent-trailers-{algorithm}",
                ContentBody = _testContent,
                DisablePayloadSigning = true,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            };

            PutAndGetChecksumTestHelper(algorithm, putRequest);
        }

        /// <summary>
        /// Validates the PutObject request does not fail when adding the trailing header key for retried requests.
        /// </summary>
        /// <remarks>https://github.com/aws/aws-sdk-net/issues/3154</remarks>
        [TestMethod]
        [TestCategory("S3")]
        public void TestDuplicateTrailingHeaderKey()
        {
            var s3Config = new AmazonS3Config
            {
                // Unrealistic timeout so SDK will do a retry
                Timeout = TimeSpan.FromMilliseconds(1),
                RetryMode = RequestRetryMode.Standard,
                MaxErrorRetry = 1
            };

            using (var s3Client = new AmazonS3Client(s3Config))
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = "s3-retry-bug",
                    ContentBody = _testContent,
                    ChecksumAlgorithm = ChecksumAlgorithm.CRC32C,
                };

                // Due to the low timeout in the S3Config, we'll still get an exception but verify it's not the
                // "ArgumentException" reported in the GitHub issue.
                AssertExtensions.ExpectException<AmazonServiceException>(() => s3Client.PutObject(putObjectRequest));
            }
        }

        /// <summary>
        /// Validates when a pre-calculated checksum is provided, it's used instead of calculating a new value.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestPrecalculatedHeaderIsUsed()
        {
            var response = Client.PutObject(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = "test-file.txt",
                ContentBody = "Hello world",
                ChecksumSHA256 = "ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw="
            });

            Assert.IsNotNull(response.ChecksumSHA256);
            Assert.IsNull(response.ChecksumCRC32);
        }

        [TestCategory("S3")]
        [DataTestMethod]
        [DataRow(CoreChecksumAlgorithm.CRC64NVME)]
        [DataRow(CoreChecksumAlgorithm.CRC32C)]
        public void TestCrtChecksumIsCalculated(CoreChecksumAlgorithm algorithm)
        {
            var putResponse = Client.PutObject(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = $"test-file-{algorithm}.txt",
                ContentBody = "Hello world",
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
            });

            if (algorithm == CoreChecksumAlgorithm.CRC32C)
            {
                Assert.IsNotNull(putResponse.ChecksumCRC32C);
            }
            else if (algorithm == CoreChecksumAlgorithm.CRC64NVME)
            {
                Assert.IsNotNull(putResponse.ChecksumCRC64NVME);
            }
        }

        /// <summary>
        /// Puts and gets an object using a flexible checksum
        /// </summary>
        /// <param name="algorithm">Checksum algorithm to use</param>
        /// <param name="putRequest">PutObject request</param>
        private void PutAndGetChecksumTestHelper(CoreChecksumAlgorithm algorithm, PutObjectRequest putRequest)
        {
            Client.PutObject(putRequest);

            var getObjectAttributesRequest = new GetObjectAttributesRequest()
            {
                BucketName = putRequest.BucketName,
                Key = putRequest.Key,
                ObjectAttributes = new List<ObjectAttributes> { ObjectAttributes.Checksum }
            };

            var getObjectAttributesResponse = Client.GetObjectAttributes(getObjectAttributesRequest);
            Assert.IsNotNull(getObjectAttributesResponse);

            var getRequest = new GetObjectRequest
            {
                BucketName = putRequest.BucketName,
                Key = putRequest.Key,
                ChecksumMode = ChecksumMode.ENABLED
            };

            var response = Client.GetObject(getRequest);

            Assert.AreEqual(algorithm, response.ResponseMetadata.ChecksumAlgorithm);
            Assert.AreEqual(ChecksumValidationStatus.PENDING_RESPONSE_READ, response.ResponseMetadata.ChecksumValidationStatus);

            // Ensures checksum was calculated, an exception will have been thrown if it didn't match
            new StreamReader(response.ResponseStream).ReadToEnd();
            response.ResponseStream.Dispose();
        }

        /// <summary>
        /// Tests copying object using multipart upload with a signed body
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestSignedCopyObjectUsingMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            CopyObjectUsingMultipartTestHelper(algorithm, _bucketName);
        }

        /// <summary>
        /// Tests a SigV4 multipart upload with a signed body
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4SignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            MultipartTestHelper(algorithm, _bucketName, false);
        }

        /// <summary>
        /// Tests a SigV4 multipart upload with an unsigned body
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4UnsignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            MultipartTestHelper(algorithm, _bucketName, true);
        }

        /// <summary>
        /// Tests a SigV4a multipart upload with a signed body
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4aSignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            MultipartTestHelper(algorithm, _mrapArn, false);
        }

        /// <summary>
        /// Tests a SigV4a multipart upload with an unsigned body
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestV4aUnsignedMultipartUpload(CoreChecksumAlgorithm algorithm)
        {
            MultipartTestHelper(algorithm, _mrapArn, true);
        }

        /// <summary>
        /// Test helper to test copy object using multipart upload.
        /// </summary>
        /// <param name="algorithm">checksum algorithm</param>
        /// <param name="bucketName">bucket to upload the object to</param>
        private void CopyObjectUsingMultipartTestHelper(CoreChecksumAlgorithm algorithm, string bucketName)
        {
            var random = new Random();
            var nextRandom = random.Next();
            var filePath = Path.Combine(Path.GetTempPath(), "multipartcopy-" + nextRandom + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + nextRandom + ".txt");
            var totalSize = MegSize * 15;

            UtilityMethods.GenerateFile(filePath, totalSize);
            string sourceKey = "sourceKey-" + random.Next();
            string copiedKey = "sourceKey-" + random.Next() + "-copy";

            try
            {
                // Upload the source file for testing copy using multipartupload.
                var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
                var transfer = new TransferUtility(Client, transferConfig);
                transfer.Upload(new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = sourceKey,
                    FilePath = filePath
                });

                // Test copy using multipartupload with ChecksumAlgorithm set.
                List<CopyPartResponse> copyResponses = new List<CopyPartResponse>();
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = copiedKey,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                };

                InitiateMultipartUploadResponse initResponse = Client.InitiateMultipartUpload(initRequest);

                // Get the size of the object.
                GetObjectMetadataRequest metadataRequest = new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = sourceKey
                };

                GetObjectMetadataResponse metadataResponse = Client.GetObjectMetadata(metadataRequest);
                long objectSize = metadataResponse.ContentLength; // Length in bytes.

                // Copy the parts.
                long partSize = 5 * (long)Math.Pow(2, 20); // Part size is 5 MB.

                long bytePosition = 0;
                for (int i = 1; bytePosition < objectSize; i++)
                {
                    CopyPartRequest copyRequest = new CopyPartRequest
                    {
                        DestinationBucket = bucketName,
                        DestinationKey = copiedKey,
                        SourceBucket = bucketName,
                        SourceKey = sourceKey,
                        UploadId = initResponse.UploadId,
                        FirstByte = bytePosition,
                        LastByte = bytePosition + partSize - 1 >= objectSize ? objectSize - 1 : bytePosition + partSize - 1,
                        PartNumber = i
                    };

                    copyResponses.Add(Client.CopyPart(copyRequest));

                    bytePosition += partSize;
                }

                // Set up to complete the copy.
                CompleteMultipartUploadRequest completeRequest =
                new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = copiedKey,
                    UploadId = initResponse.UploadId
                };
                completeRequest.AddPartETagsAndChecksums(copyResponses);

                // Complete the copy.
                CompleteMultipartUploadResponse completeUploadResponse = Client.CompleteMultipartUpload(completeRequest);

                Assert.IsNotNull(completeUploadResponse.ETag);
                Assert.AreEqual(copiedKey, completeUploadResponse.Key);
                Assert.IsNotNull(completeUploadResponse.Location);

                // Get the file back from S3 and assert it is still the same.
                var getRequest = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = copiedKey
                };

                var getResponse = Client.GetObject(getRequest);
                getResponse.WriteResponseStreamToFile(retrievedFilepath);
                UtilityMethods.CompareFiles(filePath, retrievedFilepath);
            }
            finally
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (File.Exists(retrievedFilepath))
                    File.Delete(retrievedFilepath);
            }
        }

        /// <summary>
        /// Test helper to test a multipart upload without using the Transfer Utility
        /// </summary>
        /// <param name="algorithm">checksum algorithm</param>
        /// <param name="bucketName">bucket to upload the object to</param>
        /// <param name="disablePayloadSigning">whether the request payload should be signed</param>
        private void MultipartTestHelper(CoreChecksumAlgorithm algorithm, string bucketName, bool disablePayloadSigning)
        {
            var random = new Random();
            var nextRandom = random.Next();
            var filePath = Path.Combine(Path.GetTempPath(), "multi-" + nextRandom + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + nextRandom + ".txt");
            var totalSize = MegSize * 15;

            UtilityMethods.GenerateFile(filePath, totalSize);
            string key = "sourceKey-" + random.Next();

            Stream inputStream = File.OpenRead(filePath);
            try
            {
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                };

                InitiateMultipartUploadResponse initResponse = Client.InitiateMultipartUpload(initRequest);

                // Upload part 1
                UploadPartRequest uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * MegSize,
                    InputStream = inputStream,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                    DisablePayloadSigning = disablePayloadSigning
                };
                UploadPartResponse up1Response = Client.UploadPart(uploadRequest);

                // Upload part 2
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * MegSize,
                    InputStream = inputStream,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                    DisablePayloadSigning = disablePayloadSigning
                };

                UploadPartResponse up2Response = Client.UploadPart(uploadRequest);

                // Upload part 3
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                    DisablePayloadSigning = disablePayloadSigning,
                    IsLastPart = true
                };

                UploadPartResponse up3Response = Client.UploadPart(uploadRequest);

                ListPartsRequest listPartRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };

                ListPartsResponse listPartResponse = Client.ListParts(listPartRequest);
                Assert.AreEqual(3, listPartResponse.Parts.Count);
                AssertPartsAreEqual(up1Response, listPartResponse.Parts[0]);
                AssertPartsAreEqual(up2Response, listPartResponse.Parts[1]);
                AssertPartsAreEqual(up3Response, listPartResponse.Parts[2]);

                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETagsAndChecksums(up1Response, up2Response, up3Response);

                CompleteMultipartUploadResponse compResponse = Client.CompleteMultipartUpload(compRequest);
                Assert.IsNotNull(compResponse.ETag);
                Assert.AreEqual(key, compResponse.Key);
                Assert.IsNotNull(compResponse.Location);

                // Get the file back from S3 and assert it is still the same.
                var getRequest = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ChecksumMode = ChecksumMode.ENABLED
                };

                var getResponse = Client.GetObject(getRequest);
                getResponse.WriteResponseStreamToFile(retrievedFilepath);
                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                // We don't expect the checksum to be validated on getting an entire multipart object,
                // because it's actually the checksum-of-checksums (except for CRC64).
                if (algorithm == CoreChecksumAlgorithm.CRC64NVME)
                {
                    Assert.AreEqual(CoreChecksumAlgorithm.CRC64NVME, getResponse.ResponseMetadata.ChecksumAlgorithm);
                }
                else
                {
                    Assert.AreEqual(CoreChecksumAlgorithm.NONE, getResponse.ResponseMetadata.ChecksumAlgorithm);
                    Assert.AreEqual(ChecksumValidationStatus.NOT_VALIDATED, getResponse.ResponseMetadata.ChecksumValidationStatus);
                }
            }
            finally
            {
                inputStream.Close();
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (File.Exists(retrievedFilepath))
                    File.Delete(retrievedFilepath);
            }
        }

        /// <summary>
        /// Helper to assert that uploaded parts have the same checksum as listed parts.
        /// Genearlly only one checksum is expected to be set.
        /// </summary>
        /// <param name="uploadPartResponse">Response after uploading a part</param>
        /// <param name="partDetail">Response for a single part after listing parts</param>
        private static void AssertPartsAreEqual(UploadPartResponse uploadPartResponse, PartDetail partDetail)
        {
            Assert.AreEqual(uploadPartResponse.PartNumber, partDetail.PartNumber);
            Assert.AreEqual(uploadPartResponse.ETag, partDetail.ETag);
            Assert.AreEqual(uploadPartResponse.ChecksumCRC32C, partDetail.ChecksumCRC32C);
            Assert.AreEqual(uploadPartResponse.ChecksumCRC32, partDetail.ChecksumCRC32);
            Assert.AreEqual(uploadPartResponse.ChecksumSHA1, partDetail.ChecksumSHA1);
            Assert.AreEqual(uploadPartResponse.ChecksumSHA256, partDetail.ChecksumSHA256);
        }

        [TestMethod]
        [TestCategory("S3")]
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestMultipartUploadViaTransferUtility(CoreChecksumAlgorithm algorithm)
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 7000000);
            var key = UtilityMethods.GenerateName(nameof(ChecksumTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + key + ".txt");

            try
            {
                // Create the file
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Write(content);
                }

                var uploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    FilePath = filePath,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                };

                transfer.Upload(uploadRequest);

                // Get the file back from S3 and assert it is still the same.
                GetObjectRequest getRequest = new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    ChecksumMode = ChecksumMode.ENABLED
                };

                var getResponse = Client.GetObject(getRequest);
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);

                // We don't expect the checksum to be validated on getting an entire multipart object,
                // because it's actually the checksum-of-checksums (except for CRC64).
                if (algorithm == CoreChecksumAlgorithm.CRC64NVME)
                {
                    Assert.AreEqual(CoreChecksumAlgorithm.CRC64NVME, getResponse.ResponseMetadata.ChecksumAlgorithm);
                }
                else
                {
                    Assert.AreEqual(CoreChecksumAlgorithm.NONE, getResponse.ResponseMetadata.ChecksumAlgorithm);
                    Assert.AreEqual(ChecksumValidationStatus.NOT_VALIDATED, getResponse.ResponseMetadata.ChecksumValidationStatus);
                }

                // At the moment, S3 does not store the checksums for individual parts when using CRC64NVME.
                // The full object checksum can be retrieved using GetObject or HeadObject instead.
                if (algorithm != CoreChecksumAlgorithm.CRC64NVME)
                {
                    // Get the object attributes. Parts collection in ObjectParts is only returned if ChecksumAlgorithm is set different from default value.
                    GetObjectAttributesRequest getObjectAttributesRequest = new GetObjectAttributesRequest()
                    {
                        BucketName = _bucketName,
                        Key = uploadRequest.Key,
                        ObjectAttributes = new List<ObjectAttributes>()
                        {
                            new ObjectAttributes("Checksum"),
                            new ObjectAttributes("ObjectParts"),
                            new ObjectAttributes("ObjectSize")
                        }
                    };

                    GetObjectAttributesResponse getObjectAttributesResponse = Client.GetObjectAttributes(getObjectAttributesRequest);
                    Assert.IsTrue(getObjectAttributesResponse.ObjectParts.Parts.Count > 0);
                    // Number of Parts returned is controlled by GetObjectAttributesRequest.MaxParts.
                    Assert.AreEqual(getObjectAttributesResponse.ObjectParts.Parts.Count, getObjectAttributesResponse.ObjectParts.TotalPartsCount);

                    var firstObjectPart = getObjectAttributesResponse.ObjectParts.Parts.First();
                    ChecksumAlgorithm expectedChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString());
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.CRC32)
                    {
                        Assert.IsNotNull(firstObjectPart.ChecksumCRC32);
                    }
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.CRC32C)
                    {
                        Assert.IsNotNull(firstObjectPart.ChecksumCRC32C);
                    }
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.SHA1)
                    {
                        Assert.IsNotNull(firstObjectPart.ChecksumSHA1);
                    }
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.SHA256)
                    {
                        Assert.IsNotNull(firstObjectPart.ChecksumSHA256);
                    }
                    Assert.AreEqual(1, firstObjectPart.PartNumber);
                    Assert.IsTrue(firstObjectPart.Size > 0);
                }

                // Similarily we don't expect this to validate either,
                // though it doesn't expose the reponse metadata
                transfer.Download(new TransferUtilityDownloadRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    FilePath = retrievedFilepath,
                    ChecksumMode = ChecksumMode.ENABLED
                });
            }
            finally
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (File.Exists(retrievedFilepath))
                    File.Delete(retrievedFilepath);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [DataTestMethod]
        [DynamicData(nameof(GetAlgorithmsToTest))]
        public void TestSingleUploadViaTransferUtility(CoreChecksumAlgorithm algorithm)
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 5000000);
            var key = UtilityMethods.GenerateName(nameof(ChecksumTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + key + ".txt");

            try
            {
                // Create the file
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Write(content);
                }

                var uploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    FilePath = filePath,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                };

                transfer.Upload(uploadRequest);

                // Get the file back from S3 and assert it is still the same.
                var getRequest = new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    ChecksumMode = ChecksumMode.ENABLED
                };

                var getResponse = Client.GetObject(getRequest);
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);

                Assert.AreEqual(algorithm.ToString(), getResponse.ResponseMetadata.ChecksumAlgorithm.ToString(), true);
                Assert.AreEqual(ChecksumValidationStatus.PENDING_RESPONSE_READ, getResponse.ResponseMetadata.ChecksumValidationStatus);

                // This should validate the checksum, so "assert" that no exceptions are thrown,
                // though it doesn't expose the response metadata like above
                transfer.Download(new TransferUtilityDownloadRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    FilePath = retrievedFilepath,
                    ChecksumMode = ChecksumMode.ENABLED
                });
            }
            finally
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (File.Exists(retrievedFilepath))
                    File.Delete(retrievedFilepath);
            }
        }

        // When the user sets ResponseChecksumValidation to WHEN_SUPPORTED, and the user has set the requestValidationModeMember to ENABLED, assert that the response checksum is validated.
        [DataRow(ResponseChecksumValidation.WHEN_SUPPORTED, true, true)]
        // When the user sets ResponseChecksumValidation to WHEN_SUPPORTED, and the user has NOT set the requestValidationModeMember to ENABLED, assert that the response checksum is validated.
        [DataRow(ResponseChecksumValidation.WHEN_SUPPORTED, false, true)]
        // When the user sets ResponseChecksumValidation to WHEN_REQUIRED, and the user has set the requestValidationModeMember to ENABLED, assert that the response checksum is validated.
        [DataRow(ResponseChecksumValidation.WHEN_REQUIRED, true, true)]
        // When the user sets ResponseChecksumValidation to WHEN_REQUIRED, and the user has NOT set the requestValidationModeMember to ENABLED, assert that the response checksum is NOT validated.
        [DataRow(ResponseChecksumValidation.WHEN_REQUIRED, false, false)]
        [DataTestMethod]
        public void TestResponseChecksumValidation(ResponseChecksumValidation responseChecksumValidation, bool enableChecksumMode, bool isChecksumAlgorithmSet)
        {
            var s3Config = new AmazonS3Config
            {
                ResponseChecksumValidation = responseChecksumValidation,
            };

            using (var s3Client = new AmazonS3Client(s3Config))
            {
                var key = UtilityMethods.GenerateName(nameof(ChecksumTests));
                var putRequest = new PutObjectRequest()
                {
                    BucketName = _bucketName,
                    Key = key,
                    ContentBody = _testContent,
                };

                s3Client.PutObject(putRequest);

                var getRequest = new GetObjectRequest
                {
                    BucketName = putRequest.BucketName,
                    Key = putRequest.Key,
                };
                if (enableChecksumMode)
                    getRequest.ChecksumMode = ChecksumMode.ENABLED;

                var response = s3Client.GetObject(getRequest);

                Assert.AreEqual(response.ResponseMetadata.ChecksumAlgorithm == CoreChecksumAlgorithm.NONE, !isChecksumAlgorithmSet);
            }
        }
    }
}
