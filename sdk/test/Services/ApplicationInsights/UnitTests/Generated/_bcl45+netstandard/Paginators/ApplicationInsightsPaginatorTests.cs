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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */

using Amazon.ApplicationInsights;
using Amazon.ApplicationInsights.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ApplicationInsightsPaginatorTests
    {
        private static Mock<AmazonApplicationInsightsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonApplicationInsightsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        public void ListApplicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        public void ListComponentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComponents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComponents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComponentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComponents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComponents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        public void ListConfigurationHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConfigurationHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConfigurationHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConfigurationHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConfigurationHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConfigurationHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<ListConfigurationHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConfigurationHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConfigurationHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        public void ListLogPatternsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLogPatternsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLogPatternsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLogPatternsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLogPatterns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLogPatterns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLogPatternsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLogPatternsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLogPatternsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLogPatterns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLogPatterns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        public void ListLogPatternSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLogPatternSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLogPatternSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLogPatternSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLogPatternSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLogPatternSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLogPatternSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLogPatternSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLogPatternSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLogPatternSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLogPatternSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        public void ListProblemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProblemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProblemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProblemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProblems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProblems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationInsights")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProblemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProblemsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProblemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProblems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProblems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif