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
    /// The options that determine the presentation of the <code>GaugeChartVisual</code>.
    /// </summary>
    public partial class GaugeChartOptions
    {
        private ArcConfiguration _arc;
        private ArcAxisConfiguration _arcAxis;
        private ComparisonConfiguration _comparison;
        private PrimaryValueDisplayType _primaryValueDisplayType;
        private FontConfiguration _primaryValueFontConfiguration;

        /// <summary>
        /// Gets and sets the property Arc. 
        /// <para>
        /// The arc configuration of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public ArcConfiguration Arc
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
        /// Gets and sets the property ArcAxis. 
        /// <para>
        /// The arc axis configuration of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public ArcAxisConfiguration ArcAxis
        {
            get { return this._arcAxis; }
            set { this._arcAxis = value; }
        }

        // Check to see if ArcAxis property is set
        internal bool IsSetArcAxis()
        {
            return this._arcAxis != null;
        }

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The comparison configuration of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public ComparisonConfiguration Comparison
        {
            get { return this._comparison; }
            set { this._comparison = value; }
        }

        // Check to see if Comparison property is set
        internal bool IsSetComparison()
        {
            return this._comparison != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryValueDisplayType. 
        /// <para>
        /// The options that determine the primary value display type.
        /// </para>
        /// </summary>
        public PrimaryValueDisplayType PrimaryValueDisplayType
        {
            get { return this._primaryValueDisplayType; }
            set { this._primaryValueDisplayType = value; }
        }

        // Check to see if PrimaryValueDisplayType property is set
        internal bool IsSetPrimaryValueDisplayType()
        {
            return this._primaryValueDisplayType != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryValueFontConfiguration. 
        /// <para>
        /// The options that determine the primary value font configuration.
        /// </para>
        /// </summary>
        public FontConfiguration PrimaryValueFontConfiguration
        {
            get { return this._primaryValueFontConfiguration; }
            set { this._primaryValueFontConfiguration = value; }
        }

        // Check to see if PrimaryValueFontConfiguration property is set
        internal bool IsSetPrimaryValueFontConfiguration()
        {
            return this._primaryValueFontConfiguration != null;
        }

    }
}