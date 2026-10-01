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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The plugin visual configuration. This includes the field wells, sorting options, and
    /// persisted options of the plugin visual.
    /// </summary>
    public partial class PluginVisualConfiguration
    {
        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells configuration of the plugin visual.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<PluginVisualFieldWell> FieldWells { get; set; } = AWSConfigs.InitializeCollections ? new List<PluginVisualFieldWell>() : null;

        /// <summary>
        /// Checks to see if the FieldWells property is set.
        /// </summary>
        internal bool IsSetFieldWells() => this.FieldWells != null && (this.FieldWells.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of the plugin visual.
        /// </para>
        /// </summary>
        public PluginVisualSortConfiguration SortConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SortConfiguration property is set.
        /// </summary>
        internal bool IsSetSortConfiguration() => this.SortConfiguration != null;

        /// <summary>
        /// Gets and sets the property VisualOptions. 
        /// <para>
        /// The persisted properties of the plugin visual.
        /// </para>
        /// </summary>
        public PluginVisualOptions VisualOptions { get; set; }

        /// <summary>
        /// Checks to see if the VisualOptions property is set.
        /// </summary>
        internal bool IsSetVisualOptions() => this.VisualOptions != null;
    }
}
