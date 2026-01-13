/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class GeneratePresignedUrlTests : TestBase<AmazonS3Client>
    {
        private const string TestContent = "This is the content body!";
        private const string TestKey = "key";
        private const long MegSize = 1048576;
        private static string _usEast1BucketName;
        private static string _usEast1S3ExpressBucketName;
        private static string _euNorth1BucketName;
        private static AmazonS3Client _usEast1Client;
        private static AmazonS3Client _euNorth1Client;
        private class PresignedUrlTestParameters
        {
            public DateTime Expiration { get; set; }
            public bool UseSigV4 { get; set; }
            public bool ExpectSigV4Url { get; set; }
            public bool IsS3Express { get; set; }
            public string BucketName { get; set; }
            public Dictionary<string, string> Metadata { get; set; }
        }

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext context)
        {
            _usEast1Client = new AmazonS3Client(RegionEndpoint.USEast1);
            _euNorth1Client = new AmazonS3Client(RegionEndpoint.EUNorth1);

            _usEast1BucketName = await S3TestUtils.CreateBucketWithWaitAsync(_usEast1Client);
            await _usEast1Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _usEast1BucketName,
                Key = TestKey,
                ContentBody = TestContent
            });

            _usEast1S3ExpressBucketName = await S3TestUtils.CreateS3ExpressBucketWithWaitAsync(_usEast1Client, "use1-az5");
            await _usEast1Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _usEast1S3ExpressBucketName,
                Key = TestKey,
                ContentBody = TestContent
            });

            _euNorth1BucketName = await S3TestUtils.CreateBucketWithWaitAsync(_euNorth1Client);
            await _euNorth1Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _euNorth1BucketName,
                Key = TestKey,
                ContentBody = TestContent
            });
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_usEast1Client, _usEast1BucketName);
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_usEast1Client, _usEast1S3ExpressBucketName);
            _usEast1Client.Dispose();

            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_euNorth1Client, _euNorth1BucketName);
            _euNorth1Client.Dispose();

            BaseClean();
        }

        [TestMethod]
        public void USEastUnder7Days()
        {
            AssertPreSignedUrl(_usEast1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = false,
                BucketName = _usEast1BucketName
            });

            AssertPreSignedUrl(_usEast1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = true,
                BucketName = _usEast1S3ExpressBucketName
            });
        }

        [TestMethod]
        public void USEastOver7Days()
        {
            // us-east-1 allows Sigv2 so it should fall back to it since the expiration is > 7 days
            AssertPreSignedUrl(_usEast1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2),
                UseSigV4 = true,
                ExpectSigV4Url = false,
                IsS3Express = false,
                BucketName = _usEast1BucketName
            });
        }

        [TestMethod]
        public void EUNorth1Under7Days()
        {
            AssertPreSignedUrl(_euNorth1Client, new PresignedUrlTestParameters
            {
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = false,
                BucketName = _euNorth1BucketName
            });
        }

        [TestMethod]
        public void EUNorth1Over7Days()
        {
            // EUNorth1 doesn't allow SigV2 so we expect an error since the expiration > 7 days
            var actualException = Assert.ThrowsException<ArgumentException>(() =>
                AssertPreSignedUrl(_euNorth1Client, new PresignedUrlTestParameters
                {
                    Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2),
                    UseSigV4 = true,
                    ExpectSigV4Url = true,
                    IsS3Express = false,
                    BucketName = _euNorth1BucketName
                })
            );

            Assert.AreEqual("The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds", actualException.Message);
        }

        [TestMethod]
        public void USEastSignedParameters()
        {
            AssertSignedUrlParameters(_usEast1Client, _usEast1BucketName, DateTime.UtcNow.AddDays(1), true);
        }

        [TestMethod]
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

        [TestMethod]
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
            Assert.IsTrue(url.StartsWith(serviceUrl));
        }

        private static async Task AssertPresignedUrlPut(AmazonS3Client client, PresignedUrlTestParameters testParams)
        {
            string objectKey = TestKey + DateTime.UtcNow.Ticks;

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

            // make sure we used the correct signtaure version
            var urlIsSigV4 = putPresignedUrl.Contains("aws4_request");
            Assert.AreEqual(testParams.ExpectSigV4Url, urlIsSigV4);
            List<string> signedHeadersList = new List<string> { "host" };

            if (testParams.Metadata != null && testParams.Metadata.Count > 0)
            {
                signedHeadersList.AddRange(testParams.Metadata.Select(m => "x-amz-meta-" + m.Key.ToLowerInvariant()));
            }
            
            string signedHeadersString = string.Join(";", signedHeadersList.OrderBy(k => k, StringComparer.Ordinal));
            Assert.IsFalse(putPresignedUrl.Contains(signedHeadersString));
            Assert.IsTrue(putPresignedUrl.Contains(AWSSDKUtils.UrlEncode(signedHeadersString, false)));

            var response = await PutObjectUsingPresignedUrl(putPresignedUrl, testParams.Metadata);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            if (testParams.Metadata != null && testParams.Metadata.Count > 0)
            {
                var getObjectMetadataResponse = await client.GetObjectMetadataAsync(testParams.BucketName, objectKey);
                foreach (KeyValuePair<string, string> kvp in testParams.Metadata)
                {
                    Assert.IsTrue(getObjectMetadataResponse.Metadata.Keys.Contains("x-amz-meta-" + kvp.Key.ToLowerInvariant()));
                    Assert.AreEqual(kvp.Value, getObjectMetadataResponse.Metadata[kvp.Key.ToLowerInvariant()]);
                }
            }
        }

        private static async Task<HttpWebResponse> PutObjectUsingPresignedUrl(string putPresignedUrl, Dictionary<string, string> metadata = null)
        {
            var httpRequest = WebRequest.Create(putPresignedUrl) as HttpWebRequest;
            httpRequest.Method = "PUT";

            if (metadata != null && metadata.Count > 0)
            {
                WebHeaderCollection myWebHeaderCollection = httpRequest.Headers;

                foreach (KeyValuePair<string, string> keyValuePair in metadata)
                {
                    myWebHeaderCollection.Add($"X-Amz-Meta-{keyValuePair.Key}", keyValuePair.Value);
                }
            }

            using (Stream dataStream = await httpRequest.GetRequestStreamAsync())
            {
                var buffer = Encoding.UTF8.GetBytes(TestContent);
                await dataStream.WriteAsync(buffer, 0, buffer.Length);
            }

            return await httpRequest.GetResponseAsync() as HttpWebResponse;
        }

        private void AssertPreSignedUrl(AmazonS3Client client, PresignedUrlTestParameters testParams)
        {
            // generate url
            var url = client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = testParams.BucketName,
                Key = TestKey,
                Expires = testParams.Expiration
            });

            // make sure we used the correct signtaure version
            var urlIsSigV4 = url.Contains("aws4_request");
            Assert.AreEqual(testParams.ExpectSigV4Url, urlIsSigV4);

            // use independent web client make sure the URL actually works
            // TODO: Replace this with HttpClient when the project targets .NET Standard
            var wc = new WebClient();
            Assert.AreEqual(wc.DownloadString(url), TestContent);
        }

        private void AssertSignedUrlParameters(AmazonS3Client client, string bucketName, DateTime expires, bool expectSigV4Url)
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
            // Add a parameter & value to be signed
            preSignedRequest.Parameters.Add(paramKey, paramValue);

            // generate url
            var url = client.GetPreSignedURL(preSignedRequest);

            // make sure we used the correct signtaure version
            var urlIsSigV4 = url.Contains("aws4_request");
            Assert.AreEqual(expectSigV4Url, urlIsSigV4);

            // use independent web client make sure the URL actually works
            // TODO: Replace this with HttpClient when the project targets .NET Standard
            var wc = new WebClient();
            Assert.AreEqual(wc.DownloadString(url), TestContent);

            // change parameter and we should get a 403 response
            string badParamURL = url.Replace(paramKey, badParamKey);
            
            // Using a modified parameter name should throw an exception
            WebException wex = Assert.ThrowsException<WebException>(() => wc.DownloadString(badParamURL));
            
            // And that exception should be permission denied:
            Assert.IsTrue(wex.Message.Contains("403"));

            // change value and we should get a 403 response
            string badValueURL = url.Replace(paramValue, badParamValue);
            
            // Using a modified parameter value should throw an exception
            wex = Assert.ThrowsException<WebException>(() => wc.DownloadString(badValueURL));
            
            // And that exception should be permission denied:
            Assert.IsTrue(wex.Message.Contains("403"));
        }

        [TestMethod]
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

                    WebRequest request = WebRequest.Create(url);
                    request.ContentLength = MegSize * 5;
                    request.Method = "PUT";
                    request.ContentType = "text/plain";
                    using (var dataStream = await request.GetRequestStreamAsync())
                    {
                        var random = new Random();
                        var buffer = new byte[MegSize * 5];
                        random.NextBytes(buffer);
                        await dataStream.WriteAsync(buffer, 0, (int)(MegSize * 5));
                    }
                    
                    var response = await request.GetResponseAsync();
                    partETags.Add(new PartETag(part, response.Headers["ETag"]));
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
                    Assert.Inconclusive(abortedMessage);
                }
            }
        }
    }
}