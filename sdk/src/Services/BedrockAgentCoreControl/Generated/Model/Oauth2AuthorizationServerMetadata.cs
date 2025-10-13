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
    /// Contains the authorization server metadata for an OAuth2 provider.
    /// </summary>
    public partial class Oauth2AuthorizationServerMetadata
    {
        private string _authorizationEndpoint;
        private string _issuer;
        private List<string> _responseTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tokenEndpoint;
        private List<string> _tokenEndpointAuthMethods = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint URL for the OAuth2 authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL for the OAuth2 authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseTypes. 
        /// <para>
        /// The supported response types for the OAuth2 authorization server.
        /// </para>
        /// </summary>
        public List<string> ResponseTypes
        {
            get { return this._responseTypes; }
            set { this._responseTypes = value; }
        }

        // Check to see if ResponseTypes property is set
        internal bool IsSetResponseTypes()
        {
            return this._responseTypes != null && (this._responseTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint URL for the OAuth2 authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TokenEndpoint
        {
            get { return this._tokenEndpoint; }
            set { this._tokenEndpoint = value; }
        }

        // Check to see if TokenEndpoint property is set
        internal bool IsSetTokenEndpoint()
        {
            return this._tokenEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property TokenEndpointAuthMethods. 
        /// <para>
        /// The authentication methods supported by the token endpoint. This specifies how clients
        /// can authenticate when requesting tokens from the authorization server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> TokenEndpointAuthMethods
        {
            get { return this._tokenEndpointAuthMethods; }
            set { this._tokenEndpointAuthMethods = value; }
        }

        // Check to see if TokenEndpointAuthMethods property is set
        internal bool IsSetTokenEndpointAuthMethods()
        {
            return this._tokenEndpointAuthMethods != null && (this._tokenEndpointAuthMethods.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}