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
    /// Details about your recommended reservation purchase.
    /// </summary>
    public partial class ReservationPurchaseRecommendationDetail
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that this Reserved Instance (RI) recommendation is for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AverageNormalizedUnitsUsedPerHour. 
        /// <para>
        /// The average number of normalized units that you used in an hour during the historical
        /// period. Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AverageNormalizedUnitsUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the AverageNormalizedUnitsUsedPerHour property is set.
        /// </summary>
        internal bool IsSetAverageNormalizedUnitsUsedPerHour() => this.AverageNormalizedUnitsUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property AverageNumberOfCapacityUnitsUsedPerHour. 
        /// <para>
        /// The average number of provisioned capacity units that you used in an hour during the
        /// historical period. Amazon Web Services uses this to calculate your recommended reservation
        /// purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AverageNumberOfCapacityUnitsUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the AverageNumberOfCapacityUnitsUsedPerHour property is set.
        /// </summary>
        internal bool IsSetAverageNumberOfCapacityUnitsUsedPerHour() => this.AverageNumberOfCapacityUnitsUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property AverageNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The average number of instances that you used in an hour during the historical period.
        /// Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AverageNumberOfInstancesUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the AverageNumberOfInstancesUsedPerHour property is set.
        /// </summary>
        internal bool IsSetAverageNumberOfInstancesUsedPerHour() => this.AverageNumberOfInstancesUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property AverageUtilization. 
        /// <para>
        /// The average utilization of your instances. Amazon Web Services uses this to calculate
        /// your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AverageUtilization { get; set; }

        /// <summary>
        /// Checks to see if the AverageUtilization property is set.
        /// </summary>
        internal bool IsSetAverageUtilization() => this.AverageUtilization != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code that Amazon Web Services used to calculate the costs for this instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property EstimatedBreakEvenInMonths. 
        /// <para>
        /// How long Amazon Web Services estimates that it takes for this instance to start saving
        /// you money, in months.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedBreakEvenInMonths { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedBreakEvenInMonths property is set.
        /// </summary>
        internal bool IsSetEstimatedBreakEvenInMonths() => this.EstimatedBreakEvenInMonths != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyOnDemandCost. 
        /// <para>
        /// How much Amazon Web Services estimates that you spend on On-Demand Instances in a
        /// month.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedMonthlyOnDemandCost { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlyOnDemandCost property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlyOnDemandCost() => this.EstimatedMonthlyOnDemandCost != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsAmount. 
        /// <para>
        /// How much Amazon Web Services estimates that this specific recommendation might save
        /// you in a month.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedMonthlySavingsAmount { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavingsAmount property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavingsAmount() => this.EstimatedMonthlySavingsAmount != null;

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavingsPercentage. 
        /// <para>
        /// How much Amazon Web Services estimates that this specific recommendation might save
        /// you in a month, as a percentage of your overall costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedMonthlySavingsPercentage { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedMonthlySavingsPercentage property is set.
        /// </summary>
        internal bool IsSetEstimatedMonthlySavingsPercentage() => this.EstimatedMonthlySavingsPercentage != null;

        /// <summary>
        /// Gets and sets the property EstimatedReservationCostForLookbackPeriod. 
        /// <para>
        /// How much Amazon Web Services estimates that you might spend for all usage during the
        /// specified historical period if you had a reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string EstimatedReservationCostForLookbackPeriod { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedReservationCostForLookbackPeriod property is set.
        /// </summary>
        internal bool IsSetEstimatedReservationCostForLookbackPeriod() => this.EstimatedReservationCostForLookbackPeriod != null;

        /// <summary>
        /// Gets and sets the property InstanceDetails. 
        /// <para>
        /// Details about the reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public InstanceDetails InstanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the InstanceDetails property is set.
        /// </summary>
        internal bool IsSetInstanceDetails() => this.InstanceDetails != null;

        /// <summary>
        /// Gets and sets the property MaximumNormalizedUnitsUsedPerHour. 
        /// <para>
        /// The maximum number of normalized units that you used in an hour during the historical
        /// period. Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MaximumNormalizedUnitsUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the MaximumNormalizedUnitsUsedPerHour property is set.
        /// </summary>
        internal bool IsSetMaximumNormalizedUnitsUsedPerHour() => this.MaximumNormalizedUnitsUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property MaximumNumberOfCapacityUnitsUsedPerHour. 
        /// <para>
        /// The maximum number of provisioned capacity units that you used in an hour during the
        /// historical period. Amazon Web Services uses this to calculate your recommended reservation
        /// purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MaximumNumberOfCapacityUnitsUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the MaximumNumberOfCapacityUnitsUsedPerHour property is set.
        /// </summary>
        internal bool IsSetMaximumNumberOfCapacityUnitsUsedPerHour() => this.MaximumNumberOfCapacityUnitsUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property MaximumNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The maximum number of instances that you used in an hour during the historical period.
        /// Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MaximumNumberOfInstancesUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the MaximumNumberOfInstancesUsedPerHour property is set.
        /// </summary>
        internal bool IsSetMaximumNumberOfInstancesUsedPerHour() => this.MaximumNumberOfInstancesUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property MinimumNormalizedUnitsUsedPerHour. 
        /// <para>
        /// The minimum number of normalized units that you used in an hour during the historical
        /// period. Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MinimumNormalizedUnitsUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the MinimumNormalizedUnitsUsedPerHour property is set.
        /// </summary>
        internal bool IsSetMinimumNormalizedUnitsUsedPerHour() => this.MinimumNormalizedUnitsUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property MinimumNumberOfCapacityUnitsUsedPerHour. 
        /// <para>
        /// The minimum number of provisioned capacity units that you used in an hour during the
        /// historical period. Amazon Web Services uses this to calculate your recommended reservation
        /// purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MinimumNumberOfCapacityUnitsUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the MinimumNumberOfCapacityUnitsUsedPerHour property is set.
        /// </summary>
        internal bool IsSetMinimumNumberOfCapacityUnitsUsedPerHour() => this.MinimumNumberOfCapacityUnitsUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property MinimumNumberOfInstancesUsedPerHour. 
        /// <para>
        /// The minimum number of instances that you used in an hour during the historical period.
        /// Amazon Web Services uses this to calculate your recommended reservation purchases.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MinimumNumberOfInstancesUsedPerHour { get; set; }

        /// <summary>
        /// Checks to see if the MinimumNumberOfInstancesUsedPerHour property is set.
        /// </summary>
        internal bool IsSetMinimumNumberOfInstancesUsedPerHour() => this.MinimumNumberOfInstancesUsedPerHour != null;

        /// <summary>
        /// Gets and sets the property RecommendedNormalizedUnitsToPurchase. 
        /// <para>
        /// The number of normalized units that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RecommendedNormalizedUnitsToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedNormalizedUnitsToPurchase property is set.
        /// </summary>
        internal bool IsSetRecommendedNormalizedUnitsToPurchase() => this.RecommendedNormalizedUnitsToPurchase != null;

        /// <summary>
        /// Gets and sets the property RecommendedNumberOfCapacityUnitsToPurchase. 
        /// <para>
        /// The number of reserved capacity units that Amazon Web Services recommends that you
        /// purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RecommendedNumberOfCapacityUnitsToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedNumberOfCapacityUnitsToPurchase property is set.
        /// </summary>
        internal bool IsSetRecommendedNumberOfCapacityUnitsToPurchase() => this.RecommendedNumberOfCapacityUnitsToPurchase != null;

        /// <summary>
        /// Gets and sets the property RecommendedNumberOfInstancesToPurchase. 
        /// <para>
        /// The number of instances that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RecommendedNumberOfInstancesToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedNumberOfInstancesToPurchase property is set.
        /// </summary>
        internal bool IsSetRecommendedNumberOfInstancesToPurchase() => this.RecommendedNumberOfInstancesToPurchase != null;

        /// <summary>
        /// Gets and sets the property RecurringStandardMonthlyCost. 
        /// <para>
        /// How much purchasing this instance costs you on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RecurringStandardMonthlyCost { get; set; }

        /// <summary>
        /// Checks to see if the RecurringStandardMonthlyCost property is set.
        /// </summary>
        internal bool IsSetRecurringStandardMonthlyCost() => this.RecurringStandardMonthlyCost != null;

        /// <summary>
        /// Gets and sets the property ReservedCapacityDetails. 
        /// <para>
        /// Details about the reservations that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public ReservedCapacityDetails ReservedCapacityDetails { get; set; }

        /// <summary>
        /// Checks to see if the ReservedCapacityDetails property is set.
        /// </summary>
        internal bool IsSetReservedCapacityDetails() => this.ReservedCapacityDetails != null;

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// How much purchasing this instance costs you upfront.
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
