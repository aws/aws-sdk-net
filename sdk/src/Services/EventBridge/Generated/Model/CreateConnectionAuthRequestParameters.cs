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
    /// The authorization parameters for the connection.
    /// 
    ///  
    /// <para>
    /// You must include only authorization parameters for the <c>AuthorizationType</c> you
    /// specify.
    /// </para>
    /// </summary>
    public partial class CreateConnectionAuthRequestParameters
    {
        private CreateConnectionApiKeyAuthRequestParameters _apiKeyAuthParameters;
        private CreateConnectionBasicAuthRequestParameters _basicAuthParameters;
        private ConnectivityResourceParameters _connectivityParameters;
        private ConnectionHttpParameters _invocationHttpParameters;
        private CreateConnectionOAuthRequestParameters _oAuthParameters;

        /// <summary>
        /// Gets and sets the property ApiKeyAuthParameters. 
        /// <para>
        /// The API key authorization parameters to use for the connection.
        /// </para>
        /// </summary>
        public CreateConnectionApiKeyAuthRequestParameters ApiKeyAuthParameters
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
        /// The Basic authorization parameters to use for the connection.
        /// </para>
        /// </summary>
        public CreateConnectionBasicAuthRequestParameters BasicAuthParameters
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
        /// If you specify a private OAuth endpoint, the parameters for EventBridge to use when
        /// authenticating against the endpoint.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-target-connection-auth.html">Authorization
        /// methods for connections</a> in the <i> <i>Amazon EventBridge User Guide</i> </i>.
        /// </para>
        /// </summary>
        public ConnectivityResourceParameters ConnectivityParameters
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
        /// The API key authorization parameters to use for the connection. Note that if you include
        /// additional parameters for the target of a rule via <c>HttpParameters</c>, including
        /// query strings, the parameters added for the connection take precedence.
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
        /// The OAuth authorization parameters to use for the connection.
        /// </para>
        /// </summary>
        public CreateConnectionOAuthRequestParameters OAuthParameters
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