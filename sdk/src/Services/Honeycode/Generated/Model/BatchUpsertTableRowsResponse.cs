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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// This is the response object from the BatchUpsertTableRows operation.
    /// </summary>
    public partial class BatchUpsertTableRowsResponse : AmazonWebServiceResponse
    {
        private List<FailedBatchItem> _failedBatchItems = new List<FailedBatchItem>();
        private Dictionary<string, UpsertRowsResult> _rows = new Dictionary<string, UpsertRowsResult>();
        private long? _workbookCursor;

        /// <summary>
        /// Gets and sets the property FailedBatchItems. 
        /// <para>
        ///  The list of batch items in the request that could not be updated or appended in the
        /// table. Each element in this list contains one item from the request that could not
        /// be updated in the table along with the reason why that item could not be updated or
        /// appended. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<FailedBatchItem> FailedBatchItems
        {
            get { return this._failedBatchItems; }
            set { this._failedBatchItems = value; }
        }

        // Check to see if FailedBatchItems property is set
        internal bool IsSetFailedBatchItems()
        {
            return this._failedBatchItems != null && this._failedBatchItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Rows. 
        /// <para>
        ///  A map with the batch item id as the key and the result of the upsert operation as
        /// the value. The result of the upsert operation specifies whether existing rows were
        /// updated or a new row was appended, along with the list of row ids that were affected.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, UpsertRowsResult> Rows
        {
            get { return this._rows; }
            set { this._rows = value; }
        }

        // Check to see if Rows property is set
        internal bool IsSetRows()
        {
            return this._rows != null && this._rows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkbookCursor. 
        /// <para>
        /// The updated workbook cursor after updating or appending rows in the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long WorkbookCursor
        {
            get { return this._workbookCursor.GetValueOrDefault(); }
            set { this._workbookCursor = value; }
        }

        // Check to see if WorkbookCursor property is set
        internal bool IsSetWorkbookCursor()
        {
            return this._workbookCursor.HasValue; 
        }

    }
}