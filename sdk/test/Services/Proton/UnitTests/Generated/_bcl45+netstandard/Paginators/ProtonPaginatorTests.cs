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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */

using Amazon.Proton;
using Amazon.Proton.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ProtonPaginatorTests
    {
        private static Mock<AmazonProtonClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonProtonClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListEnvironmentAccountConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentAccountConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentAccountConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentAccountConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironmentAccountConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentAccountConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentAccountConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentAccountConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentAccountConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironmentAccountConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentAccountConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListEnvironmentOutputsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentOutputsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentOutputsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentOutputsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironmentOutputs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentOutputs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentOutputsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentOutputsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentOutputsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironmentOutputs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentOutputs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListEnvironmentProvisionedResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentProvisionedResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentProvisionedResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentProvisionedResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironmentProvisionedResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentProvisionedResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentProvisionedResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentProvisionedResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentProvisionedResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironmentProvisionedResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentProvisionedResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListEnvironmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListEnvironmentTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironmentTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironmentTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListEnvironmentTemplateVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentTemplateVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEnvironmentTemplateVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEnvironmentTemplateVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEnvironmentTemplateVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentTemplateVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEnvironmentTemplateVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEnvironmentTemplateVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEnvironmentTemplateVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEnvironmentTemplateVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEnvironmentTemplateVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
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
        [TestCategory("Proton")]
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
        [TestCategory("Proton")]
        public void ListRepositorySyncDefinitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositorySyncDefinitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRepositorySyncDefinitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRepositorySyncDefinitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRepositorySyncDefinitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRepositorySyncDefinitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRepositorySyncDefinitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRepositorySyncDefinitionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRepositorySyncDefinitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRepositorySyncDefinitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRepositorySyncDefinitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServiceInstanceOutputsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceInstanceOutputsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceInstanceOutputsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceInstanceOutputsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceInstanceOutputs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceInstanceOutputs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceInstanceOutputsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceInstanceOutputsRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceInstanceOutputsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceInstanceOutputs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceInstanceOutputs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServiceInstanceProvisionedResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceInstanceProvisionedResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceInstanceProvisionedResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceInstanceProvisionedResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceInstanceProvisionedResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceInstanceProvisionedResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceInstanceProvisionedResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceInstanceProvisionedResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceInstanceProvisionedResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceInstanceProvisionedResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceInstanceProvisionedResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServiceInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServicePipelineOutputsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServicePipelineOutputsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServicePipelineOutputsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServicePipelineOutputsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServicePipelineOutputs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServicePipelineOutputs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServicePipelineOutputsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServicePipelineOutputsRequest>();

            var response = InstantiateClassGenerator.Execute<ListServicePipelineOutputsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServicePipelineOutputs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServicePipelineOutputs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServicePipelineProvisionedResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServicePipelineProvisionedResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServicePipelineProvisionedResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServicePipelineProvisionedResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServicePipelineProvisionedResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServicePipelineProvisionedResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServicePipelineProvisionedResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServicePipelineProvisionedResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServicePipelineProvisionedResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServicePipelineProvisionedResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServicePipelineProvisionedResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServiceTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListServiceTemplateVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceTemplateVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceTemplateVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceTemplateVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceTemplateVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceTemplateVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceTemplateVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceTemplateVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceTemplateVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceTemplateVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceTemplateVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Proton")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}