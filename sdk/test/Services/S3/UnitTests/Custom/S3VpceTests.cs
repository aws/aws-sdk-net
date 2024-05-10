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
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3VpceTests
    {
        private const string S3 = "s3";
        private const string S3Outposts = "s3-outposts";        
        private const string USWest2 = "us-west-2";
        private const string USEast1 = "us-east-1";

        [Flags]
        public enum Flags { None = 0, Dualstack = 2, Accelerate = 4, PathStyle = 8, UseArnRegion = 16 }

        [DataTestMethod]
        [DataRow("bucketname", "https://beta.example.com", Flags.None, "https://bucketname.beta.example.com", USEast1, S3)]
        [DataRow("arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint", "https://beta.example.com", Flags.None, "https://myendpoint-123456789012.beta.example.com", USEast1, S3)]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "https://beta.example.com", Flags.UseArnRegion, "https://myendpoint-123456789012.beta.example.com", USWest2, S3)]
        [DataRow("bucketname", "https://s3.us-west-2.amazonaws.com", Flags.None, "https://bucketname.s3.us-west-2.amazonaws.com", USWest2, S3)]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "https://s3.us-west-2.amazonaws.com", Flags.None, "https://myendpoint-123456789012.s3.us-west-2.amazonaws.com", USWest2, S3)]
        [DataRow("arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myendpoint", "https://s3-outposts.us-west-2.amazonaws.com", Flags.None, "https://myendpoint-123456789012.op-01234567890123456.s3-outposts.us-west-2.amazonaws.com", "*", S3Outposts)]
        [DataRow("bucketname", "https://bucket.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", Flags.PathStyle, "https://bucket.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com/bucketname/", USWest2, S3)]
        [DataRow("bucketname", "https://bucket.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", Flags.None, "https://bucketname.bucket.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", USWest2, S3)]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "https://accesspoint.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", Flags.None, "https://myendpoint-123456789012.accesspoint.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", USWest2, S3)]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "https://accesspoint.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", Flags.UseArnRegion, "https://myendpoint-123456789012.accesspoint.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", USWest2, S3)]
        [DataRow("arn:aws:s3:us-west-2:123456789012:accesspoint:myendpoint", "https://accesspoint.vpce-123-abc.s3.eu-west-1.vpce.amazonaws.com", Flags.UseArnRegion, "https://myendpoint-123456789012.accesspoint.vpce-123-abc.s3.eu-west-1.vpce.amazonaws.com", USWest2, S3)] //This will produce a signing error for a real request but are the expected values
        [TestCategory("S3")]
        public void VpceEndpointTests_ListObjects(string bucketName, string serviceUrl, Flags flags,
            string expectedUri, string expectedRegion, string expectedService)
        {                        
            var request = new ListObjectsRequest
            {
                BucketName = bucketName
            };

            RunTestRequest(request, ListObjectsRequestMarshaller.Instance,
                Arn.IsArn(bucketName), serviceUrl, flags, 
                expectedUri, expectedRegion, expectedService);                        
        }

        [DataTestMethod]
        [DataRow("", "https://bucket.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", Flags.None, "https://bucket.vpce-123-abc.s3.us-west-2.vpce.amazonaws.com", USWest2, S3)]
        [TestCategory("S3")]
        public void VpceEndpointTests_ListBuckets(string bucketName, string serviceUrl, Flags flags,
            string expectedUri, string expectedRegion, string expectedService)
        {
            var request = new ListBucketsRequest{};

            RunTestRequest(request, ListBucketsRequestMarshaller.Instance,
                isArn: false, serviceUrl, flags,
                expectedUri, expectedRegion, expectedService);
        }
        
        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonClientException))]
        public void ThrowExceptionCustomEndpointAndOutpostsDualstackNotSupported()
        {
            var request = new ListObjectsRequest
            {
                BucketName = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint"
            };

            var config = CreateConfig("https://beta.example.com", Flags.Dualstack);

            S3ArnTestUtils.RunMockRequest(request, ListObjectsRequestMarshaller.Instance, config);                        
        }

        private AmazonS3Config CreateConfig(string serviceUrl, Flags flags)
        {
            var clientConfig = new AmazonS3Config
            {
                UseAccelerateEndpoint = (flags & Flags.Accelerate) != 0,
                UseDualstackEndpoint = (flags & Flags.Dualstack) != 0,
                UseArnRegion = (flags & Flags.UseArnRegion) != 0,
                ForcePathStyle = (flags & Flags.PathStyle) != 0,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
                ServiceURL = serviceUrl
            };

            return clientConfig;
        }

        private void RunTestRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, 
            bool isArn, string serviceUrl, Flags flags,
            string expectedUri, string expectedRegion, string expectedService)
        {
            var clientConfig = CreateConfig(serviceUrl, flags);
                     
            var internalRequest = S3ArnTestUtils.RunMockRequest(request, marshaller, clientConfig);
                                    
            Assert.AreEqual(new Uri(expectedUri), internalRequest.Endpoint);

            if (isArn)
            {
                Assert.AreEqual(expectedRegion, internalRequest.AuthenticationRegion);
                Assert.AreEqual(expectedService, internalRequest.OverrideSigningServiceName);
            }
            
            var service = DetermineService(clientConfig);
            var signingRegion = AWS4Signer.DetermineSigningRegion(clientConfig, service, internalRequest.AlternateEndpoint, internalRequest);
            Assert.AreEqual(expectedRegion, signingRegion);
            Assert.AreEqual(expectedService, internalRequest.OverrideSigningServiceName ?? service);            
        }

        private static string DetermineService(IClientConfig clientConfig)
        {
            // Use ListBucketsRequest as it is the most basic S3 
            return (!string.IsNullOrEmpty(clientConfig.AuthenticationServiceName))
                ? clientConfig.AuthenticationServiceName
                : AWSSDKUtils.DetermineService(clientConfig.DetermineServiceOperationEndpoint(new ServiceOperationEndpointParameters(new ListBucketsRequest())).URL);
        }                
    }
}