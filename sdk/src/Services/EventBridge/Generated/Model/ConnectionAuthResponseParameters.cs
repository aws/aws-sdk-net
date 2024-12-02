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
    /// Tthe authorization parameters to use for the connection.
    /// </summary>
    public partial class ConnectionAuthResponseParameters
    {
        private ConnectionApiKeyAuthResponseParameters _apiKeyAuthParameters;
        private ConnectionBasicAuthResponseParameters _basicAuthParameters;
        private DescribeConnectionConnectivityParameters _connectivityParameters;
        private ConnectionHttpParameters _invocationHttpParameters;
        private ConnectionOAuthResponseParameters _oAuthParameters;

        /// <summary>
        /// Gets and sets the property ApiKeyAuthParameters. 
        /// <para>
        /// The API Key parameters to use for authorization.
        /// </para>
        /// </summary>
        public ConnectionApiKeyAuthResponseParameters ApiKeyAuthParameters
        {
            get { return this._apiKeyAuthParameters; }
            set { this._apiKeyAuthParameters = value; }
        }

        // Check to see if ApiKeyAuthParameters property is set
        internal bool IsSetApiKeyAuthParameters()
        {
            return this._apiKeyAuthParameters != null;
        }

        /// <summary>
        /// Gets and sets the property BasicAuthParameters. 
        /// <para>
        /// The authorization parameters for Basic authorization.
        /// </para>
        /// </summary>
        public ConnectionBasicAuthResponseParameters BasicAuthParameters
        {
            get { return this._basicAuthParameters; }
            set { this._basicAuthParameters = value; }
        }

        // Check to see if BasicAuthParameters property is set
        internal bool IsSetBasicAuthParameters()
        {
            return this._basicAuthParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectivityParameters. 
        /// <para>
        /// For private OAuth authentication endpoints. The parameters EventBridge uses to authenticate
        /// against the endpoint.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-target-connection-auth.html">Authorization
        /// methods for connections</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        /// </summary>
        public DescribeConnectionConnectivityParameters ConnectivityParameters
        {
            get { return this._connectivityParameters; }
            set { this._connectivityParameters = value; }
        }

        // Check to see if ConnectivityParameters property is set
        internal bool IsSetConnectivityParameters()
        {
            return this._connectivityParameters != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationHttpParameters. 
        /// <para>
        /// Additional parameters for the connection that are passed through with every invocation
        /// to the HTTP endpoint.
        /// </para>
        /// </summary>
        public ConnectionHttpParameters InvocationHttpParameters
        {
            get { return this._invocationHttpParameters; }
            set { this._invocationHttpParameters = value; }
        }

        // Check to see if InvocationHttpParameters property is set
        internal bool IsSetInvocationHttpParameters()
        {
            return this._invocationHttpParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthParameters. 
        /// <para>
        /// The OAuth parameters to use for authorization.
        /// </para>
        /// </summary>
        public ConnectionOAuthResponseParameters OAuthParameters
        {
            get { return this._oAuthParameters; }
            set { this._oAuthParameters = value; }
        }

        // Check to see if OAuthParameters property is set
        internal bool IsSetOAuthParameters()
        {
            return this._oAuthParameters != null;
        }

    }
}