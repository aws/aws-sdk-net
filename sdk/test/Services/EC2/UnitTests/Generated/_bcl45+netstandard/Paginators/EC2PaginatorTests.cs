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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */

using Amazon.EC2;
using Amazon.EC2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class EC2PaginatorTests
    {
        private static Mock<AmazonEC2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonEC2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeByoipCidrsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeByoipCidrsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeByoipCidrsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeByoipCidrsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeByoipCidrs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeByoipCidrs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeByoipCidrsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeByoipCidrsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeByoipCidrsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeByoipCidrs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeByoipCidrs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeCapacityReservationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCapacityReservationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCapacityReservationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCapacityReservationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCapacityReservations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCapacityReservations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCapacityReservationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCapacityReservationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCapacityReservationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCapacityReservations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCapacityReservations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeCarrierGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCarrierGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCarrierGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCarrierGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCarrierGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCarrierGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCarrierGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCarrierGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCarrierGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCarrierGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCarrierGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeClassicLinkInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClassicLinkInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClassicLinkInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClassicLinkInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeClassicLinkInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClassicLinkInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClassicLinkInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClassicLinkInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClassicLinkInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeClassicLinkInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClassicLinkInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeClientVpnAuthorizationRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnAuthorizationRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClientVpnAuthorizationRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClientVpnAuthorizationRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeClientVpnAuthorizationRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnAuthorizationRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClientVpnAuthorizationRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnAuthorizationRulesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClientVpnAuthorizationRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeClientVpnAuthorizationRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnAuthorizationRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeClientVpnConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClientVpnConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClientVpnConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeClientVpnConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClientVpnConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClientVpnConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeClientVpnConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeClientVpnEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClientVpnEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClientVpnEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeClientVpnEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClientVpnEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClientVpnEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeClientVpnEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeClientVpnRoutesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnRoutesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClientVpnRoutesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClientVpnRoutesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeClientVpnRoutes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnRoutes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClientVpnRoutesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnRoutesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClientVpnRoutesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeClientVpnRoutes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnRoutes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeClientVpnTargetNetworksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnTargetNetworksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClientVpnTargetNetworksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClientVpnTargetNetworksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeClientVpnTargetNetworks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnTargetNetworks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClientVpnTargetNetworksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClientVpnTargetNetworksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClientVpnTargetNetworksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeClientVpnTargetNetworks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClientVpnTargetNetworks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeCoipPoolsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCoipPoolsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCoipPoolsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCoipPoolsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCoipPools(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCoipPools(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCoipPoolsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCoipPoolsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCoipPoolsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCoipPools(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCoipPools(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeDhcpOptionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDhcpOptionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDhcpOptionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDhcpOptionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeDhcpOptions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDhcpOptions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDhcpOptionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDhcpOptionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDhcpOptionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeDhcpOptions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDhcpOptions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeEgressOnlyInternetGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEgressOnlyInternetGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEgressOnlyInternetGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEgressOnlyInternetGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEgressOnlyInternetGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEgressOnlyInternetGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEgressOnlyInternetGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEgressOnlyInternetGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEgressOnlyInternetGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEgressOnlyInternetGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEgressOnlyInternetGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeExportImageTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeExportImageTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeExportImageTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeExportImageTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeExportImageTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeExportImageTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeExportImageTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeExportImageTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeExportImageTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeExportImageTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeExportImageTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeFastSnapshotRestoresTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFastSnapshotRestoresRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFastSnapshotRestoresResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFastSnapshotRestoresResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFastSnapshotRestores(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFastSnapshotRestores(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFastSnapshotRestoresTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFastSnapshotRestoresRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFastSnapshotRestoresResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFastSnapshotRestores(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFastSnapshotRestores(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeFleetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFleetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFleetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFleets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFleets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFleetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFleetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFleets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFleets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeFlowLogsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFlowLogsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFlowLogsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFlowLogsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFlowLogs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFlowLogs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFlowLogsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFlowLogsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFlowLogsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFlowLogs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFlowLogs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeFpgaImagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFpgaImagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFpgaImagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFpgaImagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFpgaImages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFpgaImages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFpgaImagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFpgaImagesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFpgaImagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFpgaImages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFpgaImages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeHostReservationOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHostReservationOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeHostReservationOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeHostReservationOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeHostReservationOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeHostReservationOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeHostReservationOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHostReservationOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeHostReservationOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeHostReservationOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeHostReservationOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeHostReservationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHostReservationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeHostReservationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeHostReservationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeHostReservations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeHostReservations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeHostReservationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHostReservationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeHostReservationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeHostReservations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeHostReservations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeHostsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHostsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeHostsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeHostsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeHosts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeHosts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeHostsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeHostsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeHostsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeHosts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeHosts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeIamInstanceProfileAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeIamInstanceProfileAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeIamInstanceProfileAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeIamInstanceProfileAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeIamInstanceProfileAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeIamInstanceProfileAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeIamInstanceProfileAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeIamInstanceProfileAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeIamInstanceProfileAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeIamInstanceProfileAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeIamInstanceProfileAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeImportImageTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImportImageTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImportImageTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImportImageTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImportImageTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImportImageTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImportImageTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImportImageTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImportImageTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImportImageTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImportImageTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeImportSnapshotTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImportSnapshotTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImportSnapshotTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImportSnapshotTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImportSnapshotTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImportSnapshotTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImportSnapshotTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImportSnapshotTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImportSnapshotTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImportSnapshotTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImportSnapshotTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeInstanceCreditSpecificationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceCreditSpecificationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstanceCreditSpecificationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstanceCreditSpecificationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstanceCreditSpecifications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceCreditSpecifications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstanceCreditSpecificationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceCreditSpecificationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstanceCreditSpecificationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstanceCreditSpecifications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceCreditSpecifications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeInstanceStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstanceStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstanceStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstanceStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstanceStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstanceStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstanceStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeInstanceTypeOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceTypeOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstanceTypeOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstanceTypeOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstanceTypeOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceTypeOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstanceTypeOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceTypeOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstanceTypeOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstanceTypeOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceTypeOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeInstanceTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInstanceTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInstanceTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInstanceTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInstanceTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInstanceTypesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInstanceTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInstanceTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInstanceTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeInternetGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInternetGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInternetGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInternetGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInternetGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInternetGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInternetGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInternetGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInternetGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInternetGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInternetGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeIpv6PoolsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeIpv6PoolsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeIpv6PoolsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeIpv6PoolsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeIpv6Pools(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeIpv6Pools(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeIpv6PoolsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeIpv6PoolsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeIpv6PoolsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeIpv6Pools(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeIpv6Pools(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLaunchTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLaunchTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLaunchTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLaunchTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLaunchTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLaunchTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLaunchTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLaunchTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLaunchTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLaunchTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLaunchTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLaunchTemplateVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLaunchTemplateVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLaunchTemplateVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLaunchTemplateVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLaunchTemplateVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLaunchTemplateVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLaunchTemplateVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLaunchTemplateVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLaunchTemplateVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLaunchTemplateVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLaunchTemplateVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayRouteTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLocalGatewayRouteTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayRouteTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLocalGatewayRouteTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTablesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLocalGatewayRouteTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayRouteTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayRouteTableVirtualInterfaceGroupAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayRouteTableVpcAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVpcAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVpcAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVpcAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLocalGatewayRouteTableVpcAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayRouteTableVpcAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLocalGatewayRouteTableVpcAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVpcAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLocalGatewayRouteTableVpcAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLocalGatewayRouteTableVpcAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayRouteTableVpcAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLocalGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLocalGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLocalGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLocalGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayVirtualInterfaceGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfaceGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfaceGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfaceGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLocalGatewayVirtualInterfaceGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayVirtualInterfaceGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLocalGatewayVirtualInterfaceGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfaceGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfaceGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLocalGatewayVirtualInterfaceGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayVirtualInterfaceGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeLocalGatewayVirtualInterfacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLocalGatewayVirtualInterfaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayVirtualInterfaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLocalGatewayVirtualInterfacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfacesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLocalGatewayVirtualInterfacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLocalGatewayVirtualInterfaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLocalGatewayVirtualInterfaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeManagedPrefixListsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeManagedPrefixListsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeManagedPrefixListsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeManagedPrefixListsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeManagedPrefixLists(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeManagedPrefixLists(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeManagedPrefixListsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeManagedPrefixListsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeManagedPrefixListsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeManagedPrefixLists(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeManagedPrefixLists(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeMovingAddressesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMovingAddressesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMovingAddressesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMovingAddressesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMovingAddresses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMovingAddresses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMovingAddressesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMovingAddressesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMovingAddressesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMovingAddresses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMovingAddresses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeNatGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNatGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNatGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNatGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNatGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNatGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNatGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNatGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNatGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNatGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNatGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeNetworkAclsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkAclsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNetworkAclsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNetworkAclsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNetworkAcls(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkAcls(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNetworkAclsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkAclsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNetworkAclsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNetworkAcls(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkAcls(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeNetworkInsightsAnalysesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAnalysesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAnalysesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAnalysesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNetworkInsightsAnalyses(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInsightsAnalyses(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNetworkInsightsAnalysesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAnalysesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNetworkInsightsAnalysesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNetworkInsightsAnalyses(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInsightsAnalyses(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeNetworkInsightsPathsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsPathsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNetworkInsightsPathsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNetworkInsightsPathsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNetworkInsightsPaths(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInsightsPaths(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNetworkInsightsPathsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInsightsPathsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNetworkInsightsPathsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNetworkInsightsPaths(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInsightsPaths(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeNetworkInterfacePermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInterfacePermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNetworkInterfacePermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNetworkInterfacePermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNetworkInterfacePermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInterfacePermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNetworkInterfacePermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInterfacePermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNetworkInterfacePermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNetworkInterfacePermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInterfacePermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeNetworkInterfacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInterfacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeNetworkInterfacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeNetworkInterfacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeNetworkInterfaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInterfaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeNetworkInterfacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeNetworkInterfacesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeNetworkInterfacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeNetworkInterfaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeNetworkInterfaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribePrefixListsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePrefixListsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePrefixListsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePrefixListsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePrefixLists(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePrefixLists(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePrefixListsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePrefixListsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePrefixListsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePrefixLists(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePrefixLists(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribePrincipalIdFormatTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePrincipalIdFormatRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePrincipalIdFormatResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePrincipalIdFormatResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePrincipalIdFormat(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePrincipalIdFormat(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePrincipalIdFormatTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePrincipalIdFormatRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePrincipalIdFormatResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePrincipalIdFormat(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePrincipalIdFormat(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribePublicIpv4PoolsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePublicIpv4PoolsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePublicIpv4PoolsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePublicIpv4PoolsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePublicIpv4Pools(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePublicIpv4Pools(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePublicIpv4PoolsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePublicIpv4PoolsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePublicIpv4PoolsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePublicIpv4Pools(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePublicIpv4Pools(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeReservedInstancesModificationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesModificationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedInstancesModificationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedInstancesModificationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReservedInstancesModifications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstancesModifications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedInstancesModificationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesModificationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedInstancesModificationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReservedInstancesModifications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstancesModifications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeReservedInstancesOfferingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesOfferingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReservedInstancesOfferingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReservedInstancesOfferingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReservedInstancesOfferings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstancesOfferings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReservedInstancesOfferingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReservedInstancesOfferingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReservedInstancesOfferingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReservedInstancesOfferings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReservedInstancesOfferings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeRouteTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRouteTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRouteTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRouteTablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRouteTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRouteTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRouteTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRouteTablesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRouteTablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRouteTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRouteTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeScheduledInstanceAvailabilityTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledInstanceAvailabilityRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScheduledInstanceAvailabilityResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScheduledInstanceAvailabilityResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeScheduledInstanceAvailability(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledInstanceAvailability(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScheduledInstanceAvailabilityTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledInstanceAvailabilityRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScheduledInstanceAvailabilityResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeScheduledInstanceAvailability(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledInstanceAvailability(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeScheduledInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScheduledInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScheduledInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeScheduledInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScheduledInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScheduledInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScheduledInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeScheduledInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScheduledInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeSecurityGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSecurityGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSecurityGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSecurityGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSecurityGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSecurityGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSecurityGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSecurityGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSecurityGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSecurityGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSecurityGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeSnapshotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSnapshotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSnapshotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSnapshots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSnapshotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSnapshotsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSnapshotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSnapshots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSnapshots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeSpotFleetRequestsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSpotFleetRequestsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSpotFleetRequestsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSpotFleetRequestsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSpotFleetRequests(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSpotFleetRequests(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSpotFleetRequestsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSpotFleetRequestsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSpotFleetRequestsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSpotFleetRequests(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSpotFleetRequests(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeSpotInstanceRequestsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSpotInstanceRequestsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSpotInstanceRequestsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSpotInstanceRequestsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSpotInstanceRequests(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSpotInstanceRequests(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSpotInstanceRequestsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSpotInstanceRequestsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSpotInstanceRequestsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSpotInstanceRequests(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSpotInstanceRequests(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeSpotPriceHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSpotPriceHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSpotPriceHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSpotPriceHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSpotPriceHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSpotPriceHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSpotPriceHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSpotPriceHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSpotPriceHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSpotPriceHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSpotPriceHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeStaleSecurityGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStaleSecurityGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeStaleSecurityGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeStaleSecurityGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeStaleSecurityGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeStaleSecurityGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeStaleSecurityGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStaleSecurityGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeStaleSecurityGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeStaleSecurityGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeStaleSecurityGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeSubnetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSubnetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSubnetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSubnetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSubnets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSubnets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSubnetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSubnetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSubnetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSubnets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSubnets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTrafficMirrorFiltersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorFiltersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTrafficMirrorFiltersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTrafficMirrorFiltersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTrafficMirrorFilters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTrafficMirrorFilters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTrafficMirrorFiltersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorFiltersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTrafficMirrorFiltersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTrafficMirrorFilters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTrafficMirrorFilters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTrafficMirrorSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTrafficMirrorSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTrafficMirrorSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTrafficMirrorSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTrafficMirrorSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTrafficMirrorSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTrafficMirrorSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTrafficMirrorSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTrafficMirrorSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTrafficMirrorTargetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorTargetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTrafficMirrorTargetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTrafficMirrorTargetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTrafficMirrorTargets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTrafficMirrorTargets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTrafficMirrorTargetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTrafficMirrorTargetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTrafficMirrorTargetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTrafficMirrorTargets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTrafficMirrorTargets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayAttachmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayAttachmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayAttachmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayAttachmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGatewayAttachments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayAttachments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewayAttachmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayAttachmentsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewayAttachmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGatewayAttachments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayAttachments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayConnectPeersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectPeersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectPeersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectPeersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGatewayConnectPeers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayConnectPeers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewayConnectPeersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectPeersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectPeersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGatewayConnectPeers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayConnectPeers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayConnectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGatewayConnects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayConnects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewayConnectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewayConnectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGatewayConnects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayConnects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayMulticastDomainsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayMulticastDomainsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayMulticastDomainsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayMulticastDomainsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGatewayMulticastDomains(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayMulticastDomains(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewayMulticastDomainsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayMulticastDomainsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewayMulticastDomainsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGatewayMulticastDomains(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayMulticastDomains(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayPeeringAttachmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayPeeringAttachmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayPeeringAttachmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayPeeringAttachmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGatewayPeeringAttachments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayPeeringAttachments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewayPeeringAttachmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayPeeringAttachmentsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewayPeeringAttachmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGatewayPeeringAttachments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayPeeringAttachments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayRouteTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayRouteTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayRouteTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayRouteTablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGatewayRouteTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayRouteTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewayRouteTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayRouteTablesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewayRouteTablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGatewayRouteTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayRouteTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeTransitGatewayVpcAttachmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayVpcAttachmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayVpcAttachmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTransitGatewayVpcAttachmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTransitGatewayVpcAttachments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayVpcAttachments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTransitGatewayVpcAttachmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTransitGatewayVpcAttachmentsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTransitGatewayVpcAttachmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTransitGatewayVpcAttachments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTransitGatewayVpcAttachments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVolumesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVolumesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVolumesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVolumesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVolumes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVolumes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVolumesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVolumesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVolumesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVolumes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVolumes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVolumesModificationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVolumesModificationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVolumesModificationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVolumesModificationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVolumesModifications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVolumesModifications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVolumesModificationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVolumesModificationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVolumesModificationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVolumesModifications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVolumesModifications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVolumeStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVolumeStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVolumeStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVolumeStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVolumeStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVolumeStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVolumeStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVolumeStatusRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVolumeStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVolumeStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVolumeStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcClassicLinkDnsSupportTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcClassicLinkDnsSupportRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcClassicLinkDnsSupportResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcClassicLinkDnsSupportResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcClassicLinkDnsSupport(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcClassicLinkDnsSupport(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcClassicLinkDnsSupportTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcClassicLinkDnsSupportRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcClassicLinkDnsSupportResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcClassicLinkDnsSupport(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcClassicLinkDnsSupport(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointConnectionNotificationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionNotificationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionNotificationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionNotificationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcEndpointConnectionNotifications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointConnectionNotifications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcEndpointConnectionNotificationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionNotificationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionNotificationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcEndpointConnectionNotifications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointConnectionNotifications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcEndpointConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcEndpointConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcEndpointConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcEndpointConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointServiceConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointServiceConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointServiceConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointServiceConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcEndpointServiceConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointServiceConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcEndpointServiceConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointServiceConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcEndpointServiceConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcEndpointServiceConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointServiceConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcEndpointServicePermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointServicePermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointServicePermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcEndpointServicePermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcEndpointServicePermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointServicePermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcEndpointServicePermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcEndpointServicePermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcEndpointServicePermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcEndpointServicePermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcEndpointServicePermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcPeeringConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcPeeringConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcPeeringConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcPeeringConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcPeeringConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcPeeringConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcPeeringConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcPeeringConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcPeeringConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcPeeringConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcPeeringConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void DescribeVpcsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeVpcsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeVpcsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeVpcs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeVpcs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeVpcsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeVpcsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeVpcsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeVpcs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeVpcs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetAssociatedIpv6PoolCidrsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAssociatedIpv6PoolCidrsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAssociatedIpv6PoolCidrsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAssociatedIpv6PoolCidrsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAssociatedIpv6PoolCidrs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAssociatedIpv6PoolCidrs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAssociatedIpv6PoolCidrsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAssociatedIpv6PoolCidrsRequest>();

            var response = InstantiateClassGenerator.Execute<GetAssociatedIpv6PoolCidrsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAssociatedIpv6PoolCidrs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAssociatedIpv6PoolCidrs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetGroupsForCapacityReservationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetGroupsForCapacityReservationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetGroupsForCapacityReservationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetGroupsForCapacityReservationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetGroupsForCapacityReservation(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetGroupsForCapacityReservation(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetGroupsForCapacityReservationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetGroupsForCapacityReservationRequest>();

            var response = InstantiateClassGenerator.Execute<GetGroupsForCapacityReservationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetGroupsForCapacityReservation(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetGroupsForCapacityReservation(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetManagedPrefixListAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetManagedPrefixListAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetManagedPrefixListAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetManagedPrefixListAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetManagedPrefixListAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetManagedPrefixListAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetManagedPrefixListAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetManagedPrefixListAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetManagedPrefixListAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetManagedPrefixListAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetManagedPrefixListAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetManagedPrefixListEntriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetManagedPrefixListEntriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetManagedPrefixListEntriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetManagedPrefixListEntriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetManagedPrefixListEntries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetManagedPrefixListEntries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetManagedPrefixListEntriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetManagedPrefixListEntriesRequest>();

            var response = InstantiateClassGenerator.Execute<GetManagedPrefixListEntriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetManagedPrefixListEntries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetManagedPrefixListEntries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetTransitGatewayAttachmentPropagationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayAttachmentPropagationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTransitGatewayAttachmentPropagationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTransitGatewayAttachmentPropagationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTransitGatewayAttachmentPropagations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayAttachmentPropagations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTransitGatewayAttachmentPropagationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayAttachmentPropagationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTransitGatewayAttachmentPropagationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTransitGatewayAttachmentPropagations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayAttachmentPropagations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetTransitGatewayMulticastDomainAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayMulticastDomainAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTransitGatewayMulticastDomainAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTransitGatewayMulticastDomainAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTransitGatewayMulticastDomainAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayMulticastDomainAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTransitGatewayMulticastDomainAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayMulticastDomainAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTransitGatewayMulticastDomainAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTransitGatewayMulticastDomainAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayMulticastDomainAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetTransitGatewayPrefixListReferencesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayPrefixListReferencesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTransitGatewayPrefixListReferencesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTransitGatewayPrefixListReferencesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTransitGatewayPrefixListReferences(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayPrefixListReferences(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTransitGatewayPrefixListReferencesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayPrefixListReferencesRequest>();

            var response = InstantiateClassGenerator.Execute<GetTransitGatewayPrefixListReferencesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTransitGatewayPrefixListReferences(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayPrefixListReferences(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetTransitGatewayRouteTableAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTableAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTableAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTableAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTransitGatewayRouteTableAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayRouteTableAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTransitGatewayRouteTableAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTableAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTableAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTransitGatewayRouteTableAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayRouteTableAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void GetTransitGatewayRouteTablePropagationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTablePropagationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTablePropagationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTablePropagationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTransitGatewayRouteTablePropagations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayRouteTablePropagations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTransitGatewayRouteTablePropagationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTablePropagationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTransitGatewayRouteTablePropagationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTransitGatewayRouteTablePropagations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTransitGatewayRouteTablePropagations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void SearchLocalGatewayRoutesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchLocalGatewayRoutesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchLocalGatewayRoutesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchLocalGatewayRoutesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchLocalGatewayRoutes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchLocalGatewayRoutes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchLocalGatewayRoutesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchLocalGatewayRoutesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchLocalGatewayRoutesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchLocalGatewayRoutes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchLocalGatewayRoutes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        public void SearchTransitGatewayMulticastGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchTransitGatewayMulticastGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchTransitGatewayMulticastGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchTransitGatewayMulticastGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchTransitGatewayMulticastGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchTransitGatewayMulticastGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("EC2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchTransitGatewayMulticastGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchTransitGatewayMulticastGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchTransitGatewayMulticastGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchTransitGatewayMulticastGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchTransitGatewayMulticastGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif