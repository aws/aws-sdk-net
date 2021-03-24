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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */

using Amazon.CloudHSMV2;
using Amazon.CloudHSMV2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudHSMV2PaginatorTests
    {
        private static Mock<AmazonCloudHSMV2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudHSMV2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudHSMV2")]
        public void DescribeBackupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBackupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeBackupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeBackupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeBackups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeBackups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudHSMV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeBackupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeBackupsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeBackupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeBackups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeBackups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudHSMV2")]
        public void DescribeClustersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeClustersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeClustersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeClusters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeClusters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudHSMV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeClustersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeClustersRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeClustersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeClusters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeClusters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudHSMV2")]
        public void ListTagsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTagsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTags(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTags(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudHSMV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTagsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTagsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTagsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTags(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTags(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}