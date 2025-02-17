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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Contains the OAuth authorization parameters to use for the connection.
    /// </summary>
    public partial class CreateConnectionOAuthRequestParameters
    {
        private string _authorizationEndpoint;
        private CreateConnectionOAuthClientRequestParameters _clientParameters;
        private ConnectionOAuthHttpMethod _httpMethod;
        private ConnectionHttpParameters _oAuthHttpParameters;

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The URL to the authorization endpoint when OAuth is specified as the authorization
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AuthorizationEndpoint
        {
            get { return this._authorizationEndpoint; }
            set { this._authorizationEndpoint = value; }
        }

        // Check to see if AuthorizationEndpoint property is set
        internal bool IsSetAuthorizationEndpoint()
        {
            return this._authorizationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ClientParameters. 
        /// <para>
        /// The client parameters for OAuth authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CreateConnectionOAuthClientRequestParameters ClientParameters
        {
            get { return this._clientParameters; }
            set { this._clientParameters = value; }
        }

        // Check to see if ClientParameters property is set
        internal bool IsSetClientParameters()
        {
            return this._clientParameters != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The method to use for the authorization request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionOAuthHttpMethod HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthHttpParameters. 
        /// <para>
        /// Details about the additional parameters to use for the connection.
        /// </para>
        /// </summary>
        public ConnectionHttpParameters OAuthHttpParameters
        {
            get { return this._oAuthHttpParameters; }
            set { this._oAuthHttpParameters = value; }
        }

        // Check to see if OAuthHttpParameters property is set
        internal bool IsSetOAuthHttpParameters()
        {
            return this._oAuthHttpParameters != null;
        }

    }
}