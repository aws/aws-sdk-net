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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */

using Amazon.XRay;
using Amazon.XRay.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class XRayPaginatorTests
    {
        private static Mock<AmazonXRayClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonXRayClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void BatchGetTracesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<BatchGetTracesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<BatchGetTracesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<BatchGetTracesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.BatchGetTraces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.BatchGetTraces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void BatchGetTracesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<BatchGetTracesRequest>();

            var response = InstantiateClassGenerator.Execute<BatchGetTracesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.BatchGetTraces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.BatchGetTraces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<GetGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetInsightEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetInsightEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetInsightEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetInsightEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetInsightEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetInsightEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetInsightEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetInsightEventsRequest>();

            var response = InstantiateClassGenerator.Execute<GetInsightEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetInsightEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetInsightEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetInsightSummariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetInsightSummariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetInsightSummariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetInsightSummariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetInsightSummaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetInsightSummaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetInsightSummariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetInsightSummariesRequest>();

            var response = InstantiateClassGenerator.Execute<GetInsightSummariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetInsightSummaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetInsightSummaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetSamplingRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSamplingRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSamplingRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSamplingRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSamplingRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSamplingRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSamplingRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSamplingRulesRequest>();

            var response = InstantiateClassGenerator.Execute<GetSamplingRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSamplingRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSamplingRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetSamplingStatisticSummariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSamplingStatisticSummariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSamplingStatisticSummariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSamplingStatisticSummariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSamplingStatisticSummaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSamplingStatisticSummaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSamplingStatisticSummariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSamplingStatisticSummariesRequest>();

            var response = InstantiateClassGenerator.Execute<GetSamplingStatisticSummariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSamplingStatisticSummaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSamplingStatisticSummaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetServiceGraphTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetServiceGraphRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetServiceGraphResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetServiceGraphResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetServiceGraph(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetServiceGraph(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetServiceGraphTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetServiceGraphRequest>();

            var response = InstantiateClassGenerator.Execute<GetServiceGraphResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetServiceGraph(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetServiceGraph(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetTimeSeriesServiceStatisticsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTimeSeriesServiceStatisticsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTimeSeriesServiceStatisticsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTimeSeriesServiceStatisticsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTimeSeriesServiceStatistics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTimeSeriesServiceStatistics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTimeSeriesServiceStatisticsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTimeSeriesServiceStatisticsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTimeSeriesServiceStatisticsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTimeSeriesServiceStatistics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTimeSeriesServiceStatistics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetTraceGraphTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTraceGraphRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTraceGraphResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTraceGraphResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTraceGraph(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTraceGraph(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTraceGraphTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTraceGraphRequest>();

            var response = InstantiateClassGenerator.Execute<GetTraceGraphResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTraceGraph(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTraceGraph(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        public void GetTraceSummariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTraceSummariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTraceSummariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTraceSummariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTraceSummaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTraceSummaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("XRay")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTraceSummariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTraceSummariesRequest>();

            var response = InstantiateClassGenerator.Execute<GetTraceSummariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTraceSummaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTraceSummaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif