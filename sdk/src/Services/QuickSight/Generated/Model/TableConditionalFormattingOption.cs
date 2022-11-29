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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Conditional formatting options for a <code>PivotTableVisual</code>.
    /// </summary>
    public partial class TableConditionalFormattingOption
    {
        private TableCellConditionalFormatting _cell;
        private TableRowConditionalFormatting _row;

        /// <summary>
        /// Gets and sets the property Cell. 
        /// <para>
        /// The cell conditional formatting option for a table.
        /// </para>
        /// </summary>
        public TableCellConditionalFormatting Cell
        {
            get { return this._cell; }
            set { this._cell = value; }
        }

        // Check to see if Cell property is set
        internal bool IsSetCell()
        {
            return this._cell != null;
        }

        /// <summary>
        /// Gets and sets the property Row. 
        /// <para>
        /// The row conditional formatting option for a table.
        /// </para>
        /// </summary>
        public TableRowConditionalFormatting Row
        {
            get { return this._row; }
            set { this._row = value; }
        }

        // Check to see if Row property is set
        internal bool IsSetRow()
        {
            return this._row != null;
        }

    }
}