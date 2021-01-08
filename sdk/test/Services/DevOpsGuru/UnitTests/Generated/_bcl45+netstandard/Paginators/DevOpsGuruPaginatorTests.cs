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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */

using Amazon.DevOpsGuru;
using Amazon.DevOpsGuru.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DevOpsGuruPaginatorTests
    {
        private static Mock<AmazonDevOpsGuruClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDevOpsGuruClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void DescribeResourceCollectionHealthTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeResourceCollectionHealthRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeResourceCollectionHealthResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeResourceCollectionHealthResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeResourceCollectionHealth(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeResourceCollectionHealth(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeResourceCollectionHealthTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeResourceCollectionHealthRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeResourceCollectionHealthResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeResourceCollectionHealth(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeResourceCollectionHealth(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void GetResourceCollectionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceCollectionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourceCollectionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourceCollectionResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourceCollection(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourceCollection(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourceCollectionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceCollectionRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourceCollectionResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourceCollection(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourceCollection(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void ListAnomaliesForInsightTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomaliesForInsightRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnomaliesForInsightResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnomaliesForInsightResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnomaliesForInsight(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnomaliesForInsight(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnomaliesForInsightTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomaliesForInsightRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnomaliesForInsightResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnomaliesForInsight(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnomaliesForInsight(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void ListEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEventsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void ListInsightsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInsightsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInsightsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInsightsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInsights(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInsights(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInsightsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInsightsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInsightsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInsights(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInsights(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void ListNotificationChannelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNotificationChannelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNotificationChannelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNotificationChannelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNotificationChannels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNotificationChannels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNotificationChannelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNotificationChannelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListNotificationChannelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNotificationChannels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNotificationChannels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void ListRecommendationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecommendationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecommendationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecommendations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecommendations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecommendationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecommendationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecommendationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecommendations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecommendations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        public void SearchInsightsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchInsightsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchInsightsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchInsightsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchInsights(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchInsights(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DevOpsGuru")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchInsightsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchInsightsRequest>();

            var response = InstantiateClassGenerator.Execute<SearchInsightsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchInsights(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchInsights(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif