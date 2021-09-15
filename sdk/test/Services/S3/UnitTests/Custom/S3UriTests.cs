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
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3UriTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void S3EndpointRelativeUriTest()
        {
            bool isS3Uri = AmazonS3Uri.IsAmazonS3Endpoint(new Uri("server/", UriKind.Relative));
            Assert.IsFalse(isS3Uri);
        }        

        [TestMethod]
        [TestCategory("S3")]
        public void S3EndpointAbsoluteNonS3UriTest()
        {
            bool isS3Uri = AmazonS3Uri.IsAmazonS3Endpoint("http://somehost.com/");
            Assert.IsFalse(isS3Uri);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3EndpointAbsoluterRegionalS3UriTest()
        {
            bool isS3Uri = AmazonS3Uri.IsAmazonS3Endpoint("http://mybucket.s3.us-west-2.amazonaws.com/");
            Assert.IsTrue(isS3Uri);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3EndpointAbsoluterLegacyS3UriTest()
        {
            bool isS3Uri = AmazonS3Uri.IsAmazonS3Endpoint("https://s3.amazonaws.com/");
            Assert.IsTrue(isS3Uri);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3UriWithPlusForSpaceDecodeTest()
        {
            var s3Uri = new AmazonS3Uri("https://testbucket.s3.us-east-2.amazonaws.com/C8624825821_S3+Log", true);
            Assert.AreEqual(s3Uri.Key, "C8624825821_S3 Log");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3UriWithPlusForSpaceDecodeTryParseTest()
        {
            AmazonS3Uri s3Uri;
            bool result = AmazonS3Uri.TryParseAmazonS3Uri("https://testbucket.s3.us-east-2.amazonaws.com/C8624825821_S3+Log", true, out s3Uri);

            Assert.IsTrue(result);
            Assert.AreEqual(s3Uri.Key, "C8624825821_S3 Log");
        }
    }
}