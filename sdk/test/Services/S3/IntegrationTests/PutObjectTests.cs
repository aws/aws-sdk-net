using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class PutObjectTest : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private Random random = new Random();
        private static string bucketName;
        private const string testContent = "This is the content body!";
        private const string testKey = "test-key.json.gz";
        private const string testFileName = "PutObjectFile.txt";

        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {
            using (var writer = File.CreateText(testFileName))
            {
                await writer.WriteAsync("This is some sample text.!!");
            }

            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, true);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        public async Task TestPutAndGetWithInvalidExpires()
        {
            var content = "TestInvalidExpiresHeader";
            var key = UtilityMethods.GenerateName("TestPutAndGetWithInvalidExpires");
            var putObjectRequest = new PutObjectRequest
            {
               BucketName = bucketName,
               Key = key,
               ContentBody = content
            };

            var invalidValue = "InvalidHeaderValue";
            putObjectRequest.Headers["Expires"] = invalidValue;
            await Client.PutObjectAsync(putObjectRequest);

            var getObjectResponse = await Client.GetObjectAsync(bucketName, key);
            using (getObjectResponse)
            {
                var reader = new StreamReader(getObjectResponse.ResponseStream);
                var contentRead = await reader.ReadToEndAsync();
                Assert.IsTrue(content.Equals(contentRead));
                Assert.AreEqual(getObjectResponse.ExpiresString, invalidValue);
            }

            var getObjectMetadataResponse = await Client.GetObjectMetadataAsync(bucketName, key);
            Assert.AreEqual(getObjectMetadataResponse.ExpiresString, invalidValue);
        }

        [TestMethod]
        public async Task TestPutAndGetWithBidiCharacters()
        {
            var bidiChar = '\u200E';
            var encodedBidiChar = "%E2%80%8E";
            var content = "TestPutAndGetWithBidiCharacters";            
            var bidiKey = UtilityMethods.GenerateName($"TestPutAndGetWithBidi{bidiChar}Characters");

            // Verify character is in the string
            Assert.IsTrue(bidiKey.IndexOf(bidiChar) > 0);
            Assert.IsTrue(AWSSDKUtils.HasBidiControlCharacters(bidiKey));

            // Verify character is encoded by the Uri class
            Uri uri = new Uri(new Uri("http://www.amazon.com/"), bidiKey);
            Assert.IsTrue(uri.AbsoluteUri.Contains(encodedBidiChar));
            Assert.IsFalse(AWSSDKUtils.HasBidiControlCharacters(uri.AbsoluteUri));
            Assert.IsTrue(uri.AbsoluteUri.Contains($"TestPutAndGetWithBidi{encodedBidiChar}Characters"));

            // Verify the bidi key can be used to put an object
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = bidiKey,
                ContentBody = content
            });

            // Verify the bidi key object can be read
            var response = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = bidiKey,
            });

            // Read S3 bucket response content
            var responseBody = string.Empty;
            using (var reader = new StreamReader(response.ResponseStream))
            {
                responseBody = await reader.ReadToEndAsync();                
            }

            // Verify the correct response was read
            Assert.IsTrue(content == responseBody);
        }

        [TestMethod]
        public async Task TestStorageClass()
        {
            var key = "contentBodyPut" + random.Next();
            var storageClass = S3StorageClass.ReducedRedundancy;
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead,
                StorageClass = storageClass
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            
            var response = await Client.PutObjectAsync(request);
            Assert.IsTrue(response.ETag.Length > 0);

            var metadata = await Client.GetObjectMetadataAsync(bucketName, key);
            Assert.IsNotNull(metadata);
            Assert.IsNotNull(metadata.StorageClass);
            Assert.AreEqual(metadata.StorageClass, storageClass);
            await VerifyPut(testContent, request);
        }

        [TestMethod]
        public async Task PutObjectCancellationTest()
        {
            var fileName = UtilityMethods.GenerateName(@"CancellationTest-LargeFile");
            var basePath = Path.Combine(Path.GetTempPath(), "PutObjectCancellation-" + Guid.NewGuid().ToString());
            var path = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(path, 50 * MEG_SIZE);

            var cts = new CancellationTokenSource();
            cts.CancelAfter(1000);
            var token = cts.Token;
            try
            {
                await Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "CancellationTest" + random.Next(),
                    CannedACL = S3CannedACL.AuthenticatedRead,
                    FilePath = path
                }, token);

                Assert.Fail("An OperationCanceledException was not thrown");
            }
            catch (OperationCanceledException exception)
            {
                Assert.AreEqual(token, exception.CancellationToken);
                Assert.AreEqual(true, exception.CancellationToken.IsCancellationRequested);
            }
            finally
            {
                Directory.Delete(basePath, true);
            }
        }
      
        [TestMethod]
        public async Task PutObjectWithExternalEndpoint()
        {            
            var s3Client = new AmazonS3Client(new AmazonS3Config
            {
                ServiceURL = "https://s3-external-1.amazonaws.com"
            });

            var testBucketName = "aws-net-sdk-external" + random.Next();
            var key = "testKey";
            
            try
            {
                await s3Client.PutBucketAsync(testBucketName);
                await s3Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = testBucketName,
                    Key = key,
                    ContentBody = "testValue"
                });
                await s3Client.GetObjectAsync(testBucketName, key);
            }
            finally
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3Client, testBucketName);
                s3Client.Dispose();
            }
        }

        [TestMethod]
        public async Task PutObjectWithLeadingSlash()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "/contentBodyPut" + random.Next(),
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");

            var response = await Client.PutObjectAsync(request);
            Assert.IsTrue(response.ETag.Length > 0);
        }

        [TestMethod]
        public async Task PutObjectKeyWithUrlEncodedCharacters()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "X$abc,xyz",
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            
            var response = await Client.PutObjectAsync(request);
            Assert.IsTrue(response.ETag.Length > 0);
            await VerifyPut(testContent, request);
        }

        [TestMethod]
        public async Task PutObject()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            
            var response = await Client.PutObjectAsync(request);
            Assert.IsTrue(response.ETag.Length > 0);
            await VerifyPut(testContent, request);
        }

        [DataTestMethod]
        [DataRow(false, false)]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(true, true)]
        public async Task PutObjectWithEmptyInputStream(bool disablePayloadSigning, bool disableDefaultChecksumValidation)
        {
            var response = await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "inputStreamPut" + random.Next(),
                InputStream = new MemoryStream(),
                DisableDefaultChecksumValidation = disableDefaultChecksumValidation,
                DisablePayloadSigning = disablePayloadSigning,
            });

            Assert.IsTrue(response.ETag.Length > 0);
        }

        [TestMethod]
        public async Task PutObject_SigV4()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            
            var response = await Client.PutObjectAsync(request);
            Assert.IsTrue(response.ETag.Length > 0);
        }

        [TestMethod]
        public async Task PutObject_WithExpires()
        {
            var key = "contentBodyPut" + random.Next();
            var expires = DateTime.UtcNow.AddYears(5);
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead,
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            request.Headers.Expires = expires;
            
            var response = await Client.PutObjectAsync(request);
            Assert.IsTrue(response.ETag.Length > 0);

            var getResponse = await Client.GetObjectAsync(new GetObjectRequest { BucketName = bucketName, Key = key });
            Assert.IsTrue(expires.ApproximatelyEqual(DateTime.Parse(getResponse.ExpiresString, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToUniversalTime()));
        }

        [TestMethod]
        public async Task PutObjectWrongRegion()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            using (var client = new AmazonS3Client(RegionEndpoint.USWest2))
            {
                // Returns an exception with HTTP 301 MovedPermanently
                var exception = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => client.PutObjectAsync(request));
                Assert.AreEqual("PermanentRedirect", exception.ErrorCode);
                Assert.AreEqual(HttpStatusCode.MovedPermanently, exception.StatusCode);
                Assert.IsFalse(string.IsNullOrEmpty(exception.Message));
                Assert.IsFalse(string.IsNullOrEmpty(exception.RequestId));
                Assert.IsFalse(string.IsNullOrEmpty(exception.AmazonId2));
            }
        }

        [TestMethod]
        public async Task GetObjectWithNonMatchingEtag()
        {
            var key = "TestMatchingEtag" + random.Next();

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            });

            var etag = (await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            })).ETag;

            // Returns an exception with HTTP 304 NotModified
            var exception = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() =>
                Client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    EtagToNotMatch = etag
                })
            );
            Assert.AreEqual("NotModified", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.NotModified, exception.StatusCode);
            Assert.IsFalse(string.IsNullOrEmpty(exception.Message));
            Assert.IsFalse(string.IsNullOrEmpty(exception.RequestId));
            Assert.IsFalse(string.IsNullOrEmpty(exception.AmazonId2));
        }

        [TestMethod]
        public async Task TemporaryRedirectForS3OperationsWithSigV4()
        {
            var testBucketName = UtilityMethods.GenerateName(UtilityMethods.SDK_TEST_PREFIX);
            var config = new AmazonS3Config
            {
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            };

            using (var client = new AmazonS3Client(config))
            {
                var bucket = await client.PutBucketAsync(new PutBucketRequest
                {
                    BucketName = testBucketName,
                    BucketRegion = S3Region.USWest2
                });

                try
                {
                    await client.PutObjectAsync(new PutObjectRequest
                    {
                        BucketName = testBucketName,
                        Key = "TestKey1",
                        ContentBody = "sample text"
                    });

                    await client.PutObjectAsync(new PutObjectRequest
                    {
                        BucketName = testBucketName,
                        Key = "TestKey2",
                        InputStream = UtilityMethods.CreateStreamFromString("sample text")
                    });

                    // Returns an exception with HTTP 307 TemporaryRedirect
                    var exception = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() =>
                        client.PutObjectAsync(new PutObjectRequest
                        {
                            BucketName = testBucketName,
                            Key = "TestKey3",
                            InputStream = UtilityMethods.CreateStreamFromString("sample text", new NonRewindableStream())
                        })
                    );
                    Assert.AreEqual("TemporaryRedirect", exception.ErrorCode);
                    Assert.AreEqual(HttpStatusCode.TemporaryRedirect, exception.StatusCode);
                    Assert.IsFalse(string.IsNullOrEmpty(exception.Message));
                    Assert.IsFalse(string.IsNullOrEmpty(exception.RequestId));
                    Assert.IsFalse(string.IsNullOrEmpty(exception.AmazonId2));

                    var listResponse = await client.ListObjectsAsync(new ListObjectsRequest
                    {
                        BucketName = testBucketName
                    });
                    Assert.AreEqual(2, listResponse.S3Objects.Count);
                }
                finally
                {
                    await AmazonS3Util.DeleteS3BucketWithObjectsAsync(client, testBucketName);
                }
            }
        }

        [TestMethod]
        public async Task DeleteNonExistentBucket()
        {
            // Returns an exception with HTTP 404 NotFound
            var exception = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() =>
                Client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = "nonexistentbucket1234567890" })
            );
            Assert.AreEqual("NoSuchBucket", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
            Assert.IsFalse(string.IsNullOrEmpty(exception.Message));
            Assert.IsFalse(string.IsNullOrEmpty(exception.RequestId));
            Assert.IsFalse(string.IsNullOrEmpty(exception.AmazonId2));
        }

        [TestMethod]
        public async Task GzipTest()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "gzip";
            await TestPutAndGet(request);
        }

        [TestMethod]
        public async Task PutObjectWithContentEncodingTests()
        {
            await PutObjectWithContentEncoding();
            await PutObjectWithContentEncodingIdentity();
            await PutObjectWithoutContentEncoding();
        }

        [TestMethod]
        public async Task TestPutObjectWithContentLanguage()
        {
            var key = "contentLanguageTest" + random.Next();
            var contentLanguage = "en-US";
            
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = testContent
            };
            request.Headers.ContentLanguage = contentLanguage;
            
            var putResponse = await Client.PutObjectAsync(request);
            Assert.IsTrue(putResponse.ETag.Length > 0);
            
            // Verify via GetObject
            using (var getResponse = await Client.GetObjectAsync(bucketName, key))
            {
                Assert.AreEqual(contentLanguage, getResponse.Headers.ContentLanguage);
                Assert.AreEqual(contentLanguage, getResponse.ContentLanguage);
            }
            
            // Verify via GetObjectMetadata
            var metadata = await Client.GetObjectMetadataAsync(bucketName, key);
            Assert.AreEqual(contentLanguage, metadata.Headers.ContentLanguage);
            Assert.AreEqual(contentLanguage, metadata.ContentLanguage);
        }

        private async Task PutObjectWithContentEncoding()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "gzip";
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.AreEqual("disposition", headers.ContentDisposition);
            Assert.AreEqual("gzip", headers.ContentEncoding);
        }

        private async Task PutObjectWithContentEncodingIdentity()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "identity";
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.AreEqual("disposition", headers.ContentDisposition);
            Assert.AreEqual("identity", headers.ContentEncoding);
        }

        private async Task PutObjectWithoutContentEncoding()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.AreEqual("disposition", headers.ContentDisposition);
            Assert.IsNull(headers.ContentEncoding);
        }

        private async Task<HeadersCollection> TestPutAndGet(PutObjectRequest request)
        {
            await Client.PutObjectAsync(request);

            var key = request.Key;
            using (var response = await Client.GetObjectAsync(bucketName, key))
            using (var reader = new StreamReader(response.ResponseStream))
            {
                var contents = await reader.ReadToEndAsync();
                Assert.AreEqual(testContent, contents);
            }

            using (var response = await Client.GetObjectAsync(bucketName, key))
            {
                await response.WriteResponseStreamToFileAsync(key, append: false, cancellationToken: default);
                
                var contents = File.ReadAllText(key);
                Assert.AreEqual(testContent, contents);
            }

            var meta = await Client.GetObjectMetadataAsync(bucketName, key);
            return meta.Headers;
        }

        private PutObjectRequest CreatePutObjectRequest() => new PutObjectRequest
        {
            BucketName = bucketName,
            Key = DateTime.UtcNow.ToFileTime() + testKey,
            ContentBody = testContent
        };

        [TestMethod]
        public async Task PutEmptyFile()
        {
            string key = "contentBodyPut" + random.Next();
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = string.Empty
            });

            var getResponse = await Client.GetObjectAsync(bucketName, key);
            Assert.AreEqual(0, getResponse.ContentLength);
        }

        [TestMethod]
        public async Task PutObjectLeaveStreamOpen()
        {
            var filepath = Path.GetTempFileName();
            var key = "PutObjectLeaveStreamOpen" + random.Next();
            File.WriteAllText(filepath, "abcdefghighfsldfsdfn");

            try
            {
                var stream = File.OpenRead(filepath);
                var request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    InputStream = stream
                };

                await Client.PutObjectAsync(request);
                Assert.IsFalse(stream.CanSeek, "Stream should be closed and seek should not be allowed");

                stream = File.OpenRead(filepath);
                request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    AutoCloseStream = false,
                    InputStream = stream
                };
                
                await Client.PutObjectAsync(request);
                Assert.IsTrue(stream.CanSeek, "Stream should still be open and seek should be allowed");
                stream.Close();
            }
            finally
            {
                File.Delete(filepath);
            }
        }

        [TestMethod]
        public async Task PutObject_ContentAndFile()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "PutObjectTest",
                ContentBody = "CAT",
                FilePath = testFileName
            };

            var actual = await Assert.ThrowsExceptionAsync<ArgumentException>(() => Client.PutObjectAsync(request));
            Assert.AreEqual("Please specify one of either a FilePath or the ContentBody to be PUT as an S3 object.", actual.Message);
        }

        [TestMethod]
        public async Task PutObject_ContentAndStream()
        {
            using (var fStream = new FileStream(testFileName, FileMode.Open))
            {
                var request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "PutObjectTest",
                    ContentBody = "CAT",
                    InputStream = fStream
                };

                var actual = await Assert.ThrowsExceptionAsync<ArgumentException>(() => Client.PutObjectAsync(request));
                Assert.AreEqual("Please specify one of either an InputStream or the ContentBody to be PUT as an S3 object.", actual.Message);
            }
        }

        [TestMethod]
        public async Task PutObject_StreamAndFile()
        {
            using (var fStream = new FileStream(testFileName, FileMode.Open))
            {
                var request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "PutObjectTest",
                    InputStream = fStream,
                    FilePath = testFileName
                };

                var actual = await Assert.ThrowsExceptionAsync<ArgumentException>(() => Client.PutObjectAsync(request));
                Assert.AreEqual("Please specify one of either an InputStream or a FilePath to be PUT as an S3 object.", actual.Message);
            }
        }

        [TestMethod]
        public async Task PutObject_KeyFromPath()
        {
            string path = testFileName;
            await TestKeyFromPath(path);
            
            string fullPath = Path.GetFullPath(path);
            await TestKeyFromPath(fullPath);
            
            string fullPathUnix = fullPath.Replace('\\', '/');
            await TestKeyFromPath(fullPathUnix);
        }

        private async Task TestKeyFromPath(string path)
        {
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                FilePath = path
            });

            string key = Path.GetFileName(path);
            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest 
            { 
                BucketName = bucketName, 
                Key = key
            });
            Assert.IsNotNull(metadata);
            Assert.IsTrue(metadata.ContentLength > 0);

            await Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });
        }

        [TestMethod]
        public async Task PutObject_FileNameOnly()
        {
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                FilePath = testFileName
            });
        }

        [TestMethod]
        public async Task PutObject_FileNameNotExist()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                FilePath = "FileThatDoesntExist"
            };

            await Assert.ThrowsExceptionAsync<FileNotFoundException>(() => Client.PutObjectAsync(request));
        }

        [TestMethod]
        public async Task PutObject_StreamChecksumEnabled()
        {
            using (var fStream = new FileStream(testFileName, FileMode.Open))
            {
                await Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "PutObjectStreamChecksum" + random.Next(),
                    InputStream = fStream
                });
            }
        }

        [TestMethod]
        public async Task PutBucketPutObjectACLTest()
        {
            var aclBucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, true);
            try
            {
                var getBucketAclResponse = await Client.GetBucketAclAsync(new GetBucketAclRequest
                {
                    BucketName = aclBucketName,
                });
                
                await Client.PutBucketAclAsync(new PutBucketAclRequest
                {
                    BucketName = aclBucketName,
                    AccessControlPolicy = new S3AccessControlList
                    {
                        Grants = new List<S3Grant>
                        {
                            new S3Grant
                            {
                                Grantee = new S3Grantee
                                {
                                    URI = "http://acs.amazonaws.com/groups/s3/LogDelivery",
                                },
                                Permission = S3Permission.READ
                            },
                        },
                        Owner = getBucketAclResponse.Owner,
                    },
                });

                var getBucketAclResponse2 = await Client.GetBucketAclAsync(new GetBucketAclRequest
                {
                    BucketName = aclBucketName,
                });
                getBucketAclResponse2.Grants.ForEach(grant =>
                {
                    Assert.AreEqual("http://acs.amazonaws.com/groups/s3/LogDelivery", grant.Grantee.URI);
                    Assert.AreEqual(S3Permission.READ, grant.Permission);
                });

                await Client.PutObjectAsync(new PutObjectRequest
                {
                    Key = "putobjectwithacl",
                    ContentBody = "randomstuff",
                    BucketName = aclBucketName,
                });

                await Client.PutObjectAclAsync(new PutObjectAclRequest
                {
                    BucketName = aclBucketName,
                    Key = "putobjectwithacl",
                    AccessControlPolicy = new S3AccessControlList
                    {
                        Grants = new List<S3Grant>
                        {
                            new S3Grant
                            {
                                Grantee = new S3Grantee
                                {
                                    URI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers",
                                },
                                Permission = S3Permission.READ
                            },
                        },
                        Owner = getBucketAclResponse.Owner,
                    },
                });

                var getObjectAclResponse = await Client.GetObjectAclAsync(new GetObjectAclRequest
                {
                    Key = "putobjectwithacl",
                    BucketName = aclBucketName,
                });
                getObjectAclResponse.Grants.ForEach(grant =>
                {
                    Assert.AreEqual("http://acs.amazonaws.com/groups/global/AuthenticatedUsers", grant.Grantee.URI);
                    Assert.AreEqual(S3Permission.READ, grant.Permission);
                });
            }
            finally 
            {                 
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, aclBucketName);
            }
        }

        [TestMethod]
        public async Task PutObjectWithACL()
        {
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "putobjectwithacl",
                ContentBody = "Some Random Nonsense",
                Grants = new List<S3Grant>
                {
                    new S3Grant
                    {
                        Grantee = new S3Grantee
                        {
                            URI = "http://acs.amazonaws.com/groups/global/AllUsers"
                        },
                        Permission = S3Permission.READ
                    },
                    new S3Grant
                    {
                        Grantee = new S3Grantee
                        {
                            URI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers"
                        },
                        Permission = S3Permission.READ
                    }
                }
            });

            var acl = (await Client.GetACLAsync(new GetACLRequest { BucketName = bucketName, Key = "putobjectwithacl" })).AccessControlList;
            Assert.AreEqual(2, acl.Grants.Count);

            await Client.PutACLAsync(new PutACLRequest
            {
                BucketName = bucketName,
                Key = "putobjectwithacl",
                AccessControlList = new S3AccessControlList
                {
                    Grants = new List<S3Grant>
                    {
                        new S3Grant
                        {
                            Grantee = new S3Grantee { URI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers"},
                            Permission = S3Permission.READ,
                        },
                    },
                    Owner = acl.Owner
                },
            });
                        
            acl = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetACLAsync(new GetACLRequest() { BucketName = bucketName, Key = "putobjectwithacl" });
                return res.AccessControlList?.Grants?.Count > 0 ? res.AccessControlList : null;
            });            
            Assert.AreEqual(1, acl.Grants.Count);
        }

        [TestMethod]
        public async Task PutBucketWithCannedACL()
        {
            var aclBucketName = "dotnet-integtests-cannedacl" + DateTime.UtcNow.Ticks;
            await Client.PutBucketAsync(new PutBucketRequest 
            { 
                BucketName = aclBucketName, 
                CannedACL = S3CannedACL.LogDeliveryWrite, 
                ObjectOwnership = ObjectOwnership.ObjectWriter 
            });

            var acl = (await Client.GetACLAsync(new GetACLRequest { BucketName = aclBucketName })).AccessControlList;
            await Client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = aclBucketName });

            // should only have seen grants for full_control to test owner, LogDelivery read_acp and LogDelivery write
            Assert.AreEqual(3, acl.Grants.Count);
            foreach (var grant in acl.Grants)
            {
                if (!string.IsNullOrEmpty(grant.Grantee.DisplayName))
                {
                    Assert.IsNotNull(grant.Grantee.DisplayName);
                    Assert.AreEqual(S3Permission.FULL_CONTROL, grant.Permission);
                }
                else if (!string.IsNullOrEmpty(grant.Grantee.CanonicalUser))
                {
                    Assert.IsNotNull(grant.Grantee.CanonicalUser);
                    Assert.AreEqual(S3Permission.FULL_CONTROL, grant.Permission);
                }
                else
                {
                    Assert.AreEqual("http://acs.amazonaws.com/groups/s3/LogDelivery", grant.Grantee.URI);
                    Assert.IsTrue(grant.Permission == S3Permission.READ_ACP || grant.Permission == S3Permission.WRITE);
                }
            }
        }

        [TestMethod]
        public async Task PutObjectWithContentLength()
        {
            string sourceKey = "source";
            string destKey = "dest";
            string contents = "Sample contents";
            int length = contents.Length;

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = sourceKey,
                ContentBody = contents
            });

            // Disable clock skew testing when generating a presigned url
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                string url = Client.GetPreSignedURL(new GetPreSignedUrlRequest
                {
                    BucketName = bucketName,
                    Key = sourceKey,
                    Expires = DateTime.UtcNow + TimeSpan.FromHours(2)
                });

                var httpRequest = WebRequest.Create(url) as HttpWebRequest;
                using (HttpWebResponse httpResponse = await httpRequest.GetResponseAsync() as HttpWebResponse)
                using (Stream stream = httpResponse.GetResponseStream())
                {
                    await PutStream(destKey, length, stream);
                }

                string finalContents = await GetContents(destKey);
                Assert.AreEqual(contents, finalContents);

                length -= 2;
                httpRequest = WebRequest.Create(url) as HttpWebRequest;
                using (HttpWebResponse httpResponse = await httpRequest.GetResponseAsync() as HttpWebResponse)
                using (Stream stream = httpResponse.GetResponseStream())
                {
                    await PutStream(destKey, length, stream);
                }

                finalContents = await GetContents(destKey);
                Assert.AreEqual(contents.Substring(0, length), finalContents);
            }
        }

        private async Task PutStream(string destKey, int length, Stream stream)
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = destKey,
                InputStream = stream,
            };
            request.Headers.ContentLength = length;
            
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                await Client.PutObjectAsync(request);
            }
        }

        private async Task<string> GetContents(string key)
        {
            var response = await Client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });

            using (StreamReader reader = new StreamReader(response.ResponseStream))
            {
                return await reader.ReadToEndAsync();
            }
        }

#if NETFRAMEWORK
        [TestMethod]
        public void TestStreamRetry()
        {
            var s3ClientBufferSize = new AmazonS3Config().BufferSize;
            var chunkedWrapperBufferSize = ChunkedUploadWrapperStream.DefaultChunkSize;

            var sizeForFailWithoutWriting = 0;
            var sizeForFailWithSomeWriting = chunkedWrapperBufferSize * 2;
            var arbitrarySizeForSuccess = s3ClientBufferSize * 2;
            var runs = 3;

            var exceptions = new List<Exception>();
            for (int i = 0; i < runs; i++)
            {
                exceptions.Add(TryTest(sizeForFailWithoutWriting, failRequest: true));
                exceptions.Add(TryTest(sizeForFailWithSomeWriting, failRequest: true));
                exceptions.Add(TryTest(arbitrarySizeForSuccess, failRequest: false));
            }

            exceptions = exceptions.Where(e => e != null).ToList();
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        private static Exception TryTest(int errorSize, bool failRequest)
        {
            try
            {
                Test(errorSize, failRequest);
                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        private static void Test(int errorSize, bool failRequest)
        {
            var actualSize = errorSize + 128;
            var bytes = CreateData(actualSize);

            // must precompute this and set in headers to avoid hash computation on ErrorStream
            // affecting the test
            var payloadhash = UtilityMethods.ToHex(UtilityMethods.ComputeSHA256(bytes), true);

            ErrorStream es = ErrorStream.Create(bytes);
            if (failRequest)
                es.MaxReadBytes = errorSize;
            // 1 rewind for S3 pre-marshallers which reset position to 0
            // 1 rewind for exception at error size
            es.MinRewinds = 2;

            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "foo1",
                AutoCloseStream = false
            };
            putRequest.Headers["x-amz-content-sha256"] = payloadhash;
            putRequest.InputStream = es;

            CallWithTimeout(() => Client.PutObject(putRequest), TimeSpan.FromSeconds(10));
        }

        static void CallWithTimeout(Action action, TimeSpan timeout)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                action();
                return;
            }

            Thread threadToKill = null;
            Action wrappedAction = () =>
            {
                threadToKill = Thread.CurrentThread;
                action();
            };

            IAsyncResult result = wrappedAction.BeginInvoke(null, null);
            if (result.AsyncWaitHandle.WaitOne(timeout))
            {
                wrappedAction.EndInvoke(result);
            }
            else
            {
                threadToKill.Abort();
                throw new TimeoutException();
            }
        }

        private static byte[] CreateData(int size)
        {
            var data = new byte[size];
            for (int i = 0; i < size; i++)
            {
                var c = (i % 26) + 'a';
                data[i] = (byte)c;
            }
            return data;
        }
#endif

        private static async Task VerifyPut(string data, PutObjectRequest putRequest)
        {
            var getRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = putRequest.Key
            };
            
            using (var response = await Client.GetObjectAsync(getRequest))
            using (var responseStream = response.ResponseStream)
            using (StreamReader reader = new StreamReader(responseStream))
            {
                var responseData = await reader.ReadToEndAsync();
                Assert.AreEqual(data, responseData);
                
                if (putRequest.StorageClass != null && putRequest.StorageClass != S3StorageClass.Standard)
                {
                    Assert.IsNotNull(response.StorageClass);
                    Assert.AreEqual(putRequest.StorageClass, response.StorageClass);
                }
            }
        }

        [TestMethod]
        public async Task TestResetStreamPosition()
        {
            var stream = new MemoryStream();
            for (int i = 0; i < 10; i++)
            {
                stream.WriteByte((byte)i);
            }
            Assert.AreEqual(stream.Position, stream.Length);

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "thestream",
                InputStream = stream,
                AutoCloseStream = false
            };
            await Client.PutObjectAsync(putObjectRequest);

            var getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = "thestream"
            };
            using (var getObjectResponse = await Client.GetObjectAsync(getObjectRequest))
            {
                Assert.AreEqual(stream.Length, getObjectResponse.ContentLength);
            }

            stream.Seek(5, SeekOrigin.Begin);
            putObjectRequest.InputStream = stream;
            putObjectRequest.AutoResetStreamPosition = false;
            await Client.PutObjectAsync(putObjectRequest);

            using (var getObjectResponse = await Client.GetObjectAsync(getObjectRequest))
            {
                Assert.AreEqual(stream.Length - 5, getObjectResponse.ContentLength);
            }
        }

        [TestMethod]
        public async Task ConfirmRetrySignature()
        {
            var s3Client = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = Client.Config.RegionEndpoint,
                ResignRetries = true
            });

            // This test is response to this PR https://github.com/aws/aws-sdk-net/pull/4050 
            // where retries started failing with signature mismatch due to user agent modifications.
            // In this test we are confirming all retries are attempted and not failing with signature mismatch.
            var stream = new FailOnceStream(new MemoryStream(Encoding.UTF8.GetBytes("ConfirmRetrySignature")));
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "thestream",
                InputStream = stream,
                AutoCloseStream = false,
                DisablePayloadSigning = true
            };

            ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).UserAgentDetails.AddUserAgentComponent("Modifications");
            await s3Client.PutObjectAsync(request);
        }

        private class FailOnceStream : WrapperStream
        {
            public FailOnceStream(MemoryStream memoryStream)
                : base(memoryStream)
            {
            }

            bool _firstRead = true;


            public override int Read(byte[] buffer, int offset, int count)
            {
                if (_firstRead)
                {
                    _firstRead = false;
                    throw new IOException("Fake Exception");
                }
                return base.Read(buffer, offset, count);
            }
            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                if (_firstRead)
                {
                    _firstRead = false;
                    throw new IOException("Fake Exception");
                }
                return base.ReadAsync(buffer, offset, count, cancellationToken);
            }
        }

        private class ErrorStream : WrapperStream
        {
            private ErrorStream(Stream stream)
                : base(stream)
            {
                MaxReadBytes = -1;
                MinRewinds = -1;
            }

            public static ErrorStream Create(byte[] bytes, bool readOnly = false)
            {
                long length = -1;
                Stream stream;
                if (readOnly)
                {
                    var compressedStream = new MemoryStream(Compress(bytes));
                    stream = new GZipStream(compressedStream, CompressionMode.Decompress);
                    length = compressedStream.Length;
                }
                else
                {
                    stream = new MemoryStream(bytes);
                }
                return new ErrorStream(stream);
            }

            private static byte[] Compress(byte[] bytes)
            {
                MemoryStream dataStream;
                using (dataStream = new MemoryStream())
                using (GZipStream compress = new GZipStream(dataStream, CompressionMode.Compress))
                {
                    compress.Write(bytes, 0, bytes.Length);
                }
                var compressedData = dataStream.ToArray();
                return compressedData;
            }

            public int MaxReadBytes { get; set; }
            public int MinRewinds { get; set; }
            public event EventHandler OnRead;
            public int TotalReadBytes { get; private set; }
            public int Rewinds { get; private set; }

            public override int Read(byte[] buffer, int offset, int count)
            {
                if (OnRead != null)
                    OnRead(this, null);

                var readCount = base.Read(buffer, offset, count);
                TotalReadBytes += readCount;

                ValidateRead(MaxReadBytes, TotalReadBytes, MinRewinds, Rewinds);

                return readCount;
            }

            public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                if (OnRead != null)
                    OnRead(this, null);

                var readCount = await base.ReadAsync(buffer, offset, count, cancellationToken);
                TotalReadBytes += readCount;

                ValidateRead(MaxReadBytes, TotalReadBytes, MinRewinds, Rewinds);

                return readCount;
            }

            private void ValidateRead(int MaxReadBytes, int TotalReadBytes, int MinRewinds, int Rewinds)
            {
                bool throwBasedOnReadBytes = MaxReadBytes >= 0 && TotalReadBytes >= MaxReadBytes;
                bool suppressThrowBasedOnRewinds = MinRewinds >= 0 && Rewinds >= MinRewinds;

                if (throwBasedOnReadBytes && !suppressThrowBasedOnRewinds)
                    throw new IOException("Fake Exception");
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                var value = base.Seek(offset, origin);
                TotalReadBytes = 0;
                Rewinds++;
                return value;
            }
            public override long Position
            {
                get
                {
                    return base.Position;
                }
                set
                {
                    this.Seek(value, SeekOrigin.Begin);
                }
            }
        }

        private class NonRewindableStream : MemoryStream
        {
            public override bool CanSeek => false;
        }
    }
}
