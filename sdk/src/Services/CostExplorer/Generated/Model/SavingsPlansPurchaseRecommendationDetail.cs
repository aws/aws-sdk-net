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
    /// Details for your recommended Savings Plans.
    /// </summary>
    public partial class SavingsPlansPurchaseRecommendationDetail
    {
        private string _accountId;
        private string _currencyCode;
        private string _currentAverageHourlyOnDemandSpend;
        private string _currentMaximumHourlyOnDemandSpend;
        private string _currentMinimumHourlyOnDemandSpend;
        private string _estimatedAverageUtilization;
        private string _estimatedMonthlySavingsAmount;
        private string _estimatedOnDemandCost;
        private string _estimatedOnDemandCostWithCurrentCommitment;
        private string _estimatedROI;
        private string _estimatedSavingsAmount;
        private string _estimatedSavingsPercentage;
        private string _estimatedSPCost;
        private string _hourlyCommitmentToPurchase;
        private string _recommendationDetailId;
        private SavingsPlansDetails _savingsPlansDetails;
        private string _upfrontCost;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountID</c> the recommendation is generated for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to generate the recommendations and
        /// present potential savings.
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
        /// Gets and sets the property CurrentAverageHourlyOnDemandSpend. 
        /// <para>
        /// The average value of hourly On-Demand spend over the lookback period of the applicable
        /// usage type.
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
        /// The highest value of hourly On-Demand spend over the lookback period of the applicable
        /// usage type.
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
        /// The lowest value of hourly On-Demand spend over the lookback period of the applicable
        /// usage type.
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
        /// Gets and sets the property EstimatedAverageUtilization. 
        /// <para>
        /// The estimated utilization of the recommended Savings Plans.
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
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// The estimated monthly savings amount based on the recommended Savings Plans.
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
        /// The remaining On-Demand cost estimated to not be covered by the recommended Savings
        /// Plans, over the length of the lookback period.
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
        ///  The estimated On-Demand costs you expect with no additional commitment, based on
        /// your usage of the selected time period and the Savings Plans you own. 
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
        /// The estimated return on investment that's based on the recommended Savings Plans that
        /// you purchased. This is calculated as <c>estimatedSavingsAmount</c>/ <c>estimatedSPCost</c>*100.
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
        /// The estimated savings amount that's based on the recommended Savings Plans over the
        /// length of the lookback period.
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
        /// The estimated savings percentage relative to the total cost of applicable On-Demand
        /// usage over the lookback period.
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
        /// Gets and sets the property EstimatedSPCost. 
        /// <para>
        /// The cost of the recommended Savings Plans over the length of the lookback period.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedSPCost
        {
            get { return this._estimatedSPCost; }
            set { this._estimatedSPCost = value; }
        }

        // Check to see if EstimatedSPCost property is set
        internal bool IsSetEstimatedSPCost()
        {
            return this._estimatedSPCost != null;
        }

        /// <summary>
        /// Gets and sets the property HourlyCommitmentToPurchase. 
        /// <para>
        /// The recommended hourly commitment level for the Savings Plans type and the configuration
        /// that's based on the usage during the lookback period.
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
        /// Gets and sets the property RecommendationDetailId. 
        /// <para>
        /// Contains detailed information about a specific Savings Plan recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string RecommendationDetailId
        {
            get { return this._recommendationDetailId; }
            set { this._recommendationDetailId = value; }
        }

        // Check to see if RecommendationDetailId property is set
        internal bool IsSetRecommendationDetailId()
        {
            return this._recommendationDetailId != null;
        }

        /// <summary>
        /// Gets and sets the property SavingsPlansDetails. 
        /// <para>
        /// Details for your recommended Savings Plans.
        /// </para>
        /// </summary>
        public SavingsPlansDetails SavingsPlansDetails
        {
            get { return this._savingsPlansDetails; }
            set { this._savingsPlansDetails = value; }
        }

        // Check to see if SavingsPlansDetails property is set
        internal bool IsSetSavingsPlansDetails()
        {
            return this._savingsPlansDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// The upfront cost of the recommended Savings Plans, based on the selected payment option.
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