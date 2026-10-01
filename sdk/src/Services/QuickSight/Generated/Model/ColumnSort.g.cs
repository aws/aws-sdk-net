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
    /// The sort configuration for a column that is not used in a field well.
    /// </summary>
    public partial class ColumnSort
    {
        /// <summary>
        /// Gets and sets the property AggregationFunction. 
        /// <para>
        /// The aggregation function that is defined in the column sort.
        /// </para>
        /// </summary>
        public AggregationFunction AggregationFunction { get; set; }

        /// <summary>
        /// Checks to see if the AggregationFunction property is set.
        /// </summary>
        internal bool IsSetAggregationFunction() => this.AggregationFunction != null;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The sort direction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SortDirection Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property SortBy.
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;
    }
}
