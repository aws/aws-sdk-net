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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// A single query to be processed. You must provide the metric to query and append an
    /// aggregate function to the metric. For example, to find the average for the metric
    /// <c>db.load</c> you must use <c>db.load.avg</c>. Valid values for aggregate functions
    /// include <c>.avg</c>, <c>.min</c>, <c>.max</c>, and <c>.sum</c>. If no other parameters
    /// are specified, Performance Insights returns all data points for the specified metric.
    /// Optionally, you can request that the data points be aggregated by dimension group
    /// (<c>GroupBy</c>), and return only those data points that match your criteria (<c>Filter</c>).
    /// </summary>
    public partial class MetricQuery
    {
        private Dictionary<string, string> _filter = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DimensionGroup _groupBy;
        private string _metric;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters to apply in the request. Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any number of filters by the same dimension, as specified in the <c>GroupBy</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A single filter for any other dimension in this dimension group.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>db.sql.db_id</c> filter isn't available for RDS for SQL Server DB instances.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && (this._filter.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Valid values for <c>Metric</c> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>db.load.avg</c> - A scaled representation of the number of active sessions for
        /// the database engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db.sampledload.avg</c> - The raw number of active sessions for the database engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The counter metrics listed in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_PerfInsights_Counters.html#USER_PerfInsights_Counters.OS">Performance
        /// Insights operating system counters</a> in the <i>Amazon Aurora User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The counter metrics listed in <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights_Counters.html#USER_PerfInsights_Counters.OS">Performance
        /// Insights operating system counters</a> in the <i>Amazon RDS User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the number of active sessions is less than an internal Performance Insights threshold,
        /// <c>db.load.avg</c> and <c>db.sampledload.avg</c> are the same value. If the number
        /// of active sessions is greater than the internal threshold, Performance Insights samples
        /// the active sessions, with <c>db.load.avg</c> showing the scaled values, <c>db.sampledload.avg</c>
        /// showing the raw values, and <c>db.sampledload.avg</c> less than <c>db.load.avg</c>.
        /// For most use cases, you can query <c>db.load.avg</c> only.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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