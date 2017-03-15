/*
 * Copyright 2011-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
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
            try
            {
                return AWSSDKUtils.DownloadStringContent(uri);
            }
            catch (WebException)
            {
                throw new AmazonServiceException("Unable to reach credentials server");
            }
        }

        protected static T GetObjectFromResponse<T>(Uri uri)
        {
            string json = GetContents(uri);
            return JsonMapper.ToObject<T>(json);
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
        protected class SecurityBase
        {
            public string Code { get; set; }
            public string Message { get; set; }
            public DateTime LastUpdated { get; set; }
        }

        protected class SecurityInfo : SecurityBase
        {
            public string InstanceProfileArn { get; set; }
            public string InstanceProfileId { get; set; }
        }

        protected class SecurityCredentials : SecurityBase
        {
            public string Type { get; set; }
            public string AccessKeyId { get; set; }
            public string SecretAccessKey { get; set; }
            public string Token { get; set; }
            public DateTime Expiration { get; set; }
            public string RoleArn { get; set; }
        }
        #endregion

    }
}
