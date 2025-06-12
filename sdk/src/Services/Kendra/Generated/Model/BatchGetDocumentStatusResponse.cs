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
    /// This is the response object from the BatchGetDocumentStatus operation.
    /// </summary>
    public partial class BatchGetDocumentStatusResponse : AmazonWebServiceResponse
    {
        private List<Status> _documentStatusList = AWSConfigs.InitializeCollections ? new List<Status>() : null;
        private List<BatchGetDocumentStatusResponseError> _errors = AWSConfigs.InitializeCollections ? new List<BatchGetDocumentStatusResponseError>() : null;

        /// <summary>
        /// Gets and sets the property DocumentStatusList. 
        /// <para>
        /// The status of documents. The status indicates if the document is waiting to be indexed,
        /// is in the process of indexing, has completed indexing, or failed indexing. If a document
        /// failed indexing, the status provides the reason why.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Status> DocumentStatusList
        {
            get { return this._documentStatusList; }
            set { this._documentStatusList = value; }
        }

        // Check to see if DocumentStatusList property is set
        internal bool IsSetDocumentStatusList()
        {
            return this._documentStatusList != null && (this._documentStatusList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of documents that Amazon Kendra couldn't get the status for. The list includes
        /// the ID of the document and the reason that the status couldn't be found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BatchGetDocumentStatusResponseError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}