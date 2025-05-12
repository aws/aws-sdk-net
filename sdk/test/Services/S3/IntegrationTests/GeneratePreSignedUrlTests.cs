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
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class GeneratePresignedUrlTests : TestBase<AmazonS3Client>
    {
        private const string TestContent = "This is the content body!";
        private const string TestKey = "key";
        private Dictionary<RegionEndpoint, string> RegionCodePairs = new Dictionary<RegionEndpoint, string>()
        {
            { RegionEndpoint.USEast1, "use1-az5" },
            { RegionEndpoint.USWest2, "usw2-az1" },
            { RegionEndpoint.EUNorth1, "eun1-az1" }
        };
        private class PresignedUrlTestParameters
        {
            public RegionEndpoint Region { get; set; }
            public DateTime Expiration { get; set; }
            public bool UseSigV4 { get; set; }
            public bool ExpectSigV4Url { get; set; }
            public bool IsS3Express { get; set; }
            public string BucketName { get; set; }
            public Dictionary<string,string> Metadata { get; set; }
        }
        private const long MegSize = 1048576;

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastUnder7Days()
        {
            TestPreSignedUrl(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = false
            });
            TestPreSignedUrl(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = true
            });
            TestPreSignedUrlWithSessionToken(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = false
            });
            TestPreSignedUrlWithSessionToken(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = true
            });
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastOver7Days()
        {
            // us-east-1 allows Sigv2 so it should fall back to it since the expiration is > 7 days
            TestPreSignedUrl(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2),
                UseSigV4 = true,
                ExpectSigV4Url = false,
                IsS3Express = false
            });
            TestPreSignedUrlWithSessionToken(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2),
                UseSigV4 = true,
                ExpectSigV4Url = false,
                IsS3Express = false
            });
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void EUNorth1Under7Days()
        {
            TestPreSignedUrl(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.EUNorth1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                UseSigV4 = true,
                ExpectSigV4Url = true,
                IsS3Express = false
            });
            TestPreSignedUrlWithSessionToken(new PresignedUrlTestParameters { Region = RegionEndpoint.EUNorth1, Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2), UseSigV4 = true, ExpectSigV4Url = true, IsS3Express = false });
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void EUNorth1Over7Days()
        {
            // EUNorth1 doesn't allow SigV2 so we expect an error since the expiration > 7 days
            AssertExtensions.ExpectException(()=>{
                TestPreSignedUrl(new PresignedUrlTestParameters { Region = RegionEndpoint.EUNorth1, Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), UseSigV4 = true, ExpectSigV4Url = true, IsS3Express = false });
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");

            AssertExtensions.ExpectException(() => {
                TestPreSignedUrlWithSessionToken(new PresignedUrlTestParameters { Region = RegionEndpoint.EUNorth1, Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), UseSigV4 = true, ExpectSigV4Url = true, IsS3Express = false });
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void USEastSignedParameters() {
            TestSignedUrlParameters(RegionEndpoint.USEast1, DateTime.UtcNow.AddDays(1));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EUNorth1PutWithMetadata()
        {
            Dictionary<string, string> metadata = new Dictionary<string, string>()
            {
                { "MyMetadata", "Metadata-Value" }
            };
            TestPreSignedUrlPut(new PresignedUrlTestParameters
            {
                Region = RegionEndpoint.EUNorth1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2),
                ExpectSigV4Url = true,
                Metadata = new Dictionary<string, string>()
                {
                    { "MyMetadata", "Metadata-Value" }
                },
                IsS3Express = false
            });
        }

        [TestMethod]
        [TestCategory("S3")]
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

        private void TestPreSignedUrlPut(PresignedUrlTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                if (testParams.IsS3Express)
                {
                    testParams.BucketName = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}--{RegionCodePairs[testParams.Region]}--x-s3";
                    
                    client.PutBucket(new PutBucketRequest 
                    {
                        
                        BucketName = testParams.BucketName,
                        PutBucketConfiguration = new PutBucketConfiguration
                        {
                            BucketInfo = new BucketInfo { DataRedundancy = DataRedundancy.SingleAvailabilityZone, Type = BucketType.Directory},
                            Location = new LocationInfo { Name = RegionCodePairs[testParams.Region], Type = LocationType.AvailabilityZone }
                        }
                    });
                }
                else
                {
                    testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                }
                AssertPresignedUrlPut(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    DeleteBucket(client, testParams.BucketName);
            }
        }
        private static void AssertPresignedUrlPut(AmazonS3Client client, PresignedUrlTestParameters testParams)
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

            var response = PutObjectUsingPresignedUrl(putPresignedUrl, testParams.Metadata);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            if (testParams.Metadata != null && testParams.Metadata.Count > 0)
            {
                var getObjectMetadataResponse = client.GetObjectMetadata(testParams.BucketName, objectKey);

                foreach (KeyValuePair<string, string> kvp in testParams.Metadata)
                {
                    Assert.IsTrue(getObjectMetadataResponse.Metadata.Keys.Contains("x-amz-meta-" + kvp.Key.ToLowerInvariant()));
                    Assert.AreEqual(kvp.Value, getObjectMetadataResponse.Metadata[kvp.Key.ToLowerInvariant()]);
                }
            }
        }

        private static HttpWebResponse PutObjectUsingPresignedUrl(string putPresignedUrl, Dictionary<string, string> metadata = null)
        {
            HttpWebRequest httpRequest = WebRequest.Create(putPresignedUrl) as HttpWebRequest;
            httpRequest.Method = "PUT";

            if (metadata != null && metadata.Count > 0)
            {
                WebHeaderCollection myWebHeaderCollection = httpRequest.Headers;

                foreach (KeyValuePair<string, string> keyValuePair in metadata)
                {
                    myWebHeaderCollection.Add($"X-Amz-Meta-{keyValuePair.Key}", keyValuePair.Value);
                }
            }

            using (Stream dataStream = httpRequest.GetRequestStream())
            {
                var buffer = Encoding.UTF8.GetBytes(TestContent);
                dataStream.Write(buffer, 0, buffer.Length);
            }

            HttpWebResponse response = httpRequest.GetResponse() as HttpWebResponse;

            return response;
        }

        private void TestPreSignedUrl(PresignedUrlTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                if (testParams.IsS3Express)
                {
                    testParams.BucketName = CreateBucketAndObject(client, true, RegionCodePairs[testParams.Region]);
                }
                else
                {
                    testParams.BucketName = CreateBucketAndObject(client);
                }
                AssertPreSignedUrl(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    DeleteBucket(client, testParams.BucketName);
            }
        }
        private void TestPreSignedUrlWithSessionToken(PresignedUrlTestParameters testParams)
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient())
            {
                AWSCredentials credentials = sts.GetSessionToken().Credentials;
                var client = new AmazonS3Client(credentials, testParams.Region);
                try
                {
                    if (testParams.IsS3Express)
                    {
                        testParams.BucketName = CreateBucketAndObject(client, true, RegionCodePairs[testParams.Region]);
                    }
                    else
                    {
                        testParams.BucketName = CreateBucketAndObject(client);
                    }
                    AssertPreSignedUrl(client, testParams);
                }
                finally
                {
                    if (testParams.BucketName != null)
                        DeleteBucket(client, testParams.BucketName);
                }
            }
        }

        private void TestSignedUrlParameters(RegionEndpoint region, DateTime expires) {
            var client = new AmazonS3Client(region);
            string bucketName = null;
            try {
                bucketName = CreateBucketAndObject(client);
                AssertSignedUrlParameters(client, bucketName, expires, true);
            }
            finally {
                if (bucketName != null)
                    DeleteBucket(client, bucketName);
            }
        }

        private string CreateBucketAndObject(AmazonS3Client client, bool isS3Express = false, string regionCode = null)
        {
            string bucketName;
            if (isS3Express && regionCode != null)
            {
                bucketName = S3TestUtils.CreateS3ExpressBucketWithWait(client, regionCode);
            }
            else
            {
                bucketName = S3TestUtils.CreateBucketWithWait(client);
            }
            client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = TestKey,
                ContentBody = TestContent
            });
            S3TestUtils.WaitForObject(client, bucketName, TestKey, 30);
            return bucketName;
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
            var wc = new WebClient();
            Assert.AreEqual(wc.DownloadString(url), TestContent);
        }

        private void AssertSignedUrlParameters(AmazonS3Client client, string bucketName, DateTime expires, bool expectSigV4Url) {
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
        [TestCategory("S3")]
        public void MultipartUploadPresignedUrl()
        {
            var key = "multipart";
            var client = new AmazonS3Client(RegionEndpoint.USEast1);
            var bucketName = CreateBucketAndObject(client);
            var totalMegs = 15;
            var initiateMultipartResponse = client.InitiateMultipartUpload(new InitiateMultipartUploadRequest()
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
                    using (var dataStream = request.GetRequestStream())
                    {
                        var random = new Random();
                        var buffer = new byte[MegSize * 5];
                        random.NextBytes(buffer);
                        dataStream.Write(buffer, 0, (int)(MegSize * 5));
                    }
                    WebResponse response = request.GetResponse();
                    partETags.Add(new PartETag(part, response.Headers["ETag"]));
                }

                client.CompleteMultipartUpload(new CompleteMultipartUploadRequest()
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
                client.AbortMultipartUpload(new AbortMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initiateMultipartResponse.UploadId
                });
            }
            finally
            {
                DeleteBucket(client, bucketName);

                if (!string.IsNullOrEmpty(abortedMessage))
                {
                    Assert.Inconclusive(abortedMessage);
                }
            }
        }

        private void DeleteBucket(AmazonS3Client client, string bucketName)
        {
            AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
        }
    }
}