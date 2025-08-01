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
    /// Contains information for modifying memory strategies.
    /// </summary>
    public partial class ModifyMemoryStrategies
    {
        private List<MemoryStrategyInput> _addMemoryStrategies = AWSConfigs.InitializeCollections ? new List<MemoryStrategyInput>() : null;
        private List<DeleteMemoryStrategyInput> _deleteMemoryStrategies = AWSConfigs.InitializeCollections ? new List<DeleteMemoryStrategyInput>() : null;
        private List<ModifyMemoryStrategyInput> _updateMemoryStrategies = AWSConfigs.InitializeCollections ? new List<ModifyMemoryStrategyInput>() : null;

        /// <summary>
        /// Gets and sets the property AddMemoryStrategies. 
        /// <para>
        /// The list of memory strategies to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemoryStrategyInput> AddMemoryStrategies
        {
            get { return this._addMemoryStrategies; }
            set { this._addMemoryStrategies = value; }
        }

        // Check to see if AddMemoryStrategies property is set
        internal bool IsSetAddMemoryStrategies()
        {
            return this._addMemoryStrategies != null && (this._addMemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeleteMemoryStrategies. 
        /// <para>
        /// The list of memory strategies to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeleteMemoryStrategyInput> DeleteMemoryStrategies
        {
            get { return this._deleteMemoryStrategies; }
            set { this._deleteMemoryStrategies = value; }
        }

        // Check to see if DeleteMemoryStrategies property is set
        internal bool IsSetDeleteMemoryStrategies()
        {
            return this._deleteMemoryStrategies != null && (this._deleteMemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateMemoryStrategies. 
        /// <para>
        /// The list of memory strategies to modify.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModifyMemoryStrategyInput> UpdateMemoryStrategies
        {
            get { return this._updateMemoryStrategies; }
            set { this._updateMemoryStrategies = value; }
        }

        // Check to see if UpdateMemoryStrategies property is set
        internal bool IsSetUpdateMemoryStrategies()
        {
            return this._updateMemoryStrategies != null && (this._updateMemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}