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
    /// The total options for a pivot table visual.
    /// </summary>
    public partial class PivotTableTotalOptions
    {
        /// <summary>
        /// Gets and sets the property ColumnSubtotalOptions. 
        /// <para>
        /// The column subtotal options.
        /// </para>
        /// </summary>
        public SubtotalOptions ColumnSubtotalOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColumnSubtotalOptions property is set.
        /// </summary>
        internal bool IsSetColumnSubtotalOptions() => this.ColumnSubtotalOptions != null;

        /// <summary>
        /// Gets and sets the property ColumnTotalOptions. 
        /// <para>
        /// The column total options.
        /// </para>
        /// </summary>
        public PivotTotalOptions ColumnTotalOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColumnTotalOptions property is set.
        /// </summary>
        internal bool IsSetColumnTotalOptions() => this.ColumnTotalOptions != null;

        /// <summary>
        /// Gets and sets the property RowSubtotalOptions. 
        /// <para>
        /// The row subtotal options.
        /// </para>
        /// </summary>
        public SubtotalOptions RowSubtotalOptions { get; set; }

        /// <summary>
        /// Checks to see if the RowSubtotalOptions property is set.
        /// </summary>
        internal bool IsSetRowSubtotalOptions() => this.RowSubtotalOptions != null;

        /// <summary>
        /// Gets and sets the property RowTotalOptions. 
        /// <para>
        /// The row total options.
        /// </para>
        /// </summary>
        public PivotTotalOptions RowTotalOptions { get; set; }

        /// <summary>
        /// Checks to see if the RowTotalOptions property is set.
        /// </summary>
        internal bool IsSetRowTotalOptions() => this.RowTotalOptions != null;
    }
}
