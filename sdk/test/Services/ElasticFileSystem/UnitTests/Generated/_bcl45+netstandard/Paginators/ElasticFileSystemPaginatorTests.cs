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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */

using Amazon.ElasticFileSystem;
using Amazon.ElasticFileSystem.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ElasticFileSystemPaginatorTests
    {
        private static Mock<AmazonElasticFileSystemClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonElasticFileSystemClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        public void DescribeAccessPointsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAccessPointsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeAccessPointsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeAccessPointsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeAccessPoints(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeAccessPoints(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeAccessPointsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeAccessPointsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeAccessPointsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeAccessPoints(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeAccessPoints(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        public void DescribeFileSystemsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFileSystemsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeFileSystemsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeFileSystemsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.DescribeFileSystems(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeFileSystems(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeFileSystemsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeFileSystemsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeFileSystemsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.DescribeFileSystems(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeFileSystems(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        public void DescribeTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            secondResponse.NextMarker = null;

            _mockClient.SetupSequence(x => x.DescribeTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeTagsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeTagsResponse>();
            response.NextMarker = null;

            _mockClient.Setup(x => x.DescribeTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        public void ListTagsForResourceTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTagsForResource(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ElasticFileSystem")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsForResourceTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsForResourceRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsForResourceResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTagsForResource(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTagsForResource(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif