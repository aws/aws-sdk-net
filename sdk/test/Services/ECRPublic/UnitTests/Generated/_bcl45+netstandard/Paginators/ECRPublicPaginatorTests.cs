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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */

using Amazon.ECRPublic;
using Amazon.ECRPublic.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ECRPublicPaginatorTests
    {
        private static Mock<AmazonECRPublicClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonECRPublicClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        public void DescribeImagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImagesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        public void DescribeImageTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImageTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImageTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImageTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImageTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImageTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImageTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImageTagsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImageTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImageTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImageTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        public void DescribeRegistriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRegistriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRegistriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRegistriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRegistries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRegistries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRegistriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRegistriesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRegistriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRegistries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRegistries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        public void DescribeRepositoriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRepositoriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRepositoriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRepositoriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRepositories(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRepositories(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECRPublic")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRepositoriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRepositoriesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRepositoriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRepositories(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRepositories(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif