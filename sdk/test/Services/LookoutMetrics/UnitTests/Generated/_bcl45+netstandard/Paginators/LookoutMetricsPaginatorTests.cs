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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */

using Amazon.LookoutMetrics;
using Amazon.LookoutMetrics.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LookoutMetricsPaginatorTests
    {
        private static Mock<AmazonLookoutMetricsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLookoutMetricsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        public void DescribeAnomalyDetectionExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAnomalyDetectionExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAnomalyDetectionExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAnomalyDetectionExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAnomalyDetectionExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAnomalyDetectionExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAnomalyDetectionExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAnomalyDetectionExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAnomalyDetectionExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAnomalyDetectionExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAnomalyDetectionExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        public void GetFeedbackTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetFeedbackRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetFeedbackResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetFeedbackResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetFeedback(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetFeedback(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetFeedbackTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetFeedbackRequest>();

            var response = InstantiateClassGenerator.Execute<GetFeedbackResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetFeedback(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetFeedback(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        public void ListAlertsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAlertsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAlertsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAlertsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAlerts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAlerts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAlertsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAlertsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAlertsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAlerts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAlerts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        public void ListAnomalyDetectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomalyDetectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnomalyDetectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnomalyDetectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnomalyDetectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnomalyDetectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnomalyDetectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomalyDetectorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnomalyDetectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnomalyDetectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnomalyDetectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        public void ListAnomalyGroupSummariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomalyGroupSummariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnomalyGroupSummariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnomalyGroupSummariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnomalyGroupSummaries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnomalyGroupSummaries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnomalyGroupSummariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomalyGroupSummariesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnomalyGroupSummariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnomalyGroupSummaries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnomalyGroupSummaries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        public void ListAnomalyGroupTimeSeriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomalyGroupTimeSeriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAnomalyGroupTimeSeriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAnomalyGroupTimeSeriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAnomalyGroupTimeSeries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAnomalyGroupTimeSeries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAnomalyGroupTimeSeriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAnomalyGroupTimeSeriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAnomalyGroupTimeSeriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAnomalyGroupTimeSeries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAnomalyGroupTimeSeries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        public void ListMetricSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMetricSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMetricSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMetricSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMetricSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMetricSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutMetrics")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMetricSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMetricSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMetricSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMetricSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMetricSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}