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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */

using Amazon.Drs;
using Amazon.Drs.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DrsPaginatorTests
    {
        private static Mock<AmazonDrsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDrsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        public void DescribeJobLogItemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobLogItemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeJobLogItemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeJobLogItemsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeJobLogItems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeJobLogItems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeJobLogItemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobLogItemsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeJobLogItemsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeJobLogItems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeJobLogItems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        public void DescribeJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeJobsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        public void DescribeRecoveryInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRecoveryInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRecoveryInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRecoveryInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRecoveryInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRecoveryInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRecoveryInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRecoveryInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRecoveryInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRecoveryInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRecoveryInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        public void DescribeRecoverySnapshotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRecoverySnapshotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeRecoverySnapshotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeRecoverySnapshotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeRecoverySnapshots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeRecoverySnapshots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeRecoverySnapshotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeRecoverySnapshotsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeRecoverySnapshotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeRecoverySnapshots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeRecoverySnapshots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        public void DescribeReplicationConfigurationTemplatesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationConfigurationTemplatesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeReplicationConfigurationTemplatesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeReplicationConfigurationTemplatesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeReplicationConfigurationTemplates(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationConfigurationTemplates(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeReplicationConfigurationTemplatesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeReplicationConfigurationTemplatesRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeReplicationConfigurationTemplatesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeReplicationConfigurationTemplates(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeReplicationConfigurationTemplates(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        public void DescribeSourceServersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSourceServersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeSourceServersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeSourceServersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeSourceServers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeSourceServers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Drs")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeSourceServersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeSourceServersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeSourceServersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeSourceServers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeSourceServers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}