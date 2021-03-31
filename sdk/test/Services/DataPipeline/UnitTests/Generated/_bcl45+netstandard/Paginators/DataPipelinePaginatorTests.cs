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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */

using Amazon.DataPipeline;
using Amazon.DataPipeline.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class DataPipelinePaginatorTests
    {
        private static Mock<AmazonDataPipelineClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonDataPipelineClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataPipeline")]
        public void DescribeObjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeObjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeObjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeObjectsResponse>();
            secondResponse.HasMoreResults = false;

            _mockClient.SetupSequence(x => x.DescribeObjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeObjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataPipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeObjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeObjectsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeObjectsResponse>();
            response.HasMoreResults = false;

            _mockClient.Setup(x => x.DescribeObjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeObjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataPipeline")]
        public void ListPipelinesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelinesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            secondResponse.HasMoreResults = false;

            _mockClient.SetupSequence(x => x.ListPipelines(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPipelines(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataPipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPipelinesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPipelinesRequest>();

            var response = InstantiateClassGenerator.Execute<ListPipelinesResponse>();
            response.HasMoreResults = false;

            _mockClient.Setup(x => x.ListPipelines(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPipelines(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataPipeline")]
        public void QueryObjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<QueryObjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<QueryObjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<QueryObjectsResponse>();
            secondResponse.HasMoreResults = false;

            _mockClient.SetupSequence(x => x.QueryObjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.QueryObjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("DataPipeline")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void QueryObjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<QueryObjectsRequest>();

            var response = InstantiateClassGenerator.Execute<QueryObjectsResponse>();
            response.HasMoreResults = false;

            _mockClient.Setup(x => x.QueryObjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.QueryObjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}