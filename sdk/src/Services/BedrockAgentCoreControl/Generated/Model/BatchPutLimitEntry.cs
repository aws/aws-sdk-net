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
    /// A limit definition within a BatchPut request (rateLimitId used for upsert matching)
    /// </summary>
    public partial class BatchPutLimitEntry
    {
        private string _description;
        private List<string> _dimensionKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<LimitEntry> _entries = AWSConfigs.InitializeCollections ? new List<LimitEntry>() : null;
        private string _rateLimitId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional human-readable description for this limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DimensionKeys.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> DimensionKeys
        {
            get { return this._dimensionKeys; }
            set { this._dimensionKeys = value; }
        }

        // Check to see if DimensionKeys property is set
        internal bool IsSetDimensionKeys()
        {
            return this._dimensionKeys != null && (this._dimensionKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Entries.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<LimitEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RateLimitId. 
        /// <para>
        /// Optional — if provided, used for upsert matching against existing limits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string RateLimitId
        {
            get { return this._rateLimitId; }
            set { this._rateLimitId = value; }
        }

        // Check to see if RateLimitId property is set
        internal bool IsSetRateLimitId()
        {
            return this._rateLimitId != null;
        }

    }
}