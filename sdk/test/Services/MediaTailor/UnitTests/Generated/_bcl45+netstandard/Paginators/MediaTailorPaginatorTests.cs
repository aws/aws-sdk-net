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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */

using Amazon.MediaTailor;
using Amazon.MediaTailor.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaTailorPaginatorTests
    {
        private static Mock<AmazonMediaTailorClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaTailorClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        public void ListPlaybackConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPlaybackConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPlaybackConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaTailor")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPlaybackConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPlaybackConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPlaybackConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPlaybackConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif