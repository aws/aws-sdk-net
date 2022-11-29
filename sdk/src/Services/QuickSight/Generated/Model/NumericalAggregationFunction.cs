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
    /// Aggregation for numerical values.
    /// </summary>
    public partial class NumericalAggregationFunction
    {
        private PercentileAggregation _percentileAggregation;
        private SimpleNumericalAggregationFunction _simpleNumericalAggregation;

        /// <summary>
        /// Gets and sets the property PercentileAggregation. 
        /// <para>
        /// An aggregation based on the percentile of values in a dimension or measure.
        /// </para>
        /// </summary>
        public PercentileAggregation PercentileAggregation
        {
            get { return this._percentileAggregation; }
            set { this._percentileAggregation = value; }
        }

        // Check to see if PercentileAggregation property is set
        internal bool IsSetPercentileAggregation()
        {
            return this._percentileAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property SimpleNumericalAggregation. 
        /// <para>
        /// Built-in aggregation functions for numerical values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SUM</code>: The sum of a dimension or measure. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AVERAGE</code>: The average of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MIN</code>: The minimum value of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MAX</code>: The maximum value of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COUNT</code>: The count of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISTINCT_COUNT</code>: The count of distinct values in a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VAR</code>: The variance of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VARP</code>: The partitioned variance of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STDEV</code>: The standard deviation of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STDEVP</code>: The partitioned standard deviation of a dimension or measure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MEDIAN</code>: The median value of a dimension or measure.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SimpleNumericalAggregationFunction SimpleNumericalAggregation
        {
            get { return this._simpleNumericalAggregation; }
            set { this._simpleNumericalAggregation = value; }
        }

        // Check to see if SimpleNumericalAggregation property is set
        internal bool IsSetSimpleNumericalAggregation()
        {
            return this._simpleNumericalAggregation != null;
        }

    }
}