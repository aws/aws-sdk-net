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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */

using Amazon.Kafka;
using Amazon.Kafka.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class KafkaPaginatorTests
    {
        private static Mock<AmazonKafkaClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonKafkaClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        public void ListClusterOperationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClusterOperationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClusterOperationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClusterOperationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListClusterOperations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClusterOperations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClusterOperationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClusterOperationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListClusterOperationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListClusterOperations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClusterOperations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        public void ListClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var response = InstantiateClassGenerator.Execute<ListClustersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        public void ListConfigurationRevisionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationRevisionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConfigurationRevisionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConfigurationRevisionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConfigurationRevisions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConfigurationRevisions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConfigurationRevisionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationRevisionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListConfigurationRevisionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConfigurationRevisions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConfigurationRevisions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        public void ListConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        public void ListKafkaVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListKafkaVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListKafkaVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListKafkaVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListKafkaVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListKafkaVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListKafkaVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListKafkaVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListKafkaVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListKafkaVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListKafkaVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
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
        [TestCategory("Kafka")]
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
        [TestCategory("Kafka")]
        public void ListScramSecretsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListScramSecretsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListScramSecretsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListScramSecretsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListScramSecrets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListScramSecrets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kafka")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListScramSecretsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListScramSecretsRequest>();

            var response = InstantiateClassGenerator.Execute<ListScramSecretsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListScramSecrets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListScramSecrets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif