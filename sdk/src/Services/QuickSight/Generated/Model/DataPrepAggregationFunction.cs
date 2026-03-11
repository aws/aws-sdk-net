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
    /// Defines the type of aggregation function to apply to data during data preparation,
    /// supporting simple and list aggregations.
    /// </summary>
    public partial class DataPrepAggregationFunction
    {
        private DataPrepListAggregationFunction _listAggregation;
        private DataPrepSimpleAggregationFunction _simpleAggregation;

        /// <summary>
        /// Gets and sets the property ListAggregation. 
        /// <para>
        /// A list aggregation function that concatenates values from multiple rows into a single
        /// delimited string.
        /// </para>
        /// </summary>
        public DataPrepListAggregationFunction ListAggregation
        {
            get { return this._listAggregation; }
            set { this._listAggregation = value; }
        }

        // Check to see if ListAggregation property is set
        internal bool IsSetListAggregation()
        {
            return this._listAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property SimpleAggregation. 
        /// <para>
        /// A simple aggregation function such as <c>SUM</c>, <c>COUNT</c>, <c>AVERAGE</c>, <c>MIN</c>,
        /// <c>MAX</c>, <c>MEDIAN</c>, <c>VARIANCE</c>, or <c>STANDARD_DEVIATION</c>.
        /// </para>
        /// </summary>
        public DataPrepSimpleAggregationFunction SimpleAggregation
        {
            get { return this._simpleAggregation; }
            set { this._simpleAggregation = value; }
        }

        // Check to see if SimpleAggregation property is set
        internal bool IsSetSimpleAggregation()
        {
            return this._simpleAggregation != null;
        }

    }
}