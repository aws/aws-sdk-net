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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */

using Amazon.AWSSupport;
using Amazon.AWSSupport.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class AWSSupportPaginatorTests
    {
        private static Mock<AmazonAWSSupportClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonAWSSupportClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSSupport")]
        public void DescribeCasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSSupport")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCasesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSSupport")]
        public void DescribeCommunicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCommunicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeCommunicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeCommunicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeCommunications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeCommunications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("AWSSupport")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeCommunicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeCommunicationsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeCommunicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeCommunications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeCommunications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}