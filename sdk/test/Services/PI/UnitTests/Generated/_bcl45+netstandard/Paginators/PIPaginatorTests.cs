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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */

using Amazon.PI;
using Amazon.PI.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class PIPaginatorTests
    {
        private static Mock<AmazonPIClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonPIClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        public void DescribeDimensionKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDimensionKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDimensionKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDimensionKeysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeDimensionKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDimensionKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDimensionKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDimensionKeysRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDimensionKeysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeDimensionKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDimensionKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        public void GetResourceMetricsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceMetricsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourceMetricsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourceMetricsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourceMetrics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourceMetrics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourceMetricsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourceMetricsRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourceMetricsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourceMetrics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourceMetrics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        public void ListAvailableResourceDimensionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAvailableResourceDimensionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAvailableResourceDimensionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAvailableResourceDimensionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAvailableResourceDimensions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAvailableResourceDimensions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAvailableResourceDimensionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAvailableResourceDimensionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAvailableResourceDimensionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAvailableResourceDimensions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAvailableResourceDimensions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        public void ListAvailableResourceMetricsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAvailableResourceMetricsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAvailableResourceMetricsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAvailableResourceMetricsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAvailableResourceMetrics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAvailableResourceMetrics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAvailableResourceMetricsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAvailableResourceMetricsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAvailableResourceMetricsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAvailableResourceMetrics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAvailableResourceMetrics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}