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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// This is the response object from the BatchPutDocument operation.
    /// </summary>
    public partial class BatchPutDocumentResponse : AmazonWebServiceResponse
    {
        private List<BatchPutDocumentResponseFailedDocument> _failedDocuments = AWSConfigs.InitializeCollections ? new List<BatchPutDocumentResponseFailedDocument>() : null;

        /// <summary>
        /// Gets and sets the property FailedDocuments. 
        /// <para>
        /// A list of documents that were not added to the index because the document failed a
        /// validation check. Each document contains an error message that indicates why the document
        /// couldn't be added to the index.
        /// </para>
        ///  
        /// <para>
        /// If there was an error adding a document to an index the error is reported in your
        /// Amazon Web Services CloudWatch log. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/cloudwatch-logs.html">Monitoring
        /// Amazon Kendra with Amazon CloudWatch logs</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchPutDocumentResponseFailedDocument> FailedDocuments
        {
            get { return this._failedDocuments; }
            set { this._failedDocuments = value; }
        }

        // Check to see if FailedDocuments property is set
        internal bool IsSetFailedDocuments()
        {
            return this._failedDocuments != null && (this._failedDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}