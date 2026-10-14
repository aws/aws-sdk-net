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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CoveragePercentage. 
        /// <para>
        /// The percentage of your existing Savings Plans covered usage, divided by all of your
        /// eligible Savings Plans usage in an account (or set of accounts).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CoveragePercentage { get; set; }

        /// <summary>
        /// Checks to see if the CoveragePercentage property is set.
        /// </summary>
        internal bool IsSetCoveragePercentage() => this.CoveragePercentage != null;

        /// <summary>
        /// Gets and sets the property OnDemandCost. 
        /// <para>
        /// The cost of your Amazon Web Services usage at the public On-Demand rate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OnDemandCost { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandCost property is set.
        /// </summary>
        internal bool IsSetOnDemandCost() => this.OnDemandCost != null;

        /// <summary>
        /// Gets and sets the property SpendCoveredBySavingsPlans. 
        /// <para>
        /// The amount of your Amazon Web Services usage that's covered by a Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SpendCoveredBySavingsPlans { get; set; }

        /// <summary>
        /// Checks to see if the SpendCoveredBySavingsPlans property is set.
        /// </summary>
        internal bool IsSetSpendCoveredBySavingsPlans() => this.SpendCoveredBySavingsPlans != null;

        /// <summary>
        /// Gets and sets the property TotalCost. 
        /// <para>
        /// The total cost of your Amazon Web Services usage, regardless of your purchase option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalCost { get; set; }

        /// <summary>
        /// Checks to see if the TotalCost property is set.
        /// </summary>
        internal bool IsSetTotalCost() => this.TotalCost != null;
    }
}
