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
    /// Configuration for inbound JWT-based authorization, specifying how incoming requests
    /// should be authenticated.
    /// </summary>
    public partial class CustomJWTAuthorizerConfiguration
    {
        private List<string> _allowedAudience = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedClients = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _discoveryUrl;

        /// <summary>
        /// Gets and sets the property AllowedAudience. 
        /// <para>
        /// Represents individual audience values that are validated in the incoming JWT token
        /// validation process.
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
        /// Represents individual client IDs that are validated in the incoming JWT token validation
        /// process.
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
        /// Gets and sets the property DiscoveryUrl. 
        /// <para>
        /// This URL is used to fetch OpenID Connect configuration or authorization server metadata
        /// for validating incoming tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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