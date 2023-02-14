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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific credentials required when using Amazon Honeycode.
    /// </summary>
    public partial class HoneycodeConnectorProfileCredentials
    {
        private string _accessToken;
        private ConnectorOAuthRequest _oAuthRequest;
        private string _refreshToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  The credentials used to access protected Amazon Honeycode resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=4096)]
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
        /// Gets and sets the property OAuthRequest.
        /// </summary>
        public ConnectorOAuthRequest OAuthRequest
        {
            get { return this._oAuthRequest; }
            set { this._oAuthRequest = value; }
        }

        // Check to see if OAuthRequest property is set
        internal bool IsSetOAuthRequest()
        {
            return this._oAuthRequest != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        ///  The credentials used to acquire new access tokens. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string RefreshToken
        {
            get { return this._refreshToken; }
            set { this._refreshToken = value; }
        }

        // Check to see if RefreshToken property is set
        internal bool IsSetRefreshToken()
        {
            return this._refreshToken != null;
        }

    }
}