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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */

using Amazon.ForecastService;
using Amazon.ForecastService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ForecastServicePaginatorTests
    {
        private static Mock<AmazonForecastServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonForecastServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
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
        [TestCategory("ForecastService")]
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
        [TestCategory("ForecastService")]
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
        [TestCategory("ForecastService")]
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
        [TestCategory("ForecastService")]
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
        [TestCategory("ForecastService")]
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
        [TestCategory("ForecastService")]
        public void ListForecastExportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListForecastExportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListForecastExportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListForecastExportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListForecastExportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListForecastExportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListForecastExportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListForecastExportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListForecastExportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListForecastExportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListForecastExportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
        public void ListForecastsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListForecastsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListForecastsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListForecastsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListForecasts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListForecasts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListForecastsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListForecastsRequest>();

            var response = InstantiateClassGenerator.Execute<ListForecastsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListForecasts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListForecasts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
        public void ListPredictorBacktestExportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPredictorBacktestExportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPredictorBacktestExportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPredictorBacktestExportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPredictorBacktestExportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPredictorBacktestExportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPredictorBacktestExportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPredictorBacktestExportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPredictorBacktestExportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPredictorBacktestExportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPredictorBacktestExportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
        public void ListPredictorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPredictorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPredictorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPredictorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPredictors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPredictors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ForecastService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPredictorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPredictorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPredictorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPredictors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPredictors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif