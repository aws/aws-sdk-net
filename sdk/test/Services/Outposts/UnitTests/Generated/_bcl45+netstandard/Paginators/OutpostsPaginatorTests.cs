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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
 */

using Amazon.Outposts;
using Amazon.Outposts.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class OutpostsPaginatorTests
    {
        private static Mock<AmazonOutpostsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonOutpostsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Outposts")]
        public void ListOutpostsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListOutpostsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListOutpostsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListOutpostsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListOutposts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListOutposts(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Outposts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListOutpostsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListOutpostsRequest>();

            var response = InstantiateClassGenerator.Execute<ListOutpostsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListOutposts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListOutposts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Outposts")]
        public void ListSitesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSitesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSitesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSitesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSites(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSites(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Outposts")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSitesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSitesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSitesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSites(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSites(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}