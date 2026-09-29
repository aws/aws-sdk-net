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
    /// The subtotal options.
    /// </summary>
    public partial class SubtotalOptions
    {
        /// <summary>
        /// Gets and sets the property CustomLabel. 
        /// <para>
        /// The custom label string for the subtotal cells.
        /// </para>
        /// </summary>
        public string CustomLabel { get; set; }

        /// <summary>
        /// Checks to see if the CustomLabel property is set.
        /// </summary>
        internal bool IsSetCustomLabel() => this.CustomLabel != null;

        /// <summary>
        /// Gets and sets the property FieldLevel. 
        /// <para>
        /// The field level (all, custom, last) for the subtotal cells.
        /// </para>
        /// </summary>
        public PivotTableSubtotalLevel FieldLevel { get; set; }

        /// <summary>
        /// Checks to see if the FieldLevel property is set.
        /// </summary>
        internal bool IsSetFieldLevel() => this.FieldLevel != null;

        /// <summary>
        /// Gets and sets the property FieldLevelOptions. 
        /// <para>
        /// The optional configuration of subtotal cells.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<PivotTableFieldSubtotalOptions> FieldLevelOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<PivotTableFieldSubtotalOptions>() : null;

        /// <summary>
        /// Checks to see if the FieldLevelOptions property is set.
        /// </summary>
        internal bool IsSetFieldLevelOptions() => this.FieldLevelOptions != null && (this.FieldLevelOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricHeaderCellStyle. 
        /// <para>
        /// The cell styling options for the subtotals of header cells.
        /// </para>
        /// </summary>
        public TableCellStyle MetricHeaderCellStyle { get; set; }

        /// <summary>
        /// Checks to see if the MetricHeaderCellStyle property is set.
        /// </summary>
        internal bool IsSetMetricHeaderCellStyle() => this.MetricHeaderCellStyle != null;

        /// <summary>
        /// Gets and sets the property StyleTargets. 
        /// <para>
        /// The style targets options for subtotals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<TableStyleTarget> StyleTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<TableStyleTarget>() : null;

        /// <summary>
        /// Checks to see if the StyleTargets property is set.
        /// </summary>
        internal bool IsSetStyleTargets() => this.StyleTargets != null && (this.StyleTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalCellStyle. 
        /// <para>
        /// The cell styling options for the subtotal cells.
        /// </para>
        /// </summary>
        public TableCellStyle TotalCellStyle { get; set; }

        /// <summary>
        /// Checks to see if the TotalCellStyle property is set.
        /// </summary>
        internal bool IsSetTotalCellStyle() => this.TotalCellStyle != null;

        /// <summary>
        /// Gets and sets the property TotalsVisibility. 
        /// <para>
        /// The visibility configuration for the subtotal cells.
        /// </para>
        /// </summary>
        public Visibility TotalsVisibility { get; set; }

        /// <summary>
        /// Checks to see if the TotalsVisibility property is set.
        /// </summary>
        internal bool IsSetTotalsVisibility() => this.TotalsVisibility != null;

        /// <summary>
        /// Gets and sets the property ValueCellStyle. 
        /// <para>
        /// The cell styling options for the subtotals of value cells.
        /// </para>
        /// </summary>
        public TableCellStyle ValueCellStyle { get; set; }

        /// <summary>
        /// Checks to see if the ValueCellStyle property is set.
        /// </summary>
        internal bool IsSetValueCellStyle() => this.ValueCellStyle != null;
    }
}
