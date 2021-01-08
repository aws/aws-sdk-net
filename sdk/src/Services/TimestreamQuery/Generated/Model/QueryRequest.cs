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
    /// Query is a synchronous operation that enables you to execute a query. Query will
    /// timeout after 60 seconds. You must update the default timeout in the SDK to support
    /// a timeout of 60 seconds. The result set will be truncated to 1MB. Service quotas apply.
    /// For more information, see Quotas in the Timestream Developer Guide.
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
        ///  Unique, case-sensitive string of up to 64 ASCII characters that you specify when
        /// you make a Query request. Providing a <code>ClientToken</code> makes the call to <code>Query</code>
        /// idempotent, meaning that multiple identical calls have the same effect as one single
        /// call. 
        /// </para>
        ///  
        /// <para>
        /// Your query request will fail in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you submit a request with the same client token outside the 5-minute idepotency
        /// window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you submit a request with the same client token but a change in other parameters
        /// within the 5-minute idempotency window. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  After 4 hours, any request with the same client token is treated as a new request.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
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
        ///  The total number of rows to return in the output. If the total number of rows available
        /// is more than the value specified, a NextToken is provided in the command's output.
        /// To resume pagination, provide the NextToken value in the starting-token argument of
        /// a subsequent command. 
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
        ///  A pagination token passed to get a set of results. 
        /// </para>
        /// </summary>
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
        ///  The query to be executed by Timestream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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