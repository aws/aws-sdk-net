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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
 */

using Amazon.MediaStore;
using Amazon.MediaStore.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class MediaStorePaginatorTests
    {
        private static Mock<AmazonMediaStoreClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonMediaStoreClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaStore")]
        public void ListContainersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListContainersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListContainersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListContainersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListContainers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListContainers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("MediaStore")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListContainersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListContainersRequest>();

            var response = InstantiateClassGenerator.Execute<ListContainersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListContainers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListContainers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif