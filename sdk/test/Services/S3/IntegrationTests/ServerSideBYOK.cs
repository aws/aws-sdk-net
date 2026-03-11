using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.MD5;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class ServerSideBYOK : TestBase<AmazonS3Client>
    {
        private const string key = "Encrypted|Object.png";
        private static string bucketName;
        private static readonly MD5Managed md5 = new MD5Managed();

        [ClassInitialize]
        public static async Task Initialize(TestContext testContext)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
        }
        
        private static string ComputeEncodedMD5FromEncodedString(string base64EncodedString)
        {
            var unencodedValue = Convert.FromBase64String(base64EncodedString);
            var valueMD5 = md5.ComputeHash(unencodedValue);
            var encodedMD5 = Convert.ToBase64String(valueMD5);
            return encodedMD5;
        }

        private static AmazonS3Client CreateHttpClient() => new AmazonS3Client(new AmazonS3Config { UseHttp = true });

        [TestMethod]
        public async Task ServerSideEncryptionBYOKPutAndGet()
        {
            Aes aesEncryption = Aes.Create();
            aesEncryption.KeySize = 256;
            aesEncryption.GenerateKey();
            string base64Key = Convert.ToBase64String(aesEncryption.Key);
            string base64KeyMd5 = ComputeEncodedMD5FromEncodedString(base64Key);

            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "The Data To Encrypt in S3",
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = base64Key,
                ServerSideEncryptionCustomerProvidedKeyMD5 = base64KeyMd5
            };
            await Client.PutObjectAsync(putRequest);

            var getObjectMetadataRequest = new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = base64Key,
                ServerSideEncryptionCustomerProvidedKeyMD5 = base64KeyMd5
            };
            var getObjectMetadataResponse = await Client.GetObjectMetadataAsync(getObjectMetadataRequest);
            Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getObjectMetadataResponse.ServerSideEncryptionCustomerMethod);

            var getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = base64Key,
                ServerSideEncryptionCustomerProvidedKeyMD5 = base64KeyMd5
            };
            using (GetObjectResponse getResponse = await Client.GetObjectAsync(getObjectRequest))
            using (StreamReader reader = new StreamReader(getResponse.ResponseStream))
            {
                string content = await reader.ReadToEndAsync();
                Assert.AreEqual(putRequest.ContentBody, content);
                Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getResponse.ServerSideEncryptionCustomerMethod);
            }

            var getPresignedUrlRequest = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                Expires = DateTime.UtcNow.AddMinutes(5)
            };
            var url = await Client.GetPreSignedURLAsync(getPresignedUrlRequest);
            var webRequest = WebRequest.Create(url);
            webRequest.Headers.Add("x-amz-server-side-encryption-customer-algorithm", "AES256");
            webRequest.Headers.Add("x-amz-server-side-encryption-customer-key", base64Key);
            webRequest.Headers.Add("x-amz-server-side-encryption-customer-key-MD5", base64KeyMd5);

            using (var response = await webRequest.GetResponseAsync())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var contents = await reader.ReadToEndAsync();
                Assert.AreEqual(putRequest.ContentBody, contents);
            }

            aesEncryption.GenerateKey();
            string copyBase64Key = Convert.ToBase64String(aesEncryption.Key);
            await Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = key,
                DestinationBucket = bucketName,
                DestinationKey = "EncryptedObject_Copy",
                CopySourceServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                CopySourceServerSideEncryptionCustomerProvidedKey = base64Key,
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = copyBase64Key
            });

            getObjectMetadataRequest = new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = "EncryptedObject_Copy",
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = copyBase64Key
            };

            getObjectMetadataResponse = await Client.GetObjectMetadataAsync(getObjectMetadataRequest);
            Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getObjectMetadataResponse.ServerSideEncryptionCustomerMethod);

            // Test calls against HTTP client, some should fail on the client
            using (var httpClient = CreateHttpClient())
            {
                getObjectMetadataRequest.ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.None;
                getObjectMetadataRequest.ServerSideEncryptionCustomerProvidedKey = null;
                await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => httpClient.GetObjectMetadataAsync(getObjectMetadataRequest));

                getObjectMetadataRequest.ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256;
                await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => httpClient.GetObjectMetadataAsync(getObjectMetadataRequest));

                getObjectMetadataRequest.ServerSideEncryptionCustomerProvidedKey = copyBase64Key;
                await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => httpClient.GetObjectMetadataAsync(getObjectMetadataRequest));

                url = httpClient.GetPreSignedURL(getPresignedUrlRequest);
                Assert.IsFalse(string.IsNullOrEmpty(url));
            }
        }

        [TestMethod]
        public async Task ServerSideEncryptionBYOKTransferUtility()
        {
            Aes aesEncryption = Aes.Create();
            aesEncryption.KeySize = 256;
            aesEncryption.GenerateKey();
            string base64Key = Convert.ToBase64String(aesEncryption.Key);

            var utility = new TransferUtility(Client);
            await utility.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = base64Key,
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes("Encrypted Content"))
            });

            var getObjectMetadataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = base64Key
            });
            Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getObjectMetadataResponse.ServerSideEncryptionCustomerMethod);

            var openRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                ServerSideEncryptionCustomerProvidedKey = base64Key
            };

            using (var stream = new StreamReader(await utility.OpenStreamAsync(openRequest)))
            {
                var content = await stream.ReadToEndAsync();
                Assert.AreEqual(content, "Encrypted Content");
            }
        }
    }
}
