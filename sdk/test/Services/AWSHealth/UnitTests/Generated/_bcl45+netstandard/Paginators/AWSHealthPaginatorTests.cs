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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */

using Amazon.AWSHealth;
using Amazon.AWSHealth.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AWSHealthPaginatorTests
    {
        private static Mock<AmazonAWSHealthClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAWSHealthClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedAccountsForOrganizationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedAccountsForOrganizationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAffectedAccountsForOrganizationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAffectedAccountsForOrganizationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAffectedAccountsForOrganization(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAffectedAccountsForOrganization(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAffectedAccountsForOrganizationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedAccountsForOrganizationRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAffectedAccountsForOrganizationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAffectedAccountsForOrganization(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAffectedAccountsForOrganization(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntitiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAffectedEntities(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAffectedEntities(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAffectedEntitiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAffectedEntities(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAffectedEntities(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        public void DescribeAffectedEntitiesForOrganizationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAffectedEntitiesForOrganization(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAffectedEntitiesForOrganization(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAffectedEntitiesForOrganizationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAffectedEntitiesForOrganizationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAffectedEntitiesForOrganization(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAffectedEntitiesForOrganization(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        public void DescribeEventAggregatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventAggregatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventAggregatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventAggregatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEventAggregates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEventAggregates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventAggregatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventAggregatesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventAggregatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEventAggregates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEventAggregates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        public void DescribeEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        public void DescribeEventsForOrganizationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEventsForOrganization(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEventsForOrganization(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventsForOrganizationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventsForOrganizationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEventsForOrganization(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEventsForOrganization(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        public void DescribeEventTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEventTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEventTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSHealth")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventTypesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEventTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEventTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}