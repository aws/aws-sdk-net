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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The column option of the transposed table.
    /// </summary>
    public partial class TransposedTableOption
    {
        private int? _columnIndex;
        private TransposedColumnType _columnType;
        private string _columnWidth;

        /// <summary>
        /// Gets and sets the property ColumnIndex. 
        /// <para>
        /// The index of a columns in a transposed table. The index range is 0-9999.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9999)]
        public int? ColumnIndex
        {
            get { return this._columnIndex; }
            set { this._columnIndex = value; }
        }

        // Check to see if ColumnIndex property is set
        internal bool IsSetColumnIndex()
        {
            return this._columnIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ColumnType. 
        /// <para>
        /// The column type of the column in a transposed table. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ROW_HEADER_COLUMN</c>: Refers to the leftmost column of the row header in the
        /// transposed table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VALUE_COLUMN</c>: Refers to all value columns in the transposed table.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransposedColumnType ColumnType
        {
            get { return this._columnType; }
            set { this._columnType = value; }
        }

        // Check to see if ColumnType property is set
        internal bool IsSetColumnType()
        {
            return this._columnType != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnWidth. 
        /// <para>
        /// The width of a column in a transposed table.
        /// </para>
        /// </summary>
        public string ColumnWidth
        {
            get { return this._columnWidth; }
            set { this._columnWidth = value; }
        }

        // Check to see if ColumnWidth property is set
        internal bool IsSetColumnWidth()
        {
            return this._columnWidth != null;
        }

    }
}