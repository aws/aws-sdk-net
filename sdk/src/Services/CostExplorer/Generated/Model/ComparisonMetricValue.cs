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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Contains cost or usage metric values for comparing two time periods. Each value includes
    /// amounts for the baseline and comparison time periods, their difference, and the unit
    /// of measurement.
    /// </summary>
    public partial class ComparisonMetricValue
    {
        private string _baselineTimePeriodAmount;
        private string _comparisonTimePeriodAmount;
        private string _difference;
        private string _unit;

        /// <summary>
        /// Gets and sets the property BaselineTimePeriodAmount. 
        /// <para>
        /// The numeric value for the baseline time period measurement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string BaselineTimePeriodAmount
        {
            get { return this._baselineTimePeriodAmount; }
            set { this._baselineTimePeriodAmount = value; }
        }

        // Check to see if BaselineTimePeriodAmount property is set
        internal bool IsSetBaselineTimePeriodAmount()
        {
            return this._baselineTimePeriodAmount != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonTimePeriodAmount. 
        /// <para>
        /// The numeric value for the comparison time period measurement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ComparisonTimePeriodAmount
        {
            get { return this._comparisonTimePeriodAmount; }
            set { this._comparisonTimePeriodAmount = value; }
        }

        // Check to see if ComparisonTimePeriodAmount property is set
        internal bool IsSetComparisonTimePeriodAmount()
        {
            return this._comparisonTimePeriodAmount != null;
        }

        /// <summary>
        /// Gets and sets the property Difference. 
        /// <para>
        /// The calculated difference between <c>ComparisonTimePeriodAmount</c> and <c>BaselineTimePeriodAmount</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Difference
        {
            get { return this._difference; }
            set { this._difference = value; }
        }

        // Check to see if Difference property is set
        internal bool IsSetDifference()
        {
            return this._difference != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement applicable to all numeric values in this comparison.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}