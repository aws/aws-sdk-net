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
    /// Container for the parameters to the BatchGetNamedQuery operation.
    /// Returns the details of a single named query or a list of up to 50 queries, which you
    /// provide as an array of query ID strings. Use <a>ListNamedQueries</a> to get the list
    /// of named query IDs. If information could not be retrieved for a submitted query ID,
    /// information about the query ID submitted is listed under <a>UnprocessedNamedQueryId</a>.
    /// Named queries are different from executed queries. Use <a>BatchGetQueryExecution</a>
    /// to get details about each unique query execution, and <a>ListQueryExecutions</a> to
    /// get a list of query execution IDs.
    /// </summary>
    public partial class BatchGetNamedQueryRequest : AmazonAthenaRequest
    {
        private List<string> _namedQueryIds = new List<string>();

        /// <summary>
        /// Gets and sets the property NamedQueryIds. 
        /// <para>
        /// An array of query IDs.
        /// </para>
        /// </summary>
        public List<string> NamedQueryIds
        {
            get { return this._namedQueryIds; }
            set { this._namedQueryIds = value; }
        }

        // Check to see if NamedQueryIds property is set
        internal bool IsSetNamedQueryIds()
        {
            return this._namedQueryIds != null && this._namedQueryIds.Count > 0; 
        }

    }
}