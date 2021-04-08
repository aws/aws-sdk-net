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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */

using Amazon.LookoutEquipment;
using Amazon.LookoutEquipment.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LookoutEquipmentPaginatorTests
    {
        private static Mock<AmazonLookoutEquipmentClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLookoutEquipmentClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
        public void ListDataIngestionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataIngestionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataIngestionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataIngestionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataIngestionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataIngestionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataIngestionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataIngestionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataIngestionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataIngestionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataIngestionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
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
        [TestCategory("LookoutEquipment")]
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
        [TestCategory("LookoutEquipment")]
        public void ListInferenceExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInferenceExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInferenceExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInferenceExecutionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInferenceExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInferenceExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInferenceExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInferenceExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInferenceExecutionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInferenceExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInferenceExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
        public void ListInferenceSchedulersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInferenceSchedulersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInferenceSchedulersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInferenceSchedulersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInferenceSchedulers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInferenceSchedulers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInferenceSchedulersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInferenceSchedulersRequest>();

            var response = InstantiateClassGenerator.Execute<ListInferenceSchedulersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInferenceSchedulers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInferenceSchedulers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
        public void ListModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutEquipment")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListModelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}