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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;
using Amazon.S3Control;
using Amazon.S3Control.Internal;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ControlVpceTests
    {
        private const string S3 = "s3";
        private const string S3Outposts = "s3-outposts";
        private const string USWest2 = "us-west-2";
        private const string USEast1 = "us-east-1";

        [Flags]
        public enum Flags { None = 0, Dualstack = 2, UseArnRegion = 4 }

        [DataTestMethod]
        [DataRow("apname", "https://beta.example.com", Flags.None, "https://123456789012.beta.example.com", USEast1, S3)]
        [DataRow("apname", "https://s3.us-west-2.amazonaws.com", Flags.None, "https://123456789012.s3.us-west-2.amazonaws.com", USWest2, S3)]        
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "https://s3-outposts.us-west-2.amazonaws.com", Flags.None, "https://s3-outposts.us-west-2.amazonaws.com", USWest2, S3Outposts)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "https://s3-outposts.us-west-2.amazonaws.com", Flags.None, "https://s3-outposts.us-west-2.amazonaws.com", USWest2, S3Outposts)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint", "https://s3-outposts.eu-west-1.amazonaws.com", Flags.UseArnRegion, "https://s3-outposts.eu-west-1.amazonaws.com", USWest2, S3Outposts)] //This will produce a signing error for a real request but are the expected values
        [TestCategory("S3Control")]
        public void VpceEndpointTests_GetAccessPoint(string accessPointName, string serviceUrl, Flags flags,
            string expectedUri, string expectedRegion, string expectedService)
        {
            var request = new GetAccessPointRequest
            {
                AccountId = "123456789012",
                Name = accessPointName                
            };

            RunTestRequest(request, GetAccessPointRequestMarshaller.Instance,
                Arn.IsArn(accessPointName), serviceUrl, flags,
                expectedUri, expectedRegion, expectedService);
        }

        [DataTestMethod]
        [DataRow("bucketname", "https://beta.example.com", Flags.None, "https://beta.example.com", USEast1, S3Outposts)]
        [DataRow("bucketname", "https://s3-outposts.us-west-2.amazonaws.com", Flags.None, "https://s3-outposts.us-west-2.amazonaws.com", USWest2, S3Outposts)]
        [TestCategory("S3Control")]
        public void VpceEndpointTests_CreateBucket(string bucketName, string serviceUrl, Flags flags,
            string expectedUri, string expectedRegion, string expectedService)
        {
            var request = new CreateBucketRequest
            {
                OutpostId = "op-123",
                Bucket = bucketName
            };

            RunTestRequest(request, CreateBucketRequestMarshaller.Instance,
                isArn: false, serviceUrl, flags,
                expectedUri, expectedRegion, expectedService);
        }

        [DataTestMethod]
        [DataRow("arn:aws:s3-outposts:us-east-1:123456789012:outpost:op-01234567890123456:bucket:mybucket", "https://beta.example.com", Flags.None, "https://beta.example.com", USEast1, S3Outposts)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket", "https://s3-outposts.us-west-2.amazonaws.com", Flags.None, "https://s3-outposts.us-west-2.amazonaws.com", USWest2, S3Outposts)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket", "https://s3-outposts.us-west-2.amazonaws.com", Flags.UseArnRegion, "https://s3-outposts.us-west-2.amazonaws.com", USWest2, S3Outposts)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket", "https://s3-outposts.eu-west-1.amazonaws.com", Flags.UseArnRegion, "https://s3-outposts.eu-west-1.amazonaws.com", USWest2, S3Outposts)] //This will produce a signing error for a real request but are the expected values
        [TestCategory("S3Control")]
        public void VpceEndpointTests_GetBucket(string bucketName, string serviceUrl, Flags flags,
            string expectedUri, string expectedRegion, string expectedService)
        {
            var request = new GetBucketRequest
            {                
                Bucket = bucketName
            };

            RunTestRequest(request, GetBucketRequestMarshaller.Instance,
                Arn.IsArn(bucketName), serviceUrl, flags,
                expectedUri, expectedRegion, expectedService);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ThrowExceptionGetAccessPointCustomEndpointAndOutpostsCrossRegionRequest()
        {
            var request = new GetAccessPointRequest
            {
                Name = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint"
            };

            var config = CreateConfig("https://beta.example.com", Flags.None);

            S3ControlArnTestUtils.RunMockRequest(request, GetAccessPointRequestMarshaller.Instance, config);
        }

        [TestMethod]
        [TestCategory("S3Control")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ThrowExceptionGetAccessPointCustomEndpointAndOutpostsDualstackNotSupported()
        {
            var request = new GetAccessPointRequest
            {                
                Name = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint"
            };

            var config = CreateConfig("https://beta.example.com", Flags.Dualstack);

            S3ControlArnTestUtils.RunMockRequest(request, GetAccessPointRequestMarshaller.Instance, config);
        }                

        [TestMethod]
        [TestCategory("S3Control")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ThrowExceptionGetBucketCustomEndpointAndOutpostsDualstackNotSupported()
        {
            var request = new GetBucketRequest
            {                
                Bucket = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:bucket:mybucket"
            };

            var config = CreateConfig("https://beta.example.com", Flags.Dualstack);

            S3ControlArnTestUtils.RunMockRequest(request, GetBucketRequestMarshaller.Instance, config);
        }

        private AmazonS3ControlConfig CreateConfig(string serviceUrl, Flags flags)
        {
            var clientConfig = new AmazonS3ControlConfig
            {                
                UseDualstackEndpoint = (flags & Flags.Dualstack) != 0,
                UseArnRegion = (flags & Flags.UseArnRegion) != 0,                
                ServiceURL = serviceUrl
            };

            return clientConfig;
        }

        private void RunTestRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller,
            bool isArn, string serviceUrl, Flags flags,
            string expectedUri, string expectedRegion, string expectedService)
        {
            var clientConfig = CreateConfig(serviceUrl, flags);

            var internalRequest = S3ControlArnTestUtils.RunMockRequest(request, marshaller, clientConfig);            

            Assert.AreEqual(new Uri(expectedUri), internalRequest.Endpoint);

            if (isArn)
            {
                Assert.AreEqual(expectedRegion, internalRequest.AuthenticationRegion);
                Assert.AreEqual(expectedService, internalRequest.OverrideSigningServiceName);
            }
            
            var service = DetermineService(clientConfig, internalRequest.OriginalRequest);
            var signingRegion = AWS4Signer.DetermineSigningRegion(clientConfig, service, internalRequest.AlternateEndpoint, internalRequest);
            Assert.AreEqual(expectedRegion, signingRegion);
            Assert.AreEqual(expectedService, internalRequest.OverrideSigningServiceName ?? service);            
        }

        private static string DetermineService(IClientConfig clientConfig, AmazonWebServiceRequest request)
        {
            return (!string.IsNullOrEmpty(clientConfig.AuthenticationServiceName))
                ? clientConfig.AuthenticationServiceName
                : AWSSDKUtils.DetermineService(clientConfig.DetermineServiceOperationEndpoint(new ServiceOperationEndpointParameters(request)).URL);
        }
    }
}