using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.S3;
using Amazon.S3.Encryption;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.Runtime.Internal;


namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class EncryptionTests
    {
        private static Random random = new Random();
        private static string bucketName;
        private static string fileName = "PutObjectFile.txt";
        private static string sampleContent = "Encryption Client Testing!";

        private static AmazonS3EncryptionClient s3EncryptionClientMetadataMode;
        private static AmazonS3EncryptionClient s3EncryptionClientFileMode;
        private static EncryptionMaterials encryptionMaterials = new EncryptionMaterials(CreateAsymmetricProvider());

        [ClassInitialize]
        public static void Initialize(TestContext a)
        {
            s3EncryptionClientMetadataMode = new AmazonS3EncryptionClient(encryptionMaterials);
            RetryUtilities.ForceConfigureClient(s3EncryptionClientMetadataMode);            

            AmazonS3CryptoConfiguration config = new AmazonS3CryptoConfiguration()
            {
                StorageMode = CryptoStorageMode.InstructionFile
            };
            s3EncryptionClientFileMode = new AmazonS3EncryptionClient(config, encryptionMaterials);
            RetryUtilities.ForceConfigureClient(s3EncryptionClientFileMode);            


            using (StreamWriter writer = File.CreateText(fileName))
            {
                writer.Write(sampleContent);
            }
            bucketName = S3TestUtils.CreateBucket(s3EncryptionClientFileMode);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(s3EncryptionClientMetadataMode, bucketName);
            s3EncryptionClientMetadataMode.Dispose();
            s3EncryptionClientFileMode.Dispose();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetFileUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetFileUsingMetadataMode" + random.Next(),
                FilePath = fileName
            };

            PutObjectResponse response = s3EncryptionClientMetadataMode.PutObject(request);

            TestGet(request.Key, File.ReadAllText(fileName), s3EncryptionClientMetadataMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetFileUsingInstructionFileMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetFileUsingInstructionFileMode" + random.Next(),
                FilePath = fileName
            };

            PutObjectResponse response = s3EncryptionClientFileMode.PutObject(request);

            TestGet(request.Key, File.ReadAllText(fileName), s3EncryptionClientFileMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetStreamUsingMetadataMode()
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(sampleContent);
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetStreamUsingMeatadaMode" + random.Next(),
                InputStream = new MemoryStream(dataBytes)
            };

            PutObjectResponse response = s3EncryptionClientMetadataMode.PutObject(request);

            TestGet(request.Key, sampleContent, s3EncryptionClientMetadataMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetStreamUsingInstructionFileMode()
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(sampleContent);
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetStreamUsingMeatadaMode" + random.Next(),
                InputStream = new MemoryStream(dataBytes)
            };

            PutObjectResponse response = s3EncryptionClientFileMode.PutObject(request);

            TestGet(request.Key, sampleContent, s3EncryptionClientFileMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetContentUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                ContentBody = "Encryption Client Testing!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = s3EncryptionClientMetadataMode.PutObject(request);

            TestGet(request.Key, request.ContentBody, s3EncryptionClientMetadataMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetZeroLengthContentUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                ContentBody = "",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = s3EncryptionClientMetadataMode.PutObject(request);

            TestGet(request.Key, request.ContentBody, s3EncryptionClientMetadataMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetNullContentContentUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = s3EncryptionClientMetadataMode.PutObject(request);

            TestGet(request.Key, "", s3EncryptionClientMetadataMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutGetContentUsingInstructionFileMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                ContentBody = "Encryption Client Testing!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = s3EncryptionClientFileMode.PutObject(request);

            TestGet(request.Key, request.ContentBody, s3EncryptionClientFileMode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void MultipartEncryptionTestMetadataMode()
        {
            string filePath = @"C:\coderepo\multi.txt";
            string retrievedFilepath = @"C:\coderepo\retreived.txt";
            int MEG_SIZE = (int)Math.Pow(2, 20);
            long totalSize = (long)(15 * MEG_SIZE);
            UtilityMethods.GenerateFile(filePath, totalSize);

            string key = "MultipartEncryptionTestMetadataMode" + random.Next();

            s3EncryptionClientMetadataMode.PutBucket(new PutBucketRequest() { BucketName = bucketName });

            Stream inputStream = File.OpenRead(filePath);
            try
            {
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    StorageClass = S3StorageClass.ReducedRedundancy,
                    ContentType = "text/html",
                    CannedACL = S3CannedACL.PublicRead
                };

                InitiateMultipartUploadResponse initResponse = s3EncryptionClientMetadataMode.InitiateMultipartUpload(initRequest);

                // Upload part 1
                UploadPartRequest uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * MEG_SIZE,
                    InputStream = inputStream,
                };

                UploadPartResponse up1Response = s3EncryptionClientMetadataMode.UploadPart(uploadRequest);

                // Upload part 2
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * MEG_SIZE,
                    InputStream = inputStream,
                };

                UploadPartResponse up2Response = s3EncryptionClientMetadataMode.UploadPart(uploadRequest);

                // Upload part 3
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream,
                    IsLastPart = true
                };

                UploadPartResponse up3Response = s3EncryptionClientMetadataMode.UploadPart(uploadRequest);

                ListPartsRequest listPartRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };

                ListPartsResponse listPartResponse = s3EncryptionClientMetadataMode.ListParts(listPartRequest);
                Assert.AreEqual(3, listPartResponse.Parts.Count);
                Assert.AreEqual(up1Response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.AreEqual(up1Response.ETag, listPartResponse.Parts[0].ETag);
                Assert.AreEqual(up2Response.PartNumber, listPartResponse.Parts[1].PartNumber);
                Assert.AreEqual(up2Response.ETag, listPartResponse.Parts[1].ETag);
                Assert.AreEqual(up3Response.PartNumber, listPartResponse.Parts[2].PartNumber);
                Assert.AreEqual(up3Response.ETag, listPartResponse.Parts[2].ETag);

                listPartRequest.MaxParts = 1;
                listPartResponse = s3EncryptionClientMetadataMode.ListParts(listPartRequest);
                Assert.AreEqual(1, listPartResponse.Parts.Count);

                // Complete the response
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(up1Response, up2Response, up3Response);

                CompleteMultipartUploadResponse compResponse = s3EncryptionClientMetadataMode.CompleteMultipartUpload(compRequest);
                Assert.AreEqual(bucketName, compResponse.BucketName);
                Assert.IsNotNull(compResponse.ETag);
                Assert.AreEqual(key, compResponse.Key);
                Assert.IsNotNull(compResponse.Location);

                // Get the file back from S3 and make sure it is still the same.
                GetObjectRequest getRequest = new GetObjectRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };

                GetObjectResponse getResponse = s3EncryptionClientMetadataMode.GetObject(getRequest);
                getResponse.WriteResponseStreamToFile(retrievedFilepath);

                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                GetObjectMetadataRequest metaDataRequest = new GetObjectMetadataRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };
                GetObjectMetadataResponse metaDataResponse = s3EncryptionClientMetadataMode.GetObjectMetadata(metaDataRequest);
                Assert.AreEqual("text/html", metaDataResponse.Headers.ContentType);
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

        [TestMethod]
        [TestCategory("S3")]
        public void MultipartEncryptionTestInstructionFile()
        {
            string filePath = @"C:\temp\Upload15MegFileIn3PartsViaStream.txt";
            string retrievedFilepath = @"C:\temp\Upload15MegFileIn3PartsViaStreamRetreived.txt";
            int MEG_SIZE = (int)Math.Pow(2, 20) + 4001;
            long totalSize = (long)(15 * MEG_SIZE);
            UtilityMethods.GenerateFile(filePath, totalSize);

            string key = "MultipartEncryptionTestInstrcutionFile" + random.Next();

            s3EncryptionClientFileMode.PutBucket(new PutBucketRequest() { BucketName = bucketName });

            Stream inputStream = File.OpenRead(filePath);
            try
            {
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    StorageClass = S3StorageClass.ReducedRedundancy,
                    ContentType = "text/html",
                    CannedACL = S3CannedACL.PublicRead
                };

                InitiateMultipartUploadResponse initResponse = s3EncryptionClientFileMode.InitiateMultipartUpload(initRequest);

                // Upload part 1
                UploadPartRequest uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * MEG_SIZE,
                    InputStream = inputStream
                };

                UploadPartResponse up1Response = s3EncryptionClientFileMode.UploadPart(uploadRequest);

                // Upload part 2
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * MEG_SIZE + 4001,
                    InputStream = inputStream
                };

                UploadPartResponse up2Response = s3EncryptionClientFileMode.UploadPart(uploadRequest);

                // Upload part 3
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream,
                    IsLastPart = true
                };

                //uploadRequest.setLastPart();
                UploadPartResponse up3Response = s3EncryptionClientFileMode.UploadPart(uploadRequest);


                ListPartsRequest listPartRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };

                ListPartsResponse listPartResponse = s3EncryptionClientFileMode.ListParts(listPartRequest);
                Assert.AreEqual(3, listPartResponse.Parts.Count);
                Assert.AreEqual(up1Response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.AreEqual(up1Response.ETag, listPartResponse.Parts[0].ETag);
                Assert.AreEqual(up2Response.PartNumber, listPartResponse.Parts[1].PartNumber);
                Assert.AreEqual(up2Response.ETag, listPartResponse.Parts[1].ETag);
                Assert.AreEqual(up3Response.PartNumber, listPartResponse.Parts[2].PartNumber);
                Assert.AreEqual(up3Response.ETag, listPartResponse.Parts[2].ETag);

                listPartRequest.MaxParts = 1;
                listPartResponse = s3EncryptionClientFileMode.ListParts(listPartRequest);
                Assert.AreEqual(1, listPartResponse.Parts.Count);

                // Complete the response
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(up1Response, up2Response, up3Response);

                CompleteMultipartUploadResponse compResponse = s3EncryptionClientFileMode.CompleteMultipartUpload(compRequest);
                Assert.AreEqual(bucketName, compResponse.BucketName);
                Assert.IsNotNull(compResponse.ETag);
                Assert.AreEqual(key, compResponse.Key);
                Assert.IsNotNull(compResponse.Location);

                // Get the file back from S3 and make sure it is still the same.
                GetObjectRequest getRequest = new GetObjectRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };

                GetObjectResponse getResponse = s3EncryptionClientFileMode.GetObject(getRequest);
                getResponse.WriteResponseStreamToFile(retrievedFilepath);

                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                GetObjectMetadataRequest metaDataRequest = new GetObjectMetadataRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };
                GetObjectMetadataResponse metaDataResponse = s3EncryptionClientFileMode.GetObjectMetadata(metaDataRequest);
                Assert.AreEqual("text/html", metaDataResponse.Headers.ContentType);
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

        private static void TestGet(string key, string uploadedData, AmazonS3EncryptionClient s3EncryptionClient)
        {
            GetObjectRequest getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };

            using (GetObjectResponse getObjectResponse = s3EncryptionClient.GetObject(getObjectRequest))
            {
                using (var stream = getObjectResponse.ResponseStream)
                using (var reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    Assert.AreEqual(uploadedData, data);
                }
            }
        }

        private static void TestGet2(string key, string uploadedFile, AmazonS3EncryptionClient s3EncryptionClient)
        {
            GetObjectRequest getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };

            var destinationFile = fileName + ".downloaded";
            using (GetObjectResponse getObjectResponse = s3EncryptionClient.GetObject(getObjectRequest))
            {
                getObjectResponse.WriteResponseStreamToFile(destinationFile);
            }

            var originalMd5 = HashFile(uploadedFile);
            var downloadedMd5 = HashFile(destinationFile);
            Assert.AreEqual(originalMd5, downloadedMd5);
        }

        private static string HashFile(string file)
        {
            var md5 = MD5.Create();
            using(var stream = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                var hashBytes = md5.ComputeHash(stream);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private static RSA CreateAsymmetricProvider()
        {
            RSA rsaProvider = RSA.Create();
            return rsaProvider;
        }

        private static Aes CreateSymmetricKey()
        {
            Aes aesAlg = Aes.Create();
            return aesAlg;
        }
    }
}
