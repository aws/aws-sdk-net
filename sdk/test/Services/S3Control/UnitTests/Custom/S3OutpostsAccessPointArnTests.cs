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
    public class S3OutpostsAccessPointArnTests
    {
        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSWest2UseArnRegionFalse()
        {
            var outpostsAccessPointArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance ,s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-west-2.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSEast1UseArnRegionTrue()
        {
            var outpostsAccessPointArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-east-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSEast1UseArnRegionFalseCrossRegionError()
        {
            var outpostsAccessPointArn = "arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = false
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration, cross region Outpost Access Point ARN", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputCNNorth1UseArnRegionTrueCrossPartitionError()
        {
            var outpostsAccessPointArn = "arn:aws-cn:s3-outposts:cn-north-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration, cross partition Outpost Access Point ARN", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSGovEast1UseArnRegionTrue()
        {
            var outpostsAccessPointArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USGovCloudEast1,
                UseArnRegion = true
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-gov-east-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSGovEast1UseArnRegionFalseFipsException()
        {
            var outpostsAccessPointArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                UseArnRegion = false
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration Outpost Access Points do not support Fips- regions", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSGovEast1UseArnRegionTrueFipsException()
        {
            var outpostsAccessPointArn = "arn:aws-us-gov:s3-outposts:fips-us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                UseArnRegion = true
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration Outpost Access Points do not support Fips- regions", exception.Message);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSGovEast1UseArnRegionTrueSystemFips()
        {
            var outpostsAccessPointArn = "arn:aws-us-gov:s3-outposts:us-gov-east-1:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName("fips-us-gov-east-1"),
                UseArnRegion = true
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var marshalledRequest = S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            Assert.AreEqual(new Uri("https://s3-outposts.us-gov-east-1.amazonaws.com"), marshalledRequest.Endpoint);
            Assert.AreEqual("op-01234567890123456", marshalledRequest.Headers[HeaderKeys.XAmzOutpostId]);
            Assert.AreEqual("123456789012", marshalledRequest.Headers[HeaderKeys.XAmzAccountId]);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        public void OutpostsAccessPointInputUSWest2UseArnRegionTrueDualstackException()
        {
            var outpostsAccessPointArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseDualstackEndpoint = true,
                UseArnRegion = true
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid configuration Outpost Access Points do not support dualstack", exception.Message);
        }

        [DataTestMethod]
        [TestCategory("S3Control")]
        [TestCategory("UnitTest")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:myaccesspoint")]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:myaccesspoint:123")]
        public void OutpostsAccessPointInputUSWest2UseArnRegionTrueInvalidArnException(string outpostsAccessPointArn)
        {
            var s3ControlConfig = new AmazonS3ControlConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
                UseArnRegion = true
            };
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsAccessPointArn
            };
            var exception = Assert.ThrowsException<AmazonClientException>(() =>
            {
                S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, s3ControlConfig);
            });
            Assert.AreEqual("Invalid ARN, outpost resource format is incorrect", exception.Message);
        }
    }
}
