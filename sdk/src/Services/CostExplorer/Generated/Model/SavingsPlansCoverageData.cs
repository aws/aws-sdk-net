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
    /// Specific coverage percentage, On-Demand costs, and spend covered by Savings Plans,
    /// and total Savings Plans costs for an account.
    /// </summary>
    public partial class SavingsPlansCoverageData
    {
        private string _coveragePercentage;
        private string _onDemandCost;
        private string _spendCoveredBySavingsPlans;
        private string _totalCost;

        /// <summary>
        /// Gets and sets the property CoveragePercentage. 
        /// <para>
        /// The percentage of your existing Savings Plans covered usage, divided by all of your
        /// eligible Savings Plans usage in an account (or set of accounts).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CoveragePercentage
        {
            get { return this._coveragePercentage; }
            set { this._coveragePercentage = value; }
        }

        // Check to see if CoveragePercentage property is set
        internal bool IsSetCoveragePercentage()
        {
            return this._coveragePercentage != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandCost. 
        /// <para>
        /// The cost of your Amazon Web Services usage at the public On-Demand rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string OnDemandCost
        {
            get { return this._onDemandCost; }
            set { this._onDemandCost = value; }
        }

        // Check to see if OnDemandCost property is set
        internal bool IsSetOnDemandCost()
        {
            return this._onDemandCost != null;
        }

        /// <summary>
        /// Gets and sets the property SpendCoveredBySavingsPlans. 
        /// <para>
        /// The amount of your Amazon Web Services usage that's covered by a Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SpendCoveredBySavingsPlans
        {
            get { return this._spendCoveredBySavingsPlans; }
            set { this._spendCoveredBySavingsPlans = value; }
        }

        // Check to see if SpendCoveredBySavingsPlans property is set
        internal bool IsSetSpendCoveredBySavingsPlans()
        {
            return this._spendCoveredBySavingsPlans != null;
        }

        /// <summary>
        /// Gets and sets the property TotalCost. 
        /// <para>
        /// The total cost of your Amazon Web Services usage, regardless of your purchase option.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalCost
        {
            get { return this._totalCost; }
            set { this._totalCost = value; }
        }

        // Check to see if TotalCost property is set
        internal bool IsSetTotalCost()
        {
            return this._totalCost != null;
        }

    }
}