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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */

using Amazon.Comprehend;
using Amazon.Comprehend.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ComprehendPaginatorTests
    {
        private static Mock<AmazonComprehendClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonComprehendClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListDocumentClassificationJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentClassificationJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDocumentClassificationJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDocumentClassificationJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDocumentClassificationJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDocumentClassificationJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDocumentClassificationJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentClassificationJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDocumentClassificationJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDocumentClassificationJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDocumentClassificationJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListDocumentClassifiersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentClassifiersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDocumentClassifiersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDocumentClassifiersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDocumentClassifiers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDocumentClassifiers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDocumentClassifiersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDocumentClassifiersRequest>();

            var response = InstantiateClassGenerator.Execute<ListDocumentClassifiersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDocumentClassifiers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDocumentClassifiers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListDominantLanguageDetectionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDominantLanguageDetectionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDominantLanguageDetectionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDominantLanguageDetectionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDominantLanguageDetectionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDominantLanguageDetectionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDominantLanguageDetectionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDominantLanguageDetectionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDominantLanguageDetectionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDominantLanguageDetectionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDominantLanguageDetectionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListEntitiesDetectionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitiesDetectionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEntitiesDetectionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEntitiesDetectionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEntitiesDetectionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEntitiesDetectionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEntitiesDetectionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEntitiesDetectionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEntitiesDetectionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEntitiesDetectionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEntitiesDetectionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListEntityRecognizersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEntityRecognizersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEntityRecognizersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEntityRecognizersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEntityRecognizers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEntityRecognizers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEntityRecognizersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEntityRecognizersRequest>();

            var response = InstantiateClassGenerator.Execute<ListEntityRecognizersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEntityRecognizers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEntityRecognizers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListEventsDetectionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListEventsDetectionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListEventsDetectionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListEventsDetectionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListEventsDetectionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListEventsDetectionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListEventsDetectionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListEventsDetectionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListEventsDetectionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListEventsDetectionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListEventsDetectionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListKeyPhrasesDetectionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListKeyPhrasesDetectionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListKeyPhrasesDetectionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListKeyPhrasesDetectionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListKeyPhrasesDetectionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListKeyPhrasesDetectionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListKeyPhrasesDetectionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListKeyPhrasesDetectionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListKeyPhrasesDetectionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListKeyPhrasesDetectionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListKeyPhrasesDetectionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListSentimentDetectionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListSentimentDetectionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListSentimentDetectionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListSentimentDetectionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListSentimentDetectionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListSentimentDetectionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListSentimentDetectionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListSentimentDetectionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListSentimentDetectionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListSentimentDetectionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListSentimentDetectionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        public void ListTopicsDetectionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTopicsDetectionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTopicsDetectionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTopicsDetectionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTopicsDetectionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTopicsDetectionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Comprehend")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTopicsDetectionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTopicsDetectionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTopicsDetectionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTopicsDetectionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTopicsDetectionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif