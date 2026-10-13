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
    /// Summary metrics for your Savings Plans Purchase Recommendations.
    /// </summary>
    public partial class SavingsPlansPurchaseRecommendationSummary
    {
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to generate the recommendations and
        /// present potential savings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property CurrentOnDemandSpend. 
        /// <para>
        /// The current total on demand spend of the applicable usage types over the lookback
        /// period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentOnDemandSpend { get; set; }

        /// <summary>
        /// Checks to see if the CurrentOnDemandSpend property is set.
        /// </summary>
        internal bool IsSetCurrentOnDemandSpend() => this.CurrentOnDemandSpend != null;

        /// <summary>
        /// Gets and sets the property DailyCommitmentToPurchase. 
        /// <para>
        /// The recommended Savings Plans cost on a daily (24 hourly) basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DailyCommitmentToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the DailyCommitmentToPurchase property is set.
        /// </summary>
        internal bool IsSetDailyCommitmentToPurchase() => this.DailyCommitmentToPurchase != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// The estimated monthly savings amount that's based on the recommended Savings Plans
        /// purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedMonthlySavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavingsAmount property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavingsAmount() => this.EstimatedMonthlySavingsAmount != null;

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCostWithCurrentCommitment. 
        /// <para>
        /// The estimated On-Demand costs you expect with no additional commitment. It's based
        /// on your usage of the selected time period and the Savings Plans you own. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedOnDemandCostWithCurrentCommitment { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedOnDemandCostWithCurrentCommitment property is set.
        /// </summary>
        internal bool IsSetEstimatedOnDemandCostWithCurrentCommitment() => this.EstimatedOnDemandCostWithCurrentCommitment != null;

        /// <summary>
        /// Gets and sets the property EstimatedROI. 
        /// <para>
        /// The estimated return on investment that's based on the recommended Savings Plans and
        /// estimated savings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedROI { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedROI property is set.
        /// </summary>
        internal bool IsSetEstimatedROI() => this.EstimatedROI != null;

        /// <summary>
        /// Gets and sets the property EstimatedSavingsAmount. 
        /// <para>
        /// The estimated total savings over the lookback period, based on the purchase of the
        /// recommended Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedSavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedSavingsAmount property is set.
        /// </summary>
        internal bool IsSetEstimatedSavingsAmount() => this.EstimatedSavingsAmount != null;

        /// <summary>
        /// Gets and sets the property EstimatedSavingsPercentage. 
        /// <para>
        /// The estimated savings relative to the total cost of On-Demand usage, over the lookback
        /// period. This is calculated as <c>estimatedSavingsAmount</c>/ <c>CurrentOnDemandSpend</c>*100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedSavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedSavingsPercentage property is set.
        /// </summary>
        internal bool IsSetEstimatedSavingsPercentage() => this.EstimatedSavingsPercentage != null;

        /// <summary>
        /// Gets and sets the property EstimatedTotalCost. 
        /// <para>
        /// The estimated total cost of the usage after purchasing the recommended Savings Plans.
        /// This is a sum of the cost of Savings Plans during this term, and the remaining On-Demand
        /// usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedTotalCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTotalCost property is set.
        /// </summary>
        internal bool IsSetEstimatedTotalCost() => this.EstimatedTotalCost != null;

        /// <summary>
        /// Gets and sets the property HourlyCommitmentToPurchase. 
        /// <para>
        /// The recommended hourly commitment that's based on the recommendation parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string HourlyCommitmentToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the HourlyCommitmentToPurchase property is set.
        /// </summary>
        internal bool IsSetHourlyCommitmentToPurchase() => this.HourlyCommitmentToPurchase != null;

        /// <summary>
        /// Gets and sets the property TotalRecommendationCount. 
        /// <para>
        /// The aggregate number of Savings Plans recommendations that exist for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TotalRecommendationCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalRecommendationCount property is set.
        /// </summary>
        internal bool IsSetTotalRecommendationCount() => this.TotalRecommendationCount != null;
    }
}
