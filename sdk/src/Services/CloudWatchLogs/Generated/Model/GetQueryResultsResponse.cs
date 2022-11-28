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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the GetQueryResults operation.
    /// </summary>
    public partial class GetQueryResultsResponse : AmazonWebServiceResponse
    {
        private List<List<ResultField>> _results = new List<List<ResultField>>();
        private QueryStatistics _statistics;
        private QueryStatus _status;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// The log events that matched the query criteria during the most recent time it ran.
        /// </para>
        ///  
        /// <para>
        /// The <code>results</code> value is an array of arrays. Each log event is one object
        /// in the top-level array. Each of these log event objects is an array of <code>field</code>/<code>value</code>
        /// pairs.
        /// </para>
        /// </summary>
        public List<List<ResultField>> Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null && this._results.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Includes the number of log events scanned by the query, the number of log events that
        /// matched the query criteria, and the total number of bytes in the log events that were
        /// scanned. These values reflect the full raw results of the query.
        /// </para>
        /// </summary>
        public QueryStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the most recent running of the query. Possible values are <code>Cancelled</code>,
        /// <code>Complete</code>, <code>Failed</code>, <code>Running</code>, <code>Scheduled</code>,
        /// <code>Timeout</code>, and <code>Unknown</code>.
        /// </para>
        ///  
        /// <para>
        /// Queries time out after 15 minutes of runtime. To avoid having your queries time out,
        /// reduce the time range being searched or partition your query into a number of queries.
        /// </para>
        /// </summary>
        public QueryStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}