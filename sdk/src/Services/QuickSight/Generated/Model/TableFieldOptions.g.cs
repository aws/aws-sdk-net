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
    /// The field options of a table visual.
    /// </summary>
    public partial class TableFieldOptions
    {
        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order of the field IDs that are configured as field options for a table visual.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> Order { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order != null && (this.Order.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PinnedFieldOptions. 
        /// <para>
        /// The settings for the pinned columns of a table visual.
        /// </para>
        /// </summary>
        public TablePinnedFieldOptions PinnedFieldOptions { get; set; }

        /// <summary>
        /// Checks to see if the PinnedFieldOptions property is set.
        /// </summary>
        internal bool IsSetPinnedFieldOptions() => this.PinnedFieldOptions != null;

        /// <summary>
        /// Gets and sets the property SelectedFieldOptions. 
        /// <para>
        /// The field options to be configured to a table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 201)]
        public List<TableFieldOption> SelectedFieldOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<TableFieldOption>() : null;

        /// <summary>
        /// Checks to see if the SelectedFieldOptions property is set.
        /// </summary>
        internal bool IsSetSelectedFieldOptions() => this.SelectedFieldOptions != null && (this.SelectedFieldOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransposedTableOptions. 
        /// <para>
        /// The <c>TableOptions</c> of a transposed table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10001)]
        public List<TransposedTableOption> TransposedTableOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<TransposedTableOption>() : null;

        /// <summary>
        /// Checks to see if the TransposedTableOptions property is set.
        /// </summary>
        internal bool IsSetTransposedTableOptions() => this.TransposedTableOptions != null && (this.TransposedTableOptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
