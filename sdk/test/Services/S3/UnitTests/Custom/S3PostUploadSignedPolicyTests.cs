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
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using Amazon.Runtime;
using Amazon.S3.Util;
using Amazon;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3PostUploadSignedPolicyTests
    {
        private S3PostUploadSignedPolicy CreateTestPolicy()
        {
            return new S3PostUploadSignedPolicy
            {
                Policy = "testPolicy123",
                Signature = "abc123signature",
                AccessKeyId = "AKIAIOSFODNN7EXAMPLE",
                SecurityToken = "security-token-value",
                Algorithm = "AWS4-HMAC-SHA256",
                Date = "20250630T120000Z",
                Credential = "AKIAIOSFODNN7EXAMPLE/20250630/us-west-1/s3/aws4_request"
            };
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ToJson_SerializesAllRequiredFields()
        {
            // Arrange
            var policy = CreateTestPolicy();
            string expectedPolicy = "testPolicy123";
            string expectedSignature = "abc123signature";
            string expectedAccessKey = "AKIAIOSFODNN7EXAMPLE";

            // Act
            var json = policy.ToJson();

            // Assert
            Assert.IsTrue(json.Contains(expectedPolicy), "JSON should contain the Policy value");
            Assert.IsTrue(json.Contains(expectedSignature), "JSON should contain the Signature value");
            Assert.IsTrue(json.Contains(expectedAccessKey), "JSON should contain the AccessKeyId value");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicyFromJson_DeserializesAllRequiredFields()
        {
            // Arrange
            var json = @"{""policy"":""testPolicy123"",""signature"":""abc123signature"",""access_key"":""AKIAIOSFODNN7EXAMPLE""}";

            // Act
            var policy = S3PostUploadSignedPolicy.GetSignedPolicyFromJson(json);

            // Assert
            Assert.AreEqual("testPolicy123", policy.Policy);
            Assert.AreEqual("abc123signature", policy.Signature);
            Assert.AreEqual("AKIAIOSFODNN7EXAMPLE", policy.AccessKeyId);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicyFromJson_ThrowsArgumentException_WhenJsonIsMalformed()
        {
            // Arrange
            var malformedJson = @"{""policy"":""testPolicy123"", BAD JSON HERE";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => 
                S3PostUploadSignedPolicy.GetSignedPolicyFromJson(malformedJson));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicyFromJson_ThrowsArgumentException_WhenRequiredFieldsAreMissing()
        {
            // Test missing Policy field
            var missingPolicy = @"{""signature"":""abc123signature"",""access_key"":""AKIAIOSFODNN7EXAMPLE""}";
            Assert.ThrowsException<ArgumentException>(() => 
                S3PostUploadSignedPolicy.GetSignedPolicyFromJson(missingPolicy));

            // Test missing Signature field
            var missingSignature = @"{""policy"":""testPolicy123"",""access_key"":""AKIAIOSFODNN7EXAMPLE""}";
            Assert.ThrowsException<ArgumentException>(() => 
                S3PostUploadSignedPolicy.GetSignedPolicyFromJson(missingSignature));

            // Test missing AccessKey field
            var missingAccessKey = @"{""policy"":""testPolicy123"",""signature"":""abc123signature""}";
            Assert.ThrowsException<ArgumentException>(() => 
                S3PostUploadSignedPolicy.GetSignedPolicyFromJson(missingAccessKey));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ToXml_SerializesAllProperties()
        {
            // Arrange
            var policy = CreateTestPolicy();

            // Act
            var xml = policy.ToXml();

            // Assert
            Assert.IsTrue(xml.Contains("<Policy>testPolicy123</Policy>"), "XML should contain the Policy element");
            Assert.IsTrue(xml.Contains("<Signature>abc123signature</Signature>"), "XML should contain the Signature element");
            Assert.IsTrue(xml.Contains("<AccessKeyId>AKIAIOSFODNN7EXAMPLE</AccessKeyId>"), "XML should contain the AccessKeyId element");
            Assert.IsTrue(xml.Contains("<SecurityToken>security-token-value</SecurityToken>"), "XML should contain the SecurityToken element");
            Assert.IsTrue(xml.Contains("<Algorithm>AWS4-HMAC-SHA256</Algorithm>"), "XML should contain the Algorithm element");
            Assert.IsTrue(xml.Contains("<Date>20250630T120000Z</Date>"), "XML should contain the Date element");
            Assert.IsTrue(xml.Contains("<Credential>AKIAIOSFODNN7EXAMPLE/20250630/us-west-1/s3/aws4_request</Credential>"), 
                "XML should contain the Credential element");
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicyFromXml_DeserializesAllProperties()
        {
            // Arrange
            var originalPolicy = CreateTestPolicy();
            var xml = originalPolicy.ToXml();

            // Act
            var deserializedPolicy = S3PostUploadSignedPolicy.GetSignedPolicyFromXml(xml);

            // Assert
            Assert.AreEqual(originalPolicy.Policy, deserializedPolicy.Policy);
            Assert.AreEqual(originalPolicy.Signature, deserializedPolicy.Signature);
            Assert.AreEqual(originalPolicy.AccessKeyId, deserializedPolicy.AccessKeyId);
            Assert.AreEqual(originalPolicy.SecurityToken, deserializedPolicy.SecurityToken);
            Assert.AreEqual(originalPolicy.Algorithm, deserializedPolicy.Algorithm);
            Assert.AreEqual(originalPolicy.Date, deserializedPolicy.Date);
            Assert.AreEqual(originalPolicy.Credential, deserializedPolicy.Credential);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicyFromXml_ThrowsArgumentException_WhenXmlIsMalformed()
        {
            // Arrange
            var malformedXml = "<S3PostUploadSignedPolicy><Policy>test</Malformed>";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => 
                S3PostUploadSignedPolicy.GetSignedPolicyFromXml(malformedXml));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicyFromXml_ThrowsArgumentException_WhenRequiredFieldsAreMissing()
        {
            // Create XML with missing fields
            var policyWithMissingFields = new S3PostUploadSignedPolicy
            {
                // Missing Signature and AccessKeyId
                Policy = "testPolicy123"
            };

            using (var sw = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(S3PostUploadSignedPolicy));
                serializer.Serialize(sw, policyWithMissingFields);
                var xml = sw.ToString();

                // Act & Assert
                Assert.ThrowsException<ArgumentException>(() => 
                    S3PostUploadSignedPolicy.GetSignedPolicyFromXml(xml));
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetReadablePolicy_ReturnsDecodedPolicy()
        {
            // Arrange
            var policy = new S3PostUploadSignedPolicy
            {
                Policy = Convert.ToBase64String(Encoding.UTF8.GetBytes("{\"policy\":\"content\"}"))
            };

            // Act
            var readablePolicy = policy.GetReadablePolicy();

            // Assert
            Assert.AreEqual("{\"policy\":\"content\"}", readablePolicy);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RoundTrip_JsonSerializationAndDeserialization_PreservesRequiredProperties()
        {
            // Arrange
            var originalPolicy = new S3PostUploadSignedPolicy
            {
                Policy = "testPolicy123",
                Signature = "abc123signature",
                AccessKeyId = "AKIAIOSFODNN7EXAMPLE"
            };

            // Act
            var json = originalPolicy.ToJson();
            var deserializedPolicy = S3PostUploadSignedPolicy.GetSignedPolicyFromJson(json);

            // Assert
            Assert.AreEqual(originalPolicy.Policy, deserializedPolicy.Policy);
            Assert.AreEqual(originalPolicy.Signature, deserializedPolicy.Signature);
            Assert.AreEqual(originalPolicy.AccessKeyId, deserializedPolicy.AccessKeyId);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RoundTrip_XmlSerializationAndDeserialization_PreservesAllProperties()
        {
            // Arrange
            var originalPolicy = CreateTestPolicy();

            // Act
            var xml = originalPolicy.ToXml();
            var deserializedPolicy = S3PostUploadSignedPolicy.GetSignedPolicyFromXml(xml);

            // Assert
            Assert.AreEqual(originalPolicy.Policy, deserializedPolicy.Policy);
            Assert.AreEqual(originalPolicy.Signature, deserializedPolicy.Signature);
            Assert.AreEqual(originalPolicy.AccessKeyId, deserializedPolicy.AccessKeyId);
            Assert.AreEqual(originalPolicy.SecurityToken, deserializedPolicy.SecurityToken);
            Assert.AreEqual(originalPolicy.Algorithm, deserializedPolicy.Algorithm);
            Assert.AreEqual(originalPolicy.Date, deserializedPolicy.Date);
            Assert.AreEqual(originalPolicy.Credential, deserializedPolicy.Credential);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicy_ReturnsValidSignedPolicy()
        {
            // Arrange
            var policy = @"{""expiration"":""2030-01-01T00:00:00Z"",""conditions"":[{""bucket"":""test-bucket""}]}";
            var creds = new Mock<AWSCredentials>();
            var region = RegionEndpoint.USWest1;
            var immutableCreds = new ImmutableCredentials("AKIAIOSFODNN7EXAMPLE", "test-secret-key", null);

            // Setup mock credentials to return known values
            creds.Setup(c => c.GetCredentials())
                .Returns(immutableCreds);

            // Act
            var signedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policy, creds.Object, region.SystemName);

            // Assert
            Assert.IsNotNull(signedPolicy);
            Assert.IsNotNull(signedPolicy.Policy);
            Assert.IsNotNull(signedPolicy.Signature);
            Assert.AreEqual("AKIAIOSFODNN7EXAMPLE", signedPolicy.AccessKeyId);
            Assert.AreEqual("AWS4-HMAC-SHA256", signedPolicy.Algorithm);
            Assert.IsNotNull(signedPolicy.Date);
            Assert.IsTrue(signedPolicy.Credential.StartsWith("AKIAIOSFODNN7EXAMPLE/"));
            Assert.IsTrue(signedPolicy.Credential.Contains("/us-west-1/s3/aws4_request"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicy_WithPolicyConditions_MaintainsConditions()
        {
            // Arrange - Create a comprehensive, realistic S3 POST policy
            var policy = @"{
  ""expiration"": ""2030-01-01T00:00:00Z"",
  ""conditions"": [
    {""bucket"": ""test-bucket""},
    {""acl"": ""public-read""},
    [""starts-with"", ""$key"", ""user/uploads/""],
    [""starts-with"", ""$Content-Type"", ""image/""],
    [""content-length-range"", 1024, 10485760],
    {""success_action_status"": ""201""},
    {""x-amz-meta-uuid"": ""${filename}""},
    [""starts-with"", ""$x-amz-meta-tag"", """"]
  ]
}";
            var creds = new Mock<AWSCredentials>();
            var region = RegionEndpoint.USWest1;
            var immutableCreds = new ImmutableCredentials("AKIAIOSFODNN7EXAMPLE", "test-secret-key", null);

            // Setup mock credentials
            creds.Setup(c => c.GetCredentials())
                .Returns(immutableCreds);

            // Act
            var signedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policy, creds.Object, region.SystemName);
            var decodedPolicy = signedPolicy.GetReadablePolicy();

            // Assert - Verify original conditions are preserved
            Assert.IsNotNull(signedPolicy);
            
            // Check that bucket and ACL are preserved
            Assert.IsTrue(decodedPolicy.Contains("\"bucket\""));
            Assert.IsTrue(decodedPolicy.Contains("\"test-bucket\""));
            Assert.IsTrue(decodedPolicy.Contains("\"acl\""));
            Assert.IsTrue(decodedPolicy.Contains("\"public-read\""));
            
            // Check that starts-with conditions are preserved
            Assert.IsTrue(decodedPolicy.Contains("\"starts-with\""));
            Assert.IsTrue(decodedPolicy.Contains("\"$key\""));
            Assert.IsTrue(decodedPolicy.Contains("\"user/uploads/\""));
            Assert.IsTrue(decodedPolicy.Contains("\"$Content-Type\""));
            Assert.IsTrue(decodedPolicy.Contains("\"image/\""));
            Assert.IsTrue(decodedPolicy.Contains("\"$x-amz-meta-tag\""));
            
            // Check that content-length-range condition is preserved
            Assert.IsTrue(decodedPolicy.Contains("\"content-length-range\""));
            Assert.IsTrue(decodedPolicy.Contains("1024"));
            Assert.IsTrue(decodedPolicy.Contains("10485760"));
            
            // Check success_action_status is preserved
            Assert.IsTrue(decodedPolicy.Contains("\"success_action_status\""));
            Assert.IsTrue(decodedPolicy.Contains("\"201\""));
            
            // Check metadata condition is preserved
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-meta-uuid\""));
            Assert.IsTrue(decodedPolicy.Contains("\"${filename}\""));
            
            // Check that AWS signing conditions were added
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-algorithm\""));
            Assert.IsTrue(decodedPolicy.Contains("\"AWS4-HMAC-SHA256\""));
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-credential\""));
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-date\""));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicy_WithSecurityToken_IncludesTokenInPolicy()
        {
            // Arrange - Use the same comprehensive policy as other tests
            var policy = @"{
  ""expiration"": ""2030-01-01T00:00:00Z"",
  ""conditions"": [
    {""bucket"": ""test-bucket""},
    {""acl"": ""public-read""},
    [""starts-with"", ""$key"", ""user/uploads/""],
    [""starts-with"", ""$Content-Type"", ""image/""],
    [""content-length-range"", 1024, 10485760],
    {""success_action_status"": ""201""}
  ]
}";
            var creds = new Mock<AWSCredentials>();
            var region = RegionEndpoint.USWest1;
            // Use ImmutableCredentials with UseToken=true to test token inclusion
            var immutableCreds = new ImmutableCredentials("AKIAIOSFODNN7EXAMPLE", "test-secret-key", "security-token-value");

            // Setup mock credentials with security token
            creds.Setup(c => c.GetCredentials())
                .Returns(immutableCreds);

            // Act
            var signedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policy, creds.Object, region.SystemName);
            var decodedPolicy = signedPolicy.GetReadablePolicy();

            // Assert - Verify security token is properly incorporated
            Assert.IsNotNull(signedPolicy);
            Assert.AreEqual("security-token-value", signedPolicy.SecurityToken);
            
            // Verify the security token is included in the conditions
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-security-token\""));
            Assert.IsTrue(decodedPolicy.Contains("\"security-token-value\""));
            
            // Ensure other conditions are preserved alongside the security token
            Assert.IsTrue(decodedPolicy.Contains("\"bucket\""));
            Assert.IsTrue(decodedPolicy.Contains("\"test-bucket\""));
            Assert.IsTrue(decodedPolicy.Contains("\"$key\""));
            Assert.IsTrue(decodedPolicy.Contains("\"starts-with\""));
            Assert.IsTrue(decodedPolicy.Contains("\"content-length-range\""));
            
            // Verify standard AWS signing parameters are included
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-algorithm\""));
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-credential\""));
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-date\""));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetSignedPolicy_RoundTrip_SerializesToJson()
        {
            // Arrange - Use the same comprehensive policy structure
            var policy = @"{
  ""expiration"": ""2030-01-01T00:00:00Z"",
  ""conditions"": [
    {""bucket"": ""test-bucket""},
    {""acl"": ""public-read""},
    [""starts-with"", ""$key"", ""user/uploads/""],
    [""starts-with"", ""$Content-Type"", ""image/""],
    [""content-length-range"", 1024, 10485760],
    {""success_action_status"": ""201""}
  ]
}";
            var creds = new Mock<AWSCredentials>();
            var region = RegionEndpoint.USWest1;
            var immutableCreds = new ImmutableCredentials("AKIAIOSFODNN7EXAMPLE", "test-secret-key", null);

            // Setup mock credentials
            creds.Setup(c => c.GetCredentials())
                .Returns(immutableCreds);

            // Act - create signed policy and serialize to JSON
            var signedPolicy = S3PostUploadSignedPolicy.GetSignedPolicy(policy, creds.Object, region.SystemName);
            var json = signedPolicy.ToJson();
            
            // Deserialize back from JSON
            var deserializedPolicy = S3PostUploadSignedPolicy.GetSignedPolicyFromJson(json);

            // Verify round-trip serialization preserves the essential properties
            Assert.AreEqual(signedPolicy.Policy, deserializedPolicy.Policy);
            Assert.AreEqual(signedPolicy.Signature, deserializedPolicy.Signature);
            Assert.AreEqual(signedPolicy.AccessKeyId, deserializedPolicy.AccessKeyId);
            
            // Verify that we can decode the resulting policy back to JSON and still maintain all our conditions
            var decodedPolicy = deserializedPolicy.GetReadablePolicy();
            Assert.IsTrue(decodedPolicy.Contains("\"bucket\""));
            Assert.IsTrue(decodedPolicy.Contains("\"test-bucket\""));
            Assert.IsTrue(decodedPolicy.Contains("\"starts-with\""));
            Assert.IsTrue(decodedPolicy.Contains("\"$Content-Type\""));
            Assert.IsTrue(decodedPolicy.Contains("\"x-amz-algorithm\""));
        }
    }
}
