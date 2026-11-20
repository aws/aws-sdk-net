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
    /// Container for the parameters to the GetFinancialRecord operation. Retrieves a single
    /// financial record, including the details that are specific to its type. Specify exactly
    /// one of the following: <ul> <li> <para> The ID that Amazon Web Services Payments issued
    /// for the record, in <c>identifier</c>. </para> </li> <li> <para> The invoice ID that
    /// Amazon Web Services Invoicing issued for an invoice or a credit memo, in <c>invoiceIdentifier</c>.
    /// </para> </li> </ul> <para> If you specify both or neither, the request fails with
    /// <c>ValidationException</c>. If no record on your account matches, the request fails
    /// with <c>ResourceNotFoundException</c>. </para> <para> This operation provides strongly
    /// consistent reads. </para> <para> To use this operation, you must have Amazon Web Services
    /// Identity and Access Management (IAM) permission for both <c>payments:GetFinancialRecord</c>
    /// and <c>payments:GetPaymentStatus</c>. </para>
    /// </summary>
    public partial class GetFinancialRecordRequest : AmazonPaymentsRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID that Amazon Web Services Payments issued for the financial record, as returned
        /// in <c>id</c>.
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
        /// memo. The operation returns the record that has this invoice ID.
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
