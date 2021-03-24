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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */

using Amazon.WorkSpaces;
using Amazon.WorkSpaces.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class WorkSpacesPaginatorTests
    {
        private static Mock<AmazonWorkSpacesClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonWorkSpacesClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpaces")]
        public void DescribeWorkspaceBundlesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkspaceBundlesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeWorkspaceBundlesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeWorkspaceBundlesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeWorkspaceBundles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeWorkspaceBundles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpaces")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeWorkspaceBundlesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkspaceBundlesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeWorkspaceBundlesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeWorkspaceBundles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeWorkspaceBundles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpaces")]
        public void DescribeWorkspaceDirectoriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkspaceDirectoriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeWorkspaceDirectoriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeWorkspaceDirectoriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeWorkspaceDirectories(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeWorkspaceDirectories(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpaces")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeWorkspaceDirectoriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkspaceDirectoriesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeWorkspaceDirectoriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeWorkspaceDirectories(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeWorkspaceDirectories(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpaces")]
        public void DescribeWorkspacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkspacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeWorkspacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeWorkspacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeWorkspaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeWorkspaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkSpaces")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeWorkspacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeWorkspacesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeWorkspacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeWorkspaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeWorkspaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}