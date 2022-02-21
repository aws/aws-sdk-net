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
    /// This is the response object from the ExecuteStatement operation.
    /// </summary>
    public partial class ExecuteStatementResponse : AmazonWebServiceResponse
    {
        private ConsumedCapacity _consumedCapacity;
        private List<Dictionary<string, AttributeValue>> _items = new List<Dictionary<string, AttributeValue>>();
        private Dictionary<string, AttributeValue> _lastEvaluatedKey = new Dictionary<string, AttributeValue>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity.
        /// </summary>
        public ConsumedCapacity ConsumedCapacity
        {
            get { return this._consumedCapacity; }
            set { this._consumedCapacity = value; }
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this._consumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// If a read operation was used, this property will contain the result of the read operation;
        /// a map of attribute names and their values. For the write operations this value will
        /// be empty.
        /// </para>
        /// </summary>
        public List<Dictionary<string, AttributeValue>> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedKey. 
        /// <para>
        /// The primary key of the item where the operation stopped, inclusive of the previous
        /// result set. Use this value to start a new operation, excluding this value in the new
        /// request. If <code>LastEvaluatedKey</code> is empty, then the "last page" of results
        /// has been processed and there is no more data to be retrieved. If <code>LastEvaluatedKey</code>
        /// is not empty, it does not necessarily mean that there is more data in the result set.
        /// The only way to know when you have reached the end of the result set is when <code>LastEvaluatedKey</code>
        /// is empty. 
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> LastEvaluatedKey
        {
            get { return this._lastEvaluatedKey; }
            set { this._lastEvaluatedKey = value; }
        }

        // Check to see if LastEvaluatedKey property is set
        internal bool IsSetLastEvaluatedKey()
        {
            return this._lastEvaluatedKey != null && this._lastEvaluatedKey.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response of a read request exceeds the response payload limit DynamoDB will
        /// set this value in the response. If set, you can use that this value in the subsequent
        /// request to get the remaining results.
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

    }
}