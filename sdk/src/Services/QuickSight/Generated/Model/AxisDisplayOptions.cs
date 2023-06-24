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
    /// The display options for the axis label.
    /// </summary>
    public partial class AxisDisplayOptions
    {
        private Visibility _axisLineVisibility;
        private string _axisOffset;
        private AxisDataOptions _dataOptions;
        private Visibility _gridLineVisibility;
        private ScrollBarOptions _scrollbarOptions;
        private AxisTickLabelOptions _tickLabelOptions;

        /// <summary>
        /// Gets and sets the property AxisLineVisibility. 
        /// <para>
        /// Determines whether or not the axis line is visible.
        /// </para>
        /// </summary>
        public Visibility AxisLineVisibility
        {
            get { return this._axisLineVisibility; }
            set { this._axisLineVisibility = value; }
        }

        // Check to see if AxisLineVisibility property is set
        internal bool IsSetAxisLineVisibility()
        {
            return this._axisLineVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property AxisOffset. 
        /// <para>
        /// The offset value that determines the starting placement of the axis within a visual's
        /// bounds.
        /// </para>
        /// </summary>
        public string AxisOffset
        {
            get { return this._axisOffset; }
            set { this._axisOffset = value; }
        }

        // Check to see if AxisOffset property is set
        internal bool IsSetAxisOffset()
        {
            return this._axisOffset != null;
        }

        /// <summary>
        /// Gets and sets the property DataOptions. 
        /// <para>
        /// The data options for an axis.
        /// </para>
        /// </summary>
        public AxisDataOptions DataOptions
        {
            get { return this._dataOptions; }
            set { this._dataOptions = value; }
        }

        // Check to see if DataOptions property is set
        internal bool IsSetDataOptions()
        {
            return this._dataOptions != null;
        }

        /// <summary>
        /// Gets and sets the property GridLineVisibility. 
        /// <para>
        /// Determines whether or not the grid line is visible.
        /// </para>
        /// </summary>
        public Visibility GridLineVisibility
        {
            get { return this._gridLineVisibility; }
            set { this._gridLineVisibility = value; }
        }

        // Check to see if GridLineVisibility property is set
        internal bool IsSetGridLineVisibility()
        {
            return this._gridLineVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property ScrollbarOptions. 
        /// <para>
        /// The scroll bar options for an axis.
        /// </para>
        /// </summary>
        public ScrollBarOptions ScrollbarOptions
        {
            get { return this._scrollbarOptions; }
            set { this._scrollbarOptions = value; }
        }

        // Check to see if ScrollbarOptions property is set
        internal bool IsSetScrollbarOptions()
        {
            return this._scrollbarOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TickLabelOptions. 
        /// <para>
        /// The tick label options of an axis.
        /// </para>
        /// </summary>
        public AxisTickLabelOptions TickLabelOptions
        {
            get { return this._tickLabelOptions; }
            set { this._tickLabelOptions = value; }
        }

        // Check to see if TickLabelOptions property is set
        internal bool IsSetTickLabelOptions()
        {
            return this._tickLabelOptions != null;
        }

    }
}