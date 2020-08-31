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
using System.Text;
using System.Xml;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Credentials.Internal
{
    public static class SsoTokenUtils
    {
        private const int TokenExpirationBufferMinutes = 15;

        private static class JsonPropertyNames
        {
            public const string AccessToken = "accessToken";
            public const string Region = "region";
            public const string ExpiresAt = "expiresAt";
            public const string StartUrl = "startUrl";
        }

        #region Extension Methods

        /// <summary>
        /// Whether or not the SSO Token is considered expired
        /// </summary>
        /// <param name="token">SSO Token to check if expired</param>
        /// <returns>false if the token is not expired, true otherwise</returns>
        public static bool IsExpired(this SsoToken token)
        {
            if (token == null)
            {
                return true;
            }

            // Spec: When checking to see if a cached token is expired, the SDK MAY treat the token as expired if it will
            // expire within 15 minutes of the expiresAt time. The SDK MAY choose a longer or shorter expiration window.
#pragma warning disable CR1003 // Do not use DateTime.Now or DateTime.UtcNow, use AWSSDKUtils.CorrectedNow or AWSSDKUtils.CorrectedUtcNow
            return token.ExpiresAt < DateTime.UtcNow.AddMinutes(TokenExpirationBufferMinutes);
#pragma warning restore CR1003 // Do not use DateTime.Now or DateTime.UtcNow, use AWSSDKUtils.CorrectedNow or AWSSDKUtils.CorrectedUtcNow
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
                [JsonPropertyNames.ExpiresAt] =
                    new JsonData(XmlConvert.ToString(token.ExpiresAt, XmlDateTimeSerializationMode.Utc)),
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
            return new SsoToken()
            {
                AccessToken = jsonData[JsonPropertyNames.AccessToken].ToString(),
                ExpiresAt = XmlConvert.ToDateTime(jsonData[JsonPropertyNames.ExpiresAt].ToString(), XmlDateTimeSerializationMode.Utc),
                Region = jsonData[JsonPropertyNames.Region].ToString(),
                StartUrl = jsonData[JsonPropertyNames.StartUrl].ToString(),
            };
        }
    }
}
