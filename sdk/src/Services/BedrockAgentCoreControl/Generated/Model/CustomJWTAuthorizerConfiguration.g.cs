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
    /// Configuration for inbound JWT-based authorization, specifying how incoming requests
    /// should be authenticated.
    /// </summary>
    public partial class CustomJWTAuthorizerConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdvertisedScopeMapping. 
        /// <para>
        /// A map that associates each scope in <c>allowedScopes</c> with a corresponding advertised
        /// scope value. The advertised scope appears in OAuth protected resource metadata and
        /// <c>WWW-Authenticate</c> response headers. Use this parameter when the scope that clients
        /// request from your identity provider differs from the scope in the validated token.
        /// Each key is a scope from <c>allowedScopes</c> that the service uses for token validation.
        /// Each value is the corresponding scope that the service advertises to clients. Scopes
        /// without a mapping entry appear unchanged to clients.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> AdvertisedScopeMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdvertisedScopeMapping property is set.
        /// </summary>
        internal bool IsSetAdvertisedScopeMapping() => this.AdvertisedScopeMapping != null && (this.AdvertisedScopeMapping.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedAudience. 
        /// <para>
        /// Represents individual audience values that are validated in the incoming JWT token
        /// validation process.
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
        /// Represents individual client IDs that are validated in the incoming JWT token validation
        /// process.
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
        /// An array of scopes that are allowed to access the token.
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
        /// Gets and sets the property AllowedWorkloadConfiguration. 
        /// <para>
        /// The configuration that restricts which workloads in the request's identity chain are
        /// allowed to invoke the target, identified by their hosting environments and workload
        /// identities. At launch, this is supported only for AgentCore Runtime targets, and the
        /// allowed workloads are AgentCore Gateways.
        /// </para>
        /// </summary>
        public AllowedWorkloadConfiguration AllowedWorkloadConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AllowedWorkloadConfiguration property is set.
        /// </summary>
        internal bool IsSetAllowedWorkloadConfiguration() => this.AllowedWorkloadConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomClaims. 
        /// <para>
        /// An array of objects that define a custom claim validation name, value, and operation
        /// 
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
        /// This URL is used to fetch OpenID Connect configuration or authorization server metadata
        /// for validating incoming tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DiscoveryUrl { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryUrl property is set.
        /// </summary>
        internal bool IsSetDiscoveryUrl() => this.DiscoveryUrl != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpoint.
        /// </summary>
        public PrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PrivateEndpoint property is set.
        /// </summary>
        internal bool IsSetPrivateEndpoint() => this.PrivateEndpoint != null;

        /// <summary>
        /// Gets and sets the property PrivateEndpointOverrides. 
        /// <para>
        /// The private endpoint overrides for the custom JWT authorizer configuration.
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
