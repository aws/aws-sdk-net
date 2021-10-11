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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */

using Amazon.FraudDetector;
using Amazon.FraudDetector.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class FraudDetectorPaginatorTests
    {
        private static Mock<AmazonFraudDetectorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonFraudDetectorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void DescribeModelVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeModelVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeModelVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeModelVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeModelVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeModelVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeModelVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeModelVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeModelVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeModelVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeModelVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetBatchImportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBatchImportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBatchImportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBatchImportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBatchImportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBatchImportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBatchImportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBatchImportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<GetBatchImportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBatchImportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBatchImportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetBatchPredictionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBatchPredictionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBatchPredictionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBatchPredictionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBatchPredictionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBatchPredictionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBatchPredictionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBatchPredictionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<GetBatchPredictionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBatchPredictionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBatchPredictionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetDetectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDetectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDetectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDetectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDetectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDetectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDetectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDetectorsRequest>();

            var response = InstantiateClassGenerator.Execute<GetDetectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDetectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDetectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetEntityTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEntityTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEntityTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEntityTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEntityTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEntityTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEntityTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEntityTypesRequest>();

            var response = InstantiateClassGenerator.Execute<GetEntityTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEntityTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEntityTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetEventTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetEventTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetEventTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetEventTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetEventTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetEventTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetEventTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetEventTypesRequest>();

            var response = InstantiateClassGenerator.Execute<GetEventTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetEventTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetEventTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetExternalModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetExternalModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetExternalModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetExternalModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetExternalModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetExternalModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetExternalModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetExternalModelsRequest>();

            var response = InstantiateClassGenerator.Execute<GetExternalModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetExternalModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetExternalModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetLabelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetLabelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetLabelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetLabelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetLabels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetLabels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetLabelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetLabelsRequest>();

            var response = InstantiateClassGenerator.Execute<GetLabelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetLabels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetLabels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetModelsRequest>();

            var response = InstantiateClassGenerator.Execute<GetModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetOutcomesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetOutcomesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetOutcomesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetOutcomesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetOutcomes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetOutcomes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetOutcomesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetOutcomesRequest>();

            var response = InstantiateClassGenerator.Execute<GetOutcomesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetOutcomes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetOutcomes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetRulesRequest>();

            var response = InstantiateClassGenerator.Execute<GetRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void GetVariablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetVariablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetVariablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetVariablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetVariables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetVariables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetVariablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetVariablesRequest>();

            var response = InstantiateClassGenerator.Execute<GetVariablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetVariables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetVariables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FraudDetector")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}