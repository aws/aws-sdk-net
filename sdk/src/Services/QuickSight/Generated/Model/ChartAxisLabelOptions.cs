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
    /// The label options for an axis on a chart.
    /// </summary>
    public partial class ChartAxisLabelOptions
    {
        private List<AxisLabelOptions> _axisLabelOptions = new List<AxisLabelOptions>();
        private Visibility _sortIconVisibility;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property AxisLabelOptions. 
        /// <para>
        /// The label options for a chart axis.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<AxisLabelOptions> AxisLabelOptions
        {
            get { return this._axisLabelOptions; }
            set { this._axisLabelOptions = value; }
        }

        // Check to see if AxisLabelOptions property is set
        internal bool IsSetAxisLabelOptions()
        {
            return this._axisLabelOptions != null && this._axisLabelOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SortIconVisibility. 
        /// <para>
        /// The visibility configuration of the sort icon on a chart's axis label.
        /// </para>
        /// </summary>
        public Visibility SortIconVisibility
        {
            get { return this._sortIconVisibility; }
            set { this._sortIconVisibility = value; }
        }

        // Check to see if SortIconVisibility property is set
        internal bool IsSetSortIconVisibility()
        {
            return this._sortIconVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of an axis label on a chart. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>VISIBLE</code>: Shows the axis.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HIDDEN</code>: Hides the axis.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}