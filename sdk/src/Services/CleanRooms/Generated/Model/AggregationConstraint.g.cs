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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Constraint on query output removing output rows that do not meet a minimum number
    /// of distinct values of a specified column.
    /// </summary>
    public partial class AggregationConstraint
    {
        /// <summary>
        /// Gets and sets the property ColumnName. 
        /// <para>
        /// Column in aggregation constraint for which there must be a minimum number of distinct
        /// values in an output row for it to be in the query output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string ColumnName { get; set; }

        /// <summary>
        /// Checks to see if the ColumnName property is set.
        /// </summary>
        internal bool IsSetColumnName() => this.ColumnName != null;

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum number of distinct values that an output row must be an aggregation of.
        /// Minimum threshold of distinct values for a specified column that must exist in an
        /// output row for it to be in the query output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100000)]
        public int? Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of aggregation the constraint allows. The only valid value is currently `COUNT_DISTINCT`.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AggregationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
