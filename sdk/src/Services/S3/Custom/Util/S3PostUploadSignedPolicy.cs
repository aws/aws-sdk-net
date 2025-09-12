/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using Amazon.Runtime;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Utility class for managing and exchanging HTTP POST uploads of objects to Amazon S3.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This object supports creating, marshalling, and unmarshalling of the information needed to build 
    /// an authenticated HTTP POST request to S3 for uploading objects according to a policy. 
    /// </para>
    /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class S3PostUploadSignedPolicy
    {
        private static JsonDocumentOptions options = new JsonDocumentOptions { AllowTrailingCommas = true };

        private static string
           KEY_POLICY = "policy",
           KEY_SIGNATURE = "signature",
           KEY_ACCESSKEY = "access_key";

        /// <summary>
        /// The policy document which governs what uploads can be done.
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// The signature for the policy.
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// The AWS Access Key Id for the credential pair that produced the signature.
        /// </summary>
        public string AccessKeyId { get; set; }

        /// <summary>
        /// The security token from session or instance credentials.
        /// </summary>
        public string SecurityToken { get; set; }

        /// <summary>
        /// The signing algorithm used. Required as a field in the post Amazon
        /// S3 can re-calculate the signature.
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// The date value in ISO8601 format. It is the same date used in
        /// creating the signing key.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// In addition to the access key ID, this provides scope information
        /// used in calculating the signing key for signature calculation. 
        /// </summary>
        public string Credential { get; set; }


        /// <summary>
        ///  Given a policy and AWS credentials, produce a S3PostUploadSignedPolicy.
        /// </summary>
        /// <param name="policy">JSON string representing the policy to sign</param>
        /// <param name="credentials">Credentials to sign the policy with</param>
        /// <param name="region">Service region endpoint.</param>
        /// <returns>A signed policy object for use with an S3PostUploadRequest.</returns>
        public static S3PostUploadSignedPolicy GetSignedPolicy(string policy, AWSCredentials credentials, string region)
        {
            ImmutableCredentials iCreds = credentials.GetCredentials();
            return GetSignedPolicy(policy, iCreds, region);
        }

        /// <summary>
        /// Given a policy and immutable credentials, produce a S3PostUploadSignedPolicy.
        /// </summary>
        /// <param name="policy">JSON string representing the policy to sign</param>
        /// <param name="iCreds">Immutable credentials to sign the policy with</param>
        /// <param name="region">Service region endpoint.</param>
        /// <returns>A signed policy object for use with an S3PostUploadRequest.</returns>
        internal static S3PostUploadSignedPolicy GetSignedPolicy(string policy, ImmutableCredentials iCreds, string region)
        {
            var signedAt = AWSSDKUtils.CorrectedUtcNow;

            var algorithm = "AWS4-HMAC-SHA256";
            var dateStamp = Runtime.Internal.Auth.AWS4Signer.FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat);
            var dateTimeStamp = Runtime.Internal.Auth.AWS4Signer.FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateTimeFormat);
            var credentialString = string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}/{3}/{4}/", iCreds.AccessKey, dateStamp, region, "s3", Runtime.Internal.Auth.AWS4Signer.Terminator);

            Dictionary<string, string> extraConditions = new Dictionary<string, string> {
                { S3Constants.PostFormDataXAmzCredential, credentialString },
                { S3Constants.PostFormDataXAmzAlgorithm, algorithm },
                { S3Constants.PostFormDataXAmzDate, dateTimeStamp }
            };
            if (iCreds.UseToken) { extraConditions[S3Constants.PostFormDataSecurityToken] = iCreds.Token; }

            var policyBytes = AddConditionsToPolicy(policy, extraConditions);

            var base64Policy = Convert.ToBase64String(policyBytes);

            var signingKey = Runtime.Internal.Auth.AWS4Signer.ComposeSigningKey(iCreds.SecretKey, region, dateStamp, "s3");

            var signature = AWSSDKUtils.ToHex(Runtime.Internal.Auth.AWS4Signer.ComputeKeyedHash(SigningAlgorithm.HmacSHA256, signingKey, base64Policy), true);

            return new S3PostUploadSignedPolicy
            {
                Policy = base64Policy,
                Signature = signature,
                AccessKeyId = iCreds.AccessKey,
                SecurityToken = iCreds.Token,
                Algorithm = algorithm,
                Date = dateTimeStamp,
                Credential = credentialString
            };
        }

        /// <summary>
        /// Adds or updates conditions in an S3 POST policy document while preserving other elements.
        /// This method creates a new policy document that includes all original policy properties,
        /// updates any existing conditions that match the new conditions, and adds any new conditions.
        /// </summary>
        /// <param name="policy">Original policy document as JSON string</param>
        /// <param name="newConditions">Dictionary of new conditions to add or update</param>
        /// <returns>UTF-8 bytes of the modified policy document</returns>
        private static byte[] AddConditionsToPolicy(string policy, Dictionary<string, string> newConditions)
        {
            using (JsonDocument policyDoc = JsonDocument.Parse(policy, options))
            {
                using (var ms = new MemoryStream())
                {
                    using (var writer = new Utf8JsonWriter(ms))
                    {
                        // Step 1: Start writing the new policy document object
                        writer.WriteStartObject();

                        // Step 2: Copy all properties except "conditions" from the original policy
                        // (We'll handle the conditions array separately)
                        foreach (var property in policyDoc.RootElement.EnumerateObject())
                        {
                            if (property.Name != "conditions")
                            {
                                property.WriteTo(writer);
                            }
                        }

                        // Step 3: Start writing the new "conditions" array
                        writer.WritePropertyName("conditions");
                        writer.WriteStartArray();

                        // Step 4: Check if the original policy has a conditions array
                        bool foundConditions = policyDoc.RootElement.TryGetProperty("conditions", out JsonElement conditionsElement);

                        if (foundConditions && conditionsElement.ValueKind == JsonValueKind.Array)
                        {
                            // Step 5: Process each existing condition in the original policy
                            foreach (JsonElement condition in conditionsElement.EnumerateArray())
                            {
                                bool shouldCopyCondition = true;  // Default: copy the original condition as-is
                                string matchedKey = null;         // Track if we found a key to update

                                // Step 5a: If this condition is an object, check if it contains any keys
                                // that match our new conditions (meaning we need to update this condition)
                                if (condition.ValueKind == JsonValueKind.Object)
                                {
                                    // Optimized: Directly iterate over dictionary entries to avoid ToList allocation
                                    foreach (var newCond in newConditions)
                                    {
                                        if (condition.TryGetProperty(newCond.Key, out _))
                                        {
                                            // This condition contains a key we want to update
                                            matchedKey = newCond.Key;
                                            shouldCopyCondition = false;  // Don't copy as-is, we'll update it
                                            break;
                                        }
                                    }
                                }

                                // Step 5b: Handle the condition based on whether we need to update it
                                if (shouldCopyCondition)
                                {
                                    // Case 1: This condition doesn't need updating, copy it as-is
                                    condition.WriteTo(writer);
                                }
                                else if (matchedKey != null)
                                {
                                    // Case 2: This condition needs updating because it contains a key
                                    // that matches one of our new conditions
                                    
                                    // Start a new object for the updated condition
                                    writer.WriteStartObject();
                                    
                                    // Process each property in the original condition
                                    foreach (var property in condition.EnumerateObject())
                                    {
                                        if (property.Name == matchedKey)
                                        {
                                            // This is the property we want to update with the new value
                                            writer.WriteString(matchedKey, newConditions[matchedKey]);

                                            // Remove this key from newConditions since we've now handled it
                                            // (It won't need to be added as a new condition at the end)
                                            newConditions.Remove(matchedKey);
                                        }
                                        else
                                        {
                                            // This is a property we want to preserve (not update)
                                            // Without this else clause, properties other than the one being updated would be lost
                                            property.WriteTo(writer);
                                        }
                                    }
                                    
                                    // End the updated condition object
                                    writer.WriteEndObject();
                                }
                            }
                        }

                        // Step 6: Add any remaining new conditions that weren't updates to existing ones
                        foreach (var newCond in newConditions)
                        {
                            writer.WriteStartObject();
                            writer.WriteString(newCond.Key, newCond.Value);
                            writer.WriteEndObject();
                        }

                        // Step 7: Close the conditions array and the overall policy object
                        writer.WriteEndArray();
                        writer.WriteEndObject();
                        writer.Flush();

                        // Step 8: Return the complete modified policy document as bytes
                        return ms.ToArray();
                    }
                }
            }
        }

        /// <summary>
        /// Get the policy document as a human readable string.
        /// </summary>
        /// <returns>Human readable policy document.</returns>
        public string GetReadablePolicy()
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(this.Policy));
        }

     
        /// <summary>
        /// JSON representation of this object
        /// </summary>
        /// <returns>JSON string</returns>
        public string ToJson()
        {
            var obj = new Dictionary<string, string>
            {
                [KEY_POLICY] = this.Policy,
                [KEY_SIGNATURE] = this.Signature,
                [KEY_ACCESSKEY] = this.AccessKeyId
            };

            return JsonSerializerHelper.Serialize<Dictionary<string, string>>(
                obj,
                DictionaryStringStringJsonSerializerContexts.Default
            );
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
#if NET8_0_OR_GREATER
     [RequiresUnreferencedCode("ToXml is not supported for Native AOT.")]

#endif
        public string ToXml()
        {
            StringBuilder xml = new StringBuilder(1024);
            var serializer = new XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml, CultureInfo.InvariantCulture))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// Create an instance of this class from an XML string.
        /// </summary>
        /// <param name="policyXml">XML string generated by ToXml()</param>
        /// <returns>Instance of S3PostUploadSignedPolicy</returns>
#if NET8_0_OR_GREATER
         [RequiresUnreferencedCode("GetSignedPolicyFromXml is not supported for Native AOT.")]

#endif
        public static S3PostUploadSignedPolicy GetSignedPolicyFromXml(string policyXml)
        {
            var reader = new StringReader(policyXml);
            XmlSerializer serializer = new XmlSerializer(typeof(S3PostUploadSignedPolicy));

            S3PostUploadSignedPolicy policy;
            try
            {
                policy = serializer.Deserialize(reader) as S3PostUploadSignedPolicy;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Could not parse XML", e);
            }

            if (String.IsNullOrEmpty(policy.AccessKeyId))
                throw new ArgumentException("XML Document requries 'AccessKeyId' field");
            if (String.IsNullOrEmpty(policy.Policy))
                throw new ArgumentException("XML Document requries 'Policy' field");
            if (String.IsNullOrEmpty(policy.Signature))
                throw new ArgumentException("XML Document requries 'Signature' field");

            return policy;
        }

        /// <summary>
        /// Create an instance of this class from a JSON string.
        /// </summary>
        /// <param name="policyJson">JSON string</param>
        /// <returns>Instance of S3PostUploadSignedPolicy</returns>
        public static S3PostUploadSignedPolicy GetSignedPolicyFromJson(string policyJson)
        {
            try
            {
                using (var doc = JsonDocument.Parse(policyJson))
                {
                    var json = doc.RootElement;

                    // Check if required fields exist and are of the correct type
                    if (!json.TryGetProperty(KEY_POLICY, out var policyNode) || policyNode.ValueKind != JsonValueKind.String)
                        throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "JSON document requires '{0}' field", KEY_POLICY), KEY_POLICY);
                    if (!json.TryGetProperty(KEY_SIGNATURE, out var signatureNode) || signatureNode.ValueKind != JsonValueKind.String)
                        throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "JSON document requires '{0}' field", KEY_SIGNATURE), KEY_SIGNATURE);
                    if (!json.TryGetProperty(KEY_ACCESSKEY, out var accessKeyNode) || accessKeyNode.ValueKind != JsonValueKind.String)
                        throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "JSON document requires '{0}' field", KEY_ACCESSKEY), KEY_ACCESSKEY);

                    return new S3PostUploadSignedPolicy
                    {
                        Policy = policyNode.GetString(),
                        Signature = signatureNode.GetString(),
                        AccessKeyId = accessKeyNode.GetString()
                    };
                }
            }
            catch (JsonException e)
            {
                throw new ArgumentException("Invalid JSON document", e);
            }
        }
    }
}
