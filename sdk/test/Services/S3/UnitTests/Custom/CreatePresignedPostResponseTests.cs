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
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3.Util;
using Amazon.S3.Model;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CreatePresignedPostResponseTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void Constructor_InitializesPropertiesWithDefaults()
        {
            // Act
            var response = new CreatePresignedPostResponse();

            // Assert
            Assert.IsNull(response.Url);
            Assert.IsNotNull(response.Fields);
            Assert.AreEqual(0, response.Fields.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Constructor_InitializesEmptyFieldsDictionary()
        {
            // Act
            var response = new CreatePresignedPostResponse();

            // Assert
            Assert.IsNotNull(response.Fields);
            Assert.AreEqual(0, response.Fields.Count);
            
            // Verify dictionary is modifiable
            response.Fields.Add("test", "value");
            Assert.AreEqual(1, response.Fields.Count);
            Assert.AreEqual("value", response.Fields["test"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Url_Property_GetSetWorks()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();
            string url = "https://my-bucket.s3.amazonaws.com/";

            // Act
            response.Url = url;

            // Assert
            Assert.AreEqual(url, response.Url);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_CanBeModified()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();

            // Act
            response.Fields["key"] = "uploads/photo.jpg";
            response.Fields["policy"] = "eyJleHBpcmF0aW9uIjoiMjAyNC0wMS0wMVQwMDowMDowMFoiLCJjb25kaXRpb25zIjpbXX0=";
            response.Fields["x-amz-algorithm"] = "AWS4-HMAC-SHA256";
            response.Fields["x-amz-credential"] = "AKIAIOSFODNN7EXAMPLE/20240101/us-east-1/s3/aws4_request";
            response.Fields["x-amz-date"] = "20240101T000000Z";
            response.Fields["x-amz-signature"] = "signature-value";

            // Assert
            Assert.AreEqual(6, response.Fields.Count);
            Assert.AreEqual("uploads/photo.jpg", response.Fields["key"]);
            Assert.AreEqual("eyJleHBpcmF0aW9uIjoiMjAyNC0wMS0wMVQwMDowMDowMFoiLCJjb25kaXRpb25zIjpbXX0=", response.Fields["policy"]);
            Assert.AreEqual("AWS4-HMAC-SHA256", response.Fields["x-amz-algorithm"]);
            Assert.AreEqual("AKIAIOSFODNN7EXAMPLE/20240101/us-east-1/s3/aws4_request", response.Fields["x-amz-credential"]);
            Assert.AreEqual("20240101T000000Z", response.Fields["x-amz-date"]);
            Assert.AreEqual("signature-value", response.Fields["x-amz-signature"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_HandlesCaseSensitiveKeys()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();

            // Act
            response.Fields["Content-Type"] = "image/jpeg";
            response.Fields["content-type"] = "text/plain"; // Different case

            // Assert
            Assert.AreEqual(2, response.Fields.Count);
            Assert.AreEqual("image/jpeg", response.Fields["Content-Type"]);
            Assert.AreEqual("text/plain", response.Fields["content-type"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_HandlesSpecialCharacters()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();

            // Act
            response.Fields["key"] = "uploads/文档 & files/test.txt";
            response.Fields["x-amz-meta-title"] = "Document Upload - 文档上传";
            response.Fields["success_action_redirect"] = "https://example.com/success?id=123&status=uploaded";

            // Assert
            Assert.AreEqual(3, response.Fields.Count);
            Assert.AreEqual("uploads/文档 & files/test.txt", response.Fields["key"]);
            Assert.AreEqual("Document Upload - 文档上传", response.Fields["x-amz-meta-title"]);
            Assert.AreEqual("https://example.com/success?id=123&status=uploaded", response.Fields["success_action_redirect"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPostResponse_CompleteExample_AllPropertiesWork()
        {
            // Arrange & Act
            var response = new CreatePresignedPostResponse
            {
                Url = "https://my-upload-bucket.s3.us-east-1.amazonaws.com/"
            };

            response.Fields["key"] = "uploads/photo.jpg";
            response.Fields["acl"] = "public-read";
            response.Fields["Content-Type"] = "image/jpeg";
            response.Fields["policy"] = "eyJleHBpcmF0aW9uIjoiMjAyNC0wMS0wMVQwMDowMDowMFoiLCJjb25kaXRpb25zIjpbXX0=";
            response.Fields["x-amz-algorithm"] = "AWS4-HMAC-SHA256";
            response.Fields["x-amz-credential"] = "AKIAIOSFODNN7EXAMPLE/20240101/us-east-1/s3/aws4_request";
            response.Fields["x-amz-date"] = "20240101T000000Z";
            response.Fields["x-amz-signature"] = "signature-value";
            response.Fields["success_action_status"] = "201";

            // Assert
            Assert.AreEqual("https://my-upload-bucket.s3.us-east-1.amazonaws.com/", response.Url);
            Assert.AreEqual(9, response.Fields.Count);
            
            // Verify AWS signature fields
            Assert.AreEqual("AWS4-HMAC-SHA256", response.Fields["x-amz-algorithm"]);
            Assert.AreEqual("AKIAIOSFODNN7EXAMPLE/20240101/us-east-1/s3/aws4_request", response.Fields["x-amz-credential"]);
            Assert.AreEqual("20240101T000000Z", response.Fields["x-amz-date"]);
            Assert.AreEqual("signature-value", response.Fields["x-amz-signature"]);
            
            // Verify other fields
            Assert.AreEqual("uploads/photo.jpg", response.Fields["key"]);
            Assert.AreEqual("public-read", response.Fields["acl"]);
            Assert.AreEqual("image/jpeg", response.Fields["Content-Type"]);
            Assert.AreEqual("201", response.Fields["success_action_status"]);
            Assert.IsNotNull(response.Fields["policy"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Dictionary_IsNotSharedBetweenInstances()
        {
            // Arrange
            var response1 = new CreatePresignedPostResponse();
            var response2 = new CreatePresignedPostResponse();

            // Act
            response1.Fields["test"] = "value1";
            response2.Fields["test"] = "value2";

            // Assert
            Assert.AreEqual("value1", response1.Fields["test"]);
            Assert.AreEqual("value2", response2.Fields["test"]);
            Assert.AreEqual(1, response1.Fields.Count);
            Assert.AreEqual(1, response2.Fields.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Url_Property_HandlesVariousS3Endpoints()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();

            // Test various S3 endpoint formats
            var endpoints = new[]
            {
                "https://bucket-name.s3.amazonaws.com/",
                "https://bucket-name.s3.us-east-1.amazonaws.com/",
                "https://bucket-name.s3.eu-west-1.amazonaws.com/",
                "https://s3.amazonaws.com/bucket-name",
                "https://s3.us-west-2.amazonaws.com/bucket-name",
                "https://bucket-name.s3-accelerate.amazonaws.com/"
            };

            foreach (var endpoint in endpoints)
            {
                // Act
                response.Url = endpoint;

                // Assert
                Assert.AreEqual(endpoint, response.Url);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_HandlesAwsSignatureFields()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();

            // Act - Add all AWS signature-related fields
            response.Fields["policy"] = "base64-encoded-policy";
            response.Fields["x-amz-algorithm"] = "AWS4-HMAC-SHA256";
            response.Fields["x-amz-credential"] = "AKIAIOSFODNN7EXAMPLE/20240101/us-east-1/s3/aws4_request";
            response.Fields["x-amz-date"] = "20240101T000000Z";
            response.Fields["x-amz-signature"] = "calculated-signature";
            response.Fields["x-amz-security-token"] = "session-token-value";

            // Assert
            Assert.AreEqual(6, response.Fields.Count);
            Assert.AreEqual("base64-encoded-policy", response.Fields["policy"]);
            Assert.AreEqual("AWS4-HMAC-SHA256", response.Fields["x-amz-algorithm"]);
            Assert.AreEqual("AKIAIOSFODNN7EXAMPLE/20240101/us-east-1/s3/aws4_request", response.Fields["x-amz-credential"]);
            Assert.AreEqual("20240101T000000Z", response.Fields["x-amz-date"]);
            Assert.AreEqual("calculated-signature", response.Fields["x-amz-signature"]);
            Assert.AreEqual("session-token-value", response.Fields["x-amz-security-token"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_HandlesS3SpecificFields()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();

            // Act - Add common S3 POST form fields
            response.Fields["key"] = "uploads/${filename}";
            response.Fields["acl"] = "private";
            response.Fields["Content-Type"] = "application/octet-stream";
            response.Fields["Content-Disposition"] = "attachment; filename=\"download.txt\"";
            response.Fields["Cache-Control"] = "max-age=3600";
            response.Fields["Expires"] = "Thu, 01 Jan 2025 00:00:00 GMT";
            response.Fields["success_action_status"] = "201";
            response.Fields["success_action_redirect"] = "https://example.com/success";
            response.Fields["x-amz-meta-category"] = "user-uploads";
            response.Fields["x-amz-meta-uploaded-by"] = "user123";
            response.Fields["x-amz-server-side-encryption"] = "AES256";
            response.Fields["x-amz-storage-class"] = "STANDARD_IA";

            // Assert
            Assert.AreEqual(12, response.Fields.Count);
            Assert.AreEqual("uploads/${filename}", response.Fields["key"]);
            Assert.AreEqual("private", response.Fields["acl"]);
            Assert.AreEqual("application/octet-stream", response.Fields["Content-Type"]);
            Assert.AreEqual("attachment; filename=\"download.txt\"", response.Fields["Content-Disposition"]);
            Assert.AreEqual("max-age=3600", response.Fields["Cache-Control"]);
            Assert.AreEqual("Thu, 01 Jan 2025 00:00:00 GMT", response.Fields["Expires"]);
            Assert.AreEqual("201", response.Fields["success_action_status"]);
            Assert.AreEqual("https://example.com/success", response.Fields["success_action_redirect"]);
            Assert.AreEqual("user-uploads", response.Fields["x-amz-meta-category"]);
            Assert.AreEqual("user123", response.Fields["x-amz-meta-uploaded-by"]);
            Assert.AreEqual("AES256", response.Fields["x-amz-server-side-encryption"]);
            Assert.AreEqual("STANDARD_IA", response.Fields["x-amz-storage-class"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Response_FieldsCanBeEnumerated()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();
            response.Fields["key1"] = "value1";
            response.Fields["key2"] = "value2";
            response.Fields["key3"] = "value3";

            // Act
            var keys = response.Fields.Keys.ToList();
            var values = response.Fields.Values.ToList();
            var pairs = response.Fields.ToList();

            // Assert
            Assert.AreEqual(3, keys.Count);
            Assert.AreEqual(3, values.Count);
            Assert.AreEqual(3, pairs.Count);
            
            Assert.IsTrue(keys.Contains("key1"));
            Assert.IsTrue(keys.Contains("key2"));
            Assert.IsTrue(keys.Contains("key3"));
            
            Assert.IsTrue(values.Contains("value1"));
            Assert.IsTrue(values.Contains("value2"));
            Assert.IsTrue(values.Contains("value3"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_SupportsNullAndEmptyValues()
        {
            // Arrange
            var response = new CreatePresignedPostResponse();

            // Act
            response.Fields["empty"] = "";
            response.Fields["null"] = null;
            response.Fields["whitespace"] = "   ";

            // Assert
            Assert.AreEqual(3, response.Fields.Count);
            Assert.AreEqual("", response.Fields["empty"]);
            Assert.IsNull(response.Fields["null"]);
            Assert.AreEqual("   ", response.Fields["whitespace"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Response_CanBeUsedForHtmlFormGeneration()
        {
            // Arrange - Create a realistic response that would be used to generate an HTML form
            var response = new CreatePresignedPostResponse
            {
                Url = "https://my-bucket.s3.amazonaws.com/"
            };

            response.Fields["key"] = "uploads/photo-${filename}";
            response.Fields["acl"] = "public-read";
            response.Fields["Content-Type"] = "image/jpeg";
            response.Fields["success_action_status"] = "201";
            response.Fields["policy"] = "eyJleHBpcmF0aW9uIjoiMjAyNC0wMS0wMVQwMDowMDowMFoiLCJjb25kaXRpb25zIjpbXX0=";
            response.Fields["x-amz-algorithm"] = "AWS4-HMAC-SHA256";
            response.Fields["x-amz-credential"] = "AKIAIOSFODNN7EXAMPLE/20240101/us-east-1/s3/aws4_request";
            response.Fields["x-amz-date"] = "20240101T000000Z";
            response.Fields["x-amz-signature"] = "calculated-signature";

            // Act - Verify this response contains everything needed for an HTML form
            var requiredFields = new[] { "key", "policy", "x-amz-algorithm", "x-amz-credential", "x-amz-date", "x-amz-signature" };
            var missingFields = requiredFields.Where(field => !response.Fields.ContainsKey(field)).ToList();

            // Assert
            Assert.IsNotNull(response.Url);
            Assert.IsTrue(response.Url.StartsWith("https://"));
            Assert.AreEqual(0, missingFields.Count, $"Missing required fields: {string.Join(", ", missingFields)}");
            Assert.IsTrue(response.Fields.Count >= 6, "Response should contain at least the required AWS fields");
        }
    }
}
