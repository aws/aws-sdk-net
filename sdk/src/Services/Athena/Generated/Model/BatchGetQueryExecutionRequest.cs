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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetQueryExecution operation.
    /// Returns the details of a single query execution or a list of up to 50 query executions,
    /// which you provide as an array of query execution ID strings. Requires you to have
    /// access to the workgroup in which the queries ran. To get a list of query execution
    /// IDs, use <a>ListQueryExecutionsInput$WorkGroup</a>. Query executions differ from named
    /// (saved) queries. Use <a>BatchGetNamedQueryInput</a> to get details about named queries.
    /// </summary>
    public partial class BatchGetQueryExecutionRequest : AmazonAthenaRequest
    {
        private List<string> _queryExecutionIds = new List<string>();

        /// <summary>
        /// Gets and sets the property QueryExecutionIds. 
        /// <para>
        /// An array of query execution IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> QueryExecutionIds
        {
            get { return this._queryExecutionIds; }
            set { this._queryExecutionIds = value; }
        }

        // Check to see if QueryExecutionIds property is set
        internal bool IsSetQueryExecutionIds()
        {
            return this._queryExecutionIds != null && this._queryExecutionIds.Count > 0; 
        }

    }
}