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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Pricing information about a Savings Plans.
    /// </summary>
    public partial class SavingsPlansPricing
    {
        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCommitment. 
        /// <para>
        /// Estimated monthly commitment for the Savings Plans.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlyCommitment { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyCommitment property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyCommitment() => this.EstimatedMonthlyCommitment.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// Estimated On-Demand cost you will pay after buying the Savings Plans.
        /// </para>
        /// </summary>
        public double? EstimatedOnDemandCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedOnDemandCost property is set.
        /// </summary>
        internal bool IsSetEstimatedOnDemandCost() => this.EstimatedOnDemandCost.HasValue;

        /// <summary>
        /// Gets and sets the property MonthlySavingsPlansEligibleCost. 
        /// <para>
        /// The cost of paying for the recommended Savings Plans monthly.
        /// </para>
        /// </summary>
        public double? MonthlySavingsPlansEligibleCost { get; set; }

        /// <summary>
        /// Checks to see if the MonthlySavingsPlansEligibleCost property is set.
        /// </summary>
        internal bool IsSetMonthlySavingsPlansEligibleCost() => this.MonthlySavingsPlansEligibleCost.HasValue;

        /// <summary>
        /// Gets and sets the property SavingsPercentage. 
        /// <para>
        /// Estimated savings as a percentage of your overall costs after buying the Savings Plans.
        /// </para>
        /// </summary>
        public double? SavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPercentage property is set.
        /// </summary>
        internal bool IsSetSavingsPercentage() => this.SavingsPercentage.HasValue;
    }
}
