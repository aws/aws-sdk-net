using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class GetObjectTests : TestBase<AmazonS3Client>
    {
        private const string content = "0123456789";
        private static string bucketName;

        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = content,
                Key = "TestObject"
            });
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        public async Task TestRangedGetWithStartAndEnd()
        {
            var response = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                ByteRange = new ByteRange(1, 5),
                Key = "TestObject"
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = await reader.ReadToEndAsync();
                    Assert.AreEqual("12345", text);
                }
            }
        }

        [TestMethod]
        public async Task TestRangedGetWithByteRange()
        {
            var response = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                ByteRange = new ByteRange("bytes=-2"),
                Key = "TestObject"
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = await reader.ReadToEndAsync();
                    Assert.AreEqual("89", text);
                }
            }
        }

        [TestMethod]
        public async Task TestObjectAttributesLastModified()
        {
            var getObjectAttributesResponse = await Client.GetObjectAttributesAsync(new GetObjectAttributesRequest
            {
                BucketName = bucketName,
                Key = "TestObject",
                ObjectAttributes = new List<ObjectAttributes> { ObjectAttributes.ObjectSize }
            });

            var getObjectMetadataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = "TestObject"
            });

            Assert.AreNotEqual(getObjectAttributesResponse.LastModified, DateTime.MinValue);
            Assert.AreEqual(getObjectAttributesResponse.LastModified, getObjectMetadataResponse.LastModified);
        }

        [TestMethod]
        public async Task TestServerSideEncryptionCustomerProvidedKeyMD5()
        {
            var key = "TestServerSideEncryptionCustomerProvidedKeyMD5";
            
            // Generate a cryptographically secure 256-bit (32 byte) encryption key
            var encryptionKeyBytes = new byte[32];
            using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                rng.GetBytes(encryptionKeyBytes);
            }
            var encryptionKeyBase64 = Convert.ToBase64String(encryptionKeyBytes);
            
            // Calculate MD5 of the encryption key
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var keyMD5 = Convert.ToBase64String(md5.ComputeHash(encryptionKeyBytes));
                
                // Put object with SSE-C
                await Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = "Test content for SSE-C",
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = encryptionKeyBase64,
                    ServerSideEncryptionCustomerProvidedKeyMD5 = keyMD5
                });

                var response = await Client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = encryptionKeyBase64,
                    ServerSideEncryptionCustomerProvidedKeyMD5 = keyMD5
                });

                using (response)
                {
                    // Verify the ServerSideEncryptionCustomerProvidedKeyMD5 property is populated
                    Assert.IsNotNull(response.ServerSideEncryptionCustomerProvidedKeyMD5,
                        "ServerSideEncryptionCustomerProvidedKeyMD5 should not be null");
                    Assert.AreEqual(keyMD5, response.ServerSideEncryptionCustomerProvidedKeyMD5,
                        "ServerSideEncryptionCustomerProvidedKeyMD5 should match the provided MD5");
                }
            }
        }

        [TestMethod]
        public async Task TestContentLanguageHeader()
        {
            var key = "TestContentLanguageHeader";
            var expectedLanguage = "en-US";

            // Put object with Content-Language header
            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "Test content for Content-Language"
            };
            putRequest.Headers["Content-Language"] = expectedLanguage;

            await Client.PutObjectAsync(putRequest);

            // Get object and verify Content-Language header
            var response = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });

            using (response)
            {
                Assert.IsNotNull(response.ContentLanguage,
                    "ContentLanguage should not be null");
                Assert.AreEqual(expectedLanguage, response.ContentLanguage,
                    "ContentLanguage should match the value set during PutObject");
            }
        }

        [TestMethod]
        public async Task TestContentLanguageResponseHeaderOverride()
        {
            var key = "TestContentLanguageResponseHeaderOverride";
            var originalLanguage = "fr-FR";
            var overrideLanguage = "es-ES";

            // Put object with original Content-Language
            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "Test content for Content-Language override",
            };
            putRequest.Headers["Content-Language"] = originalLanguage;

            await Client.PutObjectAsync(putRequest);

            // Get object with response header override
            var response = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ResponseHeaderOverrides = new ResponseHeaderOverrides
                {
                    ContentLanguage = overrideLanguage
                }
            });

            using (response)
            {
                Assert.IsNotNull(response.ContentLanguage, 
                    "ContentLanguage should not be null");
                Assert.AreEqual(overrideLanguage, response.ContentLanguage,
                    "ContentLanguage should match the override value, not the original stored value");
            }

            // Verify original value is still stored by getting without override
            var responseWithoutOverride = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });

            using (responseWithoutOverride)
            {
                Assert.AreEqual(originalLanguage, responseWithoutOverride.ContentLanguage,
                    "Original ContentLanguage should still be stored when no override is specified");
            }
        }

        [TestMethod]
        public async Task TestContentLanguageHeadersCollection()
        {
            var key = "TestContentLanguageHeadersCollection";
            var expectedLanguage = "de-DE";

            // Put object with Content-Language header
            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "Test content for Content-Language headers collection"
            };
            putRequest.Headers["Content-Language"] = expectedLanguage;

            await Client.PutObjectAsync(putRequest);

            // Get object and verify both ContentLanguage properties are set
            var response = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });

            using (response)
            {
                // Verify the direct ContentLanguage property
                Assert.IsNotNull(response.ContentLanguage,
                    "ContentLanguage property should not be null");
                Assert.AreEqual(expectedLanguage, response.ContentLanguage,
                    "ContentLanguage property should match the value set during PutObject");

                // Verify the Headers.ContentLanguage property
                Assert.IsNotNull(response.Headers.ContentLanguage,
                    "Headers.ContentLanguage property should not be null");
                Assert.AreEqual(expectedLanguage, response.Headers.ContentLanguage,
                    "Headers.ContentLanguage property should match the value set during PutObject");

                // Verify both properties have the same value
                Assert.AreEqual(response.ContentLanguage, response.Headers.ContentLanguage,
                    "ContentLanguage and Headers.ContentLanguage should have the same value");
            }
        }
    }
}
