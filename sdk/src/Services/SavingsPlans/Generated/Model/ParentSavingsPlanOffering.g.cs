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

namespace Amazon.SavingsPlans.Model
{
    /// <summary>
    /// Information about a Savings Plan offering.
    /// </summary>
    public partial class ParentSavingsPlanOffering
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency.
        /// </para>
        /// </summary>
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The duration, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the offering.
        /// </para>
        /// </summary>
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        public SavingsPlanPaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property PlanDescription. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        public string PlanDescription { get; set; }

        /// <summary>
        /// Checks to see if the PlanDescription property is set.
        /// </summary>
        internal bool IsSetPlanDescription() => this.PlanDescription != null;

        /// <summary>
        /// Gets and sets the property PlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        public SavingsPlanType PlanType { get; set; }

        /// <summary>
        /// Checks to see if the PlanType property is set.
        /// </summary>
        internal bool IsSetPlanType() => this.PlanType != null;
    }
}
