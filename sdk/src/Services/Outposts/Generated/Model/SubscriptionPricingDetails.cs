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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// The pricing details for a subscription.
    /// </summary>
    public partial class SubscriptionPricingDetails
    {
        private float? _monthlyRecurringPrice;
        private PaymentOption _paymentOption;
        private PaymentTerm _paymentTerm;
        private float? _upfrontPrice;

        /// <summary>
        /// Gets and sets the property MonthlyRecurringPrice. 
        /// <para>
        /// The monthly recurring price.
        /// </para>
        /// </summary>
        public float? MonthlyRecurringPrice
        {
            get { return this._monthlyRecurringPrice; }
            set { this._monthlyRecurringPrice = value; }
        }

        // Check to see if MonthlyRecurringPrice property is set
        internal bool IsSetMonthlyRecurringPrice()
        {
            return this._monthlyRecurringPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentTerm. 
        /// <para>
        /// The payment term.
        /// </para>
        /// </summary>
        public PaymentTerm PaymentTerm
        {
            get { return this._paymentTerm; }
            set { this._paymentTerm = value; }
        }

        // Check to see if PaymentTerm property is set
        internal bool IsSetPaymentTerm()
        {
            return this._paymentTerm != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontPrice. 
        /// <para>
        /// The upfront price.
        /// </para>
        /// </summary>
        public float? UpfrontPrice
        {
            get { return this._upfrontPrice; }
            set { this._upfrontPrice = value; }
        }

        // Check to see if UpfrontPrice property is set
        internal bool IsSetUpfrontPrice()
        {
            return this._upfrontPrice.HasValue; 
        }

    }
}