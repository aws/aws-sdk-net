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
    /// The aggregated numbers for your reservation usage.
    /// </summary>
    public partial class ReservationAggregates
    {
        /// <summary>
        /// Gets and sets the property AmortizedRecurringFee. 
        /// <para>
        /// The monthly cost of your reservation. It's amortized over the reservation period.
        /// </para>
        /// </summary>
        public string AmortizedRecurringFee { get; set; }

        /// <summary>
        /// Checks to see if the AmortizedRecurringFee property is set.
        /// </summary>
        internal bool IsSetAmortizedRecurringFee() => this.AmortizedRecurringFee != null;

        /// <summary>
        /// Gets and sets the property AmortizedUpfrontFee. 
        /// <para>
        /// The upfront cost of your reservation. It's amortized over the reservation period.
        /// </para>
        /// </summary>
        public string AmortizedUpfrontFee { get; set; }

        /// <summary>
        /// Checks to see if the AmortizedUpfrontFee property is set.
        /// </summary>
        internal bool IsSetAmortizedUpfrontFee() => this.AmortizedUpfrontFee != null;

        /// <summary>
        /// Gets and sets the property NetRISavings. 
        /// <para>
        /// How much you saved due to purchasing and utilizing reservation. Amazon Web Services
        /// calculates this by subtracting <c>TotalAmortizedFee</c> from <c>OnDemandCostOfRIHoursUsed</c>.
        /// </para>
        /// </summary>
        public string NetRISavings { get; set; }

        /// <summary>
        /// Checks to see if the NetRISavings property is set.
        /// </summary>
        internal bool IsSetNetRISavings() => this.NetRISavings != null;

        /// <summary>
        /// Gets and sets the property OnDemandCostOfRIHoursUsed. 
        /// <para>
        /// How much your reservation costs if charged On-Demand rates.
        /// </para>
        /// </summary>
        public string OnDemandCostOfRIHoursUsed { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandCostOfRIHoursUsed property is set.
        /// </summary>
        internal bool IsSetOnDemandCostOfRIHoursUsed() => this.OnDemandCostOfRIHoursUsed != null;

        /// <summary>
        /// Gets and sets the property PurchasedHours. 
        /// <para>
        /// How many reservation hours that you purchased.
        /// </para>
        /// </summary>
        public string PurchasedHours { get; set; }

        /// <summary>
        /// Checks to see if the PurchasedHours property is set.
        /// </summary>
        internal bool IsSetPurchasedHours() => this.PurchasedHours != null;

        /// <summary>
        /// Gets and sets the property PurchasedUnits. 
        /// <para>
        /// The number of Amazon EC2 reservation hours that you purchased. It's converted to normalized
        /// units. Normalized units are available only for Amazon EC2 usage after November 11,
        /// 2017.
        /// </para>
        /// </summary>
        public string PurchasedUnits { get; set; }

        /// <summary>
        /// Checks to see if the PurchasedUnits property is set.
        /// </summary>
        internal bool IsSetPurchasedUnits() => this.PurchasedUnits != null;

        /// <summary>
        /// Gets and sets the property RICostForUnusedHours. 
        /// <para>
        /// The cost of unused hours for your reservation.
        /// </para>
        /// </summary>
        public string RICostForUnusedHours { get; set; }

        /// <summary>
        /// Checks to see if the RICostForUnusedHours property is set.
        /// </summary>
        internal bool IsSetRICostForUnusedHours() => this.RICostForUnusedHours != null;

        /// <summary>
        /// Gets and sets the property RealizedSavings. 
        /// <para>
        /// The realized savings because of purchasing and using a reservation.
        /// </para>
        /// </summary>
        public string RealizedSavings { get; set; }

        /// <summary>
        /// Checks to see if the RealizedSavings property is set.
        /// </summary>
        internal bool IsSetRealizedSavings() => this.RealizedSavings != null;

        /// <summary>
        /// Gets and sets the property TotalActualHours. 
        /// <para>
        /// The total number of reservation hours that you used.
        /// </para>
        /// </summary>
        public string TotalActualHours { get; set; }

        /// <summary>
        /// Checks to see if the TotalActualHours property is set.
        /// </summary>
        internal bool IsSetTotalActualHours() => this.TotalActualHours != null;

        /// <summary>
        /// Gets and sets the property TotalActualUnits. 
        /// <para>
        /// The total number of Amazon EC2 reservation hours that you used. It's converted to
        /// normalized units. Normalized units are available only for Amazon EC2 usage after November
        /// 11, 2017.
        /// </para>
        /// </summary>
        public string TotalActualUnits { get; set; }

        /// <summary>
        /// Checks to see if the TotalActualUnits property is set.
        /// </summary>
        internal bool IsSetTotalActualUnits() => this.TotalActualUnits != null;

        /// <summary>
        /// Gets and sets the property TotalAmortizedFee. 
        /// <para>
        /// The total cost of your reservation. It's amortized over the reservation period.
        /// </para>
        /// </summary>
        public string TotalAmortizedFee { get; set; }

        /// <summary>
        /// Checks to see if the TotalAmortizedFee property is set.
        /// </summary>
        internal bool IsSetTotalAmortizedFee() => this.TotalAmortizedFee != null;

        /// <summary>
        /// Gets and sets the property TotalPotentialRISavings. 
        /// <para>
        /// How much you might save if you use your entire reservation.
        /// </para>
        /// </summary>
        public string TotalPotentialRISavings { get; set; }

        /// <summary>
        /// Checks to see if the TotalPotentialRISavings property is set.
        /// </summary>
        internal bool IsSetTotalPotentialRISavings() => this.TotalPotentialRISavings != null;

        /// <summary>
        /// Gets and sets the property UnrealizedSavings. 
        /// <para>
        /// The unrealized savings because of purchasing and using a reservation.
        /// </para>
        /// </summary>
        public string UnrealizedSavings { get; set; }

        /// <summary>
        /// Checks to see if the UnrealizedSavings property is set.
        /// </summary>
        internal bool IsSetUnrealizedSavings() => this.UnrealizedSavings != null;

        /// <summary>
        /// Gets and sets the property UnusedHours. 
        /// <para>
        /// The number of reservation hours that you didn't use.
        /// </para>
        /// </summary>
        public string UnusedHours { get; set; }

        /// <summary>
        /// Checks to see if the UnusedHours property is set.
        /// </summary>
        internal bool IsSetUnusedHours() => this.UnusedHours != null;

        /// <summary>
        /// Gets and sets the property UnusedUnits. 
        /// <para>
        /// The number of Amazon EC2 reservation hours that you didn't use. It's converted to
        /// normalized units. Normalized units are available only for Amazon EC2 usage after November
        /// 11, 2017.
        /// </para>
        /// </summary>
        public string UnusedUnits { get; set; }

        /// <summary>
        /// Checks to see if the UnusedUnits property is set.
        /// </summary>
        internal bool IsSetUnusedUnits() => this.UnusedUnits != null;

        /// <summary>
        /// Gets and sets the property UtilizationPercentage. 
        /// <para>
        /// The percentage of reservation time that you used.
        /// </para>
        /// </summary>
        public string UtilizationPercentage { get; set; }

        /// <summary>
        /// Checks to see if the UtilizationPercentage property is set.
        /// </summary>
        internal bool IsSetUtilizationPercentage() => this.UtilizationPercentage != null;

        /// <summary>
        /// Gets and sets the property UtilizationPercentageInUnits. 
        /// <para>
        /// The percentage of Amazon EC2 reservation time that you used. It's converted to normalized
        /// units. Normalized units are available only for Amazon EC2 usage after November 11,
        /// 2017.
        /// </para>
        /// </summary>
        public string UtilizationPercentageInUnits { get; set; }

        /// <summary>
        /// Checks to see if the UtilizationPercentageInUnits property is set.
        /// </summary>
        internal bool IsSetUtilizationPercentageInUnits() => this.UtilizationPercentageInUnits != null;
    }
}
