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
    /// The color configuration for individual groups within a waterfall visual.
    /// </summary>
    public partial class WaterfallChartGroupColorConfiguration
    {
        private string _negativeBarColor;
        private string _positiveBarColor;
        private string _totalBarColor;

        /// <summary>
        /// Gets and sets the property NegativeBarColor. 
        /// <para>
        /// Defines the color for the negative bars of a waterfall chart.
        /// </para>
        /// </summary>
        public string NegativeBarColor
        {
            get { return this._negativeBarColor; }
            set { this._negativeBarColor = value; }
        }

        // Check to see if NegativeBarColor property is set
        internal bool IsSetNegativeBarColor()
        {
            return this._negativeBarColor != null;
        }

        /// <summary>
        /// Gets and sets the property PositiveBarColor. 
        /// <para>
        /// Defines the color for the positive bars of a waterfall chart.
        /// </para>
        /// </summary>
        public string PositiveBarColor
        {
            get { return this._positiveBarColor; }
            set { this._positiveBarColor = value; }
        }

        // Check to see if PositiveBarColor property is set
        internal bool IsSetPositiveBarColor()
        {
            return this._positiveBarColor != null;
        }

        /// <summary>
        /// Gets and sets the property TotalBarColor. 
        /// <para>
        /// Defines the color for the total bars of a waterfall chart.
        /// </para>
        /// </summary>
        public string TotalBarColor
        {
            get { return this._totalBarColor; }
            set { this._totalBarColor = value; }
        }

        // Check to see if TotalBarColor property is set
        internal bool IsSetTotalBarColor()
        {
            return this._totalBarColor != null;
        }

    }
}