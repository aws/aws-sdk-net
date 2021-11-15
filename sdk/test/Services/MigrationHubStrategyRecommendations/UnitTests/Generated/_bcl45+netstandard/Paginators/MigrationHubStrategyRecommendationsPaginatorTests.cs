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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */

using Amazon.MigrationHubStrategyRecommendations;
using Amazon.MigrationHubStrategyRecommendations.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MigrationHubStrategyRecommendationsPaginatorTests
    {
        private static Mock<AmazonMigrationHubStrategyRecommendationsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMigrationHubStrategyRecommendationsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        public void GetServerDetailsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetServerDetailsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetServerDetailsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetServerDetailsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetServerDetails(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetServerDetails(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetServerDetailsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetServerDetailsRequest>();

            var response = InstantiateClassGenerator.Execute<GetServerDetailsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetServerDetails(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetServerDetails(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        public void ListApplicationComponentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationComponentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListApplicationComponentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListApplicationComponentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListApplicationComponents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListApplicationComponents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListApplicationComponentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListApplicationComponentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListApplicationComponentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListApplicationComponents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListApplicationComponents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        public void ListCollectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCollectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCollectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCollectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCollectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCollectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCollectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCollectorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCollectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCollectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCollectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        public void ListImportFileTaskTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImportFileTaskRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImportFileTaskResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImportFileTaskResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImportFileTask(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImportFileTask(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImportFileTaskTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImportFileTaskRequest>();

            var response = InstantiateClassGenerator.Execute<ListImportFileTaskResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImportFileTask(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImportFileTask(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        public void ListServersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListServersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListServersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListServersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListServers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListServers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MigrationHubStrategyRecommendations")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListServersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListServersRequest>();

            var response = InstantiateClassGenerator.Execute<ListServersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListServers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListServers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}