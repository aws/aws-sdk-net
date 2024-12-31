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
    /// Container for the parameters to the Query operation.
    /// <c>Query</c> is a synchronous operation that enables you to run a query against your
    /// Amazon Timestream data.
    /// 
    ///  
    /// <para>
    /// If you enabled <c>QueryInsights</c>, this API also returns insights and metrics related
    /// to the query that you executed. <c>QueryInsights</c> helps with performance tuning
    /// of your query. For more information about <c>QueryInsights</c>, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/using-query-insights.html">Using
    /// query insights to optimize queries in Amazon Timestream</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The maximum number of <c>Query</c> API requests you're allowed to make with <c>QueryInsights</c>
    /// enabled is 1 query per second (QPS). If you exceed this query rate, it might result
    /// in throttling.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <c>Query</c> will time out after 60 seconds. You must update the default timeout
    /// in the SDK to support a timeout of 60 seconds. See the <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.run-query.html">code
    /// sample</a> for details. 
    /// </para>
    ///  
    /// <para>
    /// Your query request will fail in the following cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  If you submit a <c>Query</c> request with the same client token outside of the 5-minute
    /// idempotency window. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If you submit a <c>Query</c> request with the same client token, but change other
    /// parameters, within the 5-minute idempotency window. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If the size of the row (including the query metadata) exceeds 1 MB, then the query
    /// will fail with the following error message: 
    /// </para>
    ///  
    /// <para>
    ///  <c>Query aborted as max page response size has been exceeded by the output result
    /// row</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If the IAM principal of the query initiator and the result reader are not the same
    /// and/or the query initiator and the result reader do not have the same query string
    /// in the query requests, the query will fail with an <c>Invalid pagination token</c>
    /// error. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class QueryRequest : AmazonTimestreamQueryRequest
    {
        private string _clientToken;
        private int? _maxRows;
        private string _nextToken;
        private QueryInsights _queryInsights;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive string of up to 64 ASCII characters specified when a <c>Query</c>
        /// request is made. Providing a <c>ClientToken</c> makes the call to <c>Query</c> <i>idempotent</i>.
        /// This means that running the same query repeatedly will produce the same result. In
        /// other words, making multiple identical <c>Query</c> requests has the same effect as
        /// making a single request. When using <c>ClientToken</c> in a query, note the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the Query API is instantiated without a <c>ClientToken</c>, the Query SDK generates
        /// a <c>ClientToken</c> on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <c>Query</c> invocation only contains the <c>ClientToken</c> but does not include
        /// a <c>NextToken</c>, that invocation of <c>Query</c> is assumed to be a new query run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the invocation contains <c>NextToken</c>, that particular invocation is assumed
        /// to be a subsequent invocation of a prior call to the Query API, and a result set is
        /// returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After 4 hours, any request with the same <c>ClientToken</c> is treated as a new request.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=32, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRows. 
        /// <para>
        ///  The total number of rows to be returned in the <c>Query</c> output. The initial run
        /// of <c>Query</c> with a <c>MaxRows</c> value specified will return the result set of
        /// the query in two cases: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The size of the result is less than <c>1MB</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of rows in the result set is less than the value of <c>maxRows</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, the initial invocation of <c>Query</c> only returns a <c>NextToken</c>,
        /// which can then be used in subsequent calls to fetch the result set. To resume pagination,
        /// provide the <c>NextToken</c> value in the subsequent command.
        /// </para>
        ///  
        /// <para>
        /// If the row size is large (e.g. a row has many columns), Timestream may return fewer
        /// rows to keep the response size from exceeding the 1 MB limit. If <c>MaxRows</c> is
        /// not provided, Timestream will send the necessary number of rows to meet the 1 MB limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxRows
        {
            get { return this._maxRows; }
            set { this._maxRows = value; }
        }

        // Check to see if MaxRows property is set
        internal bool IsSetMaxRows()
        {
            return this._maxRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token used to return a set of results. When the <c>Query</c> API is
        /// invoked using <c>NextToken</c>, that particular invocation is assumed to be a subsequent
        /// invocation of a prior call to <c>Query</c>, and a result set is returned. However,
        /// if the <c>Query</c> invocation only contains the <c>ClientToken</c>, that invocation
        /// of <c>Query</c> is assumed to be a new query run. 
        /// </para>
        ///  
        /// <para>
        /// Note the following when using NextToken in a query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A pagination token can be used for up to five <c>Query</c> invocations, OR for a duration
        /// of up to 1 hour – whichever comes first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Using the same <c>NextToken</c> will return the same set of records. To keep paginating
        /// through the result set, you must to use the most recent <c>nextToken</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Suppose a <c>Query</c> invocation returns two <c>NextToken</c> values, <c>TokenA</c>
        /// and <c>TokenB</c>. If <c>TokenB</c> is used in a subsequent <c>Query</c> invocation,
        /// then <c>TokenA</c> is invalidated and cannot be reused.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To request a previous result set from a query after pagination has begun, you must
        /// re-invoke the Query API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The latest <c>NextToken</c> should be used to paginate until <c>null</c> is returned,
        /// at which point a new <c>NextToken</c> should be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the IAM principal of the query initiator and the result reader are not the same
        /// and/or the query initiator and the result reader do not have the same query string
        /// in the query requests, the query will fail with an <c>Invalid pagination token</c>
        /// error. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property QueryInsights. 
        /// <para>
        /// Encapsulates settings for enabling <c>QueryInsights</c>.
        /// </para>
        ///  
        /// <para>
        /// Enabling <c>QueryInsights</c> returns insights and metrics in addition to query results
        /// for the query that you executed. You can use <c>QueryInsights</c> to tune your query
        /// performance.
        /// </para>
        /// </summary>
        public QueryInsights QueryInsights
        {
            get { return this._queryInsights; }
            set { this._queryInsights = value; }
        }

        // Check to see if QueryInsights property is set
        internal bool IsSetQueryInsights()
        {
            return this._queryInsights != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        ///  The query to be run by Timestream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=262144)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

    }
}