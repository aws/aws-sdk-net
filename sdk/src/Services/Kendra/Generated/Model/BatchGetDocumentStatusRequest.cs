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
    /// Container for the parameters to the BatchGetDocumentStatus operation.
    /// Returns the indexing status for one or more documents submitted with the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchPutDocument.html">
    /// BatchPutDocument</a> API.
    /// 
    ///  
    /// <para>
    /// When you use the <c>BatchPutDocument</c> API, documents are indexed asynchronously.
    /// You can use the <c>BatchGetDocumentStatus</c> API to get the current status of a list
    /// of documents so that you can determine if they have been successfully indexed.
    /// </para>
    ///  
    /// <para>
    /// You can also use the <c>BatchGetDocumentStatus</c> API to check the status of the
    /// <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchDeleteDocument.html">
    /// BatchDeleteDocument</a> API. When a document is deleted from the index, Amazon Kendra
    /// returns <c>NOT_FOUND</c> as the status.
    /// </para>
    /// </summary>
    public partial class BatchGetDocumentStatusRequest : AmazonKendraRequest
    {
        private List<DocumentInfo> _documentInfoList = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property DocumentInfoList. 
        /// <para>
        /// A list of <c>DocumentInfo</c> objects that identify the documents for which to get
        /// the status. You identify the documents by their document ID and optional attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<DocumentInfo> DocumentInfoList
        {
            get { return this._documentInfoList; }
            set { this._documentInfoList = value; }
        }

        // Check to see if DocumentInfoList property is set
        internal bool IsSetDocumentInfoList()
        {
            return this._documentInfoList != null && (this._documentInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index to add documents to. The index ID is returned by the <a
        /// href="https://docs.aws.amazon.com/kendra/latest/dg/API_CreateIndex.html">CreateIndex
        /// </a> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}