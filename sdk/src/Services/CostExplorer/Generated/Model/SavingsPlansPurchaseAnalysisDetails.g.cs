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
    /// Details about the Savings Plans purchase analysis.
    /// </summary>
    public partial class SavingsPlansPurchaseAnalysisDetails
    {
        /// <summary>
        /// Gets and sets the property AdditionalMetadata. 
        /// <para>
        /// Additional metadata that might be applicable to the commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AdditionalMetadata { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalMetadata property is set.
        /// </summary>
        internal bool IsSetAdditionalMetadata() => this.AdditionalMetadata != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code used for the analysis.
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
        /// The average value of hourly On-Demand spend over the lookback period.
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
        /// The highest value of hourly On-Demand spend over the lookback period.
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
        /// The lowest value of hourly On-Demand spend over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentMinimumHourlyOnDemandSpend { get; set; }

        /// <summary>
        /// Checks to see if the CurrentMinimumHourlyOnDemandSpend property is set.
        /// </summary>
        internal bool IsSetCurrentMinimumHourlyOnDemandSpend() => this.CurrentMinimumHourlyOnDemandSpend != null;

        /// <summary>
        /// Gets and sets the property CurrentOnDemandSpend. 
        /// <para>
        /// The current total On-Demand spend over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrentOnDemandSpend { get; set; }

        /// <summary>
        /// Checks to see if the CurrentOnDemandSpend property is set.
        /// </summary>
        internal bool IsSetCurrentOnDemandSpend() => this.CurrentOnDemandSpend != null;

        /// <summary>
        /// Gets and sets the property EstimatedAverageCoverage. 
        /// <para>
        /// The estimated coverage of the Savings Plan.
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
        /// The estimated utilization of the Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedAverageUtilization { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedAverageUtilization property is set.
        /// </summary>
        internal bool IsSetEstimatedAverageUtilization() => this.EstimatedAverageUtilization != null;

        /// <summary>
        /// Gets and sets the property EstimatedCommitmentCost. 
        /// <para>
        /// The estimated cost of the Savings Plan over the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedCommitmentCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCommitmentCost property is set.
        /// </summary>
        internal bool IsSetEstimatedCommitmentCost() => this.EstimatedCommitmentCost != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// The estimated monthly savings amount based on the Savings Plan.
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
        /// The remaining On-Demand cost estimated to not be covered by the Savings Plan over
        /// the length of the lookback period.
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
        /// The estimated On-Demand cost you expect with no additional commitment based on your
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
        /// The estimated return on investment that's based on the Savings Plan and estimated
        /// savings. This is calculated as estimatedSavingsAmount/estimatedSPCost*100.
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
        /// The estimated savings amount that's based on the Savings Plan over the length of the
        /// lookback period.
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
        /// The estimated savings percentage relative to the total cost over the cost calculation
        /// lookback period.
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
        /// Gets and sets the property HourlyCommitmentToPurchase. 
        /// <para>
        /// The recommended or custom hourly commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string HourlyCommitmentToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the HourlyCommitmentToPurchase property is set.
        /// </summary>
        internal bool IsSetHourlyCommitmentToPurchase() => this.HourlyCommitmentToPurchase != null;

        /// <summary>
        /// Gets and sets the property LatestUsageTimestamp. 
        /// <para>
        /// The date and time of the last hour that went into the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LatestUsageTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LatestUsageTimestamp property is set.
        /// </summary>
        internal bool IsSetLatestUsageTimestamp() => this.LatestUsageTimestamp != null;

        /// <summary>
        /// Gets and sets the property LookbackPeriodInHours. 
        /// <para>
        /// The lookback period in hours that's used to generate the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LookbackPeriodInHours { get; set; }

        /// <summary>
        /// Checks to see if the LookbackPeriodInHours property is set.
        /// </summary>
        internal bool IsSetLookbackPeriodInHours() => this.LookbackPeriodInHours != null;

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
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// The upfront cost of the Savings Plan based on the selected payment option.
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
