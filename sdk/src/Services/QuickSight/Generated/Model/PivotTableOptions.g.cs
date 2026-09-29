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
    /// The table options for a pivot table visual.
    /// </summary>
    public partial class PivotTableOptions
    {
        /// <summary>
        /// Gets and sets the property CellStyle. 
        /// <para>
        /// The table cell style of cells.
        /// </para>
        /// </summary>
        public TableCellStyle CellStyle { get; set; }

        /// <summary>
        /// Checks to see if the CellStyle property is set.
        /// </summary>
        internal bool IsSetCellStyle() => this.CellStyle != null;

        /// <summary>
        /// Gets and sets the property CollapsedRowDimensionsVisibility. 
        /// <para>
        /// The visibility setting of a pivot table's collapsed row dimension fields. If the value
        /// of this structure is <c>HIDDEN</c>, all collapsed columns in a pivot table are automatically
        /// hidden. The default value is <c>VISIBLE</c>.
        /// </para>
        /// </summary>
        public Visibility CollapsedRowDimensionsVisibility { get; set; }

        /// <summary>
        /// Checks to see if the CollapsedRowDimensionsVisibility property is set.
        /// </summary>
        internal bool IsSetCollapsedRowDimensionsVisibility() => this.CollapsedRowDimensionsVisibility != null;

        /// <summary>
        /// Gets and sets the property ColumnHeaderStyle. 
        /// <para>
        /// The table cell style of the column header.
        /// </para>
        /// </summary>
        public TableCellStyle ColumnHeaderStyle { get; set; }

        /// <summary>
        /// Checks to see if the ColumnHeaderStyle property is set.
        /// </summary>
        internal bool IsSetColumnHeaderStyle() => this.ColumnHeaderStyle != null;

        /// <summary>
        /// Gets and sets the property ColumnNamesVisibility. 
        /// <para>
        /// The visibility of the column names.
        /// </para>
        /// </summary>
        public Visibility ColumnNamesVisibility { get; set; }

        /// <summary>
        /// Checks to see if the ColumnNamesVisibility property is set.
        /// </summary>
        internal bool IsSetColumnNamesVisibility() => this.ColumnNamesVisibility != null;

        /// <summary>
        /// Gets and sets the property DefaultCellWidth. 
        /// <para>
        /// The default cell width of the pivot table.
        /// </para>
        /// </summary>
        public string DefaultCellWidth { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCellWidth property is set.
        /// </summary>
        internal bool IsSetDefaultCellWidth() => this.DefaultCellWidth != null;

        /// <summary>
        /// Gets and sets the property MetricPlacement. 
        /// <para>
        /// The metric placement (row, column) options.
        /// </para>
        /// </summary>
        public PivotTableMetricPlacement MetricPlacement { get; set; }

        /// <summary>
        /// Checks to see if the MetricPlacement property is set.
        /// </summary>
        internal bool IsSetMetricPlacement() => this.MetricPlacement != null;

        /// <summary>
        /// Gets and sets the property RowAlternateColorOptions. 
        /// <para>
        /// The row alternate color options (widget status, row alternate colors).
        /// </para>
        /// </summary>
        public RowAlternateColorOptions RowAlternateColorOptions { get; set; }

        /// <summary>
        /// Checks to see if the RowAlternateColorOptions property is set.
        /// </summary>
        internal bool IsSetRowAlternateColorOptions() => this.RowAlternateColorOptions != null;

        /// <summary>
        /// Gets and sets the property RowFieldNamesStyle. 
        /// <para>
        /// The table cell style of row field names.
        /// </para>
        /// </summary>
        public TableCellStyle RowFieldNamesStyle { get; set; }

        /// <summary>
        /// Checks to see if the RowFieldNamesStyle property is set.
        /// </summary>
        internal bool IsSetRowFieldNamesStyle() => this.RowFieldNamesStyle != null;

        /// <summary>
        /// Gets and sets the property RowHeaderStyle. 
        /// <para>
        /// The table cell style of the row headers.
        /// </para>
        /// </summary>
        public TableCellStyle RowHeaderStyle { get; set; }

        /// <summary>
        /// Checks to see if the RowHeaderStyle property is set.
        /// </summary>
        internal bool IsSetRowHeaderStyle() => this.RowHeaderStyle != null;

        /// <summary>
        /// Gets and sets the property RowsLabelOptions. 
        /// <para>
        /// The options for the label that is located above the row headers. This option is only
        /// applicable when <c>RowsLayout</c> is set to <c>HIERARCHY</c>.
        /// </para>
        /// </summary>
        public PivotTableRowsLabelOptions RowsLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the RowsLabelOptions property is set.
        /// </summary>
        internal bool IsSetRowsLabelOptions() => this.RowsLabelOptions != null;

        /// <summary>
        /// Gets and sets the property RowsLayout. 
        /// <para>
        /// The layout for the row dimension headers of a pivot table. Choose one of the following
        /// options.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TABULAR</c>: (Default) Each row field is displayed in a separate column.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HIERARCHY</c>: All row fields are displayed in a single column. Indentation is
        /// used to differentiate row headers of different fields.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PivotTableRowsLayout RowsLayout { get; set; }

        /// <summary>
        /// Checks to see if the RowsLayout property is set.
        /// </summary>
        internal bool IsSetRowsLayout() => this.RowsLayout != null;

        /// <summary>
        /// Gets and sets the property SingleMetricVisibility. 
        /// <para>
        /// The visibility of the single metric options.
        /// </para>
        /// </summary>
        public Visibility SingleMetricVisibility { get; set; }

        /// <summary>
        /// Checks to see if the SingleMetricVisibility property is set.
        /// </summary>
        internal bool IsSetSingleMetricVisibility() => this.SingleMetricVisibility != null;

        /// <summary>
        /// Gets and sets the property ToggleButtonsVisibility. 
        /// <para>
        /// Determines the visibility of the pivot table.
        /// </para>
        /// </summary>
        public Visibility ToggleButtonsVisibility { get; set; }

        /// <summary>
        /// Checks to see if the ToggleButtonsVisibility property is set.
        /// </summary>
        internal bool IsSetToggleButtonsVisibility() => this.ToggleButtonsVisibility != null;
    }
}
