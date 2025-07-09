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
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CreatePresignedPostTests
    {
        private Mock<AWSCredentials> _mockCredentials;
        private AmazonS3Config _config;
        private AmazonS3Client _s3Client;

        [TestInitialize]
        public void Setup()
        {
            _mockCredentials = new Mock<AWSCredentials>();
            _config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };
            
            // Setup mock credentials to return test values
            var immutableCreds = new ImmutableCredentials("AKIAIOSFODNN7EXAMPLE", "test-secret-key", null);
            _mockCredentials.Setup(c => c.GetCredentials()).Returns(immutableCreds);
            _mockCredentials.Setup(c => c.GetCredentialsAsync()).ReturnsAsync(immutableCreds);

            // Create S3 client with mock credentials
            _s3Client = new AmazonS3Client(_mockCredentials.Object, _config);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _s3Client?.Dispose();
        }

        #region Validation Tests

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_NullRequest_ThrowsArgumentNullException()
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => 
                _s3Client.CreatePresignedPost(null));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_MissingBucketName_ThrowsArgumentException()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = null,
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => 
                _s3Client.CreatePresignedPost(request));
            Assert.IsTrue(exception.Message.Contains("BucketName"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_EmptyBucketName_ThrowsArgumentException()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => 
                _s3Client.CreatePresignedPost(request));
            Assert.IsTrue(exception.Message.Contains("BucketName"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_MissingExpires_ThrowsArgumentException()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = null
            };

            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() => 
                _s3Client.CreatePresignedPost(request));
            Assert.IsTrue(exception.Message.Contains("Expires"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_AccessPointArn_ThrowsAmazonS3Exception()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "arn:aws:s3:us-east-1:123456789012:accesspoint/my-access-point",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act & Assert
            var exception = Assert.ThrowsException<AmazonS3Exception>(() => 
                _s3Client.CreatePresignedPost(request));
            Assert.IsTrue(exception.Message.Contains("presigned POST does not support access points"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_MultiRegionAccessPointArn_ThrowsAmazonS3Exception()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "arn:aws:s3::123456789012:accesspoint:mfzwi23gnjvgw.mrap",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act & Assert
            var exception = Assert.ThrowsException<AmazonS3Exception>(() => 
                _s3Client.CreatePresignedPost(request));
            Assert.IsTrue(exception.Message.Contains("presigned POST does not support access points"));
        }

        #endregion

        #region Basic Functionality Tests

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_ValidRequest_ReturnsResponse()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "test-key.jpg",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Url);
            Assert.IsNotNull(response.Fields);
            Assert.IsTrue(response.Fields.Count > 0);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_WithCustomFields_IncludesCustomFields()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "test-key.jpg",
                Expires = DateTime.UtcNow.AddHours(1)
            };
            request.Fields["acl"] = "public-read";
            request.Fields["Content-Type"] = "image/jpeg";
            request.Fields["success_action_status"] = "201";

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.AreEqual("public-read", response.Fields["acl"]);
            Assert.AreEqual("image/jpeg", response.Fields["Content-Type"]);
            Assert.AreEqual("201", response.Fields["success_action_status"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_WithConditions_GeneratesValidPolicy()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "uploads/photo.jpg",
                Expires = DateTime.UtcNow.AddHours(1)
            };
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "public-read"));
            request.Conditions.Add(S3PostCondition.StartsWith("key", "uploads/"));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(1024, 5242880));

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsNotNull(response.Fields["Policy"]);
            
            // Decode and verify the policy
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            var policyDoc = JsonDocument.Parse(policyJson);
            
            var conditions = policyDoc.RootElement.GetProperty("conditions");
            Assert.IsTrue(conditions.GetArrayLength() > 3); // Should have bucket + custom conditions
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_UrlFormat_IsCorrect()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "my-test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsTrue(response.Url.Contains("my-test-bucket"));
            Assert.IsTrue(response.Url.StartsWith("https://") || response.Url.StartsWith("http://"));
        }

        #endregion

        #region Policy Document Tests

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_PolicyDocument_ContainsBucketCondition()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "policy-test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            
            Assert.IsTrue(policyJson.Contains("\"bucket\""));
            Assert.IsTrue(policyJson.Contains("\"policy-test-bucket\""));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_PolicyDocument_ContainsKeyCondition()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "uploads/specific-key.jpg",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            
            Assert.IsTrue(policyJson.Contains("\"key\""));
            Assert.IsTrue(policyJson.Contains("\"uploads/specific-key.jpg\""));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_PolicyDocument_ContainsExpiration()
        {
            // Arrange
            var expires = DateTime.UtcNow.AddHours(2);
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = expires
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            var policyDoc = JsonDocument.Parse(policyJson);
            
            var expiration = policyDoc.RootElement.GetProperty("expiration").GetString();
            Assert.IsNotNull(expiration);
            Assert.IsTrue(expiration.EndsWith("Z")); // Should be ISO 8601 UTC format
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_PolicyDocument_IncludesCustomConditions()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "private"));
            request.Conditions.Add(S3PostCondition.StartsWith("Content-Type", "image/"));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(100, 1000000));

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            
            // Verify exact match condition
            Assert.IsTrue(policyJson.Contains("\"acl\""));
            Assert.IsTrue(policyJson.Contains("\"private\""));
            
            // Verify starts-with condition
            Assert.IsTrue(policyJson.Contains("\"starts-with\""));
            Assert.IsTrue(policyJson.Contains("\"$Content-Type\""));
            Assert.IsTrue(policyJson.Contains("\"image/\""));
            
            // Verify content-length-range condition
            Assert.IsTrue(policyJson.Contains("\"content-length-range\""));
            Assert.IsTrue(policyJson.Contains("100"));
            Assert.IsTrue(policyJson.Contains("1000000"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_PolicyDocument_IncludesFormFields()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };
            request.Fields["success_action_status"] = "201";
            request.Fields["x-amz-meta-category"] = "photos";

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            
            Assert.IsTrue(policyJson.Contains("\"success_action_status\""));
            Assert.IsTrue(policyJson.Contains("\"201\""));
            Assert.IsTrue(policyJson.Contains("\"x-amz-meta-category\""));
            Assert.IsTrue(policyJson.Contains("\"photos\""));
        }

        #endregion

        #region AWS Signature Fields Tests

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_SignatureFields_AreCorrectFormat()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.AreEqual("AWS4-HMAC-SHA256", response.Fields["x-amz-algorithm"]);
            
            var credential = response.Fields["x-amz-credential"];
            Assert.IsTrue(credential.StartsWith("AKIAIOSFODNN7EXAMPLE/"));
            Assert.IsTrue(credential.Contains("/us-east-1/s3/aws4_request"));
            
            var date = response.Fields["x-amz-date"];
            Assert.IsTrue(date.EndsWith("Z"));
            Assert.AreEqual(16, date.Length); // Format: YYYYMMDDTHHMMSSZ
            
            Assert.IsNotNull(response.Fields["x-amz-signature"]);
            Assert.IsTrue(response.Fields["x-amz-signature"].Length > 10);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_WithSecurityToken_IncludesTokenField()
        {
            // Arrange
            var immutableCredsWithToken = new ImmutableCredentials("AKIAIOSFODNN7EXAMPLE", "test-secret-key", "security-token-123");
            _mockCredentials.Setup(c => c.GetCredentials()).Returns(immutableCredsWithToken);
            _mockCredentials.Setup(c => c.GetCredentialsAsync()).ReturnsAsync(immutableCredsWithToken);

            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsTrue(response.Fields.ContainsKey("x-amz-security-token"));
            Assert.AreEqual("security-token-123", response.Fields["x-amz-security-token"]);
        }

        #endregion

        #region Async Tests

        [TestMethod]
        [TestCategory("S3")]
        public async Task CreatePresignedPostAsync_ValidRequest_ReturnsResponse()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "async-test-key.jpg",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = await _s3Client.CreatePresignedPostAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Url);
            Assert.IsNotNull(response.Fields);
            Assert.IsTrue(response.Fields.Count > 0);
            Assert.AreEqual("async-test-key.jpg", response.Fields["key"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task CreatePresignedPostAsync_NullRequest_ThrowsArgumentNullException()
        {
            // Act & Assert
            await Assert.ThrowsExceptionAsync<ArgumentNullException>(() => 
                _s3Client.CreatePresignedPostAsync(null));
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task CreatePresignedPostAsync_MissingBucketName_ThrowsArgumentException()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = null,
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act & Assert
            var exception = await Assert.ThrowsExceptionAsync<ArgumentException>(() => 
                _s3Client.CreatePresignedPostAsync(request));
            Assert.IsTrue(exception.Message.Contains("BucketName"));
        }

        #endregion

        #region Edge Cases and Error Handling

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_EmptyKey_HandledCorrectly()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "", // Empty key should be handled
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("", response.Fields["key"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_NullKey_HandledCorrectly()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = null, // Null key should be handled
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("", response.Fields["key"]); // Should default to empty string
        }

        #endregion

        #region Special Characters and Unicode Tests

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_SpecialCharactersInBucketAndKey_HandledCorrectly()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket-with-dashes",
                Key = "uploads/files with spaces & symbols/test.txt",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Url.Contains("test-bucket-with-dashes"));
            Assert.AreEqual("uploads/files with spaces & symbols/test.txt", response.Fields["key"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_UnicodeCharacters_HandledCorrectly()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "uploads/文档/测试文件.txt",
                Expires = DateTime.UtcNow.AddHours(1)
            };
            request.Fields["x-amz-meta-title"] = "测试文档 - Test Document";

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("uploads/文档/测试文件.txt", response.Fields["key"]);
            Assert.AreEqual("测试文档 - Test Document", response.Fields["x-amz-meta-title"]);
            
            // Verify policy document handles Unicode correctly
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            var policyDoc = JsonDocument.Parse(policyJson); // Should not throw for valid JSON
            Assert.IsNotNull(policyDoc);
        }

        #endregion

        #region Deduplication Tests

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_DuplicateFieldAndCondition_ShouldDeduplicateInPolicy()
        {
            // Arrange - Create a scenario with duplicate field and exact match condition
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "demo/photo.jpg",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            // Add ACL in both Fields and Conditions (should be deduplicated)
            request.Fields["acl"] = "public-read";
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "public-read"));
            
            // Add Content-Type in both Fields and Conditions (should be deduplicated)  
            request.Fields["Content-Type"] = "image/jpeg";
            request.Conditions.Add(S3PostCondition.ExactMatch("Content-Type", "image/jpeg"));
            
            // Add a non-duplicate condition (should remain)
            request.Conditions.Add(S3PostCondition.StartsWith("key", "demo/"));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(1024, 5242880));

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert - Verify response contains the fields
            Assert.AreEqual("public-read", response.Fields["acl"]);
            Assert.AreEqual("image/jpeg", response.Fields["Content-Type"]);

            // Assert - Verify policy document has no duplicates
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            var policyDoc = JsonDocument.Parse(policyJson);
            
            var conditions = policyDoc.RootElement.GetProperty("conditions");
            var conditionsList = new List<JsonElement>();
            foreach (var condition in conditions.EnumerateArray())
            {
                conditionsList.Add(condition);
            }

            // Count exact match conditions for ACL
            var aclConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Object && 
                c.TryGetProperty("acl", out var aclProp) && 
                aclProp.GetString() == "public-read");
            
            Assert.AreEqual(1, aclConditions, "Should have exactly one ACL condition (no duplicates)");

            // Count exact match conditions for Content-Type
            var contentTypeConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Object && 
                c.TryGetProperty("Content-Type", out var ctProp) && 
                ctProp.GetString() == "image/jpeg");
            
            Assert.AreEqual(1, contentTypeConditions, "Should have exactly one Content-Type condition (no duplicates)");

            // Verify non-duplicate conditions are still present
            var startsWithConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Array && 
                c.GetArrayLength() >= 3 &&
                c[0].GetString() == "starts-with" &&
                c[1].GetString() == "$key" &&
                c[2].GetString() == "demo/");
            
            Assert.AreEqual(1, startsWithConditions, "Should have exactly one starts-with condition");

            var contentLengthConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Array && 
                c.GetArrayLength() >= 3 &&
                c[0].GetString() == "content-length-range" &&
                c[1].GetInt64() == 1024 &&
                c[2].GetInt64() == 5242880);
            
            Assert.AreEqual(1, contentLengthConditions, "Should have exactly one content-length-range condition");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_FieldWithoutMatchingCondition_ShouldIncludeBoth()
        {
            // Arrange - Create fields that don't match conditions
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            request.Fields["acl"] = "public-read";
            request.Fields["Content-Type"] = "image/jpeg";
            
            // Add conditions that don't match the field values
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "private")); // Different value
            request.Conditions.Add(S3PostCondition.ExactMatch("x-amz-meta-test", "value")); // Different field

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            var policyDoc = JsonDocument.Parse(policyJson);
            
            var conditions = policyDoc.RootElement.GetProperty("conditions");
            var conditionsList = new List<JsonElement>();
            foreach (var condition in conditions.EnumerateArray())
            {
                conditionsList.Add(condition);
            }

            // Should have both ACL conditions since values are different
            var publicReadConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Object && 
                c.TryGetProperty("acl", out var aclProp) && 
                aclProp.GetString() == "public-read");
            
            var privateConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Object && 
                c.TryGetProperty("acl", out var aclProp) && 
                aclProp.GetString() == "private");

            Assert.AreEqual(1, publicReadConditions, "Should have public-read ACL condition from field");
            Assert.AreEqual(1, privateConditions, "Should have private ACL condition from condition");

            // Should have Content-Type condition from field (no matching condition)
            var contentTypeConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Object && 
                c.TryGetProperty("Content-Type", out var ctProp) && 
                ctProp.GetString() == "image/jpeg");
            
            Assert.AreEqual(1, contentTypeConditions, "Should have Content-Type condition from field");

            // Should have x-amz-meta-test condition from condition
            var metaTestConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Object && 
                c.TryGetProperty("x-amz-meta-test", out var metaProp) && 
                metaProp.GetString() == "value");
            
            Assert.AreEqual(1, metaTestConditions, "Should have x-amz-meta-test condition from condition");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_OnlyStartsWith_ShouldNotDeduplicate()
        {
            // Arrange - Ensure StartsWith conditions are never deduplicated
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Expires = DateTime.UtcNow.AddHours(1)
            };

            request.Fields["Content-Type"] = "image/jpeg";
            
            // Add StartsWith condition - should not be deduplicated even if field exists
            request.Conditions.Add(S3PostCondition.StartsWith("Content-Type", "image/"));

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            var policyDoc = JsonDocument.Parse(policyJson);
            
            var conditions = policyDoc.RootElement.GetProperty("conditions");
            var conditionsList = new List<JsonElement>();
            foreach (var condition in conditions.EnumerateArray())
            {
                conditionsList.Add(condition);
            }

            // Should have exact match condition from field
            var exactMatchConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Object && 
                c.TryGetProperty("Content-Type", out var ctProp) && 
                ctProp.GetString() == "image/jpeg");
            
            Assert.AreEqual(1, exactMatchConditions, "Should have exact match Content-Type condition from field");

            // Should have starts-with condition from condition
            var startsWithConditions = conditionsList.Count(c => 
                c.ValueKind == JsonValueKind.Array && 
                c.GetArrayLength() >= 3 &&
                c[0].GetString() == "starts-with" &&
                c[1].GetString() == "$Content-Type" &&
                c[2].GetString() == "image/");
            
            Assert.AreEqual(1, startsWithConditions, "Should have starts-with Content-Type condition from condition");
        }

        #endregion
        
        #region ${filename} Special Handling Tests
        
        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_KeyWithFilenameVariable_UsesStartsWithCondition()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "uploads/${filename}", // Key with ${filename}
                Expires = DateTime.UtcNow.AddHours(1)
            };
            
            // Act
            var response = _s3Client.CreatePresignedPost(request);
            
            // Decode and analyze the policy
            var policyJson = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(response.Fields["Policy"]));
            var policy = JsonDocument.Parse(policyJson);
            
            // Assert
            bool hasStartsWithCondition = false;
            
            foreach (var condition in policy.RootElement.GetProperty("conditions").EnumerateArray())
            {
                // Look for a starts-with condition for the key field
                if (condition.ValueKind == JsonValueKind.Array && 
                    condition.GetArrayLength() == 3 && 
                    condition[0].GetString() == "starts-with" &&
                    condition[1].GetString() == "$key")
                {
                    string keyPrefix = condition[2].GetString();
                    
                    // Verify that the key prefix is correct
                    Assert.AreEqual("uploads/", keyPrefix);
                    hasStartsWithCondition = true;
                    break;
                }
            }
            
            Assert.IsTrue(hasStartsWithCondition, "Policy should contain a starts-with condition for the key");
        }
        
        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_KeyWithoutFilenameVariable_UsesExactMatchCondition()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "uploads/regular-file.txt", // Regular key without ${filename}
                Expires = DateTime.UtcNow.AddHours(1)
            };
            
            // Act
            var response = _s3Client.CreatePresignedPost(request);
            
            // Decode and analyze the policy
            var policyJson = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(response.Fields["Policy"]));
            var policy = JsonDocument.Parse(policyJson);
            
            // Assert
            bool hasExactMatchCondition = false;
            
            foreach (var condition in policy.RootElement.GetProperty("conditions").EnumerateArray())
            {
                // Look for an exact match condition for the key field
                if (condition.ValueKind == JsonValueKind.Object && 
                    condition.TryGetProperty("key", out var keyValue))
                {
                    string key = keyValue.GetString();
                    
                    // Verify that the key is exactly what we specified
                    Assert.AreEqual("uploads/regular-file.txt", key);
                    hasExactMatchCondition = true;
                    break;
                }
            }
            
            Assert.IsTrue(hasExactMatchCondition, "Policy should contain an exact match condition for the key");
        }
        
        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_KeyWithFilenameVariableInMiddle_UsesExactMatchCondition()
        {
            // Arrange
            var request = new CreatePresignedPostRequest
            {
                BucketName = "test-bucket",
                Key = "uploads/${filename}/preview.jpg", // ${filename} not at the end
                Expires = DateTime.UtcNow.AddHours(1)
            };
            
            // Act
            var response = _s3Client.CreatePresignedPost(request);
            
            // Decode and analyze the policy
            var policyJson = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(response.Fields["Policy"]));
            var policy = JsonDocument.Parse(policyJson);
            
            // Assert
            bool hasExactMatchCondition = false;
            
            foreach (var condition in policy.RootElement.GetProperty("conditions").EnumerateArray())
            {
                // Look for an exact match condition for the key field
                if (condition.ValueKind == JsonValueKind.Object && 
                    condition.TryGetProperty("key", out var keyValue))
                {
                    string key = keyValue.GetString();
                    
                    // Verify that the key is exactly what we specified
                    Assert.AreEqual("uploads/${filename}/preview.jpg", key);
                    hasExactMatchCondition = true;
                    break;
                }
            }
            
            Assert.IsTrue(hasExactMatchCondition, "Policy should contain an exact match condition for the key");
        }

        #endregion

        #region Comprehensive Integration Test

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPost_ComplexScenario_GeneratesCompleteResponse()
        {
            // Arrange - Create a comprehensive scenario
            var request = new CreatePresignedPostRequest
            {
                BucketName = "my-photo-uploads",
                Key = "users/johndoe/photos/vacation-2024/beach.jpg",
                Expires = DateTime.UtcNow.AddMinutes(30)
            };

            // Add form fields
            request.Fields["acl"] = "public-read";
            request.Fields["Content-Type"] = "image/jpeg";
            request.Fields["success_action_status"] = "201";
            request.Fields["success_action_redirect"] = "https://myapp.com/upload-success";
            request.Fields["x-amz-meta-category"] = "vacation-photos";
            request.Fields["x-amz-meta-uploader"] = "johndoe";

            // Add policy conditions
            request.Conditions.Add(S3PostCondition.ExactMatch("bucket", "my-photo-uploads"));
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "public-read"));
            request.Conditions.Add(S3PostCondition.StartsWith("key", "users/johndoe/"));
            request.Conditions.Add(S3PostCondition.StartsWith("Content-Type", "image/"));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(1024, 10 * 1024 * 1024)); // 1KB to 10MB

            // Act
            var response = _s3Client.CreatePresignedPost(request);

            // Assert - Verify URL
            Assert.IsNotNull(response.Url);
            Assert.IsTrue(response.Url.Contains("my-photo-uploads"));

            // Assert - Verify required AWS fields
            Assert.AreEqual("users/johndoe/photos/vacation-2024/beach.jpg", response.Fields["key"]);
            Assert.AreEqual("AWS4-HMAC-SHA256", response.Fields["x-amz-algorithm"]);
            Assert.IsTrue(response.Fields["x-amz-credential"].StartsWith("AKIAIOSFODNN7EXAMPLE/"));
            Assert.IsNotNull(response.Fields["x-amz-date"]);
            Assert.IsNotNull(response.Fields["x-amz-signature"]);
            Assert.IsNotNull(response.Fields["Policy"]);

            // Assert - Verify custom fields
            Assert.AreEqual("public-read", response.Fields["acl"]);
            Assert.AreEqual("image/jpeg", response.Fields["Content-Type"]);
            Assert.AreEqual("201", response.Fields["success_action_status"]);
            Assert.AreEqual("https://myapp.com/upload-success", response.Fields["success_action_redirect"]);
            Assert.AreEqual("vacation-photos", response.Fields["x-amz-meta-category"]);
            Assert.AreEqual("johndoe", response.Fields["x-amz-meta-uploader"]);

            // Assert - Verify policy document contains all conditions
            var policyBytes = Convert.FromBase64String(response.Fields["Policy"]);
            var policyJson = System.Text.Encoding.UTF8.GetString(policyBytes);
            
            Assert.IsTrue(policyJson.Contains("\"my-photo-uploads\""));
            Assert.IsTrue(policyJson.Contains("\"users/johndoe/\""));
            Assert.IsTrue(policyJson.Contains("\"image/\""));
            Assert.IsTrue(policyJson.Contains("\"content-length-range\""));
            Assert.IsTrue(policyJson.Contains(1024.ToString()));
            Assert.IsTrue(policyJson.Contains((10 * 1024 * 1024).ToString()));

            // Assert - Total field count should be reasonable
            Assert.IsTrue(response.Fields.Count >= 11); // At least 6 AWS fields + 6 custom fields
        }

        #endregion
    }
}
