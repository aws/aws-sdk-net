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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */

using Amazon.Connect;
using Amazon.Connect.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ConnectPaginatorTests
    {
        private static Mock<AmazonConnectClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonConnectClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void GetCurrentMetricDataTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCurrentMetricDataRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCurrentMetricDataResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCurrentMetricDataResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCurrentMetricData(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCurrentMetricData(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCurrentMetricDataTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCurrentMetricDataRequest>();

            var response = InstantiateClassGenerator.Execute<GetCurrentMetricDataResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCurrentMetricData(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCurrentMetricData(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void GetMetricDataTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetMetricDataRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetMetricDataResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetMetricDataResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetMetricData(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetMetricData(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetMetricDataTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetMetricDataRequest>();

            var response = InstantiateClassGenerator.Execute<GetMetricDataResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetMetricData(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetMetricData(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListApprovedOriginsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApprovedOriginsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApprovedOriginsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApprovedOriginsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApprovedOrigins(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApprovedOrigins(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApprovedOriginsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApprovedOriginsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApprovedOriginsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApprovedOrigins(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApprovedOrigins(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListContactFlowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContactFlowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContactFlowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContactFlowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContactFlows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContactFlows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContactFlowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContactFlowsRequest>();

            var response = InstantiateClassGenerator.Execute<ListContactFlowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContactFlows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContactFlows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListHoursOfOperationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHoursOfOperationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHoursOfOperationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHoursOfOperationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHoursOfOperations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHoursOfOperations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHoursOfOperationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHoursOfOperationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHoursOfOperationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHoursOfOperations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHoursOfOperations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListInstanceAttributesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceAttributesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstanceAttributesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstanceAttributesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInstanceAttributes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstanceAttributes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstanceAttributesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceAttributesRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstanceAttributesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInstanceAttributes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstanceAttributes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListInstanceStorageConfigsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceStorageConfigsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstanceStorageConfigsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstanceStorageConfigsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInstanceStorageConfigs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstanceStorageConfigs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstanceStorageConfigsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceStorageConfigsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstanceStorageConfigsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInstanceStorageConfigs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstanceStorageConfigs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListIntegrationAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIntegrationAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIntegrationAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIntegrationAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIntegrationAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIntegrationAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIntegrationAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIntegrationAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListIntegrationAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIntegrationAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIntegrationAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListLambdaFunctionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLambdaFunctionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLambdaFunctionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLambdaFunctionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLambdaFunctions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLambdaFunctions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLambdaFunctionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLambdaFunctionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLambdaFunctionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLambdaFunctions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLambdaFunctions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListLexBotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLexBotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLexBotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLexBotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLexBots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLexBots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLexBotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLexBotsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLexBotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLexBots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLexBots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListPhoneNumbersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPhoneNumbers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPhoneNumbersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPhoneNumbersRequest>();

            var response = InstantiateClassGenerator.Execute<ListPhoneNumbersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPhoneNumbers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPhoneNumbers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListPromptsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPromptsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPromptsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPromptsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPrompts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPrompts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPromptsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPromptsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPromptsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPrompts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPrompts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<ListQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListQuickConnectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListQuickConnectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListQuickConnectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListQuickConnectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListQuickConnects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListQuickConnects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListQuickConnectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListQuickConnectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListQuickConnectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListQuickConnects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListQuickConnects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListRoutingProfileQueuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingProfileQueuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoutingProfileQueuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoutingProfileQueuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoutingProfileQueues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoutingProfileQueues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoutingProfileQueuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingProfileQueuesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoutingProfileQueuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoutingProfileQueues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoutingProfileQueues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListRoutingProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRoutingProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRoutingProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRoutingProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRoutingProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRoutingProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRoutingProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRoutingProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRoutingProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRoutingProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListSecurityKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecurityKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecurityKeysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecurityKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecurityKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecurityKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityKeysRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecurityKeysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecurityKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecurityKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListSecurityProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSecurityProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecurityProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecurityProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSecurityProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecurityProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListUseCasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUseCasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUseCasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUseCasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUseCases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUseCases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUseCasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUseCasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListUseCasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUseCases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUseCases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListUserHierarchyGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUserHierarchyGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUserHierarchyGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUserHierarchyGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListUserHierarchyGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUserHierarchyGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUserHierarchyGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        public void ListUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Connect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif