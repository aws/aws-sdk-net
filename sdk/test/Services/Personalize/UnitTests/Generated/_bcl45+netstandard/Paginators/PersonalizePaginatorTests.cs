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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */

using Amazon.Personalize;
using Amazon.Personalize.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class PersonalizePaginatorTests
    {
        private static Mock<AmazonPersonalizeClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonPersonalizeClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        public void ListBatchInferenceJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBatchInferenceJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBatchInferenceJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBatchInferenceJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBatchInferenceJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBatchInferenceJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBatchInferenceJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBatchInferenceJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBatchInferenceJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBatchInferenceJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBatchInferenceJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        public void ListCampaignsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCampaignsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCampaignsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCampaignsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCampaigns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCampaigns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCampaignsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCampaignsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCampaignsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCampaigns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCampaigns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        public void ListDatasetGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasetGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasetGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasetGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasetGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        public void ListDatasetImportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetImportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetImportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetImportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasetImportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasetImportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetImportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetImportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetImportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasetImportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasetImportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
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
        [TestCategory("Personalize")]
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
        [TestCategory("Personalize")]
        public void ListEventTrackersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEventTrackersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEventTrackersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEventTrackersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEventTrackers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEventTrackers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEventTrackersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEventTrackersRequest>();

            var response = InstantiateClassGenerator.Execute<ListEventTrackersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEventTrackers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEventTrackers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
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
        [TestCategory("Personalize")]
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
        [TestCategory("Personalize")]
        public void ListSchemasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSchemas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSchemas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSchemasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemasRequest>();

            var response = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSchemas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSchemas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        public void ListSolutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSolutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSolutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSolutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSolutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSolutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSolutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSolutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSolutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSolutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSolutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        public void ListSolutionVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSolutionVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSolutionVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSolutionVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSolutionVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSolutionVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Personalize")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSolutionVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSolutionVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSolutionVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSolutionVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSolutionVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif