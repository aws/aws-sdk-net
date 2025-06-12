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
    /// Container for the parameters to the BatchDeleteDocument operation.
    /// Removes one or more documents from an index. The documents must have been added with
    /// the <c>BatchPutDocument</c> API.
    /// 
    ///  
    /// <para>
    /// The documents are deleted asynchronously. You can see the progress of the deletion
    /// by using Amazon Web Services CloudWatch. Any error messages related to the processing
    /// of the batch are sent to your Amazon Web Services CloudWatch log. You can also use
    /// the <c>BatchGetDocumentStatus</c> API to monitor the progress of deleting your documents.
    /// </para>
    ///  
    /// <para>
    /// Deleting documents from an index using <c>BatchDeleteDocument</c> could take up to
    /// an hour or more, depending on the number of documents you want to delete.
    /// </para>
    /// </summary>
    public partial class BatchDeleteDocumentRequest : AmazonKendraRequest
    {
        private DataSourceSyncJobMetricTarget _dataSourceSyncJobMetricTarget;
        private List<string> _documentIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property DataSourceSyncJobMetricTarget.
        /// </summary>
        public DataSourceSyncJobMetricTarget DataSourceSyncJobMetricTarget
        {
            get { return this._dataSourceSyncJobMetricTarget; }
            set { this._dataSourceSyncJobMetricTarget = value; }
        }

        // Check to see if DataSourceSyncJobMetricTarget property is set
        internal bool IsSetDataSourceSyncJobMetricTarget()
        {
            return this._dataSourceSyncJobMetricTarget != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentIdList. 
        /// <para>
        /// One or more identifiers for documents to delete from the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._documentIdList != null && (this._documentIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
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