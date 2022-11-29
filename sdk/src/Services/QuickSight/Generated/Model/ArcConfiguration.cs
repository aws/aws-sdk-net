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
    /// The arc configuration of a <code>GaugeChartVisual</code>.
    /// </summary>
    public partial class ArcConfiguration
    {
        private double? _arcAngle;
        private ArcThicknessOptions _arcThickness;

        /// <summary>
        /// Gets and sets the property ArcAngle. 
        /// <para>
        /// The option that determines the arc angle of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public double ArcAngle
        {
            get { return this._arcAngle.GetValueOrDefault(); }
            set { this._arcAngle = value; }
        }

        // Check to see if ArcAngle property is set
        internal bool IsSetArcAngle()
        {
            return this._arcAngle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ArcThickness. 
        /// <para>
        /// The options that determine the arc thickness of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public ArcThicknessOptions ArcThickness
        {
            get { return this._arcThickness; }
            set { this._arcThickness = value; }
        }

        // Check to see if ArcThickness property is set
        internal bool IsSetArcThickness()
        {
            return this._arcThickness != null;
        }

    }
}