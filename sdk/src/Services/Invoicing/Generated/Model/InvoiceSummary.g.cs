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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The invoice that the API retrieved.
    /// </summary>
    public partial class InvoiceSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        ///  The Amazon Web Services account ID. 
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property BaseCurrencyAmount. 
        /// <para>
        ///  The summary with the product and service currency. 
        /// </para>
        /// </summary>
        public InvoiceCurrencyAmount BaseCurrencyAmount { get; set; }

        /// <summary>
        /// Checks to see if the BaseCurrencyAmount property is set.
        /// </summary>
        internal bool IsSetBaseCurrencyAmount() => this.BaseCurrencyAmount != null;

        /// <summary>
        /// Gets and sets the property BillSourceAccounts. 
        /// <para>
        ///  The list of Amazon Web Services account IDs that are the bill source of the invoice.
        /// Currently, only a single bill source account is returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BillSourceAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BillSourceAccounts property is set.
        /// </summary>
        internal bool IsSetBillSourceAccounts() => this.BillSourceAccounts != null && (this.BillSourceAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillSourceAccountsTotalCount. 
        /// <para>
        ///  The total number of accounts that are the bill source of the invoice. 
        /// </para>
        /// </summary>
        public int? BillSourceAccountsTotalCount { get; set; }

        /// <summary>
        /// Checks to see if the BillSourceAccountsTotalCount property is set.
        /// </summary>
        internal bool IsSetBillSourceAccountsTotalCount() => this.BillSourceAccountsTotalCount.HasValue;

        /// <summary>
        /// Gets and sets the property BillType. 
        /// <para>
        ///  The type of the bill. 
        /// </para>
        /// </summary>
        public BillType BillType { get; set; }

        /// <summary>
        /// Checks to see if the BillType property is set.
        /// </summary>
        internal bool IsSetBillType() => this.BillType != null;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The billing period of the invoice-related document. 
        /// </para>
        /// </summary>
        public BillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property CommercialInvoiceId. 
        /// <para>
        ///  The commercial invoice ID. This is only applicable for tax invoices and identifies
        /// the associated commercial invoice. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CommercialInvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the CommercialInvoiceId property is set.
        /// </summary>
        internal bool IsSetCommercialInvoiceId() => this.CommercialInvoiceId != null;

        /// <summary>
        /// Gets and sets the property DueDate. 
        /// <para>
        ///  The invoice due date. 
        /// </para>
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Checks to see if the DueDate property is set.
        /// </summary>
        internal bool IsSetDueDate() => this.DueDate.HasValue;

        /// <summary>
        /// Gets and sets the property EinvoiceDeliveryStatus. 
        /// <para>
        ///  The e-invoice delivery status. 
        /// </para>
        /// </summary>
        public EinvoiceDeliveryStatus EinvoiceDeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the EinvoiceDeliveryStatus property is set.
        /// </summary>
        internal bool IsSetEinvoiceDeliveryStatus() => this.EinvoiceDeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property Entity. 
        /// <para>
        /// The organization name providing Amazon Web Services services.
        /// </para>
        /// </summary>
        public Entity Entity { get; set; }

        /// <summary>
        /// Checks to see if the Entity property is set.
        /// </summary>
        internal bool IsSetEntity() => this.Entity != null;

        /// <summary>
        /// Gets and sets the property InvoiceFrequency. 
        /// <para>
        ///  The frequency of the invoice. 
        /// </para>
        /// </summary>
        public InvoiceFrequency InvoiceFrequency { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceFrequency property is set.
        /// </summary>
        internal bool IsSetInvoiceFrequency() => this.InvoiceFrequency != null;

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        ///  The invoice ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceId property is set.
        /// </summary>
        internal bool IsSetInvoiceId() => this.InvoiceId != null;

        /// <summary>
        /// Gets and sets the property InvoiceType. 
        /// <para>
        ///  The type of invoice. 
        /// </para>
        /// </summary>
        public InvoiceType InvoiceType { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceType property is set.
        /// </summary>
        internal bool IsSetInvoiceType() => this.InvoiceType != null;

        /// <summary>
        /// Gets and sets the property IssuedDate. 
        /// <para>
        ///  The issued date of the invoice. 
        /// </para>
        /// </summary>
        public DateTime? IssuedDate { get; set; }

        /// <summary>
        /// Checks to see if the IssuedDate property is set.
        /// </summary>
        internal bool IsSetIssuedDate() => this.IssuedDate.HasValue;

        /// <summary>
        /// Gets and sets the property OriginalInvoiceId. 
        /// <para>
        /// The initial or original invoice ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OriginalInvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the OriginalInvoiceId property is set.
        /// </summary>
        internal bool IsSetOriginalInvoiceId() => this.OriginalInvoiceId != null;

        /// <summary>
        /// Gets and sets the property PaymentCurrencyAmount. 
        /// <para>
        ///  The summary with the customer configured currency. 
        /// </para>
        /// </summary>
        public InvoiceCurrencyAmount PaymentCurrencyAmount { get; set; }

        /// <summary>
        /// Checks to see if the PaymentCurrencyAmount property is set.
        /// </summary>
        internal bool IsSetPaymentCurrencyAmount() => this.PaymentCurrencyAmount != null;

        /// <summary>
        /// Gets and sets the property PurchaseOrderNumber. 
        /// <para>
        ///  The purchase order number associated to the invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseOrderNumber property is set.
        /// </summary>
        internal bool IsSetPurchaseOrderNumber() => this.PurchaseOrderNumber != null;

        /// <summary>
        /// Gets and sets the property ReceiverRole. 
        /// <para>
        /// The role of the invoice receiver.
        /// </para>
        /// </summary>
        public ReceiverRole ReceiverRole { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverRole property is set.
        /// </summary>
        internal bool IsSetReceiverRole() => this.ReceiverRole != null;

        /// <summary>
        /// Gets and sets the property TaxAuthorityStatus. 
        /// <para>
        ///  The current status of an invoice as reported to the tax authority. This captures
        /// scenarios where an invoice may be cancelled after issuance. 
        /// </para>
        /// </summary>
        public TaxAuthorityStatus TaxAuthorityStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaxAuthorityStatus property is set.
        /// </summary>
        internal bool IsSetTaxAuthorityStatus() => this.TaxAuthorityStatus != null;

        /// <summary>
        /// Gets and sets the property TaxCurrencyAmount. 
        /// <para>
        ///  The summary with the tax currency. 
        /// </para>
        /// </summary>
        public InvoiceCurrencyAmount TaxCurrencyAmount { get; set; }

        /// <summary>
        /// Checks to see if the TaxCurrencyAmount property is set.
        /// </summary>
        internal bool IsSetTaxCurrencyAmount() => this.TaxCurrencyAmount != null;
    }
}
