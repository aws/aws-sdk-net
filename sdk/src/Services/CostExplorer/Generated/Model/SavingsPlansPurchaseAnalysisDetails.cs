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
    /// Details about the Savings Plans purchase analysis.
    /// </summary>
    public partial class SavingsPlansPurchaseAnalysisDetails
    {
        private string _additionalMetadata;
        private string _currencyCode;
        private string _currentAverageCoverage;
        private string _currentAverageHourlyOnDemandSpend;
        private string _currentMaximumHourlyOnDemandSpend;
        private string _currentMinimumHourlyOnDemandSpend;
        private string _currentOnDemandSpend;
        private string _estimatedAverageCoverage;
        private string _estimatedAverageUtilization;
        private string _estimatedCommitmentCost;
        private string _estimatedMonthlySavingsAmount;
        private string _estimatedOnDemandCost;
        private string _estimatedOnDemandCostWithCurrentCommitment;
        private string _estimatedROI;
        private string _estimatedSavingsAmount;
        private string _estimatedSavingsPercentage;
        private string _existingHourlyCommitment;
        private string _hourlyCommitmentToPurchase;
        private string _latestUsageTimestamp;
        private string _lookbackPeriodInHours;
        private List<RecommendationDetailHourlyMetrics> _metricsOverLookbackPeriod = AWSConfigs.InitializeCollections ? new List<RecommendationDetailHourlyMetrics>() : null;
        private string _upfrontCost;

        /// <summary>
        /// Gets and sets the property AdditionalMetadata. 
        /// <para>
        /// Additional metadata that might be applicable to the commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AdditionalMetadata
        {
            get { return this._additionalMetadata; }
            set { this._additionalMetadata = value; }
        }

        // Check to see if AdditionalMetadata property is set
        internal bool IsSetAdditionalMetadata()
        {
            return this._additionalMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code used for the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentAverageCoverage. 
        /// <para>
        /// The average value of hourly coverage over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrentAverageCoverage
        {
            get { return this._currentAverageCoverage; }
            set { this._currentAverageCoverage = value; }
        }

        // Check to see if CurrentAverageCoverage property is set
        internal bool IsSetCurrentAverageCoverage()
        {
            return this._currentAverageCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentAverageHourlyOnDemandSpend. 
        /// <para>
        /// The average value of hourly On-Demand spend over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrentAverageHourlyOnDemandSpend
        {
            get { return this._currentAverageHourlyOnDemandSpend; }
            set { this._currentAverageHourlyOnDemandSpend = value; }
        }

        // Check to see if CurrentAverageHourlyOnDemandSpend property is set
        internal bool IsSetCurrentAverageHourlyOnDemandSpend()
        {
            return this._currentAverageHourlyOnDemandSpend != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentMaximumHourlyOnDemandSpend. 
        /// <para>
        /// The highest value of hourly On-Demand spend over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrentMaximumHourlyOnDemandSpend
        {
            get { return this._currentMaximumHourlyOnDemandSpend; }
            set { this._currentMaximumHourlyOnDemandSpend = value; }
        }

        // Check to see if CurrentMaximumHourlyOnDemandSpend property is set
        internal bool IsSetCurrentMaximumHourlyOnDemandSpend()
        {
            return this._currentMaximumHourlyOnDemandSpend != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentMinimumHourlyOnDemandSpend. 
        /// <para>
        /// The lowest value of hourly On-Demand spend over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrentMinimumHourlyOnDemandSpend
        {
            get { return this._currentMinimumHourlyOnDemandSpend; }
            set { this._currentMinimumHourlyOnDemandSpend = value; }
        }

        // Check to see if CurrentMinimumHourlyOnDemandSpend property is set
        internal bool IsSetCurrentMinimumHourlyOnDemandSpend()
        {
            return this._currentMinimumHourlyOnDemandSpend != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentOnDemandSpend. 
        /// <para>
        /// The current total On-Demand spend over the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrentOnDemandSpend
        {
            get { return this._currentOnDemandSpend; }
            set { this._currentOnDemandSpend = value; }
        }

        // Check to see if CurrentOnDemandSpend property is set
        internal bool IsSetCurrentOnDemandSpend()
        {
            return this._currentOnDemandSpend != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedAverageCoverage. 
        /// <para>
        /// The estimated coverage of the Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedAverageCoverage
        {
            get { return this._estimatedAverageCoverage; }
            set { this._estimatedAverageCoverage = value; }
        }

        // Check to see if EstimatedAverageCoverage property is set
        internal bool IsSetEstimatedAverageCoverage()
        {
            return this._estimatedAverageCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedAverageUtilization. 
        /// <para>
        /// The estimated utilization of the Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedAverageUtilization
        {
            get { return this._estimatedAverageUtilization; }
            set { this._estimatedAverageUtilization = value; }
        }

        // Check to see if EstimatedAverageUtilization property is set
        internal bool IsSetEstimatedAverageUtilization()
        {
            return this._estimatedAverageUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedCommitmentCost. 
        /// <para>
        /// The estimated cost of the Savings Plan over the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedCommitmentCost
        {
            get { return this._estimatedCommitmentCost; }
            set { this._estimatedCommitmentCost = value; }
        }

        // Check to see if EstimatedCommitmentCost property is set
        internal bool IsSetEstimatedCommitmentCost()
        {
            return this._estimatedCommitmentCost != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// The estimated monthly savings amount based on the Savings Plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedMonthlySavingsAmount
        {
            get { return this._estimatedMonthlySavingsAmount; }
            set { this._estimatedMonthlySavingsAmount = value; }
        }

        // Check to see if EstimatedMonthlySavingsAmount property is set
        internal bool IsSetEstimatedMonthlySavingsAmount()
        {
            return this._estimatedMonthlySavingsAmount != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCost. 
        /// <para>
        /// The remaining On-Demand cost estimated to not be covered by the Savings Plan over
        /// the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedOnDemandCost
        {
            get { return this._estimatedOnDemandCost; }
            set { this._estimatedOnDemandCost = value; }
        }

        // Check to see if EstimatedOnDemandCost property is set
        internal bool IsSetEstimatedOnDemandCost()
        {
            return this._estimatedOnDemandCost != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedOnDemandCostWithCurrentCommitment. 
        /// <para>
        /// The estimated On-Demand cost you expect with no additional commitment based on your
        /// usage of the selected time period and the Savings Plan you own.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedOnDemandCostWithCurrentCommitment
        {
            get { return this._estimatedOnDemandCostWithCurrentCommitment; }
            set { this._estimatedOnDemandCostWithCurrentCommitment = value; }
        }

        // Check to see if EstimatedOnDemandCostWithCurrentCommitment property is set
        internal bool IsSetEstimatedOnDemandCostWithCurrentCommitment()
        {
            return this._estimatedOnDemandCostWithCurrentCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedROI. 
        /// <para>
        /// The estimated return on investment that's based on the Savings Plan and estimated
        /// savings. This is calculated as estimatedSavingsAmount/estimatedSPCost*100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedROI
        {
            get { return this._estimatedROI; }
            set { this._estimatedROI = value; }
        }

        // Check to see if EstimatedROI property is set
        internal bool IsSetEstimatedROI()
        {
            return this._estimatedROI != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedSavingsAmount. 
        /// <para>
        /// The estimated savings amount that's based on the Savings Plan over the length of the
        /// lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedSavingsAmount
        {
            get { return this._estimatedSavingsAmount; }
            set { this._estimatedSavingsAmount = value; }
        }

        // Check to see if EstimatedSavingsAmount property is set
        internal bool IsSetEstimatedSavingsAmount()
        {
            return this._estimatedSavingsAmount != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedSavingsPercentage. 
        /// <para>
        /// The estimated savings percentage relative to the total cost over the cost calculation
        /// lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedSavingsPercentage
        {
            get { return this._estimatedSavingsPercentage; }
            set { this._estimatedSavingsPercentage = value; }
        }

        // Check to see if EstimatedSavingsPercentage property is set
        internal bool IsSetEstimatedSavingsPercentage()
        {
            return this._estimatedSavingsPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property ExistingHourlyCommitment. 
        /// <para>
        /// The existing hourly commitment for the Savings Plan type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ExistingHourlyCommitment
        {
            get { return this._existingHourlyCommitment; }
            set { this._existingHourlyCommitment = value; }
        }

        // Check to see if ExistingHourlyCommitment property is set
        internal bool IsSetExistingHourlyCommitment()
        {
            return this._existingHourlyCommitment != null;
        }

        /// <summary>
        /// Gets and sets the property HourlyCommitmentToPurchase. 
        /// <para>
        /// The recommended or custom hourly commitment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string HourlyCommitmentToPurchase
        {
            get { return this._hourlyCommitmentToPurchase; }
            set { this._hourlyCommitmentToPurchase = value; }
        }

        // Check to see if HourlyCommitmentToPurchase property is set
        internal bool IsSetHourlyCommitmentToPurchase()
        {
            return this._hourlyCommitmentToPurchase != null;
        }

        /// <summary>
        /// Gets and sets the property LatestUsageTimestamp. 
        /// <para>
        /// The date and time of the last hour that went into the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LatestUsageTimestamp
        {
            get { return this._latestUsageTimestamp; }
            set { this._latestUsageTimestamp = value; }
        }

        // Check to see if LatestUsageTimestamp property is set
        internal bool IsSetLatestUsageTimestamp()
        {
            return this._latestUsageTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property LookbackPeriodInHours. 
        /// <para>
        /// The lookback period in hours that's used to generate the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LookbackPeriodInHours
        {
            get { return this._lookbackPeriodInHours; }
            set { this._lookbackPeriodInHours = value; }
        }

        // Check to see if LookbackPeriodInHours property is set
        internal bool IsSetLookbackPeriodInHours()
        {
            return this._lookbackPeriodInHours != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsOverLookbackPeriod. 
        /// <para>
        /// The related hourly cost, coverage, and utilization metrics over the lookback period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationDetailHourlyMetrics> MetricsOverLookbackPeriod
        {
            get { return this._metricsOverLookbackPeriod; }
            set { this._metricsOverLookbackPeriod = value; }
        }

        // Check to see if MetricsOverLookbackPeriod property is set
        internal bool IsSetMetricsOverLookbackPeriod()
        {
            return this._metricsOverLookbackPeriod != null && (this._metricsOverLookbackPeriod.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// The upfront cost of the Savings Plan based on the selected payment option.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UpfrontCost
        {
            get { return this._upfrontCost; }
            set { this._upfrontCost = value; }
        }

        // Check to see if UpfrontCost property is set
        internal bool IsSetUpfrontCost()
        {
            return this._upfrontCost != null;
        }

    }
}