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
    /// Container for the parameters to the BatchUpdateTableRows operation.
    /// The BatchUpdateTableRows API allows you to update one or more rows in a table in
    /// a workbook. 
    /// 
    ///  
    /// <para>
    ///  You can specify the values to set in some or all of the columns in the table for
    /// the specified rows. If a column is not explicitly specified in a particular row, then
    /// that column will not be updated for that row. To clear out the data in a specific
    /// cell, you need to set the value as an empty string (""). 
    /// </para>
    /// </summary>
    public partial class BatchUpdateTableRowsRequest : AmazonHoneycodeRequest
    {
        private string _clientRequestToken;
        private List<UpdateRowData> _rowsToUpdate = new List<UpdateRowData>();
        private string _tableId;
        private string _workbookId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  The request token for performing the update action. Request tokens help to identify
        /// duplicate requests. If a call times out or fails due to a transient error like a failed
        /// network connection, you can retry the call with the same request token. The service
        /// ensures that if the first call using that request token is successfully performed,
        /// the second call will not perform the action again. 
        /// </para>
        ///  
        /// <para>
        ///  Note that request tokens are valid only for a few minutes. You cannot use request
        /// tokens to dedupe requests spanning hours or days. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property RowsToUpdate. 
        /// <para>
        ///  The list of rows to update in the table. Each item in this list needs to contain
        /// the row id to update along with the map of column id to cell values for each column
        /// in that row that needs to be updated. You need to specify at least one row in this
        /// list, and for each row, you need to specify at least one column to update. 
        /// </para>
        ///  
        /// <para>
        ///  Note that if one of the row or column ids in the request does not exist in the table,
        /// then the request fails and no updates are made to the table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<UpdateRowData> RowsToUpdate
        {
            get { return this._rowsToUpdate; }
            set { this._rowsToUpdate = value; }
        }

        // Check to see if RowsToUpdate property is set
        internal bool IsSetRowsToUpdate()
        {
            return this._rowsToUpdate != null && this._rowsToUpdate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// The ID of the table where the rows are being updated.
        /// </para>
        ///  
        /// <para>
        ///  If a table with the specified id could not be found, this API throws ResourceNotFoundException.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TableId
        {
            get { return this._tableId; }
            set { this._tableId = value; }
        }

        // Check to see if TableId property is set
        internal bool IsSetTableId()
        {
            return this._tableId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkbookId. 
        /// <para>
        /// The ID of the workbook where the rows are being updated.
        /// </para>
        ///  
        /// <para>
        ///  If a workbook with the specified id could not be found, this API throws ResourceNotFoundException.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WorkbookId
        {
            get { return this._workbookId; }
            set { this._workbookId = value; }
        }

        // Check to see if WorkbookId property is set
        internal bool IsSetWorkbookId()
        {
            return this._workbookId != null;
        }

    }
}