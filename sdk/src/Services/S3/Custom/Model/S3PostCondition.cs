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
using System.Text.Json;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Base abstract class for all S3 POST policy conditions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// S3 POST policy conditions are used to restrict what can be uploaded through a presigned POST request.
    /// </para>
    /// <para>
    /// S3 supports three types of conditions in POST policies:
    /// </para>
    /// <list type="bullet">
    /// <item><description>Exact Match - Field must exactly match a specified value</description></item>
    /// <item><description>Starts With - Field value must start with a specified prefix</description></item>
    /// <item><description>Content Length Range - File size must be within specified byte limits</description></item>
    /// </list>
    /// </remarks>
    public abstract class S3PostCondition
    {
        /// <summary>
        /// Creates an exact match condition that requires a form field to have exactly the specified value.
        /// </summary>
        /// <param name="fieldName">
        /// The name of the form field that must match the expected value.
        /// Common field names include "bucket", "acl", "Content-Type", and custom metadata fields
        /// prefixed with "x-amz-meta-".
        /// </param>
        /// <param name="expectedValue">
        /// The exact value that the form field must have for the upload to be allowed.
        /// </param>
        /// <returns>An <see cref="ExactMatchCondition"/> for the specified field and value.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown when <paramref name="fieldName"/> or <paramref name="expectedValue"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown when <paramref name="fieldName"/> or <paramref name="expectedValue"/> is empty.
        /// </exception>
        /// <example>
        /// <code>
        /// // Require uploads to have public-read ACL
        /// var aclCondition = S3PostCondition.ExactMatch("acl", "public-read");
        /// 
        /// // Require specific content type
        /// var contentTypeCondition = S3PostCondition.ExactMatch("Content-Type", "image/jpeg");
        /// </code>
        /// </example>
        public static ExactMatchCondition ExactMatch(string fieldName, string expectedValue)
        {
            return new ExactMatchCondition(fieldName, expectedValue);
        }

        /// <summary>
        /// Creates a starts-with condition that requires a form field value to begin with the specified prefix.
        /// </summary>
        /// <param name="fieldName">
        /// The name of the form field whose value must start with the specified prefix.
        /// The most common field is "key" for restricting object key prefixes, but any 
        /// form field can be used.
        /// </param>
        /// <param name="prefix">
        /// The prefix that the form field value must start with. Can be an empty string
        /// to allow any value (though this makes the condition effectively permissive).
        /// </param>
        /// <returns>A <see cref="StartsWithCondition"/> for the specified field and prefix.</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown when <paramref name="fieldName"/> or <paramref name="prefix"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown when <paramref name="fieldName"/> is empty.
        /// </exception>
        /// <example>
        /// <code>
        /// // Only allow uploads to the "user-uploads/" prefix
        /// var keyCondition = S3PostCondition.StartsWith("key", "user-uploads/");
        /// 
        /// // Restrict uploads to a specific user's folder
        /// var userCondition = S3PostCondition.StartsWith("key", $"users/{userId}/");
        /// </code>
        /// </example>
        public static StartsWithCondition StartsWith(string fieldName, string prefix)
        {
            return new StartsWithCondition(fieldName, prefix);
        }

        /// <summary>
        /// Creates a content length range condition that restricts file size to the specified byte range.
        /// </summary>
        /// <param name="minimumLength">
        /// The minimum allowed file size in bytes. Must be non-negative.
        /// Use 0 to allow empty files, or 1 to require non-empty files.
        /// </param>
        /// <param name="maximumLength">
        /// The maximum allowed file size in bytes. Must be greater than or equal to 
        /// the minimum length.
        /// </param>
        /// <returns>A <see cref="ContentLengthRangeCondition"/> for the specified size range.</returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown when <paramref name="minimumLength"/> is negative, or when 
        /// <paramref name="maximumLength"/> is less than <paramref name="minimumLength"/>.
        /// </exception>
        /// <example>
        /// <code>
        /// // Allow files between 1KB and 5MB
        /// var sizeCondition = S3PostCondition.ContentLengthRange(1024, 5 * 1024 * 1024);
        /// 
        /// // Allow documents up to 10MB
        /// var docSizeCondition = S3PostCondition.ContentLengthRange(0, 10 * 1024 * 1024);
        /// </code>
        /// </example>
        public static ContentLengthRangeCondition ContentLengthRange(long minimumLength, long maximumLength)
        {
            return new ContentLengthRangeCondition(minimumLength, maximumLength);
        }

        /// <summary>
        /// Writes the condition to the specified JSON writer in the appropriate format for the S3 POST policy.
        /// </summary>
        /// <param name="writer">The JSON writer to write the condition to.</param>
        /// <remarks>
        /// This method is called during policy document serialization and writes the condition directly
        /// to the JSON writer stream. Each condition type implements this method to produce its specific
        /// JSON structure (object for exact match conditions, array for starts-with and content-length-range).
        /// </remarks>
        public abstract void WriteToJsonWriter(Utf8JsonWriter writer);
    }

    /// <summary>
    /// Represents an exact match condition in an S3 POST policy.
    /// </summary>
    /// <remarks>
    /// <para>
    /// An exact match condition requires that a form field in the POST request has exactly the specified value.
    /// This is useful for enforcing specific values for metadata, ACL settings, storage class, etc.
    /// </para>
    /// <para>
    /// Common use cases include:
    /// </para>
    /// <list type="bullet">
    /// <item><description>Enforcing a specific bucket: <c>new ExactMatchCondition("bucket", "my-uploads")</c></description></item>
    /// <item><description>Requiring a specific ACL: <c>new ExactMatchCondition("acl", "public-read")</c></description></item>
    /// <item><description>Setting required metadata: <c>new ExactMatchCondition("x-amz-meta-category", "photos")</c></description></item>
    /// </list>
    /// </remarks>
    /// <example>
    /// <code>
    /// // Require uploads to have public-read ACL
    /// var condition = new ExactMatchCondition("acl", "public-read");
    /// 
    /// // Require specific content type
    /// var contentTypeCondition = new ExactMatchCondition("Content-Type", "image/jpeg");
    /// </code>
    /// </example>
    public class ExactMatchCondition : S3PostCondition
    {
        /// <summary>
        /// Gets the name of the form field that must match the expected value.
        /// </summary>
        /// <value>
        /// The form field name (e.g., "acl", "Content-Type", "x-amz-meta-category").
        /// </value>
        public string FieldName { get; }
        
        /// <summary>
        /// Gets the exact value that the form field must have.
        /// </summary>
        /// <value>
        /// The expected value for the field. The POST request will be rejected if the 
        /// field value doesn't exactly match this value.
        /// </value>
        public string ExpectedValue { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExactMatchCondition"/> class.
        /// </summary>
        /// <param name="fieldName">
        /// The name of the form field that must match the expected value.
        /// Common field names include "bucket", "acl", "Content-Type", and custom metadata fields
        /// prefixed with "x-amz-meta-".
        /// </param>
        /// <param name="expectedValue">
        /// The exact value that the form field must have for the upload to be allowed.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown when <paramref name="fieldName"/> or <paramref name="expectedValue"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown when <paramref name="fieldName"/> or <paramref name="expectedValue"/> is empty.
        /// </exception>
        public ExactMatchCondition(string fieldName, string expectedValue)
        {
            if (fieldName == null)
                throw new ArgumentNullException(nameof(fieldName));
            if (expectedValue == null)
                throw new ArgumentNullException(nameof(expectedValue));
            if (string.IsNullOrEmpty(fieldName))
                throw new ArgumentException("Field name cannot be empty", nameof(fieldName));
            if (string.IsNullOrEmpty(expectedValue))
                throw new ArgumentException("Expected value cannot be empty", nameof(expectedValue));

            FieldName = fieldName;
            ExpectedValue = expectedValue;
        }
        
        /// <summary>
        /// Writes this condition to the specified JSON writer as an object with the field name and expected value.
        /// </summary>
        /// <param name="writer">The JSON writer to write the condition to.</param>
        /// <remarks>
        /// Writes the condition as a JSON object: <c>{"fieldName": "expectedValue"}</c>
        /// The Utf8JsonWriter automatically handles JSON escaping for string values.
        /// </remarks>
        public override void WriteToJsonWriter(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteString(FieldName, ExpectedValue);
            writer.WriteEndObject();
        }
    }

    /// <summary>
    /// Represents a "starts-with" condition in an S3 POST policy.
    /// </summary>
    /// <remarks>
    /// <para>
    /// A starts-with condition requires that a form field value begins with the specified prefix.
    /// This is particularly useful for restricting object keys to specific prefixes, allowing 
    /// organized uploads while maintaining flexibility in naming.
    /// </para>
    /// <para>
    /// The condition is serialized as a JSON array: <c>["starts-with", "$fieldName", "prefix"]</c>
    /// </para>
    /// <para>
    /// The field name is automatically prefixed with "$" to indicate it's a variable reference
    /// in the POST policy. This is required by the S3 POST policy format.
    /// </para>
    /// <para>
    /// Common use cases include:
    /// </para>
    /// <list type="bullet">
    /// <item><description>Restricting uploads to a user folder: <c>new StartsWithCondition("key", "users/johndoe/")</c></description></item>
    /// <item><description>Organizing by file type: <c>new StartsWithCondition("key", "images/")</c></description></item>
    /// <item><description>Enforcing naming conventions: <c>new StartsWithCondition("key", "uploads-2023-")</c></description></item>
    /// </list>
    /// </remarks>
    /// <example>
    /// <code>
    /// // Only allow uploads to the "user-uploads/" prefix
    /// var condition = new StartsWithCondition("key", "user-uploads/");
    /// 
    /// // Restrict uploads to a specific user's folder
    /// var userCondition = new StartsWithCondition("key", $"users/{userId}/");
    /// 
    /// // Allow uploads with specific metadata prefix
    /// var metadataCondition = new StartsWithCondition("x-amz-meta-category", "photo-");
    /// </code>
    /// </example>
    public class StartsWithCondition : S3PostCondition
    {
        /// <summary>
        /// Gets the name of the form field whose value must start with the specified prefix.
        /// </summary>
        /// <value>
        /// The form field name (e.g., "key" for object key, "Content-Type" for content type).
        /// This will be automatically prefixed with "$" in the policy condition to indicate
        /// it's a variable reference.
        /// </value>
        public string FieldName { get; }
        
        /// <summary>
        /// Gets the prefix that the form field value must start with.
        /// </summary>
        /// <value>
        /// The required prefix. The POST request will be rejected if the field value
        /// doesn't start with this exact prefix. An empty string allows any value.
        /// </value>
        public string Prefix { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartsWithCondition"/> class.
        /// </summary>
        /// <param name="fieldName">
        /// The name of the form field whose value must start with the specified prefix.
        /// The most common field is "key" for restricting object key prefixes, but any 
        /// form field can be used.
        /// </param>
        /// <param name="prefix">
        /// The prefix that the form field value must start with. Can be an empty string
        /// to allow any value (though this makes the condition effectively permissive).
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown when <paramref name="fieldName"/> or <paramref name="prefix"/> is null.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown when <paramref name="fieldName"/> is empty.
        /// </exception>
        public StartsWithCondition(string fieldName, string prefix)
        {
            if (fieldName == null)
                throw new ArgumentNullException(nameof(fieldName));
            if (prefix == null)
                throw new ArgumentNullException(nameof(prefix));
            if (string.IsNullOrEmpty(fieldName))
                throw new ArgumentException("Field name cannot be empty", nameof(fieldName));

            FieldName = fieldName;
            Prefix = prefix;
        }
        
        /// <summary>
        /// Writes this condition to the specified JSON writer as an array representing the starts-with condition.
        /// </summary>
        /// <param name="writer">The JSON writer to write the condition to.</param>
        /// <remarks>
        /// Writes the condition as a JSON array: <c>["starts-with", "$fieldName", "prefix"]</c>
        /// The field name is automatically prefixed with "$" as required by S3 POST policy format.
        /// The Utf8JsonWriter automatically handles JSON escaping for string values.
        /// </remarks>
        public override void WriteToJsonWriter(Utf8JsonWriter writer)
        {
            writer.WriteStartArray();
            writer.WriteStringValue("starts-with");
            writer.WriteStringValue($"${FieldName}");
            writer.WriteStringValue(Prefix);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// Represents a content length range condition in an S3 POST policy.
    /// </summary>
    /// <remarks>
    /// <para>
    /// A content length range condition restricts the size of files that can be uploaded
    /// through the presigned POST request.
    /// </para>
    /// <para>
    /// The condition is serialized as a JSON array: <c>["content-length-range", minimumLength, maximumLength]</c>
    /// </para>
    /// <para>
    /// Both minimum and maximum values are specified in bytes and are inclusive bounds.
    /// The uploaded file size must be greater than or equal to the minimum and less than 
    /// or equal to the maximum.
    /// </para>
    /// <para>
    /// Common use cases include:
    /// </para>
    /// <list type="bullet">
    /// <item><description>Profile photos: <c>new ContentLengthRangeCondition(1024, 5 * 1024 * 1024)</c> (1KB to 5MB)</description></item>
    /// <item><description>Document uploads: <c>new ContentLengthRangeCondition(0, 10 * 1024 * 1024)</c> (up to 10MB)</description></item>
    /// <item><description>Preventing empty files: <c>new ContentLengthRangeCondition(1, long.MaxValue)</c></description></item>
    /// </list>
    /// </remarks>
    /// <example>
    /// <code>
    /// // Allow files between 1KB and 5MB (typical for profile images)
    /// var imageSize = new ContentLengthRangeCondition(1024, 5 * 1024 * 1024);
    /// 
    /// // Allow documents up to 10MB
    /// var documentSize = new ContentLengthRangeCondition(0, 10 * 1024 * 1024);
    /// 
    /// // Require non-empty files with reasonable maximum
    /// var nonEmptySize = new ContentLengthRangeCondition(1, 100 * 1024 * 1024);
    /// </code>
    /// </example>
    public class ContentLengthRangeCondition : S3PostCondition
    {
        /// <summary>
        /// Gets the minimum allowed file size in bytes.
        /// </summary>
        /// <value>
        /// The minimum file size in bytes (inclusive). Files smaller than this size
        /// will be rejected. Must be non-negative and less than or equal to the maximum length.
        /// </value>
        public long MinimumLength { get; }
        
        /// <summary>
        /// Gets the maximum allowed file size in bytes.
        /// </summary>
        /// <value>
        /// The maximum file size in bytes (inclusive). Files larger than this size
        /// will be rejected. Must be greater than or equal to the minimum length.
        /// </value>
        public long MaximumLength { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentLengthRangeCondition"/> class.
        /// </summary>
        /// <param name="minimumLength">
        /// The minimum allowed file size in bytes. Must be non-negative.
        /// Use 0 to allow empty files, or 1 to require non-empty files.
        /// </param>
        /// <param name="maximumLength">
        /// The maximum allowed file size in bytes. Must be greater than or equal to 
        /// the minimum length.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown when <paramref name="minimumLength"/> is negative, or when 
        /// <paramref name="maximumLength"/> is less than <paramref name="minimumLength"/>.
        /// </exception>
        public ContentLengthRangeCondition(long minimumLength, long maximumLength)
        {
            if (minimumLength < 0)
                throw new ArgumentException("Minimum length cannot be negative", nameof(minimumLength));
                
            if (maximumLength < minimumLength)
                throw new ArgumentException("Maximum length must be greater than or equal to minimum length", nameof(maximumLength));
                
            MinimumLength = minimumLength;
            MaximumLength = maximumLength;
        }
        
        /// <summary>
        /// Writes this condition to the specified JSON writer as an array representing the content-length-range condition.
        /// </summary>
        /// <param name="writer">The JSON writer to write the condition to.</param>
        /// <remarks>
        /// Writes the condition as a JSON array: <c>["content-length-range", minimumLength, maximumLength]</c>
        /// The numeric values are written directly without escaping as they are valid JSON numbers.
        /// </remarks>
        public override void WriteToJsonWriter(Utf8JsonWriter writer)
        {
            writer.WriteStartArray();
            writer.WriteStringValue("content-length-range");
            writer.WriteNumberValue(MinimumLength);
            writer.WriteNumberValue(MaximumLength);
            writer.WriteEndArray();
        }
    }
}
