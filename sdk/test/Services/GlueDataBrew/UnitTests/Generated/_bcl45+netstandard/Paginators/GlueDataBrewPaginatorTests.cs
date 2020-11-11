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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */

using Amazon.GlueDataBrew;
using Amazon.GlueDataBrew.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GlueDataBrewPaginatorTests
    {
        private static Mock<AmazonGlueDataBrewClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGlueDataBrewClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        public void ListDatasetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        public void ListJobRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobRunsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        public void ListJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
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
        [TestCategory("GlueDataBrew")]
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
        [TestCategory("GlueDataBrew")]
        public void ListRecipesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecipesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecipesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecipesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecipes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecipes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecipesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecipesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecipesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecipes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecipes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        public void ListRecipeVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecipeVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecipeVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecipeVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecipeVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecipeVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecipeVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecipeVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecipeVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecipeVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecipeVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        public void ListSchedulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSchedulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSchedulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSchedulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSchedules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSchedules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GlueDataBrew")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSchedulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSchedulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSchedulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSchedules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSchedules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif