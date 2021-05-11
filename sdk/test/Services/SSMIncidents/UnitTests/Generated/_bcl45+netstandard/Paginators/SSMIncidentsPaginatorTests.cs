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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */

using Amazon.SSMIncidents;
using Amazon.SSMIncidents.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SSMIncidentsPaginatorTests
    {
        private static Mock<AmazonSSMIncidentsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSSMIncidentsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        public void GetResourcePoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcePoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourcePolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourcePolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourcePoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcePoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourcePolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourcePolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        public void ListIncidentRecordsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIncidentRecordsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIncidentRecordsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIncidentRecordsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIncidentRecords(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIncidentRecords(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIncidentRecordsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIncidentRecordsRequest>();

            var response = InstantiateClassGenerator.Execute<ListIncidentRecordsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIncidentRecords(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIncidentRecords(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        public void ListRelatedItemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRelatedItemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRelatedItemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRelatedItemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRelatedItems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRelatedItems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRelatedItemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRelatedItemsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRelatedItemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRelatedItems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRelatedItems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        public void ListReplicationSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReplicationSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReplicationSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReplicationSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReplicationSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReplicationSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReplicationSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReplicationSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListReplicationSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReplicationSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReplicationSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        public void ListResponsePlansTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResponsePlansRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResponsePlansResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResponsePlansResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResponsePlans(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResponsePlans(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResponsePlansTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResponsePlansRequest>();

            var response = InstantiateClassGenerator.Execute<ListResponsePlansResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResponsePlans(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResponsePlans(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        public void ListTimelineEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTimelineEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTimelineEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTimelineEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTimelineEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTimelineEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSMIncidents")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTimelineEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTimelineEventsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTimelineEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTimelineEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTimelineEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}