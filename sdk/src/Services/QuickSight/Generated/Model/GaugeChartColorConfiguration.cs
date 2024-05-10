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
    /// The color configuration of a <c>GaugeChartVisual</c>.
    /// </summary>
    public partial class GaugeChartColorConfiguration
    {
        private string _backgroundColor;
        private string _foregroundColor;

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public string BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this._backgroundColor = value; }
        }

        // Check to see if BackgroundColor property is set
        internal bool IsSetBackgroundColor()
        {
            return this._backgroundColor != null;
        }

        /// <summary>
        /// Gets and sets the property ForegroundColor. 
        /// <para>
        /// The foreground color configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public string ForegroundColor
        {
            get { return this._foregroundColor; }
            set { this._foregroundColor = value; }
        }

        // Check to see if ForegroundColor property is set
        internal bool IsSetForegroundColor()
        {
            return this._foregroundColor != null;
        }

    }
}