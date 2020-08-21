#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */

using Amazon.IdentityStore;
using Amazon.IdentityStore.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IdentityStorePaginatorTests
    {
        private static Mock<AmazonIdentityStoreClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIdentityStoreClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityStore")]
        public void ListGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityStore")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityStore")]
        public void ListUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListUsersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IdentityStore")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListUsersRequest>();

            var response = InstantiateClassGenerator.Execute<ListUsersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif