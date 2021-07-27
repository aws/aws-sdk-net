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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */

using Amazon.Route53RecoveryControlConfig;
using Amazon.Route53RecoveryControlConfig.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class Route53RecoveryControlConfigPaginatorTests
    {
        private static Mock<AmazonRoute53RecoveryControlConfigClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRoute53RecoveryControlConfigClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        public void ListAssociatedRoute53HealthChecksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedRoute53HealthChecksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssociatedRoute53HealthChecksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssociatedRoute53HealthChecksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssociatedRoute53HealthChecks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssociatedRoute53HealthChecks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssociatedRoute53HealthChecksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssociatedRoute53HealthChecksRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssociatedRoute53HealthChecksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssociatedRoute53HealthChecks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssociatedRoute53HealthChecks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        public void ListClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var response = InstantiateClassGenerator.Execute<ListClustersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        public void ListControlPanelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListControlPanelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListControlPanelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListControlPanelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListControlPanels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListControlPanels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListControlPanelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListControlPanelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListControlPanelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListControlPanels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListControlPanels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        public void ListRoutingControlsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingControlsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoutingControlsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoutingControlsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoutingControls(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoutingControls(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoutingControlsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingControlsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoutingControlsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoutingControls(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoutingControls(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        public void ListSafetyRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSafetyRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSafetyRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSafetyRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSafetyRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSafetyRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Route53RecoveryControlConfig")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSafetyRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSafetyRulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSafetyRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSafetyRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSafetyRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}