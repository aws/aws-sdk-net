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
    /// The unaggregated field wells of a scatter plot.
    /// </summary>
    public partial class ScatterPlotUnaggregatedFieldWells
    {
        private List<MeasureField> _size = new List<MeasureField>();
        private List<DimensionField> _xAxis = new List<DimensionField>();
        private List<DimensionField> _yAxis = new List<DimensionField>();

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size field well of a scatter plot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<MeasureField> Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size != null && this._size.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property XAxis. 
        /// <para>
        /// The x-axis field well of a scatter plot.
        /// </para>
        ///  
        /// <para>
        /// The x-axis is a dimension field and cannot be aggregated.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> XAxis
        {
            get { return this._xAxis; }
            set { this._xAxis = value; }
        }

        // Check to see if XAxis property is set
        internal bool IsSetXAxis()
        {
            return this._xAxis != null && this._xAxis.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property YAxis. 
        /// <para>
        /// The y-axis field well of a scatter plot.
        /// </para>
        ///  
        /// <para>
        /// The y-axis is a dimension field and cannot be aggregated.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public List<DimensionField> YAxis
        {
            get { return this._yAxis; }
            set { this._yAxis = value; }
        }

        // Check to see if YAxis property is set
        internal bool IsSetYAxis()
        {
            return this._yAxis != null && this._yAxis.Count > 0; 
        }

    }
}