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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */

using Amazon.Translate;
using Amazon.Translate.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class TranslatePaginatorTests
    {
        private static Mock<AmazonTranslateClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonTranslateClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Translate")]
        public void ListParallelDataTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListParallelDataRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListParallelDataResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListParallelDataResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListParallelData(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListParallelData(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Translate")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListParallelDataTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListParallelDataRequest>();

            var response = InstantiateClassGenerator.Execute<ListParallelDataResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListParallelData(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListParallelData(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Translate")]
        public void ListTerminologiesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTerminologiesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTerminologiesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTerminologiesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTerminologies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTerminologies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Translate")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTerminologiesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTerminologiesRequest>();

            var response = InstantiateClassGenerator.Execute<ListTerminologiesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTerminologies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTerminologies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Translate")]
        public void ListTextTranslationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTextTranslationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTextTranslationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTextTranslationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTextTranslationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTextTranslationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Translate")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTextTranslationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTextTranslationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTextTranslationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTextTranslationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTextTranslationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif