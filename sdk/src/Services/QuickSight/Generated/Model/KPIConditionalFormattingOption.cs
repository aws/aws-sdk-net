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
    /// The conditional formatting options of a KPI visual.
    /// </summary>
    public partial class KPIConditionalFormattingOption
    {
        private KPIActualValueConditionalFormatting _actualValue;
        private KPIComparisonValueConditionalFormatting _comparisonValue;
        private KPIPrimaryValueConditionalFormatting _primaryValue;
        private KPIProgressBarConditionalFormatting _progressBar;

        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The conditional formatting for the actual value of a KPI visual.
        /// </para>
        /// </summary>
        public KPIActualValueConditionalFormatting ActualValue
        {
            get { return this._actualValue; }
            set { this._actualValue = value; }
        }

        // Check to see if ActualValue property is set
        internal bool IsSetActualValue()
        {
            return this._actualValue != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonValue. 
        /// <para>
        /// The conditional formatting for the comparison value of a KPI visual.
        /// </para>
        /// </summary>
        public KPIComparisonValueConditionalFormatting ComparisonValue
        {
            get { return this._comparisonValue; }
            set { this._comparisonValue = value; }
        }

        // Check to see if ComparisonValue property is set
        internal bool IsSetComparisonValue()
        {
            return this._comparisonValue != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryValue. 
        /// <para>
        /// The conditional formatting for the primary value of a KPI visual.
        /// </para>
        /// </summary>
        public KPIPrimaryValueConditionalFormatting PrimaryValue
        {
            get { return this._primaryValue; }
            set { this._primaryValue = value; }
        }

        // Check to see if PrimaryValue property is set
        internal bool IsSetPrimaryValue()
        {
            return this._primaryValue != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressBar. 
        /// <para>
        /// The conditional formatting for the progress bar of a KPI visual.
        /// </para>
        /// </summary>
        public KPIProgressBarConditionalFormatting ProgressBar
        {
            get { return this._progressBar; }
            set { this._progressBar = value; }
        }

        // Check to see if ProgressBar property is set
        internal bool IsSetProgressBar()
        {
            return this._progressBar != null;
        }

    }
}