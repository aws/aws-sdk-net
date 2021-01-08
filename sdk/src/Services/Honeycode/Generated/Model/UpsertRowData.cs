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
    /// Data needed to upsert rows in a table as part of a single item in the BatchUpsertTableRows
    /// request.
    /// </summary>
    public partial class UpsertRowData
    {
        private string _batchItemId;
        private Dictionary<string, CellInput> _cellsToUpdate = new Dictionary<string, CellInput>();
        private Filter _filter;

        /// <summary>
        /// Gets and sets the property BatchItemId. 
        /// <para>
        ///  An external identifier that represents a single item in the request that is being
        /// upserted as part of the BatchUpsertTableRows request. This can be any string that
        /// you can use to identify the item in the request. The BatchUpsertTableRows API puts
        /// the batch item id in the results to allow you to link data in the request to data
        /// in the results. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string BatchItemId
        {
            get { return this._batchItemId; }
            set { this._batchItemId = value; }
        }

        // Check to see if BatchItemId property is set
        internal bool IsSetBatchItemId()
        {
            return this._batchItemId != null;
        }

        /// <summary>
        /// Gets and sets the property CellsToUpdate. 
        /// <para>
        ///  A map representing the cells to update for the matching rows or an appended row.
        /// The key is the column id of the cell and the value is the CellInput object that represents
        /// the data to set in that cell. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public Dictionary<string, CellInput> CellsToUpdate
        {
            get { return this._cellsToUpdate; }
            set { this._cellsToUpdate = value; }
        }

        // Check to see if CellsToUpdate property is set
        internal bool IsSetCellsToUpdate()
        {
            return this._cellsToUpdate != null && this._cellsToUpdate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        ///  The filter formula to use to find existing matching rows to update. The formula needs
        /// to return zero or more rows. If the formula returns 0 rows, then a new row will be
        /// appended in the target table. If the formula returns one or more rows, then the returned
        /// rows will be updated. 
        /// </para>
        ///  
        /// <para>
        ///  Note that the filter formula needs to return rows from the target table for the upsert
        /// operation to succeed. If the filter formula has a syntax error or it doesn't evaluate
        /// to zero or more rows in the target table for any one item in the input list, then
        /// the entire BatchUpsertTableRows request fails and no updates are made to the table.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Filter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

    }
}