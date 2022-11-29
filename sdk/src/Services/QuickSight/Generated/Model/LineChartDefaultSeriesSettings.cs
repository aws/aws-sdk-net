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
    /// The options that determine the default presentation of all line series in <code>LineChartVisual</code>.
    /// </summary>
    public partial class LineChartDefaultSeriesSettings
    {
        private AxisBinding _axisBinding;
        private LineChartLineStyleSettings _lineStyleSettings;
        private LineChartMarkerStyleSettings _markerStyleSettings;

        /// <summary>
        /// Gets and sets the property AxisBinding. 
        /// <para>
        /// The axis to which you are binding all line series to.
        /// </para>
        /// </summary>
        public AxisBinding AxisBinding
        {
            get { return this._axisBinding; }
            set { this._axisBinding = value; }
        }

        // Check to see if AxisBinding property is set
        internal bool IsSetAxisBinding()
        {
            return this._axisBinding != null;
        }

        /// <summary>
        /// Gets and sets the property LineStyleSettings. 
        /// <para>
        /// Line styles options for all line series in the visual.
        /// </para>
        /// </summary>
        public LineChartLineStyleSettings LineStyleSettings
        {
            get { return this._lineStyleSettings; }
            set { this._lineStyleSettings = value; }
        }

        // Check to see if LineStyleSettings property is set
        internal bool IsSetLineStyleSettings()
        {
            return this._lineStyleSettings != null;
        }

        /// <summary>
        /// Gets and sets the property MarkerStyleSettings. 
        /// <para>
        /// Marker styles options for all line series in the visual.
        /// </para>
        /// </summary>
        public LineChartMarkerStyleSettings MarkerStyleSettings
        {
            get { return this._markerStyleSettings; }
            set { this._markerStyleSettings = value; }
        }

        // Check to see if MarkerStyleSettings property is set
        internal bool IsSetMarkerStyleSettings()
        {
            return this._markerStyleSettings != null;
        }

    }
}