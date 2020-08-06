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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */

using Amazon.CodeGuruProfiler;
using Amazon.CodeGuruProfiler.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeGuruProfilerPaginatorTests
    {
        private static Mock<AmazonCodeGuruProfilerClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeGuruProfilerClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        public void GetFindingsReportAccountSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetFindingsReportAccountSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetFindingsReportAccountSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetFindingsReportAccountSummaryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetFindingsReportAccountSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetFindingsReportAccountSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetFindingsReportAccountSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetFindingsReportAccountSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetFindingsReportAccountSummaryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetFindingsReportAccountSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetFindingsReportAccountSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        public void ListFindingsReportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsReportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFindingsReportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFindingsReportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFindingsReports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFindingsReports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFindingsReportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFindingsReportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListFindingsReportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFindingsReports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFindingsReports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        public void ListProfileTimesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProfileTimesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProfileTimesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProfileTimesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProfileTimes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProfileTimes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProfileTimesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProfileTimesRequest>();

            var response = InstantiateClassGenerator.Execute<ListProfileTimesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProfileTimes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProfileTimes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        public void ListProfilingGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProfilingGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProfilingGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProfilingGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProfilingGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProfilingGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeGuruProfiler")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProfilingGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProfilingGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProfilingGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProfilingGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProfilingGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif