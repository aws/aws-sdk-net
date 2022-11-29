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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The subtotal options.
    /// </summary>
    public partial class SubtotalOptions
    {
        private string _customLabel;
        private PivotTableSubtotalLevel _fieldLevel;
        private List<PivotTableFieldSubtotalOptions> _fieldLevelOptions = new List<PivotTableFieldSubtotalOptions>();
        private TableCellStyle _metricHeaderCellStyle;
        private TableCellStyle _totalCellStyle;
        private Visibility _totalsVisibility;
        private TableCellStyle _valueCellStyle;

        /// <summary>
        /// Gets and sets the property CustomLabel. 
        /// <para>
        /// The custom label string for the subtotal cells.
        /// </para>
        /// </summary>
        public string CustomLabel
        {
            get { return this._customLabel; }
            set { this._customLabel = value; }
        }

        // Check to see if CustomLabel property is set
        internal bool IsSetCustomLabel()
        {
            return this._customLabel != null;
        }

        /// <summary>
        /// Gets and sets the property FieldLevel. 
        /// <para>
        /// The field level (all, custom, last) for the subtotal cells.
        /// </para>
        /// </summary>
        public PivotTableSubtotalLevel FieldLevel
        {
            get { return this._fieldLevel; }
            set { this._fieldLevel = value; }
        }

        // Check to see if FieldLevel property is set
        internal bool IsSetFieldLevel()
        {
            return this._fieldLevel != null;
        }

        /// <summary>
        /// Gets and sets the property FieldLevelOptions. 
        /// <para>
        /// The optional configuration of subtotal cells.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<PivotTableFieldSubtotalOptions> FieldLevelOptions
        {
            get { return this._fieldLevelOptions; }
            set { this._fieldLevelOptions = value; }
        }

        // Check to see if FieldLevelOptions property is set
        internal bool IsSetFieldLevelOptions()
        {
            return this._fieldLevelOptions != null && this._fieldLevelOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricHeaderCellStyle. 
        /// <para>
        /// The cell styling options for the subtotals of header cells.
        /// </para>
        /// </summary>
        public TableCellStyle MetricHeaderCellStyle
        {
            get { return this._metricHeaderCellStyle; }
            set { this._metricHeaderCellStyle = value; }
        }

        // Check to see if MetricHeaderCellStyle property is set
        internal bool IsSetMetricHeaderCellStyle()
        {
            return this._metricHeaderCellStyle != null;
        }

        /// <summary>
        /// Gets and sets the property TotalCellStyle. 
        /// <para>
        /// The cell styling options for the subtotal cells.
        /// </para>
        /// </summary>
        public TableCellStyle TotalCellStyle
        {
            get { return this._totalCellStyle; }
            set { this._totalCellStyle = value; }
        }

        // Check to see if TotalCellStyle property is set
        internal bool IsSetTotalCellStyle()
        {
            return this._totalCellStyle != null;
        }

        /// <summary>
        /// Gets and sets the property TotalsVisibility. 
        /// <para>
        /// The visibility configuration for the subtotal cells.
        /// </para>
        /// </summary>
        public Visibility TotalsVisibility
        {
            get { return this._totalsVisibility; }
            set { this._totalsVisibility = value; }
        }

        // Check to see if TotalsVisibility property is set
        internal bool IsSetTotalsVisibility()
        {
            return this._totalsVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property ValueCellStyle. 
        /// <para>
        /// The cell styling options for the subtotals of value cells.
        /// </para>
        /// </summary>
        public TableCellStyle ValueCellStyle
        {
            get { return this._valueCellStyle; }
            set { this._valueCellStyle = value; }
        }

        // Check to see if ValueCellStyle property is set
        internal bool IsSetValueCellStyle()
        {
            return this._valueCellStyle != null;
        }

    }
}