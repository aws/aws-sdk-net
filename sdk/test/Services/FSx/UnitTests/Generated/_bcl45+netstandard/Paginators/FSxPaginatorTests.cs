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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */

using Amazon.FSx;
using Amazon.FSx.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class FSxPaginatorTests
    {
        private static Mock<AmazonFSxClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonFSxClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        public void DescribeBackupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBackupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeBackupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeBackupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeBackups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeBackups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeBackupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBackupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeBackupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeBackups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeBackups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        public void DescribeDataRepositoryTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDataRepositoryTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeDataRepositoryTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeDataRepositoryTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeDataRepositoryTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeDataRepositoryTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeDataRepositoryTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeDataRepositoryTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeDataRepositoryTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeDataRepositoryTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeDataRepositoryTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        public void DescribeFileSystemAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFileSystemAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFileSystemAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFileSystemAliasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFileSystemAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFileSystemAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFileSystemAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFileSystemAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFileSystemAliasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFileSystemAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFileSystemAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        public void DescribeFileSystemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFileSystemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFileSystemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFileSystemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeFileSystems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFileSystems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("FSx")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFileSystemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFileSystemsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFileSystemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeFileSystems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFileSystems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif