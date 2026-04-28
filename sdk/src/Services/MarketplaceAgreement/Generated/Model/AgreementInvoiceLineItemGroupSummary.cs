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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
        private string _agreementId;
        private InvoiceBillingPeriod _invoiceBillingPeriod;
        private string _invoiceId;
        private InvoiceType _invoiceType;
        private InvoicingEntity _invoicingEntity;
        private DateTime? _issuedTime;
        private PricingCurrencyAmount _pricingCurrencyAmount;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceBillingPeriod. 
        /// <para>
        /// The billing period associated with this group.
        /// </para>
        /// </summary>
        public InvoiceBillingPeriod InvoiceBillingPeriod
        {
            get { return this._invoiceBillingPeriod; }
            set { this._invoiceBillingPeriod = value; }
        }

        // Check to see if InvoiceBillingPeriod property is set
        internal bool IsSetInvoiceBillingPeriod()
        {
            return this._invoiceBillingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// The identifier of the invoice for this group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string InvoiceId
        {
            get { return this._invoiceId; }
            set { this._invoiceId = value; }
        }

        // Check to see if InvoiceId property is set
        internal bool IsSetInvoiceId()
        {
            return this._invoiceId != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceType. 
        /// <para>
        /// The type of invoice. Valid values are <c>INVOICE</c> and <c>CREDIT_MEMO</c>.
        /// </para>
        /// </summary>
        public InvoiceType InvoiceType
        {
            get { return this._invoiceType; }
            set { this._invoiceType = value; }
        }

        // Check to see if InvoiceType property is set
        internal bool IsSetInvoiceType()
        {
            return this._invoiceType != null;
        }

        /// <summary>
        /// Gets and sets the property InvoicingEntity. 
        /// <para>
        /// The entity that issues the invoice.
        /// </para>
        /// </summary>
        public InvoicingEntity InvoicingEntity
        {
            get { return this._invoicingEntity; }
            set { this._invoicingEntity = value; }
        }

        // Check to see if InvoicingEntity property is set
        internal bool IsSetInvoicingEntity()
        {
            return this._invoicingEntity != null;
        }

        /// <summary>
        /// Gets and sets the property IssuedTime. 
        /// <para>
        /// The timestamp when the invoice containing this group was created.
        /// </para>
        /// </summary>
        public DateTime? IssuedTime
        {
            get { return this._issuedTime; }
            set { this._issuedTime = value; }
        }

        // Check to see if IssuedTime property is set
        internal bool IsSetIssuedTime()
        {
            return this._issuedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PricingCurrencyAmount. 
        /// <para>
        /// Monetary amounts for this invoice group.
        /// </para>
        /// </summary>
        public PricingCurrencyAmount PricingCurrencyAmount
        {
            get { return this._pricingCurrencyAmount; }
            set { this._pricingCurrencyAmount = value; }
        }

        // Check to see if PricingCurrencyAmount property is set
        internal bool IsSetPricingCurrencyAmount()
        {
            return this._pricingCurrencyAmount != null;
        }

    }
}