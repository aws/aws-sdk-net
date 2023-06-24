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
    /// An aggregation function aggregates values from a dimension or measure.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class AggregationFunction
    {
        private CategoricalAggregationFunction _categoricalAggregationFunction;
        private DateAggregationFunction _dateAggregationFunction;
        private NumericalAggregationFunction _numericalAggregationFunction;

        /// <summary>
        /// Gets and sets the property CategoricalAggregationFunction. 
        /// <para>
        /// Aggregation for categorical values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COUNT</code>: Aggregate by the total number of values, including duplicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISTINCT_COUNT</code>: Aggregate by the total number of distinct values.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CategoricalAggregationFunction CategoricalAggregationFunction
        {
            get { return this._categoricalAggregationFunction; }
            set { this._categoricalAggregationFunction = value; }
        }

        // Check to see if CategoricalAggregationFunction property is set
        internal bool IsSetCategoricalAggregationFunction()
        {
            return this._categoricalAggregationFunction != null;
        }

        /// <summary>
        /// Gets and sets the property DateAggregationFunction. 
        /// <para>
        /// Aggregation for date values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COUNT</code>: Aggregate by the total number of values, including duplicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISTINCT_COUNT</code>: Aggregate by the total number of distinct values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MIN</code>: Select the smallest date value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MAX</code>: Select the largest date value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateAggregationFunction DateAggregationFunction
        {
            get { return this._dateAggregationFunction; }
            set { this._dateAggregationFunction = value; }
        }

        // Check to see if DateAggregationFunction property is set
        internal bool IsSetDateAggregationFunction()
        {
            return this._dateAggregationFunction != null;
        }

        /// <summary>
        /// Gets and sets the property NumericalAggregationFunction. 
        /// <para>
        /// Aggregation for numerical values.
        /// </para>
        /// </summary>
        public NumericalAggregationFunction NumericalAggregationFunction
        {
            get { return this._numericalAggregationFunction; }
            set { this._numericalAggregationFunction = value; }
        }

        // Check to see if NumericalAggregationFunction property is set
        internal bool IsSetNumericalAggregationFunction()
        {
            return this._numericalAggregationFunction != null;
        }

    }
}