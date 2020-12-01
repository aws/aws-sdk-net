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
    /// An object that contains attributes about a single row in a table
    /// </summary>
    public partial class TableRow
    {
        private List<Cell> _cells = new List<Cell>();
        private string _rowId;

        /// <summary>
        /// Gets and sets the property Cells. 
        /// <para>
        /// A list of cells in the table row. The cells appear in the same order as the columns
        /// of the table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Cell> Cells
        {
            get { return this._cells; }
            set { this._cells = value; }
        }

        // Check to see if Cells property is set
        internal bool IsSetCells()
        {
            return this._cells != null && this._cells.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RowId. 
        /// <para>
        /// The id of the row in the table.
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