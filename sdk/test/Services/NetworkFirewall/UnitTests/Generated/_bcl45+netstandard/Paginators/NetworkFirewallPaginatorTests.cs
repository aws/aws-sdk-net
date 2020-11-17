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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */

using Amazon.NetworkFirewall;
using Amazon.NetworkFirewall.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class NetworkFirewallPaginatorTests
    {
        private static Mock<AmazonNetworkFirewallClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonNetworkFirewallClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkFirewall")]
        public void ListFirewallPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFirewallPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFirewallPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFirewallPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFirewallPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFirewallPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkFirewall")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFirewallPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFirewallPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFirewallPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFirewallPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFirewallPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkFirewall")]
        public void ListFirewallsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFirewallsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFirewallsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFirewallsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFirewalls(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFirewalls(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkFirewall")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFirewallsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFirewallsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFirewallsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFirewalls(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFirewalls(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkFirewall")]
        public void ListRuleGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRuleGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRuleGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRuleGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRuleGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRuleGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkFirewall")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRuleGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRuleGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRuleGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRuleGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRuleGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("NetworkFirewall")]
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
        [TestCategory("NetworkFirewall")]
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