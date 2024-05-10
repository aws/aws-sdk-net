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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private TableCellStyle _cellStyle;
        private Visibility _collapsedRowDimensionsVisibility;
        private TableCellStyle _columnHeaderStyle;
        private Visibility _columnNamesVisibility;
        private string _defaultCellWidth;
        private PivotTableMetricPlacement _metricPlacement;
        private RowAlternateColorOptions _rowAlternateColorOptions;
        private TableCellStyle _rowFieldNamesStyle;
        private TableCellStyle _rowHeaderStyle;
        private PivotTableRowsLabelOptions _rowsLabelOptions;
        private PivotTableRowsLayout _rowsLayout;
        private Visibility _singleMetricVisibility;
        private Visibility _toggleButtonsVisibility;

        /// <summary>
        /// Gets and sets the property CellStyle. 
        /// <para>
        /// The table cell style of cells.
        /// </para>
        /// </summary>
        public TableCellStyle CellStyle
        {
            get { return this._cellStyle; }
            set { this._cellStyle = value; }
        }

        // Check to see if CellStyle property is set
        internal bool IsSetCellStyle()
        {
            return this._cellStyle != null;
        }

        /// <summary>
        /// Gets and sets the property CollapsedRowDimensionsVisibility. 
        /// <para>
        /// The visibility setting of a pivot table's collapsed row dimension fields. If the value
        /// of this structure is <c>HIDDEN</c>, all collapsed columns in a pivot table are automatically
        /// hidden. The default value is <c>VISIBLE</c>.
        /// </para>
        /// </summary>
        public Visibility CollapsedRowDimensionsVisibility
        {
            get { return this._collapsedRowDimensionsVisibility; }
            set { this._collapsedRowDimensionsVisibility = value; }
        }

        // Check to see if CollapsedRowDimensionsVisibility property is set
        internal bool IsSetCollapsedRowDimensionsVisibility()
        {
            return this._collapsedRowDimensionsVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnHeaderStyle. 
        /// <para>
        /// The table cell style of the column header.
        /// </para>
        /// </summary>
        public TableCellStyle ColumnHeaderStyle
        {
            get { return this._columnHeaderStyle; }
            set { this._columnHeaderStyle = value; }
        }

        // Check to see if ColumnHeaderStyle property is set
        internal bool IsSetColumnHeaderStyle()
        {
            return this._columnHeaderStyle != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnNamesVisibility. 
        /// <para>
        /// The visibility of the column names.
        /// </para>
        /// </summary>
        public Visibility ColumnNamesVisibility
        {
            get { return this._columnNamesVisibility; }
            set { this._columnNamesVisibility = value; }
        }

        // Check to see if ColumnNamesVisibility property is set
        internal bool IsSetColumnNamesVisibility()
        {
            return this._columnNamesVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCellWidth. 
        /// <para>
        /// The default cell width of the pivot table.
        /// </para>
        /// </summary>
        public string DefaultCellWidth
        {
            get { return this._defaultCellWidth; }
            set { this._defaultCellWidth = value; }
        }

        // Check to see if DefaultCellWidth property is set
        internal bool IsSetDefaultCellWidth()
        {
            return this._defaultCellWidth != null;
        }

        /// <summary>
        /// Gets and sets the property MetricPlacement. 
        /// <para>
        /// The metric placement (row, column) options.
        /// </para>
        /// </summary>
        public PivotTableMetricPlacement MetricPlacement
        {
            get { return this._metricPlacement; }
            set { this._metricPlacement = value; }
        }

        // Check to see if MetricPlacement property is set
        internal bool IsSetMetricPlacement()
        {
            return this._metricPlacement != null;
        }

        /// <summary>
        /// Gets and sets the property RowAlternateColorOptions. 
        /// <para>
        /// The row alternate color options (widget status, row alternate colors).
        /// </para>
        /// </summary>
        public RowAlternateColorOptions RowAlternateColorOptions
        {
            get { return this._rowAlternateColorOptions; }
            set { this._rowAlternateColorOptions = value; }
        }

        // Check to see if RowAlternateColorOptions property is set
        internal bool IsSetRowAlternateColorOptions()
        {
            return this._rowAlternateColorOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RowFieldNamesStyle. 
        /// <para>
        /// The table cell style of row field names.
        /// </para>
        /// </summary>
        public TableCellStyle RowFieldNamesStyle
        {
            get { return this._rowFieldNamesStyle; }
            set { this._rowFieldNamesStyle = value; }
        }

        // Check to see if RowFieldNamesStyle property is set
        internal bool IsSetRowFieldNamesStyle()
        {
            return this._rowFieldNamesStyle != null;
        }

        /// <summary>
        /// Gets and sets the property RowHeaderStyle. 
        /// <para>
        /// The table cell style of the row headers.
        /// </para>
        /// </summary>
        public TableCellStyle RowHeaderStyle
        {
            get { return this._rowHeaderStyle; }
            set { this._rowHeaderStyle = value; }
        }

        // Check to see if RowHeaderStyle property is set
        internal bool IsSetRowHeaderStyle()
        {
            return this._rowHeaderStyle != null;
        }

        /// <summary>
        /// Gets and sets the property RowsLabelOptions. 
        /// <para>
        /// The options for the label that is located above the row headers. This option is only
        /// applicable when <c>RowsLayout</c> is set to <c>HIERARCHY</c>.
        /// </para>
        /// </summary>
        public PivotTableRowsLabelOptions RowsLabelOptions
        {
            get { return this._rowsLabelOptions; }
            set { this._rowsLabelOptions = value; }
        }

        // Check to see if RowsLabelOptions property is set
        internal bool IsSetRowsLabelOptions()
        {
            return this._rowsLabelOptions != null;
        }

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
        public PivotTableRowsLayout RowsLayout
        {
            get { return this._rowsLayout; }
            set { this._rowsLayout = value; }
        }

        // Check to see if RowsLayout property is set
        internal bool IsSetRowsLayout()
        {
            return this._rowsLayout != null;
        }

        /// <summary>
        /// Gets and sets the property SingleMetricVisibility. 
        /// <para>
        /// The visibility of the single metric options.
        /// </para>
        /// </summary>
        public Visibility SingleMetricVisibility
        {
            get { return this._singleMetricVisibility; }
            set { this._singleMetricVisibility = value; }
        }

        // Check to see if SingleMetricVisibility property is set
        internal bool IsSetSingleMetricVisibility()
        {
            return this._singleMetricVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property ToggleButtonsVisibility. 
        /// <para>
        /// Determines the visibility of the pivot table.
        /// </para>
        /// </summary>
        public Visibility ToggleButtonsVisibility
        {
            get { return this._toggleButtonsVisibility; }
            set { this._toggleButtonsVisibility = value; }
        }

        // Check to see if ToggleButtonsVisibility property is set
        internal bool IsSetToggleButtonsVisibility()
        {
            return this._toggleButtonsVisibility != null;
        }

    }
}