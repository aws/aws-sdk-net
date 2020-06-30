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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */

using Amazon.CodeArtifact;
using Amazon.CodeArtifact.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeArtifactPaginatorTests
    {
        private static Mock<AmazonCodeArtifactClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeArtifactClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        public void ListDomainsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDomains(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDomainsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDomainsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDomainsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDomains(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDomains(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        public void ListPackagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPackagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPackagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPackages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPackages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPackagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPackagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPackages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPackages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        public void ListPackageVersionAssetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPackageVersionAssetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPackageVersionAssetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPackageVersionAssetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPackageVersionAssets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPackageVersionAssets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPackageVersionAssetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPackageVersionAssetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPackageVersionAssetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPackageVersionAssets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPackageVersionAssets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        public void ListPackageVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPackageVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPackageVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPackageVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPackageVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPackageVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPackageVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPackageVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPackageVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPackageVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPackageVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        public void ListRepositoriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRepositoriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRepositoriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRepositories(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRepositories(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRepositoriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRepositoriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRepositories(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRepositories(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        public void ListRepositoriesInDomainTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesInDomainRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRepositoriesInDomainResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRepositoriesInDomainResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRepositoriesInDomain(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRepositoriesInDomain(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeArtifact")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRepositoriesInDomainTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositoriesInDomainRequest>();

            var response = InstantiateClassGenerator.Execute<ListRepositoriesInDomainResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRepositoriesInDomain(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRepositoriesInDomain(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif