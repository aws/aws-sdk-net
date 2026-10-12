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
    /// Pricing details for your recommended reserved instance.
    /// </summary>
    public partial class ReservedInstancesPricing
    {
        /// <summary>
        /// Gets and sets the property EstimatedMonthlyAmortizedReservationCost. 
        /// <para>
        /// The estimated cost of your recurring monthly fees for the recommended reserved instance
        /// across the month.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlyAmortizedReservationCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyAmortizedReservationCost property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyAmortizedReservationCost() => this.EstimatedMonthlyAmortizedReservationCost.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// The remaining On-Demand cost estimated to not be covered by the recommended reserved
        /// instance, over the length of the lookback period.
        /// </para>
        /// </summary>
        public double? EstimatedOnDemandCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedOnDemandCost property is set.
        /// </summary>
        internal bool IsSetEstimatedOnDemandCost() => this.EstimatedOnDemandCost.HasValue;

        /// <summary>
        /// Gets and sets the property MonthlyReservationEligibleCost. 
        /// <para>
        /// The cost of paying for the recommended reserved instance monthly.
        /// </para>
        /// </summary>
        public double? MonthlyReservationEligibleCost { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyReservationEligibleCost property is set.
        /// </summary>
        internal bool IsSetMonthlyReservationEligibleCost() => this.MonthlyReservationEligibleCost.HasValue;

        /// <summary>
        /// Gets and sets the property SavingsPercentage. 
        /// <para>
        /// The savings percentage relative to the total On-Demand costs that are associated with
        /// this instance.
        /// </para>
        /// </summary>
        public double? SavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPercentage property is set.
        /// </summary>
        internal bool IsSetSavingsPercentage() => this.SavingsPercentage.HasValue;
    }
}
