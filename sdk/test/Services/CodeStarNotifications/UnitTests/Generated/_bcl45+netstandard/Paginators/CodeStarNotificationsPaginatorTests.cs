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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */

using Amazon.CodeStarNotifications;
using Amazon.CodeStarNotifications.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class CodeStarNotificationsPaginatorTests
    {
        private static Mock<AmazonCodeStarNotificationsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonCodeStarNotificationsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarNotifications")]
        public void ListEventTypesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEventTypesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEventTypesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEventTypesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEventTypes(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEventTypes(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarNotifications")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEventTypesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEventTypesRequest>();

            var response = InstantiateClassGenerator.Execute<ListEventTypesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEventTypes(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEventTypes(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarNotifications")]
        public void ListNotificationRulesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListNotificationRulesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListNotificationRulesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListNotificationRulesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListNotificationRules(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListNotificationRules(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarNotifications")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListNotificationRulesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListNotificationRulesRequest>();

            var response = InstantiateClassGenerator.Execute<ListNotificationRulesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListNotificationRules(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListNotificationRules(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarNotifications")]
        public void ListTargetsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTargetsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTargetsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTargets(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTargets(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("CodeStarNotifications")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTargetsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTargetsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTargetsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTargets(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTargets(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif