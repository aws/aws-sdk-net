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
using System.Linq;
using System.Text;
using System.Xml;
using Amazon.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Credentials.Internal
{
    public static class SsoTokenUtils
    {
        private static class JsonPropertyNames
        {
            public const string AccessToken = "accessToken";
            public const string Region = "region";
            public const string RefreshToken = "refreshToken";
            public const string ClientId = "clientId";
            public const string ClientSecret = "clientSecret";
            public const string RegistrationExpiresAt = "registrationExpiresAt";
            public const string ExpiresAt = "expiresAt";
            public const string StartUrl = "startUrl";
        }

        #region Extension Methods

        /// <summary>
        /// True if <see cref="SsoToken.ExpiresAt"/> is less than the current time
        /// </summary>
        public static bool IsExpired(this SsoToken token)
        {
            if (null == token)
                throw new ArgumentNullException(nameof(token));

#pragma warning disable CS0618 // Type or member is obsolete
            var currentTime = AWSSDKUtils.CorrectedUtcNow;
#pragma warning restore CS0618 // Type or member is obsolete

            return token.ExpiresAt < currentTime;
        }

        /// <summary>
        /// True if either the <paramref name="token"/> will expire in 6 minutes or
        /// has already expired.
        /// <para />
        /// Per Spec: Always try and refresh an expired token.
        /// </summary>
        public static bool NeedsRefresh(this SsoToken token)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var currentTime = AWSSDKUtils.CorrectedUtcNow;
#pragma warning restore CS0618 // Type or member is obsolete

            return token.ExpiresAt <= currentTime.AddMinutes(6);
        }

        /// <summary>
        /// Indicates if <paramref name="token"/> has the necessary data properties
        /// to facilitate a refresh attempt.
        /// <para />
        /// NOTE: This does NOT check if the <paramref name="token"/> is within a refresh
        /// time window.  For that, use <see cref="NeedsRefresh"/>/
        /// </summary>
        public static bool CanRefresh(this SsoToken token)
        {
            return
                !string.IsNullOrEmpty(token.RefreshToken) &&
                !string.IsNullOrEmpty(token.ClientId) &&
                !string.IsNullOrEmpty(token.ClientSecret);
        }
        
        /// <summary>
        /// Serializes the SSO Token to JSON
        /// </summary>
        /// <param name="token">Token to serialize</param>
        public static string AsJson(this SsoToken token)
        {
            return ToJson(token);
        }

        #endregion

        /// <summary>
        /// Serializes the SSO Token to JSON
        /// </summary>
        /// <param name="token">Token to serialize</param>
        public static string ToJson(SsoToken token)
        {
            var json = new StringBuilder();
            var writer = new JsonWriter(json)
            {
                PrettyPrint = true,
            };

            var jsonData = new JsonData
            {
                [JsonPropertyNames.AccessToken] = new JsonData(token.AccessToken),
                [JsonPropertyNames.ExpiresAt] = new JsonData(XmlConvert.ToString(token.ExpiresAt, XmlDateTimeSerializationMode.Utc)),
                [JsonPropertyNames.RefreshToken] = new JsonData(token.RefreshToken),
                [JsonPropertyNames.ClientId] = new JsonData(token.ClientId),
                [JsonPropertyNames.ClientSecret] = new JsonData(token.ClientSecret),
                [JsonPropertyNames.RegistrationExpiresAt] = new JsonData(token.RegistrationExpiresAt),
                [JsonPropertyNames.Region] = new JsonData(token.Region),
                [JsonPropertyNames.StartUrl] = new JsonData(token.StartUrl)
            };

            JsonMapper.ToJson(jsonData, writer);
            return json.ToString();
        }

        /// <summary>
        /// Deserializes the SSO Token from JSON
        /// </summary>
        /// <param name="json">JSON (string) to deserialize</param>
        public static SsoToken FromJson(string json)
        {
            var jsonData = JsonMapper.ToObject(json);

            var token = new SsoToken();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.AccessToken))
                token.AccessToken = jsonData[JsonPropertyNames.AccessToken].ToString();
            else
                throw new AmazonClientException($"Token is invalid: missing required field [{JsonPropertyNames.AccessToken}]");

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.ExpiresAt))
                token.ExpiresAt = XmlConvert.ToDateTime(jsonData[JsonPropertyNames.ExpiresAt].ToString(), XmlDateTimeSerializationMode.Utc);
            else
                throw new AmazonClientException($"Token is invalid: missing required field [{JsonPropertyNames.ExpiresAt}]");

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.RefreshToken))
                token.RefreshToken = jsonData[JsonPropertyNames.RefreshToken]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.ClientId))
                token.ClientId = jsonData[JsonPropertyNames.ClientId]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.ClientSecret))
                token.ClientSecret = jsonData[JsonPropertyNames.ClientSecret]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.RegistrationExpiresAt))
                token.RegistrationExpiresAt = jsonData[JsonPropertyNames.RegistrationExpiresAt]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.Region))
                token.Region = jsonData[JsonPropertyNames.Region]?.ToString();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.StartUrl))
                token.StartUrl = jsonData[JsonPropertyNames.StartUrl]?.ToString();
            
            return token;
        }
    }
}
