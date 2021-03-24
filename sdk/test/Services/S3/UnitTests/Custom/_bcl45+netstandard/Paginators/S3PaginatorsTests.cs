using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using Amazon;
using Amazon.Util;
using Amazon.Runtime.Internal;
using Amazon.S3.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using Moq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using System.Linq;

namespace AWSSDK.UnitTests.S3.Net45.Custom
{
    [TestClass]
    public class S3PaginatorsTests
    {
        private static Mock<AmazonS3Client> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonS3Client>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        public void ListMultipartUploadsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListMultipartUploadsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListMultipartUploadsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListMultipartUploadsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListMultipartUploads(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListMultipartUploads(request);

            Assert.AreEqual(2, paginator.Responses.Count());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListMultipartUploadsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListMultipartUploadsRequest>();

            var response = InstantiateClassGenerator.Execute<ListMultipartUploadsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListMultipartUploads(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListMultipartUploads(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        public void ListObjectsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListObjectsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListObjectsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListObjects(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListObjects(request);

            Assert.AreEqual(2, paginator.Responses.Count());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListObjectsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectsRequest>();

            var response = InstantiateClassGenerator.Execute<ListObjectsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListObjects(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListObjects(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        public void ListObjectsV2Test_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectsV2Request>();

            var firstResponse = InstantiateClassGenerator.Execute<ListObjectsV2Response>();
            var secondResponse = InstantiateClassGenerator.Execute<ListObjectsV2Response>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListObjectsV2(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListObjectsV2(request);

            Assert.AreEqual(2, paginator.Responses.Count());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListObjectsV2Test__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListObjectsV2Request>();

            var response = InstantiateClassGenerator.Execute<ListObjectsV2Response>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListObjectsV2(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListObjectsV2(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        public void ListPartsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListPartsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListPartsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListPartsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListParts(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListParts(request);

            Assert.AreEqual(2, paginator.Responses.Count());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListPartsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListPartsRequest>();

            var response = InstantiateClassGenerator.Execute<ListPartsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListParts(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListParts(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        public void ListVersionsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListVersionsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListVersionsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListVersionsResponse>();
            secondResponse.IsTruncated = false;

            _mockClient.SetupSequence(x => x.ListVersions(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListVersions(request);

            Assert.AreEqual(2, paginator.Responses.Count());
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("S3")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListVersionsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListVersionsRequest>();

            var response = InstantiateClassGenerator.Execute<ListVersionsResponse>();
            response.IsTruncated = false;

            _mockClient.Setup(x => x.ListVersions(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListVersions(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }
    }
}