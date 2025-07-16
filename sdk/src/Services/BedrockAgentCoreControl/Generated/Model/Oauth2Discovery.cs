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
    /// Contains the discovery information for an OAuth2 provider.
    /// </summary>
    public partial class Oauth2Discovery
    {
        private Oauth2AuthorizationServerMetadata _authorizationServerMetadata;
        private string _discoveryUrl;

        /// <summary>
        /// Gets and sets the property AuthorizationServerMetadata. 
        /// <para>
        /// The authorization server metadata for the OAuth2 provider.
        /// </para>
        /// </summary>
        public Oauth2AuthorizationServerMetadata AuthorizationServerMetadata
        {
            get { return this._authorizationServerMetadata; }
            set { this._authorizationServerMetadata = value; }
        }

        // Check to see if AuthorizationServerMetadata property is set
        internal bool IsSetAuthorizationServerMetadata()
        {
            return this._authorizationServerMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property DiscoveryUrl. 
        /// <para>
        /// The discovery URL for the OAuth2 provider.
        /// </para>
        /// </summary>
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

    }
}