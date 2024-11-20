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
    /// Provides various insights and metrics related to the <c>ExecuteScheduledQueryRequest</c>
    /// that was executed.
    /// </summary>
    public partial class ScheduledQueryInsightsResponse
    {
        private long? _outputBytes;
        private long? _outputRows;
        private QuerySpatialCoverage _querySpatialCoverage;
        private long? _queryTableCount;
        private QueryTemporalRange _queryTemporalRange;

        /// <summary>
        /// Gets and sets the property OutputBytes. 
        /// <para>
        /// Indicates the size of query result set in bytes. You can use this data to validate
        /// if the result set has changed as part of the query tuning exercise.
        /// </para>
        /// </summary>
        public long? OutputBytes
        {
            get { return this._outputBytes; }
            set { this._outputBytes = value; }
        }

        // Check to see if OutputBytes property is set
        internal bool IsSetOutputBytes()
        {
            return this._outputBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputRows. 
        /// <para>
        /// Indicates the total number of rows returned as part of the query result set. You can
        /// use this data to validate if the number of rows in the result set have changed as
        /// part of the query tuning exercise.
        /// </para>
        /// </summary>
        public long? OutputRows
        {
            get { return this._outputRows; }
            set { this._outputRows = value; }
        }

        // Check to see if OutputRows property is set
        internal bool IsSetOutputRows()
        {
            return this._outputRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QuerySpatialCoverage. 
        /// <para>
        /// Provides insights into the spatial coverage of the query, including the table with
        /// sub-optimal (max) spatial pruning. This information can help you identify areas for
        /// improvement in your partitioning strategy to enhance spatial pruning.
        /// </para>
        /// </summary>
        public QuerySpatialCoverage QuerySpatialCoverage
        {
            get { return this._querySpatialCoverage; }
            set { this._querySpatialCoverage = value; }
        }

        // Check to see if QuerySpatialCoverage property is set
        internal bool IsSetQuerySpatialCoverage()
        {
            return this._querySpatialCoverage != null;
        }

        /// <summary>
        /// Gets and sets the property QueryTableCount. 
        /// <para>
        /// Indicates the number of tables in the query.
        /// </para>
        /// </summary>
        public long? QueryTableCount
        {
            get { return this._queryTableCount; }
            set { this._queryTableCount = value; }
        }

        // Check to see if QueryTableCount property is set
        internal bool IsSetQueryTableCount()
        {
            return this._queryTableCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryTemporalRange. 
        /// <para>
        /// Provides insights into the temporal range of the query, including the table with the
        /// largest (max) time range. Following are some of the potential options for optimizing
        /// time-based pruning:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Add missing time-predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove functions around the time predicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add time predicates to all the sub-queries.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public QueryTemporalRange QueryTemporalRange
        {
            get { return this._queryTemporalRange; }
            set { this._queryTemporalRange = value; }
        }

        // Check to see if QueryTemporalRange property is set
        internal bool IsSetQueryTemporalRange()
        {
            return this._queryTemporalRange != null;
        }

    }
}