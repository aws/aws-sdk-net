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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines a pricing model where customers are charged a fixed recurring price at the
    /// end of each billing period.
    /// </summary>
    public partial class RecurringPaymentTerm
    {
        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// Defines the recurrence at which buyers are charged.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// Defines the currency for the prices mentioned in this term. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 3)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// Amount charged to the buyer every billing period.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the term being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
