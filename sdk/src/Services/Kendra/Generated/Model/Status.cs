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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about the status of documents submitted for indexing.
    /// </summary>
    public partial class Status
    {
        private string _documentId;
        private DocumentStatus _documentStatus;
        private string _failureCode;
        private string _failureReason;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The identifier of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentStatus. 
        /// <para>
        /// The current status of a document.
        /// </para>
        ///  
        /// <para>
        /// If the document was submitted for deletion, the status is <code>NOT_FOUND</code> after
        /// the document is deleted.
        /// </para>
        /// </summary>
        public DocumentStatus DocumentStatus
        {
            get { return this._documentStatus; }
            set { this._documentStatus = value; }
        }

        // Check to see if DocumentStatus property is set
        internal bool IsSetDocumentStatus()
        {
            return this._documentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// Indicates the source of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Provides detailed information about why the document couldn't be indexed. Use this
        /// information to correct the error before you resubmit the document for indexing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

    }
}