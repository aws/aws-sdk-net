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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */

using Amazon.Rekognition;
using Amazon.Rekognition.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class RekognitionPaginatorTests
    {
        private static Mock<AmazonRekognitionClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonRekognitionClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void DescribeProjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeProjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeProjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeProjectsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeProjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeProjects(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeProjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeProjectsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeProjectsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeProjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeProjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void DescribeProjectVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeProjectVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeProjectVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeProjectVersionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeProjectVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeProjectVersions(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeProjectVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeProjectVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeProjectVersionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeProjectVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeProjectVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetCelebrityRecognitionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetCelebrityRecognitionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetCelebrityRecognitionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetCelebrityRecognitionResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetCelebrityRecognition(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetCelebrityRecognition(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetCelebrityRecognitionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetCelebrityRecognitionRequest>();

            var response = InstantiateClassGenerator.Execute<GetCelebrityRecognitionResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetCelebrityRecognition(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetCelebrityRecognition(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetContentModerationTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetContentModerationRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetContentModerationResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetContentModerationResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetContentModeration(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetContentModeration(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetContentModerationTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetContentModerationRequest>();

            var response = InstantiateClassGenerator.Execute<GetContentModerationResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetContentModeration(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetContentModeration(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetFaceDetectionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetFaceDetectionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetFaceDetectionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetFaceDetectionResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetFaceDetection(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetFaceDetection(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetFaceDetectionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetFaceDetectionRequest>();

            var response = InstantiateClassGenerator.Execute<GetFaceDetectionResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetFaceDetection(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetFaceDetection(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetFaceSearchTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetFaceSearchRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetFaceSearchResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetFaceSearchResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetFaceSearch(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetFaceSearch(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetFaceSearchTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetFaceSearchRequest>();

            var response = InstantiateClassGenerator.Execute<GetFaceSearchResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetFaceSearch(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetFaceSearch(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetLabelDetectionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetLabelDetectionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetLabelDetectionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetLabelDetectionResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetLabelDetection(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetLabelDetection(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetLabelDetectionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetLabelDetectionRequest>();

            var response = InstantiateClassGenerator.Execute<GetLabelDetectionResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetLabelDetection(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetLabelDetection(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetPersonTrackingTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetPersonTrackingRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetPersonTrackingResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetPersonTrackingResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetPersonTracking(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetPersonTracking(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetPersonTrackingTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetPersonTrackingRequest>();

            var response = InstantiateClassGenerator.Execute<GetPersonTrackingResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetPersonTracking(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetPersonTracking(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetSegmentDetectionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetSegmentDetectionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetSegmentDetectionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetSegmentDetectionResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetSegmentDetection(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetSegmentDetection(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetSegmentDetectionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetSegmentDetectionRequest>();

            var response = InstantiateClassGenerator.Execute<GetSegmentDetectionResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetSegmentDetection(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetSegmentDetection(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void GetTextDetectionTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<GetTextDetectionRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<GetTextDetectionResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<GetTextDetectionResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.GetTextDetection(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.GetTextDetection(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void GetTextDetectionTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<GetTextDetectionRequest>();

            var response = InstantiateClassGenerator.Execute<GetTextDetectionResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.GetTextDetection(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.GetTextDetection(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void ListCollectionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListCollectionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListCollectionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListCollectionsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListCollections(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListCollections(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListCollectionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListCollectionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListCollectionsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListCollections(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListCollections(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
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
        [TestCategory("Rekognition")]
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
        [TestCategory("Rekognition")]
        public void ListDatasetLabelsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetLabelsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListDatasetLabelsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListDatasetLabelsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListDatasetLabels(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListDatasetLabels(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListDatasetLabelsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListDatasetLabelsRequest>();

            var response = InstantiateClassGenerator.Execute<ListDatasetLabelsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListDatasetLabels(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListDatasetLabels(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void ListFacesTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListFacesRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListFacesResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListFacesResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListFaces(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListFaces(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListFacesTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListFacesRequest>();

            var response = InstantiateClassGenerator.Execute<ListFacesResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListFaces(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListFaces(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        public void ListStreamProcessorsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamProcessorsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListStreamProcessorsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListStreamProcessorsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListStreamProcessors(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListStreamProcessors(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rekognition")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListStreamProcessorsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListStreamProcessorsRequest>();

            var response = InstantiateClassGenerator.Execute<ListStreamProcessorsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListStreamProcessors(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListStreamProcessors(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}