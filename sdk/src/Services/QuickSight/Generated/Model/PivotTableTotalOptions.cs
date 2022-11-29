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
    /// The total options for a pivot table visual.
    /// </summary>
    public partial class PivotTableTotalOptions
    {
        private SubtotalOptions _columnSubtotalOptions;
        private PivotTotalOptions _columnTotalOptions;
        private SubtotalOptions _rowSubtotalOptions;
        private PivotTotalOptions _rowTotalOptions;

        /// <summary>
        /// Gets and sets the property ColumnSubtotalOptions. 
        /// <para>
        /// The column subtotal options.
        /// </para>
        /// </summary>
        public SubtotalOptions ColumnSubtotalOptions
        {
            get { return this._columnSubtotalOptions; }
            set { this._columnSubtotalOptions = value; }
        }

        // Check to see if ColumnSubtotalOptions property is set
        internal bool IsSetColumnSubtotalOptions()
        {
            return this._columnSubtotalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnTotalOptions. 
        /// <para>
        /// The column total options.
        /// </para>
        /// </summary>
        public PivotTotalOptions ColumnTotalOptions
        {
            get { return this._columnTotalOptions; }
            set { this._columnTotalOptions = value; }
        }

        // Check to see if ColumnTotalOptions property is set
        internal bool IsSetColumnTotalOptions()
        {
            return this._columnTotalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RowSubtotalOptions. 
        /// <para>
        /// The row subtotal options.
        /// </para>
        /// </summary>
        public SubtotalOptions RowSubtotalOptions
        {
            get { return this._rowSubtotalOptions; }
            set { this._rowSubtotalOptions = value; }
        }

        // Check to see if RowSubtotalOptions property is set
        internal bool IsSetRowSubtotalOptions()
        {
            return this._rowSubtotalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RowTotalOptions. 
        /// <para>
        /// The row total options.
        /// </para>
        /// </summary>
        public PivotTotalOptions RowTotalOptions
        {
            get { return this._rowTotalOptions; }
            set { this._rowTotalOptions = value; }
        }

        // Check to see if RowTotalOptions property is set
        internal bool IsSetRowTotalOptions()
        {
            return this._rowTotalOptions != null;
        }

    }
}