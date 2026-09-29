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
    /// Configuration details for OAuth 2.0 authorization code grant flow.
    /// </summary>
    public partial class AuthorizationCodeGrantDetails
    {
        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint URL for the OAuth flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the OAuth application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret for the OAuth application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 2048)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint URL for obtaining access tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;
    }
}
