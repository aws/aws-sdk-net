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
    /// This is the response object from the Query operation.
    /// </summary>
    public partial class QueryResponse : AmazonWebServiceResponse
    {
        private List<ColumnInfo> _columnInfo = new List<ColumnInfo>();
        private string _nextToken;
        private string _queryId;
        private QueryStatus _queryStatus;
        private List<Row> _rows = new List<Row>();

        /// <summary>
        /// Gets and sets the property ColumnInfo. 
        /// <para>
        ///  The column data types of the returned result set. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ColumnInfo> ColumnInfo
        {
            get { return this._columnInfo; }
            set { this._columnInfo = value; }
        }

        // Check to see if ColumnInfo property is set
        internal bool IsSetColumnInfo()
        {
            return this._columnInfo != null && this._columnInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token that can be used again on a <code>Query</code> call to get the
        /// next set of results. 
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
        /// Gets and sets the property QueryId. 
        /// <para>
        ///  A unique ID for the given query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStatus. 
        /// <para>
        /// Information about the status of the query, including progress and bytes scannned.
        /// </para>
        /// </summary>
        public QueryStatus QueryStatus
        {
            get { return this._queryStatus; }
            set { this._queryStatus = value; }
        }

        // Check to see if QueryStatus property is set
        internal bool IsSetQueryStatus()
        {
            return this._queryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Rows. 
        /// <para>
        ///  The result set rows returned by the query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Row> Rows
        {
            get { return this._rows; }
            set { this._rows = value; }
        }

        // Check to see if Rows property is set
        internal bool IsSetRows()
        {
            return this._rows != null && this._rows.Count > 0; 
        }

    }
}