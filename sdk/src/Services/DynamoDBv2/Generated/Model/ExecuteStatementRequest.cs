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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the ExecuteStatement operation.
    /// This operation allows you to perform reads and singleton writes on data stored in
    /// DynamoDB, using PartiQL.
    /// 
    ///  
    /// <para>
    /// For PartiQL reads (<c>SELECT</c> statement), if the total number of processed items
    /// exceeds the maximum dataset size limit of 1 MB, the read stops and results are returned
    /// to the user as a <c>LastEvaluatedKey</c> value to continue the read in a subsequent
    /// operation. If the filter criteria in <c>WHERE</c> clause does not match any data,
    /// the read will return an empty result set.
    /// </para>
    ///  
    /// <para>
    /// A single <c>SELECT</c> statement response can return up to the maximum number of items
    /// (if using the Limit parameter) or a maximum of 1 MB of data (and then apply any filtering
    /// to the results using <c>WHERE</c> clause). If <c>LastEvaluatedKey</c> is present in
    /// the response, you need to paginate the result set. If <c>NextToken</c> is present,
    /// you need to paginate the result set and include <c>NextToken</c>.
    /// </para>
    /// </summary>
    public partial class ExecuteStatementRequest : AmazonDynamoDBRequest
    {
        private bool? _consistentRead;
        private int? _limit;
        private string _nextToken;
        private List<AttributeValue> _parameters = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private ReturnValuesOnConditionCheckFailure _returnValuesOnConditionCheckFailure;
        private string _statement;

        /// <summary>
        /// Gets and sets the property ConsistentRead. 
        /// <para>
        /// The consistency of a read operation. If set to <c>true</c>, then a strongly consistent
        /// read is used; otherwise, an eventually consistent read is used.
        /// </para>
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to evaluate (not necessarily the number of matching items).
        /// If DynamoDB processes the number of items up to the limit while processing the results,
        /// it stops the operation and returns the matching values up to that point, along with
        /// a key in <c>LastEvaluatedKey</c> to apply in a subsequent operation so you can pick
        /// up where you left off. Also, if the processed dataset size exceeds 1 MB before DynamoDB
        /// reaches this limit, it stops the operation and returns the matching values up to the
        /// limit, and a key in <c>LastEvaluatedKey</c> to apply in a subsequent operation to
        /// continue the operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Set this value to get remaining results, if <c>NextToken</c> was returned in the statement
        /// response.
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
        /// The parameters for the PartiQL statement, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this._returnConsumedCapacity; }
            set { this._returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this._returnConsumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnValuesOnConditionCheckFailure. 
        /// <para>
        /// An optional parameter that returns the item attributes for an <c>ExecuteStatement</c>
        /// operation that failed a condition check.
        /// </para>
        ///  
        /// <para>
        /// There is no additional cost associated with requesting a return value aside from the
        /// small network and processing overhead of receiving a larger response. No read capacity
        /// units are consumed.
        /// </para>
        /// </summary>
        public ReturnValuesOnConditionCheckFailure ReturnValuesOnConditionCheckFailure
        {
            get { return this._returnValuesOnConditionCheckFailure; }
            set { this._returnValuesOnConditionCheckFailure = value; }
        }

        // Check to see if ReturnValuesOnConditionCheckFailure property is set
        internal bool IsSetReturnValuesOnConditionCheckFailure()
        {
            return this._returnValuesOnConditionCheckFailure != null;
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// The PartiQL statement representing the operation to run.
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