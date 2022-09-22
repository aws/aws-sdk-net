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
using Amazon.Runtime;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ArnConflictingAccountIdTests
    {
        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ArnIdSetFieldIdNotSet()
        {
            var outpostArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual("123456789012", marshalledRequest.Headers["x-amz-account-id"]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ArnIdSetFieldIdSetBothTheSame()
        {
            var outpostArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostArn,
                AccountId = "123456789012"
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual("123456789012", marshalledRequest.Headers["x-amz-account-id"]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ArnIdNotSetFieldIdSet()
        {
            var accessPoint = "myAccessPoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = accessPoint,
                AccountId = "123456789012"
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual("123456789012", marshalledRequest.Headers["x-amz-account-id"]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ArnIdNotSetFieldIdNotSetException()
        {
            var outpostAccessPointName = "myAccessPoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostAccessPointName,
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() => {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("AccountId is required but not set", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ArnIdNotSetFieldIdNotSetInvalidArnException()
        {
            var accessPointName = "arn:aws:s3-outposts:us-west-2::outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = accessPointName
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid ARN: missing account ID", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void ArnIdSetFieldIdSetMismatchException()
        {
            var accessPointName = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                AccountId = "923456789012",
                Name = accessPointName
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid ARN: the accountId specified in the ARN (`123456789012`) does not match the parameter (`923456789012`)", exception.Message);
        }
    }
}
