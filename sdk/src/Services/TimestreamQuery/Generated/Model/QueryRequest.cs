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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the Query operation.
    /// <code>Query</code> is a synchronous operation that enables you to run a query against
    /// your Amazon Timestream data. <code>Query</code> will time out after 60 seconds. You
    /// must update the default timeout in the SDK to support a timeout of 60 seconds. See
    /// the <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.run-query.html">code
    /// sample</a> for details. 
    /// 
    ///  
    /// <para>
    /// Your query request will fail in the following cases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  If you submit a <code>Query</code> request with the same client token outside of
    /// the 5-minute idempotency window. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If you submit a <code>Query</code> request with the same client token, but change
    /// other parameters, within the 5-minute idempotency window. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If the size of the row (including the query metadata) exceeds 1 MB, then the query
    /// will fail with the following error message: 
    /// </para>
    ///  
    /// <para>
    ///  <code>Query aborted as max page response size has been exceeded by the output result
    /// row</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  If the IAM principal of the query initiator and the result reader are not the same
    /// and/or the query initiator and the result reader do not have the same query string
    /// in the query requests, the query will fail with an <code>Invalid pagination token</code>
    /// error. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class QueryRequest : AmazonTimestreamQueryRequest
    {
        private string _clientToken;
        private int? _maxRows;
        private string _nextToken;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive string of up to 64 ASCII characters specified when a <code>Query</code>
        /// request is made. Providing a <code>ClientToken</code> makes the call to <code>Query</code>
        /// <i>idempotent</i>. This means that running the same query repeatedly will produce
        /// the same result. In other words, making multiple identical <code>Query</code> requests
        /// has the same effect as making a single request. When using <code>ClientToken</code>
        /// in a query, note the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the Query API is instantiated without a <code>ClientToken</code>, the Query SDK
        /// generates a <code>ClientToken</code> on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the <code>Query</code> invocation only contains the <code>ClientToken</code> but
        /// does not include a <code>NextToken</code>, that invocation of <code>Query</code> is
        /// assumed to be a new query run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the invocation contains <code>NextToken</code>, that particular invocation is assumed
        /// to be a subsequent invocation of a prior call to the Query API, and a result set is
        /// returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After 4 hours, any request with the same <code>ClientToken</code> is treated as a
        /// new request. 
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
        ///  The total number of rows to be returned in the <code>Query</code> output. The initial
        /// run of <code>Query</code> with a <code>MaxRows</code> value specified will return
        /// the result set of the query in two cases: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The size of the result is less than <code>1MB</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of rows in the result set is less than the value of <code>maxRows</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, the initial invocation of <code>Query</code> only returns a <code>NextToken</code>,
        /// which can then be used in subsequent calls to fetch the result set. To resume pagination,
        /// provide the <code>NextToken</code> value in the subsequent command.
        /// </para>
        ///  
        /// <para>
        /// If the row size is large (e.g. a row has many columns), Timestream may return fewer
        /// rows to keep the response size from exceeding the 1 MB limit. If <code>MaxRows</code>
        /// is not provided, Timestream will send the necessary number of rows to meet the 1 MB
        /// limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxRows
        {
            get { return this._maxRows.GetValueOrDefault(); }
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
        ///  A pagination token used to return a set of results. When the <code>Query</code> API
        /// is invoked using <code>NextToken</code>, that particular invocation is assumed to
        /// be a subsequent invocation of a prior call to <code>Query</code>, and a result set
        /// is returned. However, if the <code>Query</code> invocation only contains the <code>ClientToken</code>,
        /// that invocation of <code>Query</code> is assumed to be a new query run. 
        /// </para>
        ///  
        /// <para>
        /// Note the following when using NextToken in a query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A pagination token can be used for up to five <code>Query</code> invocations, OR for
        /// a duration of up to 1 hour – whichever comes first.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Using the same <code>NextToken</code> will return the same set of records. To keep
        /// paginating through the result set, you must to use the most recent <code>nextToken</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Suppose a <code>Query</code> invocation returns two <code>NextToken</code> values,
        /// <code>TokenA</code> and <code>TokenB</code>. If <code>TokenB</code> is used in a subsequent
        /// <code>Query</code> invocation, then <code>TokenA</code> is invalidated and cannot
        /// be reused.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To request a previous result set from a query after pagination has begun, you must
        /// re-invoke the Query API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The latest <code>NextToken</code> should be used to paginate until <code>null</code>
        /// is returned, at which point a new <code>NextToken</code> should be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the IAM principal of the query initiator and the result reader are not the same
        /// and/or the query initiator and the result reader do not have the same query string
        /// in the query requests, the query will fail with an <code>Invalid pagination token</code>
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