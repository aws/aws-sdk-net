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
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for the TransferUtility upload operations on S3 bucket with object lock and data governance enabled.
    /// </summary>
    [TestClass]
    public class TransferUtilityObjectLockMD5Tests : TestBase<AmazonS3Client>
    {
        private static string bucketName;

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            CreateBucketWithObjectLockConfiguration();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            DeleteBucketObjectsIncludingLocked(Client, bucketName);
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);

            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestMultipartUploadStreamViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 7000000);
            var contentStream = new MemoryStream(Encoding.UTF8.GetBytes(content));

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests)),
                InputStream = contentStream
            };

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestMultipartUploadFileViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 7000000);
            var key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");

            // Create the file
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(content);
            }

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSimpleUploadStreamViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 2000000);
            var contentStream = new MemoryStream(Encoding.UTF8.GetBytes(content));

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests)),
                InputStream = contentStream,
            };

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSimpleUploadStreamViaTransferUtility_ExplicitMD5()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 2000000);
            var contentStream = new MemoryStream(Encoding.UTF8.GetBytes(content));

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests)),
                InputStream = contentStream,
            };
            uploadRequest.Headers.ContentMD5 = AWSSDKUtils.GenerateMD5ChecksumForStream(contentStream);

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSimpleUploadFileViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 2000000);
            var key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");

            // Create the file
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(content);
            }

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSimpleUploadFileViaTransferUtility_ExplicitMD5()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 2000000);
            var key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");

            // Create the file
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(content);
            }

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            using (FileStream fileStream = File.OpenRead(filePath))
            {
                uploadRequest.Headers.ContentMD5 = AWSSDKUtils.GenerateMD5ChecksumForStream(fileStream);
            }

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestUploadDirectoryViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var directoryKey = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var directoryPath = Path.Combine(Path.GetTempPath(), directoryKey);
            Dictionary<string, int> filesWithSize = new Dictionary<string, int>() {
                { directoryKey + "_1.txt", 7000000}, // MultipartUpload
                { directoryKey + "_2.txt", 2000000}, // SimpleUpload
                { directoryKey + "_3.txt", 4000000}, // SimpleUpload
            };

            // Create directory with files.
            Directory.CreateDirectory(directoryPath);
            foreach (var file in filesWithSize)
            {
                var filePath = Path.Combine(directoryPath, file.Key);
                var content = new string('a', file.Value);
                // Create the file
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Write(content);
                }
            }

            var uploadDirectoryRequest = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath
            };

            transfer.UploadDirectory(uploadDirectoryRequest);

            // Verify the files
            foreach (var file in filesWithSize)
            {
                using (var getResponse = Client.GetObject(bucketName, file.Key))
                {
                    var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                    Assert.AreEqual(new string('a', file.Value), getBody);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSimpleUploadFileWithObjectLockViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 2000000);
            var key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");

            // NOTE: In ObjectLockMode.Compliance mode, a protected object version can't be deleted by any user, including the root user (refer https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock-overview.html#object-lock-retention-modes).
            ObjectLockLegalHoldStatus desiredObjectLockLegalHoldStatus = ObjectLockLegalHoldStatus.Off;
            ObjectLockMode desiredObjectLockMode = ObjectLockMode.Governance;
            DateTime desiredObjectLockRetainUntilDate = DateTime.UtcNow.Date.AddDays(5);

            // Create the file
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(content);
            }

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
                ObjectLockLegalHoldStatus = desiredObjectLockLegalHoldStatus,
                ObjectLockMode = desiredObjectLockMode,
                ObjectLockRetainUntilDate = desiredObjectLockRetainUntilDate
            };

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
                Assert.AreEqual(desiredObjectLockLegalHoldStatus, getResponse.ObjectLockLegalHoldStatus);
                Assert.AreEqual(desiredObjectLockMode, getResponse.ObjectLockMode);
                Assert.AreEqual(desiredObjectLockRetainUntilDate.Date, getResponse.ObjectLockRetainUntilDate.Value.ToUniversalTime().Date);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestUploadDirectoryWithObjectLockViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var directoryKey = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var directoryPath = Path.Combine(Path.GetTempPath(), directoryKey);
            Dictionary<string, int> filesWithSize = new Dictionary<string, int>() {
                { directoryKey + "_1.txt", 7000000}, // MultipartUpload
                { directoryKey + "_2.txt", 2000000}, // SimpleUpload
                { directoryKey + "_3.txt", 4000000}, // SimpleUpload
            };

            // NOTE: In ObjectLockMode.Compliance mode, a protected object version can't be deleted by any user, including the root user (refer https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock-overview.html#object-lock-retention-modes).
            ObjectLockLegalHoldStatus desiredObjectLockLegalHoldStatus = ObjectLockLegalHoldStatus.Off;
            ObjectLockMode desiredObjectLockMode = ObjectLockMode.Governance;
            DateTime desiredObjectLockRetainUntilDate = DateTime.UtcNow.Date.AddDays(5);

            // Create directory with files.
            Directory.CreateDirectory(directoryPath);
            foreach (var file in filesWithSize)
            {
                var filePath = Path.Combine(directoryPath, file.Key);
                var content = new string('a', file.Value);
                // Create the file
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.Write(content);
                }
            }

            var uploadDirectoryRequest = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath,
                ObjectLockLegalHoldStatus = desiredObjectLockLegalHoldStatus,
                ObjectLockMode = desiredObjectLockMode,
                ObjectLockRetainUntilDate = desiredObjectLockRetainUntilDate
            };

            transfer.UploadDirectory(uploadDirectoryRequest);

            // Verify the files
            foreach (var file in filesWithSize)
            {
                using (var getResponse = Client.GetObject(bucketName, file.Key))
                {
                    var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                    Assert.AreEqual(new string('a', file.Value), getBody);
                    Assert.AreEqual(desiredObjectLockLegalHoldStatus, getResponse.ObjectLockLegalHoldStatus);
                    Assert.AreEqual(desiredObjectLockMode, getResponse.ObjectLockMode);
                    Assert.AreEqual(desiredObjectLockRetainUntilDate.Date, getResponse.ObjectLockRetainUntilDate.Value.ToUniversalTime().Date);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestMultipartUploadFileWithObjectLockViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 7000000);
            var key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");

            // NOTE: In ObjectLockMode.Compliance mode, a protected object version can't be deleted by any user, including the root user (refer https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock-overview.html#object-lock-retention-modes).
            ObjectLockLegalHoldStatus desiredObjectLockLegalHoldStatus = ObjectLockLegalHoldStatus.Off;
            ObjectLockMode desiredObjectLockMode = ObjectLockMode.Governance;
            DateTime desiredObjectLockRetainUntilDate = DateTime.UtcNow.Date.AddDays(5);

            // Create the file
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(content);
            }

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
                ObjectLockLegalHoldStatus = desiredObjectLockLegalHoldStatus,
                ObjectLockMode = desiredObjectLockMode,
                ObjectLockRetainUntilDate = desiredObjectLockRetainUntilDate
            };

            transfer.Upload(uploadRequest);

            using (var getResponse = Client.GetObject(bucketName, uploadRequest.Key))
            {
                var getBody = new StreamReader(getResponse.ResponseStream).ReadToEnd();
                Assert.AreEqual(content, getBody);
                Assert.AreEqual(desiredObjectLockLegalHoldStatus, getResponse.ObjectLockLegalHoldStatus);
                Assert.AreEqual(desiredObjectLockMode, getResponse.ObjectLockMode);
                Assert.AreEqual(desiredObjectLockRetainUntilDate.Date, getResponse.ObjectLockRetainUntilDate.Value.ToUniversalTime().Date);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSimpleUploadFileWithoutMD5ViaTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };

            var transfer = new TransferUtility(Client, transferConfig);
            var content = new string('a', 2000000);
            var key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");

            // Create the file
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(content);
            }

            // Upload should still succeed without MD5 (as the SDK is calculating CRC checksums by default).
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            transfer.Upload(uploadRequest);
        }

        private static void CreateBucketWithObjectLockConfiguration()
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client, new PutBucketRequest
            {
                ObjectLockEnabledForBucket = true,
            });

            var objectLockConfiguration = new ObjectLockConfiguration();
            objectLockConfiguration.ObjectLockEnabled = ObjectLockEnabled.Enabled;
            objectLockConfiguration.Rule = new ObjectLockRule
            {
                DefaultRetention = new DefaultRetention
                {
                    Days = 1,
                    Mode = ObjectLockRetentionMode.Governance
                }
            };

            var putRequest = new PutObjectLockConfigurationRequest
            {
                BucketName = bucketName,
                RequestPayer = RequestPayer.Requester,
                ObjectLockConfiguration = objectLockConfiguration
            };

            var putResponse = Client.PutObjectLockConfiguration(putRequest);
        }

        private static void DeleteBucketObjectsIncludingLocked(IAmazonS3 s3Client, string bucketName)
        {
            var listVersionsRequest = new ListVersionsRequest
            {
                BucketName = bucketName
            };

            ListVersionsResponse listVersionsResponse;

            // Iterate through the objects in the bucket and delete them.
            do
            {
                // List all the versions of all the objects in the bucket.
                listVersionsResponse = s3Client.ListVersions(listVersionsRequest);

                if (listVersionsResponse.Versions.Count == 0)
                {
                    // If the bucket has no objects break the loop.
                    break;
                }

                var keyVersionList = new List<KeyVersion>(listVersionsResponse.Versions.Count);
                for (int index = 0; index < listVersionsResponse.Versions.Count; index++)
                {
                    keyVersionList.Add(new KeyVersion
                    {
                        Key = listVersionsResponse.Versions[index].Key,
                        VersionId = listVersionsResponse.Versions[index].VersionId
                    });
                }

                try
                {
                    // Delete the current set of objects.
                    var deleteObjectsResponse = s3Client.DeleteObjects(new DeleteObjectsRequest
                    {
                        BucketName = bucketName,
                        Objects = keyVersionList,
                        BypassGovernanceRetention = true
                    });
                }
                catch
                {
                }

                // Set the markers to get next set of objects from the bucket.
                listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;

            }
            // Continue listing objects and deleting them until the bucket is empty.
            while (listVersionsResponse.IsTruncated.Value);
        }
    }
}