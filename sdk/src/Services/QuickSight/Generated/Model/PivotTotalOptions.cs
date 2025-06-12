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
    /// The optional configuration of totals cells in a <c>PivotTableVisual</c>.
    /// </summary>
    public partial class PivotTotalOptions
    {
        private string _customLabel;
        private TableCellStyle _metricHeaderCellStyle;
        private TableTotalsPlacement _placement;
        private TableTotalsScrollStatus _scrollStatus;
        private List<TotalAggregationOption> _totalAggregationOptions = AWSConfigs.InitializeCollections ? new List<TotalAggregationOption>() : null;
        private TableCellStyle _totalCellStyle;
        private Visibility _totalsVisibility;
        private TableCellStyle _valueCellStyle;

        /// <summary>
        /// Gets and sets the property CustomLabel. 
        /// <para>
        /// The custom label string for the total cells.
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
        /// Gets and sets the property MetricHeaderCellStyle. 
        /// <para>
        /// The cell styling options for the total of header cells.
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
        /// Gets and sets the property Placement. 
        /// <para>
        /// The placement (start, end) for the total cells.
        /// </para>
        /// </summary>
        public TableTotalsPlacement Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property ScrollStatus. 
        /// <para>
        /// The scroll status (pinned, scrolled) for the total cells.
        /// </para>
        /// </summary>
        public TableTotalsScrollStatus ScrollStatus
        {
            get { return this._scrollStatus; }
            set { this._scrollStatus = value; }
        }

        // Check to see if ScrollStatus property is set
        internal bool IsSetScrollStatus()
        {
            return this._scrollStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAggregationOptions. 
        /// <para>
        /// The total aggregation options for each value field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<TotalAggregationOption> TotalAggregationOptions
        {
            get { return this._totalAggregationOptions; }
            set { this._totalAggregationOptions = value; }
        }

        // Check to see if TotalAggregationOptions property is set
        internal bool IsSetTotalAggregationOptions()
        {
            return this._totalAggregationOptions != null && (this._totalAggregationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalCellStyle. 
        /// <para>
        /// The cell styling options for the total cells.
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
        /// The visibility configuration for the total cells.
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
        /// The cell styling options for the totals of value cells.
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