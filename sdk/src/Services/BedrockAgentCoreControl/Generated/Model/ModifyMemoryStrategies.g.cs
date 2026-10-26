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
    /// Contains information for modifying memory strategies.
    /// </summary>
    public partial class ModifyMemoryStrategies
    {
        /// <summary>
        /// Gets and sets the property AddMemoryStrategies. 
        /// <para>
        /// The list of memory strategies to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemoryStrategyInput> AddMemoryStrategies { get; set; } = AWSConfigs.InitializeCollections ? new List<MemoryStrategyInput>() : null;

        /// <summary>
        /// Checks to see if the AddMemoryStrategies property is set.
        /// </summary>
        internal bool IsSetAddMemoryStrategies() => this.AddMemoryStrategies != null && (this.AddMemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeleteMemoryStrategies. 
        /// <para>
        /// The list of memory strategies to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeleteMemoryStrategyInput> DeleteMemoryStrategies { get; set; } = AWSConfigs.InitializeCollections ? new List<DeleteMemoryStrategyInput>() : null;

        /// <summary>
        /// Checks to see if the DeleteMemoryStrategies property is set.
        /// </summary>
        internal bool IsSetDeleteMemoryStrategies() => this.DeleteMemoryStrategies != null && (this.DeleteMemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateMemoryStrategies. 
        /// <para>
        /// The list of memory strategies to modify.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModifyMemoryStrategyInput> UpdateMemoryStrategies { get; set; } = AWSConfigs.InitializeCollections ? new List<ModifyMemoryStrategyInput>() : null;

        /// <summary>
        /// Checks to see if the UpdateMemoryStrategies property is set.
        /// </summary>
        internal bool IsSetUpdateMemoryStrategies() => this.UpdateMemoryStrategies != null && (this.UpdateMemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
