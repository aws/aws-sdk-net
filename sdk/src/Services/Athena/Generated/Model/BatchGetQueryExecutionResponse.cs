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
    /// This is the response object from the BatchGetQueryExecution operation.
    /// </summary>
    public partial class BatchGetQueryExecutionResponse : AmazonWebServiceResponse
    {
        private List<QueryExecution> _queryExecutions = new List<QueryExecution>();
        private List<UnprocessedQueryExecutionId> _unprocessedQueryExecutionIds = new List<UnprocessedQueryExecutionId>();

        /// <summary>
        /// Gets and sets the property QueryExecutions. 
        /// <para>
        /// Information about a query execution.
        /// </para>
        /// </summary>
        public List<QueryExecution> QueryExecutions
        {
            get { return this._queryExecutions; }
            set { this._queryExecutions = value; }
        }

        // Check to see if QueryExecutions property is set
        internal bool IsSetQueryExecutions()
        {
            return this._queryExecutions != null && this._queryExecutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedQueryExecutionIds. 
        /// <para>
        /// Information about the query executions that failed to run.
        /// </para>
        /// </summary>
        public List<UnprocessedQueryExecutionId> UnprocessedQueryExecutionIds
        {
            get { return this._unprocessedQueryExecutionIds; }
            set { this._unprocessedQueryExecutionIds = value; }
        }

        // Check to see if UnprocessedQueryExecutionIds property is set
        internal bool IsSetUnprocessedQueryExecutionIds()
        {
            return this._unprocessedQueryExecutionIds != null && this._unprocessedQueryExecutionIds.Count > 0; 
        }

    }
}