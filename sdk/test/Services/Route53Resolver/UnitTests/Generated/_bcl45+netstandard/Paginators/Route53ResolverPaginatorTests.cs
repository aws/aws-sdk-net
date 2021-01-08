#if !NETSTANDARD13
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

/*
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */

using Amazon.Route53Resolver;
using Amazon.Route53Resolver.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class Route53ResolverPaginatorTests
    {
        private static Mock<AmazonRoute53ResolverClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRoute53ResolverClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListResolverDnssecConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverDnssecConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResolverDnssecConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResolverDnssecConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResolverDnssecConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResolverDnssecConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResolverDnssecConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverDnssecConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResolverDnssecConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResolverDnssecConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResolverDnssecConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListResolverEndpointIpAddressesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverEndpointIpAddressesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResolverEndpointIpAddressesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResolverEndpointIpAddressesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResolverEndpointIpAddresses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResolverEndpointIpAddresses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResolverEndpointIpAddressesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverEndpointIpAddressesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResolverEndpointIpAddressesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResolverEndpointIpAddresses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResolverEndpointIpAddresses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListResolverEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResolverEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResolverEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResolverEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResolverEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResolverEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResolverEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResolverEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResolverEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListResolverQueryLogConfigAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResolverQueryLogConfigAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResolverQueryLogConfigAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResolverQueryLogConfigAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResolverQueryLogConfigAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResolverQueryLogConfigAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListResolverQueryLogConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResolverQueryLogConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResolverQueryLogConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResolverQueryLogConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResolverQueryLogConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResolverQueryLogConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResolverQueryLogConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListResolverRuleAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverRuleAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResolverRuleAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResolverRuleAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResolverRuleAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResolverRuleAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResolverRuleAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverRuleAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResolverRuleAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResolverRuleAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResolverRuleAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListResolverRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResolverRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResolverRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResolverRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResolverRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResolverRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResolverRulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResolverRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResolverRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResolverRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53Resolver")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif