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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Pricing information about a Savings Plan.
    /// </summary>
    public partial class SavingsPlansPricing
    {
        private double? _estimatedMonthlyCommitment;
        private double? _estimatedOnDemandCost;
        private double? _monthlySavingsPlansEligibleCost;
        private double? _savingsPercentage;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCommitment. 
        /// <para>
        /// Estimated monthly commitment for the Savings Plan.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlyCommitment
        {
            get { return this._estimatedMonthlyCommitment; }
            set { this._estimatedMonthlyCommitment = value; }
        }

        // Check to see if EstimatedMonthlyCommitment property is set
        internal bool IsSetEstimatedMonthlyCommitment()
        {
            return this._estimatedMonthlyCommitment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// Estimated On-Demand cost you will pay after buying the Savings Plan.
        /// </para>
        /// </summary>
        public double? EstimatedOnDemandCost
        {
            get { return this._estimatedOnDemandCost; }
            set { this._estimatedOnDemandCost = value; }
        }

        // Check to see if EstimatedOnDemandCost property is set
        internal bool IsSetEstimatedOnDemandCost()
        {
            return this._estimatedOnDemandCost.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MonthlySavingsPlansEligibleCost. 
        /// <para>
        /// The cost of paying for the recommended Savings Plan monthly.
        /// </para>
        /// </summary>
        public double? MonthlySavingsPlansEligibleCost
        {
            get { return this._monthlySavingsPlansEligibleCost; }
            set { this._monthlySavingsPlansEligibleCost = value; }
        }

        // Check to see if MonthlySavingsPlansEligibleCost property is set
        internal bool IsSetMonthlySavingsPlansEligibleCost()
        {
            return this._monthlySavingsPlansEligibleCost.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsPercentage. 
        /// <para>
        /// Estimated savings as a percentage of your overall costs after buying the Savings Plan.
        /// </para>
        /// </summary>
        public double? SavingsPercentage
        {
            get { return this._savingsPercentage; }
            set { this._savingsPercentage = value; }
        }

        // Check to see if SavingsPercentage property is set
        internal bool IsSetSavingsPercentage()
        {
            return this._savingsPercentage.HasValue; 
        }

    }
}