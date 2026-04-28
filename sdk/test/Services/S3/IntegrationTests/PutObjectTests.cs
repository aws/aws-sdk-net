using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class PutObjectTest
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private const string testContent = "This is the content body!";
        private const string testFileName = "PutObjectFile.txt";

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        public PutObjectTest(SharedS3ObjectBucketFixture sharedBucket)
        {
            _client = sharedBucket.Client;
            _bucketName = sharedBucket.BucketName;
            _testId = Guid.NewGuid().ToString("N");

            // Ensure the test file exists (idempotent — safe to call from every constructor)
            if (!File.Exists(testFileName))
            {
                File.WriteAllText(testFileName, "This is some sample text.!!");
            }
        }

#if NETFRAMEWORK
        // On .NET 8+, HttpClient validates and transforms the Expires header before sending,
        // so an invalid (non-date) value causes a signature mismatch rather than being stored
        // verbatim by S3. This behavior is specific to .NET Framework's HttpWebRequest.
        [Fact]
        public async Task TestPutAndGetWithInvalidExpires()
        {
            var content = "TestInvalidExpiresHeader";
            var key = UtilityMethods.GenerateName("TestPutAndGetWithInvalidExpires");
            var putObjectRequest = new PutObjectRequest
            {
               BucketName = _bucketName,
               Key = key,
               ContentBody = content
            };

            var invalidValue = "InvalidHeaderValue";
            putObjectRequest.Headers["Expires"] = invalidValue;
            await _client.PutObjectAsync(putObjectRequest);

            var getObjectResponse = await _client.GetObjectAsync(_bucketName, key);
            using (getObjectResponse)
            {
                var reader = new StreamReader(getObjectResponse.ResponseStream);
                var contentRead = await reader.ReadToEndAsync();
                Assert.True(content.Equals(contentRead));
                Assert.Equal(getObjectResponse.ExpiresString, invalidValue);
            }

            var getObjectMetadataResponse = await _client.GetObjectMetadataAsync(_bucketName, key);
            Assert.Equal(getObjectMetadataResponse.ExpiresString, invalidValue);
        }
#endif

        [Fact]
        public async Task TestPutAndGetWithBidiCharacters()
        {
            var bidiChar = '\u200E';
            var encodedBidiChar = "%E2%80%8E";
            var content = "TestPutAndGetWithBidiCharacters";            
            var bidiKey = UtilityMethods.GenerateName($"TestPutAndGetWithBidi{bidiChar}Characters");

            // Verify character is in the string
            Assert.True(bidiKey.IndexOf(bidiChar) > 0);
            Assert.True(AWSSDKUtils.HasBidiControlCharacters(bidiKey));

            // Verify character is encoded by the Uri class
            Uri uri = new Uri(new Uri("http://www.amazon.com/"), bidiKey);
            Assert.True(uri.AbsoluteUri.Contains(encodedBidiChar));
            Assert.False(AWSSDKUtils.HasBidiControlCharacters(uri.AbsoluteUri));
            Assert.True(uri.AbsoluteUri.Contains($"TestPutAndGetWithBidi{encodedBidiChar}Characters"));

            // Verify the bidi key can be used to put an object
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = bidiKey,
                ContentBody = content
            });

            // Verify the bidi key object can be read
            var response = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = bidiKey,
            });

            // Read S3 bucket response content
            var responseBody = string.Empty;
            using (var reader = new StreamReader(response.ResponseStream))
            {
                responseBody = await reader.ReadToEndAsync();                
            }

            // Verify the correct response was read
            Assert.True(content == responseBody);
        }

        [Fact]
        public async Task TestStorageClass()
        {
            var key = _testId + "-contentBodyPut";
            var storageClass = S3StorageClass.ReducedRedundancy;
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead,
                StorageClass = storageClass
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            
            var response = await _client.PutObjectAsync(request);
            Assert.True(response.ETag.Length > 0);

            var metadata = await _client.GetObjectMetadataAsync(_bucketName, key);
            Assert.NotNull(metadata);
            Assert.NotNull(metadata.StorageClass);
            Assert.Equal(metadata.StorageClass, storageClass);
            await VerifyPut(testContent, request);
        }

        [Fact]
        public async Task PutObjectCancellationTest()
        {
            var fileName = UtilityMethods.GenerateName(@"CancellationTest-LargeFile");
            var basePath = Path.Combine(Path.GetTempPath(), "PutObjectCancellation-" + Guid.NewGuid().ToString());
            var path = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(path, 50 * MEG_SIZE);

            var cts = new CancellationTokenSource();
            cts.CancelAfter(100);
            var token = cts.Token;
            try
            {
                await _client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = _testId + "-CancellationTest",
                    CannedACL = S3CannedACL.AuthenticatedRead,
                    FilePath = path
                }, token);

                Assert.Fail("An OperationCanceledException was not thrown");
            }
            catch (OperationCanceledException exception)
            {
                Assert.Equal(token, exception.CancellationToken);
                Assert.True(exception.CancellationToken.IsCancellationRequested);
            }
            finally
            {
                Directory.Delete(basePath, true);
            }
        }
      
        [Fact]
        public async Task PutObjectWithExternalEndpoint()
        {            
            var s3Client = new AmazonS3Client(new AmazonS3Config
            {
                ServiceURL = "https://s3-external-1.amazonaws.com"
            });

            var testBucketName = UtilityMethods.GenerateName("aws-net-sdk-external");
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

        [Fact]
        public async Task PutObjectWithLeadingSlash()
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = "/" + _testId + "-contentBodyPut",
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");

            var response = await _client.PutObjectAsync(request);
            Assert.True(response.ETag.Length > 0);
        }

        [Fact]
        public async Task PutObjectKeyWithUrlEncodedCharacters()
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = _testId + "-X$abc,xyz",
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            
            var response = await _client.PutObjectAsync(request);
            Assert.True(response.ETag.Length > 0);
            await VerifyPut(testContent, request);
        }

        [Fact]
        public async Task PutObject()
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = _testId + "-contentBodyPut",
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            
            var response = await _client.PutObjectAsync(request);
            Assert.True(response.ETag.Length > 0);
            await VerifyPut(testContent, request);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public async Task PutObjectWithEmptyInputStream(bool disablePayloadSigning, bool disableDefaultChecksumValidation)
        {
            var response = await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = _testId + "-inputStreamPut",
                InputStream = new MemoryStream(),
                DisableDefaultChecksumValidation = disableDefaultChecksumValidation,
                DisablePayloadSigning = disablePayloadSigning,
            });

            Assert.True(response.ETag.Length > 0);
        }

        [Fact]
        public async Task PutObject_WithExpires()
        {
            var key = _testId + "-contentBodyPut";
            var expires = DateTime.UtcNow.AddYears(5);
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead,
            };
            request.Metadata.Add("Subject", "Content-As-Object");
            request.Headers.Expires = expires;
            
            var response = await _client.PutObjectAsync(request);
            Assert.True(response.ETag.Length > 0);

            var getResponse = await _client.GetObjectAsync(new GetObjectRequest { BucketName = _bucketName, Key = key });
            Assert.True(expires.ApproximatelyEqual(DateTime.Parse(getResponse.ExpiresString, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToUniversalTime()));
        }

#if NETFRAMEWORK
        // On .NET 8+, HttpClientHandler has AllowAutoRedirect=true by default, so the underlying
        // HTTP client silently follows the 301 PermanentRedirect before the SDK pipeline sees it.
        // The request succeeds instead of throwing, making this assertion impossible on .NET 8+.
        [Fact]
        public async Task PutObjectWrongRegion()
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = _testId + "-contentBodyPut",
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            };

            using (var client = new AmazonS3Client(RegionEndpoint.USWest2))
            {
                // Returns an exception with HTTP 301 MovedPermanently
                var exception = await Assert.ThrowsAsync<AmazonS3Exception>(() => client.PutObjectAsync(request));
                Assert.Equal("PermanentRedirect", exception.ErrorCode);
                Assert.Equal(HttpStatusCode.MovedPermanently, exception.StatusCode);
                Assert.False(string.IsNullOrEmpty(exception.Message));
                Assert.False(string.IsNullOrEmpty(exception.RequestId));
                Assert.False(string.IsNullOrEmpty(exception.AmazonId2));
            }
        }
#endif

        [Fact]
        public async Task GetObjectWithNonMatchingEtag()
        {
            var key = _testId + "-TestMatchingEtag";

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "This is the content body!",
                CannedACL = S3CannedACL.AuthenticatedRead
            });

            var etag = (await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            })).ETag;

            // Returns an exception with HTTP 304 NotModified
            var exception = await Assert.ThrowsAsync<AmazonS3Exception>(() =>
                _client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    EtagToNotMatch = etag
                })
            );
            Assert.Equal("NotModified", exception.ErrorCode);
            Assert.Equal(HttpStatusCode.NotModified, exception.StatusCode);
            Assert.False(string.IsNullOrEmpty(exception.Message));
            Assert.False(string.IsNullOrEmpty(exception.RequestId));
            Assert.False(string.IsNullOrEmpty(exception.AmazonId2));
        }

#if NETFRAMEWORK
        // On .NET 8+, HttpClientHandler has AllowAutoRedirect=true by default, so the underlying
        // HTTP client silently follows the 307 TemporaryRedirect before the SDK pipeline sees it.
        // The non-rewindable stream PUT succeeds instead of throwing, making this assertion impossible on .NET 8+.
        [Fact]
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
                    var exception = await Assert.ThrowsAsync<AmazonS3Exception>(() =>
                        client.PutObjectAsync(new PutObjectRequest
                        {
                            BucketName = testBucketName,
                            Key = "TestKey3",
                            InputStream = UtilityMethods.CreateStreamFromString("sample text", new NonRewindableStream())
                        })
                    );
                    Assert.Equal("TemporaryRedirect", exception.ErrorCode);
                    Assert.Equal(HttpStatusCode.TemporaryRedirect, exception.StatusCode);
                    Assert.False(string.IsNullOrEmpty(exception.Message));
                    Assert.False(string.IsNullOrEmpty(exception.RequestId));
                    Assert.False(string.IsNullOrEmpty(exception.AmazonId2));

                    var listResponse = await client.ListObjectsAsync(new ListObjectsRequest
                    {
                        BucketName = testBucketName
                    });
                    Assert.Equal(2, listResponse.S3Objects.Count);
                }
                finally
                {
                    await AmazonS3Util.DeleteS3BucketWithObjectsAsync(client, testBucketName);
                }
            }
        }
#endif

        [Fact]
        public async Task DeleteNonExistentBucket()
        {
            // Returns an exception with HTTP 404 NotFound
            var exception = await Assert.ThrowsAsync<AmazonS3Exception>(() =>
                _client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = "nonexistentbucket1234567890" })
            );
            Assert.Equal("NoSuchBucket", exception.ErrorCode);
            Assert.Equal(HttpStatusCode.NotFound, exception.StatusCode);
            Assert.False(string.IsNullOrEmpty(exception.Message));
            Assert.False(string.IsNullOrEmpty(exception.RequestId));
            Assert.False(string.IsNullOrEmpty(exception.AmazonId2));
        }

        [Fact]
        public async Task PutObjectWithContentEncodingTests()
        {
            await PutObjectWithContentEncoding();
            await PutObjectWithContentEncodingIdentity();
            await PutObjectWithoutContentEncoding();
        }

        [Fact]
        public async Task TestPutObjectWithContentLanguage()
        {
            var key = _testId + "-contentLanguageTest";
            var contentLanguage = "en-US";
            
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = testContent
            };
            request.Headers.ContentLanguage = contentLanguage;
            
            var putResponse = await _client.PutObjectAsync(request);
            Assert.True(putResponse.ETag.Length > 0);
            
            // Verify via GetObject
            using (var getResponse = await _client.GetObjectAsync(_bucketName, key))
            {
                Assert.Equal(contentLanguage, getResponse.Headers.ContentLanguage);
                Assert.Equal(contentLanguage, getResponse.ContentLanguage);
            }
            
            // Verify via GetObjectMetadata
            var metadata = await _client.GetObjectMetadataAsync(_bucketName, key);
            Assert.Equal(contentLanguage, metadata.Headers.ContentLanguage);
            Assert.Equal(contentLanguage, metadata.ContentLanguage);
        }

        private async Task PutObjectWithContentEncoding()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "gzip";
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.Equal("disposition", headers.ContentDisposition);
            Assert.Equal("gzip", headers.ContentEncoding);
        }

        private async Task PutObjectWithContentEncodingIdentity()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentEncoding = "identity";
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.Equal("disposition", headers.ContentDisposition);
            Assert.Equal("identity", headers.ContentEncoding);
        }

        private async Task PutObjectWithoutContentEncoding()
        {
            var request = CreatePutObjectRequest();
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.Equal("disposition", headers.ContentDisposition);
            Assert.Null(headers.ContentEncoding);
        }

        private async Task<HeadersCollection> TestPutAndGet(PutObjectRequest request)
        {
            await _client.PutObjectAsync(request);

            var key = request.Key;
            using (var response = await _client.GetObjectAsync(_bucketName, key))
            using (var reader = new StreamReader(response.ResponseStream))
            {
                var contents = await reader.ReadToEndAsync();
                Assert.Equal(testContent, contents);
            }

            using (var response = await _client.GetObjectAsync(_bucketName, key))
            {
                await response.WriteResponseStreamToFileAsync(key, append: false, cancellationToken: default);
                
                var contents = File.ReadAllText(key);
                Assert.Equal(testContent, contents);
            }

            var meta = await _client.GetObjectMetadataAsync(_bucketName, key);
            return meta.Headers;
        }

        private PutObjectRequest CreatePutObjectRequest() => new PutObjectRequest
        {
            BucketName = _bucketName,
            Key = _testId + "-test-key.json.gz",
            ContentBody = testContent
        };

        [Fact]
        public async Task PutEmptyFile()
        {
            string key = _testId + "-contentBodyPut";
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = string.Empty
            });

            var getResponse = await _client.GetObjectAsync(_bucketName, key);
            Assert.Equal(0, getResponse.ContentLength);
        }

        [Fact]
        public async Task PutObjectLeaveStreamOpen()
        {
            var filepath = Path.GetTempFileName();
            var key = _testId + "-PutObjectLeaveStreamOpen";
            File.WriteAllText(filepath, "abcdefghighfsldfsdfn");

            try
            {
                var stream = File.OpenRead(filepath);
                var request = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    InputStream = stream
                };

                await _client.PutObjectAsync(request);
                Assert.False(stream.CanSeek, "Stream should be closed and seek should not be allowed");

                stream = File.OpenRead(filepath);
                request = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    AutoCloseStream = false,
                    InputStream = stream
                };
                
                await _client.PutObjectAsync(request);
                Assert.True(stream.CanSeek, "Stream should still be open and seek should be allowed");
                stream.Close();
            }
            finally
            {
                File.Delete(filepath);
            }
        }

        [Fact]
        public async Task PutObject_ContentAndFile()
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = "PutObjectTest",
                ContentBody = "CAT",
                FilePath = testFileName
            };

            var actual = await Assert.ThrowsAsync<ArgumentException>(() => _client.PutObjectAsync(request));
            Assert.Equal("Please specify one of either a FilePath or the ContentBody to be PUT as an S3 object.", actual.Message);
        }

        [Fact]
        public async Task PutObject_ContentAndStream()
        {
            using (var fStream = new FileStream(testFileName, FileMode.Open))
            {
                var request = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = "PutObjectTest",
                    ContentBody = "CAT",
                    InputStream = fStream
                };

                var actual = await Assert.ThrowsAsync<ArgumentException>(() => _client.PutObjectAsync(request));
                Assert.Equal("Please specify one of either an InputStream or the ContentBody to be PUT as an S3 object.", actual.Message);
            }
        }

        [Fact]
        public async Task PutObject_StreamAndFile()
        {
            using (var fStream = new FileStream(testFileName, FileMode.Open))
            {
                var request = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = "PutObjectTest",
                    InputStream = fStream,
                    FilePath = testFileName
                };

                var actual = await Assert.ThrowsAsync<ArgumentException>(() => _client.PutObjectAsync(request));
                Assert.Equal("Please specify one of either an InputStream or a FilePath to be PUT as an S3 object.", actual.Message);
            }
        }

        [Fact]
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
            // Use a _testId-prefixed key to avoid collisions when test classes run in parallel.
            // The FilePath drives the upload content; we override the Key explicitly.
            string key = _testId + "-" + Path.GetFileName(path);
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = key
            });

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest 
            { 
                BucketName = _bucketName, 
                Key = key
            });
            Assert.NotNull(metadata);
            Assert.True(metadata.ContentLength > 0);

            await _client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            });
        }

        [Fact]
        public async Task PutObject_FileNameNotExist()
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                FilePath = "FileThatDoesntExist"
            };

            await Assert.ThrowsAsync<FileNotFoundException>(() => _client.PutObjectAsync(request));
        }

        [Fact]
        public async Task PutBucketPutObjectACLTest()
        {
            var aclBucketName = await S3TestUtils.CreateBucketWithWaitAsync(_client, true);
            try
            {
                var getBucketAclResponse = await _client.GetBucketAclAsync(new GetBucketAclRequest
                {
                    BucketName = aclBucketName,
                });
                
                await _client.PutBucketAclAsync(new PutBucketAclRequest
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

                var getBucketAclResponse2 = await _client.GetBucketAclAsync(new GetBucketAclRequest
                {
                    BucketName = aclBucketName,
                });
                getBucketAclResponse2.Grants.ForEach(grant =>
                {
                    Assert.Equal("http://acs.amazonaws.com/groups/s3/LogDelivery", grant.Grantee.URI);
                    Assert.Equal(S3Permission.READ, grant.Permission);
                });

                await _client.PutObjectAsync(new PutObjectRequest
                {
                    Key = "putobjectwithacl",
                    ContentBody = "randomstuff",
                    BucketName = aclBucketName,
                });

                await _client.PutObjectAclAsync(new PutObjectAclRequest
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

                var getObjectAclResponse = await _client.GetObjectAclAsync(new GetObjectAclRequest
                {
                    Key = "putobjectwithacl",
                    BucketName = aclBucketName,
                });
                getObjectAclResponse.Grants.ForEach(grant =>
                {
                    Assert.Equal("http://acs.amazonaws.com/groups/global/AuthenticatedUsers", grant.Grantee.URI);
                    Assert.Equal(S3Permission.READ, grant.Permission);
                });
            }
            finally 
            {                 
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_client, aclBucketName);
            }
        }

        [Fact]
        public async Task PutObjectWithACL()
        {
            var objectKey = _testId + "-putobjectwithacl";
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = objectKey,
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

            var acl = (await _client.GetACLAsync(new GetACLRequest { BucketName = _bucketName, Key = objectKey })).AccessControlList;
            Assert.Equal(2, acl.Grants.Count);

            await _client.PutACLAsync(new PutACLRequest
            {
                BucketName = _bucketName,
                Key = objectKey,
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
                var res = await _client.GetACLAsync(new GetACLRequest() { BucketName = _bucketName, Key = objectKey });
                return res.AccessControlList?.Grants?.Count > 0 ? res.AccessControlList : null;
            });            
            Assert.Equal(1, acl.Grants.Count);
        }

        [Fact]
        public async Task PutBucketWithCannedACL()
        {
            var aclBucketName = UtilityMethods.GenerateName("dotnet-integtests-cannedacl");
            await _client.PutBucketAsync(new PutBucketRequest 
            { 
                BucketName = aclBucketName, 
                CannedACL = S3CannedACL.LogDeliveryWrite, 
                ObjectOwnership = ObjectOwnership.ObjectWriter 
            });

            var acl = (await _client.GetACLAsync(new GetACLRequest { BucketName = aclBucketName })).AccessControlList;
            await _client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = aclBucketName });

            // should only have seen grants for full_control to test owner, LogDelivery read_acp and LogDelivery write
            Assert.Equal(3, acl.Grants.Count);
            foreach (var grant in acl.Grants)
            {
                if (!string.IsNullOrEmpty(grant.Grantee.DisplayName))
                {
                    Assert.NotNull(grant.Grantee.DisplayName);
                    Assert.Equal(S3Permission.FULL_CONTROL, grant.Permission);
                }
                else if (!string.IsNullOrEmpty(grant.Grantee.CanonicalUser))
                {
                    Assert.NotNull(grant.Grantee.CanonicalUser);
                    Assert.Equal(S3Permission.FULL_CONTROL, grant.Permission);
                }
                else
                {
                    Assert.Equal("http://acs.amazonaws.com/groups/s3/LogDelivery", grant.Grantee.URI);
                    Assert.True(grant.Permission == S3Permission.READ_ACP || grant.Permission == S3Permission.WRITE);
                }
            }
        }

#if NETFRAMEWORK
        [Fact]
        public async Task PutObjectWithContentLength()
        {
            string sourceKey = _testId + "-source";
            string destKey = _testId + "-dest";
            string contents = "Sample contents";
            int length = contents.Length;

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = sourceKey,
                ContentBody = contents
            });

            // Disable clock skew testing when generating a presigned url
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                string url = _client.GetPreSignedURL(new GetPreSignedUrlRequest
                {
                    BucketName = _bucketName,
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
                Assert.Equal(contents, finalContents);

                length -= 2;
                httpRequest = WebRequest.Create(url) as HttpWebRequest;
                using (HttpWebResponse httpResponse = await httpRequest.GetResponseAsync() as HttpWebResponse)
                using (Stream stream = httpResponse.GetResponseStream())
                {
                    await PutStream(destKey, length, stream);
                }

                finalContents = await GetContents(destKey);
                Assert.Equal(contents.Substring(0, length), finalContents);
            }
        }

        private async Task PutStream(string destKey, int length, Stream stream)
        {
            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = destKey,
                InputStream = stream,
            };
            request.Headers.ContentLength = length;

            using (RetryUtilities.DisableClockSkewCorrection())
            {
                await _client.PutObjectAsync(request);
            }
        }

        private async Task<string> GetContents(string key)
        {
            var response = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            using (StreamReader reader = new StreamReader(response.ResponseStream))
            {
                return await reader.ReadToEndAsync();
            }
        }

        [Fact]
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

        private Exception TryTest(int errorSize, bool failRequest)
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

        private void Test(int errorSize, bool failRequest)
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
                BucketName = _bucketName,
                Key = _testId + "-foo1",
                AutoCloseStream = false
            };
            putRequest.Headers["x-amz-content-sha256"] = payloadhash;
            putRequest.InputStream = es;

            CallWithTimeout(() => _client.PutObject(putRequest), TimeSpan.FromSeconds(10));
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

        private async Task VerifyPut(string data, PutObjectRequest putRequest)
        {
            var getRequest = new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = putRequest.Key
            };
            
            using (var response = await _client.GetObjectAsync(getRequest))
            using (var responseStream = response.ResponseStream)
            using (StreamReader reader = new StreamReader(responseStream))
            {
                var responseData = await reader.ReadToEndAsync();
                Assert.Equal(data, responseData);
                
                if (putRequest.StorageClass != null && putRequest.StorageClass != S3StorageClass.Standard)
                {
                    Assert.NotNull(response.StorageClass);
                    Assert.Equal(putRequest.StorageClass, response.StorageClass);
                }
            }
        }

        /// <summary>
        /// Reported in https://github.com/aws/aws-sdk-net/issues/3941
        /// </summary>
        [Fact]
        public async Task HandlesFileStreamWithoutAutoReset()
        {
            var tempFilePath = Path.GetTempFileName();
            try
            {
                using (var writeFs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                {
                    var data = new byte[]
                    {
                        0x01, 0x00, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x01, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    };

                    await writeFs.WriteAsync(data, 0, data.Length);
                }

                using (var fileStream = File.Open(tempFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var reader = new BinaryReader(fileStream))
                {
                    fileStream.Position = 10;
                    var compression = reader.ReadInt16();

                    fileStream.Seek(8, SeekOrigin.Current);
                    var bIsLast = reader.ReadBoolean();

                    fileStream.Seek(4, SeekOrigin.Current);

                    var putRequest = new PutObjectRequest
                    {
                        BucketName = _bucketName,
                        Key = "upload-test/0D-0",
                        ContentType = "application/octet-stream",
                        InputStream = fileStream,
                        AutoResetStreamPosition = false,
                    };
                    putRequest.Metadata.Add("compression", compression.ToString());
                    putRequest.Metadata.Add("islast", bIsLast ? "T" : "F");

                    var putResponse = await _client.PutObjectAsync(putRequest);
                    Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);

                    var getResponse = await _client.GetObjectMetadataAsync(_bucketName, putRequest.Key);
                    Assert.Equal(HttpStatusCode.OK, getResponse.HttpStatusCode);
                    Assert.NotNull(getResponse.Metadata);
                    Assert.True(getResponse.Metadata.Count > 0);
                }
            }
            finally
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }
            }
        }

        /// <summary>
        /// Reported in https://github.com/aws/aws-sdk-net/issues/3629
        /// </summary>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task TestResetStreamPosition(bool useChunkEncoding)
        {
            var memoryStream = new MemoryStream();
            long offset;

            using (var writer = new StreamWriter(memoryStream, Encoding.UTF8, 1024, leaveOpen: true))
            {
                writer.AutoFlush = true;
                await writer.WriteAsync("Hello");
                offset = memoryStream.Position;
                await writer.WriteAsync("World");
                await writer.FlushAsync();
            }

            memoryStream.Seek(offset, SeekOrigin.Begin);

            var putRequest = new PutObjectRequest
            {
                CannedACL = S3CannedACL.NoACL,
                BucketName = _bucketName,
                Key = "test-file.txt",
                AutoResetStreamPosition = false,
                AutoCloseStream = !memoryStream.CanSeek,
                InputStream = memoryStream.CanSeek ? memoryStream : AmazonS3Util.MakeStreamSeekable(memoryStream),
                UseChunkEncoding = useChunkEncoding,
            };

            var putResponse = await _client.PutObjectAsync(putRequest);
            Assert.True(putResponse.HttpStatusCode == HttpStatusCode.OK);

            var getResponse = await _client.GetObjectAsync(_bucketName, "test-file.txt");
            using (var reader = new StreamReader(getResponse.ResponseStream))
            {
                var content = await reader.ReadToEndAsync();
                Assert.Equal("World", content);
            }
        }

#if !NETFRAMEWORK
        /// <summary>
        /// Validates that the SDK correctly sets (or omits) the <c>aws-chunked</c> Content-Encoding
        /// header and the <c>x-amz-decoded-content-length</c> header depending on the combination of
        /// <see cref="PutObjectRequest.UseChunkEncoding"/>, <see cref="PutObjectRequest.DisablePayloadSigning"/>,
        /// and <see cref="PutObjectRequest.DisableDefaultChecksumValidation"/>.
        /// <para>
        /// Ported from the NetStandard integration tests
        /// (<c>sdk/test/NetStandard/IntegrationTests/IntegrationTests/S3/PutObjectTests.cs</c>).
        /// </para>
        /// </summary>
        [Theory]
        [InlineData(true,  true,  true,  false)]
        [InlineData(true,  true,  false, true)]
        [InlineData(true,  false, true,  true)]
        [InlineData(true,  false, false, true)]
        [InlineData(false, true,  true,  false)]
        [InlineData(false, true,  false, true)]
        [InlineData(false, false, true,  false)]
        [InlineData(false, false, false, false)]
        public async Task PutObjectAddsAwsChunkedWhenNeeded(
            bool useChunkedEncoding,
            bool disablePayloadSigning,
            bool disableDefaultChecksumValidation,
            bool isContentEncodingHeaderExpected)
        {
            // S3 stores the resulting object without the aws-chunked value in the Content-Encoding header,
            // so we use a custom HttpClientFactory to inspect the raw outgoing request headers before
            // they reach S3, then verify S3 accepted the request (HTTP 200).
            var customHttpClientFactory = new AwsChunkedInspectingHttpClientFactory
            {
                ShouldHaveContentEncoding = isContentEncodingHeaderExpected,
            };

            using var customClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = _client.Config.RegionEndpoint,
                HttpClientFactory = customHttpClientFactory,
            });

            var putRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = _testId + "-aws-chunked-test",
                ContentBody = testContent,
                UseChunkEncoding = useChunkedEncoding,
                DisablePayloadSigning = disablePayloadSigning,
                DisableDefaultChecksumValidation = disableDefaultChecksumValidation,
            };

            // If the request succeeded, S3 handled the Content-Encoding correctly.
            var putResponse = await customClient.PutObjectAsync(putRequest);
            Assert.Equal(System.Net.HttpStatusCode.OK, putResponse.HttpStatusCode);
        }

        private class AwsChunkedInspectingHttpClientFactory : Amazon.Runtime.HttpClientFactory
        {
            public bool ShouldHaveContentEncoding { get; set; }

            public override System.Net.Http.HttpClient CreateHttpClient(Amazon.Runtime.IClientConfig clientConfig)
            {
                var handler = new AwsChunkedInspectingHandler(new System.Net.Http.HttpClientHandler())
                {
                    ShouldHaveContentEncoding = ShouldHaveContentEncoding,
                };
                return new System.Net.Http.HttpClient(handler);
            }
        }

        private class AwsChunkedInspectingHandler : System.Net.Http.DelegatingHandler
        {
            public bool ShouldHaveContentEncoding { get; set; }

            public AwsChunkedInspectingHandler(System.Net.Http.HttpMessageHandler innerHandler) : base(innerHandler) { }

            protected override Task<System.Net.Http.HttpResponseMessage> SendAsync(
                System.Net.Http.HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                // Content-Length and Transfer-Encoding are mutually exclusive; verify the SDK
                // never sets both simultaneously (which would cause S3 to reject the request).
                Assert.True(request.Content?.Headers.ContentLength.HasValue);
                Assert.False(request.Headers.TransferEncodingChunked.GetValueOrDefault());

                if (ShouldHaveContentEncoding)
                {
                    Assert.True(request.Content?.Headers.ContentEncoding.Contains("aws-chunked"),
                        "Expected 'aws-chunked' in Content-Encoding but it was absent.");
                    Assert.True(request.Headers.Contains("x-amz-decoded-content-length"),
                        "Expected 'x-amz-decoded-content-length' header but it was absent.");
                }
                else
                {
                    Assert.False(request.Content?.Headers.ContentEncoding.Contains("aws-chunked"),
                        "Did not expect 'aws-chunked' in Content-Encoding but it was present.");
                    Assert.False(request.Headers.Contains("x-amz-decoded-content-length"),
                        "Did not expect 'x-amz-decoded-content-length' header but it was present.");
                }

                return base.SendAsync(request, cancellationToken);
            }
        }
#endif

#if NET8_0_OR_GREATER
        /// <summary>
        /// Validates that object keys containing <c>/../</c> path segments are stored and retrieved
        /// verbatim (i.e. S3 does not canonicalize the key), and that presigned URLs for such keys
        /// work correctly when URI canonicalization is disabled on the HTTP client.
        /// <para>
        /// Ported from the NetStandard integration tests
        /// (<c>sdk/test/NetStandard/IntegrationTests/IntegrationTests/S3/S3ServiceClientTests.cs</c>).
        /// </para>
        /// </summary>
        [Fact]
        public async Task TestDisableCanonicalization()
        {
            string key = $"/path/../{_testId}.txt";

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                ContentBody = "Hello World",
                Key = key
            };
            var putObjectResponse = await _client.PutObjectAsync(putObjectRequest);

            var getObjectRequest = new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            };
            using (var getObjectResponse = await _client.GetObjectAsync(getObjectRequest))
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var content = await reader.ReadToEndAsync();
                Assert.Equal(putObjectRequest.ContentBody, content);
            }

            var presignedUrlRequest = new GetPreSignedUrlRequest
            {
                BucketName = _bucketName,
                Key = key,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(1)
            };

            var presignedUrl = _client.GetPreSignedURL(presignedUrlRequest);
            using var httpClient = new HttpClient();
            var uri = new Uri(presignedUrl, new UriCreationOptions { DangerousDisablePathAndQueryCanonicalization = true });
            var presignedData = await httpClient.GetStringAsync(uri);
            Assert.Equal(putObjectRequest.ContentBody, presignedData);

            await _client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            });
        }
#endif

        [Fact]
        public async Task ConfirmRetrySignature()
        {
            var s3Client = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = _client.Config.RegionEndpoint,
                ResignRetries = true
            });

            // This test is response to this PR https://github.com/aws/aws-sdk-net/pull/4050 
            // where retries started failing with signature mismatch due to user agent modifications.
            // In this test we are confirming all retries are attempted and not failing with signature mismatch.
            var stream = new FailOnceStream(new MemoryStream(Encoding.UTF8.GetBytes("ConfirmRetrySignature")));
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = _bucketName,
                Key = _testId + "-thestream",
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
