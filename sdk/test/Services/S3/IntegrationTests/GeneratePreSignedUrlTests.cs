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

        private const long MegSize = 1048576;

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastUnder7Days()
        {
            TestPreSignedUrl(RegionEndpoint.USEast1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2), true, true);
            TestPreSignedUrlWithSessionToken(RegionEndpoint.USEast1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2), true, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastOver7Days()
        {
            // us-east-1 allows Sigv2 so it should fall back to it since the expiration is > 7 days
            TestPreSignedUrl(RegionEndpoint.USEast1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), true, false);
            TestPreSignedUrlWithSessionToken(RegionEndpoint.USEast1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), true, false);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void EUCentral1Under7Days()
        {
            TestPreSignedUrl(RegionEndpoint.EUCentral1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2), true, true);
            TestPreSignedUrlWithSessionToken(RegionEndpoint.EUCentral1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2), true, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void EUCentral1Over7Days()
        {
            // EUCentral1 doesn't allow SigV2 so we expect an error since the expiration > 7 days
            AssertExtensions.ExpectException(()=>{
                TestPreSignedUrl(RegionEndpoint.EUCentral1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), true, true);
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");

            AssertExtensions.ExpectException(() => {
                TestPreSignedUrlWithSessionToken(RegionEndpoint.EUCentral1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), true, true);
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void USEastSignedParameters() {
            TestSignedUrlParameters(RegionEndpoint.USEast1, DateTime.Now.AddDays(1));
        }

        private void TestPreSignedUrl(RegionEndpoint region, DateTime expires, bool useSigV4, bool expectSigV4Url)
        {
            var client = new AmazonS3Client(region);
            var originalUseSigV4 = AWSConfigsS3.UseSignatureVersion4;
            string bucketName = null;
            try
            {
                AWSConfigsS3.UseSignatureVersion4 = true;
                bucketName = CreateBucketAndObject(client);
                AssertPreSignedUrl(client, bucketName, expires, expectSigV4Url);
            }
            finally
            {
                AWSConfigsS3.UseSignatureVersion4 = originalUseSigV4;
                if (bucketName != null)
                    DeleteBucket(client, bucketName);
            }
        }

        private void TestPreSignedUrlWithSessionToken(RegionEndpoint region, DateTime expires, bool useSigV4, bool expectSigV4Url)
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient())
            {
                AWSCredentials credentials = sts.GetSessionToken().Credentials;
                var client = new AmazonS3Client(credentials, region);
                var originalUseSigV4 = AWSConfigsS3.UseSignatureVersion4;
                AWSConfigsS3.UseSignatureVersion4 = true;
                string bucketName = null;
                try
                {
                    AWSConfigsS3.UseSignatureVersion4 = true;
                    bucketName = CreateBucketAndObject(client);
                    AssertPreSignedUrl(client, bucketName, expires, expectSigV4Url);
                }
                finally
                {
                    AWSConfigsS3.UseSignatureVersion4 = originalUseSigV4;
                    if (bucketName != null)
                        DeleteBucket(client, bucketName);
                }
            }
        }

        private void TestSignedUrlParameters(RegionEndpoint region, DateTime expires) {
            var client = new AmazonS3Client(region);
            var originalUseSigV4 = AWSConfigsS3.UseSignatureVersion4;
            string bucketName = null;
            try {
                AWSConfigsS3.UseSignatureVersion4 = true;
                bucketName = CreateBucketAndObject(client);
                AssertSignedUrlParameters(client, bucketName, expires, true);
            }
            finally {
                AWSConfigsS3.UseSignatureVersion4 = originalUseSigV4;
                if (bucketName != null)
                    DeleteBucket(client, bucketName);
            }
        }

        private string CreateBucketAndObject(AmazonS3Client client)
        {
            var bucketName = S3TestUtils.CreateBucketWithWait(client);
            client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = TestKey,
                ContentBody = TestContent
            });
            S3TestUtils.WaitForObject(client, bucketName, TestKey, 30);
            return bucketName;
        }

        private void AssertPreSignedUrl(AmazonS3Client client, string bucketName, DateTime expires, bool expectSigV4Url)
        {
            // generate url
            var url = client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = TestKey,
                Expires = expires
            });

            // make sure we used the correct signtaure version
            var urlIsSigV4 = url.Contains("aws4_request");
            Assert.AreEqual(expectSigV4Url, urlIsSigV4);

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
                        Expires = DateTime.Now.AddDays(1),
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