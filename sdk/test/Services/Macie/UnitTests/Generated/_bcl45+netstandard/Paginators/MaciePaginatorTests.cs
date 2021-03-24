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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */

using Amazon.Macie;
using Amazon.Macie.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MaciePaginatorTests
    {
        private static Mock<AmazonMacieClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMacieClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie")]
        public void ListMemberAccountsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMemberAccountsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMemberAccountsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMemberAccountsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMemberAccounts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMemberAccounts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMemberAccountsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMemberAccountsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMemberAccountsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMemberAccounts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMemberAccounts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie")]
        public void ListS3ResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListS3ResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListS3ResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListS3ResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListS3Resources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListS3Resources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Macie")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListS3ResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListS3ResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListS3ResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListS3Resources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListS3Resources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}