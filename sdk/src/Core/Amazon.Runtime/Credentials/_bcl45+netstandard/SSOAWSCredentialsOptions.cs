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
using System.Globalization;
using System.Net;

namespace Amazon.Runtime
{
    public class SsoVerificationArguments
    {
        /// <summary>
        /// The end-user verification code that is provided (by the user or on their behalf) when
        /// the user logs in using <see cref="VerificationUri"/>
        /// </summary>
        public string UserCode { get; set; }

        /// <summary>
        /// End-user verification URI on the authorization server.
        /// </summary>
        public string VerificationUri { get; set; }

        /// <summary>
        /// A verification URI that includes the "user_code", designed for non-textual transmission.
        /// </summary>
        public string VerificationUriComplete { get; set; }

        /// <summary>
        /// Produces a stock message that can be presented to users, instructing them how to log in through SSO.
        /// </summary>
        public string GetSsoSigninMessage()
        {
            return string.Format(
                $"Using a browser, visit: {VerificationUri}{0}" +
                $"And enter the code: {UserCode}{0}",
                Environment.NewLine
            );
        }
    }

    public class SSOAWSCredentialsOptions
    {
        /// <summary>
        /// Required - Name of the application or system used during SSO client registration.
        /// A timestamp indicating when the client was registered will be appended to requests made to the SSOOIDC service.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// The name of the sso_session section in the shared configuration file specified to be used when loading the token.
        /// </summary>
        public string SessionName { get; set; }

        /// <summary>
        /// A callback that is used to initiate the SSO Login flow with the user.
        /// </summary>
        public Action<SsoVerificationArguments> SsoVerificationCallback { get; set; }

        /// <summary>
        /// The proxy settings to use when calling SSOOIDC and SSO Services.
        /// </summary>
#if BCL
        public WebProxy ProxySettings { get; set; }
#elif NETSTANDARD
        public IWebProxy ProxySettings { get; set; }
#endif
    }
}
