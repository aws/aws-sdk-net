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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// OAuth 3-legged authorization configuration for MCP server.
    /// </summary>
    public partial class MCPServerOAuth3LOConfig
    {
        private string _authorizationUrl;
        private string _clientId;
        private string _clientName;
        private string _clientSecret;
        private Dictionary<string, string> _exchangeParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _exchangeUrl;
        private string _returnToEndpoint;
        private List<string> _scopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _supportCodeChallenge;

        /// <summary>
        /// Gets and sets the property AuthorizationUrl. 
        /// <para>
        /// OAuth authorization URL for 3LO authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// OAuth client ID for authenticating with the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientName. 
        /// <para>
        /// User friendly OAuth client name specified by end user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientName
        {
            get { return this._clientName; }
            set { this._clientName = value; }
        }

        // Check to see if ClientName property is set
        internal bool IsSetClientName()
        {
            return this._clientName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// OAuth client secret for authenticating with the service. Required for confidential
        /// clients or when PKCE is not supported. Optional for public clients using PKCE.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=512)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property ExchangeParameters. 
        /// <para>
        /// OAuth token exchange parameters for authenticating with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExchangeParameters
        {
            get { return this._exchangeParameters; }
            set { this._exchangeParameters = value; }
        }

        // Check to see if ExchangeParameters property is set
        internal bool IsSetExchangeParameters()
        {
            return this._exchangeParameters != null && (this._exchangeParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExchangeUrl. 
        /// <para>
        /// OAuth token exchange URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExchangeUrl
        {
            get { return this._exchangeUrl; }
            set { this._exchangeUrl = value; }
        }

        // Check to see if ExchangeUrl property is set
        internal bool IsSetExchangeUrl()
        {
            return this._exchangeUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnToEndpoint. 
        /// <para>
        /// The endpoint to return to after OAuth flow completes (must be AWS console domain)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReturnToEndpoint
        {
            get { return this._returnToEndpoint; }
            set { this._returnToEndpoint = value; }
        }

        // Check to see if ReturnToEndpoint property is set
        internal bool IsSetReturnToEndpoint()
        {
            return this._returnToEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// OAuth scopes for 3LO authentication. The service will always request scope offline_access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && (this._scopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportCodeChallenge. 
        /// <para>
        /// Whether the service supports PKCE (Proof Key for Code Exchange) for enhanced security
        /// during the OAuth flow.
        /// </para>
        /// </summary>
        public bool? SupportCodeChallenge
        {
            get { return this._supportCodeChallenge; }
            set { this._supportCodeChallenge = value; }
        }

        // Check to see if SupportCodeChallenge property is set
        internal bool IsSetSupportCodeChallenge()
        {
            return this._supportCodeChallenge.HasValue; 
        }

    }
}