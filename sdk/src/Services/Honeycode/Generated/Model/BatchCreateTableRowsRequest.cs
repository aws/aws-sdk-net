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
    /// Container for the parameters to the BatchCreateTableRows operation.
    /// The BatchCreateTableRows API allows you to create one or more rows at the end of
    /// a table in a workbook. The API allows you to specify the values to set in some or
    /// all of the columns in the new rows. 
    /// 
    ///  
    /// <para>
    ///  If a column is not explicitly set in a specific row, then the column level formula
    /// specified in the table will be applied to the new row. If there is no column level
    /// formula but the last row of the table has a formula, then that formula will be copied
    /// down to the new row. If there is no column level formula and no formula in the last
    /// row of the table, then that column will be left blank for the new rows. 
    /// </para>
    /// </summary>
    public partial class BatchCreateTableRowsRequest : AmazonHoneycodeRequest
    {
        private string _clientRequestToken;
        private List<CreateRowData> _rowsToCreate = new List<CreateRowData>();
        private string _tableId;
        private string _workbookId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  The request token for performing the batch create operation. Request tokens help
        /// to identify duplicate requests. If a call times out or fails due to a transient error
        /// like a failed network connection, you can retry the call with the same request token.
        /// The service ensures that if the first call using that request token is successfully
        /// performed, the second call will not perform the operation again. 
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
        /// Gets and sets the property RowsToCreate. 
        /// <para>
        ///  The list of rows to create at the end of the table. Each item in this list needs
        /// to have a batch item id to uniquely identify the element in the request and the cells
        /// to create for that row. You need to specify at least one item in this list. 
        /// </para>
        ///  
        /// <para>
        ///  Note that if one of the column ids in any of the rows in the request does not exist
        /// in the table, then the request fails and no updates are made to the table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<CreateRowData> RowsToCreate
        {
            get { return this._rowsToCreate; }
            set { this._rowsToCreate = value; }
        }

        // Check to see if RowsToCreate property is set
        internal bool IsSetRowsToCreate()
        {
            return this._rowsToCreate != null && this._rowsToCreate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// The ID of the table where the new rows are being added.
        /// </para>
        ///  
        /// <para>
        ///  If a table with the specified ID could not be found, this API throws ResourceNotFoundException.
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
        /// The ID of the workbook where the new rows are being added.
        /// </para>
        ///  
        /// <para>
        ///  If a workbook with the specified ID could not be found, this API throws ResourceNotFoundException.
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