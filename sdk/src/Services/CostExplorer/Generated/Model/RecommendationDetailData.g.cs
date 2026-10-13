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
    /// The details and metrics for the given recommendation.
    /// </summary>
    public partial class RecommendationDetailData
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AccountID that the recommendation is generated for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope that you want your recommendations for. Amazon Web Services calculates
        /// recommendations including the management account and member accounts if the value
        /// is set to PAYER. If the value is LINKED, recommendations are calculated for individual
        /// member accounts only.
        /// </para>
        /// </summary>
        public AccountScope AccountScope { get; set; }

        /// <summary>
        /// Checks to see if the AccountScope property is set.
        /// </summary>
        internal bool IsSetAccountScope() => this.AccountScope != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to generate the recommendation and
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
        /// Gets and sets the property CurrentAverageCoverage. 
        /// <para>
        /// The average value of hourly coverage over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentAverageCoverage { get; set; }

        /// <summary>
        /// Checks to see if the CurrentAverageCoverage property is set.
        /// </summary>
        internal bool IsSetCurrentAverageCoverage() => this.CurrentAverageCoverage != null;

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
        /// Gets and sets the property EstimatedAverageCoverage. 
        /// <para>
        /// The estimated coverage of the recommended Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedAverageCoverage { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedAverageCoverage property is set.
        /// </summary>
        internal bool IsSetEstimatedAverageCoverage() => this.EstimatedAverageCoverage != null;

        /// <summary>
        /// Gets and sets the property EstimatedAverageUtilization. 
        /// <para>
        /// The estimated utilization of the recommended Savings Plan.
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
        /// The estimated monthly savings amount based on the recommended Savings Plan.
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
        /// Plan, over the length of the lookback period.
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
        /// The estimated On-Demand costs you expect with no additional commitment, based on your
        /// usage of the selected time period and the Savings Plan you own.
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
        /// The estimated return on investment that's based on the recommended Savings Plan that
        /// you purchased. This is calculated as estimatedSavingsAmount/estimatedSPCost*100.
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
        /// The cost of the recommended Savings Plan over the length of the lookback period.
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
        /// The estimated savings amount that's based on the recommended Savings Plan over the
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
        /// Gets and sets the property ExistingHourlyCommitment. 
        /// <para>
        /// The existing hourly commitment for the Savings Plan type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ExistingHourlyCommitment { get; set; }

        /// <summary>
        /// Checks to see if the ExistingHourlyCommitment property is set.
        /// </summary>
        internal bool IsSetExistingHourlyCommitment() => this.ExistingHourlyCommitment != null;

        /// <summary>
        /// Gets and sets the property GenerationTimestamp.
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string GenerationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the GenerationTimestamp property is set.
        /// </summary>
        internal bool IsSetGenerationTimestamp() => this.GenerationTimestamp != null;

        /// <summary>
        /// Gets and sets the property HourlyCommitmentToPurchase. 
        /// <para>
        /// The recommended hourly commitment level for the Savings Plan type and the configuration
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
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family of the recommended Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamily property is set.
        /// </summary>
        internal bool IsSetInstanceFamily() => this.InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property LatestUsageTimestamp.
        /// </summary>
        [AWSProperty(Min = 20, Max = 25)]
        public string LatestUsageTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LatestUsageTimestamp property is set.
        /// </summary>
        internal bool IsSetLatestUsageTimestamp() => this.LatestUsageTimestamp != null;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInDays. 
        /// <para>
        /// How many days of previous usage that Amazon Web Services considers when making this
        /// recommendation.
        /// </para>
        /// </summary>
        public LookbackPeriodInDays LookbackPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInDays property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInDays() => this.LookbackPeriodInDays != null;

        /// <summary>
        /// Gets and sets the property MetricsOverLookbackPeriod. 
        /// <para>
        /// The related hourly cost, coverage, and utilization metrics over the lookback period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationDetailHourlyMetrics> MetricsOverLookbackPeriod { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendationDetailHourlyMetrics>() : null;

        /// <summary>
        /// Checks to see if the MetricsOverLookbackPeriod property is set.
        /// </summary>
        internal bool IsSetMetricsOverLookbackPeriod() => this.MetricsOverLookbackPeriod != null && (this.MetricsOverLookbackPeriod.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The unique ID that's used to distinguish Savings Plans from one another.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the commitment (for example, All Upfront or No Upfront).
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The region the recommendation is generated for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansType. 
        /// <para>
        /// The requested Savings Plan recommendation type.
        /// </para>
        /// </summary>
        public SupportedSavingsPlansType SavingsPlansType { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansType property is set.
        /// </summary>
        internal bool IsSetSavingsPlansType() => this.SavingsPlansType != null;

        /// <summary>
        /// Gets and sets the property TermInYears. 
        /// <para>
        /// The term of the commitment in years.
        /// </para>
        /// </summary>
        public TermInYears TermInYears { get; set; }

        /// <summary>
        /// Checks to see if the TermInYears property is set.
        /// </summary>
        internal bool IsSetTermInYears() => this.TermInYears != null;

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// The upfront cost of the recommended Savings Plan, based on the selected payment option.
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
