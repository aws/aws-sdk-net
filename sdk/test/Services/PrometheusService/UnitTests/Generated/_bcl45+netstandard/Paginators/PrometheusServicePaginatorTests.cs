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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */

using Amazon.PrometheusService;
using Amazon.PrometheusService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class PrometheusServicePaginatorTests
    {
        private static Mock<AmazonPrometheusServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonPrometheusServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PrometheusService")]
        public void ListWorkspacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkspacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListWorkspaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListWorkspaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("PrometheusService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListWorkspacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListWorkspacesRequest>();

            var response = InstantiateClassGenerator.Execute<ListWorkspacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListWorkspaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListWorkspaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif