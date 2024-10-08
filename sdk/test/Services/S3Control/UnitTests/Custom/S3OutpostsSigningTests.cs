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
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.S3Control;
using Amazon.S3Control.Internal;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3OutpostsSigningTests
    {
        [TestMethod]
        [TestCategory("S3Control")]
        public void TestS3OutpostsSignerGetAccessPoint()
        {
            var signer = new S3Signer();

            var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var getAccessPointRequest = new GetAccessPointRequest
            {
                Name = outpostsArn
            };
            var config = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var originalAuthService = config.AuthenticationServiceName;
            var iRequest = S3ControlArnTestUtils.RunMockRequest(getAccessPointRequest, GetAccessPointRequestMarshaller.Instance, config);
            signer.Sign(iRequest, config, new RequestMetrics(), new BasicAWSCredentials("ACCESS", "SECRET"));
            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-outposts"));
            Assert.IsTrue(config.AuthenticationServiceName == originalAuthService);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        public void TestS3OutpostsSignerGetBucket()
        {
            var signer = new S3Signer();

            var bucketArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket";
            var getBucketRequest = new GetBucketRequest
            {
                Bucket = bucketArn
            };
            var config = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var originalAuthService = config.AuthenticationServiceName;
            var iRequest = S3ControlArnTestUtils.RunMockRequest(getBucketRequest, GetBucketRequestMarshaller.Instance, config);
            signer.Sign(iRequest, config, new RequestMetrics(), new BasicAWSCredentials("ACCESS", "SECRET"));
            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-outposts"));
            Assert.IsTrue(config.AuthenticationServiceName == originalAuthService);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        public void TestS3OutpostsSignerCreateBucket()
        {
            var signer = new S3Signer();

            var createBucketRequest = new CreateBucketRequest
            {
                Bucket = "test",
                OutpostId = "op-123456789012"
            };
            var config = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var originalAuthService = config.AuthenticationServiceName;
            var iRequest = S3ControlArnTestUtils.RunMockRequest(createBucketRequest, CreateBucketRequestMarshaller.Instance, config);            
            signer.Sign(iRequest, config, new RequestMetrics(), new BasicAWSCredentials("ACCESS", "SECRET"));
            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-outposts"));
            Assert.IsTrue(config.AuthenticationServiceName == originalAuthService);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        public void TestS3OutpostsSignerCreateAccessPointWithArn()
        {
            var signer = new S3Signer();
            var createAccessPointRequest = new CreateAccessPointRequest
            {
                Bucket = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket",
                Name = "myaccesspoint",
            };
            var config = new AmazonS3ControlConfig
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var originalAuthService = config.AuthenticationServiceName;
            var iRequest = S3ControlArnTestUtils.RunMockRequest(createAccessPointRequest, CreateAccessPointRequestMarshaller.Instance, config);            
            signer.Sign(iRequest, config, new RequestMetrics(), new BasicAWSCredentials("ACCESS", "SECRET"));

            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-outposts"));
            Assert.IsTrue(config.AuthenticationServiceName == originalAuthService);
        }
    }
}
