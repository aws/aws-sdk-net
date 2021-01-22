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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */

using Amazon.LexModelsV2;
using Amazon.LexModelsV2.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LexModelsV2PaginatorTests
    {
        private static Mock<AmazonLexModelsV2Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLexModelsV2Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListBotAliasesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBotAliasesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBotAliasesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBotAliasesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBotAliases(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBotAliases(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBotAliasesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBotAliasesRequest>();

            var response = InstantiateClassGenerator.Execute<ListBotAliasesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBotAliases(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBotAliases(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListBotLocalesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBotLocalesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBotLocalesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBotLocalesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBotLocales(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBotLocales(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBotLocalesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBotLocalesRequest>();

            var response = InstantiateClassGenerator.Execute<ListBotLocalesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBotLocales(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBotLocales(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListBotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBotsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListBotVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBotVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBotVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBotVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBotVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBotVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBotVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBotVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBotVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBotVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBotVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListBuiltInIntentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBuiltInIntentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBuiltInIntentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBuiltInIntentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBuiltInIntents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBuiltInIntents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBuiltInIntentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBuiltInIntentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListBuiltInIntentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBuiltInIntents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBuiltInIntents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListBuiltInSlotTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListBuiltInSlotTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListBuiltInSlotTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListBuiltInSlotTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListBuiltInSlotTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListBuiltInSlotTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListBuiltInSlotTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListBuiltInSlotTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListBuiltInSlotTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListBuiltInSlotTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListBuiltInSlotTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListIntentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListIntentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListIntentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListIntentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListIntents(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListIntents(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListIntentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListIntentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListIntentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListIntents(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListIntents(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListSlotsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSlotsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSlotsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSlotsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSlots(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSlots(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSlotsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSlotsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSlotsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSlots(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSlots(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        public void ListSlotTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSlotTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSlotTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSlotTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSlotTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSlotTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LexModelsV2")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSlotTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSlotTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListSlotTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSlotTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSlotTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif