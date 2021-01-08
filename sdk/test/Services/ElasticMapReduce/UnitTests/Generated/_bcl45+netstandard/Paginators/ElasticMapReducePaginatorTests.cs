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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */

using Amazon.ElasticMapReduce;
using Amazon.ElasticMapReduce.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ElasticMapReducePaginatorTests
    {
        private static Mock<AmazonElasticMapReduceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonElasticMapReduceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListBootstrapActionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBootstrapActionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBootstrapActionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBootstrapActionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListBootstrapActions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBootstrapActions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBootstrapActionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBootstrapActionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBootstrapActionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListBootstrapActions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBootstrapActions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListClustersResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListClustersRequest>();

            var response = InstantiateClassGenerator.Execute<ListClustersResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListInstanceFleetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceFleetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstanceFleetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstanceFleetsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListInstanceFleets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstanceFleets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstanceFleetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceFleetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstanceFleetsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListInstanceFleets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstanceFleets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListInstanceGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstanceGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstanceGroupsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListInstanceGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstanceGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstanceGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstanceGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstanceGroupsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListInstanceGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstanceGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListInstancesResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListNotebookExecutionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNotebookExecutionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNotebookExecutionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNotebookExecutionsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListNotebookExecutions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNotebookExecutions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNotebookExecutionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNotebookExecutionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListNotebookExecutionsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListNotebookExecutions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNotebookExecutions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListSecurityConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSecurityConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSecurityConfigurationsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListSecurityConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSecurityConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSecurityConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSecurityConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSecurityConfigurationsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListSecurityConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSecurityConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListStepsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStepsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStepsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStepsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListSteps(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSteps(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStepsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStepsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStepsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListSteps(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSteps(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListStudiosTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStudiosRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStudiosResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStudiosResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListStudios(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStudios(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStudiosTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStudiosRequest>();

            var response = InstantiateClassGenerator.Execute<ListStudiosResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListStudios(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStudios(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        public void ListStudioSessionMappingsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStudioSessionMappingsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStudioSessionMappingsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStudioSessionMappingsResponse>();
            secondResponse.Marker = null;

            _mockClient.SetupSequence(x => x.ListStudioSessionMappings(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStudioSessionMappings(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticMapReduce")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStudioSessionMappingsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStudioSessionMappingsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStudioSessionMappingsResponse>();
            response.Marker = null;

            _mockClient.Setup(x => x.ListStudioSessionMappings(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStudioSessionMappings(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif