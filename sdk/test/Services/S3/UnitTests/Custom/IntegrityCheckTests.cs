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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class IntegrityCheckTests
    {
        public AmazonS3Config s3Config;

        [TestInitialize]
        public void Initialize()
        {
            s3Config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3Signer_Https_Request_DisablePayloadSigning_Is_True()
        {
            var request = TestS3Signer(true, "https://does_not_matter.com");
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonClientException))]
        public void TestS3Signer_Http_Request_DisablePayloadSigning_Is_True()
        {
            try
            {
                var request = TestS3Signer(true, "http://does_not_matter.com");
            }
            catch(AmazonClientException e)
            {
                Assert.AreEqual("When DisablePayloadSigning is true, the request must be sent over HTTPS.", e.Message);
                throw;
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_UploadPartRequestMarshaller_DisableDefaultChecksumValidation_Is_False()
        {
            var request = new UploadPartRequest
            {
                BucketName = "mybucketname",
                Key = "foo.txt",
                PartNumber = 1,
                DisableDefaultChecksumValidation = false,
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes("mystring"))
            };

            var internalRequest = RunMockRequest(request, UploadPartRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_UploadPartRequestMarshaller_DisableDefaultChecksumValidation_Is_True()
        {
            var request = new UploadPartRequest
            {
                BucketName = "mybucketname",
                Key = "foo.txt",
                PartNumber = 1,
                DisableDefaultChecksumValidation = true,
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes("mystring"))
            };

            var internalRequest = RunMockRequest(request, UploadPartRequestMarshaller.Instance);
            Assert.IsTrue(internalRequest.ContentStream is PartialWrapperStream);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3_UploadPartRequestMarshaller_DisablePayloadSigning_Is_True_UseChunkedEncoding_Is_False()
        {
            var request = new UploadPartRequest
            {
                BucketName = "mybucketname",
                Key = "foo.txt",
                PartNumber = 1,
                DisablePayloadSigning = true,
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes("mystring")),
                UseChunkEncoding = true,
            };

            var internalRequest = RunMockRequest(request, UploadPartRequestMarshaller.Instance);
            Assert.IsFalse(internalRequest.ContentStream is MD5Stream);
            Assert.IsFalse(internalRequest.UseChunkEncoding);
            Assert.IsTrue(internalRequest.DisablePayloadSigning.Value);
        }

        private IRequest TestS3Signer(bool? disablePayloadSigning, string url)
        {
            var signer = new Amazon.S3.Internal.S3Signer();
            var uploadPartRequest = new UploadPartRequest();
            var request = new DefaultRequest(uploadPartRequest, "s3")
            {
                Endpoint = new System.Uri(url),
                DisablePayloadSigning = disablePayloadSigning
            };
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest1
            };

            signer.Sign(request, config, new RequestMetrics(), new BasicAWSCredentials("ACCESS", "SECRET"));
            return request;
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller)
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };

            return RunMockRequest(request, marshaller, config);
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, AmazonS3Config config)
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

            var requestContext = new RequestContext(config.LogMetrics, new AWS4Signer())
            {
                ClientConfig = config,
                Marshaller = marshaller,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false
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