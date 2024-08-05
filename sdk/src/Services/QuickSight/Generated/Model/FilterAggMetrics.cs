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
    /// The definition for the <c>FilterAggMetrics</c>.
    /// </summary>
    public partial class FilterAggMetrics
    {
        private AggType _function;
        private Identifier _metricOperand;
        private TopicSortDirection _sortDirection;

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function for the <c>FilterAggMetrics</c>.
        /// </para>
        /// </summary>
        public AggType Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property MetricOperand. 
        /// <para>
        /// The metric operand of the <c>FilterAggMetrics</c>.
        /// </para>
        /// </summary>
        public Identifier MetricOperand
        {
            get { return this._metricOperand; }
            set { this._metricOperand = value; }
        }

        // Check to see if MetricOperand property is set
        internal bool IsSetMetricOperand()
        {
            return this._metricOperand != null;
        }

        /// <summary>
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The sort direction for <c>FilterAggMetrics</c>.
        /// </para>
        /// </summary>
        public TopicSortDirection SortDirection
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