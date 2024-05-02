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
    /// The aggregated numbers for your reservation usage.
    /// </summary>
    public partial class ReservationAggregates
    {
        private string _amortizedRecurringFee;
        private string _amortizedUpfrontFee;
        private string _netRISavings;
        private string _onDemandCostOfRIHoursUsed;
        private string _purchasedHours;
        private string _purchasedUnits;
        private string _realizedSavings;
        private string _riCostForUnusedHours;
        private string _totalActualHours;
        private string _totalActualUnits;
        private string _totalAmortizedFee;
        private string _totalPotentialRISavings;
        private string _unrealizedSavings;
        private string _unusedHours;
        private string _unusedUnits;
        private string _utilizationPercentage;
        private string _utilizationPercentageInUnits;

        /// <summary>
        /// Gets and sets the property AmortizedRecurringFee. 
        /// <para>
        /// The monthly cost of your reservation. It's amortized over the reservation period.
        /// </para>
        /// </summary>
        public string AmortizedRecurringFee
        {
            get { return this._amortizedRecurringFee; }
            set { this._amortizedRecurringFee = value; }
        }

        // Check to see if AmortizedRecurringFee property is set
        internal bool IsSetAmortizedRecurringFee()
        {
            return this._amortizedRecurringFee != null;
        }

        /// <summary>
        /// Gets and sets the property AmortizedUpfrontFee. 
        /// <para>
        /// The upfront cost of your reservation. It's amortized over the reservation period.
        /// </para>
        /// </summary>
        public string AmortizedUpfrontFee
        {
            get { return this._amortizedUpfrontFee; }
            set { this._amortizedUpfrontFee = value; }
        }

        // Check to see if AmortizedUpfrontFee property is set
        internal bool IsSetAmortizedUpfrontFee()
        {
            return this._amortizedUpfrontFee != null;
        }

        /// <summary>
        /// Gets and sets the property NetRISavings. 
        /// <para>
        /// How much you saved due to purchasing and utilizing reservation. Amazon Web Services
        /// calculates this by subtracting <c>TotalAmortizedFee</c> from <c>OnDemandCostOfRIHoursUsed</c>.
        /// </para>
        /// </summary>
        public string NetRISavings
        {
            get { return this._netRISavings; }
            set { this._netRISavings = value; }
        }

        // Check to see if NetRISavings property is set
        internal bool IsSetNetRISavings()
        {
            return this._netRISavings != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandCostOfRIHoursUsed. 
        /// <para>
        /// How much your reservation costs if charged On-Demand rates.
        /// </para>
        /// </summary>
        public string OnDemandCostOfRIHoursUsed
        {
            get { return this._onDemandCostOfRIHoursUsed; }
            set { this._onDemandCostOfRIHoursUsed = value; }
        }

        // Check to see if OnDemandCostOfRIHoursUsed property is set
        internal bool IsSetOnDemandCostOfRIHoursUsed()
        {
            return this._onDemandCostOfRIHoursUsed != null;
        }

        /// <summary>
        /// Gets and sets the property PurchasedHours. 
        /// <para>
        /// How many reservation hours that you purchased.
        /// </para>
        /// </summary>
        public string PurchasedHours
        {
            get { return this._purchasedHours; }
            set { this._purchasedHours = value; }
        }

        // Check to see if PurchasedHours property is set
        internal bool IsSetPurchasedHours()
        {
            return this._purchasedHours != null;
        }

        /// <summary>
        /// Gets and sets the property PurchasedUnits. 
        /// <para>
        /// The number of Amazon EC2 reservation hours that you purchased. It's converted to normalized
        /// units. Normalized units are available only for Amazon EC2 usage after November 11,
        /// 2017.
        /// </para>
        /// </summary>
        public string PurchasedUnits
        {
            get { return this._purchasedUnits; }
            set { this._purchasedUnits = value; }
        }

        // Check to see if PurchasedUnits property is set
        internal bool IsSetPurchasedUnits()
        {
            return this._purchasedUnits != null;
        }

        /// <summary>
        /// Gets and sets the property RealizedSavings. 
        /// <para>
        /// The realized savings because of purchasing and using a reservation.
        /// </para>
        /// </summary>
        public string RealizedSavings
        {
            get { return this._realizedSavings; }
            set { this._realizedSavings = value; }
        }

        // Check to see if RealizedSavings property is set
        internal bool IsSetRealizedSavings()
        {
            return this._realizedSavings != null;
        }

        /// <summary>
        /// Gets and sets the property RICostForUnusedHours. 
        /// <para>
        /// The cost of unused hours for your reservation.
        /// </para>
        /// </summary>
        public string RICostForUnusedHours
        {
            get { return this._riCostForUnusedHours; }
            set { this._riCostForUnusedHours = value; }
        }

        // Check to see if RICostForUnusedHours property is set
        internal bool IsSetRICostForUnusedHours()
        {
            return this._riCostForUnusedHours != null;
        }

        /// <summary>
        /// Gets and sets the property TotalActualHours. 
        /// <para>
        /// The total number of reservation hours that you used.
        /// </para>
        /// </summary>
        public string TotalActualHours
        {
            get { return this._totalActualHours; }
            set { this._totalActualHours = value; }
        }

        // Check to see if TotalActualHours property is set
        internal bool IsSetTotalActualHours()
        {
            return this._totalActualHours != null;
        }

        /// <summary>
        /// Gets and sets the property TotalActualUnits. 
        /// <para>
        /// The total number of Amazon EC2 reservation hours that you used. It's converted to
        /// normalized units. Normalized units are available only for Amazon EC2 usage after November
        /// 11, 2017.
        /// </para>
        /// </summary>
        public string TotalActualUnits
        {
            get { return this._totalActualUnits; }
            set { this._totalActualUnits = value; }
        }

        // Check to see if TotalActualUnits property is set
        internal bool IsSetTotalActualUnits()
        {
            return this._totalActualUnits != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAmortizedFee. 
        /// <para>
        /// The total cost of your reservation. It's amortized over the reservation period.
        /// </para>
        /// </summary>
        public string TotalAmortizedFee
        {
            get { return this._totalAmortizedFee; }
            set { this._totalAmortizedFee = value; }
        }

        // Check to see if TotalAmortizedFee property is set
        internal bool IsSetTotalAmortizedFee()
        {
            return this._totalAmortizedFee != null;
        }

        /// <summary>
        /// Gets and sets the property TotalPotentialRISavings. 
        /// <para>
        /// How much you might save if you use your entire reservation.
        /// </para>
        /// </summary>
        public string TotalPotentialRISavings
        {
            get { return this._totalPotentialRISavings; }
            set { this._totalPotentialRISavings = value; }
        }

        // Check to see if TotalPotentialRISavings property is set
        internal bool IsSetTotalPotentialRISavings()
        {
            return this._totalPotentialRISavings != null;
        }

        /// <summary>
        /// Gets and sets the property UnrealizedSavings. 
        /// <para>
        /// The unrealized savings because of purchasing and using a reservation.
        /// </para>
        /// </summary>
        public string UnrealizedSavings
        {
            get { return this._unrealizedSavings; }
            set { this._unrealizedSavings = value; }
        }

        // Check to see if UnrealizedSavings property is set
        internal bool IsSetUnrealizedSavings()
        {
            return this._unrealizedSavings != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedHours. 
        /// <para>
        /// The number of reservation hours that you didn't use.
        /// </para>
        /// </summary>
        public string UnusedHours
        {
            get { return this._unusedHours; }
            set { this._unusedHours = value; }
        }

        // Check to see if UnusedHours property is set
        internal bool IsSetUnusedHours()
        {
            return this._unusedHours != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedUnits. 
        /// <para>
        /// The number of Amazon EC2 reservation hours that you didn't use. It's converted to
        /// normalized units. Normalized units are available only for Amazon EC2 usage after November
        /// 11, 2017.
        /// </para>
        /// </summary>
        public string UnusedUnits
        {
            get { return this._unusedUnits; }
            set { this._unusedUnits = value; }
        }

        // Check to see if UnusedUnits property is set
        internal bool IsSetUnusedUnits()
        {
            return this._unusedUnits != null;
        }

        /// <summary>
        /// Gets and sets the property UtilizationPercentage. 
        /// <para>
        /// The percentage of reservation time that you used.
        /// </para>
        /// </summary>
        public string UtilizationPercentage
        {
            get { return this._utilizationPercentage; }
            set { this._utilizationPercentage = value; }
        }

        // Check to see if UtilizationPercentage property is set
        internal bool IsSetUtilizationPercentage()
        {
            return this._utilizationPercentage != null;
        }

        /// <summary>
        /// Gets and sets the property UtilizationPercentageInUnits. 
        /// <para>
        /// The percentage of Amazon EC2 reservation time that you used. It's converted to normalized
        /// units. Normalized units are available only for Amazon EC2 usage after November 11,
        /// 2017.
        /// </para>
        /// </summary>
        public string UtilizationPercentageInUnits
        {
            get { return this._utilizationPercentageInUnits; }
            set { this._utilizationPercentageInUnits = value; }
        }

        // Check to see if UtilizationPercentageInUnits property is set
        internal bool IsSetUtilizationPercentageInUnits()
        {
            return this._utilizationPercentageInUnits != null;
        }

    }
}