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
    /// The configuration options to sort aggregated values.
    /// </summary>
    public partial class AggregationSortConfiguration
    {
        private AggregationFunction _aggregationFunction;
        private ColumnIdentifier _column;
        private SortDirection _sortDirection;

        /// <summary>
        /// Gets and sets the property AggregationFunction. 
        /// <para>
        /// The function that aggregates the values in <code>Column</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AggregationFunction AggregationFunction
        {
            get { return this._aggregationFunction; }
            set { this._aggregationFunction = value; }
        }

        // Check to see if AggregationFunction property is set
        internal bool IsSetAggregationFunction()
        {
            return this._aggregationFunction != null;
        }

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that determines the sort order of aggregated values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The sort direction of values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ASC</code>: Sort in ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DESC</code>: Sort in descending order.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SortDirection SortDirection
        {
            get { return this._sortDirection; }
            set { this._sortDirection = value; }
        }

        // Check to see if SortDirection property is set
        internal bool IsSetSortDirection()
        {
            return this._sortDirection != null;
        }

    }
}