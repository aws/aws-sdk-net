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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */

using Amazon.Panorama;
using Amazon.Panorama.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class PanoramaPaginatorTests
    {
        private static Mock<AmazonPanoramaClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonPanoramaClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListApplicationInstanceDependenciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationInstanceDependenciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationInstanceDependenciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationInstanceDependenciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationInstanceDependencies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationInstanceDependencies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationInstanceDependenciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationInstanceDependenciesRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationInstanceDependenciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationInstanceDependencies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationInstanceDependencies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListApplicationInstanceNodeInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationInstanceNodeInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationInstanceNodeInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationInstanceNodeInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationInstanceNodeInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationInstanceNodeInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationInstanceNodeInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationInstanceNodeInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationInstanceNodeInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationInstanceNodeInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationInstanceNodeInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListApplicationInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListDevicesJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevicesJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevicesJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevicesJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevicesJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevicesJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevicesJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevicesJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevicesJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevicesJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListNodeFromTemplateJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNodeFromTemplateJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNodeFromTemplateJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNodeFromTemplateJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNodeFromTemplateJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNodeFromTemplateJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNodeFromTemplateJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNodeFromTemplateJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListNodeFromTemplateJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNodeFromTemplateJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNodeFromTemplateJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListNodesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNodesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNodesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNodesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNodes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNodes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNodesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNodesRequest>();

            var response = InstantiateClassGenerator.Execute<ListNodesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNodes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNodes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        public void ListPackageImportJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPackageImportJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPackageImportJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPackageImportJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPackageImportJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPackageImportJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPackageImportJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPackageImportJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPackageImportJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPackageImportJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPackageImportJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Panorama")]
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
        [TestCategory("Panorama")]
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

    }
}