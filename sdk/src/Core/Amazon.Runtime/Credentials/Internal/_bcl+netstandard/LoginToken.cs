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

using Amazon.Runtime.Internal.Auth;
using System;
using System.Globalization;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// Class representing Login Token.
    /// </summary>
    public class LoginToken
    {
        /// <summary>
        /// An object containing the access token and its metadata.
        /// </summary>
        [JsonPropertyName("accessToken")]
        [JsonConverter(typeof(LoginImmutableCredentialsConverter))]
        public LoginImmutableCredentials AccessToken { get; set; }

        /// <summary>
        /// Returned by Sign-In, only expected to be `aws_sigv4` initially.
        /// </summary>
        [JsonPropertyName("tokenType")]
        public string TokenType { get; set; }

        /// <summary>
        /// A JWT, containing info from Sign-In about which account/role/etc. the AccessToken is for.
        /// </summary>
        [JsonPropertyName("idToken")]
        public string IdentityToken { get; set; }

        /// <summary>
        /// An opaque string returned by Sign-In.
        /// </summary>
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// The ARN of the client ID used when acquiring the token (`arn:aws:signin:::devtools/same-device` OR `arn:aws:signin:::devtools/cross-device`).
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// PEM file contents containing the base64-encoding of the ECPrivateKey format.
        /// </summary>
        [JsonPropertyName("dpopKey")]
        public string DPoPKey { get; set; }
    }

    public class LoginImmutableCredentialsConverter : JsonConverter<LoginImmutableCredentials>
    {
        public override void Write(Utf8JsonWriter writer, LoginImmutableCredentials value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("accessKeyId", value.AccessKey);
            writer.WriteString("secretAccessKey", value.SecretKey);
            writer.WriteString("sessionToken", value.Token);
            writer.WriteString("accountId", value.AccountId);
            writer.WriteString("expiresAt", value.ExpiresAt?.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffZ"));
            writer.WriteEndObject();
        }

        public override LoginImmutableCredentials Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            var root = doc.RootElement;

            var accessKeyId = root.GetProperty("accessKeyId").GetString();
            var secretAccessKey = root.GetProperty("secretAccessKey").GetString();
            var sessionToken = root.GetProperty("sessionToken").GetString();
            var accountId = root.GetProperty("accountId").GetString();
            var expiresAt = DateTime.Parse(root.GetProperty("expiresAt").GetString(), null, DateTimeStyles.AdjustToUniversal);

            return new LoginImmutableCredentials(accessKeyId, secretAccessKey, sessionToken, expiresAt, accountId);
        }
    }

#if NET8_0_OR_GREATER
    [System.Text.Json.Serialization.JsonSerializable(typeof(LoginToken))]
#else
    [Amazon.Util.Internal.JsonSerializable(typeof(LoginToken))]
#endif
    internal partial class LoginTokenJsonSerializerContexts
#if NET8_0_OR_GREATER
        : System.Text.Json.Serialization.JsonSerializerContext
#else
        : Amazon.Util.Internal.JsonSerializerContext
#endif
    {
#if !NET8_0_OR_GREATER
        public LoginTokenJsonSerializerContexts(Amazon.Util.Internal.JsonSerializerOptions defaultOptions)
            :base(defaultOptions)
        { }
#endif
    }
}