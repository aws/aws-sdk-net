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
    /// Contains the authorization server metadata for an OAuth2 provider.
    /// </summary>
    public partial class Oauth2AuthorizationServerMetadata
    {
        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint URL for the OAuth2 authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL for the OAuth2 authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property ResponseTypes. 
        /// <para>
        /// The supported response types for the OAuth2 authorization server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResponseTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResponseTypes property is set.
        /// </summary>
        internal bool IsSetResponseTypes() => this.ResponseTypes != null && (this.ResponseTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint URL for the OAuth2 authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;

        /// <summary>
        /// Gets and sets the property TokenEndpointAuthMethods. 
        /// <para>
        /// The authentication methods supported by the token endpoint. This specifies how clients
        /// can authenticate when requesting tokens from the authorization server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> TokenEndpointAuthMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenEndpointAuthMethods property is set.
        /// </summary>
        internal bool IsSetTokenEndpointAuthMethods() => this.TokenEndpointAuthMethods != null && (this.TokenEndpointAuthMethods.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
