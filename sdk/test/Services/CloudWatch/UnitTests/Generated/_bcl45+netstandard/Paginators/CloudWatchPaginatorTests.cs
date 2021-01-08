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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */

using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudWatchPaginatorTests
    {
        private static Mock<AmazonCloudWatchClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudWatchClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        public void DescribeAlarmHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAlarmHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAlarmHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAlarmHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAlarmHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAlarmHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAlarmHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAlarmHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAlarmHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAlarmHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAlarmHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        public void DescribeAlarmsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAlarmsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAlarmsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAlarmsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAlarms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAlarms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAlarmsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAlarmsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAlarmsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAlarms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAlarms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        public void DescribeInsightRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInsightRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeInsightRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeInsightRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeInsightRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeInsightRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeInsightRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeInsightRulesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeInsightRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeInsightRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeInsightRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
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
        [TestCategory("CloudWatch")]
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
        [TestCategory("CloudWatch")]
        public void ListDashboardsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDashboards(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDashboards(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDashboardsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDashboardsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDashboardsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDashboards(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDashboards(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        public void ListMetricsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMetricsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMetricsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMetricsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMetrics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMetrics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatch")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMetricsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMetricsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMetricsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMetrics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMetrics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif