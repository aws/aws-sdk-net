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
    /// Provides insights into the spatial coverage of the query, including the table with
    /// sub-optimal (max) spatial pruning. This information can help you identify areas for
    /// improvement in your partitioning strategy to enhance spatial pruning
    /// 
    ///  
    /// <para>
    /// For example, you can do the following with the <c>QuerySpatialCoverage</c> information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Add measure_name or use <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/customer-defined-partition-keys.html">customer-defined
    /// partition key</a> (CDPK) predicates.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you've already done the preceding action, remove functions around them or clauses,
    /// such as <c>LIKE</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class QuerySpatialCoverage
    {
        private QuerySpatialCoverageMax _max;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// Provides insights into the spatial coverage of the executed query and the table with
        /// the most inefficient spatial pruning.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Value</c> – The maximum ratio of spatial coverage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TableArn</c> – The Amazon Resource Name (ARN) of the table with sub-optimal spatial
        /// pruning.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PartitionKey</c> – The partition key used for partitioning, which can be a default
        /// <c>measure_name</c> or a CDPK.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public QuerySpatialCoverageMax Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max != null;
        }

    }
}