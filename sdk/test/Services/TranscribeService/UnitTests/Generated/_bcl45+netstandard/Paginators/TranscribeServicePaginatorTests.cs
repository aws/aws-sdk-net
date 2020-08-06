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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */

using Amazon.TranscribeService;
using Amazon.TranscribeService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class TranscribeServicePaginatorTests
    {
        private static Mock<AmazonTranscribeServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonTranscribeServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        public void ListLanguageModelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLanguageModelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLanguageModelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLanguageModelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLanguageModels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLanguageModels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLanguageModelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLanguageModelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListLanguageModelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLanguageModels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLanguageModels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        public void ListMedicalTranscriptionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMedicalTranscriptionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMedicalTranscriptionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMedicalTranscriptionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMedicalTranscriptionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMedicalTranscriptionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMedicalTranscriptionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMedicalTranscriptionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMedicalTranscriptionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMedicalTranscriptionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMedicalTranscriptionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        public void ListMedicalVocabulariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMedicalVocabulariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMedicalVocabulariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMedicalVocabulariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListMedicalVocabularies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMedicalVocabularies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMedicalVocabulariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMedicalVocabulariesRequest>();

            var response = InstantiateClassGenerator.Execute<ListMedicalVocabulariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListMedicalVocabularies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMedicalVocabularies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        public void ListTranscriptionJobsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListTranscriptionJobsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListTranscriptionJobsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListTranscriptionJobsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListTranscriptionJobs(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListTranscriptionJobs(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListTranscriptionJobsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListTranscriptionJobsRequest>();

            var response = InstantiateClassGenerator.Execute<ListTranscriptionJobsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListTranscriptionJobs(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListTranscriptionJobs(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        public void ListVocabulariesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVocabulariesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVocabulariesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVocabulariesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVocabularies(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVocabularies(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVocabulariesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVocabulariesRequest>();

            var response = InstantiateClassGenerator.Execute<ListVocabulariesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVocabularies(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVocabularies(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        public void ListVocabularyFiltersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVocabularyFiltersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVocabularyFiltersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVocabularyFiltersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListVocabularyFilters(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVocabularyFilters(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("TranscribeService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVocabularyFiltersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVocabularyFiltersRequest>();

            var response = InstantiateClassGenerator.Execute<ListVocabularyFiltersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListVocabularyFilters(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVocabularyFilters(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif