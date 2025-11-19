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

using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
#if NET8_0_OR_GREATER
using System.Text.Json;
#endif
using System.Xml;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Credentials.Internal
{
    public static class LoginUtils
    {
        private static class JsonPropertyNames
        {
            public const string AccessToken = "accessToken";
            public const string AccessTokenAccessKeyId = "accessKeyId";
            public const string AccessTokenSecretAccessKey = "secretAccessKey";
            public const string AccessTokenSessionToken = "sessionToken";
            public const string AccessTokenAccountId = "accountId";
            public const string AccessTokenExpiresAt = "expiresAt";
            public const string TokenType = "tokenType";
            public const string IdentityToken = "idToken";
            public const string RefreshToken = "refreshToken";
            public const string ClientId = "clientId";
            public const string DPoPKey = "dpopKey";
        }

        #region Constants
        public const string ClientIdSameDevice = "arn:aws:signin:::devtools/same-device";
        public const string ClientIdCrossDevice = "arn:aws:signin:::devtools/cross-device";
        #endregion

        #region Extension Methods
        /// <summary>
        /// Method to check if the Login Token is expired.
        /// </summary>
        /// <param name="token">Login Token instance.</param>
        /// <returns>Flag to indicate if Login Token is expired.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool IsExpired(this LoginToken token)
        {
            if (token == null)
                throw new ArgumentNullException(nameof(token));

            var currentTime = AWSSDKUtils.CorrectedUtcNow;
            return token.AccessToken.ExpiresAt < currentTime;
        }

        /// <summary>
        /// True if either the <paramref name="token"/> will expire in 6 minutes or
        /// has already expired.
        /// </summary>
        public static bool NeedsRefresh(this LoginToken token)
        {
            var currentTime = AWSSDKUtils.CorrectedUtcNow;
            return token.AccessToken.ExpiresAt <= currentTime.AddMinutes(6);
        }

        /// <summary>
        /// Indicates if <paramref name="token"/> has the necessary data properties
        /// to facilitate a refresh attempt.
        /// <para />
        /// NOTE: This does NOT check if the <paramref name="token"/> is within a refresh
        /// time window.  For that, use <see cref="NeedsRefresh"/>/
        /// </summary>
        public static bool CanRefresh(this LoginToken token)
        {
            return
                !string.IsNullOrEmpty(token.RefreshToken) &&
                !string.IsNullOrEmpty(token.ClientId);
        }

        /// <summary>
        /// Serializes the Login Token to JSON
        /// </summary>
        /// <param name="token">Token to serialize</param>
        public static string AsJson(this LoginToken token)
        {
            return ToJson(token);
        }
        #endregion

        /// <summary>
        /// Serializes the Login Token to JSON
        /// </summary>
        /// <param name="token">Token to serialize</param>
        public static string ToJson(LoginToken token)
        {
            var jsonData = new Dictionary<string, object>
            {
                [JsonPropertyNames.AccessToken] = new Dictionary<string, string>
                {
                    [JsonPropertyNames.AccessTokenAccessKeyId] = token.AccessToken?.AccessKey,
                    [JsonPropertyNames.AccessTokenSecretAccessKey] = token.AccessToken?.SecretKey,
                    [JsonPropertyNames.AccessTokenSessionToken] = token.AccessToken?.Token,
                    [JsonPropertyNames.AccessTokenAccountId] = token.AccessToken?.AccountId,
                    [JsonPropertyNames.AccessTokenExpiresAt] = token.AccessToken?.ExpiresAt?.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fffZ")
                },
                [JsonPropertyNames.TokenType] = token.TokenType,
                [JsonPropertyNames.IdentityToken] = token.IdentityToken,
                [JsonPropertyNames.RefreshToken] = token.RefreshToken,
                [JsonPropertyNames.ClientId] = token.ClientId,
                [JsonPropertyNames.DPoPKey] = token.DPoPKey
            };

            // LitJson adds `\r\n` at the beginning of JSON string, which should be removed.
            return JsonSerializerHelper.Serialize<Dictionary<string, object>>(jsonData, new DictionaryStringObjectJsonSerializerContexts(new JsonSerializerOptions { WriteIndented = true }))?.Trim(new char[] { '\r', '\n' });
        }

        /// <summary>
        /// Deserializes the Login Token from JSON.
        /// </summary>
        /// <param name="json">JSON (string) to deserialize.</param>
        public static LoginToken FromJson(string json)
        {
            var jsonData = JsonMapper.ToObject(json);
            var token = new LoginToken();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.AccessToken))
            {
                token.AccessToken = null;
                if (jsonData[JsonPropertyNames.AccessToken].IsObject)
                {
                    string accessKeyId = jsonData[JsonPropertyNames.AccessToken][JsonPropertyNames.AccessTokenAccessKeyId].ToString();
                    string secretAccessKey = jsonData[JsonPropertyNames.AccessToken][JsonPropertyNames.AccessTokenSecretAccessKey].ToString();
                    string sessionToken = jsonData[JsonPropertyNames.AccessToken][JsonPropertyNames.AccessTokenSessionToken].ToString();
                    string accountId = jsonData[JsonPropertyNames.AccessToken][JsonPropertyNames.AccessTokenAccountId].ToString();
                    string expiresAt = jsonData[JsonPropertyNames.AccessToken][JsonPropertyNames.AccessTokenExpiresAt].ToString();
                    DateTime? expiresAtAsDateTime = null;

                    if (expiresAt != null)
                    {
                        expiresAtAsDateTime = DateTime.Parse(expiresAt, null, DateTimeStyles.AdjustToUniversal);
                    }
                    token.AccessToken = new LoginImmutableCredentials(accessKeyId, secretAccessKey, sessionToken, expiresAtAsDateTime, accountId);
                }
            }

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.TokenType))
                token.TokenType = jsonData[JsonPropertyNames.TokenType]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.IdentityToken))
                token.IdentityToken = jsonData[JsonPropertyNames.IdentityToken]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.RefreshToken))
                token.RefreshToken = jsonData[JsonPropertyNames.RefreshToken]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.ClientId))
                token.ClientId = jsonData[JsonPropertyNames.ClientId]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.DPoPKey))
                token.DPoPKey = jsonData[JsonPropertyNames.DPoPKey]?.ToString();

            return token;
        }

        /// <summary>
        /// Extracts login_session from identity token.
        /// </summary>
        /// <param name="identityToken">Identity Token value.</param>
        /// <returns>Login Session value.</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public static string ExtractLoginSessionFromIdentityToken(string identityToken)
        {
            // Parse JWT to extract login_session
            // 1. Separate token into header, payload, signature by splitting on '.'
            var parts = identityToken.Split('.');
            if (parts.Length != 3)
                throw new ArgumentException("Invalid JWT format");

            // 2. Base64URL decode the payload and convert to JSON object
            var payload = parts[1];
            var payloadBytes = Base64UrlDecode(payload);
            var payloadJson = Encoding.UTF8.GetString(payloadBytes);

            var payloadJsonData = JsonMapper.ToObject(payloadJson);

            // 3. Select the value of the sub key in the payload
            if (payloadJsonData.PropertyNames.Contains("sub"))
            {
                return payloadJsonData["sub"]?.ToString();
            }

            throw new InvalidOperationException("Login session not found in the identity token.");
        }

        /// <summary>
        /// Extracts AWS account ID from Login Session ARN.
        /// </summary>
        /// <param name="loginSession">Login Session value.</param>
        /// <returns>AWS account ID</returns>
        public static string ExtractAccountIdFromLoginSessionArn(string loginSession)
        {
            // Login Session is of format arn:aws:iam::<<ACCOUNT-ID>>:user/<<SUFFIX>>. Get the AccountId from the login_session ARN by splitting on : and selecting the fifth piece.
            if (!string.IsNullOrWhiteSpace(loginSession))
            {
                var parts = loginSession.Split(':');
                if (parts.Length < 5)
                {
                    return null;
                }

                return parts[4];
            }

            return null;
        }

        /// <summary>
        /// Encodes a byte array into a URL-safe Base64 string.
        /// <para>Base64 URL encoding, defined in RFC 4648. is a variant of Base64 encoding that is specifically designed 
        /// to be safe for use in URLs, JSON  Web Tokens (JWTs) and filenames. The standard Base64 characters + and / are 
        /// replaced with - and _ respectively, and padding characters (=) are omitted, ensuring 
        /// that the encoded data does not include any characters that have special meanings in URLs.
        /// </para>
        /// </summary>
        /// <param name="input">The byte array to encode.</param>
        /// <returns>The URL-safe Base64 encoded string. The characters '+' and '/' are replaced with '-' and '_', 
        /// respectively, and padding characters '=' are removed.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1055:Uri return values should not be strings")]
        public static string Base64UrlEncode(byte[] input)
        {
            if (input == null)
                return null;

            // Refer https://jonathancrozier.com/blog/base64-url-encoding-using-c-sharp for example.
            return Convert.ToBase64String(input)
                .TrimEnd('=')
                .Replace('+', '-')
                .Replace('/', '_');
        }

        /// <summary>
        /// Decodes a Base64 URL-encoded string into its original byte array representation.
        /// </summary>
        /// <remarks>
        /// This method converts the URL-safe Base64 encoding characters ('-' and '_') back to the standard 
        /// Base64 characters ('+' and '/') and reintroduces the necessary padding ('=') before decoding.
        /// It is specifically designed to handle strings generated by the Base64 URL encoding scheme 
        /// defined in RFC 4648, Section 5, ensuring they are safe for transmission in URLs.
        /// </remarks>
        /// <param name="input">The Base64 URL-encoded string to decode.</param>
        /// The original byte array, or <see langword="null"/> if the input string is <see langword="null"/>.
        /// <exception cref="System.FormatException">Thrown if the <paramref name="input"/> is not a valid Base64 URL-encoded string.</exception>
        public static byte[] Base64UrlDecode(string input)
        {
            if (input == null)
                return null;

            var base64 = input.Replace('-', '+').Replace('_', '/');
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }

            return Convert.FromBase64String(base64);
        }
    }
}
