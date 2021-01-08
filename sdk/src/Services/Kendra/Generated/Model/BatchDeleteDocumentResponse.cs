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
    /// This is the response object from the BatchDeleteDocument operation.
    /// </summary>
    public partial class BatchDeleteDocumentResponse : AmazonWebServiceResponse
    {
        private List<BatchDeleteDocumentResponseFailedDocument> _failedDocuments = new List<BatchDeleteDocumentResponseFailedDocument>();

        /// <summary>
        /// Gets and sets the property FailedDocuments. 
        /// <para>
        /// A list of documents that could not be removed from the index. Each entry contains
        /// an error message that indicates why the document couldn't be removed from the index.
        /// </para>
        /// </summary>
        public List<BatchDeleteDocumentResponseFailedDocument> FailedDocuments
        {
            get { return this._failedDocuments; }
            set { this._failedDocuments = value; }
        }

        // Check to see if FailedDocuments property is set
        internal bool IsSetFailedDocuments()
        {
            return this._failedDocuments != null && this._failedDocuments.Count > 0; 
        }

    }
}