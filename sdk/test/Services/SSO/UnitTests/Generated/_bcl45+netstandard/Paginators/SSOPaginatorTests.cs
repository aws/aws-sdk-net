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
 * Do not modify this file. This file is generated from the sso-2019-06-10.normal.json service model.
 */

using Amazon.SSO;
using Amazon.SSO.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class SSOPaginatorTests
    {
        private static Mock<AmazonSSOClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonSSOClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSO")]
        public void ListAccountRolesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountRolesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountRolesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountRolesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccountRoles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccountRoles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSO")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountRolesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountRolesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountRolesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccountRoles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccountRoles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSO")]
        public void ListAccountsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAccountsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAccountsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAccounts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAccounts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SSO")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAccountsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAccountsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAccountsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAccounts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAccounts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif