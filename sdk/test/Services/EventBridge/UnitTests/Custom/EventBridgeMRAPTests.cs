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
using Amazon.EventBridge;
using Amazon.EventBridge.Model;
using Amazon.EventBridge.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EventBridgeMRAPTests
    {
        private void CheckV4aAuthorization(IRequest internalRequest)
        {
            Assert.AreEqual(SignatureVersion.SigV4a, internalRequest.SignatureVersion);
            Assert.IsTrue(internalRequest.Headers["Authorization"].StartsWith("AWS4-ECDSA-P256-SHA256"));
        }

        private void CheckV4Authorization(IRequest internalRequest)
        {
            Assert.AreNotEqual(SignatureVersion.SigV4a, internalRequest.SignatureVersion);
            Assert.IsTrue(internalRequest.Headers["Authorization"].StartsWith("AWS4-HMAC-SHA256"));
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseDefaultEndpointWhenEndpointIdIsNotSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = null
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance);
            Assert.AreEqual("https://events.us-east-1.amazonaws.com/", internalRequest.Endpoint.ToString());
            CheckV4Authorization(internalRequest);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseMrapEndpointWhenEndpointIdIsSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = "abc123.456def"
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance);
            Assert.AreEqual("https://abc123.456def.endpoint.events.amazonaws.com/", internalRequest.Endpoint.ToString());
            CheckV4aAuthorization(internalRequest);
            Assert.AreEqual("*", internalRequest.AuthenticationRegion);
            Assert.AreEqual("*", internalRequest.Headers["x-amz-region-set"]);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        [ExpectedException(typeof(AmazonClientException))]
        public void UseBadEndpointId()
        {
            var request = new PutEventsRequest
            {
                EndpointId = "badactor.com?foo=bar"
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        [ExpectedException(typeof(AmazonClientException))]
        public void UseEmptyEndpointId()
        {
            var request = new PutEventsRequest
            {
                EndpointId = ""
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseDualStackEndpointWithEndpointIdNotSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = null
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseDualstackEndpoint = true
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://events.us-east-1.api.aws/", internalRequest.Endpoint.ToString());
            CheckV4Authorization(internalRequest);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseDualStackEndpointWithEndpointIdSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = "abc123.456def"
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseDualstackEndpoint = true
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://abc123.456def.endpoint.events.api.aws/", internalRequest.Endpoint.ToString());
            CheckV4aAuthorization(internalRequest);
            Assert.AreEqual("*", internalRequest.AuthenticationRegion);
            Assert.AreEqual("*", internalRequest.Headers["x-amz-region-set"]);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseFIPSEndpointWithEndpointIdNotSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = null
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseFIPSEndpoint = true
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://events-fips.us-east-1.amazonaws.com/", internalRequest.Endpoint.ToString());
            CheckV4Authorization(internalRequest);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        [ExpectedException(typeof(AmazonClientException))]
        public void UseFIPSEndpointWithEndpointIdSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = "abc123.456def"
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseFIPSEndpoint = true
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseFIPSAndDualStackEndpointWithEndpointIdNotSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = null
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseFIPSEndpoint = true,
                UseDualstackEndpoint = true
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://events-fips.us-east-1.api.aws/", internalRequest.Endpoint.ToString());
            CheckV4Authorization(internalRequest);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        [ExpectedException(typeof(AmazonClientException))]
        public void UseFIPSAndDualStackEndpointWithEndpointIdSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = "abc123.456def"
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                UseFIPSEndpoint = true,
                UseDualstackEndpoint = true
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseDefaultIsoEndpointWhenEndpointIdIsNotSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = null
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USIsoEast1
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://events.us-iso-east-1.c2s.ic.gov/", internalRequest.Endpoint.ToString());
            CheckV4Authorization(internalRequest);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseMrapIsoEndpointWhenEndpointIdIsSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = "abc123.456def"
            };

            var config = new AmazonEventBridgeConfig
            {
                RegionEndpoint = RegionEndpoint.USIsoEast1
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://abc123.456def.endpoint.events.c2s.ic.gov/", internalRequest.Endpoint.ToString());
            CheckV4aAuthorization(internalRequest);
            Assert.AreEqual("*", internalRequest.AuthenticationRegion);
            Assert.AreEqual("*", internalRequest.Headers["x-amz-region-set"]);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseOverrideEndpointWhenEndpointIdIsNotSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = null
            };

            var config = new AmazonEventBridgeConfig
            {
                ServiceURL = "https://example.org"
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://example.org/", internalRequest.Endpoint.ToString());
            CheckV4Authorization(internalRequest);
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        public void UseOverrideEndpointWhenEndpointIdIsSet()
        {
            var request = new PutEventsRequest
            {
                EndpointId = "abc123.456def"
            };

            var config = new AmazonEventBridgeConfig
            {
                ServiceURL = "https://example.org"
            };

            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            Assert.AreEqual("https://example.org/", internalRequest.Endpoint.ToString());
            CheckV4aAuthorization(internalRequest);
            Assert.AreEqual("*", internalRequest.AuthenticationRegion);
            Assert.AreEqual("*", internalRequest.Headers["x-amz-region-set"]);
        }
    }
}
