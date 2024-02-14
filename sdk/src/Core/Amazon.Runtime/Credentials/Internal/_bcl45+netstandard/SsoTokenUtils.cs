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
using System.Xml;
using Amazon.Util;
using Amazon.Util.Internal;
using ThirdParty.Json.LitJson;

#if NET8_0_OR_GREATER
using System.Text.Json;
#endif

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

        /// <summary>
        /// This determines whether the <seealso cref="SsoToken.RegistrationExpiresAt"/> field is 5 minutes within expiration
        /// </summary>
        /// <param name="token">The sso token</param>
        /// <returns>This returns true if <seealso cref="SsoToken.RegistrationExpiresAt"/> is within 5 minutes of expiration. False otherwise</returns>
        public static bool RegisteredClientExpired(this SsoToken token)
        {
            if (null == token)
                throw new ArgumentNullException(nameof(token));
            DateTime dateTime = ConvertRFC3339StringToDateTime(token.RegistrationExpiresAt);
#pragma warning disable CS0618 // Type or member is obsolete
            return AWSSDKUtils.CorrectedUtcNow >= dateTime.AddMinutes(-5);
#pragma warning restore CS0618 // Type or member is obsolete               
        }

        #endregion

        /// <summary>
        /// Serializes the SSO Token to JSON
        /// </summary>
        /// <param name="token">Token to serialize</param>
        public static string ToJson(SsoToken token)
        {
            var jsonData = new Dictionary<string, string>
            {
                [JsonPropertyNames.AccessToken] = token.AccessToken,
                [JsonPropertyNames.ExpiresAt] = XmlConvert.ToString(token.ExpiresAt, XmlDateTimeSerializationMode.Utc),
                [JsonPropertyNames.RefreshToken] = token.RefreshToken,
                [JsonPropertyNames.ClientId] = token.ClientId,
                [JsonPropertyNames.ClientSecret] = token.ClientSecret,
                [JsonPropertyNames.RegistrationExpiresAt] = token.RegistrationExpiresAt,
                [JsonPropertyNames.Region] = token.Region,
                [JsonPropertyNames.StartUrl] = token.StartUrl
            };

            return JsonSerializerHelper.Serialize<Dictionary<string, string>>(jsonData, new DictionaryStringStringJsonSerializerContexts(new JsonSerializerOptions { WriteIndented = true }));
        }

        /// <summary>
        /// Deserializes the SSO Token from JSON. Returns null when throwIfTokenInvalid is false and token is invalid.
        /// </summary>
        /// <param name="json">JSON (string) to deserialize.</param>
        /// <param name="throwIfTokenInvalid">if set, throws exception of type AmazonClientException when the json doesn't have AccessToken and ExpiresAt properties.</param>
        public static SsoToken FromJson(string json, bool throwIfTokenInvalid)
        {
            var jsonData = JsonMapper.ToObject(json);

            var token = new SsoToken();

            if (jsonData.PropertyNames.Contains(JsonPropertyNames.AccessToken))
                token.AccessToken = jsonData[JsonPropertyNames.AccessToken].ToString();
            else
            {
                if (throwIfTokenInvalid)
                {
                    throw new AmazonClientException($"Token is invalid: missing required field [{JsonPropertyNames.AccessToken}]");
                }
                else
                {
                    return null;
                }
            }
            if (jsonData.PropertyNames.Contains(JsonPropertyNames.ExpiresAt))
                token.ExpiresAt = XmlConvert.ToDateTime(jsonData[JsonPropertyNames.ExpiresAt].ToString(), XmlDateTimeSerializationMode.Utc);
            else
            {
                if (throwIfTokenInvalid)
                {
                    throw new AmazonClientException($"Token is invalid: missing required field [{JsonPropertyNames.ExpiresAt}]");
                }
                else
                {
                    return null;
                }
            }
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

        /// <summary>
        /// Deserializes the SSO Token from JSON
        /// </summary>
        /// <param name="json">JSON (string) to deserialize</param>
        public static SsoToken FromJson(string json)
        {
            return FromJson(json, throwIfTokenInvalid: true);
        }
        #region private methods
        /// <summary>
        /// This method takes in an RFC3339 string representing a datetime and converts it to a DateTime object 
        /// </summary>
        /// <param name="stringFormattedDate">The RFC3339 formatted string</param>
        /// <returns>Returns the datetime object serialized to UTC</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static DateTime ConvertRFC3339StringToDateTime(string stringFormattedDate)
        {
            if (string.IsNullOrEmpty(stringFormattedDate))
            {
                throw new ArgumentNullException(nameof(stringFormattedDate));
            }
            return XmlConvert.ToDateTime(stringFormattedDate, XmlDateTimeSerializationMode.Utc);
        }
        #endregion
    }
}
