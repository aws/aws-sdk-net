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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */

using Amazon.BackupGateway;
using Amazon.BackupGateway.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class BackupGatewayPaginatorTests
    {
        private static Mock<AmazonBackupGatewayClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonBackupGatewayClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BackupGateway")]
        public void ListGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BackupGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<ListGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BackupGateway")]
        public void ListHypervisorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListHypervisorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListHypervisorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListHypervisorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListHypervisors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListHypervisors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BackupGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListHypervisorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListHypervisorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListHypervisorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListHypervisors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListHypervisors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BackupGateway")]
        public void ListVirtualMachinesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualMachinesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVirtualMachinesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVirtualMachinesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVirtualMachines(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVirtualMachines(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("BackupGateway")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVirtualMachinesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVirtualMachinesRequest>();

            var response = InstantiateClassGenerator.Execute<ListVirtualMachinesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVirtualMachines(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVirtualMachines(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}