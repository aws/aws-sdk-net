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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */

using Amazon.Kendra;
using Amazon.Kendra.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class KendraPaginatorTests
    {
        private static Mock<AmazonKendraClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonKendraClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kendra")]
        public void ListDataSourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataSourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataSourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataSources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataSources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kendra")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataSourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataSourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataSources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataSources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kendra")]
        public void ListDataSourceSyncJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSourceSyncJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataSourceSyncJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataSourceSyncJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataSourceSyncJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataSourceSyncJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kendra")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataSourceSyncJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSourceSyncJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataSourceSyncJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataSourceSyncJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataSourceSyncJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kendra")]
        public void ListIndicesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIndicesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIndicesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIndicesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIndices(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIndices(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Kendra")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIndicesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIndicesRequest>();

            var response = InstantiateClassGenerator.Execute<ListIndicesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIndices(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIndices(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif