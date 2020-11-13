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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */

using Amazon.Shield;
using Amazon.Shield.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ShieldPaginatorTests
    {
        private static Mock<AmazonShieldClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonShieldClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        public void ListAttacksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttacksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttacksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttacksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAttacks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttacks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttacksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttacksRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttacksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAttacks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttacks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        public void ListProtectionGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProtectionGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProtectionGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProtectionGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProtectionGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProtectionGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProtectionGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProtectionGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProtectionGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProtectionGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProtectionGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        public void ListProtectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProtectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProtectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProtectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProtections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProtections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProtectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProtectionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProtectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProtections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProtections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        public void ListResourcesInProtectionGroupTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesInProtectionGroupRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesInProtectionGroupResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesInProtectionGroupResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourcesInProtectionGroup(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourcesInProtectionGroup(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Shield")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesInProtectionGroupTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesInProtectionGroupRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesInProtectionGroupResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourcesInProtectionGroup(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourcesInProtectionGroup(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif