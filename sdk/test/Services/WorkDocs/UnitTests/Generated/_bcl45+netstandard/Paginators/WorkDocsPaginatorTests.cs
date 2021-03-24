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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */

using Amazon.WorkDocs;
using Amazon.WorkDocs.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class WorkDocsPaginatorTests
    {
        private static Mock<AmazonWorkDocsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonWorkDocsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkDocs")]
        public void DescribeDocumentVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDocumentVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDocumentVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDocumentVersionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeDocumentVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDocumentVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkDocs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDocumentVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDocumentVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDocumentVersionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeDocumentVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDocumentVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkDocs")]
        public void DescribeFolderContentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFolderContentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFolderContentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFolderContentsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeFolderContents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFolderContents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkDocs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFolderContentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFolderContentsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFolderContentsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeFolderContents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFolderContents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkDocs")]
        public void DescribeUsersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUsersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeUsersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeUsersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.DescribeUsers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeUsers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("WorkDocs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeUsersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeUsersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeUsersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.DescribeUsers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeUsers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}