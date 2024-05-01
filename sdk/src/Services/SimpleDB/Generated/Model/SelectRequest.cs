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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
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
namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Container for the parameters to the Select operation.
    /// The <c>Select</c> operation returns a set of attributes for <c>ItemNames</c> that
    /// match the select expression. <c>Select</c> is similar to the standard SQL SELECT statement.
    /// 
    /// 
    ///  
    /// <para>
    ///  The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB
    /// automatically adjusts the number of items returned per page to enforce this limit.
    /// For example, if the client asks to retrieve 2500 items, but each individual item is
    /// 10 kB in size, the system returns 100 items and an appropriate <c>NextToken</c> so
    /// the client can access the next page of results. 
    /// </para>
    ///  
    /// <para>
    ///  For information on how to construct select expressions, see Using Select to Create
    /// Amazon SimpleDB Queries in the Developer Guide. 
    /// </para>
    /// </summary>
    public partial class SelectRequest : AmazonSimpleDBRequest
    {
        private bool? _consistentRead;
        private string _nextToken;
        private string _selectExpression;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SelectRequest() { }

        /// <summary>
        /// Instantiates SelectRequest with the parameterized properties
        /// </summary>
        /// <param name="selectExpression">The expression used to query the domain.</param>
        public SelectRequest(string selectExpression)
        {
            _selectExpression = selectExpression;
        }

        /// <summary>
        /// Instantiates SelectRequest with the parameterized properties
        /// </summary>
        /// <param name="selectExpression">The expression used to query the domain.</param>
        /// <param name="consistentRead">Determines whether or not strong consistency should be enforced when data is read from SimpleDB. If <c>true</c>, any data previously written to SimpleDB will be returned. Otherwise, results will be consistent eventually, and the client may not see data that was written immediately before your read.</param>
        public SelectRequest(string selectExpression, bool? consistentRead)
        {
            _selectExpression = selectExpression;
            _consistentRead = consistentRead;
        }

        /// <summary>
        /// Gets and sets the property ConsistentRead. Determines whether or not strong consistency
        /// should be enforced when data is read from SimpleDB. If <c>true</c>, any data previously
        /// written to SimpleDB will be returned. Otherwise, results will be consistent eventually,
        /// and the client may not see data that was written immediately before your read.
        /// </summary>
        public bool? ConsistentRead
        {
            get { return this._consistentRead; }
            set { this._consistentRead = value; }
        }

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this._consistentRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. A string informing Amazon SimpleDB where to
        /// start the next list of <c>ItemNames</c>.
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
        /// Gets and sets the property SelectExpression. The expression used to query the domain.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SelectExpression
        {
            get { return this._selectExpression; }
            set { this._selectExpression = value; }
        }

        // Check to see if SelectExpression property is set
        internal bool IsSetSelectExpression()
        {
            return this._selectExpression != null;
        }

    }
}