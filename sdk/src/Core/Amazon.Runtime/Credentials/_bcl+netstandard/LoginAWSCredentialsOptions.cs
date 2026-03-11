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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Amazon.Runtime
{
    /// <summary>
    /// Options that are used to resolve <see cref="LoginAWSCredentials"/>. 
    /// </summary>
    public class LoginAWSCredentialsOptions
    {
        /// <summary>
        /// Login session used for getting token.
        /// </summary>
        public string LoginSession { get; set; }

        /// <summary>
        /// Region to be used for Signin client.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Profile name that was used to resolve credentials.
        /// </summary>
        public string ProfileName { get; set; }

        /// <summary>
        /// The proxy settings to use when calling AWS Signin service.
        /// </summary>
#if BCL
        public WebProxy ProxySettings { get; set; }
#elif NETSTANDARD
        public IWebProxy ProxySettings { get; set; }
#endif
    }
}
