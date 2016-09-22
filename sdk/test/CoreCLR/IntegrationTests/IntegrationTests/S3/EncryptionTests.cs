using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Encryption;
using Amazon.S3.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;

using Xunit;


namespace Amazon.DNXCore.IntegrationTests.S3
{
    public class EncryptionTests : TestBase<AmazonS3Client>
    {
        private static Random random = new Random();
        private static string bucketName;
        private string filePath = "";
        private static string sampleContent = "Encryption Client Testing!";

        private static AmazonS3EncryptionClient s3EncryptionClientMetadataMode;
        private static AmazonS3EncryptionClient s3EncryptionClientFileMode;
        private static EncryptionMaterials encryptionMaterials = new EncryptionMaterials(CreateAsymmetricProvider());

        private List<string> _filesToDelete = new List<string>();

        public EncryptionTests()
        {
            s3EncryptionClientMetadataMode = new AmazonS3EncryptionClient(encryptionMaterials);

            AmazonS3CryptoConfiguration config = new AmazonS3CryptoConfiguration()
            {
                StorageMode = CryptoStorageMode.InstructionFile
            };
            s3EncryptionClientFileMode = new AmazonS3EncryptionClient(config, encryptionMaterials);


            filePath = Path.Combine(Path.GetTempPath(), "EncryptionPutObjectFile.txt");
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.Write(sampleContent);
            }
            _filesToDelete.Add(filePath);

            bucketName = UtilityMethods.CreateBucketAsync(s3EncryptionClientFileMode, "EncryptionTests").Result;
        }

        protected override void Dispose(bool disposing) 
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(s3EncryptionClientMetadataMode, bucketName).Wait();

            s3EncryptionClientMetadataMode.Dispose();
            s3EncryptionClientFileMode.Dispose();

            foreach(string file in _filesToDelete)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }

            base.Dispose(disposing);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetFileUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetFileUsingMetadataMode" + random.Next(),
                FilePath = filePath
            };

            PutObjectResponse response = await s3EncryptionClientMetadataMode.PutObjectAsync(request);
            await TestGet(request.Key, File.ReadAllText(filePath), s3EncryptionClientMetadataMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetFileUsingInstructionFileMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetFileUsingInstructionFileMode" + random.Next(),
                FilePath = filePath
            };

            PutObjectResponse response = await s3EncryptionClientFileMode.PutObjectAsync(request);

            await TestGet(request.Key, File.ReadAllText(filePath), s3EncryptionClientFileMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetStreamUsingMetadataMode()
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(sampleContent);
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetStreamUsingMeatadaMode" + random.Next(),
                InputStream = new MemoryStream(dataBytes)
            };

            PutObjectResponse response = await s3EncryptionClientMetadataMode.PutObjectAsync(request);

            await TestGet(request.Key, sampleContent, s3EncryptionClientMetadataMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetStreamUsingInstructionFileMode()
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(sampleContent);
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetStreamUsingMeatadaMode" + random.Next(),
                InputStream = new MemoryStream(dataBytes)
            };

            PutObjectResponse response = await s3EncryptionClientFileMode.PutObjectAsync(request);

            await TestGet(request.Key, sampleContent, s3EncryptionClientFileMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetContentUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                ContentBody = "Encryption Client Testing!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = await s3EncryptionClientMetadataMode.PutObjectAsync(request);

            await TestGet(request.Key, request.ContentBody, s3EncryptionClientMetadataMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetZeroLengthContentUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                ContentBody = "",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = await s3EncryptionClientMetadataMode.PutObjectAsync(request);

            await TestGet(request.Key, request.ContentBody, s3EncryptionClientMetadataMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetNullContentContentUsingMetadataMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = await s3EncryptionClientMetadataMode.PutObjectAsync(request);

            await TestGet(request.Key, "", s3EncryptionClientMetadataMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task PutGetContentUsingInstructionFileMode()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "PutGetContentUsingMeatadaMode" + random.Next(),
                ContentBody = "Encryption Client Testing!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            PutObjectResponse response = await s3EncryptionClientFileMode.PutObjectAsync(request);

            await TestGet(request.Key, request.ContentBody, s3EncryptionClientFileMode);
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task MultipartEncryptionTestMetadataMode()
        {
            string filePath = Path.Combine(Path.GetTempPath(), "MultipartEncryptionTestMetaDatamode_upload.txt");
            string retrievedFilepath = Path.Combine(Path.GetTempPath(), "MultipartEncryptionTestMetaDatamode_download.txt");
            int MEG_SIZE = (int)Math.Pow(2, 20);
            long totalSize = (long)(15 * MEG_SIZE);
            UtilityMethods.GenerateFile(filePath, totalSize);
                _filesToDelete.Add(filePath);
            string key = "MultipartEncryptionTestMetadataMode" + random.Next();

            using(Stream inputStream = File.OpenRead(filePath))
            {
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    StorageClass = S3StorageClass.ReducedRedundancy,
                    ContentType = "text/html",
                    CannedACL = S3CannedACL.PublicRead
                };

                InitiateMultipartUploadResponse initResponse = await s3EncryptionClientMetadataMode.InitiateMultipartUploadAsync(initRequest);

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

                UploadPartResponse up1Response = await s3EncryptionClientMetadataMode.UploadPartAsync(uploadRequest);

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

                UploadPartResponse up2Response = await s3EncryptionClientMetadataMode.UploadPartAsync(uploadRequest);

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

                UploadPartResponse up3Response = await s3EncryptionClientMetadataMode.UploadPartAsync(uploadRequest);

                ListPartsRequest listPartRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };

                ListPartsResponse listPartResponse = await s3EncryptionClientMetadataMode.ListPartsAsync(listPartRequest);
                Assert.Equal(3, listPartResponse.Parts.Count);
                Assert.Equal(up1Response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.Equal(up1Response.ETag, listPartResponse.Parts[0].ETag);
                Assert.Equal(up2Response.PartNumber, listPartResponse.Parts[1].PartNumber);
                Assert.Equal(up2Response.ETag, listPartResponse.Parts[1].ETag);
                Assert.Equal(up3Response.PartNumber, listPartResponse.Parts[2].PartNumber);
                Assert.Equal(up3Response.ETag, listPartResponse.Parts[2].ETag);

                listPartRequest.MaxParts = 1;
                listPartResponse = await s3EncryptionClientMetadataMode.ListPartsAsync(listPartRequest);
                Assert.Equal(1, listPartResponse.Parts.Count);

                // Complete the response
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(up1Response, up2Response, up3Response);

                CompleteMultipartUploadResponse compResponse = await s3EncryptionClientMetadataMode.CompleteMultipartUploadAsync(compRequest);
                Assert.Equal(bucketName, compResponse.BucketName);
                Assert.NotNull(compResponse.ETag);
                Assert.Equal(key, compResponse.Key);
                Assert.NotNull(compResponse.Location);

                // Get the file back from S3 and make sure it is still the same.
                GetObjectRequest getRequest = new GetObjectRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };

                GetObjectResponse getResponse = await s3EncryptionClientMetadataMode.GetObjectAsync(getRequest);
                await getResponse.WriteResponseStreamToFileAsync(retrievedFilepath, false, System.Threading.CancellationToken.None);
                _filesToDelete.Add(retrievedFilepath);

                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                GetObjectMetadataRequest metaDataRequest = new GetObjectMetadataRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };
                GetObjectMetadataResponse metaDataResponse = await s3EncryptionClientMetadataMode.GetObjectMetadataAsync(metaDataRequest);
                Assert.Equal("text/html", metaDataResponse.Headers.ContentType);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"S3")]
        public async Task MultipartEncryptionTestInstructionFile()
        {
            string filePath = Path.Combine(Path.GetTempPath(), "MulitpartEncryptionTestInstructionFile_upload.txt");
            string retrievedFilepath = Path.Combine(Path.GetTempPath(), "MulitpartEncryptionTestInstructionFile_download.txt");
            int MEG_SIZE = (int)Math.Pow(2, 20);
            long totalSize = (long)(15 * MEG_SIZE) + 4001;
            UtilityMethods.GenerateFile(filePath, totalSize);
                _filesToDelete.Add(filePath);

            string key = "MultipartEncryptionTestInstrcutionFile" + random.Next();

            using (Stream inputStream = File.OpenRead(filePath))
            {
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    StorageClass = S3StorageClass.ReducedRedundancy,
                    ContentType = "text/html",
                    CannedACL = S3CannedACL.PublicRead
                };

                InitiateMultipartUploadResponse initResponse = await s3EncryptionClientFileMode.InitiateMultipartUploadAsync(initRequest);

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

                UploadPartResponse up1Response = await s3EncryptionClientFileMode.UploadPartAsync(uploadRequest);

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

                UploadPartResponse up2Response = await s3EncryptionClientFileMode.UploadPartAsync(uploadRequest);

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
                UploadPartResponse up3Response = await s3EncryptionClientFileMode.UploadPartAsync(uploadRequest);


                ListPartsRequest listPartRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };

                ListPartsResponse listPartResponse = await s3EncryptionClientFileMode.ListPartsAsync(listPartRequest);
                Assert.Equal(3, listPartResponse.Parts.Count);
                Assert.Equal(up1Response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.Equal(up1Response.ETag, listPartResponse.Parts[0].ETag);
                Assert.Equal(up2Response.PartNumber, listPartResponse.Parts[1].PartNumber);
                Assert.Equal(up2Response.ETag, listPartResponse.Parts[1].ETag);
                Assert.Equal(up3Response.PartNumber, listPartResponse.Parts[2].PartNumber);
                Assert.Equal(up3Response.ETag, listPartResponse.Parts[2].ETag);

                listPartRequest.MaxParts = 1;
                listPartResponse = await s3EncryptionClientFileMode.ListPartsAsync(listPartRequest);
                Assert.Equal(1, listPartResponse.Parts.Count);

                // Complete the response
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(up1Response, up2Response, up3Response);

                CompleteMultipartUploadResponse compResponse = await s3EncryptionClientFileMode.CompleteMultipartUploadAsync(compRequest);
                Assert.Equal(bucketName, compResponse.BucketName);
                Assert.NotNull(compResponse.ETag);
                Assert.Equal(key, compResponse.Key);
                Assert.NotNull(compResponse.Location);

                // Get the file back from S3 and make sure it is still the same.
                GetObjectRequest getRequest = new GetObjectRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };

                GetObjectResponse getResponse = await s3EncryptionClientFileMode.GetObjectAsync(getRequest);
                await getResponse.WriteResponseStreamToFileAsync(retrievedFilepath, false, System.Threading.CancellationToken.None);
                    _filesToDelete.Add(retrievedFilepath);

                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                GetObjectMetadataRequest metaDataRequest = new GetObjectMetadataRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };
                GetObjectMetadataResponse metaDataResponse = await s3EncryptionClientFileMode.GetObjectMetadataAsync(metaDataRequest);
                Assert.Equal("text/html", metaDataResponse.Headers.ContentType);
            }
        }

        private static async Task TestGet(string key, string uploadedData, AmazonS3EncryptionClient s3EncryptionClient)
        {
            GetObjectRequest getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };

            using (GetObjectResponse getObjectResponse = await s3EncryptionClient.GetObjectAsync(getObjectRequest))
            {
                using (var stream = getObjectResponse.ResponseStream)
                using (var reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    Assert.Equal(uploadedData, data);
                }
            }
        }

        private static string HashFile(string file)
        {
            var md5 = MD5.Create();
            using (var stream = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.None))
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
