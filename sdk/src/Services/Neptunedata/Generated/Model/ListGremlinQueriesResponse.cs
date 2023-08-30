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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the ListGremlinQueries operation.
    /// </summary>
    public partial class ListGremlinQueriesResponse : AmazonWebServiceResponse
    {
        private int? _acceptedQueryCount;
        private List<GremlinQueryStatus> _queries = new List<GremlinQueryStatus>();
        private int? _runningQueryCount;

        /// <summary>
        /// Gets and sets the property AcceptedQueryCount. 
        /// <para>
        /// The number of queries that have been accepted but not yet completed, including queries
        /// in the queue.
        /// </para>
        /// </summary>
        public int AcceptedQueryCount
        {
            get { return this._acceptedQueryCount.GetValueOrDefault(); }
            set { this._acceptedQueryCount = value; }
        }

        // Check to see if AcceptedQueryCount property is set
        internal bool IsSetAcceptedQueryCount()
        {
            return this._acceptedQueryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Queries. 
        /// <para>
        /// A list of the current queries.
        /// </para>
        /// </summary>
        public List<GremlinQueryStatus> Queries
        {
            get { return this._queries; }
            set { this._queries = value; }
        }

        // Check to see if Queries property is set
        internal bool IsSetQueries()
        {
            return this._queries != null && this._queries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RunningQueryCount. 
        /// <para>
        /// The number of Gremlin queries currently running.
        /// </para>
        /// </summary>
        public int RunningQueryCount
        {
            get { return this._runningQueryCount.GetValueOrDefault(); }
            set { this._runningQueryCount = value; }
        }

        // Check to see if RunningQueryCount property is set
        internal bool IsSetRunningQueryCount()
        {
            return this._runningQueryCount.HasValue; 
        }

    }
}