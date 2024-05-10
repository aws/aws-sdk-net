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
    /// Options that determine the layout and display options of a chart's small multiples.
    /// </summary>
    public partial class SmallMultiplesOptions
    {
        private long? _maxVisibleColumns;
        private long? _maxVisibleRows;
        private PanelConfiguration _panelConfiguration;
        private SmallMultiplesAxisProperties _xAxis;
        private SmallMultiplesAxisProperties _yAxis;

        /// <summary>
        /// Gets and sets the property MaxVisibleColumns. 
        /// <para>
        /// Sets the maximum number of visible columns to display in the grid of small multiples
        /// panels.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>Auto</c>, which automatically adjusts the columns in the grid to
        /// fit the overall layout and size of the given chart.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public long? MaxVisibleColumns
        {
            get { return this._maxVisibleColumns; }
            set { this._maxVisibleColumns = value; }
        }

        // Check to see if MaxVisibleColumns property is set
        internal bool IsSetMaxVisibleColumns()
        {
            return this._maxVisibleColumns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxVisibleRows. 
        /// <para>
        /// Sets the maximum number of visible rows to display in the grid of small multiples
        /// panels.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>Auto</c>, which automatically adjusts the rows in the grid
        /// to fit the overall layout and size of the given chart.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public long? MaxVisibleRows
        {
            get { return this._maxVisibleRows; }
            set { this._maxVisibleRows = value; }
        }

        // Check to see if MaxVisibleRows property is set
        internal bool IsSetMaxVisibleRows()
        {
            return this._maxVisibleRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PanelConfiguration. 
        /// <para>
        /// Configures the display options for each small multiples panel.
        /// </para>
        /// </summary>
        public PanelConfiguration PanelConfiguration
        {
            get { return this._panelConfiguration; }
            set { this._panelConfiguration = value; }
        }

        // Check to see if PanelConfiguration property is set
        internal bool IsSetPanelConfiguration()
        {
            return this._panelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property XAxis. 
        /// <para>
        /// The properties of a small multiples X axis.
        /// </para>
        /// </summary>
        public SmallMultiplesAxisProperties XAxis
        {
            get { return this._xAxis; }
            set { this._xAxis = value; }
        }

        // Check to see if XAxis property is set
        internal bool IsSetXAxis()
        {
            return this._xAxis != null;
        }

        /// <summary>
        /// Gets and sets the property YAxis. 
        /// <para>
        /// The properties of a small multiples Y axis.
        /// </para>
        /// </summary>
        public SmallMultiplesAxisProperties YAxis
        {
            get { return this._yAxis; }
            set { this._yAxis = value; }
        }

        // Check to see if YAxis property is set
        internal bool IsSetYAxis()
        {
            return this._yAxis != null;
        }

    }
}