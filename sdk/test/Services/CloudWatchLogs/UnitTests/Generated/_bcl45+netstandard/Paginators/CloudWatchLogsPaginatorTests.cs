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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */

using Amazon.CloudWatchLogs;
using Amazon.CloudWatchLogs.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudWatchLogsPaginatorTests
    {
        private static Mock<AmazonCloudWatchLogsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudWatchLogsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        public void DescribeDestinationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDestinationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDestinationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDestinationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeDestinations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDestinations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDestinationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDestinationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDestinationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeDestinations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDestinations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        public void DescribeLogGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLogGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLogGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLogGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLogGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLogGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLogGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLogGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLogGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLogGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLogGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        public void DescribeLogStreamsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLogStreamsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeLogStreamsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeLogStreamsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeLogStreams(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeLogStreams(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeLogStreamsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeLogStreamsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeLogStreamsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeLogStreams(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeLogStreams(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        public void DescribeMetricFiltersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMetricFiltersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMetricFiltersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMetricFiltersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMetricFilters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMetricFilters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMetricFiltersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMetricFiltersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMetricFiltersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMetricFilters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMetricFilters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        public void DescribeSubscriptionFiltersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSubscriptionFiltersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSubscriptionFiltersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSubscriptionFiltersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSubscriptionFilters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSubscriptionFilters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSubscriptionFiltersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSubscriptionFiltersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSubscriptionFiltersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSubscriptionFilters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSubscriptionFilters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        public void FilterLogEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<FilterLogEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<FilterLogEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<FilterLogEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.FilterLogEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.FilterLogEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void FilterLogEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<FilterLogEventsRequest>();

            var response = InstantiateClassGenerator.Execute<FilterLogEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.FilterLogEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.FilterLogEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        public void GetLogEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetLogEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetLogEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetLogEventsResponse>();
            secondResponse.NextForwardToken = null;

            _mockClient.SetupSequence(x => x.GetLogEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetLogEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudWatchLogs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetLogEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetLogEventsRequest>();

            var response = InstantiateClassGenerator.Execute<GetLogEventsResponse>();
            response.NextForwardToken = null;

            _mockClient.Setup(x => x.GetLogEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetLogEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}