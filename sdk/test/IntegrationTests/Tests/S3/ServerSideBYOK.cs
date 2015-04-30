using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.S3.Transfer;
using System.Security.Cryptography;
using System.Net;
using ThirdParty.MD5;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class ServerSideBYOK : TestBase<AmazonS3Client>
    {
        private const string key = "Encrypted|Object.png";

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        //internal static string ComputeEncodedMD5FromEncodedString(string base64EncodedString)
        private static MD5Managed md5 = new MD5Managed();
        private static string ComputeEncodedMD5FromEncodedString(string base64EncodedString)
        {
            var unencodedValue = Convert.FromBase64String(base64EncodedString);
            var valueMD5 = md5.ComputeHash(unencodedValue);
            var encodedMD5 = Convert.ToBase64String(valueMD5);
            return encodedMD5;
        }

        private static AmazonS3Client CreateHttpClient()
        {
            var config = new AmazonS3Config { UseHttp = true };
            var client = new AmazonS3Client(config);

            return client;
        }


        [TestMethod]
        [TestCategory("S3")]
        public void ServerSideEncryptionBYOKPutAndGet()
        {
            var bucketName = S3TestUtils.CreateBucket(Client);

            try
            {
                Aes aesEncryption = Aes.Create();
                aesEncryption.KeySize = 256;
                aesEncryption.GenerateKey();
                string base64Key = Convert.ToBase64String(aesEncryption.Key);
                string base64KeyMd5 = ComputeEncodedMD5FromEncodedString(base64Key);

                PutObjectRequest putRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = "The Data To Encrypt in S3",

                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key,
                    ServerSideEncryptionCustomerProvidedKeyMD5 = base64KeyMd5
                };

                Client.PutObject(putRequest);

                GetObjectMetadataRequest getObjectMetadataRequest = new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key,

                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key,
                    ServerSideEncryptionCustomerProvidedKeyMD5 = base64KeyMd5
                };

                GetObjectMetadataResponse getObjectMetadataResponse = Client.GetObjectMetadata(getObjectMetadataRequest);
                Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getObjectMetadataResponse.ServerSideEncryptionCustomerMethod);

                GetObjectRequest getObjectRequest = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,

                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key,
                    ServerSideEncryptionCustomerProvidedKeyMD5 = base64KeyMd5
                };

                using (GetObjectResponse getResponse = Client.GetObject(getObjectRequest))
                using (StreamReader reader = new StreamReader(getResponse.ResponseStream))
                {
                    string content = reader.ReadToEnd();
                    Assert.AreEqual(putRequest.ContentBody, content);
                    Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getResponse.ServerSideEncryptionCustomerMethod);
                }

                GetPreSignedUrlRequest getPresignedUrlRequest = new GetPreSignedUrlRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    Expires = DateTime.Now.AddMinutes(5)
                };
                var url = Client.GetPreSignedURL(getPresignedUrlRequest);
                var webRequest = HttpWebRequest.Create(url);
                webRequest.Headers.Add("x-amz-server-side-encryption-customer-algorithm", "AES256");
                webRequest.Headers.Add("x-amz-server-side-encryption-customer-key", base64Key);
                webRequest.Headers.Add("x-amz-server-side-encryption-customer-key-MD5", base64KeyMd5);

                using (var response = webRequest.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var contents = reader.ReadToEnd();
                    Assert.AreEqual(putRequest.ContentBody, contents);
                }

                aesEncryption.GenerateKey();
                string copyBase64Key = Convert.ToBase64String(aesEncryption.Key);

                CopyObjectRequest copyRequest = new CopyObjectRequest
                {
                    SourceBucket = bucketName,
                    SourceKey = key,
                    DestinationBucket = bucketName,
                    DestinationKey = "EncryptedObject_Copy",

                    CopySourceServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    CopySourceServerSideEncryptionCustomerProvidedKey = base64Key,
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = copyBase64Key
                };
                Client.CopyObject(copyRequest);

                getObjectMetadataRequest = new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = "EncryptedObject_Copy",

                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = copyBase64Key
                };

                getObjectMetadataResponse = Client.GetObjectMetadata(getObjectMetadataRequest);
                Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getObjectMetadataResponse.ServerSideEncryptionCustomerMethod);

                // Test calls against HTTP client, some should fail on the client
                using (var httpClient = CreateHttpClient())
                {
                    getObjectMetadataRequest.ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.None;
                    getObjectMetadataRequest.ServerSideEncryptionCustomerProvidedKey = null;
                    AssertExtensions.ExpectException(() =>
                        httpClient.GetObjectMetadata(getObjectMetadataRequest), typeof(AmazonS3Exception));

                    getObjectMetadataRequest.ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256;
                    AssertExtensions.ExpectException(() =>
                        httpClient.GetObjectMetadata(getObjectMetadataRequest), typeof(AmazonS3Exception));

                    getObjectMetadataRequest.ServerSideEncryptionCustomerProvidedKey = copyBase64Key;
                    AssertExtensions.ExpectException(() =>
                        httpClient.GetObjectMetadata(getObjectMetadataRequest), typeof(Amazon.Runtime.AmazonClientException));

                    url = httpClient.GetPreSignedURL(getPresignedUrlRequest);
                    Assert.IsFalse(string.IsNullOrEmpty(url));
                }
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ServerSideEncryptionBYOKTransferUtility()
        {
            var bucketName = S3TestUtils.CreateBucket(Client);
            try
            {
                Aes aesEncryption = Aes.Create();
                aesEncryption.KeySize = 256;
                aesEncryption.GenerateKey();
                string base64Key = Convert.ToBase64String(aesEncryption.Key);

                TransferUtility utility = new TransferUtility(Client);

                var uploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key
                };

                uploadRequest.InputStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes("Encrypted Content"));

                utility.Upload(uploadRequest);

                GetObjectMetadataRequest getObjectMetadataRequest = new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key,

                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key
                };

                GetObjectMetadataResponse getObjectMetadataResponse = Client.GetObjectMetadata(getObjectMetadataRequest);
                Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, getObjectMetadataResponse.ServerSideEncryptionCustomerMethod);

                var openRequest = new TransferUtilityOpenStreamRequest
                {
                    BucketName = bucketName,
                    Key = key,

                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = base64Key
                };

                using(var stream = new StreamReader(utility.OpenStream(openRequest)))
                {
                    var content = stream.ReadToEnd();
                    Assert.AreEqual(content, "Encrypted Content");
                }
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            }
        }
    }
}
