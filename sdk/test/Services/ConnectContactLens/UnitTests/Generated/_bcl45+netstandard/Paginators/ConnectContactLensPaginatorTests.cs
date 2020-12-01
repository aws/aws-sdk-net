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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
 */

using Amazon.ConnectContactLens;
using Amazon.ConnectContactLens.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ConnectContactLensPaginatorTests
    {
        private static Mock<AmazonConnectContactLensClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonConnectContactLensClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectContactLens")]
        public void ListRealtimeContactAnalysisSegmentsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListRealtimeContactAnalysisSegmentsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListRealtimeContactAnalysisSegmentsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListRealtimeContactAnalysisSegmentsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListRealtimeContactAnalysisSegments(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListRealtimeContactAnalysisSegments(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ConnectContactLens")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListRealtimeContactAnalysisSegmentsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListRealtimeContactAnalysisSegmentsRequest>();

            var response = InstantiateClassGenerator.Execute<ListRealtimeContactAnalysisSegmentsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListRealtimeContactAnalysisSegments(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListRealtimeContactAnalysisSegments(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif