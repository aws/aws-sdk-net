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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Write-only OAuth credentials used to authorize a GitHub.com integration. Not stored
    /// or returned after creation.
    /// </summary>
    public partial class GitHubAuthorizationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthorizationCode. The OAuth authorization code returned
        /// by GitHub after the user authorizes the application.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 512)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationCode property is set.
        /// </summary>
        internal bool IsSetAuthorizationCode() => this.AuthorizationCode != null;

        /// <summary>
        /// Gets and sets the property RedirectUrl. The redirect URL used to obtain the authorization
        /// code. Must match one of the redirect URLs registered on the GitHub App. If omitted,
        /// the App's default redirect URL is used. Not stored or returned after creation.
        /// </summary>
        [AWSProperty(Min = 9, Max = 2083)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUrl property is set.
        /// </summary>
        internal bool IsSetRedirectUrl() => this.RedirectUrl != null;

        /// <summary>
        /// Gets and sets the property State. The `state` returned by GitHub in the OAuth callback.
        /// It must be the state that StartIntegrationAuthorization returned to the same AWS account,
        /// and the authorization request must have sent that call's codeChallenge. The state
        /// can be redeemed once. A stage that enforces authorization sessions rejects a missing,
        /// expired, already used, or other-account state with ValidationException; restart the
        /// authorization with StartIntegrationAuthorization.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
