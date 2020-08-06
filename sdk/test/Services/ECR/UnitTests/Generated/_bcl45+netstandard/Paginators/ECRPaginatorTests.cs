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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */

using Amazon.ECR;
using Amazon.ECR.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ECRPaginatorTests
    {
        private static Mock<AmazonECRClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonECRClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECR")]
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
        [TestCategory("ECR")]
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
        [TestCategory("ECR")]
        public void DescribeImageScanFindingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImageScanFindingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImageScanFindingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImageScanFindingsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImageScanFindings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImageScanFindings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECR")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImageScanFindingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImageScanFindingsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImageScanFindingsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImageScanFindings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImageScanFindings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECR")]
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
        [TestCategory("ECR")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECR")]
        public void GetLifecyclePolicyPreviewTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetLifecyclePolicyPreviewRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetLifecyclePolicyPreviewResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetLifecyclePolicyPreviewResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetLifecyclePolicyPreview(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetLifecyclePolicyPreview(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECR")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetLifecyclePolicyPreviewTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetLifecyclePolicyPreviewRequest>();

            var response = InstantiateClassGenerator.Execute<GetLifecyclePolicyPreviewResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetLifecyclePolicyPreview(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetLifecyclePolicyPreview(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECR")]
        public void ListImagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ECR")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListImagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif