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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ElasticBeanstalkPaginatorTests
    {
        private static Mock<AmazonElasticBeanstalkClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonElasticBeanstalkClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEnvironmentManagedActionHistoryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEnvironmentManagedActionHistoryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEnvironmentManagedActionHistoryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEnvironmentManagedActionHistoryResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEnvironmentManagedActionHistory(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEnvironmentManagedActionHistory(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEnvironmentManagedActionHistoryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEnvironmentManagedActionHistoryRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEnvironmentManagedActionHistoryResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEnvironmentManagedActionHistory(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEnvironmentManagedActionHistory(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        public void DescribeEventsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeEvents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeEventsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeEventsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeEventsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeEvents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeEvents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        public void ListPlatformBranchesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPlatformBranchesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPlatformBranchesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPlatformBranchesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPlatformBranches(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPlatformBranches(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPlatformBranchesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPlatformBranchesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPlatformBranchesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPlatformBranches(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPlatformBranches(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        public void ListPlatformVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPlatformVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPlatformVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPlatformVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPlatformVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPlatformVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticBeanstalk")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPlatformVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPlatformVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPlatformVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPlatformVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPlatformVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif