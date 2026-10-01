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
    /// The field options for a pivot table visual.
    /// </summary>
    public partial class PivotTableFieldOptions
    {
        /// <summary>
        /// Gets and sets the property CollapseStateOptions. 
        /// <para>
        /// The collapse state options for the pivot table field options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PivotTableFieldCollapseStateOption> CollapseStateOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<PivotTableFieldCollapseStateOption>() : null;

        /// <summary>
        /// Checks to see if the CollapseStateOptions property is set.
        /// </summary>
        internal bool IsSetCollapseStateOptions() => this.CollapseStateOptions != null && (this.CollapseStateOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataPathOptions. 
        /// <para>
        /// The data path options for the pivot table field options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PivotTableDataPathOption> DataPathOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<PivotTableDataPathOption>() : null;

        /// <summary>
        /// Checks to see if the DataPathOptions property is set.
        /// </summary>
        internal bool IsSetDataPathOptions() => this.DataPathOptions != null && (this.DataPathOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SelectedFieldOptions. 
        /// <para>
        /// The selected field options for the pivot table field options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PivotTableFieldOption> SelectedFieldOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<PivotTableFieldOption>() : null;

        /// <summary>
        /// Checks to see if the SelectedFieldOptions property is set.
        /// </summary>
        internal bool IsSetSelectedFieldOptions() => this.SelectedFieldOptions != null && (this.SelectedFieldOptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
