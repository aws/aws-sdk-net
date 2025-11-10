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
    /// Invoice document data.
    /// </summary>
    public partial class InvoicePDF
    {
        private string _documentUrl;
        private DateTime? _documentUrlExpirationDate;
        private string _invoiceId;
        private List<SupplementalDocument> _supplementalDocuments = AWSConfigs.InitializeCollections ? new List<SupplementalDocument>() : null;

        /// <summary>
        /// Gets and sets the property DocumentUrl. 
        /// <para>
        /// The pre-signed URL to download the invoice document. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DocumentUrl
        {
            get { return this._documentUrl; }
            set { this._documentUrl = value; }
        }

        // Check to see if DocumentUrl property is set
        internal bool IsSetDocumentUrl()
        {
            return this._documentUrl != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentUrlExpirationDate. 
        /// <para>
        /// The pre-signed URL expiration date of the invoice document.
        /// </para>
        /// </summary>
        public DateTime DocumentUrlExpirationDate
        {
            get { return this._documentUrlExpirationDate.GetValueOrDefault(); }
            set { this._documentUrlExpirationDate = value; }
        }

        // Check to see if DocumentUrlExpirationDate property is set
        internal bool IsSetDocumentUrlExpirationDate()
        {
            return this._documentUrlExpirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvoiceId. 
        /// <para>
        ///  Your unique invoice ID. 
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
        /// Gets and sets the property SupplementalDocuments. 
        /// <para>
        /// List of supplemental documents associated with the invoice.
        /// </para>
        /// </summary>
        public List<SupplementalDocument> SupplementalDocuments
        {
            get { return this._supplementalDocuments; }
            set { this._supplementalDocuments = value; }
        }

        // Check to see if SupplementalDocuments property is set
        internal bool IsSetSupplementalDocuments()
        {
            return this._supplementalDocuments != null && (this._supplementalDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}