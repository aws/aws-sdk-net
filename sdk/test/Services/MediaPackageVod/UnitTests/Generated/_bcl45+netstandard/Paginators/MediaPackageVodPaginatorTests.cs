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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */

using Amazon.MediaPackageVod;
using Amazon.MediaPackageVod.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaPackageVodPaginatorTests
    {
        private static Mock<AmazonMediaPackageVodClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaPackageVodClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackageVod")]
        public void ListAssetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAssetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAssetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAssets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAssets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackageVod")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAssetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAssetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListAssetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAssets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAssets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackageVod")]
        public void ListPackagingConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagingConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPackagingConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPackagingConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPackagingConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPackagingConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackageVod")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPackagingConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagingConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPackagingConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPackagingConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPackagingConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackageVod")]
        public void ListPackagingGroupsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagingGroupsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPackagingGroupsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPackagingGroupsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPackagingGroups(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPackagingGroups(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaPackageVod")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPackagingGroupsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPackagingGroupsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPackagingGroupsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPackagingGroups(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPackagingGroups(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}