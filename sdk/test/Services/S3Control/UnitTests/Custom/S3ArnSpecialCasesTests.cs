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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ArnSpecialCasesTests
    {
        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void CreateBucketTest()
        {
            var bucketName = "testBucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                UseArnRegion = false,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var createBucketRequest = new CreateBucketRequest
            {
                Bucket = bucketName,
                OutpostId = "op-01234567890123456"
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(createBucketRequest, CreateBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-west-2.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers["x-amz-outpost-id"]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ListRegionalBucketsTest()
        {
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var listRegionalBucketsRequest = new ListRegionalBucketsRequest
            {
                OutpostId = "op-01234567890123456",
                AccountId = "123456789012"
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(listRegionalBucketsRequest, ListRegionalBucketsRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-west-2.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers["x-amz-outpost-id"]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers["x-amz-account-id"]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void CreateAccessPointTest()
        {
            var bucketArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
               RegionEndpoint = RegionEndpoint.USWest2
            };
            var createAccessPointRequest = new CreateAccessPointRequest
            {
                Bucket = bucketArn,
                Name = "accessPoint",
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(createAccessPointRequest, CreateAccessPointRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-west-2.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers["x-amz-outpost-id"]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers["x-amz-account-id"]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ListAccessPointsTest()
        {
            var bucketArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var listAccessPointsRequest = new ListAccessPointsRequest
            {
                Bucket = bucketArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(listAccessPointsRequest, ListAccessPointsRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-west-2.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers["x-amz-outpost-id"]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers["x-amz-account-id"]);
        }

        /// <summary>
        /// Using S3 Control with Snowball Edge requires setting both a custom serviceURL and
        /// region to "snow" to invoke the correct endpoint rule. Since we don't allow both, this verifies
        /// that substituting AuthenticationRegion with "snow" results in the correct endpoint.
        /// https://docs.aws.amazon.com/snowball/latest/developer-guide/working-s3-snow-buckets.html
        /// </summary>
        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void SnowballEdgeTest()
        {
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                AuthenticationRegion ="snow",
                ServiceURL = "https://192.168.1.1"
            };

            var listRegionalBucketsRequest = new ListRegionalBucketsRequest()
            {
                AccountId = "012345678910"
            };

            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(listRegionalBucketsRequest, ListRegionalBucketsRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://192.168.1.1"), marshalledRequest.Endpoint);
            Assert.AreEqual("012345678910", marshalledRequest.Headers["x-amz-account-id"]);
            Assert.IsTrue(marshalledRequest.Headers["Authorization"].Contains("snow")); // signing region should be "snow"
        }
    }
}
