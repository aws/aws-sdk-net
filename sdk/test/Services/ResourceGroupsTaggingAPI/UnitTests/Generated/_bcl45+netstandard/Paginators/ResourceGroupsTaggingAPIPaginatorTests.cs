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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */

using Amazon.ResourceGroupsTaggingAPI;
using Amazon.ResourceGroupsTaggingAPI.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ResourceGroupsTaggingAPIPaginatorTests
    {
        private static Mock<AmazonResourceGroupsTaggingAPIClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonResourceGroupsTaggingAPIClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        public void GetComplianceSummaryTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetComplianceSummaryRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetComplianceSummaryResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetComplianceSummaryResponse>();
            secondResponse.PaginationToken = null;

            _mockClient.SetupSequence(x => x.GetComplianceSummary(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetComplianceSummary(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetComplianceSummaryTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetComplianceSummaryRequest>();

            var response = InstantiateClassGenerator.Execute<GetComplianceSummaryResponse>();
            response.PaginationToken = null;

            _mockClient.Setup(x => x.GetComplianceSummary(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetComplianceSummary(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        public void GetResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetResourcesResponse>();
            secondResponse.PaginationToken = null;

            _mockClient.SetupSequence(x => x.GetResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<GetResourcesResponse>();
            response.PaginationToken = null;

            _mockClient.Setup(x => x.GetResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        public void GetTagKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTagKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTagKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTagKeysResponse>();
            secondResponse.PaginationToken = null;

            _mockClient.SetupSequence(x => x.GetTagKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTagKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTagKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTagKeysRequest>();

            var response = InstantiateClassGenerator.Execute<GetTagKeysResponse>();
            response.PaginationToken = null;

            _mockClient.Setup(x => x.GetTagKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTagKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        public void GetTagValuesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTagValuesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTagValuesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTagValuesResponse>();
            secondResponse.PaginationToken = null;

            _mockClient.SetupSequence(x => x.GetTagValues(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTagValues(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ResourceGroupsTaggingAPI")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTagValuesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTagValuesRequest>();

            var response = InstantiateClassGenerator.Execute<GetTagValuesResponse>();
            response.PaginationToken = null;

            _mockClient.Setup(x => x.GetTagValues(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTagValues(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif