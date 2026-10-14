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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The Redshift reserved instances configuration used for recommendations.
    /// </summary>
    public partial class RedshiftReservedInstancesConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountScope. 
        /// <para>
        /// The account scope for which you want recommendations.
        /// </para>
        /// </summary>
        public string AccountScope { get; set; }

        /// <summary>
        /// Checks to see if the AccountScope property is set.
        /// </summary>
        internal bool IsSetAccountScope() => this.AccountScope != null;

        /// <summary>
        /// Gets and sets the property CurrentGeneration. 
        /// <para>
        /// Determines whether the recommendation is for a current generation instance.
        /// </para>
        /// </summary>
        public string CurrentGeneration { get; set; }

        /// <summary>
        /// Checks to see if the CurrentGeneration property is set.
        /// </summary>
        internal bool IsSetCurrentGeneration() => this.CurrentGeneration != null;

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family of the recommended reservation.
        /// </para>
        /// </summary>
        public string InstanceFamily { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFamily property is set.
        /// </summary>
        internal bool IsSetInstanceFamily() => this.InstanceFamily != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The type of instance that Amazon Web Services recommends.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MonthlyRecurringCost. 
        /// <para>
        /// How much purchasing these reserved instances costs you on a monthly basis.
        /// </para>
        /// </summary>
        public string MonthlyRecurringCost { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyRecurringCost property is set.
        /// </summary>
        internal bool IsSetMonthlyRecurringCost() => this.MonthlyRecurringCost != null;

        /// <summary>
        /// Gets and sets the property NormalizedUnitsToPurchase. 
        /// <para>
        /// The number of normalized units that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public string NormalizedUnitsToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the NormalizedUnitsToPurchase property is set.
        /// </summary>
        internal bool IsSetNormalizedUnitsToPurchase() => this.NormalizedUnitsToPurchase != null;

        /// <summary>
        /// Gets and sets the property NumberOfInstancesToPurchase. 
        /// <para>
        /// The number of instances that Amazon Web Services recommends that you purchase.
        /// </para>
        /// </summary>
        public string NumberOfInstancesToPurchase { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfInstancesToPurchase property is set.
        /// </summary>
        internal bool IsSetNumberOfInstancesToPurchase() => this.NumberOfInstancesToPurchase != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option for the commitment.
        /// </para>
        /// </summary>
        public string PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property ReservedInstancesRegion. 
        /// <para>
        /// The Amazon Web Services Region of the commitment.
        /// </para>
        /// </summary>
        public string ReservedInstancesRegion { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstancesRegion property is set.
        /// </summary>
        internal bool IsSetReservedInstancesRegion() => this.ReservedInstancesRegion != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The service for which you want recommendations.
        /// </para>
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property SizeFlexEligible. 
        /// <para>
        /// Determines whether the recommendation is size flexible.
        /// </para>
        /// </summary>
        public bool? SizeFlexEligible { get; set; }

        /// <summary>
        /// Checks to see if the SizeFlexEligible property is set.
        /// </summary>
        internal bool IsSetSizeFlexEligible() => this.SizeFlexEligible.HasValue;

        /// <summary>
        /// Gets and sets the property Term. 
        /// <para>
        /// The reserved instances recommendation term in years.
        /// </para>
        /// </summary>
        public string Term { get; set; }

        /// <summary>
        /// Checks to see if the Term property is set.
        /// </summary>
        internal bool IsSetTerm() => this.Term != null;

        /// <summary>
        /// Gets and sets the property UpfrontCost. 
        /// <para>
        /// How much purchasing this instance costs you upfront.
        /// </para>
        /// </summary>
        public string UpfrontCost { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontCost property is set.
        /// </summary>
        internal bool IsSetUpfrontCost() => this.UpfrontCost != null;
    }
}
