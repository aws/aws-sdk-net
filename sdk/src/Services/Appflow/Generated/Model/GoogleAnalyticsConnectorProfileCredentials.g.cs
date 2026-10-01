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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile credentials required by Google Analytics.
    /// </summary>
    public partial class GoogleAnalyticsConnectorProfileCredentials
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  The credentials used to access protected Google Analytics resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        ///  The identifier for the desired client. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 512)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        ///  The client secret used by the OAuth client to authenticate to the authorization server.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 512)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property OAuthRequest. 
        /// <para>
        ///  The OAuth requirement needed to request security tokens from the connector endpoint.
        /// 
        /// </para>
        /// </summary>
        public ConnectorOAuthRequest OAuthRequest { get; set; }

        /// <summary>
        /// Checks to see if the OAuthRequest property is set.
        /// </summary>
        internal bool IsSetOAuthRequest() => this.OAuthRequest != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        ///  The credentials used to acquire new access tokens. This is required only for OAuth2
        /// access tokens, and is not required for OAuth1 access tokens. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;
    }
}
