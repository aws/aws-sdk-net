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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// <c>QueryInsights</c> is a performance tuning feature that helps you optimize your
    /// queries, reducing costs and improving performance. With <c>QueryInsights</c>, you
    /// can assess the pruning efficiency of your queries and identify areas for improvement
    /// to enhance query performance. With <c>QueryInsights</c>, you can also analyze the
    /// effectiveness of your queries in terms of temporal and spatial pruning, and identify
    /// opportunities to improve performance. Specifically, you can evaluate how well your
    /// queries use time-based and partition key-based indexing strategies to optimize data
    /// retrieval. To optimize query performance, it's essential that you fine-tune both the
    /// temporal and spatial parameters that govern query execution.
    /// 
    ///  
    /// <para>
    /// The key metrics provided by <c>QueryInsights</c> are <c>QuerySpatialCoverage</c> and
    /// <c>QueryTemporalRange</c>. <c>QuerySpatialCoverage</c> indicates how much of the spatial
    /// axis the query scans, with lower values being more efficient. <c>QueryTemporalRange</c>
    /// shows the time range scanned, with narrower ranges being more performant.
    /// </para>
    ///  
    /// <para>
    ///  <b>Benefits of QueryInsights</b> 
    /// </para>
    ///  
    /// <para>
    /// The following are the key benefits of using <c>QueryInsights</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Identifying inefficient queries</b> – <c>QueryInsights</c> provides information
    /// on the time-based and attribute-based pruning of the tables accessed by the query.
    /// This information helps you identify the tables that are sub-optimally accessed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Optimizing your data model and partitioning</b> – You can use the <c>QueryInsights</c>
    /// information to access and fine-tune your data model and partitioning strategy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Tuning queries</b> – <c>QueryInsights</c> highlights opportunities to use indexes
    /// more effectively.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// The maximum number of <c>Query</c> API requests you're allowed to make with <c>QueryInsights</c>
    /// enabled is 1 query per second (QPS). If you exceed this query rate, it might result
    /// in throttling.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class QueryInsights
    {
        private QueryInsightsMode _mode;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Provides the following modes to enable <c>QueryInsights</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED_WITH_RATE_CONTROL</c> – Enables <c>QueryInsights</c> for the queries being
        /// processed. This mode also includes a rate control mechanism, which limits the <c>QueryInsights</c>
        /// feature to 1 query per second (QPS).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Disables <c>QueryInsights</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryInsightsMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}