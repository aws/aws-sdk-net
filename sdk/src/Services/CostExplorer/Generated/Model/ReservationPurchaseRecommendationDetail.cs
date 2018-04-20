/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details about your recommended reservation purchase.
    /// </summary>
    public partial class ReservationPurchaseRecommendationDetail
    {
        private string _averageNormalizedUnitsUsedPerHour;
        private string _averageNumberOfInstancesUsedPerHour;
        private string _averageUtilization;
        private string _currencyCode;
        private string _estimatedBreakEvenInMonths;
        private string _estimatedMonthlyOnDemandCost;
        private string _estimatedMonthlySavingsAmount;
        private string _estimatedMonthlySavingsPercentage;
        private string _estimatedReservationCostForLookbackPeriod;
        private InstanceDetails _instanceDetails;
        private string _maximumNormalizedUnitsUsedPerHour;
        private string _maximumNumberOfInstancesUsedPerHour;
        private string _minimumNormalizedUnitsUsedPerHour;
        private string _minimumNumberOfInstancesUsedPerHour;
        private string _recommendedNormalizedUnitsToPurchase;
        private string _recommendedNumberOfInstancesToPurchase;
        private string _recurringStandardMonthlyCost;
        private string _upfrontCost;

        /// <summary>
        /// Gets and sets the property AverageNormalizedUnitsUsedPerHour. 
        /// <para>
        /// The average number of normalized units that you used in an hour during the historical
        /// period. AWS uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        public string AverageNormalizedUnitsUsedPerHour
        {
            get { return this._averageNormalizedUnitsUsedPerHour; }
            set { this._averageNormalizedUnitsUsedPerHour = value; }
        }

        // Check to see if AverageNormalizedUnitsUsedPerHour property is set
        internal bool IsSetAverageNormalizedUnitsUsedPerHour()
        {
            return this._averageNormalizedUnitsUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property AverageNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The average number of instances that you used in an hour during the historical period.
        /// AWS uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        public string AverageNumberOfInstancesUsedPerHour
        {
            get { return this._averageNumberOfInstancesUsedPerHour; }
            set { this._averageNumberOfInstancesUsedPerHour = value; }
        }

        // Check to see if AverageNumberOfInstancesUsedPerHour property is set
        internal bool IsSetAverageNumberOfInstancesUsedPerHour()
        {
            return this._averageNumberOfInstancesUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property AverageUtilization. 
        /// <para>
        /// The average utilization of your instances. AWS uses this to calculate your recommended
        /// reservation purchases.
        /// </para>
        /// </summary>
        public string AverageUtilization
        {
            get { return this._averageUtilization; }
            set { this._averageUtilization = value; }
        }

        // Check to see if AverageUtilization property is set
        internal bool IsSetAverageUtilization()
        {
            return this._averageUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code that AWS used to calculate the costs for this instance.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EstimatedBreakEvenInMonths. 
        /// <para>
        /// How long AWS estimates that it takes for this instance to start saving you money,
        /// in months.
        /// </para>
        /// </summary>
        public string EstimatedBreakEvenInMonths
        {
            get { return this._estimatedBreakEvenInMonths; }
            set { this._estimatedBreakEvenInMonths = value; }
        }

        // Check to see if EstimatedBreakEvenInMonths property is set
        internal bool IsSetEstimatedBreakEvenInMonths()
        {
            return this._estimatedBreakEvenInMonths != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyOnDemandCost. 
        /// <para>
        /// How much AWS estimates that you spend on On-Demand Instances in a month.
        /// </para>
        /// </summary>
        public string EstimatedMonthlyOnDemandCost
        {
            get { return this._estimatedMonthlyOnDemandCost; }
            set { this._estimatedMonthlyOnDemandCost = value; }
        }

        // Check to see if EstimatedMonthlyOnDemandCost property is set
        internal bool IsSetEstimatedMonthlyOnDemandCost()
        {
            return this._estimatedMonthlyOnDemandCost != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// How much AWS estimates that this specific recommendation could save you in a month.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EstimatedMonthlySavingsPercentage. 
        /// <para>
        /// How much AWS estimates that this specific recommendation could save you in a month,
        /// as a percentage of your overall costs.
        /// </para>
        /// </summary>
        public string EstimatedMonthlySavingsPercentage
        {
            get { return this._estimatedMonthlySavingsPercentage; }
            set { this._estimatedMonthlySavingsPercentage = value; }
        }

        // Check to see if EstimatedMonthlySavingsPercentage property is set
        internal bool IsSetEstimatedMonthlySavingsPercentage()
        {
            return this._estimatedMonthlySavingsPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedReservationCostForLookbackPeriod. 
        /// <para>
        /// How much AWS estimates that you would have spent for all usage during the specified
        /// historical period if you had had a reservation.
        /// </para>
        /// </summary>
        public string EstimatedReservationCostForLookbackPeriod
        {
            get { return this._estimatedReservationCostForLookbackPeriod; }
            set { this._estimatedReservationCostForLookbackPeriod = value; }
        }

        // Check to see if EstimatedReservationCostForLookbackPeriod property is set
        internal bool IsSetEstimatedReservationCostForLookbackPeriod()
        {
            return this._estimatedReservationCostForLookbackPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceDetails. 
        /// <para>
        /// Details about the instances that AWS recommends that you purchase.
        /// </para>
        /// </summary>
        public InstanceDetails InstanceDetails
        {
            get { return this._instanceDetails; }
            set { this._instanceDetails = value; }
        }

        // Check to see if InstanceDetails property is set
        internal bool IsSetInstanceDetails()
        {
            return this._instanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumNormalizedUnitsUsedPerHour. 
        /// <para>
        /// The maximum number of normalized units that you used in an hour during the historical
        /// period. AWS uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        public string MaximumNormalizedUnitsUsedPerHour
        {
            get { return this._maximumNormalizedUnitsUsedPerHour; }
            set { this._maximumNormalizedUnitsUsedPerHour = value; }
        }

        // Check to see if MaximumNormalizedUnitsUsedPerHour property is set
        internal bool IsSetMaximumNormalizedUnitsUsedPerHour()
        {
            return this._maximumNormalizedUnitsUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The maximum number of instances that you used in an hour during the historical period.
        /// AWS uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        public string MaximumNumberOfInstancesUsedPerHour
        {
            get { return this._maximumNumberOfInstancesUsedPerHour; }
            set { this._maximumNumberOfInstancesUsedPerHour = value; }
        }

        // Check to see if MaximumNumberOfInstancesUsedPerHour property is set
        internal bool IsSetMaximumNumberOfInstancesUsedPerHour()
        {
            return this._maximumNumberOfInstancesUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumNormalizedUnitsUsedPerHour. 
        /// <para>
        /// The minimum number of hours that you used in an hour during the historical period.
        /// AWS uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        public string MinimumNormalizedUnitsUsedPerHour
        {
            get { return this._minimumNormalizedUnitsUsedPerHour; }
            set { this._minimumNormalizedUnitsUsedPerHour = value; }
        }

        // Check to see if MinimumNormalizedUnitsUsedPerHour property is set
        internal bool IsSetMinimumNormalizedUnitsUsedPerHour()
        {
            return this._minimumNormalizedUnitsUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The minimum number of instances that you used in an hour during the historical period.
        /// AWS uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        public string MinimumNumberOfInstancesUsedPerHour
        {
            get { return this._minimumNumberOfInstancesUsedPerHour; }
            set { this._minimumNumberOfInstancesUsedPerHour = value; }
        }

        // Check to see if MinimumNumberOfInstancesUsedPerHour property is set
        internal bool IsSetMinimumNumberOfInstancesUsedPerHour()
        {
            return this._minimumNumberOfInstancesUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedNormalizedUnitsToPurchase. 
        /// <para>
        /// The number of normalized units that AWS recommends that you purchase.
        /// </para>
        /// </summary>
        public string RecommendedNormalizedUnitsToPurchase
        {
            get { return this._recommendedNormalizedUnitsToPurchase; }
            set { this._recommendedNormalizedUnitsToPurchase = value; }
        }

        // Check to see if RecommendedNormalizedUnitsToPurchase property is set
        internal bool IsSetRecommendedNormalizedUnitsToPurchase()
        {
            return this._recommendedNormalizedUnitsToPurchase != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedNumberOfInstancesToPurchase. 
        /// <para>
        /// The number of instances that AWS recommends that you purchase.
        /// </para>
        /// </summary>
        public string RecommendedNumberOfInstancesToPurchase
        {
            get { return this._recommendedNumberOfInstancesToPurchase; }
            set { this._recommendedNumberOfInstancesToPurchase = value; }
        }

        // Check to see if RecommendedNumberOfInstancesToPurchase property is set
        internal bool IsSetRecommendedNumberOfInstancesToPurchase()
        {
            return this._recommendedNumberOfInstancesToPurchase != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringStandardMonthlyCost. 
        /// <para>
        /// How much purchasing this instance costs you on a monthly basis.
        /// </para>
        /// </summary>
        public string RecurringStandardMonthlyCost
        {
            get { return this._recurringStandardMonthlyCost; }
            set { this._recurringStandardMonthlyCost = value; }
        }

        // Check to see if RecurringStandardMonthlyCost property is set
        internal bool IsSetRecurringStandardMonthlyCost()
        {
            return this._recurringStandardMonthlyCost != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// How much purchasing this instance costs you upfront.
        /// </para>
        /// </summary>
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