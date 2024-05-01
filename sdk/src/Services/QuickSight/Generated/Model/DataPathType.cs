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
    /// The type of the data path value.
    /// </summary>
    public partial class DataPathType
    {
        private PivotTableDataPathType _pivotTableDataPathType;

        /// <summary>
        /// Gets and sets the property PivotTableDataPathType. 
        /// <para>
        /// The type of data path value utilized in a pivot table. Choose one of the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HIERARCHY_ROWS_LAYOUT_COLUMN</c> - The type of data path for the rows layout column,
        /// when <c>RowsLayout</c> is set to <c>HIERARCHY</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTIPLE_ROW_METRICS_COLUMN</c> - The type of data path for the metric column
        /// when the row is set to Metric Placement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMPTY_COLUMN_HEADER</c> - The type of data path for the column with empty column
        /// header, when there is no field in <c>ColumnsFieldWell</c> and the row is set to Metric
        /// Placement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COUNT_METRIC_COLUMN</c> - The type of data path for the column with <c>COUNT</c>
        /// as the metric, when there is no field in the <c>ValuesFieldWell</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PivotTableDataPathType PivotTableDataPathType
        {
            get { return this._pivotTableDataPathType; }
            set { this._pivotTableDataPathType = value; }
        }

        // Check to see if PivotTableDataPathType property is set
        internal bool IsSetPivotTableDataPathType()
        {
            return this._pivotTableDataPathType != null;
        }

    }
}