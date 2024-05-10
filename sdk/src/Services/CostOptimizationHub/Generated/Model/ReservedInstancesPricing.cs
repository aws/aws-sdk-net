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
    /// Pricing details for your recommended reserved instance.
    /// </summary>
    public partial class ReservedInstancesPricing
    {
        private double? _estimatedMonthlyAmortizedReservationCost;
        private double? _estimatedOnDemandCost;
        private double? _monthlyReservationEligibleCost;
        private double? _savingsPercentage;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyAmortizedReservationCost. 
        /// <para>
        /// The estimated cost of your recurring monthly fees for the recommended reserved instance
        /// across the month.
        /// </para>
        /// </summary>
        public double? EstimatedMonthlyAmortizedReservationCost
        {
            get { return this._estimatedMonthlyAmortizedReservationCost; }
            set { this._estimatedMonthlyAmortizedReservationCost = value; }
        }

        // Check to see if EstimatedMonthlyAmortizedReservationCost property is set
        internal bool IsSetEstimatedMonthlyAmortizedReservationCost()
        {
            return this._estimatedMonthlyAmortizedReservationCost.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// The remaining On-Demand cost estimated to not be covered by the recommended reserved
        /// instance, over the length of the lookback period.
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
        /// Gets and sets the property MonthlyReservationEligibleCost. 
        /// <para>
        /// The cost of paying for the recommended reserved instance monthly.
        /// </para>
        /// </summary>
        public double? MonthlyReservationEligibleCost
        {
            get { return this._monthlyReservationEligibleCost; }
            set { this._monthlyReservationEligibleCost = value; }
        }

        // Check to see if MonthlyReservationEligibleCost property is set
        internal bool IsSetMonthlyReservationEligibleCost()
        {
            return this._monthlyReservationEligibleCost.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsPercentage. 
        /// <para>
        /// The savings percentage relative to the total On-Demand costs that are associated with
        /// this instance.
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