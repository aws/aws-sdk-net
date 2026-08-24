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
    /// A single rule entry within a limit, mapping dimension values to rate configurations
    /// </summary>
    public partial class LimitEntry
    {
        private List<RateConfig> _connections = AWSConfigs.InitializeCollections ? new List<RateConfig>() : null;
        private Dictionary<string, string> _dimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<RateConfig> _requests = AWSConfigs.InitializeCollections ? new List<RateConfig>() : null;
        private List<RateConfig> _tokens = AWSConfigs.InitializeCollections ? new List<RateConfig>() : null;

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// Connection rate limits (per second only). Limited to 1 entry for now. — P2
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<RateConfig> Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null && (this._connections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// Map of dimension name to dimension value, matching the parent limit's dimensionKeys.
        /// Keys must exactly match the dimensionKeys. Values may be &quot;<em>&quot; as a wildcard.
        /// &quot;</em>&quot; may only appear at trailing positions (based on dimensionKeys ordering).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public Dictionary<string, string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Requests. 
        /// <para>
        /// Request rate limits (RPS or RPM). Limited to 1 entry for now.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<RateConfig> Requests
        {
            get { return this._requests; }
            set { this._requests = value; }
        }

        // Check to see if Requests property is set
        internal bool IsSetRequests()
        {
            return this._requests != null && (this._requests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tokens. 
        /// <para>
        /// Token rate limits (TPM). Limited to 1 entry for now. — P1
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<RateConfig> Tokens
        {
            get { return this._tokens; }
            set { this._tokens = value; }
        }

        // Check to see if Tokens property is set
        internal bool IsSetTokens()
        {
            return this._tokens != null && (this._tokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}