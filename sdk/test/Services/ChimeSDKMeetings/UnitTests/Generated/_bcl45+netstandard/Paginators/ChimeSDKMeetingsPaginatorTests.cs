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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */

using Amazon.ChimeSDKMeetings;
using Amazon.ChimeSDKMeetings.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ChimeSDKMeetingsPaginatorTests
    {
        private static Mock<AmazonChimeSDKMeetingsClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonChimeSDKMeetingsClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMeetings")]
        public void ListAttendeesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListAttendeesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListAttendeesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListAttendees(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListAttendees(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ChimeSDKMeetings")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListAttendeesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListAttendeesRequest>();

            var response = InstantiateClassGenerator.Execute<ListAttendeesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListAttendees(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListAttendees(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}