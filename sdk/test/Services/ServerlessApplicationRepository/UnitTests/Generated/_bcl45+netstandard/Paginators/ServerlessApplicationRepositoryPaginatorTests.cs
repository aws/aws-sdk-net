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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */

using Amazon.ServerlessApplicationRepository;
using Amazon.ServerlessApplicationRepository.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ServerlessApplicationRepositoryPaginatorTests
    {
        private static Mock<AmazonServerlessApplicationRepositoryClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonServerlessApplicationRepositoryClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerlessApplicationRepository")]
        public void ListApplicationDependenciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationDependenciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationDependenciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationDependenciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationDependencies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationDependencies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerlessApplicationRepository")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationDependenciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationDependenciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationDependenciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationDependencies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationDependencies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerlessApplicationRepository")]
        public void ListApplicationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplications(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerlessApplicationRepository")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplications(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplications(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerlessApplicationRepository")]
        public void ListApplicationVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerlessApplicationRepository")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif