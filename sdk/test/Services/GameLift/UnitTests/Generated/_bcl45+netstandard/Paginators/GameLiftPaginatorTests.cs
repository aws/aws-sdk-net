#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */

using Amazon.GameLift;
using Amazon.GameLift.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GameLiftPaginatorTests
    {
        private static Mock<AmazonGameLiftClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGameLiftClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeFleetAttributesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetAttributesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFleetAttributesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFleetAttributesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFleetAttributes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFleetAttributes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFleetAttributesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetAttributesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFleetAttributesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFleetAttributes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFleetAttributes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeFleetCapacityTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetCapacityRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFleetCapacityResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFleetCapacityResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFleetCapacity(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFleetCapacity(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFleetCapacityTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetCapacityRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFleetCapacityResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFleetCapacity(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFleetCapacity(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeFleetEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFleetEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFleetEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFleetEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFleetEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFleetEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFleetEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFleetEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFleetEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeFleetUtilizationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetUtilizationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFleetUtilizationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFleetUtilizationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFleetUtilization(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFleetUtilization(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFleetUtilizationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFleetUtilizationRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFleetUtilizationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFleetUtilization(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFleetUtilization(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeGameServerInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameServerInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeGameServerInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeGameServerInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeGameServerInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeGameServerInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeGameServerInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameServerInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeGameServerInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeGameServerInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeGameServerInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeGameSessionDetailsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameSessionDetailsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeGameSessionDetailsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeGameSessionDetailsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeGameSessionDetails(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeGameSessionDetails(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeGameSessionDetailsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameSessionDetailsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeGameSessionDetailsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeGameSessionDetails(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeGameSessionDetails(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeGameSessionQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameSessionQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeGameSessionQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeGameSessionQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeGameSessionQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeGameSessionQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeGameSessionQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameSessionQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeGameSessionQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeGameSessionQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeGameSessionQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeGameSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeGameSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeGameSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeGameSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeGameSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeGameSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeGameSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeGameSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeGameSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeGameSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
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
        [TestCategory("GameLift")]
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
        [TestCategory("GameLift")]
        public void DescribeMatchmakingConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMatchmakingConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMatchmakingConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMatchmakingConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMatchmakingConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMatchmakingConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMatchmakingConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMatchmakingConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMatchmakingConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMatchmakingConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMatchmakingConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeMatchmakingRuleSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMatchmakingRuleSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMatchmakingRuleSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMatchmakingRuleSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMatchmakingRuleSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMatchmakingRuleSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMatchmakingRuleSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMatchmakingRuleSetsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMatchmakingRuleSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMatchmakingRuleSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMatchmakingRuleSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribePlayerSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribePlayerSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribePlayerSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribePlayerSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribePlayerSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribePlayerSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribePlayerSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribePlayerSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribePlayerSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribePlayerSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribePlayerSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void DescribeScalingPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalingPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeScalingPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeScalingPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeScalingPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeScalingPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeScalingPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeScalingPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeScalingPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeScalingPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeScalingPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void ListAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void ListBuildsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBuildsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBuildsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBuilds(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBuilds(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBuildsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBuildsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBuilds(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBuilds(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void ListFleetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFleetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFleets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFleets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFleetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFleetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFleetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFleets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFleets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void ListGameServerGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGameServerGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGameServerGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGameServerGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGameServerGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGameServerGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGameServerGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGameServerGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGameServerGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGameServerGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGameServerGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void ListGameServersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGameServersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGameServersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGameServersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGameServers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGameServers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGameServersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGameServersRequest>();

            var response = InstantiateClassGenerator.Execute<ListGameServersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGameServers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGameServers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void ListScriptsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListScriptsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListScriptsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListScriptsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListScripts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListScripts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListScriptsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListScriptsRequest>();

            var response = InstantiateClassGenerator.Execute<ListScriptsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListScripts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListScripts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        public void SearchGameSessionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchGameSessionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchGameSessionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchGameSessionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchGameSessions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchGameSessions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GameLift")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchGameSessionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchGameSessionsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchGameSessionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchGameSessions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchGameSessions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif