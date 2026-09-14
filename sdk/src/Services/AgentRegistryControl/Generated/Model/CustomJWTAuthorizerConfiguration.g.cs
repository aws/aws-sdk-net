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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Configuration for a custom JWT authorizer that validates inbound bearer tokens against
    /// an OpenID Connect identity provider.
    /// </summary>
    public partial class CustomJWTAuthorizerConfiguration
    {
        /// <summary>
        /// Gets and sets the property AllowedAudience. 
        /// <para>
        /// The audience values accepted during JWT validation. A token is rejected if none of
        /// its audience claims match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> AllowedAudience { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedAudience property is set.
        /// </summary>
        internal bool IsSetAllowedAudience() => this.AllowedAudience != null && (this.AllowedAudience.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedClients. 
        /// <para>
        /// The client identifiers accepted during JWT validation. A token is rejected if it was
        /// not issued to one of these clients.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> AllowedClients { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedClients property is set.
        /// </summary>
        internal bool IsSetAllowedClients() => this.AllowedClients != null && (this.AllowedClients.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedScopes. 
        /// <para>
        /// The scopes accepted during JWT validation. A token is rejected if it does not carry
        /// one of these scopes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> AllowedScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedScopes property is set.
        /// </summary>
        internal bool IsSetAllowedScopes() => this.AllowedScopes != null && (this.AllowedScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomClaims. 
        /// <para>
        /// Additional custom claim validations applied to the inbound JWT.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<CustomClaimValidationType> CustomClaims { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomClaimValidationType>() : null;

        /// <summary>
        /// Checks to see if the CustomClaims property is set.
        /// </summary>
        internal bool IsSetCustomClaims() => this.CustomClaims != null && (this.CustomClaims.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DiscoveryUrl. 
        /// <para>
        /// The OpenID Connect discovery URL used to retrieve the identity provider's metadata
        /// and signing keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string DiscoveryUrl { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryUrl property is set.
        /// </summary>
        internal bool IsSetDiscoveryUrl() => this.DiscoveryUrl != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpoint. 
        /// <para>
        /// The private endpoint used to reach the identity provider's discovery URL over a private
        /// network path.
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
        /// Per-domain private endpoint overrides that route specific identity provider domains
        /// through distinct private endpoints.
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
    }
}
