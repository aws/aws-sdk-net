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
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;


namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for CreatePresignedPost functionality
    /// </summary>
    [TestClass]
    public class CreatePresignedPostTests : TestBase<AmazonS3Client>
    {
        // Test result classes for better structure
        private class UploadResult
        {
            public bool IsSuccessful { get; set; }
            public HttpStatusCode StatusCode { get; set; }
            public string ResponseText { get; set; }
        }

        private const string TestContent = "This is the content body!";
        private const string TestKey = "presigned-post-key";

        private class PresignedPostTestParameters
        {
            public RegionEndpoint Region { get; set; }
            public DateTime Expiration { get; set; }
            public string BucketName { get; set; }
            public Dictionary<string, string> Fields { get; set; }
            public List<S3PostCondition> Conditions { get; set; }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastUnder7Days()
        {
            TestPresignedPost(new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2)
            });

            TestPresignedPostWithSessionToken(new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(-2)
            });
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void USEastOver7Days()
        {
            // Unlike GetPreSignedUrl, CreatePresignedPost always uses SigV4 and should throw an exception for expirations > 7 days
            AssertExtensions.ExpectException(() =>
            {
                TestPresignedPost(new PresignedPostTestParameters
                {
                    Region = RegionEndpoint.USEast1,
                    Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2)
                });
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");

            AssertExtensions.ExpectException(() =>
            {
                TestPresignedPostWithSessionToken(new PresignedPostTestParameters
                {
                    Region = RegionEndpoint.USEast1,
                    Expiration = AWSSDKUtils.CorrectedUtcNow.AddDays(7).AddHours(2)
                });
            }, typeof(ArgumentException), "The maximum expiry period for a presigned url using AWS4 signing is 604800 seconds");
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void WithCustomConditions()
        {
            var testParams = new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                Fields = new Dictionary<string, string>
                {
                      // Include Content-Type in Fields even with a starts-with condition
                        // This matches JavaScript SDK behavior - fields and conditions can coexist
                     { "Content-Type", "text/plain" }
                },
                Conditions = new List<S3PostCondition>
                {
                    S3PostCondition.StartsWith("Content-Type", "text/"),
                    S3PostCondition.ContentLengthRange(1, 1048576) // 1 byte to 1 MB
                }
            };

            TestPresignedPostWithConditions(testParams);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void WithContentTypeFieldAndStartsWithCondition()
        {
            var testParams = new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1),
                Fields = new Dictionary<string, string>
                {
                    // Include Content-Type in Fields, matching JavaScript SDK behavior
                    { "Content-Type", "text/plain" },
                    { "success_action_status", "201" }
                },
                Conditions = new List<S3PostCondition>
                {
                    // Also add a starts-with condition for Content-Type
                    S3PostCondition.StartsWith("Content-Type", "text/"),
                    S3PostCondition.ContentLengthRange(1, 1048576) // 1 byte to 1 MB
                }
            };

            TestPresignedPostWithMixedContentType(testParams);
        }
        
        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("RequiresIAMUser")]
        public void FilenameVariableHandling()
        {
            var testParams = new PresignedPostTestParameters
            {
                Region = RegionEndpoint.USEast1,
                Expiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1)
            };

            TestPresignedPostWithFilenameVariable(testParams);
        }

        private void TestPresignedPost(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                // Create regular bucket
                testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                
                AssertPresignedPost(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }

        private void TestPresignedPostWithSessionToken(PresignedPostTestParameters testParams)
        {
            using (var sts = new Amazon.SecurityToken.AmazonSecurityTokenServiceClient())
            {
                AWSCredentials credentials = sts.GetSessionToken().Credentials;
                var client = new AmazonS3Client(credentials, testParams.Region);
                try
                {
                    // Create regular bucket
                    testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                    
                    AssertPresignedPost(client, testParams);
                }
                finally
                {
                    if (testParams.BucketName != null)
                        AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
                }
            }
        }

        private void TestPresignedPostWithFields(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                // Create regular bucket
                testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                
                AssertPresignedPostWithFields(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }

        private void TestPresignedPostWithConditions(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                // Create regular bucket
                testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                
                AssertPresignedPostWithConditions(client, testParams);
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }
        
        // Helper methods for creating and working with presigned POST URLs
        private CreatePresignedPostResponse GeneratePresignedPostRequest(
            AmazonS3Client client, 
            string bucketName, 
            string objectKey, 
            DateTime expiration,
            Dictionary<string, string> fields = null,
            List<S3PostCondition> conditions = null)
        {
            var request = new CreatePresignedPostRequest
            {
                BucketName = bucketName,
                Key = objectKey,
                Expires = expiration
            };

            // Add custom fields if provided
            if (fields != null)
            {
                foreach (var field in fields)
                {
                    request.Fields.Add(field.Key, field.Value);
                }
            }

            // Add conditions if provided
            if (conditions != null)
            {
                foreach (var condition in conditions)
                {
                    request.Conditions.Add(condition);
                }
            }

            return client.CreatePresignedPost(request);
        }

        // Validates that Content-Type field exists with expected value
        private void ValidateContentTypeFieldPresent(CreatePresignedPostResponse response, string expectedContentType)
        {
            Assert.IsTrue(response.Fields.ContainsKey("Content-Type"), 
                "Content-Type should be included in response fields even with a starts-with condition");
            Assert.AreEqual(expectedContentType, response.Fields["Content-Type"]);
        }

        // Performs an upload with valid Content-Type
        private UploadResult PerformUpload(
            string url, 
            Dictionary<string, string> fields, 
            string content, 
            string objectKey,
            string contentType)
        {
            var formData = new MultipartFormDataContent();

            // Add all form fields
            foreach (var field in fields)
            {
                formData.Add(new StringContent(field.Value), field.Key);
            }

            // Add file content with proper Content-Type
            var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
            formData.Add(fileContent, "file", objectKey);

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // Send the POST request
                var httpResponse = httpClient.PostAsync(url, formData).Result;
                
                return new UploadResult
                {
                    IsSuccessful = httpResponse.IsSuccessStatusCode,
                    StatusCode = httpResponse.StatusCode,
                    ResponseText = httpResponse.Content.ReadAsStringAsync().Result
                };
            }
        }

        // Validates that the object was uploaded correctly
        private void ValidateObjectContent(AmazonS3Client client, string bucketName, string objectKey, string expectedContent)
        {
            var getObjectResponse = client.GetObject(bucketName, objectKey);
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var content = reader.ReadToEnd();
                Assert.AreEqual(expectedContent, content, "Object content does not match expected content");
            }
        }

        // Performs an upload with invalid Content-Type to test condition enforcement
        private UploadResult PerformInvalidContentTypeUpload(
            string url,
            Dictionary<string, string> fields,
            string content,
            string objectKey)
        {
            var formData = new MultipartFormDataContent();
            
            // Add all fields from response
            foreach (var field in fields)
            {
                if (field.Key == "Content-Type")
                {
                    // Override Content-Type with an invalid one
                    formData.Add(new StringContent("image/jpeg"), field.Key);
                }
                else
                {
                    formData.Add(new StringContent(field.Value), field.Key);
                }
            }
            
            // Add file with invalid Content-Type header
            var invalidFileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
            invalidFileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
            formData.Add(invalidFileContent, "file", objectKey);
            
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var httpResponse = httpClient.PostAsync(url, formData).Result;
                
                return new UploadResult
                {
                    IsSuccessful = httpResponse.IsSuccessStatusCode,
                    StatusCode = httpResponse.StatusCode,
                    ResponseText = httpResponse.Content.ReadAsStringAsync().Result
                };
            }
        }

        private void TestPresignedPostWithMixedContentType(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                // Create regular bucket
                testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                
                // Create a unique object key
                string objectKey = TestKey + DateTime.UtcNow.Ticks;

                // Step 1: Generate presigned POST response
                var response = GeneratePresignedPostRequest(
                    client, 
                    testParams.BucketName, 
                    objectKey, 
                    testParams.Expiration,
                    testParams.Fields,
                    testParams.Conditions);
                
                // Step 2: Verify Content-Type field is included in response
                ValidateContentTypeFieldPresent(response, "text/plain");
                
                // Step 3: Perform upload with valid Content-Type
                var uploadResult = PerformUpload(
                    response.Url,
                    response.Fields,
                    TestContent,
                    objectKey,
                    "text/plain");
                
                // Step 4: Verify upload was successful
                Assert.IsTrue(uploadResult.IsSuccessful, 
                    $"Upload failed with status code {uploadResult.StatusCode}");
                
                // Step 5: Verify uploaded content
                ValidateObjectContent(client, testParams.BucketName, objectKey, TestContent);
                
                // Step 6: Clean up for next test
                client.DeleteObject(testParams.BucketName, objectKey);
                
                // Step 7: Test with invalid Content-Type
                var invalidResult = PerformInvalidContentTypeUpload(
                    response.Url,
                    response.Fields,
                    TestContent,
                    objectKey);
                
                // Step 8: Verify upload with invalid Content-Type was rejected
                Assert.AreEqual(HttpStatusCode.Forbidden, invalidResult.StatusCode,
                    "Upload with invalid Content-Type should be rejected");
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }

        private void AssertPresignedPost(AmazonS3Client client, PresignedPostTestParameters testParams)
        {
            string objectKey = TestKey + DateTime.UtcNow.Ticks;

            // Generate presigned POST response
            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            var response = client.CreatePresignedPost(request);

            // Verify required fields
            Assert.IsNotNull(response.Url);
            Assert.IsNotNull(response.Fields);
            Assert.IsTrue(response.Fields.ContainsKey("key"));
            Assert.IsTrue(response.Fields.ContainsKey("Policy"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-algorithm"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-credential"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-date"));
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-signature"));

            // Use the presigned post form to upload a file
            var formData = new MultipartFormDataContent();

            // Add all form fields
            foreach (var field in response.Fields)
            {
                formData.Add(new StringContent(field.Value), field.Key);
            }

            // Add file content
            formData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);

            // Create and configure the HttpClient
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // Send the POST request
                var httpResponse = httpClient.PostAsync(response.Url, formData).Result;
                
                // Verify the upload was successful
                Assert.AreEqual(HttpStatusCode.NoContent, httpResponse.StatusCode);
                
                // Verify the uploaded object exists and has the correct content
                var getObjectResponse = client.GetObject(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual(TestContent, content);
                }
            }
        }

        private void AssertPresignedPostWithFields(AmazonS3Client client, PresignedPostTestParameters testParams)
        {
            string objectKey = TestKey + DateTime.UtcNow.Ticks;

            // Generate presigned POST response
            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            // Add custom fields
            foreach (var field in testParams.Fields)
            {
                request.Fields.Add(field.Key, field.Value);
            }

            var response = client.CreatePresignedPost(request);

            // Verify all fields are present in the response
            foreach (var field in testParams.Fields)
            {
                Assert.IsTrue(response.Fields.ContainsKey(field.Key));
                Assert.AreEqual(field.Value, response.Fields[field.Key]);
            }

            // Use the presigned post form to upload a file
            var formData = new MultipartFormDataContent();

            // Add all form fields
            foreach (var field in response.Fields)
            {
                formData.Add(new StringContent(field.Value), field.Key);
            }

            // Add file content
            formData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);

            // Create and configure the HttpClient
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // Send the POST request
                var httpResponse = httpClient.PostAsync(response.Url, formData).Result;
                
                // Verify the upload was successful
                Assert.IsTrue(httpResponse.IsSuccessStatusCode);
                
                // Verify the uploaded object exists and has the correct content
                var getObjectResponse = client.GetObject(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual(TestContent, content);
                }

                if (testParams.Fields.ContainsKey("x-amz-meta-original-filename"))
                {
                    var headObjectResponse = client.GetObjectMetadata(testParams.BucketName, objectKey);

                    // Check if the metadata contains the key using the Keys collection
                    Assert.IsTrue(headObjectResponse.Metadata.Keys.Contains("original-filename"),
                                 "Metadata should contain 'original-filename'");
                    Assert.AreEqual(testParams.Fields["x-amz-meta-original-filename"],
                                    headObjectResponse.Metadata["original-filename"]);
                }

            }
        }

        private UploadResult PerformUploadWithActualFilename(
            string url, 
            Dictionary<string, string> fields, 
            string content,
            string filename)
        {
            var formData = new MultipartFormDataContent();

            foreach (var field in fields)
            {
                formData.Add(new StringContent(field.Value), field.Key);
            }

            // Add file content with the actual filename
            var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(content));
            fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/plain");
            formData.Add(fileContent, "file", filename);

            using (var httpClient = new System.Net.Http.HttpClient())
            {
                var httpResponse = httpClient.PostAsync(url, formData).Result;
                
                return new UploadResult
                {
                    IsSuccessful = httpResponse.IsSuccessStatusCode,
                    StatusCode = httpResponse.StatusCode,
                    ResponseText = httpResponse.Content.ReadAsStringAsync().Result
                };
            }
        }

        private void TestPresignedPostWithFilenameVariable(PresignedPostTestParameters testParams)
        {
            var client = new AmazonS3Client(testParams.Region);
            try
            {
                // Create test bucket
                testParams.BucketName = S3TestUtils.CreateBucketWithWait(client);
                
                // Create a presigned POST with key ending in ${filename}
                string keyPrefix = "uploads/";
                string objectKey = keyPrefix + "${filename}";
                string actualFilename = "test-file-" + DateTime.UtcNow.Ticks + ".txt";
                
                var response = GeneratePresignedPostRequest(
                    client, 
                    testParams.BucketName, 
                    objectKey, 
                    testParams.Expiration);
                
                // Verify policy contains starts-with condition
                var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
                var policyJson = Encoding.UTF8.GetString(policyBytes);
                var policyDoc = JsonDocument.Parse(policyJson);
                
                bool hasStartsWithCondition = false;
                foreach (var condition in policyDoc.RootElement.GetProperty("conditions").EnumerateArray())
                {
                    if (condition.ValueKind == JsonValueKind.Array && 
                        condition.GetArrayLength() == 3 && 
                        condition[0].GetString() == "starts-with" &&
                        condition[1].GetString() == "$key")
                    {
                        string foundPrefix = condition[2].GetString();
                        Assert.AreEqual(keyPrefix, foundPrefix, "Policy should contain starts-with condition with correct prefix");
                        hasStartsWithCondition = true;
                        break;
                    }
                }
                
                Assert.IsTrue(hasStartsWithCondition, "Policy should contain a starts-with condition for the key");
                
                // Perform upload with actual filename
                string expectedFinalKey = keyPrefix + actualFilename;
                var uploadResult = PerformUploadWithActualFilename(
                    response.Url,
                    response.Fields,
                    TestContent,
                    actualFilename);
                
                // Verify upload success
                Assert.IsTrue(uploadResult.IsSuccessful, $"Upload failed with status {uploadResult.StatusCode}: {uploadResult.ResponseText}");
                
                // Verify the object exists with the expected key (prefix + actual filename)
                try
                {
                    var objectMetadata = client.GetObjectMetadata(testParams.BucketName, expectedFinalKey);
                    Assert.IsNotNull(objectMetadata, "Object should exist with the expected key");
                    
                    // Verify content
                    var getObjectResponse = client.GetObject(testParams.BucketName, expectedFinalKey);
                    using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                    {
                        var content = reader.ReadToEnd();
                        Assert.AreEqual(TestContent, content, "Object content should match the uploaded content");
                    }
                }
                catch (AmazonS3Exception ex)
                {
                    Assert.Fail($"Failed to get object with key '{expectedFinalKey}': {ex.Message}");
                }
            }
            finally
            {
                if (testParams.BucketName != null)
                    AmazonS3Util.DeleteS3BucketWithObjects(client, testParams.BucketName);
            }
        }

        private void AssertPresignedPostWithConditions(AmazonS3Client client, PresignedPostTestParameters testParams)
        {
            string objectKey = TestKey + DateTime.UtcNow.Ticks;

            // Generate presigned POST response
            var request = new CreatePresignedPostRequest
            {
                BucketName = testParams.BucketName,
                Key = objectKey,
                Expires = testParams.Expiration
            };

            // Add custom fields
            foreach (var field in testParams.Fields)
            {
                request.Fields.Add(field.Key, field.Value);
            }

            // Add conditions
            foreach (var condition in testParams.Conditions)
            {
                request.Conditions.Add(condition);
            }

            var response = client.CreatePresignedPost(request);

            // Use the presigned post form to upload a file that meets the conditions
            var validFormData = new MultipartFormDataContent();

            // Add all form fields
            foreach (var field in response.Fields)
            {
                validFormData.Add(new StringContent(field.Value), field.Key);
            }

            // Check if we have a Content-Type starts-with condition
            var contentTypeCondition = testParams.Conditions.FirstOrDefault(c => c is StartsWithCondition && 
                ((StartsWithCondition)c).FieldName == "Content-Type") as StartsWithCondition;

            // Add file content that meets conditions
            if (contentTypeCondition != null)
            {
                // With JavaScript-like behavior, explicitly set Content-Type for uploads with starts-with conditions
                var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent));
                
                // Use a Content-Type that satisfies the starts-with condition
                string contentTypeToUse = "text/plain"; // Default for our tests that use text/ prefix
                fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentTypeToUse);
                
                // Also add Content-Type as a form field if it's not already in response.Fields
                if (!response.Fields.ContainsKey("Content-Type"))
                {
                    validFormData.Add(new StringContent(contentTypeToUse), "Content-Type");
                }
                
                validFormData.Add(fileContent, "file", objectKey);
            }
            else
            {
                // Standard file upload without special Content-Type handling
                validFormData.Add(new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent)), "file", objectKey);
            }

            // Create and configure the HttpClient
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                // Send the valid POST request
                var validResponse = httpClient.PostAsync(response.Url, validFormData).Result;
                
                // Verify the upload was successful
                Assert.IsTrue(validResponse.IsSuccessStatusCode);
                
                // Verify the uploaded object exists and has the correct content
                var getObjectResponse = client.GetObject(testParams.BucketName, objectKey);
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual(TestContent, content);
                }

                // Delete the object for the next test
                client.DeleteObject(testParams.BucketName, objectKey);

                // Test a violation of the Content-Type condition if present
                var invalidContentTypeCondition = testParams.Conditions.FirstOrDefault(c => c is StartsWithCondition && 
                   ((StartsWithCondition)c).FieldName == "Content-Type") as StartsWithCondition;
                   
                if (invalidContentTypeCondition != null)
                {
                    // Create new form data with invalid Content-Type
                    var invalidFormData = new MultipartFormDataContent();
                    
                    // Add all fields from response
                    foreach (var field in response.Fields)
                    {
                        invalidFormData.Add(new StringContent(field.Value), field.Key);
                    }
                    
                    // Manually add a Content-Type that violates the condition
                    // Note: With JavaScript-like behavior, Content-Type might not be in response.Fields
                    // if there's a starts-with condition for it
                    invalidFormData.Add(new StringContent("image/jpeg"), "Content-Type");

                    // Add file content
                    var fileContent = new ByteArrayContent(Encoding.UTF8.GetBytes(TestContent));
                    fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    invalidFormData.Add(fileContent, "file", objectKey);
                    
                    // This request should fail with 403 Forbidden
                    var invalidResponse = httpClient.PostAsync(response.Url, invalidFormData).Result;
                    Assert.AreEqual(HttpStatusCode.Forbidden, invalidResponse.StatusCode);
                }

                // Test a violation of the content length range condition if present
                var contentLengthCondition = testParams.Conditions.FirstOrDefault(c => c is ContentLengthRangeCondition) as ContentLengthRangeCondition;
                if (contentLengthCondition != null && contentLengthCondition.MaximumLength < 10 * 1024 * 1024) // Only if max is reasonable
                {
                    // Create new form data with a file that exceeds max size
                    var oversizeFormData = new MultipartFormDataContent();
                    
                    // Add all fields
                    foreach (var field in response.Fields)
                    {
                        oversizeFormData.Add(new StringContent(field.Value), field.Key);
                    }

                    // Generate a file larger than the max size
                    var largeContent = new byte[contentLengthCondition.MaximumLength + 1024]; // Exceed by 1KB
                    new Random().NextBytes(largeContent);
                    
                    oversizeFormData.Add(new ByteArrayContent(largeContent), "file", objectKey);
                    
                    // This request should fail
                    var oversizeResponse = httpClient.PostAsync(response.Url, oversizeFormData).Result;
                    Assert.AreEqual(HttpStatusCode.BadRequest, oversizeResponse.StatusCode);
                }
            }
        }
    }
}
