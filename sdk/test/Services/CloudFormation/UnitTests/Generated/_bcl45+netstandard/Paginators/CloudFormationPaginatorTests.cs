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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudFormationPaginatorTests
    {
        private static Mock<AmazonCloudFormationClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudFormationClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void DescribeAccountLimitsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAccountLimitsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAccountLimitsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAccountLimitsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAccountLimits(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAccountLimits(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAccountLimitsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAccountLimitsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAccountLimitsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAccountLimits(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAccountLimits(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void DescribeStackEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStackEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeStackEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeStackEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeStackEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeStackEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeStackEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStackEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeStackEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeStackEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeStackEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void DescribeStackResourceDriftsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStackResourceDriftsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeStackResourceDriftsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeStackResourceDriftsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeStackResourceDrifts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeStackResourceDrifts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeStackResourceDriftsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStackResourceDriftsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeStackResourceDriftsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeStackResourceDrifts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeStackResourceDrifts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void DescribeStacksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStacksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeStacksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeStacksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeStacks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeStacks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeStacksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeStacksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeStacksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeStacks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeStacks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListChangeSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChangeSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChangeSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChangeSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChangeSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChangeSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChangeSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChangeSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListChangeSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChangeSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChangeSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListExportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListExportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListExportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListExportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListExports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListExports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListExportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListExportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListExportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListExports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListExports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListImportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListImportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListImportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListImports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListImports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListImportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListImportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListImportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListImports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListImports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListStackInstancesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStackInstancesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStackInstancesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStackInstancesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStackInstances(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStackInstances(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStackInstancesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStackInstancesRequest>();

            var response = InstantiateClassGenerator.Execute<ListStackInstancesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStackInstances(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStackInstances(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListStackResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStackResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStackResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStackResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStackResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStackResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStackResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStackResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListStackResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStackResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStackResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListStacksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStacksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStacksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStacksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStacks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStacks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStacksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStacksRequest>();

            var response = InstantiateClassGenerator.Execute<ListStacksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStacks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStacks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListStackSetOperationResultsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStackSetOperationResultsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStackSetOperationResultsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStackSetOperationResultsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStackSetOperationResults(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStackSetOperationResults(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStackSetOperationResultsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStackSetOperationResultsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStackSetOperationResultsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStackSetOperationResults(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStackSetOperationResults(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListStackSetOperationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStackSetOperationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStackSetOperationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStackSetOperationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStackSetOperations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStackSetOperations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStackSetOperationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStackSetOperationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStackSetOperationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStackSetOperations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStackSetOperations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListStackSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStackSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStackSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStackSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStackSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStackSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStackSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStackSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStackSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStackSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStackSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListTypeRegistrationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTypeRegistrationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTypeRegistrationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTypeRegistrationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTypeRegistrations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTypeRegistrations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTypeRegistrationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTypeRegistrationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTypeRegistrationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTypeRegistrations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTypeRegistrations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        public void ListTypeVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTypeVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTypeVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTypeVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTypeVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTypeVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudFormation")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTypeVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTypeVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTypeVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTypeVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTypeVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif