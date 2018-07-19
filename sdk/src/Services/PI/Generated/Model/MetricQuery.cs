/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// A single query to be processed. You must provide the metric to query. If no other
    /// parameters are specified, Performance Insights returns all of the data points for
    /// that metric. You can optionally request that the data points be aggregated by dimension
    /// group ( <code>GroupBy</code>), and return only those data points that match your criteria
    /// (<code>Filter</code>).
    /// </summary>
    public partial class MetricQuery
    {
        private Dictionary<string, string> _filter = new Dictionary<string, string>();
        private DimensionGroup _groupBy;
        private string _metric;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters to apply in the request. Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any number of filters by the same dimension, as specified in the <code>GroupBy</code>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A single filter for any other dimension in this dimension group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// A specification for how to aggregate the data points from a query result. You must
        /// specify a valid dimension group. Performance Insights will return all of the dimensions
        /// within that group, unless you provide the names of specific dimensions within that
        /// group. You can also request that Performance Insights return a limited number of values
        /// for a dimension.
        /// </para>
        /// </summary>
        public DimensionGroup GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The name of a Performance Insights metric to be measured.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Metric</code> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db.load.avg</code> - a scaled representation of the number of active sessions
        /// for the database engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sampledload.avg</code> - the raw number of active sessions for the database
        /// engine.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

    }
}