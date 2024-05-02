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
    /// Summary metrics for your Savings Plans Purchase Recommendations.
    /// </summary>
    public partial class SavingsPlansPurchaseRecommendationSummary
    {
        private string _currencyCode;
        private string _currentOnDemandSpend;
        private string _dailyCommitmentToPurchase;
        private string _estimatedMonthlySavingsAmount;
        private string _estimatedOnDemandCostWithCurrentCommitment;
        private string _estimatedROI;
        private string _estimatedSavingsAmount;
        private string _estimatedSavingsPercentage;
        private string _estimatedTotalCost;
        private string _hourlyCommitmentToPurchase;
        private string _totalRecommendationCount;

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
        /// Gets and sets the property CurrentOnDemandSpend. 
        /// <para>
        /// The current total on demand spend of the applicable usage types over the lookback
        /// period.
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
        /// Gets and sets the property DailyCommitmentToPurchase. 
        /// <para>
        /// The recommended Savings Plans cost on a daily (24 hourly) basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DailyCommitmentToPurchase
        {
            get { return this._dailyCommitmentToPurchase; }
            set { this._dailyCommitmentToPurchase = value; }
        }

        // Check to see if DailyCommitmentToPurchase property is set
        internal bool IsSetDailyCommitmentToPurchase()
        {
            return this._dailyCommitmentToPurchase != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// The estimated monthly savings amount that's based on the recommended Savings Plans
        /// purchase.
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
        /// Gets and sets the property EstimatedOnDemandCostWithCurrentCommitment. 
        /// <para>
        /// The estimated On-Demand costs you expect with no additional commitment. It's based
        /// on your usage of the selected time period and the Savings Plans you own. 
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
        /// The estimated return on investment that's based on the recommended Savings Plans and
        /// estimated savings.
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
        /// The estimated total savings over the lookback period, based on the purchase of the
        /// recommended Savings Plans.
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
        /// The estimated savings relative to the total cost of On-Demand usage, over the lookback
        /// period. This is calculated as <c>estimatedSavingsAmount</c>/ <c>CurrentOnDemandSpend</c>*100.
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
        /// Gets and sets the property EstimatedTotalCost. 
        /// <para>
        /// The estimated total cost of the usage after purchasing the recommended Savings Plans.
        /// This is a sum of the cost of Savings Plans during this term, and the remaining On-Demand
        /// usage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedTotalCost
        {
            get { return this._estimatedTotalCost; }
            set { this._estimatedTotalCost = value; }
        }

        // Check to see if EstimatedTotalCost property is set
        internal bool IsSetEstimatedTotalCost()
        {
            return this._estimatedTotalCost != null;
        }

        /// <summary>
        /// Gets and sets the property HourlyCommitmentToPurchase. 
        /// <para>
        /// The recommended hourly commitment that's based on the recommendation parameters.
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
        /// Gets and sets the property TotalRecommendationCount. 
        /// <para>
        /// The aggregate number of Savings Plans recommendations that exist for your account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string TotalRecommendationCount
        {
            get { return this._totalRecommendationCount; }
            set { this._totalRecommendationCount = value; }
        }

        // Check to see if TotalRecommendationCount property is set
        internal bool IsSetTotalRecommendationCount()
        {
            return this._totalRecommendationCount != null;
        }

    }
}