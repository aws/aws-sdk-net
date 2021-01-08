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
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3OutpostsBucketArnTests
    {
        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSWest2UseArnRegionFalse()
        {
            var outpostsBucketArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-west-2.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSEast1UseArnRegionTrue()
        {
            var outpostsBucketArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-east-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSEast1UseArnRegionFalseCrossRegionError()
        {
            var outpostsBucketArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = false
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration, cross region Outpost Bucket ARN", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputCNNorth1UseArnRegionTrueCrossPartitionError()
        {
            var outpostsBucketArn = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration, cross partition Outpost Bucket ARN", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSGovEast1UseArnRegionTrue()
        {
            var outpostsBucketArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USGovCloudEast1,
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-gov-east-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSGovEast1UseArnRegionFalseFipsException()
        {
            var outpostsBucketArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                UseArnRegion = false
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration Outpost Buckets do not support Fips- regions", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSGovEast1UseArnRegionTrueFipsException()
        {
            var outpostsBucketArn = "arn:aws-us-gov:s3-outposts:fips-us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration Outpost Buckets do not support Fips- regions", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSGovEast1UseArnRegionTrueSystemFips()
        {
            var outpostsBucketArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-gov-east-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsBucketInputUSWest2UseArnRegionTrueDualstackException()
        {
            var outpostsBucketArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseDualstackEndpoint = true,
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration Outpost Buckets do not support dualstack", exception.Message);
        }

        [DataTestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:bucket")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:bucket:123")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket")]
        public void OutpostsBucketInputUSWest2UseArnRegionTrueInvalidArnException(string outpostsBucketArn)
        {
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = outpostsBucketArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid ARN, outpost resource format is incorrect", exception.Message);
        }
    }
}
