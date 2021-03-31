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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */

using Amazon.MachineLearning;
using Amazon.MachineLearning.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MachineLearningPaginatorTests
    {
        private static Mock<AmazonMachineLearningClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMachineLearningClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        public void DescribeBatchPredictionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBatchPredictionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeBatchPredictionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeBatchPredictionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeBatchPredictions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeBatchPredictions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeBatchPredictionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBatchPredictionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeBatchPredictionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeBatchPredictions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeBatchPredictions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        public void DescribeDataSourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDataSourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDataSourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDataSourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeDataSources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDataSources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDataSourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDataSourcesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDataSourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeDataSources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDataSources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        public void DescribeEvaluationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEvaluationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEvaluationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEvaluationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEvaluations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEvaluations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEvaluationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEvaluationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEvaluationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEvaluations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEvaluations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        public void DescribeMLModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMLModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeMLModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeMLModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeMLModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeMLModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MachineLearning")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeMLModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeMLModelsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeMLModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeMLModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeMLModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}