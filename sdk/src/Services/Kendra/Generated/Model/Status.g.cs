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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about the status of documents submitted for indexing.
    /// </summary>
    public partial class Status
    {
        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Checks to see if the DocumentId property is set.
        /// </summary>
        internal bool IsSetDocumentId() => this.DocumentId != null;

        /// <summary>
        /// Gets and sets the property DocumentStatus. 
        /// <para>
        /// The current status of a document.
        /// </para>
        ///  
        /// <para>
        /// If the document was submitted for deletion, the status is <c>NOT_FOUND</c> after the
        /// document is deleted.
        /// </para>
        /// </summary>
        public DocumentStatus DocumentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DocumentStatus property is set.
        /// </summary>
        internal bool IsSetDocumentStatus() => this.DocumentStatus != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Indicates the source of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Provides detailed information about why the document couldn't be indexed. Use this
        /// information to correct the error before you resubmit the document for indexing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;
    }
}
