using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class GetObjectTests : TestBase<AmazonS3Client>
    {
        private const string content = "0123456789";
        private static string bucketName;

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);

            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = content,
                Key = "TestObject"
            });
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }


        [TestMethod]
        [TestCategory("S3")]
        public void TestRangedGetWithStartAndEnd()
        {
            var response = Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                ByteRange = new ByteRange(1, 5),
                Key = "TestObject"
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = reader.ReadToEnd();
                    Assert.AreEqual("12345", text);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRangedGetWithByteRange()
        {
            var response = Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                ByteRange = new ByteRange("bytes=-2"),
                Key = "TestObject"
            });

            using (response.ResponseStream)
            {
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var text = reader.ReadToEnd();
                    Assert.AreEqual("89", text);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestObjectAttributesLastModified()
        {
            var getObjectAttributesResponse = Client.GetObjectAttributes(new GetObjectAttributesRequest
            {
                BucketName = bucketName,
                Key = "TestObject",
                ObjectAttributes = new List<ObjectAttributes> { ObjectAttributes.ObjectSize }
            });

            var getObjectMetadataResponse = Client.GetObjectMetadata(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = "TestObject"
            });

            Assert.AreNotEqual(getObjectAttributesResponse.LastModified, DateTime.MinValue);
            Assert.AreEqual(getObjectAttributesResponse.LastModified, getObjectMetadataResponse.LastModified);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestServerSideEncryptionCustomerProvidedKeyMD5()
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
                Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = "Test content for SSE-C",
                    ServerSideEncryptionCustomerMethod = ServerSideEncryptionCustomerMethod.AES256,
                    ServerSideEncryptionCustomerProvidedKey = encryptionKeyBase64,
                    ServerSideEncryptionCustomerProvidedKeyMD5 = keyMD5
                });

                try
                {
                    // Get object with SSE-C
                    var response = Client.GetObject(new GetObjectRequest
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
                finally
                {
                    // Clean up test object
                    try
                    {
                        Client.DeleteObject(bucketName, key);
                    }
                    catch (Exception ex)
                    {
                         Console.WriteLine($"Failed to delete test object '{key}' from bucket '{bucketName}': {ex}");
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestContentLanguageHeader()
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
            putRequest.Headers.ContentLanguage = expectedLanguage;

            Client.PutObject(putRequest);

            try
            {
                // Get object and verify Content-Language header
                var response = Client.GetObject(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });

                using (response)
                {
                    Assert.IsNotNull(response.Headers.ContentLanguage, 
                        "ContentLanguage should not be null");
                    Assert.AreEqual(expectedLanguage, response.Headers.ContentLanguage,
                        "ContentLanguage should match the value set during PutObject");
                }
            }
            finally
            {
                // Clean up test object
                try
                {
                    Client.DeleteObject(bucketName, key);
                }
                catch (Exception ex)
                {
                     Console.WriteLine($"Failed to delete test object '{key}' from bucket '{bucketName}': {ex}");
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestContentLanguageResponseHeaderOverride()
        {
            var key = "TestContentLanguageResponseHeaderOverride";
            var originalLanguage = "fr-FR";
            var overrideLanguage = "es-ES";

            // Put object with original Content-Language
            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "Test content for Content-Language override"
            };
            putRequest.Headers.ContentLanguage = originalLanguage;

            Client.PutObject(putRequest);

            try
            {
                // Get object with response header override
                var response = Client.GetObject(new GetObjectRequest
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
                    Assert.IsNotNull(response.Headers.ContentLanguage, 
                        "ContentLanguage should not be null");
                    Assert.AreEqual(overrideLanguage, response.Headers.ContentLanguage,
                        "ContentLanguage should match the override value, not the original stored value");
                }

                // Verify original value is still stored by getting without override
                var responseWithoutOverride = Client.GetObject(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });

                using (responseWithoutOverride)
                {
                    Assert.AreEqual(originalLanguage, responseWithoutOverride.Headers.ContentLanguage,
                        "Original ContentLanguage should still be stored when no override is specified");
                }
            }
            finally
            {
                // Clean up test object
                try
                {
                    Client.DeleteObject(bucketName, key);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to delete test object '{key}' from bucket '{bucketName}': {ex}");
                }
            }
        }
    }
}
