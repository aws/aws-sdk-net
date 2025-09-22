using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Diagnostics;
using Amazon.Util;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class PutObjectTest : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private Random random = new Random();
        private static string bucketName;
        private const string testContent = "This is the content body!";
        private const string testKey = "test-key.json.gz";

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            StreamWriter writer = File.CreateText("PutObjectFile.txt");
            writer.Write("This is some sample text.!!");
            writer.Close();

            bucketName = S3TestUtils.CreateBucketWithWait(Client, true);
        }


        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestPutAndGetWithInvalidExpires()
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
            Client.PutObject(putObjectRequest);

            var newExpires = DateTime.UtcNow.AddDays(1);
            var getObjectResponse = Client.GetObject(bucketName, key);
            using (getObjectResponse)
            {
                var reader = new StreamReader(getObjectResponse.ResponseStream);
                var contentRead = reader.ReadToEnd();
                Assert.IsTrue(content.Equals(contentRead));

                Assert.AreEqual(getObjectResponse.ExpiresString, invalidValue);
            }
            var getObjectMetadataResponse = Client.GetObjectMetadata(bucketName, key);

            Assert.AreEqual(getObjectMetadataResponse.ExpiresString, invalidValue);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestPutAndGetWithBidiCharacters()
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
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = bidiKey,
                ContentBody = content
            };
                        
            Client.PutObject(putObjectRequest);

            // Verify the bidi key object can be read
            var response = Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = bidiKey,
            });

            // Read S3 bucket response content
            var responseBody = string.Empty;
            using (var reader = new StreamReader(response.ResponseStream))
            {
                responseBody = reader.ReadToEnd();                
            }

            // Verify the correct response was read
            Assert.IsTrue(content == responseBody);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestStorageClass()
        {
            var key = "contentBodyPut" + random.Next();
            var storageClass = S3StorageClass.ReducedRedundancy;
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead,
                StorageClass = storageClass
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            PutObjectResponse response = Client.PutObject(request);

            Console.WriteLine("S3 generated ETag: {0}", response.ETag);
            Assert.IsTrue(response.ETag.Length > 0);

            var metadata = Client.GetObjectMetadata(bucketName, key);
            Assert.IsNotNull(metadata);
            Assert.IsNotNull(metadata.StorageClass);
            Assert.AreEqual(metadata.StorageClass, storageClass);

            VerifyPut(testContent, request);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestHttpErrorResponseUnmarshalling()
        {
            try
            {
                Client.PutObject(new PutObjectRequest
                {
                    BucketName = UtilityMethods.GenerateName("NonExistentBucket"),
                    Key = "1",
                    ContentBody = "TestContent"
                });
            }
            catch (AmazonS3Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.ErrorCode);
                Console.WriteLine(exception.StatusCode);

                Assert.IsTrue(exception.Message.Contains("The specified bucket does not exist"));
                Assert.AreEqual("NoSuchBucket", exception.ErrorCode);
                Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
            }
        }

 #if ASYNC_AWAIT

        [TestMethod]
        [TestCategory("S3")]
        public async System.Threading.Tasks.Task PutObjectAsync()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            PutObjectResponse response = await Client.PutObjectAsync(request);

            Console.WriteLine("S3 generated ETag: {0}", response.ETag);
            Assert.IsTrue(response.ETag.Length > 0);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async System.Threading.Tasks.Task PutObjectCancellationTest()
        {
            var fileName = UtilityMethods.GenerateName(@"CancellationTest\LargeFile");
            string basePath = @"c:\temp\test\";
            var path = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(path, 50 * MEG_SIZE);

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "CancellationTest" + random.Next(),
                CannedACL = S3CannedACL.AuthenticatedRead,
                FilePath = path
            };

            var cts = new CancellationTokenSource();
            cts.CancelAfter(1000);
            var token = cts.Token;
            try
            {
                await Client.PutObjectAsync(putObjectRequest, token);
            }
            catch(OperationCanceledException exception)
            {
                Assert.AreEqual(token, exception.CancellationToken);
                Assert.AreEqual(true, exception.CancellationToken.IsCancellationRequested);
                return;
            }
            finally
            {
                Directory.Delete(basePath, true);
            }
            Assert.Fail("An OperationCanceledException was not thrown");
        }
#endif
        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectWithExternalEndpoint()
        {            
            var s3Client = new AmazonS3Client(new AmazonS3Config
            {
                ServiceURL = "https://s3-external-1.amazonaws.com"
            });
            var testBucketName = "aws-net-sdk-external" + random.Next();
            var key = "testKey";
            try
            {
                
                s3Client.PutBucket(testBucketName);
                S3TestUtils.WaitForBucket(s3Client, testBucketName);

                s3Client.PutObject(new PutObjectRequest
                {
                    BucketName = testBucketName,
                    Key = key,
                    ContentBody = "testValue"
                });

                s3Client.GetObject(testBucketName, key);
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(s3Client, testBucketName);
                s3Client.Dispose();
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectWithLeadingSlash()
        {
            using(var client = new AmazonS3Client())
            {
                PutObjectRequest request = new PutObjectRequest()
                {
                    BucketName = bucketName,
                    Key = "/contentBodyPut" + random.Next(),
                    ContentBody = "This is the content body!",
                    CannedACL = S3CannedACL.AuthenticatedRead
                };
                request.Metadata.Add("Subject", "Content-As-Object");
                PutObjectResponse response = client.PutObject(request);

                Console.WriteLine("S3 generated ETag: {0}", response.ETag);
                Assert.IsTrue(response.ETag.Length > 0);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectKeyWithUrlEncodedCharacters()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "X$abc,xyz",
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            PutObjectResponse response = Client.PutObject(request);

            Console.WriteLine("S3 generated ETag: {0}", response.ETag);
            Assert.IsTrue(response.ETag.Length > 0);

            VerifyPut(testContent, request);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObject()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            PutObjectResponse response = Client.PutObject(request);

            Console.WriteLine("S3 generated ETag: {0}", response.ETag);
            Assert.IsTrue(response.ETag.Length > 0);

            VerifyPut(testContent, request);
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow(false, false)]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(true, true)]
        public void PutObjectWithEmptyInputStream(bool disablePayloadSigning, bool disableDefaultChecksumValidation)
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "inputStreamPut" + random.Next(),
                InputStream = new MemoryStream(),
                DisableDefaultChecksumValidation = disableDefaultChecksumValidation,
                DisablePayloadSigning = disablePayloadSigning,
            };
            PutObjectResponse response = Client.PutObject(request);

            Assert.IsTrue(response.ETag.Length > 0);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObject_SigV4()
        {
            using (var client = new AmazonS3Client())
            {
                RetryUtilities.ConfigureClient(client);

                PutObjectRequest request = new PutObjectRequest()
                {
                    BucketName = bucketName,
                    Key = "contentBodyPut" + random.Next(),
                    ContentBody = "This is the content body!",
                    CannedACL = S3CannedACL.AuthenticatedRead
                };
                request.Metadata.Add("Subject", "Content-As-Object");
                PutObjectResponse response = client.PutObject(request);

                Console.WriteLine("S3 generated ETag: {0}", response.ETag);
                Assert.IsTrue(response.ETag.Length > 0);
            }
        }


        [TestMethod]
        [TestCategory("S3")]
        public void PutObject_WithExpires()
        {
            var key = "contentBodyPut" + random.Next();
            var expires = DateTime.UtcNow.AddYears(5);
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead,
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            request.Headers.Expires = expires;
            PutObjectResponse response = Client.PutObject(request);

            Console.WriteLine("S3 generated ETag: {0}", response.ETag);
            Assert.IsTrue(response.ETag.Length > 0);

            using (var getResponse = Client.GetObject(new GetObjectRequest { BucketName = bucketName, Key = key }))
            {
                Assert.IsTrue(expires.ApproximatelyEqual(DateTime.Parse(getResponse.ExpiresString, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AssumeUniversal).ToUniversalTime()));
            }
        }

        [TestCategory("S3")]
        [TestMethod]
        public void PutObjectWeirdKeys()
        {
            var keys = new List<string>
            {
                "b204a53f-781a-4cdd-a29c-3626818eb199:115740.pdf",
                "46dbc16e-5f55-4bda-b275-75e2a8ab243c:115740.pdf"
            };

            string filePath = "SomeFile.txt";
            string contents = "Sample content";
            File.WriteAllText(filePath, contents);

            foreach (var key in keys)
            {
                var request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    FilePath = filePath,
                };

                Client.PutObject(request);
                using (var response = Client.GetObject(new GetObjectRequest { BucketName = bucketName, Key = key }))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var rtContents = reader.ReadToEnd();
                    Assert.IsNotNull(rtContents);
                    Assert.AreEqual(contents, rtContents);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectWithBacklashInKey()
        {
            const string writtenContent = @"an object with a \ in the key";
            const string key = @"My\Key";

            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = writtenContent,
            };
            Client.PutObject(request);

            using (var response = Client.GetObject(new GetObjectRequest { BucketName = bucketName, Key = key }))
            using (var reader = new StreamReader(response.ResponseStream))
            {
                var readContent = reader.ReadToEnd();
                Assert.AreEqual(readContent, writtenContent);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectWrongRegion()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            using (var client = new AmazonS3Client(RegionEndpoint.USWest2))
            {
                // Returns an exception with HTTP 301 MovedPermanently
                var exception = AssertExtensions.ExpectException<AmazonS3Exception>(() => client.PutObject(request));
                Assert.AreEqual("PermanentRedirect", exception.ErrorCode);
                Assert.AreEqual(HttpStatusCode.MovedPermanently, exception.StatusCode);
                Assert.IsFalse(string.IsNullOrEmpty(exception.Message));
                Assert.IsFalse(string.IsNullOrEmpty(exception.RequestId));
                Assert.IsFalse(string.IsNullOrEmpty(exception.AmazonId2));
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectWithNonMatchingEtag()
        {
            var key = "TestMatchingEtag" + random.Next();
            var request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            Client.PutObject(request);

            var etag = Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            }).ETag;

            // Returns an exception with HTTP 304 NotModified
            var exception = AssertExtensions.ExpectException<AmazonS3Exception>(() =>
                Client.GetObject(new GetObjectRequest
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
        [TestCategory("S3")]
        public void TemporaryRedirectForS3OperationsWithSigV4()
        {
            TemporaryRedirectForS3Operations();
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("S3")]
        public void TemporaryRedirectForS3Operations()
        {            
            var testBucketName = UtilityMethods.GenerateName(UtilityMethods.SDK_TEST_PREFIX);
            var config = new AmazonS3Config
            {
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            };

            using (var client = new AmazonS3Client(config))
            {
                var bucket = client.PutBucket(new PutBucketRequest
                {
                    BucketName = testBucketName,
                    BucketRegion = S3Region.USWest2
                });
                S3TestUtils.WaitForBucket(client, testBucketName);

                try
                {
                    client.PutObject(new PutObjectRequest
                    {
                        BucketName = testBucketName,
                        Key = "TestKey1",
                        ContentBody = "sample text"
                    });

                    client.PutObject(new PutObjectRequest
                    {
                        BucketName = testBucketName,
                        Key = "TestKey2",
                        InputStream = UtilityMethods.CreateStreamFromString("sample text")
                    });

                    // Returns an exception with HTTP 307 TemporaryRedirect
                    var exception = AssertExtensions.ExpectException<AmazonS3Exception>(() =>
                        client.PutObject(new PutObjectRequest
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


                    var objects = client.ListObjects(new ListObjectsRequest
                    {
                        BucketName = testBucketName
                    }).S3Objects;
                    Assert.AreEqual(2, objects.Count);
                }
                finally
                {
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testBucketName);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DeleteNonExistentBucket()
        {
            // Returns an exception with HTTP 404 NotFound
            var exception = AssertExtensions.ExpectException<AmazonS3Exception>(() =>
                Client.DeleteBucket(new DeleteBucketRequest { BucketName = "nonexistentbucket1234567890" })
            );
            Assert.AreEqual("NoSuchBucket", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
            Assert.IsFalse(string.IsNullOrEmpty(exception.Message));
            Assert.IsFalse(string.IsNullOrEmpty(exception.RequestId));
            Assert.IsFalse(string.IsNullOrEmpty(exception.AmazonId2));

        }

        [TestMethod]
        [TestCategory("S3")]
        public void GzipTest()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "gzip";

            TestPutAndGet(request);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectWithContentEncodingTests()
        {
            PutObjectWithContentEncoding();
            PutObjectWithContentEncodingIdentity();
            PutObjectWithoutContentEncoding();
        }

        private void PutObjectWithContentEncoding()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "gzip";
            request.Headers.ContentDisposition = "disposition";

            var headers = TestPutAndGet(request);
            Assert.AreEqual("disposition", headers.ContentDisposition);
            Assert.AreEqual("gzip", headers.ContentEncoding);
        }
        private void PutObjectWithContentEncodingIdentity()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "identity";
            request.Headers.ContentDisposition = "disposition";

            var headers = TestPutAndGet(request);
            Assert.AreEqual("disposition", headers.ContentDisposition);
            Assert.AreEqual("identity", headers.ContentEncoding);
        }
        private void PutObjectWithoutContentEncoding()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentDisposition = "disposition";

            var headers = TestPutAndGet(request);
            Assert.AreEqual("disposition", headers.ContentDisposition);
            Assert.IsNull(headers.ContentEncoding);
        }

        private HeadersCollection TestPutAndGet(PutObjectRequest request)
        {
            Client.PutObject(request);

            var key = request.Key;

            using (var response = Client.GetObject(bucketName, key))
            using (var reader = new StreamReader(response.ResponseStream))
            {
                var contents = reader.ReadToEnd();
                Assert.AreEqual(testContent, contents);
            }
            using (var response = Client.GetObject(bucketName, key))
            {
                response.WriteResponseStreamToFile(key, false);

                var contents = File.ReadAllText(key);
                Assert.AreEqual(testContent, contents);
            }

            var meta = Client.GetObjectMetadata(bucketName, key);
            return meta.Headers;
        }
        private PutObjectRequest CreatePutObjectRequest()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = DateTime.UtcNow.ToFileTime() + testKey,
                ContentBody = testContent
            };
            return request;
        }


        [TestMethod]
        [TestCategory("S3")]
        public void PutEmptyFile()
        {
            string key = "contentBodyPut" + random.Next();
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.ContentBody = string.Empty;
            PutObjectResponse response = Client.PutObject(request);

            using (GetObjectResponse getResponse = Client.GetObject(new GetObjectRequest() { BucketName = bucketName, Key = key }))
            {
                Assert.AreEqual(0, getResponse.ContentLength);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectLeaveStreamOpen()
        {
            string filepath = @"c:\temp\PutObjectLeaveStreamOpen.txt";
            string key = "PutObjectLeaveStreamOpen" + random.Next();
            writeContent(@"c:\temp", "PutObjectLeaveStreamOpen.txt", "abcdefghighfsldfsdfn");
            try
            {
                Stream stream = File.OpenRead(filepath);

                PutObjectRequest request = new PutObjectRequest();
                request.BucketName = bucketName;
                request.Key = key;
                request.InputStream = stream;
                Client.PutObject(request);

                Assert.IsFalse(stream.CanSeek, "Stream should be closed and seek should not be allowed");

                stream = File.OpenRead(filepath);
                request = new PutObjectRequest();
                request.BucketName = bucketName;
                request.Key = key;
                request.AutoCloseStream = false;
                request.InputStream = stream;
                Client.PutObject(request);

                Assert.IsTrue(stream.CanSeek, "Stream should still be open and seek should be allowed");

                stream.Close();
            }
            finally
            {
                File.Delete(filepath);
                try
                {
                    Client.DeleteObject(new DeleteObjectRequest() { BucketName = bucketName, Key = key });
                }
                catch { }
            }
        }

        private void writeContent(string directory, string fileName, string content)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            StreamWriter writer = new StreamWriter(directory + "/" + fileName);
            writer.Write(content);
            writer.Close();
        }


        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(ArgumentException))]
        public void PutObject_ContentAndFile()
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.Key = "PutObjectTest";
            request.ContentBody = "CAT";
            request.FilePath = "PutObjectFile.txt";

            try
            {
                Client.PutObject(request);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual<string>("Please specify one of either a FilePath or the ContentBody to be PUT as an S3 object.", ex.Message);
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(ArgumentException), "Please specify one of either an InputStream or the ContentBody to be PUT as an S3 object.")]
        public void PutObject_ContentAndStream()
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.Key = "PutObjectTest";
            request.ContentBody = "CAT";
            using (FileStream fStream = new FileStream("PutObjectFile.txt", FileMode.Open))
            {
                request.InputStream = fStream;

                try
                {
                    Client.PutObject(request);
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual<string>("Please specify one of either an InputStream or the ContentBody to be PUT as an S3 object.", ex.Message);
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(ArgumentException), "Please specify one of either an Input FileStream or a Filename to be PUT as an S3 object.")]
        public void PutObject_StreamAndFile()
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.Key = "PutObjectTest";
            using (FileStream fStream = new FileStream("PutObjectFile.txt", FileMode.Open))
            {
                request.InputStream = fStream;
                request.FilePath = "PutObjectFile.txt";

                try
                {
                    Client.PutObject(request);
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual<string>("Please specify one of either an InputStream or a FilePath to be PUT as an S3 object.", ex.Message);
                    Console.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObject_KeyFromPath()
        {
            string path = "PutObjectFile.txt";
            TestKeyFromPath(path);
            string fullPath = Path.GetFullPath(path);
            TestKeyFromPath(fullPath);
            string fullPathUnix = fullPath.Replace('\\', '/');
            TestKeyFromPath(fullPathUnix);
        }

        private void TestKeyFromPath(string path)
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.FilePath = path;
            Client.PutObject(request);

            string key = Path.GetFileName(path);
            var metadataRequest = new GetObjectMetadataRequest { BucketName = bucketName, Key = key };
            var metadata = Client.GetObjectMetadata(metadataRequest);
            Assert.IsNotNull(metadata);
            Assert.IsTrue(metadata.ContentLength > 0);

            Client.DeleteObject(new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });

            AssertExtensions.ExpectException(() => Client.GetObjectMetadata(metadataRequest));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObject_FileNameOnly()
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.FilePath = "PutObjectFile.txt";
            Client.PutObject(request);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(FileNotFoundException))]
        public void PutObject_FileNameNotExist()
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.FilePath = "FileThatDoesntExist";
            try
            {
                Client.PutObject(request);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
        }


        [TestMethod]
        [TestCategory("S3")]
        public void PutObject_StreamChecksumEnabled()
        {
            PutObjectRequest request = new PutObjectRequest();
            request.BucketName = bucketName;
            request.Key = "PutObjectStreamChecksum" + random.Next();

            using (FileStream fStream = new FileStream("PutObjectFile.txt", FileMode.Open))
            {
                request.InputStream = fStream;
                Client.PutObject(request);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutBucketPutObjectACLTest()
        {
            var aclBucketName = S3TestUtils.CreateBucketWithWait(Client, true);
            try
            {
                Client.PutBucket(new PutBucketRequest
                {
                    BucketName = aclBucketName,
                });
                var getBucketAclResponse = Client.GetBucketAcl(new GetBucketAclRequest
                {
                    BucketName = aclBucketName,
                });
                S3TestUtils.WaitForBucket(Client, aclBucketName);
                var response = Client.PutBucketAcl(new PutBucketAclRequest
                {
                    BucketName = aclBucketName,
                    AccessControlPolicy = new S3AccessControlList
                    {
                        Grants = new List<S3Grant>()
                    {
                        new S3Grant()
                        {
                            Grantee = new S3Grantee()
                            {
                                URI = "http://acs.amazonaws.com/groups/s3/LogDelivery",
                            },
                            Permission = S3Permission.READ
                        },
                    },
                        Owner = getBucketAclResponse.Owner,
                    },
                });
                var getBucketAclResponse2 = Client.GetBucketAcl(new GetBucketAclRequest
                {
                    BucketName = aclBucketName,
                });
                getBucketAclResponse2.Grants.ForEach(grant =>
                {
                    Assert.IsTrue(grant.Grantee.URI == "http://acs.amazonaws.com/groups/s3/LogDelivery");
                    Assert.IsTrue(grant.Permission == S3Permission.READ);
                });

                Client.PutObject(new PutObjectRequest
                {
                    Key = "putobjectwithacl",
                    ContentBody = "randomstuff",
                    BucketName = aclBucketName,
                });
                Client.PutObjectAcl(new PutObjectAclRequest
                {
                    BucketName = aclBucketName,
                    Key = "putobjectwithacl",
                    AccessControlPolicy = new S3AccessControlList
                    {
                        Grants = new List<S3Grant>()
                    {
                        new S3Grant()
                        {
                            Grantee = new S3Grantee()
                            {
                                URI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers",
                            },
                            Permission = S3Permission.READ
                        },
                    },
                        Owner = getBucketAclResponse.Owner,
                    },
                });
                var getObjectAclResponse = Client.GetObjectAcl(new GetObjectAclRequest
                {
                    Key = "putobjectwithacl",
                    BucketName = aclBucketName,
                });

                getObjectAclResponse.Grants.ForEach(grant =>
                {
                    Assert.IsTrue(grant.Grantee.URI == "http://acs.amazonaws.com/groups/global/AuthenticatedUsers");
                    Assert.IsTrue(grant.Permission == S3Permission.READ);
                });
            }
            finally 
            {                 
                AmazonS3Util.DeleteS3BucketWithObjects(Client, aclBucketName);
            }

        }
        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectWithACL()
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "putobjectwithacl",
                ContentBody = "Some Random Nonsense",
                Grants = new List<S3Grant>()
                {
                    //new S3Grant(){Grantee = new S3Grantee(){EmailAddress = "pavel@amazon.com"}, Permission = S3Permission.FULL_CONTROL},
                    //new S3Grant(){Grantee = new S3Grantee(){EmailAddress = "aws-dr-tools-test@amazon.com"}, Permission = S3Permission.FULL_CONTROL},
                    new S3Grant(){Grantee = new S3Grantee(){URI = "http://acs.amazonaws.com/groups/global/AllUsers"}, Permission = S3Permission.READ},
                    new S3Grant(){Grantee = new S3Grantee { URI = "http://acs.amazonaws.com/groups/global/AuthenticatedUsers"}, Permission = S3Permission.READ}
                }
            };

            Client.PutObject(request);

            var acl = Client.GetACL(new GetACLRequest() { BucketName = bucketName, Key = "putobjectwithacl" }).AccessControlList;
            Assert.AreEqual(2, acl.Grants.Count);
            foreach (var grant in acl.Grants)
            {
                var grantee = grant.Grantee;
                Console.WriteLine("Grantee:");
                if (!string.IsNullOrEmpty(grantee.URI))
                    Console.WriteLine("Uri: {0}", grantee.URI);
                if (!string.IsNullOrEmpty(grantee.EmailAddress))
                    Console.WriteLine("Email: {0}", grantee.EmailAddress);
                if (grantee.CanonicalUser != null && !string.IsNullOrEmpty(grantee.CanonicalUser))
                    Console.WriteLine("Canonical user: {0}", grantee.CanonicalUser);
                Console.WriteLine("Permissions: {0}", grant.Permission.ToString());
            }

            Client.PutACL(new PutACLRequest
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
                        
            acl = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetACL(new GetACLRequest() { BucketName = bucketName, Key = "putobjectwithacl" });
                return res.AccessControlList?.Grants?.Count > 0 ? res.AccessControlList : null;
            });            
            Assert.AreEqual(1, acl.Grants.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutBucketWithCannedACL()
        {
            string aclBucketName = "dotnet-integtests-cannedacl" + DateTime.UtcNow.Ticks;
            PutBucketRequest request = new PutBucketRequest() { BucketName = aclBucketName, CannedACL = S3CannedACL.LogDeliveryWrite, ObjectOwnership = ObjectOwnership.ObjectWriter };

            Client.PutBucket(request);
            S3TestUtils.WaitForBucket(Client, aclBucketName);

            var acl = Client.GetACL(new GetACLRequest() { BucketName = aclBucketName }).AccessControlList;
            Client.DeleteBucket(new DeleteBucketRequest() { BucketName = aclBucketName });

            // should only have seen grants for full_control to test owner, LogDelivery read_acp and LogDelivery write
            Assert.AreEqual(3, acl.Grants.Count);
            foreach (var grant in acl.Grants)
            {
                if (!string.IsNullOrEmpty(grant.Grantee.DisplayName))
                {
                    Assert.IsNotNull(grant.Grantee.DisplayName);
                    Assert.AreEqual<S3Permission>(S3Permission.FULL_CONTROL, grant.Permission);
                }
                else if (!string.IsNullOrEmpty(grant.Grantee.CanonicalUser))
                {
                    Assert.IsNotNull(grant.Grantee.CanonicalUser);
                    Assert.AreEqual<S3Permission>(S3Permission.FULL_CONTROL, grant.Permission);
                }
                else
                {
                    Assert.AreEqual<string>("http://acs.amazonaws.com/groups/s3/LogDelivery", grant.Grantee.URI);
                    Assert.IsTrue(grant.Permission == S3Permission.READ_ACP || grant.Permission == S3Permission.WRITE);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void PutObjectWithContentLength()
        {
            string sourceKey = "source";
            string destKey = "dest";
            string contents = "Sample contents";
            int length = contents.Length;
            Client.PutObject(new PutObjectRequest
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

                HttpWebRequest httpRequest = HttpWebRequest.Create(url) as HttpWebRequest;
                using (HttpWebResponse httpResponse = httpRequest.GetResponse() as HttpWebResponse)
                using (Stream stream = httpResponse.GetResponseStream())
                {
                    PutStream(destKey, length, stream);
                }
                string finalContents = GetContents(destKey);
                Assert.AreEqual(contents, finalContents);

                length -= 2;
                httpRequest = HttpWebRequest.Create(url) as HttpWebRequest;
                using (HttpWebResponse httpResponse = httpRequest.GetResponse() as HttpWebResponse)
                using (Stream stream = httpResponse.GetResponseStream())
                {
                    PutStream(destKey, length, stream);
                }
                finalContents = GetContents(destKey);
                Assert.AreEqual(contents.Substring(0, length), finalContents);
            }
        }

        private void PutStream(string destKey, int length, Stream stream)
        {
            PutObjectRequest request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = destKey,
                InputStream = stream,
            };
            request.Headers.ContentLength = length;
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                Client.PutObject(request);
            }
        }

        private string GetContents(string key)
        {
            Stream stream = Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            }).ResponseStream;

            using (stream)
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
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
#if ASYNC_AWAIT
                throw new AggregateException(exceptions);
#else
                throw exceptions.First();
#endif
        }

        private static Exception TryTest(int errorSize, bool failRequest)
        {
            try
            {
                Test(errorSize, failRequest);
                return null;
            }
            catch(Exception e)
            {
                return e;
            }
        }
        private static void Test(int errorSize, bool failRequest)
        {
            var actualSize = errorSize + 128;
            //var data = new string('@', actualSize + bufferSize);
            //byte[] bytes = Encoding.UTF8.GetBytes(data);
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
            for(int i=0;i<size;i++)
            {
                var c = (i % 26) + 'a';
                data[i] = (byte)c;
            }
            return data;
        }

        private static void VerifyPut(string data, PutObjectRequest putRequest)
        {
            var getRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = putRequest.Key
            };
            string responseData;
            using (var response = Client.GetObject(getRequest))
            using (var responseStream = response.ResponseStream)
            using (StreamReader reader = new StreamReader(responseStream))
            {
                responseData = reader.ReadToEnd();

                Assert.AreEqual(data, responseData);
                if (putRequest.StorageClass != null && putRequest.StorageClass != S3StorageClass.Standard)
                {
                    Assert.IsNotNull(response.StorageClass);
                    Assert.AreEqual(response.StorageClass, putRequest.StorageClass);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestResetStreamPosition()
        {
            MemoryStream stream = new MemoryStream();
            for (int i = 0; i < 10; i++)
            {
                stream.WriteByte((byte)i);
            }


            Assert.AreEqual(stream.Position, stream.Length);

            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "thestream",
                InputStream = stream,
                AutoCloseStream = false
            };
            Client.PutObject(request);

            var getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = "thestream"
            };

            for (int retries = 0; retries < 5; retries++)
            {
                Thread.Sleep(1000 * retries);
                try
                {
                    using (var getObjectResponse = Client.GetObject(getObjectRequest))
                    {
                        Assert.AreEqual(stream.Length, getObjectResponse.ContentLength);
                    }
                    break;
                }
                catch (AmazonServiceException e)
                {
                    if (e.StatusCode != HttpStatusCode.NotFound || retries == 5)
                        throw;
                }
            }

            stream.Seek(5, SeekOrigin.Begin);
            request.InputStream = stream;
            request.AutoResetStreamPosition = false;
            Client.PutObject(request);

            using (var getObjectResponse = Client.GetObject(getObjectRequest))
            {
                Assert.AreEqual(stream.Length - 5, getObjectResponse.ContentLength);
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
    }

    public class NonRewindableStream : MemoryStream
    {
        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }
    }
}