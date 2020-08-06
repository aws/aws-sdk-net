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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */

using Amazon.KeyManagementService;
using Amazon.KeyManagementService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class KeyManagementServicePaginatorTests
    {
        private static Mock<AmazonKeyManagementServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonKeyManagementServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        public void ListAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            secondResponse.Truncated = false;

            _mockClient.SetupSequence(x => x.ListAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAliasesResponse>();
            response.Truncated = false;

            _mockClient.Setup(x => x.ListAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        public void ListGrantsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGrantsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGrantsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGrantsResponse>();
            secondResponse.Truncated = false;

            _mockClient.SetupSequence(x => x.ListGrants(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGrants(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGrantsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGrantsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGrantsResponse>();
            response.Truncated = false;

            _mockClient.Setup(x => x.ListGrants(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGrants(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        public void ListKeyPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListKeyPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListKeyPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListKeyPoliciesResponse>();
            secondResponse.Truncated = false;

            _mockClient.SetupSequence(x => x.ListKeyPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListKeyPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListKeyPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListKeyPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListKeyPoliciesResponse>();
            response.Truncated = false;

            _mockClient.Setup(x => x.ListKeyPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListKeyPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        public void ListKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListKeysResponse>();
            secondResponse.Truncated = false;

            _mockClient.SetupSequence(x => x.ListKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KeyManagementService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListKeysRequest>();

            var response = InstantiateClassGenerator.Execute<ListKeysResponse>();
            response.Truncated = false;

            _mockClient.Setup(x => x.ListKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif