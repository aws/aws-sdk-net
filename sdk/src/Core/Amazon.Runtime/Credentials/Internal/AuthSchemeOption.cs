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

using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Credentials.Internal
{
    public class AuthSchemeOption : IAuthSchemeOption
    {
        /// <inheritdoc/>
        public string SchemeId { get; set; }

        internal const string SigV4 = "aws.auth#sigv4";
        internal const string SigV4A = "aws.auth#sigv4a";
        internal const string Bearer = "smithy.api#httpBearerAuth";
        internal const string NoAuth = "smithy.api#noAuth";

        /// <summary>
        /// Default auth scheme options for services / operations that only support SigV4.
        /// </summary>
        public static readonly List<IAuthSchemeOption> DEFAULT_SIGV4 = new()
        {
            new AuthSchemeOption { SchemeId = SigV4 },
        };

        /// <summary>
        /// Default auth scheme options for services / operations that only support SigV4A.
        /// </summary>
        public static readonly List<IAuthSchemeOption> DEFAULT_SIGV4A = new()
        {
            new AuthSchemeOption { SchemeId = SigV4A },
        };

        /// <summary>
        /// Default auth scheme options for services / operations that support both SigV4 and SigV4A.
        /// </summary>
        public static readonly List<IAuthSchemeOption> DEFAULT_SIGV4_SIGV4A = new()
        {
            new AuthSchemeOption { SchemeId = SigV4 },
            new AuthSchemeOption { SchemeId = SigV4A },
        };

        /// <summary>
        /// Default auth scheme options for services / operations that that only support bearer authentication.
        /// </summary>
        public static readonly List<IAuthSchemeOption> DEFAULT_BEARER = new()
        {
            new AuthSchemeOption { SchemeId = Bearer },
        };

        /// <summary>
        /// Default auth scheme options for services / operations that don't require credentials.
        /// </summary>
        public static readonly List<IAuthSchemeOption> DEFAULT_NOAUTH = new()
        {
            new AuthSchemeOption { SchemeId = NoAuth },
        };
    }
}
