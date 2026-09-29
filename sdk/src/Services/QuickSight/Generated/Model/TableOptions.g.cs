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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The table options for a table visual.
    /// </summary>
    public partial class TableOptions
    {
        /// <summary>
        /// Gets and sets the property CellStyle. 
        /// <para>
        /// The table cell style of table cells.
        /// </para>
        /// </summary>
        public TableCellStyle CellStyle { get; set; }

        /// <summary>
        /// Checks to see if the CellStyle property is set.
        /// </summary>
        internal bool IsSetCellStyle() => this.CellStyle != null;

        /// <summary>
        /// Gets and sets the property HeaderStyle. 
        /// <para>
        /// The table cell style of a table header.
        /// </para>
        /// </summary>
        public TableCellStyle HeaderStyle { get; set; }

        /// <summary>
        /// Checks to see if the HeaderStyle property is set.
        /// </summary>
        internal bool IsSetHeaderStyle() => this.HeaderStyle != null;

        /// <summary>
        /// Gets and sets the property Orientation. 
        /// <para>
        /// The orientation (vertical, horizontal) for a table.
        /// </para>
        /// </summary>
        public TableOrientation Orientation { get; set; }

        /// <summary>
        /// Checks to see if the Orientation property is set.
        /// </summary>
        internal bool IsSetOrientation() => this.Orientation != null;

        /// <summary>
        /// Gets and sets the property RowAlternateColorOptions. 
        /// <para>
        /// The row alternate color options (widget status, row alternate colors) for a table.
        /// </para>
        /// </summary>
        public RowAlternateColorOptions RowAlternateColorOptions { get; set; }

        /// <summary>
        /// Checks to see if the RowAlternateColorOptions property is set.
        /// </summary>
        internal bool IsSetRowAlternateColorOptions() => this.RowAlternateColorOptions != null;
    }
}
