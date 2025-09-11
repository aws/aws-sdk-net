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

using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CreatePresignedPostRequestTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void Constructor_InitializesPropertiesWithDefaults()
        {
            // Act
            var request = new CreatePresignedPostRequest();

            // Assert
            Assert.IsNull(request.BucketName);
            Assert.IsNull(request.Key);
            Assert.IsNotNull(request.Expires);
            Assert.IsNotNull(request.Fields);
            Assert.IsNotNull(request.Conditions);
            
            // Default expiration should be approximately 1 hour from now
            var expectedExpiration = AWSSDKUtils.CorrectedUtcNow.AddHours(1);
            var timeDifference = Math.Abs((request.Expires.Value - expectedExpiration).TotalMinutes);
            Assert.IsTrue(timeDifference < 1, "Default expiration should be approximately 1 hour from now");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Constructor_InitializesEmptyCollections()
        {
            // Act
            var request = new CreatePresignedPostRequest();

            // Assert
            Assert.AreEqual(0, request.Fields.Count);
            Assert.AreEqual(0, request.Conditions.Count);
            
            // Verify collections are modifiable
            request.Fields.Add("test", "value");
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "public-read"));
            
            Assert.AreEqual(1, request.Fields.Count);
            Assert.AreEqual(1, request.Conditions.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void BucketName_Property_GetSetWorks()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();
            string bucketName = "test-bucket";

            // Act
            request.BucketName = bucketName;

            // Assert
            Assert.AreEqual(bucketName, request.BucketName);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Key_Property_GetSetWorks()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();
            string key = "test-key.jpg";

            // Act
            request.Key = key;

            // Assert
            Assert.AreEqual(key, request.Key);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Expires_Property_GetSetWorks()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();
            var expires = DateTime.UtcNow.AddHours(2);

            // Act
            request.Expires = expires;

            // Assert
            Assert.AreEqual(expires, request.Expires);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_CanBeModified()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();

            // Act
            request.Fields["acl"] = "public-read";
            request.Fields["Content-Type"] = "image/jpeg";
            request.Fields["success_action_redirect"] = "https://example.com/success";

            // Assert
            Assert.AreEqual(3, request.Fields.Count);
            Assert.AreEqual("public-read", request.Fields["acl"]);
            Assert.AreEqual("image/jpeg", request.Fields["Content-Type"]);
            Assert.AreEqual("https://example.com/success", request.Fields["success_action_redirect"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Conditions_Property_CanBeModified()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();

            // Act
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "public-read"));
            request.Conditions.Add(S3PostCondition.StartsWith("key", "uploads/"));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(1024, 5242880));

            // Assert
            Assert.AreEqual(3, request.Conditions.Count);
            
            var exactMatch = request.Conditions[0] as ExactMatchCondition;
            var startsWith = request.Conditions[1] as StartsWithCondition;
            var contentLength = request.Conditions[2] as ContentLengthRangeCondition;
            
            Assert.IsNotNull(exactMatch);
            Assert.AreEqual("acl", exactMatch.FieldName);
            Assert.AreEqual("public-read", exactMatch.ExpectedValue);
            
            Assert.IsNotNull(startsWith);
            Assert.AreEqual("key", startsWith.FieldName);
            Assert.AreEqual("uploads/", startsWith.Prefix);
            
            Assert.IsNotNull(contentLength);
            Assert.AreEqual(1024, contentLength.MinimumLength);
            Assert.AreEqual(5242880, contentLength.MaximumLength);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreatePresignedPostRequest_CompleteExample_AllPropertiesWork()
        {
            // Arrange & Act
            var request = new CreatePresignedPostRequest
            {
                BucketName = "my-upload-bucket",
                Key = "uploads/photo.jpg",
                Expires = DateTime.UtcNow.AddMinutes(30)
            };

            request.Fields["acl"] = "public-read";
            request.Fields["Content-Type"] = "image/jpeg";
            request.Fields["success_action_status"] = "201";
            request.Fields["x-amz-meta-category"] = "photos";

            request.Conditions.Add(S3PostCondition.ExactMatch("bucket", "my-upload-bucket"));
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "public-read"));
            request.Conditions.Add(S3PostCondition.StartsWith("key", "uploads/"));
            request.Conditions.Add(S3PostCondition.StartsWith("Content-Type", "image/"));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(1024, 10485760));

            // Assert
            Assert.AreEqual("my-upload-bucket", request.BucketName);
            Assert.AreEqual("uploads/photo.jpg", request.Key);
            Assert.IsNotNull(request.Expires);
            
            Assert.AreEqual(4, request.Fields.Count);
            Assert.AreEqual("public-read", request.Fields["acl"]);
            Assert.AreEqual("image/jpeg", request.Fields["Content-Type"]);
            Assert.AreEqual("201", request.Fields["success_action_status"]);
            Assert.AreEqual("photos", request.Fields["x-amz-meta-category"]);
            
            Assert.AreEqual(5, request.Conditions.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_HandlesCaseSensitiveKeys()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();

            // Act
            request.Fields["Content-Type"] = "image/jpeg";
            request.Fields["content-type"] = "text/plain"; // Different case

            // Assert
            Assert.AreEqual(2, request.Fields.Count);
            Assert.AreEqual("image/jpeg", request.Fields["Content-Type"]);
            Assert.AreEqual("text/plain", request.Fields["content-type"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Property_HandlesSpecialCharacters()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();

            // Act
            request.Fields["x-amz-meta-title"] = "文档上传 - Document Upload";
            request.Fields["x-amz-meta-path"] = "folder/subfolder & more/file.txt";
            request.Fields["success_action_redirect"] = "https://example.com/success?id=123&type=upload";

            // Assert
            Assert.AreEqual(3, request.Fields.Count);
            Assert.AreEqual("文档上传 - Document Upload", request.Fields["x-amz-meta-title"]);
            Assert.AreEqual("folder/subfolder & more/file.txt", request.Fields["x-amz-meta-path"]);
            Assert.AreEqual("https://example.com/success?id=123&type=upload", request.Fields["success_action_redirect"]);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Conditions_Property_HandlesMultipleConditionTypes()
        {
            // Arrange
            var request = new CreatePresignedPostRequest();

            // Act - Add various condition types
            request.Conditions.Add(S3PostCondition.ExactMatch("bucket", "test-bucket"));
            request.Conditions.Add(S3PostCondition.ExactMatch("acl", "private"));
            request.Conditions.Add(S3PostCondition.StartsWith("key", "private/"));
            request.Conditions.Add(S3PostCondition.StartsWith("Content-Type", ""));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(0, 1048576));
            request.Conditions.Add(S3PostCondition.ContentLengthRange(1, 1));

            // Assert
            Assert.AreEqual(6, request.Conditions.Count);
            
            // Verify each condition type is preserved
            var exactMatches = request.Conditions.OfType<ExactMatchCondition>().ToList();
            var startsWiths = request.Conditions.OfType<StartsWithCondition>().ToList();
            var contentLengths = request.Conditions.OfType<ContentLengthRangeCondition>().ToList();
            
            Assert.AreEqual(2, exactMatches.Count);
            Assert.AreEqual(2, startsWiths.Count);
            Assert.AreEqual(2, contentLengths.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Request_InheritsFromAmazonWebServiceRequest()
        {
            // Arrange & Act
            var request = new CreatePresignedPostRequest();

            // Assert
            Assert.IsInstanceOfType(request, typeof(Amazon.Runtime.AmazonWebServiceRequest));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DefaultExpiration_IsReasonableValue()
        {
            // Arrange
            var beforeCreation = AWSSDKUtils.CorrectedUtcNow;
            
            // Act
            var request = new CreatePresignedPostRequest();
            
            // Assert
            var afterCreation = AWSSDKUtils.CorrectedUtcNow;
            
            // Default should be 1 hour from creation time
            Assert.IsTrue(request.Expires.Value > beforeCreation.AddMinutes(59));
            Assert.IsTrue(request.Expires.Value < afterCreation.AddMinutes(61));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Fields_Dictionary_IsNotSharedBetweenInstances()
        {
            // Arrange
            var request1 = new CreatePresignedPostRequest();
            var request2 = new CreatePresignedPostRequest();

            // Act
            request1.Fields["test"] = "value1";
            request2.Fields["test"] = "value2";

            // Assert
            Assert.AreEqual("value1", request1.Fields["test"]);
            Assert.AreEqual("value2", request2.Fields["test"]);
            Assert.AreEqual(1, request1.Fields.Count);
            Assert.AreEqual(1, request2.Fields.Count);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Conditions_List_IsNotSharedBetweenInstances()
        {
            // Arrange
            var request1 = new CreatePresignedPostRequest();
            var request2 = new CreatePresignedPostRequest();

            // Act
            request1.Conditions.Add(S3PostCondition.ExactMatch("acl", "public-read"));
            request2.Conditions.Add(S3PostCondition.ExactMatch("acl", "private"));

            // Assert
            Assert.AreEqual(1, request1.Conditions.Count);
            Assert.AreEqual(1, request2.Conditions.Count);
            
            var condition1 = request1.Conditions[0] as ExactMatchCondition;
            var condition2 = request2.Conditions[0] as ExactMatchCondition;
            
            Assert.AreEqual("public-read", condition1.ExpectedValue);
            Assert.AreEqual("private", condition2.ExpectedValue);
        }

        /// <summary>
        /// This test is to reproduce the GitHub issue https://github.com/aws/aws-sdk-net/issues/4003
        /// where a NRE was triggered due to assume the RegionEndpoint on the config always being set.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public async Task EnsureRegionFromServiceUrlIsUsed()
        {
            var endpoint = "https://s3.us-west-2.amazonaws.com";
            var bucket = "fooBucket";
            var credentials = new BasicAWSCredentials("accessKeyId", "secretKey");

            var config = new AmazonS3Config
            {
                ServiceURL = endpoint,
                ForcePathStyle = true
            };

            IAmazonS3 client = new AmazonS3Client(credentials, config);

            var req = new CreatePresignedPostRequest
            {
                Key = "potato",
                BucketName = bucket,
                Expires = DateTime.UtcNow.AddMinutes(60)
            };
            var res = await client.CreatePresignedPostAsync(req);
            Assert.IsTrue(res.Url.Contains("us-west-2"));
            var credentialField = res.Fields["x-amz-credential"];
            Assert.IsTrue(credentialField.Contains("us-west-2"));

            config.AuthenticationRegion = "us-west-1";
            client = new AmazonS3Client(credentials, config);

            req = new CreatePresignedPostRequest
            {
                Key = "potato",
                BucketName = bucket,
                Expires = DateTime.UtcNow.AddMinutes(60)
            };
            res = await client.CreatePresignedPostAsync(req);
            Assert.IsTrue(res.Url.Contains("us-west-2"));
            credentialField = res.Fields["x-amz-credential"];
            Assert.IsTrue(credentialField.Contains("us-west-1"));
        }
    }
}
