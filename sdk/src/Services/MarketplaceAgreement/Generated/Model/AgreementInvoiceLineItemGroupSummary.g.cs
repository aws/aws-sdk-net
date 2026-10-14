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
    /// A summary of grouped billing data for an agreement invoice line item.
    /// </summary>
    public partial class AgreementInvoiceLineItemGroupSummary
    {
        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Checks to see if the AgreementId property is set.
        /// </summary>
        internal bool IsSetAgreementId() => this.AgreementId != null;

        /// <summary>
        /// Gets and sets the property InvoiceBillingPeriod. 
        /// <para>
        /// The billing period associated with this group.
        /// </para>
        /// </summary>
        public InvoiceBillingPeriod InvoiceBillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceBillingPeriod property is set.
        /// </summary>
        internal bool IsSetInvoiceBillingPeriod() => this.InvoiceBillingPeriod != null;

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// The identifier of the invoice for this group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceId property is set.
        /// </summary>
        internal bool IsSetInvoiceId() => this.InvoiceId != null;

        /// <summary>
        /// Gets and sets the property InvoiceType. 
        /// <para>
        /// The type of invoice. Valid values are <c>INVOICE</c> and <c>CREDIT_MEMO</c>.
        /// </para>
        /// </summary>
        public InvoiceType InvoiceType { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceType property is set.
        /// </summary>
        internal bool IsSetInvoiceType() => this.InvoiceType != null;

        /// <summary>
        /// Gets and sets the property InvoicingEntity. 
        /// <para>
        /// The entity that issues the invoice.
        /// </para>
        /// </summary>
        public InvoicingEntity InvoicingEntity { get; set; }

        /// <summary>
        /// Checks to see if the InvoicingEntity property is set.
        /// </summary>
        internal bool IsSetInvoicingEntity() => this.InvoicingEntity != null;

        /// <summary>
        /// Gets and sets the property IssuedTime. 
        /// <para>
        /// The timestamp when the invoice containing this group was created.
        /// </para>
        /// </summary>
        public DateTime? IssuedTime { get; set; }

        /// <summary>
        /// Checks to see if the IssuedTime property is set.
        /// </summary>
        internal bool IsSetIssuedTime() => this.IssuedTime.HasValue;

        /// <summary>
        /// Gets and sets the property PricingCurrencyAmount. 
        /// <para>
        /// Monetary amounts for this invoice group.
        /// </para>
        /// </summary>
        public PricingCurrencyAmount PricingCurrencyAmount { get; set; }

        /// <summary>
        /// Checks to see if the PricingCurrencyAmount property is set.
        /// </summary>
        internal bool IsSetPricingCurrencyAmount() => this.PricingCurrencyAmount != null;
    }
}
