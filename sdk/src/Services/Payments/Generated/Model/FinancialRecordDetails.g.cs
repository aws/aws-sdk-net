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
    /// The attributes that exist only for one type of financial record. The populated member
    /// matches the record's <c>type</c>.
    /// </summary>
    public partial class FinancialRecordDetails
    {
        /// <summary>
        /// Gets and sets the property CreditMemoDetails. 
        /// <para>
        /// The details of a credit memo. Populated when <c>type</c> is <c>CREDIT_MEMO</c>.
        /// </para>
        /// </summary>
        public CreditMemoDetails CreditMemoDetails { get; set; }

        /// <summary>
        /// Checks to see if the CreditMemoDetails property is set.
        /// </summary>
        internal bool IsSetCreditMemoDetails() => this.CreditMemoDetails != null;

        /// <summary>
        /// Gets and sets the property InvoiceDetails. 
        /// <para>
        /// The details of an invoice. Populated when <c>type</c> is <c>INVOICE</c>.
        /// </para>
        /// </summary>
        public InvoiceDetails InvoiceDetails { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceDetails property is set.
        /// </summary>
        internal bool IsSetInvoiceDetails() => this.InvoiceDetails != null;
    }
}
