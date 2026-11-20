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
    /// A way to identify a financial record. Specify exactly one member: the ID that Amazon
    /// Web Services Payments issued, in <c>identifier</c>, or the invoice ID that Amazon
    /// Web Services Invoicing issued, in <c>invoiceIdentifier</c>. If you specify both or
    /// neither, the request fails with <c>ValidationException</c>.
    /// </summary>
    public partial class FinancialRecordKey
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID that Amazon Web Services Payments issued for the record.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 17, Max = 23)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property InvoiceIdentifier. 
        /// <para>
        /// The invoice ID that Amazon Web Services Invoicing issued for an invoice or a credit
        /// memo.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string InvoiceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InvoiceIdentifier property is set.
        /// </summary>
        internal bool IsSetInvoiceIdentifier() => this.InvoiceIdentifier != null;
    }
}
