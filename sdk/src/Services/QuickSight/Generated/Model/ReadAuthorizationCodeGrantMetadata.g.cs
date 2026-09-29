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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Read-only metadata for OAuth2 authorization code grant authentication configuration.
    /// </summary>
    public partial class ReadAuthorizationCodeGrantMetadata
    {
        /// <summary>
        /// Gets and sets the property AuthorizationCodeGrantCredentialsSource. 
        /// <para>
        /// The source of credentials for the authorization code grant flow.
        /// </para>
        /// </summary>
        public AuthorizationCodeGrantCredentialsSource AuthorizationCodeGrantCredentialsSource { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationCodeGrantCredentialsSource property is set.
        /// </summary>
        internal bool IsSetAuthorizationCodeGrantCredentialsSource() => this.AuthorizationCodeGrantCredentialsSource != null;

        /// <summary>
        /// Gets and sets the property BaseEndpoint. 
        /// <para>
        /// The base endpoint URL for the OAuth2 authorization code grant flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string BaseEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the BaseEndpoint property is set.
        /// </summary>
        internal bool IsSetBaseEndpoint() => this.BaseEndpoint != null;

        /// <summary>
        /// Gets and sets the property ReadAuthorizationCodeGrantCredentialsDetails. 
        /// <para>
        /// The read-only credentials details for the authorization code grant flow.
        /// </para>
        /// </summary>
        public ReadAuthorizationCodeGrantCredentialsDetails ReadAuthorizationCodeGrantCredentialsDetails { get; set; }

        /// <summary>
        /// Checks to see if the ReadAuthorizationCodeGrantCredentialsDetails property is set.
        /// </summary>
        internal bool IsSetReadAuthorizationCodeGrantCredentialsDetails() => this.ReadAuthorizationCodeGrantCredentialsDetails != null;

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// The redirect URL where the authorization server will send the user after authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUrl property is set.
        /// </summary>
        internal bool IsSetRedirectUrl() => this.RedirectUrl != null;
    }
}
