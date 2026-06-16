using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class GeneratePresignedUrlTests : IAsyncLifetime
    {
        private const string TestContent = "This is the content body!";
        private const string TestKey = "key";
        private const long MegSize = 1048576;

        private string _usEast1BucketName;
        private string _usEast1S3ExpressBucketName;
        private string _euNorth1BucketName;
        private AmazonS3Client _usEast1Client;
        private AmazonS3Client _euNorth1Client;

        private class PresignedUrlTestParameters
        {
            public DateTime Expiration { get; set; }
            public bool UseSigV4 { get; set; }
            public bool ExpectSigV4Url { get; set; }
            public bool IsS3Express { get; set; }
            public string BucketName { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
        }

        public async ValueTask InitializeAsync()
        {
            _usEast1Client = new AmazonS3Client(RegionEndpoint.USEast1);
            _euNorth1Client = new AmazonS3Client(RegionEndpoint.EUNorth1);

            var usEast1BucketTask = S3TestUtils.CreateBucketWithWaitAsync(_usEast1Client);
            var usEast1S3ExpressBucketTask = S3TestUtils.CreateS3ExpressBucketWithWaitAsync(_usEast1Client, "use1-az5");
            var euNorth1BucketTask = S3TestUtils.CreateBucketWithWaitAsync(_euNorth1Client);

            await Task.WhenAll(usEast1BucketTask, usEast1S3ExpressBucketTask, euNorth1BucketTask);

            _usEast1BucketName = usEast1BucketTask.Result;
            _usEast1S3ExpressBucketName = usEast1S3ExpressBucketTask.Result;
            _euNorth1BucketName = euNorth1BucketTask.Result;

            await Task.WhenAll(
                _usEast1Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = _usEast1BucketName,
                    Key = TestKey,
                    ContentBody = TestContent
                }),
                _usEast1Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = _usEast1S3ExpressBucketName,
                    Key = TestKey,
                    ContentBody = TestContent
                }),
                _euNorth1Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = _euNorth1BucketName,
                    Key = TestKey,
                    ContentBody = TestContent
                })
            );
        }

        public async ValueTask DisposeAsync()
        {
            var cleanupTasks = new List<Task>();

            if (_usEast1Client != null)
            {
                if (_usEast1BucketName != null)
                {
                    cleanupTasks.Add(AmazonS3Util.DeleteS3BucketWithObjectsAsync(_usEast1Client, _usEast1BucketName));
                }

                if (_usEast1S3ExpressBucketName != null)
                {
                    cleanupTasks.Add(AmazonS3Util.DeleteS3BucketWithObjectsAsync(_usEast1Client, _usEast1S3ExpressBucketName));
                }
            }

            if (_euNorth1Client != null && _euNorth1BucketName != null)
            {
                cleanupTasks.Add(AmazonS3Util.DeleteS3BucketWithObjectsAsync(_euNorth1Client, _euNorth1BucketName));
            }

            await Task.WhenAll(cleanupTasks);
            _usEast1Client?.Dispose();
            _euNorth1Client?.Dispose();
        }

        [Fact]
        public async Task USEastUnder7Days()
        {
            await AssertPreSignedUrl(_usEast1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = false,
                BucketName = _usEast1BucketName
            });

            await AssertPreSignedUrl(_usEast1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = true,
                BucketName = _usEast1S3ExpressBucketName
            });
        }

        [Fact]
        public async Task USEastOver7Days()
        {
            // us-east-1 allows Sigv2 so it should fall back to it since the expiration is > 7 days
            await AssertPreSignedUrl(_usEast1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2),
                UseSigV4 = true,
                ExpectSigV4Url = false,
                IsS3Express = false,
                BucketName = _usEast1BucketName
            });
        }

        [Fact]
        public async Task EUNorth1Under7Days()
        {
            await AssertPreSignedUrl(_euNorth1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = false,
                BucketName = _euNorth1BucketName
            });
        }

        [Fact]
        public void EUNorth1Over7Days()
        {
            // EUNorth1 doesn't allow SigV2 so we expect an error since the expiration > 7 days
            // GetPreSignedURL throws synchronously before any HTTP call, so no async needed here.
            var actualException = Assert.Throws<ArgumentException>(() =>
                _euNorth1Client.GetPreSignedURL(new GetPreSignedUrlRequest
                {
                    BucketName = _euNorth1BucketName,
                    Key = TestKey,
                    Expires = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2)
                })
            );

            Assert.Equal("The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds", actualException.Message);
        }

        [Fact]
        public async Task USEastSignedParameters()
        {
            await AssertSignedUrlParameters(_usEast1Client, _usEast1BucketName, DateTime.UtcNow.AddDays(1), true);
        }

        [Fact]
        public async Task EUNorth1PutWithMetadata()
        {
            await AssertPresignedUrlPut(_euNorth1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                ExpectSigV4Url = true,
                Metadata = new Dictionary<string, string>()
                {
                    { "MyMetadata", "Metadata-Value" }
                },
                IsS3Express = false,
                BucketName = _euNorth1BucketName
            });
        }

        [Fact]
        public void TestGetPreSignedURL_WithCustomServiceURL()
        {
            var serviceUrl = "https://s3-external-1.amazonaws.com";
            var config = new AmazonS3Config
            {
                ServiceURL = serviceUrl,
                ForcePathStyle = true,
                AuthenticationRegion = "us-west-2"
            };

            var credentials = new BasicAWSCredentials("accessKey", "secretKey");
            var s3Client = new AmazonS3Client(credentials, config);
            var request = new GetPreSignedUrlRequest
            {
                BucketName = "my-bucket",
                Key = "my-object-key",
                Expires = DateTime.UtcNow.AddMinutes(5)
            };

            var url = s3Client.GetPreSignedURL(request);
            Assert.StartsWith(serviceUrl, url);
        }

        private static async Task AssertPresignedUrlPut(AmazonS3Client client, PresignedUrlTestParameters testParams)
        {
            string objectKey = UtilityMethods.GenerateName(TestKey);

            var request = new GetPreSignedUrlRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Verb = HttpVerb.PUT,
                Expires = testParams.Expiration,
                Protocol = Protocol.HTTPS
            };

            if (testParams.Metadata != null && testParams.Metadata.Count > 0)
            {
                foreach (KeyValuePair<string, string> kvp in testParams.Metadata)
                {
                    request.Metadata.Add(kvp.Key, kvp.Value);
                }
            }

            string putPresignedUrl = client.GetPreSignedURL(request);

            var urlIsSigV4 = putPresignedUrl.Contains("aws4_request");
            Assert.Equal(testParams.ExpectSigV4Url, urlIsSigV4);
            List<string> signedHeadersList = new List<string> { "host" };

            if (testParams.Metadata != null && testParams.Metadata.Count > 0)
            {
                signedHeadersList.AddRange(testParams.Metadata.Select(m => "x-amz-meta-" + m.Key.ToLowerInvariant()));
            }
            
            string signedHeadersString = string.Join(";", signedHeadersList.OrderBy(k => k, StringComparer.Ordinal));
            Assert.False(putPresignedUrl.Contains(signedHeadersString));
            Assert.True(putPresignedUrl.Contains(AWSSDKUtils.UrlEncode(signedHeadersString, false)));

            var response = await PutObjectUsingPresignedUrl(putPresignedUrl, testParams.Metadata);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            if (testParams.Metadata != null && testParams.Metadata.Count > 0)
            {
                var getObjectMetadataResponse = await client.GetObjectMetadataAsync(testParams.BucketName, objectKey);
                foreach (KeyValuePair<string, string> kvp in testParams.Metadata)
                {
                    Assert.True(getObjectMetadataResponse.Metadata.Keys.Contains("x-amz-meta-" + kvp.Key.ToLowerInvariant()));
                    Assert.Equal(kvp.Value, getObjectMetadataResponse.Metadata[kvp.Key.ToLowerInvariant()]);
                }
            }
        }

        private static readonly HttpClient _httpClient = new HttpClient();

        private static async Task<HttpResponseMessage> PutObjectUsingPresignedUrl(string putPresignedUrl, Dictionary<string, string> metadata = null)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Put, putPresignedUrl))
            {
                if (metadata != null && metadata.Count > 0)
                {
                    foreach (KeyValuePair<string, string> kvp in metadata)
                    {
                        request.Headers.TryAddWithoutValidation($"X-Amz-Meta-{kvp.Key}", kvp.Value);
                    }
                }

                request.Content = new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent));
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                return response;
            }
        }

        private async Task AssertPreSignedUrl(AmazonS3Client client, PresignedUrlTestParameters testParams)
        {
            var url = client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = testParams.BucketName,
                Key = TestKey,
                Expires = testParams.Expiration
            });

            var urlIsSigV4 = url.Contains("aws4_request");
            Assert.Equal(testParams.ExpectSigV4Url, urlIsSigV4);

            var content = await _httpClient.GetStringAsync(url);
            Assert.Equal(TestContent, content);
        }

        private async Task AssertSignedUrlParameters(AmazonS3Client client, string bucketName, DateTime expires, bool expectSigV4Url)
        {
            const string paramKey = "x-test-param";
            const string paramValue = "TestParamValue";
            const string badParamKey = "x-test-param2";
            const string badParamValue = "TestParamValue2";

            var preSignedRequest = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = TestKey,
                Expires = expires
            };
            preSignedRequest.Parameters.Add(paramKey, paramValue);

            var url = client.GetPreSignedURL(preSignedRequest);

            var urlIsSigV4 = url.Contains("aws4_request");
            Assert.Equal(expectSigV4Url, urlIsSigV4);

            var content = await _httpClient.GetStringAsync(url);
            Assert.Equal(TestContent, content);

            string badParamURL = url.Replace(paramKey, badParamKey);
            var badParamResponse = await _httpClient.GetAsync(badParamURL);
            Assert.Equal(HttpStatusCode.Forbidden, badParamResponse.StatusCode);

            string badValueURL = url.Replace(paramValue, badParamValue);
            var badValueResponse = await _httpClient.GetAsync(badValueURL);
            Assert.Equal(HttpStatusCode.Forbidden, badValueResponse.StatusCode);
        }

        [Fact]
        public async Task MultipartUploadPresignedUrl()
        {
            var key = "multipart";
            var client = _usEast1Client;
            var bucketName = _usEast1BucketName;
            var totalMegs = 15;
            var initiateMultipartResponse = await client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentType = "text/plain"
            });

            var abortedMessage = "";
            var partETags = new List<PartETag>();
            try
            {
                for (var part = 1; part <= totalMegs / 5; part++)
                {
                    var url = client.GetPreSignedURL(new GetPreSignedUrlRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        Expires = DateTime.UtcNow.AddDays(1),
                        PartNumber = part,
                        UploadId = initiateMultipartResponse.UploadId,
                        Verb = HttpVerb.PUT,
                        ContentType = "text/plain",
                        Protocol = Protocol.HTTPS
                    });

                    var random = new Random();
                    var buffer = new byte[MegSize * 5];
                    random.NextBytes(buffer);

                    using (var httpRequest = new HttpRequestMessage(HttpMethod.Put, url))
                    {
                        httpRequest.Content = new ByteArrayContent(buffer);
                        httpRequest.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/plain");
                        var response = await _httpClient.SendAsync(httpRequest);
                        response.EnsureSuccessStatusCode();
                        var etag = response.Headers.ETag?.Tag;
                        partETags.Add(new PartETag(part, etag));
                    }
                }

                await client.CompleteMultipartUploadAsync(new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initiateMultipartResponse.UploadId,
                    PartETags = partETags
                });
            }
            catch (Exception e)
            {
                abortedMessage = e.StackTrace;
                await client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initiateMultipartResponse.UploadId
                });
            }
            finally
            {
                if (!string.IsNullOrEmpty(abortedMessage))
                {
                    Assert.Fail(abortedMessage);
                }
            }
        }
    }
}
