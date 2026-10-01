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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the GetResourceOauth2Token operation.
    /// </summary>
    public partial class GetResourceOauth2TokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The OAuth 2.0 access token to use.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 131072)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property AuthorizationUrl. 
        /// <para>
        /// The URL to initiate the authorization process, provided when the access token requires
        /// user authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string AuthorizationUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationUrl property is set.
        /// </summary>
        internal bool IsSetAuthorizationUrl() => this.AuthorizationUrl != null;

        /// <summary>
        /// Gets and sets the property SessionStatus. 
        /// <para>
        /// Status indicating whether the user's authorization session is in progress or has failed.
        /// This helps determine the next steps in the OAuth2 authentication flow.
        /// </para>
        /// </summary>
        public SessionStatus SessionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SessionStatus property is set.
        /// </summary>
        internal bool IsSetSessionStatus() => this.SessionStatus != null;

        /// <summary>
        /// Gets and sets the property SessionUri. 
        /// <para>
        /// Unique identifier for the user's authorization session for retrieving OAuth2 tokens.
        /// This matches the sessionId from the request and can be used to track the session state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SessionUri { get; set; }

        /// <summary>
        /// Checks to see if the SessionUri property is set.
        /// </summary>
        internal bool IsSetSessionUri() => this.SessionUri != null;
    }
}
