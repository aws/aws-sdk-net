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
using System;
using System.Collections.Generic;
using System.Net;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// Options used to get Login Token from cache or refresh an expired token.
    /// </summary>
    public class LoginTokenManagerGetTokenOptions
    {
        /// <summary>
        /// Login session for the Signin profile.
        /// </summary>
        public string LoginSession { get; set; }

        /// <summary>
        /// AWS region where the AWS Signin service is hosted.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Folder location where Login Tokens are cached.
        /// </summary>
        public string CacheFolderLocation { get; set; }

        /// <summary>
        /// The proxy settings to use when calling Signin service.
        /// </summary>
#if BCL
        public WebProxy ProxySettings { get; set; }
#elif NETSTANDARD
        public IWebProxy ProxySettings { get; set; }
#endif
    }
}
