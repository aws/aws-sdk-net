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
    /// This is the response object from the ListQueryExecutions operation.
    /// </summary>
    public partial class ListQueryExecutionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _queryExecutionIds = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to be used by the next request if this request is truncated.
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
        /// Gets and sets the property QueryExecutionIds. 
        /// <para>
        /// The unique IDs of each query execution as an array of strings.
        /// </para>
        /// </summary>
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