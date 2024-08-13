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
 * Do not modify this file. This file is generated from the paginators-test-2022-03-14.normal.json service model.
 */

using Amazon.PaginatorsTest;
using Amazon.PaginatorsTest.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests.PaginatorTests
{
    [TestClass]
    public class PaginatorsTestPaginatorTests
    {
        private static Mock<AmazonPaginatorsTestClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonPaginatorsTestClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PaginatorsTest")]
        public void TestPaginatorTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<TestPaginatorRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<TestPaginatorResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<TestPaginatorResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.TestPaginator(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.TestPaginator(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PaginatorsTest")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void TestPaginatorTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<TestPaginatorRequest>();

            var response = InstantiateClassGenerator.Execute<TestPaginatorResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.TestPaginator(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.TestPaginator(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}