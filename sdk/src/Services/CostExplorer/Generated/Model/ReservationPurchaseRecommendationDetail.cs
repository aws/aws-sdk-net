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
    /// Details about your recommended reservation purchase.
    /// </summary>
    public partial class ReservationPurchaseRecommendationDetail
    {
        private string _accountId;
        private string _averageNormalizedUnitsUsedPerHour;
        private string _averageNumberOfCapacityUnitsUsedPerHour;
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
        private string _maximumNumberOfCapacityUnitsUsedPerHour;
        private string _maximumNumberOfInstancesUsedPerHour;
        private string _minimumNormalizedUnitsUsedPerHour;
        private string _minimumNumberOfCapacityUnitsUsedPerHour;
        private string _minimumNumberOfInstancesUsedPerHour;
        private string _recommendedNormalizedUnitsToPurchase;
        private string _recommendedNumberOfCapacityUnitsToPurchase;
        private string _recommendedNumberOfInstancesToPurchase;
        private string _recurringStandardMonthlyCost;
        private ReservedCapacityDetails _reservedCapacityDetails;
        private string _upfrontCost;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that this Reserved Instance (RI) recommendation is for.
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
        /// Gets and sets the property AverageNormalizedUnitsUsedPerHour. 
        /// <para>
        /// The average number of normalized units that you used in an hour during the historical
        /// period. Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property AverageNumberOfCapacityUnitsUsedPerHour. 
        /// <para>
        /// The average number of provisioned capacity units that you used in an hour during the
        /// historical period. Amazon Web Services uses this to calculate your recommended reservation
        /// purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AverageNumberOfCapacityUnitsUsedPerHour
        {
            get { return this._averageNumberOfCapacityUnitsUsedPerHour; }
            set { this._averageNumberOfCapacityUnitsUsedPerHour = value; }
        }

        // Check to see if AverageNumberOfCapacityUnitsUsedPerHour property is set
        internal bool IsSetAverageNumberOfCapacityUnitsUsedPerHour()
        {
            return this._averageNumberOfCapacityUnitsUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property AverageNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The average number of instances that you used in an hour during the historical period.
        /// Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The average utilization of your instances. Amazon Web Services uses this to calculate
        /// your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The currency code that Amazon Web Services used to calculate the costs for this instance.
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
        /// Gets and sets the property EstimatedBreakEvenInMonths. 
        /// <para>
        /// How long Amazon Web Services estimates that it takes for this instance to start saving
        /// you money, in months.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// How much Amazon Web Services estimates that you spend on On-Demand Instances in a
        /// month.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// How much Amazon Web Services estimates that this specific recommendation might save
        /// you in a month.
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
        /// Gets and sets the property EstimatedMonthlySavingsPercentage. 
        /// <para>
        /// How much Amazon Web Services estimates that this specific recommendation might save
        /// you in a month, as a percentage of your overall costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// How much Amazon Web Services estimates that you might spend for all usage during the
        /// specified historical period if you had a reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Details about the reservations that Amazon Web Services recommends that you purchase.
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
        /// period. Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property MaximumNumberOfCapacityUnitsUsedPerHour. 
        /// <para>
        /// The maximum number of provisioned capacity units that you used in an hour during the
        /// historical period. Amazon Web Services uses this to calculate your recommended reservation
        /// purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MaximumNumberOfCapacityUnitsUsedPerHour
        {
            get { return this._maximumNumberOfCapacityUnitsUsedPerHour; }
            set { this._maximumNumberOfCapacityUnitsUsedPerHour = value; }
        }

        // Check to see if MaximumNumberOfCapacityUnitsUsedPerHour property is set
        internal bool IsSetMaximumNumberOfCapacityUnitsUsedPerHour()
        {
            return this._maximumNumberOfCapacityUnitsUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The maximum number of instances that you used in an hour during the historical period.
        /// Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The minimum number of normalized units that you used in an hour during the historical
        /// period. Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property MinimumNumberOfCapacityUnitsUsedPerHour. 
        /// <para>
        /// The minimum number of provisioned capacity units that you used in an hour during the
        /// historical period. Amazon Web Services uses this to calculate your recommended reservation
        /// purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MinimumNumberOfCapacityUnitsUsedPerHour
        {
            get { return this._minimumNumberOfCapacityUnitsUsedPerHour; }
            set { this._minimumNumberOfCapacityUnitsUsedPerHour = value; }
        }

        // Check to see if MinimumNumberOfCapacityUnitsUsedPerHour property is set
        internal bool IsSetMinimumNumberOfCapacityUnitsUsedPerHour()
        {
            return this._minimumNumberOfCapacityUnitsUsedPerHour != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The minimum number of instances that you used in an hour during the historical period.
        /// Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// The number of normalized units that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property RecommendedNumberOfCapacityUnitsToPurchase. 
        /// <para>
        /// The number of reserved capacity units that Amazon Web Services recommends that you
        /// purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string RecommendedNumberOfCapacityUnitsToPurchase
        {
            get { return this._recommendedNumberOfCapacityUnitsToPurchase; }
            set { this._recommendedNumberOfCapacityUnitsToPurchase = value; }
        }

        // Check to see if RecommendedNumberOfCapacityUnitsToPurchase property is set
        internal bool IsSetRecommendedNumberOfCapacityUnitsToPurchase()
        {
            return this._recommendedNumberOfCapacityUnitsToPurchase != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedNumberOfInstancesToPurchase. 
        /// <para>
        /// The number of instances that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property ReservedCapacityDetails. 
        /// <para>
        /// Details about the reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public ReservedCapacityDetails ReservedCapacityDetails
        {
            get { return this._reservedCapacityDetails; }
            set { this._reservedCapacityDetails = value; }
        }

        // Check to see if ReservedCapacityDetails property is set
        internal bool IsSetReservedCapacityDetails()
        {
            return this._reservedCapacityDetails != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// How much purchasing this instance costs you upfront.
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