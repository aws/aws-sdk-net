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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
        private string _accessToken;
        private string _authorizationUrl;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// OAuth2 token ready for use
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=131072)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationUrl. 
        /// <para>
        /// The URL for the authorization process, provided if the Access token requires user
        /// Authorization.
        /// </para>
        /// </summary>
        public string AuthorizationUrl
        {
            get { return this._authorizationUrl; }
            set { this._authorizationUrl = value; }
        }

        // Check to see if AuthorizationUrl property is set
        internal bool IsSetAuthorizationUrl()
        {
            return this._authorizationUrl != null;
        }

    }
}