/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteDocument operation.
    /// Removes one or more documents from an index. The documents must have been added with
    /// the <a>BatchPutDocument</a> operation.
    /// 
    ///  
    /// <para>
    /// The documents are deleted asynchronously. You can see the progress of the deletion
    /// by using AWS CloudWatch. Any error messages releated to the processing of the batch
    /// are sent to you CloudWatch log.
    /// </para>
    /// </summary>
    public partial class BatchDeleteDocumentRequest : AmazonKendraRequest
    {
        private List<string> _documentIdList = new List<string>();
        private string _indexId;

        /// <summary>
        /// Gets and sets the property DocumentIdList. 
        /// <para>
        /// One or more identifiers for documents to delete from the index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> DocumentIdList
        {
            get { return this._documentIdList; }
            set { this._documentIdList = value; }
        }

        // Check to see if DocumentIdList property is set
        internal bool IsSetDocumentIdList()
        {
            return this._documentIdList != null && this._documentIdList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index that contains the documents to delete.
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