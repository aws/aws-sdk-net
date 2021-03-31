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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */

using Amazon.Pricing;
using Amazon.Pricing.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class PricingPaginatorTests
    {
        private static Mock<AmazonPricingClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonPricingClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Pricing")]
        public void DescribeServicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeServicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeServicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeServicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeServices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeServices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Pricing")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeServicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeServicesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeServicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeServices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeServices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Pricing")]
        public void GetAttributeValuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetAttributeValuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetAttributeValuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetAttributeValuesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetAttributeValues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetAttributeValues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Pricing")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetAttributeValuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetAttributeValuesRequest>();

            var response = InstantiateClassGenerator.Execute<GetAttributeValuesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetAttributeValues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetAttributeValues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Pricing")]
        public void GetProductsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetProductsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetProductsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetProductsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetProducts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetProducts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Pricing")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetProductsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetProductsRequest>();

            var response = InstantiateClassGenerator.Execute<GetProductsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetProducts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetProducts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}