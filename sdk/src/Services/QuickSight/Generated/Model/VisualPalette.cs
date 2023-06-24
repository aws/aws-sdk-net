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
    /// The visual display options for the visual palette.
    /// </summary>
    public partial class VisualPalette
    {
        private string _chartColor;
        private List<DataPathColor> _colorMap = new List<DataPathColor>();

        /// <summary>
        /// Gets and sets the property ChartColor. 
        /// <para>
        /// The chart color options for the visual palette.
        /// </para>
        /// </summary>
        public string ChartColor
        {
            get { return this._chartColor; }
            set { this._chartColor = value; }
        }

        // Check to see if ChartColor property is set
        internal bool IsSetChartColor()
        {
            return this._chartColor != null;
        }

        /// <summary>
        /// Gets and sets the property ColorMap. 
        /// <para>
        /// The color map options for the visual palette.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5000)]
        public List<DataPathColor> ColorMap
        {
            get { return this._colorMap; }
            set { this._colorMap = value; }
        }

        // Check to see if ColorMap property is set
        internal bool IsSetColorMap()
        {
            return this._colorMap != null && this._colorMap.Count > 0; 
        }

    }
}