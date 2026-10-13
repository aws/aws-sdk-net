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
    /// Details for your recommended Savings Plans.
    /// </summary>
    public partial class SavingsPlansPurchaseRecommendationDetail
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountID</c> the recommendation is generated for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

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
        /// Gets and sets the property CurrentAverageHourlyOnDemandSpend. 
        /// <para>
        /// The average value of hourly On-Demand spend over the lookback period of the applicable
        /// usage type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentAverageHourlyOnDemandSpend { get; set; }

        /// <summary>
        /// Checks to see if the CurrentAverageHourlyOnDemandSpend property is set.
        /// </summary>
        internal bool IsSetCurrentAverageHourlyOnDemandSpend() => this.CurrentAverageHourlyOnDemandSpend != null;

        /// <summary>
        /// Gets and sets the property CurrentMaximumHourlyOnDemandSpend. 
        /// <para>
        /// The highest value of hourly On-Demand spend over the lookback period of the applicable
        /// usage type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentMaximumHourlyOnDemandSpend { get; set; }

        /// <summary>
        /// Checks to see if the CurrentMaximumHourlyOnDemandSpend property is set.
        /// </summary>
        internal bool IsSetCurrentMaximumHourlyOnDemandSpend() => this.CurrentMaximumHourlyOnDemandSpend != null;

        /// <summary>
        /// Gets and sets the property CurrentMinimumHourlyOnDemandSpend. 
        /// <para>
        /// The lowest value of hourly On-Demand spend over the lookback period of the applicable
        /// usage type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentMinimumHourlyOnDemandSpend { get; set; }

        /// <summary>
        /// Checks to see if the CurrentMinimumHourlyOnDemandSpend property is set.
        /// </summary>
        internal bool IsSetCurrentMinimumHourlyOnDemandSpend() => this.CurrentMinimumHourlyOnDemandSpend != null;

        /// <summary>
        /// Gets and sets the property EstimatedAverageUtilization. 
        /// <para>
        /// The estimated utilization of the recommended Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedAverageUtilization { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedAverageUtilization property is set.
        /// </summary>
        internal bool IsSetEstimatedAverageUtilization() => this.EstimatedAverageUtilization != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// The estimated monthly savings amount based on the recommended Savings Plans.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedMonthlySavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavingsAmount property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavingsAmount() => this.EstimatedMonthlySavingsAmount != null;

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// The remaining On-Demand cost estimated to not be covered by the recommended Savings
        /// Plans, over the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedOnDemandCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedOnDemandCost property is set.
        /// </summary>
        internal bool IsSetEstimatedOnDemandCost() => this.EstimatedOnDemandCost != null;

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCostWithCurrentCommitment. 
        /// <para>
        ///  The estimated On-Demand costs you expect with no additional commitment, based on
        /// your usage of the selected time period and the Savings Plans you own. 
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
        /// The estimated return on investment that's based on the recommended Savings Plans that
        /// you purchased. This is calculated as <c>estimatedSavingsAmount</c>/ <c>estimatedSPCost</c>*100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedROI { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedROI property is set.
        /// </summary>
        internal bool IsSetEstimatedROI() => this.EstimatedROI != null;

        /// <summary>
        /// Gets and sets the property EstimatedSPCost. 
        /// <para>
        /// The cost of the recommended Savings Plans over the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedSPCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedSPCost property is set.
        /// </summary>
        internal bool IsSetEstimatedSPCost() => this.EstimatedSPCost != null;

        /// <summary>
        /// Gets and sets the property EstimatedSavingsAmount. 
        /// <para>
        /// The estimated savings amount that's based on the recommended Savings Plans over the
        /// length of the lookback period.
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
        /// The estimated savings percentage relative to the total cost of applicable On-Demand
        /// usage over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedSavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedSavingsPercentage property is set.
        /// </summary>
        internal bool IsSetEstimatedSavingsPercentage() => this.EstimatedSavingsPercentage != null;

        /// <summary>
        /// Gets and sets the property HourlyCommitmentToPurchase. 
        /// <para>
        /// The recommended hourly commitment level for the Savings Plans type and the configuration
        /// that's based on the usage during the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string HourlyCommitmentToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the HourlyCommitmentToPurchase property is set.
        /// </summary>
        internal bool IsSetHourlyCommitmentToPurchase() => this.HourlyCommitmentToPurchase != null;

        /// <summary>
        /// Gets and sets the property RecommendationDetailId. 
        /// <para>
        /// Contains detailed information about a specific Savings Plan recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string RecommendationDetailId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationDetailId property is set.
        /// </summary>
        internal bool IsSetRecommendationDetailId() => this.RecommendationDetailId != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansDetails. 
        /// <para>
        /// Details for your recommended Savings Plans.
        /// </para>
        /// </summary>
        public SavingsPlansDetails SavingsPlansDetails { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansDetails property is set.
        /// </summary>
        internal bool IsSetSavingsPlansDetails() => this.SavingsPlansDetails != null;

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// The upfront cost of the recommended Savings Plans, based on the selected payment option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string UpfrontCost { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontCost property is set.
        /// </summary>
        internal bool IsSetUpfrontCost() => this.UpfrontCost != null;
    }
}
