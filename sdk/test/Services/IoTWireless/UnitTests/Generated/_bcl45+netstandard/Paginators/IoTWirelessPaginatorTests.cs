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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */

using Amazon.IoTWireless;
using Amazon.IoTWireless.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IoTWirelessPaginatorTests
    {
        private static Mock<AmazonIoTWirelessClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIoTWirelessClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        public void ListDestinationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDestinationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDestinationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDestinationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDestinations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDestinations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDestinationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDestinationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDestinationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDestinations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDestinations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        public void ListDeviceProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDeviceProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDeviceProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDeviceProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDeviceProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDeviceProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDeviceProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDeviceProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDeviceProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDeviceProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDeviceProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        public void ListServiceProfilesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceProfilesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServiceProfilesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServiceProfilesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServiceProfiles(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServiceProfiles(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServiceProfilesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServiceProfilesRequest>();

            var response = InstantiateClassGenerator.Execute<ListServiceProfilesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServiceProfiles(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServiceProfiles(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        public void ListWirelessDevicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWirelessDevicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWirelessDevicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWirelessDevicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWirelessDevices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWirelessDevices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWirelessDevicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWirelessDevicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWirelessDevicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWirelessDevices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWirelessDevices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        public void ListWirelessGatewaysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWirelessGatewaysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWirelessGatewaysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWirelessGatewaysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWirelessGateways(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWirelessGateways(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IoTWireless")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWirelessGatewaysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWirelessGatewaysRequest>();

            var response = InstantiateClassGenerator.Execute<ListWirelessGatewaysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWirelessGateways(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWirelessGateways(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif