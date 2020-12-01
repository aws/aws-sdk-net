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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */

using Amazon.LookoutforVision;
using Amazon.LookoutforVision.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class LookoutforVisionPaginatorTests
    {
        private static Mock<AmazonLookoutforVisionClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonLookoutforVisionClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutforVision")]
        public void ListDatasetEntriesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetEntriesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetEntriesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetEntriesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasetEntries(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasetEntries(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutforVision")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetEntriesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetEntriesRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetEntriesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasetEntries(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasetEntries(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutforVision")]
        public void ListModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutforVision")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListModelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutforVision")]
        public void ListProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("LookoutforVision")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif