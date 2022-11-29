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
    /// Conditional formatting options of a <code>GaugeChartVisual</code>.
    /// </summary>
    public partial class GaugeChartConditionalFormattingOption
    {
        private GaugeChartArcConditionalFormatting _arc;
        private GaugeChartPrimaryValueConditionalFormatting _primaryValue;

        /// <summary>
        /// Gets and sets the property Arc. 
        /// <para>
        /// The options that determine the presentation of the arc of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public GaugeChartArcConditionalFormatting Arc
        {
            get { return this._arc; }
            set { this._arc = value; }
        }

        // Check to see if Arc property is set
        internal bool IsSetArc()
        {
            return this._arc != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryValue. 
        /// <para>
        /// The conditional formatting for the primary value of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public GaugeChartPrimaryValueConditionalFormatting PrimaryValue
        {
            get { return this._primaryValue; }
            set { this._primaryValue = value; }
        }

        // Check to see if PrimaryValue property is set
        internal bool IsSetPrimaryValue()
        {
            return this._primaryValue != null;
        }

    }
}