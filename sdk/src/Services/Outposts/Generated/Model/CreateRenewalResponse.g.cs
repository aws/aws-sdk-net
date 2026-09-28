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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the CreateRenewal operation.
    /// </summary>
    public partial class CreateRenewalResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Currency. 
        /// <para>
        /// The currency of the renewal price.
        /// </para>
        /// </summary>
        public CurrencyCode Currency { get; set; }

        /// <summary>
        /// Checks to see if the Currency property is set.
        /// </summary>
        internal bool IsSetCurrency() => this.Currency != null;

        /// <summary>
        /// Gets and sets the property MonthlyRecurringPrice. 
        /// <para>
        /// The monthly recurring price of the renewal.
        /// </para>
        /// </summary>
        public float? MonthlyRecurringPrice { get; set; }

        /// <summary>
        /// Checks to see if the MonthlyRecurringPrice property is set.
        /// </summary>
        internal bool IsSetMonthlyRecurringPrice() => this.MonthlyRecurringPrice.HasValue;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID of the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property PaymentTerm. 
        /// <para>
        /// The payment term.
        /// </para>
        /// </summary>
        public PaymentTerm PaymentTerm { get; set; }

        /// <summary>
        /// Checks to see if the PaymentTerm property is set.
        /// </summary>
        internal bool IsSetPaymentTerm() => this.PaymentTerm != null;

        /// <summary>
        /// Gets and sets the property UpfrontPrice. 
        /// <para>
        /// The upfront price of the renewal.
        /// </para>
        /// </summary>
        public float? UpfrontPrice { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontPrice property is set.
        /// </summary>
        internal bool IsSetUpfrontPrice() => this.UpfrontPrice.HasValue;
    }
}
