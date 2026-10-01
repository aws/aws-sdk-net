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
    /// The configuration options to sort aggregated values.
    /// </summary>
    public partial class AggregationSortConfiguration
    {
        /// <summary>
        /// Gets and sets the property AggregationFunction. 
        /// <para>
        /// The function that aggregates the values in <c>Column</c>.
        /// </para>
        /// </summary>
        public AggregationFunction AggregationFunction { get; set; }

        /// <summary>
        /// Checks to see if the AggregationFunction property is set.
        /// </summary>
        internal bool IsSetAggregationFunction() => this.AggregationFunction != null;

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that determines the sort order of aggregated values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The sort direction of values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASC</c>: Sort in ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESC</c>: Sort in descending order.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SortDirection SortDirection { get; set; }

        /// <summary>
        /// Checks to see if the SortDirection property is set.
        /// </summary>
        internal bool IsSetSortDirection() => this.SortDirection != null;
    }
}
