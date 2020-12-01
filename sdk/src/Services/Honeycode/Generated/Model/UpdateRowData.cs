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
    public partial class UpdateRowData
    {
        private Dictionary<string, CellInput> _cellsToUpdate = new Dictionary<string, CellInput>();
        private string _rowId;

        /// <summary>
        /// Gets and sets the property CellsToUpdate. 
        /// <para>
        ///  A map representing the cells to update in the given row. The key is the column id
        /// of the cell and the value is the CellInput object that represents the data to set
        /// in that cell. 
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
        /// Gets and sets the property RowId. 
        /// <para>
        ///  The id of the row that needs to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=77, Max=77)]
        public string RowId
        {
            get { return this._rowId; }
            set { this._rowId = value; }
        }

        // Check to see if RowId property is set
        internal bool IsSetRowId()
        {
            return this._rowId != null;
        }

    }
}