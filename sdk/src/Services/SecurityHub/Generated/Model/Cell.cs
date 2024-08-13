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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An occurrence of sensitive data detected in a Microsoft Excel workbook, comma-separated
    /// value (CSV) file, or tab-separated value (TSV) file.
    /// </summary>
    public partial class Cell
    {
        private string _cellReference;
        private long? _column;
        private string _columnName;
        private long? _row;

        /// <summary>
        /// Gets and sets the property CellReference. 
        /// <para>
        /// For a Microsoft Excel workbook, provides the location of the cell, as an absolute
        /// cell reference, that contains the data. For example, Sheet2!C5 for cell C5 on Sheet2.
        /// </para>
        /// </summary>
        public string CellReference
        {
            get { return this._cellReference; }
            set { this._cellReference = value; }
        }

        // Check to see if CellReference property is set
        internal bool IsSetCellReference()
        {
            return this._cellReference != null;
        }

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column number of the column that contains the data. For a Microsoft Excel workbook,
        /// the column number corresponds to the alphabetical column identifiers. For example,
        /// a value of 1 for Column corresponds to the A column in the workbook.
        /// </para>
        /// </summary>
        public long? Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// The name of the column that contains the data.
        /// </para>
        /// </summary>
        public string ColumnName
        {
            get { return this._columnName; }
            set { this._columnName = value; }
        }

        // Check to see if ColumnName property is set
        internal bool IsSetColumnName()
        {
            return this._columnName != null;
        }

        /// <summary>
        /// Gets and sets the property Row. 
        /// <para>
        /// The row number of the row that contains the data.
        /// </para>
        /// </summary>
        public long? Row
        {
            get { return this._row; }
            set { this._row = value; }
        }

        // Check to see if Row property is set
        internal bool IsSetRow()
        {
            return this._row.HasValue; 
        }

    }
}