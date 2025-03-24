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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3ExpressChecksumTests
    {
        private const string regularBucketName = "regularBucketName";
        private const string S3ExpressBucketName = "aws-sdk-net309281302--use1-az2--x-s3";

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_DeleteObjectsRequest_RegularBucket_Should_Use_ChecksumHeader()
        {
            var request = new DeleteObjectsRequest
            {
                BucketName = regularBucketName,
            };

            var internalRequest = RunMockRequest(request, DeleteObjectsRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k == HeaderKeys.ContentMD5Header));
            Assert.IsTrue(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("CHECKSUM")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_DeleteObjectsRequest_S3ExpressBucket_Should_Use_CRC32Checksum()
        {
            var request = new DeleteObjectsRequest
            {
                BucketName = S3ExpressBucketName,
            };

            var internalRequest = RunMockRequest(request, DeleteObjectsRequestMarshaller.Instance);
            Assert.IsTrue(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("CRC32")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_DeleteObjectsRequest_RegularBucket_ShouldUse_UserSpecifiedChecksumAlgorithm()
        {
            var request = new DeleteObjectsRequest
            {
                BucketName = regularBucketName,
                ChecksumAlgorithm = ChecksumAlgorithm.SHA256
            };

            var internalRequest = RunMockRequest(request, DeleteObjectsRequestMarshaller.Instance);
            Assert.IsTrue(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("SHA256")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_DeleteObjectsRequest_S3ExpressBucket_ShouldUse_UserSpecifiedChecksumAlgorithm()
        {
            var request = new DeleteObjectsRequest
            {
                BucketName = S3ExpressBucketName,
                ChecksumAlgorithm = ChecksumAlgorithm.SHA256
            };

            var internalRequest = RunMockRequest(request, DeleteObjectsRequestMarshaller.Instance);
            Assert.IsTrue(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("SHA256")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_PutObjectRequest_RegularBucket_DisableDefaultChecksumValidation_Is_True_Shouldnt_Use_MD5Stream_Nor_ChecksumHeader()
        {
            var request = new PutObjectRequest
            {
                BucketName = regularBucketName,
                Key = "foo.txt",
                ContentBody = "mystring",
                DisableDefaultChecksumValidation = true,
            };

            var internalRequest = RunMockRequest(request, PutObjectRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("CHECKSUM") || k == HeaderKeys.ContentMD5Header));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_PutObjectRequest_RegularBucket_Shouldnt_Use_MD5Stream()
        {
            var request = new PutObjectRequest
            {
                BucketName = regularBucketName,
                Key = "foo.txt",
                ContentBody = "mystring"
            };

            var internalRequest = RunMockRequest(request, PutObjectRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k == HeaderKeys.ContentMD5Header));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_PutObjectRequest_S3ExpressBucket_Should_Use_CRC32_TrailingHeaders()
        {
            var request = new PutObjectRequest
            {
                BucketName = S3ExpressBucketName,
                Key = "foo.txt",
                ContentBody = "mystring"
            };

            var internalRequest = RunMockRequest(request, PutObjectRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k == HeaderKeys.ContentMD5Header));
            Assert.IsTrue(internalRequest.TrailingHeaders.Keys.Any(k => k.ToUpper().Contains("CHECKSUM")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_PutObjectRequest_S3ExpressBucket_DisableDefaultChecksumValidation_Is_True_Shouldnt_Use_MD5Stream_Nor_ChecksumHeader()
        {
            var request = new PutObjectRequest
            {
                BucketName = S3ExpressBucketName,
                Key = "foo.txt",
                ContentBody = "mystring",
                DisableDefaultChecksumValidation = true,
            };

            var internalRequest = RunMockRequest(request, PutObjectRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("CHECKSUM") || k == HeaderKeys.ContentMD5Header));
            Assert.IsFalse(internalRequest.TrailingHeaders.Keys.Any(k => k.ToUpper().Contains("CHECKSUM") || k == HeaderKeys.ContentMD5Header));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_UploadPartRequest_RegularBucket_DisableDefaultChecksumValidation_Is_True_Shouldnt_Use_MD5Stream_Nor_ChecksumHeader()
        {
            var request = new UploadPartRequest
            {
                BucketName = regularBucketName,
                Key = "foo.txt",
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes("mystring")),
                DisableDefaultChecksumValidation = true,
            };

            var internalRequest = RunMockRequest(request, UploadPartRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("CHECKSUM") || k == HeaderKeys.ContentMD5Header));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_UploadPartRequest_RegularBucket_Should_Use_ChecksumHeader()
        {
            var request = new UploadPartRequest
            {
                BucketName = regularBucketName,
                Key = "foo.txt",
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes("mystring"))
            };

            var internalRequest = RunMockRequest(request, UploadPartRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k == HeaderKeys.ContentMD5Header));
            Assert.IsTrue(internalRequest.TrailingHeaders.Keys.Any(k => k.ToUpper().Contains("CHECKSUM")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_UploadPartRequest_S3ExpressBucket_Should_Use_ChecksumHeader()
        {
            var request = new UploadPartRequest
            {
                BucketName = S3ExpressBucketName,
                Key = "foo.txt",
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes("mystring"))
            };

            var internalRequest = RunMockRequest(request, UploadPartRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k == HeaderKeys.ContentMD5Header));
            Assert.IsTrue(internalRequest.TrailingHeaders.Keys.Any(k => k.ToUpper().Contains("CHECKSUM")));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_InitiateMultipartUploadRequest_S3ExpressBucket_Shouldnt_Use_Checksum()
        {
            var request = new InitiateMultipartUploadRequest
            {
                BucketName = S3ExpressBucketName,
                Key = "foo.txt",
            };

            var internalRequest = RunMockRequest(request, InitiateMultipartUploadRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("CHECKSUM") || k == HeaderKeys.ContentMD5Header));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_CompleteMultipartUploadRequest_S3ExpressBucket_Shouldnt_Use_Checksum()
        {
            var request = new CompleteMultipartUploadRequest
            {
                BucketName = S3ExpressBucketName,
                Key = "foo.txt",
            };

            var internalRequest = RunMockRequest(request, CompleteMultipartUploadRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.Headers.Keys.Any(k => k.ToUpper().Contains("CHECKSUM") || k == HeaderKeys.ContentMD5Header));
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller)
        {
            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                new S3ArnTestUtils.NoopPipelineHandler(),
                new ChecksumHandler(),
                new CompressionHandler(),
                new AmazonS3PostMarshallHandler(),
                new AmazonS3EndpointResolver(),
                new AmazonS3AuthSchemeHandler(),
                new Marshaller(),
                new AmazonS3PreMarshallHandler(),
            });

            var requestContext = new RequestContext(false, new AWS4Signer())
            {
                ClientConfig = new AmazonS3Config
                {
                    RegionEndpoint = RegionEndpoint.USEast1
                },
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false,
                Identity = new BasicAWSCredentials("access key", "secret"),
            };
            var executionContext = new ExecutionContext(
                requestContext,
                new ResponseContext()
            );

            pipeline.InvokeSync(executionContext);

            return requestContext.Request;
        }
    }
}