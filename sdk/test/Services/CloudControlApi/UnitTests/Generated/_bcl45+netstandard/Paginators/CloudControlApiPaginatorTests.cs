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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */

using Amazon.CloudControlApi;
using Amazon.CloudControlApi.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CloudControlApiPaginatorTests
    {
        private static Mock<AmazonCloudControlApiClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCloudControlApiClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudControlApi")]
        public void ListResourceRequestsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceRequestsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourceRequestsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourceRequestsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResourceRequests(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResourceRequests(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudControlApi")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourceRequestsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourceRequestsRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourceRequestsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResourceRequests(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResourceRequests(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudControlApi")]
        public void ListResourcesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListResources(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListResources(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CloudControlApi")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListResourcesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListResourcesRequest>();

            var response = InstantiateClassGenerator.Execute<ListResourcesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListResources(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListResources(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}