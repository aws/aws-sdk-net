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
    /// Container for the parameters to the GetInvoicePDF operation.
    /// Returns a URL to download the invoice document and supplemental documents associated
    /// with an invoice. The URLs are pre-signed and have expiration time. For special cases
    /// like Brazil, where Amazon Web Services generated invoice identifiers and government
    /// provided identifiers do not match, use the Amazon Web Services generated invoice identifier
    /// when making API requests. To grant IAM permission to use this operation, the caller
    /// needs the <c>invoicing:GetInvoicePDF</c> policy action.
    /// </summary>
    public partial class GetInvoicePDFRequest : AmazonInvoicingRequest
    {
        private string _invoiceId;

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        ///  Your unique invoice ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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

    }
}