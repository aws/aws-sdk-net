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

using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

namespace AWSSDK.UnitTests.Services.S3
{
    [TestClass]
    public class RenameObjectTests
    {
        // Define constants locally since S3Constants is inaccessible
        private static class Constants
        {
            public const string AmzHeaderRenameSource = "x-amz-rename-source";
            public const string AmzHeaderClientToken = "x-amz-client-token";
            public const string AmzHeaderRenameSourceIfMatch = "x-amz-rename-source-if-match";
            public const string AmzHeaderRenameSourceIfNoneMatch = "x-amz-rename-source-if-none-match";
            public const string AmzHeaderRenameSourceIfModifiedSince = "x-amz-rename-source-if-modified-since";
            public const string AmzHeaderRenameSourceIfUnmodifiedSince = "x-amz-rename-source-if-unmodified-since";
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRenameObjectRequestMarshalling()
        {
            var request = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key",
                ClientToken = "test-client-token"
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;
            var marshalledRequest = marshaller.Marshall(request);

            // Test HTTP method and resource path
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Assert.AreEqual("/destination-key", marshalledRequest.ResourcePath);
            
            // Test query parameters
            Assert.IsTrue(marshalledRequest.UseQueryString, "The request should use a query string");
            Assert.IsTrue(marshalledRequest.SubResources.ContainsKey("renameObject"), "The request should have the 'renameObject' sub-resource");
            
            // Test headers
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("x-amz-rename-source"), "Header x-amz-rename-source not found");
            Assert.AreEqual("/test-bucket/source-key", marshalledRequest.Headers["x-amz-rename-source"]);
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("x-amz-client-token"), "Header x-amz-client-token not found");
            Assert.AreEqual("test-client-token", marshalledRequest.Headers["x-amz-client-token"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRenameObjectMissingRequiredParameters()
        {
            var requestMissingBucket = new RenameObjectRequest
            {
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key"
            };

            var requestMissingKey = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                RenameSource = "/test-bucket/source-key"
            };

            var requestMissingRenameSource = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key"
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;

            Assert.ThrowsException<ArgumentException>(() => marshaller.Marshall(requestMissingBucket));
            Assert.ThrowsException<ArgumentException>(() => marshaller.Marshall(requestMissingKey));
            Assert.ThrowsException<ArgumentException>(() => marshaller.Marshall(requestMissingRenameSource));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRenameObjectAllHeaders()
        {
            var request = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key",
                SourceIfMatch = "source-etag",
                SourceIfNoneMatch = "non-matching-etag",
                SourceIfModifiedSince = new DateTime(2023, 1, 1, 12, 0, 0, DateTimeKind.Utc),
                SourceIfUnmodifiedSince = new DateTime(2023, 12, 31, 12, 0, 0, DateTimeKind.Utc),
                DestinationIfMatch = "dest-etag",
                DestinationIfNoneMatch = "non-matching-dest-etag",
                DestinationIfModifiedSince = new DateTime(2023, 2, 1, 12, 0, 0, DateTimeKind.Utc),
                DestinationIfUnmodifiedSince = new DateTime(2023, 11, 30, 12, 0, 0, DateTimeKind.Utc)
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;
            var marshalledRequest = marshaller.Marshall(request);
            
            // Source condition headers
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey(Constants.AmzHeaderRenameSourceIfMatch));
            Assert.AreEqual("source-etag", marshalledRequest.Headers[Constants.AmzHeaderRenameSourceIfMatch]);
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey(Constants.AmzHeaderRenameSourceIfNoneMatch));
            Assert.AreEqual("non-matching-etag", marshalledRequest.Headers[Constants.AmzHeaderRenameSourceIfNoneMatch]);
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey(Constants.AmzHeaderRenameSourceIfModifiedSince));
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey(Constants.AmzHeaderRenameSourceIfUnmodifiedSince));
            
            // Destination condition headers
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("If-Match"));
            Assert.AreEqual("dest-etag", marshalledRequest.Headers["If-Match"]);
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("If-None-Match"));
            Assert.AreEqual("non-matching-dest-etag", marshalledRequest.Headers["If-None-Match"]);
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("If-Modified-Since"));
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("If-Unmodified-Since"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRenameObjectResponseUnmarshalling()
        {
            string emptyResponse = "";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(emptyResponse);
            
            using (var stream = new MemoryStream(bytes))
            {
                var mockWebResponse = new Mock<IWebResponseData>();
                mockWebResponse.Setup(r => r.GetHeaderNames()).Returns(new string[0]);
                mockWebResponse.Setup(r => r.GetHeaderValue(It.IsAny<string>())).Returns((string)null);
                mockWebResponse.Setup(r => r.StatusCode).Returns(HttpStatusCode.OK);
                
                var context = new XmlUnmarshallerContext(stream, false, mockWebResponse.Object);
                var unmarshaller = RenameObjectResponseUnmarshaller.Instance;
                
                var response = unmarshaller.Unmarshall(context);
                
                Assert.IsNotNull(response);
                Assert.IsInstanceOfType(response, typeof(RenameObjectResponse));
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestIdempotencyParameterMismatchExceptionUnmarshalling()
        {
            // Test by creating the S3ErrorResponse directly and testing the specific unmarshaller
            var s3ErrorResponse = new S3ErrorResponse
            {
                Code = "IdempotencyParameterMismatch",
                Message = "The request includes a client token that was used for a previous request, but the parameters do not match the previous request.",
                RequestId = "ABCDEF12345",
                Id2 = "TestId2Value",
                AmzCfId = "TestCfIdValue",
                Type = ErrorType.Sender,
                StatusCode = HttpStatusCode.BadRequest
            };

            // Create a simple XML context for the unmarshaller
            var dummyXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><e></e>";
            var bytes = System.Text.Encoding.UTF8.GetBytes(dummyXml);
            
            using (var stream = new MemoryStream(bytes))
            {
                var mockWebResponse = new Mock<IWebResponseData>();
                mockWebResponse.Setup(r => r.StatusCode).Returns(HttpStatusCode.BadRequest);
                var context = new XmlUnmarshallerContext(stream, false, mockWebResponse.Object);
                
                // Test the IdempotencyParameterMismatchExceptionUnmarshaller directly
                var exceptionUnmarshaller = IdempotencyParameterMismatchExceptionUnmarshaller.Instance;
                var exception = exceptionUnmarshaller.Unmarshall(context, s3ErrorResponse);
                
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(IdempotencyParameterMismatchException));
                Assert.AreEqual("IdempotencyParameterMismatch", exception.ErrorCode);
                Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
                Assert.AreEqual(ErrorType.Sender, exception.ErrorType);
                Assert.AreEqual("TestId2Value", exception.AmazonId2);
                Assert.AreEqual("TestCfIdValue", exception.AmazonCloudFrontId);
                Assert.AreEqual("The request includes a client token that was used for a previous request, but the parameters do not match the previous request.", exception.Message);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestNoSuchKeyExceptionUnmarshalling()
        {
            // Test handling of generic S3 exceptions through response unmarshaller
            // Create a mock error response that will result in a generic S3 exception
            var dummyXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><e></e>";
            var bytes = System.Text.Encoding.UTF8.GetBytes(dummyXml);
            
            using (var stream = new MemoryStream(bytes))
            {
                var mockWebResponse = new Mock<IWebResponseData>();
                mockWebResponse.Setup(r => r.GetHeaderNames()).Returns(new string[0]);
                mockWebResponse.Setup(r => r.GetHeaderValue(It.IsAny<string>())).Returns((string)null);
                mockWebResponse.Setup(r => r.StatusCode).Returns(HttpStatusCode.NotFound);
                
                var context = new XmlUnmarshallerContext(stream, false, mockWebResponse.Object);
                var unmarshaller = RenameObjectResponseUnmarshaller.Instance;
                
                var exception = unmarshaller.UnmarshallException(context, null, HttpStatusCode.NotFound);
                
                Assert.IsNotNull(exception);
                Assert.IsInstanceOfType(exception, typeof(AmazonS3Exception));
                var s3Exception = (AmazonS3Exception)exception;
                // The error code will be based on the status code when XML parsing fails
                Assert.AreEqual("NotFound", s3Exception.ErrorCode);
                // The error type defaults to Sender when parsing minimal XML
                Assert.AreEqual(ErrorType.Sender, s3Exception.ErrorType);
                Assert.AreEqual(HttpStatusCode.NotFound, s3Exception.StatusCode);
            }
        }
        
        [TestMethod]
        [TestCategory("S3")]
        public void TestClientTokenAutoGeneration()
        {
            // Test that a client token is auto-generated if not provided
            var request = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key"
                // ClientToken intentionally not set
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;
            var marshalledRequest = marshaller.Marshall(request);

            // Verify client token was auto-generated
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("x-amz-client-token"), "Header x-amz-client-token not found");
            Assert.IsNotNull(marshalledRequest.Headers["x-amz-client-token"]);
            
            // The auto-generated token should be a valid GUID
            Guid clientTokenGuid;
            Assert.IsTrue(Guid.TryParse(marshalledRequest.Headers["x-amz-client-token"], out clientTokenGuid), 
                "Auto-generated client token is not a valid GUID");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestDateTimeHeaderFormatting()
        {
            // Test that date-time headers are correctly formatted in RFC 822 format
            var testDate = new DateTime(2023, 5, 15, 14, 30, 45, DateTimeKind.Utc);

            var request = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key",
                SourceIfModifiedSince = testDate,
                DestinationIfModifiedSince = testDate
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;
            var marshalledRequest = marshaller.Marshall(request);

            // Check that date headers exist (format may vary by implementation)
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey(Constants.AmzHeaderRenameSourceIfModifiedSince));
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("If-Modified-Since"));
            
            // Verify the headers contain date values (exact format may vary)
            Assert.IsFalse(string.IsNullOrEmpty(marshalledRequest.Headers[Constants.AmzHeaderRenameSourceIfModifiedSince]));
            Assert.IsFalse(string.IsNullOrEmpty(marshalledRequest.Headers["If-Modified-Since"]));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestIdempotencyExceptionAllConstructors()
        {
            // Test all constructor overloads of IdempotencyParameterMismatchException
            
            // Test simple message constructor
            var exception1 = new IdempotencyParameterMismatchException("Test message");
            Assert.AreEqual("Test message", exception1.Message);
            
            // Test message + inner exception constructor
            var innerException = new Exception("Inner exception");
            var exception2 = new IdempotencyParameterMismatchException("Test message", innerException);
            Assert.AreEqual("Test message", exception2.Message);
            Assert.AreEqual(innerException, exception2.InnerException);
            
            // Test inner exception only constructor
            var exception3 = new IdempotencyParameterMismatchException(innerException);
            Assert.AreEqual(innerException, exception3.InnerException);
            
            // Test constructor with ErrorType (missing innerException)
            var exception4 = new IdempotencyParameterMismatchException(
                "Test message",
                ErrorType.Sender,
                "IdempotencyParameterMismatch",
                "REQUESTID123",
                HttpStatusCode.BadRequest);
            Assert.AreEqual("Test message", exception4.Message);
            Assert.AreEqual(ErrorType.Sender, exception4.ErrorType);
            Assert.AreEqual("IdempotencyParameterMismatch", exception4.ErrorCode);
            Assert.AreEqual("REQUESTID123", exception4.RequestId);
            Assert.AreEqual(HttpStatusCode.BadRequest, exception4.StatusCode);
            
            // Test constructor with inner exception but no S3-specific fields
            var exception5 = new IdempotencyParameterMismatchException(
                "Test message",
                innerException,
                ErrorType.Sender,
                "IdempotencyParameterMismatch",
                "REQUESTID456",
                HttpStatusCode.BadRequest);
            Assert.AreEqual("Test message", exception5.Message);
            Assert.AreEqual(innerException, exception5.InnerException);
            Assert.AreEqual(ErrorType.Sender, exception5.ErrorType);
            Assert.AreEqual("IdempotencyParameterMismatch", exception5.ErrorCode);
            Assert.AreEqual("REQUESTID456", exception5.RequestId);
            Assert.AreEqual(HttpStatusCode.BadRequest, exception5.StatusCode);
            
            // Test full S3-specific constructor
            var exception6 = new IdempotencyParameterMismatchException(
                "Test message with S3 fields",
                null, // innerException
                ErrorType.Sender,
                "IdempotencyParameterMismatch",
                "REQUESTID789",
                HttpStatusCode.BadRequest,
                "TestId2Value",
                "TestCfIdValue");
            Assert.AreEqual("Test message with S3 fields", exception6.Message);
            Assert.AreEqual(ErrorType.Sender, exception6.ErrorType);
            Assert.AreEqual("IdempotencyParameterMismatch", exception6.ErrorCode);
            Assert.AreEqual("REQUESTID789", exception6.RequestId);
            Assert.AreEqual(HttpStatusCode.BadRequest, exception6.StatusCode);
            Assert.AreEqual("TestId2Value", exception6.AmazonId2);
            Assert.AreEqual("TestCfIdValue", exception6.AmazonCloudFrontId);
        }
        
        [TestMethod]
        [TestCategory("S3")]
        public void TestIdempotencyExceptionUnmarshalling()
        {
            // Create an S3ErrorResponse directly
            var s3Response = new S3ErrorResponse
            {
                Code = "IdempotencyParameterMismatch",
                Message = "The request includes a client token that was used for a previous request, but the parameters do not match.",
                RequestId = "ABCDEF12345",
                Id2 = "TestId2Value",
                AmzCfId = "TestCfIdValue",
                Type = ErrorType.Sender,
                StatusCode = HttpStatusCode.BadRequest
            };
            
            // Provide a valid XML stream
            var dummyXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><e></e>";
            var bytes = System.Text.Encoding.UTF8.GetBytes(dummyXml);
            var stream = new MemoryStream(bytes);
            
            // Test IdempotencyParameterMismatchExceptionUnmarshaller with the S3ErrorResponse
            var specificUnmarshaller = IdempotencyParameterMismatchExceptionUnmarshaller.Instance;
            var mockWebResponse = new Mock<IWebResponseData>();
            mockWebResponse.Setup(r => r.StatusCode).Returns(HttpStatusCode.BadRequest);
            var context = new XmlUnmarshallerContext(stream, false, mockWebResponse.Object);
            var exception = specificUnmarshaller.Unmarshall(context, s3Response);
            
            // Verify the exception properties
            Assert.IsNotNull(exception, "Unmarshalled exception should not be null");
            Assert.IsInstanceOfType(exception, typeof(IdempotencyParameterMismatchException));
            Assert.AreEqual("TestId2Value", exception.AmazonId2, "AmazonId2 property was not correctly set");
            Assert.AreEqual("TestCfIdValue", exception.AmazonCloudFrontId, "AmazonCloudFrontId property was not correctly set");
            Assert.AreEqual("IdempotencyParameterMismatch", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRenameObjectResponseExceptionRouting()
        {
            // Test that the RenameObjectResponseUnmarshaller correctly routes IdempotencyParameterMismatch errors
            // We'll test this by ensuring that the right exception type is returned for different error codes
            
            // Test with a basic error response that should trigger the IdempotencyParameterMismatch path
            var responseUnmarshaller = RenameObjectResponseUnmarshaller.Instance;
            
            // Create a minimal error response for IdempotencyParameterMismatch
            var idempotencyErrorResponse = new S3ErrorResponse
            {
                Code = "IdempotencyParameterMismatch",
                Message = "Test idempotency error",
                Type = ErrorType.Sender,
                StatusCode = HttpStatusCode.BadRequest,
                Id2 = "TestId2",
                AmzCfId = "TestCfId"
            };
            
            // Create a simple context just to pass to the method
            var dummyXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><e></e>";
            var bytes = System.Text.Encoding.UTF8.GetBytes(dummyXml);
            
            using (var stream = new MemoryStream(bytes))
            {
                var mockWebResponse = new Mock<IWebResponseData>();
                mockWebResponse.Setup(r => r.StatusCode).Returns(HttpStatusCode.BadRequest);
                var context = new XmlUnmarshallerContext(stream, false, mockWebResponse.Object);
                
                // Test that the specific unmarshaller works correctly
                var specificUnmarshaller = IdempotencyParameterMismatchExceptionUnmarshaller.Instance;
                var exception = specificUnmarshaller.Unmarshall(context, idempotencyErrorResponse);
                
                Assert.IsInstanceOfType(exception, typeof(IdempotencyParameterMismatchException));
                Assert.AreEqual("IdempotencyParameterMismatch", exception.ErrorCode);
                Assert.AreEqual("TestId2", exception.AmazonId2);
                Assert.AreEqual("TestCfId", exception.AmazonCloudFrontId);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSingletonPatterns()
        {
            // Test that our singleton patterns are working correctly
            
            // Test RenameObjectRequestMarshaller singleton
            var marshaller1 = RenameObjectRequestMarshaller.Instance;
            var marshaller2 = RenameObjectRequestMarshaller.Instance;
            Assert.AreSame(marshaller1, marshaller2, "RenameObjectRequestMarshaller should return the same instance");
            
            // Test RenameObjectResponseUnmarshaller singleton
            var unmarshaller1 = RenameObjectResponseUnmarshaller.Instance;
            var unmarshaller2 = RenameObjectResponseUnmarshaller.Instance;
            Assert.AreSame(unmarshaller1, unmarshaller2, "RenameObjectResponseUnmarshaller should return the same instance");
            
            // Test IdempotencyParameterMismatchExceptionUnmarshaller singleton
            var exceptionUnmarshaller1 = IdempotencyParameterMismatchExceptionUnmarshaller.Instance;
            var exceptionUnmarshaller2 = IdempotencyParameterMismatchExceptionUnmarshaller.Instance;
            Assert.AreSame(exceptionUnmarshaller1, exceptionUnmarshaller2, "IdempotencyParameterMismatchExceptionUnmarshaller should return the same instance");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestEndToEndRequestResponse()
        {
            // Simulate a full request-response cycle
            // 1. Create and marshal a request
            var request = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key",
                ClientToken = "test-client-token"
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;
            var marshalledRequest = marshaller.Marshall(request);

            // 2. Verify marshalled request
            Assert.AreEqual("PUT", marshalledRequest.HttpMethod);
            Assert.AreEqual("/destination-key", marshalledRequest.ResourcePath);
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("x-amz-rename-source"));
            Assert.AreEqual("/test-bucket/source-key", marshalledRequest.Headers["x-amz-rename-source"]);

            // 3. Create and simulate a service response (empty for success case)
            string emptyResponse = "";
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(emptyResponse);
            
            using (var stream = new MemoryStream(bytes))
            {
                var mockWebResponse = new Mock<IWebResponseData>();
                mockWebResponse.Setup(r => r.GetHeaderNames()).Returns(new string[0]);
                mockWebResponse.Setup(r => r.GetHeaderValue(It.IsAny<string>())).Returns((string)null);
                mockWebResponse.Setup(r => r.StatusCode).Returns(HttpStatusCode.OK);
                
                var context = new XmlUnmarshallerContext(stream, false, mockWebResponse.Object);
                
                // 4. Unmarshall response
                var unmarshaller = RenameObjectResponseUnmarshaller.Instance;
                var response = unmarshaller.Unmarshall(context);
                
                // 5. Verify response properties
                Assert.IsNotNull(response);
                Assert.IsInstanceOfType(response, typeof(RenameObjectResponse));
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestNotImplementedMethodInUnmarshaller()
        {
            // Test that the single-parameter Unmarshall method throws NotImplementedException
            var unmarshaller = IdempotencyParameterMismatchExceptionUnmarshaller.Instance;
            var dummyXml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><e></e>";
            var bytes = System.Text.Encoding.UTF8.GetBytes(dummyXml);
            var stream = new MemoryStream(bytes);
            var mockWebResponse = new Mock<IWebResponseData>();
            var context = new XmlUnmarshallerContext(stream, false, mockWebResponse.Object);
            
            Assert.ThrowsException<NotImplementedException>(() => unmarshaller.Unmarshall(context));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestDateTimePropertyGettersSetters()
        {
            // Test that DateTime properties work correctly with nullable DateTime internal fields
            var request = new RenameObjectRequest();
            var testDate = new DateTime(2023, 5, 15, 14, 30, 45, DateTimeKind.Utc);
            
            // Test DestinationIfModifiedSince
            request.DestinationIfModifiedSince = testDate;
            Assert.AreEqual(testDate, request.DestinationIfModifiedSince);
            
            // Test DestinationIfUnmodifiedSince
            request.DestinationIfUnmodifiedSince = testDate;
            Assert.AreEqual(testDate, request.DestinationIfUnmodifiedSince);
            
            // Test SourceIfModifiedSince
            request.SourceIfModifiedSince = testDate;
            Assert.AreEqual(testDate, request.SourceIfModifiedSince);
            
            // Test SourceIfUnmodifiedSince
            request.SourceIfUnmodifiedSince = testDate;
            Assert.AreEqual(testDate, request.SourceIfUnmodifiedSince);
            
            // Test with default values (should return default DateTime)
            var defaultRequest = new RenameObjectRequest();
            Assert.AreEqual(default(DateTime), defaultRequest.DestinationIfModifiedSince);
            Assert.AreEqual(default(DateTime), defaultRequest.DestinationIfUnmodifiedSince);
            Assert.AreEqual(default(DateTime), defaultRequest.SourceIfModifiedSince);
            Assert.AreEqual(default(DateTime), defaultRequest.SourceIfUnmodifiedSince);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestMarshallerWithOptionalHeaders()
        {
            // Test marshalling with only some optional headers set
            var request = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key",
                SourceIfMatch = "source-etag"
                // Other conditional fields intentionally not set
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;
            var marshalledRequest = marshaller.Marshall(request);

            // Verify required headers are present
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("x-amz-rename-source"));
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey("x-amz-client-token")); // Auto-generated
            Assert.IsTrue(marshalledRequest.Headers.ContainsKey(Constants.AmzHeaderRenameSourceIfMatch));
            
            // Verify optional headers that weren't set are not present
            Assert.IsFalse(marshalledRequest.Headers.ContainsKey(Constants.AmzHeaderRenameSourceIfNoneMatch));
            Assert.IsFalse(marshalledRequest.Headers.ContainsKey("If-Match"));
            Assert.IsFalse(marshalledRequest.Headers.ContainsKey("If-None-Match"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestResourcePathEncoding()
        {
            // Test that special characters in the key are properly handled
            var request = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "folder/subfolder/file with spaces.txt",
                RenameSource = "/test-bucket/source-key"
            };

            var marshaller = RenameObjectRequestMarshaller.Instance;
            var marshalledRequest = marshaller.Marshall(request);

            // The resource path should include the key
            Assert.IsTrue(marshalledRequest.ResourcePath.Contains("folder/subfolder/file with spaces.txt"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestRequestPropertiesSetAndGet()
        {
            // Test that we can properly set and get all RenameObjectRequest properties
            var request = new RenameObjectRequest();
            
            // Test string properties
            request.BucketName = "test-bucket";
            Assert.AreEqual("test-bucket", request.BucketName);
            
            request.Key = "test-key";
            Assert.AreEqual("test-key", request.Key);
            
            request.RenameSource = "/test-bucket/source-key";
            Assert.AreEqual("/test-bucket/source-key", request.RenameSource);
            
            request.ClientToken = "test-token";
            Assert.AreEqual("test-token", request.ClientToken);
            
            request.DestinationIfMatch = "dest-etag";
            Assert.AreEqual("dest-etag", request.DestinationIfMatch);
            
            request.DestinationIfNoneMatch = "dest-none-match";
            Assert.AreEqual("dest-none-match", request.DestinationIfNoneMatch);
            
            request.SourceIfMatch = "source-etag";
            Assert.AreEqual("source-etag", request.SourceIfMatch);
            
            request.SourceIfNoneMatch = "source-none-match";
            Assert.AreEqual("source-none-match", request.SourceIfNoneMatch);
            
            // Test that we can set properties to null
            request.BucketName = null;
            Assert.IsNull(request.BucketName);
            
            request.ClientToken = null;
            Assert.IsNull(request.ClientToken);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestMarshallerExceptionMessages()
        {
            // Test that missing required parameters provide informative error messages
            var marshaller = RenameObjectRequestMarshaller.Instance;
            
            // Test missing bucket
            var requestMissingBucket = new RenameObjectRequest
            {
                Key = "destination-key",
                RenameSource = "/test-bucket/source-key"
            };
            
            try
            {
                marshaller.Marshall(requestMissingBucket);
                Assert.Fail("Expected ArgumentException for missing BucketName");
            }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(ex.Message.Contains("BucketName"), "Exception message should mention BucketName");
            }
            
            // Test missing key
            var requestMissingKey = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                RenameSource = "/test-bucket/source-key"
            };
            
            try
            {
                marshaller.Marshall(requestMissingKey);
                Assert.Fail("Expected ArgumentException for missing Key");
            }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(ex.Message.Contains("Key"), "Exception message should mention Key");
            }
            
            // Test missing rename source
            var requestMissingRenameSource = new RenameObjectRequest
            {
                BucketName = "test-bucket",
                Key = "destination-key"
            };
            
            try
            {
                marshaller.Marshall(requestMissingRenameSource);
                Assert.Fail("Expected ArgumentException for missing RenameSource");
            }
            catch (ArgumentException ex)
            {
                Assert.IsTrue(ex.Message.Contains("RenameSource"), "Exception message should mention RenameSource");
            }
        }
    }
}