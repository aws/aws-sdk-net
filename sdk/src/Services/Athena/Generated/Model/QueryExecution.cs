/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Information about a single instance of a query execution.
    /// </summary>
    public partial class QueryExecution
    {
        private string _query;
        private QueryExecutionContext _queryExecutionContext;
        private string _queryExecutionId;
        private ResultConfiguration _resultConfiguration;
        private QueryExecutionStatistics _statistics;
        private QueryExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The SQL query statements which the query execution ran.
        /// </para>
        /// </summary>
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property QueryExecutionContext. 
        /// <para>
        /// The database in which the query execution occurred.
        /// </para>
        /// </summary>
        public QueryExecutionContext QueryExecutionContext
        {
            get { return this._queryExecutionContext; }
            set { this._queryExecutionContext = value; }
        }

        // Check to see if QueryExecutionContext property is set
        internal bool IsSetQueryExecutionContext()
        {
            return this._queryExecutionContext != null;
        }

        /// <summary>
        /// Gets and sets the property QueryExecutionId. 
        /// <para>
        /// The unique identifier for each query execution.
        /// </para>
        /// </summary>
        public string QueryExecutionId
        {
            get { return this._queryExecutionId; }
            set { this._queryExecutionId = value; }
        }

        // Check to see if QueryExecutionId property is set
        internal bool IsSetQueryExecutionId()
        {
            return this._queryExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// The location in Amazon S3 where query results were stored and the encryption option,
        /// if any, used for query results.
        /// </para>
        /// </summary>
        public ResultConfiguration ResultConfiguration
        {
            get { return this._resultConfiguration; }
            set { this._resultConfiguration = value; }
        }

        // Check to see if ResultConfiguration property is set
        internal bool IsSetResultConfiguration()
        {
            return this._resultConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The amount of data scanned during the query execution and the amount of time that
        /// it took to execute.
        /// </para>
        /// </summary>
        public QueryExecutionStatistics Statistics
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
        /// The completion date, current state, submission time, and state change reason (if applicable)
        /// for the query execution.
        /// </para>
        /// </summary>
        public QueryExecutionStatus Status
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