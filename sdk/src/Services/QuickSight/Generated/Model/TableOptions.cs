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
    /// The table options for a table visual.
    /// </summary>
    public partial class TableOptions
    {
        private TableCellStyle _cellStyle;
        private TableCellStyle _headerStyle;
        private TableOrientation _orientation;
        private RowAlternateColorOptions _rowAlternateColorOptions;

        /// <summary>
        /// Gets and sets the property CellStyle. 
        /// <para>
        /// The table cell style of table cells.
        /// </para>
        /// </summary>
        public TableCellStyle CellStyle
        {
            get { return this._cellStyle; }
            set { this._cellStyle = value; }
        }

        // Check to see if CellStyle property is set
        internal bool IsSetCellStyle()
        {
            return this._cellStyle != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderStyle. 
        /// <para>
        /// The table cell style of a table header.
        /// </para>
        /// </summary>
        public TableCellStyle HeaderStyle
        {
            get { return this._headerStyle; }
            set { this._headerStyle = value; }
        }

        // Check to see if HeaderStyle property is set
        internal bool IsSetHeaderStyle()
        {
            return this._headerStyle != null;
        }

        /// <summary>
        /// Gets and sets the property Orientation. 
        /// <para>
        /// The orientation (vertical, horizontal) for a table.
        /// </para>
        /// </summary>
        public TableOrientation Orientation
        {
            get { return this._orientation; }
            set { this._orientation = value; }
        }

        // Check to see if Orientation property is set
        internal bool IsSetOrientation()
        {
            return this._orientation != null;
        }

        /// <summary>
        /// Gets and sets the property RowAlternateColorOptions. 
        /// <para>
        /// The row alternate color options (widget status, row alternate colors) for a table.
        /// </para>
        /// </summary>
        public RowAlternateColorOptions RowAlternateColorOptions
        {
            get { return this._rowAlternateColorOptions; }
            set { this._rowAlternateColorOptions = value; }
        }

        // Check to see if RowAlternateColorOptions property is set
        internal bool IsSetRowAlternateColorOptions()
        {
            return this._rowAlternateColorOptions != null;
        }

    }
}