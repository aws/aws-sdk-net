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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The invoice that the API retrieved.
    /// </summary>
    public partial class InvoiceSummary
    {
        private string _accountId;
        private InvoiceCurrencyAmount _baseCurrencyAmount;
        private BillingPeriod _billingPeriod;
        private DateTime? _dueDate;
        private Entity _entity;
        private string _invoiceId;
        private InvoiceType _invoiceType;
        private DateTime? _issuedDate;
        private string _originalInvoiceId;
        private InvoiceCurrencyAmount _paymentCurrencyAmount;
        private string _purchaseOrderNumber;
        private InvoiceCurrencyAmount _taxCurrencyAmount;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID. 
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property BaseCurrencyAmount. 
        /// <para>
        ///  The summary with the product and service currency. 
        /// </para>
        /// </summary>
        public InvoiceCurrencyAmount BaseCurrencyAmount
        {
            get { return this._baseCurrencyAmount; }
            set { this._baseCurrencyAmount = value; }
        }

        // Check to see if BaseCurrencyAmount property is set
        internal bool IsSetBaseCurrencyAmount()
        {
            return this._baseCurrencyAmount != null;
        }

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The billing period of the invoice-related document. 
        /// </para>
        /// </summary>
        public BillingPeriod BillingPeriod
        {
            get { return this._billingPeriod; }
            set { this._billingPeriod = value; }
        }

        // Check to see if BillingPeriod property is set
        internal bool IsSetBillingPeriod()
        {
            return this._billingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property DueDate. 
        /// <para>
        ///  The invoice due date. 
        /// </para>
        /// </summary>
        public DateTime? DueDate
        {
            get { return this._dueDate; }
            set { this._dueDate = value; }
        }

        // Check to see if DueDate property is set
        internal bool IsSetDueDate()
        {
            return this._dueDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The organization name providing Amazon Web Services services.
        /// </para>
        /// </summary>
        public Entity Entity
        {
            get { return this._entity; }
            set { this._entity = value; }
        }

        // Check to see if Entity property is set
        internal bool IsSetEntity()
        {
            return this._entity != null;
        }

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        ///  The invoice ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        ///  The type of invoice. 
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
        /// Gets and sets the property IssuedDate. 
        /// <para>
        ///  The issued date of the invoice. 
        /// </para>
        /// </summary>
        public DateTime? IssuedDate
        {
            get { return this._issuedDate; }
            set { this._issuedDate = value; }
        }

        // Check to see if IssuedDate property is set
        internal bool IsSetIssuedDate()
        {
            return this._issuedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalInvoiceId. 
        /// <para>
        /// The initial or original invoice ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string OriginalInvoiceId
        {
            get { return this._originalInvoiceId; }
            set { this._originalInvoiceId = value; }
        }

        // Check to see if OriginalInvoiceId property is set
        internal bool IsSetOriginalInvoiceId()
        {
            return this._originalInvoiceId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentCurrencyAmount. 
        /// <para>
        ///  The summary with the customer configured currency. 
        /// </para>
        /// </summary>
        public InvoiceCurrencyAmount PaymentCurrencyAmount
        {
            get { return this._paymentCurrencyAmount; }
            set { this._paymentCurrencyAmount = value; }
        }

        // Check to see if PaymentCurrencyAmount property is set
        internal bool IsSetPaymentCurrencyAmount()
        {
            return this._paymentCurrencyAmount != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseOrderNumber. 
        /// <para>
        ///  The purchase order number associated to the invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string PurchaseOrderNumber
        {
            get { return this._purchaseOrderNumber; }
            set { this._purchaseOrderNumber = value; }
        }

        // Check to see if PurchaseOrderNumber property is set
        internal bool IsSetPurchaseOrderNumber()
        {
            return this._purchaseOrderNumber != null;
        }

        /// <summary>
        /// Gets and sets the property TaxCurrencyAmount. 
        /// <para>
        ///  The summary with the tax currency. 
        /// </para>
        /// </summary>
        public InvoiceCurrencyAmount TaxCurrencyAmount
        {
            get { return this._taxCurrencyAmount; }
            set { this._taxCurrencyAmount = value; }
        }

        // Check to see if TaxCurrencyAmount property is set
        internal bool IsSetTaxCurrencyAmount()
        {
            return this._taxCurrencyAmount != null;
        }

    }
}