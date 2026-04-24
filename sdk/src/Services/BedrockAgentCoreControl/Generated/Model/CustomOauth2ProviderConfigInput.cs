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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Input configuration for a custom OAuth2 provider.
    /// </summary>
    public partial class CustomOauth2ProviderConfigInput
    {
        private string _clientId;
        private string _clientSecret;
        private Oauth2Discovery _oauthDiscovery;
        private PrivateEndpoint _privateEndpoint;
        private List<PrivateEndpointOverride> _privateEndpointOverrides = AWSConfigs.InitializeCollections ? new List<PrivateEndpointOverride>() : null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the custom OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret for the custom OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
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
        /// Gets and sets the property OauthDiscovery. 
        /// <para>
        /// The OAuth2 discovery information for the custom provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Oauth2Discovery OauthDiscovery
        {
            get { return this._oauthDiscovery; }
            set { this._oauthDiscovery = value; }
        }

        // Check to see if OauthDiscovery property is set
        internal bool IsSetOauthDiscovery()
        {
            return this._oauthDiscovery != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The default private endpoint for the custom OAuth2 provider, enabling secure connectivity
        /// through a VPC Lattice resource configuration.
        /// </para>
        /// </summary>
        public PrivateEndpoint PrivateEndpoint
        {
            get { return this._privateEndpoint; }
            set { this._privateEndpoint = value; }
        }

        // Check to see if PrivateEndpoint property is set
        internal bool IsSetPrivateEndpoint()
        {
            return this._privateEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateEndpointOverrides. 
        /// <para>
        /// The list of private endpoint overrides for the custom OAuth2 provider. Each override
        /// maps a specific domain to a private endpoint, enabling secure connectivity through
        /// VPC Lattice resource configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<PrivateEndpointOverride> PrivateEndpointOverrides
        {
            get { return this._privateEndpointOverrides; }
            set { this._privateEndpointOverrides = value; }
        }

        // Check to see if PrivateEndpointOverrides property is set
        internal bool IsSetPrivateEndpointOverrides()
        {
            return this._privateEndpointOverrides != null && (this._privateEndpointOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}