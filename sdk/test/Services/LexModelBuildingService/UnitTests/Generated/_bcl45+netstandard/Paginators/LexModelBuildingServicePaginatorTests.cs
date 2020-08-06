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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */

using Amazon.LexModelBuildingService;
using Amazon.LexModelBuildingService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LexModelBuildingServicePaginatorTests
    {
        private static Mock<AmazonLexModelBuildingServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLexModelBuildingServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBotAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBotAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBotAliasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBotAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBotAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBotAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBotAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<GetBotAliasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBotAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBotAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotChannelAssociationsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBotChannelAssociationsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBotChannelAssociationsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBotChannelAssociationsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBotChannelAssociations(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBotChannelAssociations(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBotChannelAssociationsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBotChannelAssociationsRequest>();

            var response = InstantiateClassGenerator.Execute<GetBotChannelAssociationsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBotChannelAssociations(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBotChannelAssociations(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBotsRequest>();

            var response = InstantiateClassGenerator.Execute<GetBotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetBotVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBotVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBotVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBotVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBotVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBotVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBotVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBotVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetBotVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBotVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBotVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetBuiltinIntentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBuiltinIntentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBuiltinIntentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBuiltinIntentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBuiltinIntents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBuiltinIntents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBuiltinIntentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBuiltinIntentsRequest>();

            var response = InstantiateClassGenerator.Execute<GetBuiltinIntentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBuiltinIntents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBuiltinIntents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetBuiltinSlotTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetBuiltinSlotTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetBuiltinSlotTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetBuiltinSlotTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetBuiltinSlotTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetBuiltinSlotTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetBuiltinSlotTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetBuiltinSlotTypesRequest>();

            var response = InstantiateClassGenerator.Execute<GetBuiltinSlotTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetBuiltinSlotTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetBuiltinSlotTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetIntentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetIntentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetIntentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetIntentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetIntents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetIntents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetIntentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetIntentsRequest>();

            var response = InstantiateClassGenerator.Execute<GetIntentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetIntents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetIntents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetIntentVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetIntentVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetIntentVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetIntentVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetIntentVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetIntentVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetIntentVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetIntentVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetIntentVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetIntentVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetIntentVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetSlotTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSlotTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSlotTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSlotTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSlotTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSlotTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSlotTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSlotTypesRequest>();

            var response = InstantiateClassGenerator.Execute<GetSlotTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSlotTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSlotTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        public void GetSlotTypeVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSlotTypeVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSlotTypeVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSlotTypeVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSlotTypeVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSlotTypeVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelBuildingService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSlotTypeVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSlotTypeVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<GetSlotTypeVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSlotTypeVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSlotTypeVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif