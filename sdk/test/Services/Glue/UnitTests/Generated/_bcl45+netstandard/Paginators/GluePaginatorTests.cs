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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */

using Amazon.Glue;
using Amazon.Glue.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class GluePaginatorTests
    {
        private static Mock<AmazonGlueClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonGlueClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetClassifiersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetClassifiersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetClassifiersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetClassifiersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetClassifiers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetClassifiers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetClassifiersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetClassifiersRequest>();

            var response = InstantiateClassGenerator.Execute<GetClassifiersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetClassifiers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetClassifiers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetConnectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetConnectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetConnectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetConnectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetConnections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetConnections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetConnectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetConnectionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetConnectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetConnections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetConnections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetCrawlerMetricsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCrawlerMetricsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCrawlerMetricsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCrawlerMetricsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCrawlerMetrics(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCrawlerMetrics(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCrawlerMetricsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCrawlerMetricsRequest>();

            var response = InstantiateClassGenerator.Execute<GetCrawlerMetricsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCrawlerMetrics(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCrawlerMetrics(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetCrawlersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCrawlersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCrawlersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCrawlersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCrawlers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCrawlers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCrawlersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCrawlersRequest>();

            var response = InstantiateClassGenerator.Execute<GetCrawlersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCrawlers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCrawlers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetDatabasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDatabasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDatabasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDatabasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDatabases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDatabases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDatabasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDatabasesRequest>();

            var response = InstantiateClassGenerator.Execute<GetDatabasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDatabases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDatabases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetDevEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetDevEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetDevEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetDevEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetDevEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetDevEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetDevEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetDevEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<GetDevEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetDevEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetDevEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetJobRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetJobRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetJobRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetJobRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetJobRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetJobRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetJobRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetJobRunsRequest>();

            var response = InstantiateClassGenerator.Execute<GetJobRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetJobRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetJobRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetJobsRequest>();

            var response = InstantiateClassGenerator.Execute<GetJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetMLTaskRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetMLTaskRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetMLTaskRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetMLTaskRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetMLTaskRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetMLTaskRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetMLTaskRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetMLTaskRunsRequest>();

            var response = InstantiateClassGenerator.Execute<GetMLTaskRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetMLTaskRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetMLTaskRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetMLTransformsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetMLTransformsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetMLTransformsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetMLTransformsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetMLTransforms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetMLTransforms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetMLTransformsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetMLTransformsRequest>();

            var response = InstantiateClassGenerator.Execute<GetMLTransformsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetMLTransforms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetMLTransforms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetPartitionIndexesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetPartitionIndexesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetPartitionIndexesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetPartitionIndexesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetPartitionIndexes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetPartitionIndexes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetPartitionIndexesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetPartitionIndexesRequest>();

            var response = InstantiateClassGenerator.Execute<GetPartitionIndexesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetPartitionIndexes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetPartitionIndexes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetPartitionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetPartitionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetPartitionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetPartitionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetPartitions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetPartitions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetPartitionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetPartitionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetPartitionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetPartitions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetPartitions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetResourcePoliciesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcePoliciesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetResourcePolicies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResourcePolicies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourcePoliciesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcePoliciesRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourcePoliciesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetResourcePolicies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResourcePolicies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetSecurityConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSecurityConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSecurityConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSecurityConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSecurityConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSecurityConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSecurityConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSecurityConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetSecurityConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSecurityConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSecurityConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTablesRequest>();

            var response = InstantiateClassGenerator.Execute<GetTablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetTableVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTableVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTableVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTableVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTableVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTableVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTableVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTableVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetTableVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTableVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTableVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetTriggersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTriggersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTriggersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTriggersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTriggers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTriggers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTriggersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTriggersRequest>();

            var response = InstantiateClassGenerator.Execute<GetTriggersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTriggers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTriggers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetUserDefinedFunctionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetUserDefinedFunctionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetUserDefinedFunctionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetUserDefinedFunctionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetUserDefinedFunctions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetUserDefinedFunctions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetUserDefinedFunctionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetUserDefinedFunctionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetUserDefinedFunctionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetUserDefinedFunctions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetUserDefinedFunctions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void GetWorkflowRunsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetWorkflowRunsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetWorkflowRunsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetWorkflowRunsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetWorkflowRuns(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetWorkflowRuns(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetWorkflowRunsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetWorkflowRunsRequest>();

            var response = InstantiateClassGenerator.Execute<GetWorkflowRunsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetWorkflowRuns(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetWorkflowRuns(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListCrawlersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCrawlersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCrawlersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCrawlersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCrawlers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCrawlers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCrawlersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCrawlersRequest>();

            var response = InstantiateClassGenerator.Execute<ListCrawlersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCrawlers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCrawlers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListDevEndpointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDevEndpointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDevEndpointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDevEndpointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDevEndpoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDevEndpoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDevEndpointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDevEndpointsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDevEndpointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDevEndpoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDevEndpoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListMLTransformsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMLTransformsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMLTransformsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMLTransformsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMLTransforms(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMLTransforms(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMLTransformsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMLTransformsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMLTransformsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMLTransforms(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMLTransforms(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListRegistriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRegistriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRegistriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRegistriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRegistries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRegistries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRegistriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRegistriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListRegistriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRegistries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRegistries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListSchemasTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemasRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSchemas(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSchemas(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSchemasTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemasRequest>();

            var response = InstantiateClassGenerator.Execute<ListSchemasResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSchemas(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSchemas(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListSchemaVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemaVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSchemaVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSchemaVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSchemaVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSchemaVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSchemaVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSchemaVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSchemaVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSchemaVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSchemaVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListTriggersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTriggersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTriggersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTriggersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTriggers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTriggers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTriggersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTriggersRequest>();

            var response = InstantiateClassGenerator.Execute<ListTriggersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTriggers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTriggers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void ListWorkflowsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkflowsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkflowsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkflowsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkflows(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkflows(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkflowsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkflowsRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkflowsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkflows(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkflows(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        public void SearchTablesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<SearchTablesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<SearchTablesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<SearchTablesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.SearchTables(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.SearchTables(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Glue")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void SearchTablesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<SearchTablesRequest>();

            var response = InstantiateClassGenerator.Execute<SearchTablesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.SearchTables(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.SearchTables(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif