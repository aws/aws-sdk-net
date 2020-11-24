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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteStatement operation.
    /// This operation allows you to perform reads and singleton writes on data stored in
    /// DynamoDB, using PartiQL.
    /// </summary>
    public partial class ExecuteStatementRequest : AmazonDynamoDBRequest
    {
        private bool? _consistentRead;
        private string _nextToken;
        private List<AttributeValue> _parameters = new List<AttributeValue>();
        private string _statement;

        /// <summary>
        /// Gets and sets the property ConsistentRead. 
        /// <para>
        ///  The consistency of a read operation. If set to <code>true</code>, then a strongly
        /// consistent read is used; otherwise, an eventually consistent read is used. 
        /// </para>
        /// </summary>
        public bool ConsistentRead
        {
            get { return this._consistentRead.GetValueOrDefault(); }
            set { this._consistentRead = value; }
        }

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this._consistentRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Set this value to get remaining results, if <code>NextToken</code> was returned in
        /// the statement response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
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
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  The parameters for the PartiQL statement, if any. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AttributeValue> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        ///  The PartiQL statement representing the operation to run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}