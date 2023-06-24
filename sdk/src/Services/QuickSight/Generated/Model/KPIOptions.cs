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
    /// The options that determine the presentation of a KPI visual.
    /// </summary>
    public partial class KPIOptions
    {
        private ComparisonConfiguration _comparison;
        private PrimaryValueDisplayType _primaryValueDisplayType;
        private FontConfiguration _primaryValueFontConfiguration;
        private ProgressBarOptions _progressBar;
        private SecondaryValueOptions _secondaryValue;
        private FontConfiguration _secondaryValueFontConfiguration;
        private TrendArrowOptions _trendArrows;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The comparison configuration of a KPI visual.
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

        /// <summary>
        /// Gets and sets the property ProgressBar. 
        /// <para>
        /// The options that determine the presentation of the progress bar of a KPI visual.
        /// </para>
        /// </summary>
        public ProgressBarOptions ProgressBar
        {
            get { return this._progressBar; }
            set { this._progressBar = value; }
        }

        // Check to see if ProgressBar property is set
        internal bool IsSetProgressBar()
        {
            return this._progressBar != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryValue. 
        /// <para>
        /// The options that determine the presentation of the secondary value of a KPI visual.
        /// </para>
        /// </summary>
        public SecondaryValueOptions SecondaryValue
        {
            get { return this._secondaryValue; }
            set { this._secondaryValue = value; }
        }

        // Check to see if SecondaryValue property is set
        internal bool IsSetSecondaryValue()
        {
            return this._secondaryValue != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryValueFontConfiguration. 
        /// <para>
        /// The options that determine the secondary value font configuration.
        /// </para>
        /// </summary>
        public FontConfiguration SecondaryValueFontConfiguration
        {
            get { return this._secondaryValueFontConfiguration; }
            set { this._secondaryValueFontConfiguration = value; }
        }

        // Check to see if SecondaryValueFontConfiguration property is set
        internal bool IsSetSecondaryValueFontConfiguration()
        {
            return this._secondaryValueFontConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TrendArrows. 
        /// <para>
        /// The options that determine the presentation of trend arrows in a KPI visual.
        /// </para>
        /// </summary>
        public TrendArrowOptions TrendArrows
        {
            get { return this._trendArrows; }
            set { this._trendArrows = value; }
        }

        // Check to see if TrendArrows property is set
        internal bool IsSetTrendArrows()
        {
            return this._trendArrows != null;
        }

    }
}