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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */

using Amazon.Imagebuilder;
using Amazon.Imagebuilder.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ImagebuilderPaginatorTests
    {
        private static Mock<AmazonImagebuilderClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonImagebuilderClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListComponentBuildVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentBuildVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComponentBuildVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComponentBuildVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComponentBuildVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComponentBuildVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComponentBuildVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentBuildVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListComponentBuildVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComponentBuildVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComponentBuildVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListComponentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComponents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComponents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComponentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListComponentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComponents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComponents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListContainerRecipesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContainerRecipesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContainerRecipesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContainerRecipesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContainerRecipes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContainerRecipes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContainerRecipesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContainerRecipesRequest>();

            var response = InstantiateClassGenerator.Execute<ListContainerRecipesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContainerRecipes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContainerRecipes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListDistributionConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDistributionConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDistributionConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDistributionConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDistributionConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDistributionConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDistributionConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDistributionConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDistributionConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDistributionConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDistributionConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListImageBuildVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImageBuildVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImageBuildVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImageBuildVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImageBuildVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImageBuildVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImageBuildVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImageBuildVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListImageBuildVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImageBuildVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImageBuildVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListImagePipelineImagesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImagePipelineImagesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImagePipelineImagesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImagePipelineImagesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImagePipelineImages(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImagePipelineImages(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImagePipelineImagesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImagePipelineImagesRequest>();

            var response = InstantiateClassGenerator.Execute<ListImagePipelineImagesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImagePipelineImages(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImagePipelineImages(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListImagePipelinesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImagePipelinesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImagePipelinesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImagePipelinesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImagePipelines(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImagePipelines(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImagePipelinesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImagePipelinesRequest>();

            var response = InstantiateClassGenerator.Execute<ListImagePipelinesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImagePipelines(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImagePipelines(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListImageRecipesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImageRecipesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImageRecipesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImageRecipesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImageRecipes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImageRecipes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImageRecipesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImageRecipesRequest>();

            var response = InstantiateClassGenerator.Execute<ListImageRecipesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImageRecipes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImageRecipes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
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
        [TestCategory("Imagebuilder")]
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


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        public void ListInfrastructureConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInfrastructureConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInfrastructureConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInfrastructureConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInfrastructureConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInfrastructureConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Imagebuilder")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInfrastructureConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInfrastructureConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInfrastructureConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInfrastructureConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInfrastructureConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif