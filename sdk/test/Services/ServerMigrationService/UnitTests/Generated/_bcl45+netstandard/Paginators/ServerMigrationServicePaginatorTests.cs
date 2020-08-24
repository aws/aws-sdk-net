#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */

using Amazon.ServerMigrationService;
using Amazon.ServerMigrationService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ServerMigrationServicePaginatorTests
    {
        private static Mock<AmazonServerMigrationServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonServerMigrationServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        public void GetConnectorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetConnectorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetConnectorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetConnectorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetConnectors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetConnectors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetConnectorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetConnectorsRequest>();

            var response = InstantiateClassGenerator.Execute<GetConnectorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetConnectors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetConnectors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        public void GetReplicationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetReplicationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetReplicationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetReplicationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetReplicationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetReplicationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetReplicationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetReplicationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<GetReplicationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetReplicationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetReplicationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        public void GetReplicationRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetReplicationRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetReplicationRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetReplicationRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetReplicationRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetReplicationRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetReplicationRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetReplicationRunsRequest>();

            var response = InstantiateClassGenerator.Execute<GetReplicationRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetReplicationRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetReplicationRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        public void GetServersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetServersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetServersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetServersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetServers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetServers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ServerMigrationService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetServersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetServersRequest>();

            var response = InstantiateClassGenerator.Execute<GetServersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetServers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetServers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif