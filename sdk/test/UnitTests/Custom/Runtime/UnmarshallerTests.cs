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
using Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations;
using Amazon.ElasticMapReduce.Model;

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
            string jsonResponse = @"
            {
                ""Cluster"": {    
                    ""Configurations"": [                    
                        {
                            ""Classification"": ""value1"",
                            ""Properties"": {
                                ""/"": ""xyz""
                            }
                        },
                        {
                            ""Classification"": ""value2"",
                            ""Properties"": {
                                ""the/name"": ""true""
                            }
                        },
                        {
                            ""Classification"": ""value3"",
                            ""Properties"": {
                                ""name"": ""true""
                            }
                        },            
                    ]        
                }
            }";

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };

            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var unmarshaller = DescribeClusterResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context) as DescribeClusterResponse;
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Cluster);

            var configurations = response.Cluster.Configurations;
            Assert.IsNotNull(configurations);
            Assert.AreEqual(3, configurations.Count);
            Assert.IsTrue(configurations[0].Properties.ContainsKey("/"));
            Assert.IsTrue(configurations[1].Properties.ContainsKey("the/name"));
            Assert.IsTrue(configurations[2].Properties.ContainsKey("name"));
        }

#if BCL
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
#endif


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

            public string[] GetHeaderNames()
            {
                return new string[0];
            }

            public string GetHeaderValue(string headerName)
            {
                return null;
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
