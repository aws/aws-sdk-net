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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */

using Amazon.DataExchange;
using Amazon.DataExchange.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DataExchangePaginatorTests
    {
        private static Mock<AmazonDataExchangeClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDataExchangeClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataExchange")]
        public void ListDataSetRevisionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSetRevisionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataSetRevisionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataSetRevisionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataSetRevisions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataSetRevisions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataExchange")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataSetRevisionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSetRevisionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataSetRevisionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataSetRevisions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataSetRevisions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataExchange")]
        public void ListDataSetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDataSetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDataSetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDataSets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDataSets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataExchange")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDataSetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDataSetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDataSetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDataSets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDataSets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataExchange")]
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
        [TestCategory("DataExchange")]
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
        [TestCategory("DataExchange")]
        public void ListRevisionAssetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRevisionAssetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRevisionAssetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRevisionAssetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRevisionAssets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRevisionAssets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataExchange")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRevisionAssetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRevisionAssetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRevisionAssetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRevisionAssets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRevisionAssets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif