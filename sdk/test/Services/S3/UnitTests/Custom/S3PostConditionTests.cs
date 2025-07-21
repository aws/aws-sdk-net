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
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3.Model;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3PostConditionTests
    {
        #region ExactMatchCondition Tests

        [TestMethod]
        [TestCategory("S3")]
        public void ExactMatchCondition_Constructor_ValidParameters_SetsProperties()
        {
            // Arrange
            string fieldName = "acl";
            string expectedValue = "public-read";

            // Act
            var condition = new ExactMatchCondition(fieldName, expectedValue);

            // Assert
            Assert.AreEqual(fieldName, condition.FieldName);
            Assert.AreEqual(expectedValue, condition.ExpectedValue);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExactMatchCondition_Constructor_NullFieldName_ThrowsArgumentNullException()
        {
            // Arrange
            string fieldName = null;
            string expectedValue = "public-read";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => 
                new ExactMatchCondition(fieldName, expectedValue));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExactMatchCondition_Constructor_NullExpectedValue_ThrowsArgumentNullException()
        {
            // Arrange
            string fieldName = "acl";
            string expectedValue = null;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => 
                new ExactMatchCondition(fieldName, expectedValue));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExactMatchCondition_Constructor_EmptyFieldName_ThrowsArgumentException()
        {
            // Arrange
            string fieldName = "";
            string expectedValue = "public-read";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => 
                new ExactMatchCondition(fieldName, expectedValue));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExactMatchCondition_Constructor_EmptyExpectedValue_ThrowsArgumentException()
        {
            // Arrange
            string fieldName = "acl";
            string expectedValue = "";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => 
                new ExactMatchCondition(fieldName, expectedValue));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExactMatchCondition_WriteToJsonWriter_ProducesCorrectJson()
        {
            // Arrange
            var condition = new ExactMatchCondition("acl", "public-read");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            condition.WriteToJsonWriter(writer);
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            var expectedJson = "{\"acl\":\"public-read\"}";
            Assert.AreEqual(expectedJson, json);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExactMatchCondition_WriteToJsonWriter_HandlesSpecialCharacters()
        {
            // Arrange
            var condition = new ExactMatchCondition("x-amz-meta-category", "files/docs & notes");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            condition.WriteToJsonWriter(writer);
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            Assert.IsTrue(json.Contains("x-amz-meta-category"));
            Assert.IsTrue(json.Contains("files/docs \\u0026 notes")); // JSON escaped
        }

        #endregion

        #region StartsWithCondition Tests

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_Constructor_ValidParameters_SetsProperties()
        {
            // Arrange
            string fieldName = "key";
            string prefix = "user-uploads/";

            // Act
            var condition = new StartsWithCondition(fieldName, prefix);

            // Assert
            Assert.AreEqual(fieldName, condition.FieldName);
            Assert.AreEqual(prefix, condition.Prefix);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_Constructor_NullFieldName_ThrowsArgumentNullException()
        {
            // Arrange
            string fieldName = null;
            string prefix = "user-uploads/";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => 
                new StartsWithCondition(fieldName, prefix));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_Constructor_NullPrefix_ThrowsArgumentNullException()
        {
            // Arrange
            string fieldName = "key";
            string prefix = null;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => 
                new StartsWithCondition(fieldName, prefix));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_Constructor_EmptyFieldName_ThrowsArgumentException()
        {
            // Arrange
            string fieldName = "";
            string prefix = "user-uploads/";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => 
                new StartsWithCondition(fieldName, prefix));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_Constructor_EmptyPrefix_Succeeds()
        {
            // Arrange
            string fieldName = "key";
            string prefix = "";

            // Act
            var condition = new StartsWithCondition(fieldName, prefix);

            // Assert
            Assert.AreEqual(fieldName, condition.FieldName);
            Assert.AreEqual(prefix, condition.Prefix);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_WriteToJsonWriter_ProducesCorrectJson()
        {
            // Arrange
            var condition = new StartsWithCondition("key", "user-uploads/");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            writer.WriteStartArray();
            condition.WriteToJsonWriter(writer);
            writer.WriteEndArray();
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            var expectedJson = "[[\"starts-with\",\"$key\",\"user-uploads/\"]]";
            Assert.AreEqual(expectedJson, json);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_WriteToJsonWriter_HandlesEmptyPrefix()
        {
            // Arrange
            var condition = new StartsWithCondition("key", "");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            writer.WriteStartArray();
            condition.WriteToJsonWriter(writer);
            writer.WriteEndArray();
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            var expectedJson = "[[\"starts-with\",\"$key\",\"\"]]";
            Assert.AreEqual(expectedJson, json);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StartsWithCondition_WriteToJsonWriter_HandlesSpecialCharacters()
        {
            // Arrange
            var condition = new StartsWithCondition("x-amz-meta-tag", "category/photos & videos");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            writer.WriteStartArray();
            condition.WriteToJsonWriter(writer);
            writer.WriteEndArray();
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            Assert.IsTrue(json.Contains("starts-with"));
            Assert.IsTrue(json.Contains("$x-amz-meta-tag"));
            Assert.IsTrue(json.Contains("category/photos \\u0026 videos")); // JSON escaped
        }

        #endregion

        #region ContentLengthRangeCondition Tests

        [TestMethod]
        [TestCategory("S3")]
        public void ContentLengthRangeCondition_Constructor_ValidParameters_SetsProperties()
        {
            // Arrange
            long minLength = 1024;
            long maxLength = 5242880; // 5MB

            // Act
            var condition = new ContentLengthRangeCondition(minLength, maxLength);

            // Assert
            Assert.AreEqual(minLength, condition.MinimumLength);
            Assert.AreEqual(maxLength, condition.MaximumLength);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ContentLengthRangeCondition_Constructor_NegativeMinimum_ThrowsArgumentException()
        {
            // Arrange
            long minLength = -1;
            long maxLength = 5242880;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => 
                new ContentLengthRangeCondition(minLength, maxLength));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ContentLengthRangeCondition_Constructor_MaximumLessThanMinimum_ThrowsArgumentException()
        {
            // Arrange
            long minLength = 5242880;
            long maxLength = 1024;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => 
                new ContentLengthRangeCondition(minLength, maxLength));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ContentLengthRangeCondition_Constructor_EqualMinimumAndMaximum_Succeeds()
        {
            // Arrange
            long length = 1024;

            // Act
            var condition = new ContentLengthRangeCondition(length, length);

            // Assert
            Assert.AreEqual(length, condition.MinimumLength);
            Assert.AreEqual(length, condition.MaximumLength);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ContentLengthRangeCondition_Constructor_ZeroMinimum_Succeeds()
        {
            // Arrange
            long minLength = 0;
            long maxLength = 1024;

            // Act
            var condition = new ContentLengthRangeCondition(minLength, maxLength);

            // Assert
            Assert.AreEqual(minLength, condition.MinimumLength);
            Assert.AreEqual(maxLength, condition.MaximumLength);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ContentLengthRangeCondition_WriteToJsonWriter_ProducesCorrectJson()
        {
            // Arrange
            var condition = new ContentLengthRangeCondition(1024, 5242880);
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            writer.WriteStartArray();
            condition.WriteToJsonWriter(writer);
            writer.WriteEndArray();
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            var expectedJson = "[[\"content-length-range\",1024,5242880]]";
            Assert.AreEqual(expectedJson, json);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ContentLengthRangeCondition_WriteToJsonWriter_HandlesLargeNumbers()
        {
            // Arrange
            var condition = new ContentLengthRangeCondition(0, long.MaxValue);
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            writer.WriteStartArray();
            condition.WriteToJsonWriter(writer);
            writer.WriteEndArray();
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            Assert.IsTrue(json.Contains("content-length-range"));
            Assert.IsTrue(json.Contains("0"));
            Assert.IsTrue(json.Contains(long.MaxValue.ToString()));
        }

        #endregion

        #region Static Factory Methods Tests

        [TestMethod]
        [TestCategory("S3")]
        public void S3PostCondition_ExactMatch_CreatesExactMatchCondition()
        {
            // Arrange
            string fieldName = "acl";
            string expectedValue = "public-read";

            // Act
            var condition = S3PostCondition.ExactMatch(fieldName, expectedValue);

            // Assert
            Assert.IsInstanceOfType(condition, typeof(ExactMatchCondition));
            Assert.AreEqual(fieldName, condition.FieldName);
            Assert.AreEqual(expectedValue, condition.ExpectedValue);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3PostCondition_StartsWith_CreatesStartsWithCondition()
        {
            // Arrange
            string fieldName = "key";
            string prefix = "user-uploads/";

            // Act
            var condition = S3PostCondition.StartsWith(fieldName, prefix);

            // Assert
            Assert.IsInstanceOfType(condition, typeof(StartsWithCondition));
            Assert.AreEqual(fieldName, condition.FieldName);
            Assert.AreEqual(prefix, condition.Prefix);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3PostCondition_ContentLengthRange_CreatesContentLengthRangeCondition()
        {
            // Arrange
            long minLength = 1024;
            long maxLength = 5242880;

            // Act
            var condition = S3PostCondition.ContentLengthRange(minLength, maxLength);

            // Assert
            Assert.IsInstanceOfType(condition, typeof(ContentLengthRangeCondition));
            Assert.AreEqual(minLength, condition.MinimumLength);
            Assert.AreEqual(maxLength, condition.MaximumLength);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3PostCondition_FactoryMethods_ValidateParameters()
        {
            // Test ExactMatch validation
            Assert.ThrowsException<ArgumentNullException>(() => 
                S3PostCondition.ExactMatch(null, "value"));
            Assert.ThrowsException<ArgumentNullException>(() => 
                S3PostCondition.ExactMatch("field", null));

            // Test StartsWith validation
            Assert.ThrowsException<ArgumentNullException>(() => 
                S3PostCondition.StartsWith(null, "prefix"));
            Assert.ThrowsException<ArgumentNullException>(() => 
                S3PostCondition.StartsWith("field", null));

            // Test ContentLengthRange validation
            Assert.ThrowsException<ArgumentException>(() => 
                S3PostCondition.ContentLengthRange(-1, 100));
            Assert.ThrowsException<ArgumentException>(() => 
                S3PostCondition.ContentLengthRange(100, 50));
        }

        #endregion

        #region Common Scenarios Tests

        [TestMethod]
        [TestCategory("S3")]
        public void S3PostCondition_CommonScenarios_ProduceExpectedJson()
        {
            // Arrange - Create conditions for a typical photo upload scenario
            var bucketCondition = S3PostCondition.ExactMatch("bucket", "my-photo-uploads");
            var aclCondition = S3PostCondition.ExactMatch("acl", "public-read");
            var keyCondition = S3PostCondition.StartsWith("key", "photos/2024/");
            var contentTypeCondition = S3PostCondition.StartsWith("Content-Type", "image/");
            var sizeCondition = S3PostCondition.ContentLengthRange(1024, 10 * 1024 * 1024); // 1KB to 10MB
            var categoryCondition = S3PostCondition.ExactMatch("x-amz-meta-category", "user-uploads");

            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act - Write a complete policy conditions array
            writer.WriteStartArray();
            
            bucketCondition.WriteToJsonWriter(writer);
            aclCondition.WriteToJsonWriter(writer);
            keyCondition.WriteToJsonWriter(writer);
            contentTypeCondition.WriteToJsonWriter(writer);
            sizeCondition.WriteToJsonWriter(writer);
            categoryCondition.WriteToJsonWriter(writer);
            
            writer.WriteEndArray();
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            
            // Verify bucket condition
            Assert.IsTrue(json.Contains("{\"bucket\":\"my-photo-uploads\"}"));
            
            // Verify ACL condition
            Assert.IsTrue(json.Contains("{\"acl\":\"public-read\"}"));
            
            // Verify key starts-with condition
            Assert.IsTrue(json.Contains("[\"starts-with\",\"$key\",\"photos/2024/\"]"));
            
            // Verify content-type starts-with condition
            Assert.IsTrue(json.Contains("[\"starts-with\",\"$Content-Type\",\"image/\"]"));
            
            // Verify content-length-range condition
            Assert.IsTrue(json.Contains("[\"content-length-range\",1024,10485760]"));
            
            // Verify metadata condition
            Assert.IsTrue(json.Contains("{\"x-amz-meta-category\":\"user-uploads\"}"));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void S3PostCondition_UnicodeHandling_ProducesValidJson()
        {
            // Arrange - Test with Unicode characters
            var condition = S3PostCondition.ExactMatch("x-amz-meta-title", "文档上传 - Document Upload");
            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream);

            // Act
            condition.WriteToJsonWriter(writer);
            writer.Flush();

            // Assert
            var json = Encoding.UTF8.GetString(stream.ToArray());
            
            // Verify the JSON is valid and contains the Unicode content
            Assert.IsTrue(json.Contains("x-amz-meta-title"));
            
            // Parse to ensure it's valid JSON
            var document = JsonDocument.Parse(json);
            var element = document.RootElement.GetProperty("x-amz-meta-title");
            Assert.AreEqual("文档上传 - Document Upload", element.GetString());
        }

        #endregion
    }
}
