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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Output configuration for a custom OAuth2 provider.
    /// </summary>
    public partial class CustomOauth2ProviderConfigOutput
    {
        /// <summary>
        /// Gets and sets the property ClientAuthenticationMethod. 
        /// <para>
        /// The client authentication method used when authenticating with the token endpoint.
        /// </para>
        /// </summary>
        public ClientAuthenticationMethodType ClientAuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ClientAuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetClientAuthenticationMethod() => this.ClientAuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the custom OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property OauthDiscovery. 
        /// <para>
        /// The OAuth2 discovery information for the custom provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Oauth2Discovery OauthDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the OauthDiscovery property is set.
        /// </summary>
        internal bool IsSetOauthDiscovery() => this.OauthDiscovery != null;

        /// <summary>
        /// Gets and sets the property OnBehalfOfTokenExchangeConfig. 
        /// <para>
        /// The configuration for on-behalf-of token exchange.
        /// </para>
        /// </summary>
        public OnBehalfOfTokenExchangeConfigType OnBehalfOfTokenExchangeConfig { get; set; }

        /// <summary>
        /// Checks to see if the OnBehalfOfTokenExchangeConfig property is set.
        /// </summary>
        internal bool IsSetOnBehalfOfTokenExchangeConfig() => this.OnBehalfOfTokenExchangeConfig != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The default private endpoint for the custom OAuth2 provider, enabling secure connectivity
        /// through a VPC Lattice resource configuration.
        /// </para>
        /// </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpoint property is set.
        /// </summary>
        internal bool IsSetPrivateEndpoint() => this.PrivateEndpoint != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpointOverrides. 
        /// <para>
        /// The private endpoint overrides for the custom OAuth2 provider configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<PrivateEndpointOverride> PrivateEndpointOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<PrivateEndpointOverride>() : null;

        /// <summary>
        /// Checks to see if the PrivateEndpointOverrides property is set.
        /// </summary>
        internal bool IsSetPrivateEndpointOverrides() => this.PrivateEndpointOverrides != null && (this.PrivateEndpointOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrivateKeyJwtConfig. 
        /// <para>
        /// The configuration for private_key_jwt client authentication used by this OAuth2 credential
        /// provider.
        /// </para>
        /// </summary>
        public PrivateKeyJwtConfig PrivateKeyJwtConfig { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKeyJwtConfig property is set.
        /// </summary>
        internal bool IsSetPrivateKeyJwtConfig() => this.PrivateKeyJwtConfig != null;
    }
}
