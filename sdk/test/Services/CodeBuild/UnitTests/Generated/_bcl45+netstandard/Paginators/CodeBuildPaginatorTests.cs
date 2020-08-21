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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */

using Amazon.CodeBuild;
using Amazon.CodeBuild.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeBuildPaginatorTests
    {
        private static Mock<AmazonCodeBuildClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeBuildClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void DescribeCodeCoveragesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCodeCoveragesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCodeCoveragesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCodeCoveragesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCodeCoverages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCodeCoverages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCodeCoveragesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCodeCoveragesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCodeCoveragesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCodeCoverages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCodeCoverages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void DescribeTestCasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTestCasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTestCasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTestCasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeTestCases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTestCases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTestCasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTestCasesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTestCasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeTestCases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTestCases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListBuildBatchesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildBatchesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBuildBatchesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBuildBatchesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBuildBatches(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBuildBatches(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBuildBatchesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildBatchesRequest>();

            var response = InstantiateClassGenerator.Execute<ListBuildBatchesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBuildBatches(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBuildBatches(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListBuildBatchesForProjectTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildBatchesForProjectRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBuildBatchesForProjectResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBuildBatchesForProjectResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBuildBatchesForProject(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBuildBatchesForProject(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBuildBatchesForProjectTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildBatchesForProjectRequest>();

            var response = InstantiateClassGenerator.Execute<ListBuildBatchesForProjectResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBuildBatchesForProject(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBuildBatchesForProject(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListBuildsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBuildsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBuildsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBuilds(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBuilds(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBuildsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBuildsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBuilds(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBuilds(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListBuildsForProjectTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildsForProjectRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBuildsForProjectResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBuildsForProjectResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBuildsForProject(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBuildsForProject(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBuildsForProjectTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBuildsForProjectRequest>();

            var response = InstantiateClassGenerator.Execute<ListBuildsForProjectResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBuildsForProject(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBuildsForProject(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListReportGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReportGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReportGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReportGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReportGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReportGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReportGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReportGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListReportGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReportGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReportGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListReportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListReportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListReportsForReportGroupTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListReportsForReportGroupRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListReportsForReportGroupResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListReportsForReportGroupResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListReportsForReportGroup(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListReportsForReportGroup(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListReportsForReportGroupTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListReportsForReportGroupRequest>();

            var response = InstantiateClassGenerator.Execute<ListReportsForReportGroupResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListReportsForReportGroup(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListReportsForReportGroup(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListSharedProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSharedProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSharedProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSharedProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSharedProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSharedProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSharedProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSharedProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSharedProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSharedProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSharedProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        public void ListSharedReportGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSharedReportGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSharedReportGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSharedReportGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSharedReportGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSharedReportGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeBuild")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSharedReportGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSharedReportGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSharedReportGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSharedReportGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSharedReportGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif