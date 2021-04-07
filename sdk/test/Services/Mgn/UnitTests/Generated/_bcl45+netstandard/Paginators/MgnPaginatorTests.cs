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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */

using Amazon.Mgn;
using Amazon.Mgn.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MgnPaginatorTests
    {
        private static Mock<AmazonMgnClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMgnClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Mgn")]
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
        [TestCategory("Mgn")]
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
        [TestCategory("Mgn")]
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
        [TestCategory("Mgn")]
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
        [TestCategory("Mgn")]
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
        [TestCategory("Mgn")]
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
        [TestCategory("Mgn")]
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
        [TestCategory("Mgn")]
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