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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Settings for hierarchical document chunking for a data source. Hierarchical chunking
    /// splits documents into layers of chunks where the first layer contains large chunks,
    /// and the second layer contains smaller chunks derived from the first layer.
    /// </summary>
    public partial class HierarchicalChunkingConfiguration
    {
        private List<HierarchicalChunkingLevelConfiguration> _levelConfigurations = AWSConfigs.InitializeCollections ? new List<HierarchicalChunkingLevelConfiguration>() : null;
        private int? _overlapTokens;

        /// <summary>
        /// Gets and sets the property LevelConfigurations. 
        /// <para>
        /// Token settings for each layer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<HierarchicalChunkingLevelConfiguration> LevelConfigurations
        {
            get { return this._levelConfigurations; }
            set { this._levelConfigurations = value; }
        }

        // Check to see if LevelConfigurations property is set
        internal bool IsSetLevelConfigurations()
        {
            return this._levelConfigurations != null && (this._levelConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverlapTokens. 
        /// <para>
        /// The number of tokens to repeat across chunks in the same layer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? OverlapTokens
        {
            get { return this._overlapTokens; }
            set { this._overlapTokens = value; }
        }

        // Check to see if OverlapTokens property is set
        internal bool IsSetOverlapTokens()
        {
            return this._overlapTokens.HasValue; 
        }

    }
}