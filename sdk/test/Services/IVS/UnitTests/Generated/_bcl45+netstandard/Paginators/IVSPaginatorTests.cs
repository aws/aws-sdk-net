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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */

using Amazon.IVS;
using Amazon.IVS.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class IVSPaginatorTests
    {
        private static Mock<AmazonIVSClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonIVSClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        public void ListChannelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListChannelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListChannelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListChannels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListChannels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListChannelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListChannelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListChannelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListChannels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListChannels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        public void ListPlaybackKeyPairsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaybackKeyPairsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPlaybackKeyPairsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPlaybackKeyPairsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListPlaybackKeyPairs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListPlaybackKeyPairs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPlaybackKeyPairsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPlaybackKeyPairsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPlaybackKeyPairsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListPlaybackKeyPairs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListPlaybackKeyPairs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        public void ListRecordingConfigurationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRecordingConfigurationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRecordingConfigurationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRecordingConfigurationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRecordingConfigurations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRecordingConfigurations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRecordingConfigurationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRecordingConfigurationsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRecordingConfigurationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRecordingConfigurations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRecordingConfigurations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        public void ListStreamKeysTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamKeysRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStreamKeysResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStreamKeysResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStreamKeys(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStreamKeys(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStreamKeysTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamKeysRequest>();

            var response = InstantiateClassGenerator.Execute<ListStreamKeysResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStreamKeys(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStreamKeys(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("IVS")]
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
        [TestCategory("IVS")]
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