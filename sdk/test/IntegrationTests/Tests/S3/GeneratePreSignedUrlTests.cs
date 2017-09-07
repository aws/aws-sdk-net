/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using Amazon.Util;

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

        [TestMethod]
        [TestCategory("S3")]
        public void USEastUnder7Days()
        {
            TestPreSignedUrl(RegionEndpoint.USEast1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2), true, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void USEastOver7Days()
        {
            // us-east-1 allows Sigv2 so it should fall back to it since the expiration is > 7 days
            TestPreSignedUrl(RegionEndpoint.USEast1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), true, false);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EUCentral1Under7Days()
        {
            TestPreSignedUrl(RegionEndpoint.EUCentral1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2), true, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void EUCentral1Over7Days()
        {
            // EUCentral1 doesn't allow SigV2 so we expect an error since the expiration > 7 days
            AssertExtensions.ExpectException(()=>{
                TestPreSignedUrl(RegionEndpoint.EUCentral1, AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2), true, true);
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

        private void DeleteBucket(AmazonS3Client client, string bucketName)
        {
            AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
        }
    }
}