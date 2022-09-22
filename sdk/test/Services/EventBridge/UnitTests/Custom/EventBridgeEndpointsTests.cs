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
using Amazon.Runtime.Endpoints;
using Amazon.EventBridge;
using Amazon.EventBridge.Model;
using Amazon.EventBridge.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EventBridgeEndpointsTests
    {
        [TestMethod]
        [TestCategory("EventBridge")]
        [TestCategory("Endpoints")]
        public void UseCustomEndpointProvider()
        {
            var config = new AmazonEventBridgeConfig
            {
                EndpointProvider = new CustomEndpointProvider()
            };

            var request = new PutEventsRequest();
            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);

            Assert.AreEqual("https://custom-endpoint/", internalRequest.Endpoint.ToString());
        }


        [TestMethod]
        [TestCategory("EventBridge")]
        [TestCategory("Endpoints")]
        public void UseStaticEndpointProvider()
        {
            var config = new AmazonEventBridgeConfig
            {
                EndpointProvider = new StaticEndpointProvider("https://static-endpoint/")
            };
            
            var request = new PutEventsRequest();
            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);

            Assert.AreEqual("https://static-endpoint/", internalRequest.Endpoint.ToString());
        }

        [TestMethod]
        [TestCategory("EventBridge")]
        [TestCategory("Endpoints")]
        public void UseGlobalEndpointProvider()
        {
            var config = new AmazonEventBridgeConfig
            {
                EndpointProvider = new StaticEndpointProvider("https://static-endpoint/")
            };

            // that will override all other providers
            GlobalEndpoints.Provider = new GlobalEndpointProvider();

            var request = new PutEventsRequest();
            var internalRequest = EventBridgeTestUtils.RunMockRequest(request, PutEventsRequestMarshaller.Instance, config);
            
            // we have to reset it after use!
            GlobalEndpoints.Provider = null;

            Assert.AreEqual("http://global-endpoint/", internalRequest.Endpoint.ToString());
            
        }

    }
}
