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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */

using Amazon.ManagedGrafana;
using Amazon.ManagedGrafana.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ManagedGrafanaPaginatorTests
    {
        private static Mock<AmazonManagedGrafanaClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonManagedGrafanaClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedGrafana")]
        public void ListPermissionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPermissions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPermissions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedGrafana")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPermissionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPermissionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPermissionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPermissions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPermissions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedGrafana")]
        public void ListWorkspacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkspacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkspaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkspaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ManagedGrafana")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkspacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkspacesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkspaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkspaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}