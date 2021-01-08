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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */

using Amazon.GreengrassV2;
using Amazon.GreengrassV2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GreengrassV2PaginatorTests
    {
        private static Mock<AmazonGreengrassV2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGreengrassV2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
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
        [TestCategory("GreengrassV2")]
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
        [TestCategory("GreengrassV2")]
        public void ListComponentVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListComponentVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListComponentVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListComponentVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListComponentVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListComponentVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListComponentVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListComponentVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListComponentVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListComponentVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        public void ListCoreDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCoreDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCoreDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCoreDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCoreDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCoreDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCoreDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCoreDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListCoreDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCoreDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCoreDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        public void ListDeploymentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeploymentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeploymentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeployments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeployments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeploymentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeploymentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeploymentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeployments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeployments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        public void ListEffectiveDeploymentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEffectiveDeploymentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEffectiveDeploymentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEffectiveDeploymentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEffectiveDeployments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEffectiveDeployments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEffectiveDeploymentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEffectiveDeploymentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEffectiveDeploymentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEffectiveDeployments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEffectiveDeployments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        public void ListInstalledComponentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstalledComponentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstalledComponentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstalledComponentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListInstalledComponents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstalledComponents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("GreengrassV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstalledComponentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstalledComponentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstalledComponentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListInstalledComponents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstalledComponents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif