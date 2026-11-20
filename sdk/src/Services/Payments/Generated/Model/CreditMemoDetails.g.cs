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
    /// The details of a credit memo: the invoice ID that Amazon Web Services Invoicing issued
    /// for it and the billing period that it applies to.
    /// </summary>
    public partial class CreditMemoDetails
    {
        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        /// The billing period the credit memo applies to: the period of the usage it credits.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        /// The invoice ID that Amazon Web Services Invoicing issued for the credit memo: the
        /// document number printed on it, shown in the Amazon Web Services Billing and Cost Management
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
    }
}
