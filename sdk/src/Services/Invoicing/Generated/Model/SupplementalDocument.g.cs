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
    /// Supplemental document associated with the invoice.
    /// </summary>
    public partial class SupplementalDocument
    {
        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The ID of the supplemental document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Checks to see if the DocumentId property is set.
        /// </summary>
        internal bool IsSetDocumentId() => this.DocumentId != null;

        /// <summary>
        /// Gets and sets the property DocumentType. 
        /// <para>
        /// The type of supplemental document.
        /// </para>
        /// </summary>
        public SupplementalDocumentType DocumentType { get; set; }

        /// <summary>
        /// Checks to see if the DocumentType property is set.
        /// </summary>
        internal bool IsSetDocumentType() => this.DocumentType != null;

        /// <summary>
        /// Gets and sets the property DocumentUrl. 
        /// <para>
        /// The pre-signed URL to download invoice supplemental document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DocumentUrl { get; set; }

        /// <summary>
        /// Checks to see if the DocumentUrl property is set.
        /// </summary>
        internal bool IsSetDocumentUrl() => this.DocumentUrl != null;

        /// <summary>
        /// Gets and sets the property DocumentUrlExpirationDate. 
        /// <para>
        /// The pre-signed URL expiration date of invoice supplemental document.
        /// </para>
        /// </summary>
        public DateTime? DocumentUrlExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the DocumentUrlExpirationDate property is set.
        /// </summary>
        internal bool IsSetDocumentUrlExpirationDate() => this.DocumentUrlExpirationDate.HasValue;
    }
}
