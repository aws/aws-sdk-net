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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet.UnitTests;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.Runtime.EventStreams;

#if NETFRAMEWORK
namespace AWSSDK.UnitTests
{
    [TestClass]
    public class UnmarshallerTests : RuntimePipelineTestBase<Unmarshaller>
    {
        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            Handler = new Unmarshaller(true);
            RuntimePipeline.AddHandler(Handler);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestListBucketsResponseUnmarshallingException200OK()
        {
            Tester.Reset();

            var context = CreateTestContext();
            var request = new ListBucketsRequest();
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new ListBucketsRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = new ListBucketsResponseUnmarshaller();

            var response = MockWebResponse.CreateFromResource("MalformedResponse.txt")
                as HttpWebResponse;
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            try
            {
                RuntimePipeline.InvokeSync(context);
                Assert.Fail();
            }
            catch (AmazonUnmarshallingException aue)
            {
                Assert.IsTrue(aue.Message.Contains("HTTP Status Code: 200 OK"));
                Assert.AreEqual(HttpStatusCode.OK, aue.StatusCode);
                Assert.IsNotNull(aue.InnerException);
                Assert.AreEqual("Data at the root level is invalid. Line 1, position 1.", aue.InnerException.Message);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestJsonResponseUnmarshaller_UnmarshallResponse()
        {
            var fakeResponseData = new FakeResponseData();
            fakeResponseData.StatusCode = HttpStatusCode.OK;
            var unmarshaller = new BadJsonResponseUnmarshaller();
            var unmarshallerContext = new JsonUnmarshallerContext(new MemoryStream(), true, fakeResponseData);

            try
            {
                unmarshaller.UnmarshallResponse(unmarshallerContext);
                Assert.Fail();
            }
            catch (AmazonUnmarshallingException aue)
            {
                Assert.IsTrue(aue.Message.Contains("HTTP Status Code: 200 OK"));
                Assert.AreEqual(HttpStatusCode.OK, aue.StatusCode);
                Assert.IsNotNull(aue.InnerException);
                Assert.AreEqual("Error in Unmarshall", aue.InnerException.Message);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHttpErrorResponseExceptionHandler_HandleException()
        {
            var webResponseData = new WebResponseData();
            webResponseData.StatusCode = HttpStatusCode.ServiceUnavailable;

            var handler = new HttpErrorResponseExceptionHandler(Logger.GetLogger(GetType()));
            var context = CreateTestContext(null, new BadJsonResponseUnmarshaller());
            context.ResponseContext.Response = new AmazonWebServiceResponse();
            context.ResponseContext.Response.HttpStatusCode = HttpStatusCode.ServiceUnavailable;

            try
            {
                handler.Handle(context, new HttpErrorResponseException(webResponseData));
                Assert.Fail();
            }
            catch (AmazonUnmarshallingException aue)
            {
                Assert.IsTrue(aue.Message.Contains("HTTP Status Code: 503 ServiceUnavailable"));
                Assert.AreEqual(HttpStatusCode.ServiceUnavailable, aue.StatusCode);
                Assert.IsNotNull(aue.InnerException);
                Assert.AreEqual("Error in UnmarshallException", aue.InnerException.Message);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestListBucketsResponseUnmarshalling()
        {
            Tester.Reset();

            var context = CreateTestContext();
            var request = new ListBucketsRequest();
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new ListBucketsRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            var response = MockWebResponse.CreateFromResource("ListBucketsResponse.txt")
                as HttpWebResponse;
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            RuntimePipeline.InvokeSync(context);

            Assert.AreEqual(1, Tester.CallCount);
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(ListBucketsResponse));

            var listBucketsResponse = context.ResponseContext.Response as ListBucketsResponse;
            Assert.AreEqual(4, listBucketsResponse.Buckets.Count);
            Assert.AreEqual("-UUNhfhfx0J622sdKihbDfqEvIa94CkVQvcb4AGlNmRbpbInOTYXSA==", listBucketsResponse.ResponseMetadata.Metadata[HeaderKeys.XAmzCloudFrontIdHeader]);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void UnmarshallJsonWithForwardSlashes()
        {
            string json = @"{""/"": ""xyz"", ""the/name"": ""true"", ""name"": ""value""}";

            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(json), false, new WebResponseData());
            var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(
                StringUnmarshaller.Instance, StringUnmarshaller.Instance);
            var reader = new StreamingUtf8JsonReader(Utils.CreateStreamFromString(json));
            var result = unmarshaller.Unmarshall(context, ref reader);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("xyz", result["/"]);
            Assert.AreEqual("true", result["the/name"]);
            Assert.AreEqual("value", result["name"]);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\AsyncNetFramework")]
        public async Task TestListBucketsResponseUnmarshallingAsync()
        {
            Tester.Reset();

            var context = CreateTestContext();
            var request = new ListBucketsRequest();
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new ListBucketsRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            var response = MockWebResponse.CreateFromResource("ListBucketsResponse.txt")
                as HttpWebResponse;
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            var listBucketsResponse = await RuntimePipeline.InvokeAsync<ListBucketsResponse>(context);

            Assert.AreEqual(1, Tester.CallCount);
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(ListBucketsResponse));
            Assert.AreEqual(4, listBucketsResponse.Buckets.Count);
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHandlingHTMLErrorResponse()
        {
            string errorRepsonse = "<html><body>Error: <br> The Error Message</body></html>";
            var stream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(errorRepsonse));
            var responseData = new FakeResponseData { StatusCode = HttpStatusCode.BadGateway };

            XmlUnmarshallerContext context = new XmlUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new S3ErrorResponseUnmarshaller();
            S3ErrorResponse response = unmarshaller.Unmarshall(context);
            Assert.IsNotNull(response);
        }

        [TestMethod]
        [DataRow("x-amz-checksum-sha1", "e1AsOh9IyGCa4hLN+2Od7jlnP14=", CoreChecksumAlgorithm.SHA1)]
        [DataRow("x-amz-checksum-sha256", "ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=", CoreChecksumAlgorithm.SHA256)]
        [DataRow("x-amz-checksum-crc32", "i9aeUg==", CoreChecksumAlgorithm.CRC32)]
        public void TestGetObjectResponseValidChecksum(string header, string checksumValue, CoreChecksumAlgorithm expectedAlgorithm)
        {
            Tester.Reset();

            var context = CreateTestContext();
            var request = new GetObjectRequest
            { 
                BucketName = "foo", 
                Key = "bar",
                ChecksumMode =  ChecksumMode.ENABLED
            };

            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new GetObjectRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = GetObjectResponseUnmarshaller.Instance;

            var expectedResponseBody = "Hello world";
            var response = MockWebResponse.Create(HttpStatusCode.OK, new Dictionary<string, string>(), expectedResponseBody);
            response.Headers.Add("Content-Length", "11");
            response.Headers.Add(header,checksumValue);
            
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            RuntimePipeline.InvokeSync(context);

            Assert.AreEqual(1, Tester.CallCount);
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(GetObjectResponse));

            var getObjectResponse = context.ResponseContext.Response as GetObjectResponse;
            Assert.AreEqual(expectedAlgorithm, getObjectResponse.ResponseMetadata.ChecksumAlgorithm);
            Assert.AreEqual(ChecksumValidationStatus.PENDING_RESPONSE_READ, getObjectResponse.ResponseMetadata.ChecksumValidationStatus);

            // Read the stream to the end to finish checksum calcuation and validation
            // This implicitly asserts that the checksum is valid because an exception would be thrown otherwise
            var responseBody =  new StreamReader(getObjectResponse.ResponseStream).ReadToEnd();
            Assert.AreEqual(expectedResponseBody, responseBody);

            // Once the stream has been read to completion the status is updated from
            // PENDING_RESPONSE_READ to SUCCESSFUL.
            Assert.AreEqual(ChecksumValidationStatus.SUCCESSFUL, getObjectResponse.ResponseMetadata.ChecksumValidationStatus);
        }

        private GetObjectResponse InvokeGetObject(string header, string checksumValue, string expectedResponseBody)
        {
            Tester.Reset();

            var context = CreateTestContext();
            var request = new GetObjectRequest
            {
                BucketName = "foo",
                Key = "bar",
                ChecksumMode = ChecksumMode.ENABLED
            };

            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new GetObjectRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = GetObjectResponseUnmarshaller.Instance;

            var response = MockWebResponse.Create(HttpStatusCode.OK, new Dictionary<string, string>(), expectedResponseBody);
            response.Headers.Add("Content-Length", expectedResponseBody.Length.ToString());
            response.Headers.Add(header, checksumValue);

            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            RuntimePipeline.InvokeSync(context);

            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(GetObjectResponse));
            return context.ResponseContext.Response as GetObjectResponse;
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataRow("x-amz-checksum-sha1", "e1AsOh9IyGCa4hLN+2Od7jlnP14=")]
        [DataRow("x-amz-checksum-sha256", "ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=")]
        [DataRow("x-amz-checksum-crc32", "i9aeUg==")]
        public void TestGetObjectResponse_StatusBecomesSuccessful_AfterFullRead(string header, string checksumValue)
        {
            var getObjectResponse = InvokeGetObject(header, checksumValue, "Hello world");

            // Before the stream is read the validation is pending.
            Assert.AreEqual(ChecksumValidationStatus.PENDING_RESPONSE_READ, getObjectResponse.ResponseMetadata.ChecksumValidationStatus);

            new StreamReader(getObjectResponse.ResponseStream).ReadToEnd();

            // Reading to the end triggers checksum calculation and flips the status to SUCCESSFUL.
            Assert.AreEqual(ChecksumValidationStatus.SUCCESSFUL, getObjectResponse.ResponseMetadata.ChecksumValidationStatus);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataRow("x-amz-checksum-sha1", "invalid=")]
        [DataRow("x-amz-checksum-sha256", "invalid=")]
        [DataRow("x-amz-checksum-crc32", "invalid=")]
        public void TestGetObjectResponse_StatusBecomesInvalid_OnChecksumMismatch(string header, string checksumValue)
        {
            var getObjectResponse = InvokeGetObject(header, checksumValue, "Hello world");

            Assert.AreEqual(ChecksumValidationStatus.PENDING_RESPONSE_READ, getObjectResponse.ResponseMetadata.ChecksumValidationStatus);

            AmazonClientException exception = null;
            try
            {
                new StreamReader(getObjectResponse.ResponseStream).ReadToEnd();
            }
            catch (AmazonClientException e)
            {
                exception = e;
            }

            // A mismatch still throws, and now also records the status as INVALID.
            Assert.IsNotNull(exception);
            Assert.AreEqual("Expected hash not equal to calculated hash", exception.Message);
            Assert.AreEqual(ChecksumValidationStatus.INVALID, getObjectResponse.ResponseMetadata.ChecksumValidationStatus);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [DataRow("x-amz-checksum-crc32", "i9aeUg==")]
        public void TestGetObjectResponse_StatusBecomesNotValidated_WhenStreamNotFullyRead(string header, string checksumValue)
        {
            var getObjectResponse = InvokeGetObject(header, checksumValue, "Hello world");

            // Read only part of the body, then dispose. Because the stream was not read
            // to the end the checksum cannot be validated, so the status is reported as
            // NOT_VALIDATED (rather than left stale at PENDING_RESPONSE_READ) and no
            // exception is thrown.
            using (var stream = getObjectResponse.ResponseStream)
            {
                var buffer = new byte[5];
                stream.Read(buffer, 0, buffer.Length);
            }

            Assert.AreEqual(ChecksumValidationStatus.NOT_VALIDATED, getObjectResponse.ResponseMetadata.ChecksumValidationStatus);
        }

        [TestMethod]
        [DataRow("x-amz-checksum-sha1", "invalid=", CoreChecksumAlgorithm.SHA1)]
        [DataRow("x-amz-checksum-sha256", "invalid=", CoreChecksumAlgorithm.SHA256)]
        [DataRow("x-amz-checksum-crc32", "invalid=", CoreChecksumAlgorithm.CRC32)]
        public void TestGetObjectResponseInvalidChecksum_ThrowsException(string header, string checksumValue, CoreChecksumAlgorithm expectedAlgorithm)
        {
            Exception exception = null;
            try
            {
                TestGetObjectResponseValidChecksum(header, checksumValue, expectedAlgorithm);
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
            Assert.AreEqual(exception.Message, "Expected hash not equal to calculated hash");
        }

        public class FakeResponseData : IWebResponseData
        {
            public long ContentLength { get; set; }

            public string ContentType { get; set; }

            public bool IsSuccessStatusCode { get; set; }

            public IHttpResponseBody ResponseBody { get; set; }

            public HttpStatusCode StatusCode { get; set; }
            public Dictionary<string, IEventStreamHeader> EventHeaders { get; set; }

            public IEventStreamHeader GetEventStreamHeader(string headerName)
            {
                return null;
            }

            public string[] GetHeaderNames()
            {
                return new string[0];
            }

            public string GetHeaderValue(string headerName)
            {
                return null;
            }

            public bool IsEventHeaderPresent(string headerName)
            {
                return false;
            }

            public bool IsHeaderPresent(string headerName)
            {
                return false;
            }
        }

        private class BadJsonResponseUnmarshaller : JsonResponseUnmarshaller
        {
            public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext input)
            {
                throw new Exception("Error in Unmarshall");
            }

            public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext input, Exception innerException, HttpStatusCode statusCode)
            {
                throw new Exception("Error in UnmarshallException");
            }
        }

    }
}
#endif
