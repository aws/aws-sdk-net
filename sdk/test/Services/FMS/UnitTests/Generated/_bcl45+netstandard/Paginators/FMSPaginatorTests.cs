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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */

using Amazon.FMS;
using Amazon.FMS.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class FMSPaginatorTests
    {
        private static Mock<AmazonFMSClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonFMSClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FMS")]
        public void ListComplianceStatusTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComplianceStatusRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComplianceStatusResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComplianceStatusResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComplianceStatus(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComplianceStatus(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FMS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComplianceStatusTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComplianceStatusRequest>();

            var response = InstantiateClassGenerator.Execute<ListComplianceStatusResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComplianceStatus(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComplianceStatus(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FMS")]
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
        [TestCategory("FMS")]
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
        [TestCategory("FMS")]
        public void ListPoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FMS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif