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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */

using Amazon.KafkaConnect;
using Amazon.KafkaConnect.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class KafkaConnectPaginatorTests
    {
        private static Mock<AmazonKafkaConnectClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonKafkaConnectClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KafkaConnect")]
        public void ListConnectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConnectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConnectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConnectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConnectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConnectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KafkaConnect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConnectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConnectorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListConnectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConnectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConnectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KafkaConnect")]
        public void ListCustomPluginsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomPluginsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCustomPluginsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCustomPluginsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCustomPlugins(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCustomPlugins(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KafkaConnect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCustomPluginsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCustomPluginsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCustomPluginsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCustomPlugins(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCustomPlugins(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KafkaConnect")]
        public void ListWorkerConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkerConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkerConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkerConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkerConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkerConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KafkaConnect")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkerConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkerConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkerConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkerConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkerConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}