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

namespace Amazon.Payments.Model
{
    /// <summary>
    /// The details of an invoice: the invoice ID that Amazon Web Services Invoicing issued,
    /// the billing period that the invoice covers, its due date and due status, its payment
    /// terms, and its frequency.
    /// </summary>
    public partial class InvoiceDetails
    {
        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period the invoice covers: the period of the usage it bills.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property DueDate. 
        /// <para>
        /// The calendar date by which the invoice must be paid, as the timestamp of 00:00:00
        /// UTC on that day. The invoice is past due from the following day.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Checks to see if the DueDate property is set.
        /// </summary>
        internal bool IsSetDueDate() => this.DueDate.HasValue;

        /// <summary>
        /// Gets and sets the property DueStatus. 
        /// <para>
        /// Whether the invoice is due or past its due date. This member is present only while
        /// the invoice's <c>status</c> is <c>OUTSTANDING</c>. It's absent when the <c>status</c>
        /// is <c>PROCESSING</c>, <c>SETTLED</c>, or <c>CANCELED</c>. The following values are
        /// valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DUE</c> – The due date hasn't passed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAST_DUE</c> – The due date has passed, and the invoice is still outstanding.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DueStatus DueStatus { get; set; }

        /// <summary>
        /// Checks to see if the DueStatus property is set.
        /// </summary>
        internal bool IsSetDueStatus() => this.DueStatus != null;

        /// <summary>
        /// Gets and sets the property InvoiceFrequency. 
        /// <para>
        /// Whether the invoice was issued once or as part of a billing cycle. The following values
        /// are valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ONE_TIME</c> – A single invoice that isn't part of a billing cycle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RECURRING</c> – One invoice of a billing cycle, such as your monthly invoice.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public InvoiceFrequency InvoiceFrequency { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceFrequency property is set.
        /// </summary>
        internal bool IsSetInvoiceFrequency() => this.InvoiceFrequency != null;

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// The invoice ID that Amazon Web Services Invoicing issued for the invoice: the document
        /// number printed on it, shown in the Amazon Web Services Billing and Cost Management
        /// console and returned by the Amazon Web Services Invoicing API as <c>InvoiceId</c>.
        /// <c>GetFinancialRecord</c> and <c>BatchGetFinancialRecord</c> also accept it, as <c>invoiceIdentifier</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceId property is set.
        /// </summary>
        internal bool IsSetInvoiceId() => this.InvoiceId != null;

        /// <summary>
        /// Gets and sets the property PaymentTerms. 
        /// <para>
        /// The payment terms for the invoice, as Amazon Web Services Invoicing issued them, such
        /// as <c>Net30</c>. The due date follows from these terms. This member is absent when
        /// Amazon Web Services Invoicing didn't issue payment terms for the invoice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// Checks to see if the PaymentTerms property is set.
        /// </summary>
        internal bool IsSetPaymentTerms() => this.PaymentTerms != null;
    }
}
