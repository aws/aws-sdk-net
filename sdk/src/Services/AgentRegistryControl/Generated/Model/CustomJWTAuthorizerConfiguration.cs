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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Configuration for a custom JWT authorizer that validates inbound bearer tokens against
    /// an OpenID Connect identity provider.
    /// </summary>
    public partial class CustomJWTAuthorizerConfiguration
    {
        private List<string> _allowedAudience = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedClients = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<CustomClaimValidationType> _customClaims = AWSConfigs.InitializeCollections ? new List<CustomClaimValidationType>() : null;
        private string _discoveryUrl;
        private PrivateEndpoint _privateEndpoint;
        private List<PrivateEndpointOverride> _privateEndpointOverrides = AWSConfigs.InitializeCollections ? new List<PrivateEndpointOverride>() : null;

        /// <summary>
        /// Gets and sets the property AllowedAudience. 
        /// <para>
        /// The audience values accepted during JWT validation. A token is rejected if none of
        /// its audience claims match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> AllowedAudience
        {
            get { return this._allowedAudience; }
            set { this._allowedAudience = value; }
        }

        // Check to see if AllowedAudience property is set
        internal bool IsSetAllowedAudience()
        {
            return this._allowedAudience != null && (this._allowedAudience.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedClients. 
        /// <para>
        /// The client identifiers accepted during JWT validation. A token is rejected if it was
        /// not issued to one of these clients.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> AllowedClients
        {
            get { return this._allowedClients; }
            set { this._allowedClients = value; }
        }

        // Check to see if AllowedClients property is set
        internal bool IsSetAllowedClients()
        {
            return this._allowedClients != null && (this._allowedClients.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedScopes. 
        /// <para>
        /// The scopes accepted during JWT validation. A token is rejected if it does not carry
        /// one of these scopes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> AllowedScopes
        {
            get { return this._allowedScopes; }
            set { this._allowedScopes = value; }
        }

        // Check to see if AllowedScopes property is set
        internal bool IsSetAllowedScopes()
        {
            return this._allowedScopes != null && (this._allowedScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomClaims. 
        /// <para>
        /// Additional custom claim validations applied to the inbound JWT.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<CustomClaimValidationType> CustomClaims
        {
            get { return this._customClaims; }
            set { this._customClaims = value; }
        }

        // Check to see if CustomClaims property is set
        internal bool IsSetCustomClaims()
        {
            return this._customClaims != null && (this._customClaims.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DiscoveryUrl. 
        /// <para>
        /// The OpenID Connect discovery URL used to retrieve the identity provider's metadata
        /// and signing keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DiscoveryUrl
        {
            get { return this._discoveryUrl; }
            set { this._discoveryUrl = value; }
        }

        // Check to see if DiscoveryUrl property is set
        internal bool IsSetDiscoveryUrl()
        {
            return this._discoveryUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The private endpoint used to reach the identity provider's discovery URL over a private
        /// network path.
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
        /// Per-domain private endpoint overrides that route specific identity provider domains
        /// through distinct private endpoints.
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