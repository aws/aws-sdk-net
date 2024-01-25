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
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime
{
    public class URIBasedRefreshingCredentialHelper : RefreshingAWSCredentials
    {
        private static string SuccessCode = "Success";

        protected static string GetContents(Uri uri)
        {
            return GetContents(uri, null);
        }

        protected static string GetContents(Uri uri, IWebProxy proxy)
        {
            return GetContents(uri, proxy, null);
        }

        protected static string GetContents(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
        {
            try
            {
                return AWSSDKUtils.ExecuteHttpRequest(uri, "GET", null, TimeSpan.Zero, proxy, headers);
            }
            catch (Exception e)
            {        
                throw new AmazonServiceException("Unable to reach credentials server", e);
            }
        }

        [Obsolete("This method is not compatible with Native AOT builds. The GetObjectFromResponse overload using the generic parameter taking in a JsonSerializerContext should be used instead.")]
#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("GetObjectFromResponse overload using the generic parameter taking in a JsonSerializerContext should be used instead.")]
#endif
        protected static T GetObjectFromResponse<T>(Uri uri)
        {
            return GetObjectFromResponse<T>(uri, null, null);
        }

        [Obsolete("This method is not compatible with Native AOT builds. The GetObjectFromResponse overload using the generic parameter taking in a JsonSerializerContext should be used instead.")]
#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("GetObjectFromResponse overload using the generic parameter taking in a JsonSerializerContext should be used instead.")]
#endif
        protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy)
        {
            return GetObjectFromResponse<T>(uri, proxy, null);
        }

        [Obsolete("This method is not compatible with Native AOT builds. The GetObjectFromResponse overload using the generic parameter taking in a JsonSerializerContext should be used instead.")]
#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("GetObjectFromResponse overload using the generic parameter taking in a JsonSerializerContext should be used instead.")]
#endif
        protected static T GetObjectFromResponse<T>(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
        {
            string json = GetContents(uri, proxy, headers);
            return JsonMapper.ToObject<T>(json);
        }

        protected static T GetObjectFromResponse<T, TC>(Uri uri, IWebProxy proxy, Dictionary<string, string> headers)
            where TC :
#if NET8_0_OR_GREATER
                System.Text.Json.Serialization.JsonSerializerContext,
#else
                Amazon.Util.Internal.JsonSerializerContext,
#endif
                new()
        {
            string json = GetContents(uri, proxy, headers);
            return JsonSerializerHelper.Deserialize<T>(json, new TC());
        }

        protected static void ValidateResponse(SecurityBase response)
        {
            if (!string.Equals(response.Code, SuccessCode, StringComparison.OrdinalIgnoreCase))
            {
                throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture,
                    "Unable to retrieve credentials. Code = \"{0}\". Message = \"{1}\".",
                    response.Code, response.Message));
            }
        }

        #region Private serialization classes
#pragma warning disable CA1034
        public class SecurityBase
        {
            public string Code { get; set; }
            public string Message { get; set; }
            public DateTime LastUpdated { get; set; }
        }

        public class SecurityInfo : SecurityBase
        {
            public string InstanceProfileArn { get; set; }
            public string InstanceProfileId { get; set; }
        }

        public class SecurityCredentials : SecurityBase
        {
            public string Type { get; set; }
            public string AccessKeyId { get; set; }
            public string SecretAccessKey { get; set; }
            public string Token { get; set; }
            public DateTime Expiration { get; set; }
            public string RoleArn { get; set; }
            public string AccountId { get; set; }
        }
#pragma warning restore CA1034

        #endregion

    }
}
