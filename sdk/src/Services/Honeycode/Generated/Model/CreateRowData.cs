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
    /// Data needed to create a single row in a table as part of the BatchCreateTableRows
    /// request.
    /// </summary>
    public partial class CreateRowData
    {
        private string _batchItemId;
        private Dictionary<string, CellInput> _cellsToCreate = new Dictionary<string, CellInput>();

        /// <summary>
        /// Gets and sets the property BatchItemId. 
        /// <para>
        ///  An external identifier that represents the single row that is being created as part
        /// of the BatchCreateTableRows request. This can be any string that you can use to identify
        /// the row in the request. The BatchCreateTableRows API puts the batch item id in the
        /// results to allow you to link data in the request to data in the results. 
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
        /// Gets and sets the property CellsToCreate. 
        /// <para>
        ///  A map representing the cells to create in the new row. The key is the column id of
        /// the cell and the value is the CellInput object that represents the data to set in
        /// that cell. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public Dictionary<string, CellInput> CellsToCreate
        {
            get { return this._cellsToCreate; }
            set { this._cellsToCreate = value; }
        }

        // Check to see if CellsToCreate property is set
        internal bool IsSetCellsToCreate()
        {
            return this._cellsToCreate != null && this._cellsToCreate.Count > 0; 
        }

    }
}