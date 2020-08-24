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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */

using Amazon.KinesisVideo;
using Amazon.KinesisVideo.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class KinesisVideoPaginatorTests
    {
        private static Mock<AmazonKinesisVideoClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonKinesisVideoClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KinesisVideo")]
        public void ListSignalingChannelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSignalingChannelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSignalingChannelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSignalingChannelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSignalingChannels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSignalingChannels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KinesisVideo")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSignalingChannelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSignalingChannelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSignalingChannelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSignalingChannels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSignalingChannels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KinesisVideo")]
        public void ListStreamsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStreamsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStreamsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStreams(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStreams(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("KinesisVideo")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStreamsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStreamsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStreams(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStreams(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif