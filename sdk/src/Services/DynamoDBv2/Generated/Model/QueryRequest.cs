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
    /// Container for the parameters to the Query operation.
    /// You must provide the name of the partition key attribute and a single value for that
    /// attribute. <c>Query</c> returns all items with that partition key value. Optionally,
    /// you can provide a sort key attribute and use a comparison operator to refine the search
    /// results.
    /// 
    ///  
    /// <para>
    /// Use the <c>KeyConditionExpression</c> parameter to provide a specific value for the
    /// partition key. The <c>Query</c> operation will return all of the items from the table
    /// or index with that partition key value. You can optionally narrow the scope of the
    /// <c>Query</c> operation by specifying a sort key value and a comparison operator in
    /// <c>KeyConditionExpression</c>. To further refine the <c>Query</c> results, you can
    /// optionally provide a <c>FilterExpression</c>. A <c>FilterExpression</c> determines
    /// which items within the results should be returned to you. All of the other results
    /// are discarded. 
    /// </para>
    ///  
    /// <para>
    ///  A <c>Query</c> operation always returns a result set. If no matching items are found,
    /// the result set will be empty. Queries that do not return results consume the minimum
    /// number of read capacity units for that type of read operation. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  DynamoDB calculates the number of read capacity units consumed based on item size,
    /// not on the amount of data that is returned to an application. The number of capacity
    /// units consumed will be the same whether you request all of the attributes (the default
    /// behavior) or just some of them (using a projection expression). The number will also
    /// be the same whether or not you use a <c>FilterExpression</c>. 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <c>Query</c> results are always sorted by the sort key value. If the data type of
    /// the sort key is Number, the results are returned in numeric order; otherwise, the
    /// results are returned in order of UTF-8 bytes. By default, the sort order is ascending.
    /// To reverse the order, set the <c>ScanIndexForward</c> parameter to false. 
    /// </para>
    ///  
    /// <para>
    ///  A single <c>Query</c> operation will read up to the maximum number of items set (if
    /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then apply any
    /// filtering to the results using <c>FilterExpression</c>. If <c>LastEvaluatedKey</c>
    /// is present in the response, you will need to paginate the result set. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Query.html#Query.Pagination">Paginating
    /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <c>FilterExpression</c> is applied after a <c>Query</c> finishes, but before the
    /// results are returned. A <c>FilterExpression</c> cannot contain partition key or sort
    /// key attributes. You need to specify those attributes in the <c>KeyConditionExpression</c>.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    ///  A <c>Query</c> operation can return an empty result set and a <c>LastEvaluatedKey</c>
    /// if all the items read for the page of results are filtered out. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You can query a table, a local secondary index, or a global secondary index. For a
    /// query on a table or on a local secondary index, you can set the <c>ConsistentRead</c>
    /// parameter to <c>true</c> and obtain a strongly consistent result. Global secondary
    /// indexes support eventually consistent reads only, so do not specify <c>ConsistentRead</c>
    /// when querying a global secondary index.
    /// </para>
    /// </summary>
    public partial class QueryRequest : AmazonDynamoDBRequest
    {
        private List<string> _attributesToGet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConditionalOperator _conditionalOperator;
        private bool? _consistentRead;
        private Dictionary<string, AttributeValue> _exclusiveStartKey = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private Dictionary<string, string> _expressionAttributeNames = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, AttributeValue> _expressionAttributeValues = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private string _filterExpression;
        private string _indexName;
        private string _keyConditionExpression;
        private Dictionary<string, Condition> _keyConditions = AWSConfigs.InitializeCollections ? new Dictionary<string, Condition>() : null;
        private int? _limit;
        private string _projectionExpression;
        private Dictionary<string, Condition> _queryFilter = AWSConfigs.InitializeCollections ? new Dictionary<string, Condition>() : null;
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private bool? _scanIndexForward;
        private Select _select;
        private string _tableName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public QueryRequest() { }

        /// <summary>
        /// Instantiates QueryRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        public QueryRequest(string tableName)
        {
            _tableName = tableName;
        }

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a>
        /// in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && (this._attributesToGet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConditionalOperator. 
        /// <para>
        /// This is a legacy parameter. Use <c>FilterExpression</c> instead. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.ConditionalOperator.html">ConditionalOperator</a>
        /// in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public ConditionalOperator ConditionalOperator
        {
            get { return this._conditionalOperator; }
            set { this._conditionalOperator = value; }
        }

        // Check to see if ConditionalOperator property is set
        internal bool IsSetConditionalOperator()
        {
            return this._conditionalOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ConsistentRead. 
        /// <para>
        /// Determines the read consistency model: If set to <c>true</c>, then the operation uses
        /// strongly consistent reads; otherwise, the operation uses eventually consistent reads.
        /// </para>
        ///  
        /// <para>
        /// Strongly consistent reads are not supported on global secondary indexes. If you query
        /// a global secondary index with <c>ConsistentRead</c> set to <c>true</c>, you will receive
        /// a <c>ValidationException</c>.
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
        /// Gets and sets the property ExclusiveStartKey. 
        /// <para>
        /// The primary key of the first item that this operation will evaluate. Use the value
        /// that was returned for <c>LastEvaluatedKey</c> in the previous operation.
        /// </para>
        ///  
        /// <para>
        /// The data type for <c>ExclusiveStartKey</c> must be String, Number, or Binary. No set
        /// data types are allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> ExclusiveStartKey
        {
            get { return this._exclusiveStartKey; }
            set { this._exclusiveStartKey = value; }
        }

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this._exclusiveStartKey != null && (this._exclusiveStartKey.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpressionAttributeNames. 
        /// <para>
        /// One or more substitution tokens for attribute names in an expression. The following
        /// are some use cases for using <c>ExpressionAttributeNames</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To access an attribute whose name conflicts with a DynamoDB reserved word.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a placeholder for repeating occurrences of an attribute name in an expression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To prevent special characters in an attribute name from being misinterpreted in an
        /// expression.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the <b>#</b> character in an expression to dereference an attribute name. For
        /// example, consider the following attribute name:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Percentile</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The name of this attribute conflicts with a reserved word, so it cannot be used directly
        /// in an expression. (For the complete list of reserved words, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ReservedWords.html">Reserved
        /// Words</a> in the <i>Amazon DynamoDB Developer Guide</i>). To work around this, you
        /// could specify the following for <c>ExpressionAttributeNames</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>{"#P":"Percentile"}</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You could then use this substitution in an expression, as in this example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>#P = :val</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Tokens that begin with the <b>:</b> character are <i>expression attribute values</i>,
        /// which are placeholders for the actual value at runtime.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on expression attribute names, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Specifying
        /// Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ExpressionAttributeNames
        {
            get { return this._expressionAttributeNames; }
            set { this._expressionAttributeNames = value; }
        }

        // Check to see if ExpressionAttributeNames property is set
        internal bool IsSetExpressionAttributeNames()
        {
            return this._expressionAttributeNames != null && (this._expressionAttributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpressionAttributeValues. 
        /// <para>
        /// One or more values that can be substituted in an expression.
        /// </para>
        ///  
        /// <para>
        /// Use the <b>:</b> (colon) character in an expression to dereference an attribute value.
        /// For example, suppose that you wanted to check whether the value of the <i>ProductStatus</i>
        /// attribute was one of the following: 
        /// </para>
        ///  
        /// <para>
        ///  <c>Available | Backordered | Discontinued</c> 
        /// </para>
        ///  
        /// <para>
        /// You would first need to specify <c>ExpressionAttributeValues</c> as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ ":avail":{"S":"Available"}, ":back":{"S":"Backordered"}, ":disc":{"S":"Discontinued"}
        /// }</c> 
        /// </para>
        ///  
        /// <para>
        /// You could then use these values in an expression, such as this:
        /// </para>
        ///  
        /// <para>
        ///  <c>ProductStatus IN (:avail, :back, :disc)</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information on expression attribute values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.SpecifyingConditions.html">Specifying
        /// Conditions</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> ExpressionAttributeValues
        {
            get { return this._expressionAttributeValues; }
            set { this._expressionAttributeValues = value; }
        }

        // Check to see if ExpressionAttributeValues property is set
        internal bool IsSetExpressionAttributeValues()
        {
            return this._expressionAttributeValues != null && (this._expressionAttributeValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// A string that contains conditions that DynamoDB applies after the <c>Query</c> operation,
        /// but before the data is returned to you. Items that do not satisfy the <c>FilterExpression</c>
        /// criteria are not returned.
        /// </para>
        ///  
        /// <para>
        /// A <c>FilterExpression</c> does not allow key attributes. You cannot define a filter
        /// expression based on a partition key or a sort key.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <c>FilterExpression</c> is applied after the items have already been read; the process
        /// of filtering does not consume any additional read capacity units.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Query.FilterExpression.html">Filter
        /// Expressions</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public string FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of an index to query. This index can be any local secondary index or global
        /// secondary index on the table. Note that if you use the <c>IndexName</c> parameter,
        /// you must also provide <c>TableName.</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property KeyConditionExpression. 
        /// <para>
        /// The condition that specifies the key values for items to be retrieved by the <c>Query</c>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// The condition must perform an equality test on a single partition key value.
        /// </para>
        ///  
        /// <para>
        /// The condition can optionally perform one of several comparison tests on a single sort
        /// key value. This allows <c>Query</c> to retrieve one item with a given partition key
        /// value and sort key value, or several items that have the same partition key value
        /// but different sort key values.
        /// </para>
        ///  
        /// <para>
        /// The partition key equality test is required, and must be specified in the following
        /// format:
        /// </para>
        ///  
        /// <para>
        ///  <c>partitionKeyName</c> <i>=</i> <c>:partitionkeyval</c> 
        /// </para>
        ///  
        /// <para>
        /// If you also want to provide a condition for the sort key, it must be combined using
        /// <c>AND</c> with the condition for the sort key. Following is an example, using the
        /// <b>=</b> comparison operator for the sort key:
        /// </para>
        ///  
        /// <para>
        ///  <c>partitionKeyName</c> <c>=</c> <c>:partitionkeyval</c> <c>AND</c> <c>sortKeyName</c>
        /// <c>=</c> <c>:sortkeyval</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid comparisons for the sort key condition are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>sortKeyName</c> <c>=</c> <c>:sortkeyval</c> - true if the sort key value is equal
        /// to <c>:sortkeyval</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sortKeyName</c> <c>&lt;</c> <c>:sortkeyval</c> - true if the sort key value is
        /// less than <c>:sortkeyval</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sortKeyName</c> <c>&lt;=</c> <c>:sortkeyval</c> - true if the sort key value is
        /// less than or equal to <c>:sortkeyval</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sortKeyName</c> <c>&gt;</c> <c>:sortkeyval</c> - true if the sort key value is
        /// greater than <c>:sortkeyval</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sortKeyName</c> <c>&gt;= </c> <c>:sortkeyval</c> - true if the sort key value
        /// is greater than or equal to <c>:sortkeyval</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sortKeyName</c> <c>BETWEEN</c> <c>:sortkeyval1</c> <c>AND</c> <c>:sortkeyval2</c>
        /// - true if the sort key value is greater than or equal to <c>:sortkeyval1</c>, and
        /// less than or equal to <c>:sortkeyval2</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>begins_with (</c> <c>sortKeyName</c>, <c>:sortkeyval</c> <c>)</c> - true if the
        /// sort key value begins with a particular operand. (You cannot use this function with
        /// a sort key that is of type Number.) Note that the function name <c>begins_with</c>
        /// is case-sensitive.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use the <c>ExpressionAttributeValues</c> parameter to replace tokens such as <c>:partitionval</c>
        /// and <c>:sortval</c> with actual values at runtime.
        /// </para>
        ///  
        /// <para>
        /// You can optionally use the <c>ExpressionAttributeNames</c> parameter to replace the
        /// names of the partition key and sort key with placeholder tokens. This option might
        /// be necessary if an attribute name conflicts with a DynamoDB reserved word. For example,
        /// the following <c>KeyConditionExpression</c> parameter causes an error because <i>Size</i>
        /// is a reserved word:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Size = :myval</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To work around this, define a placeholder (such a <c>#S</c>) to represent the attribute
        /// name <i>Size</i>. <c>KeyConditionExpression</c> then is as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>#S = :myval</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a list of reserved words, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ReservedWords.html">Reserved
        /// Words</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information on <c>ExpressionAttributeNames</c> and <c>ExpressionAttributeValues</c>,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ExpressionPlaceholders.html">Using
        /// Placeholders for Attribute Names and Values</a> in the <i>Amazon DynamoDB Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string KeyConditionExpression
        {
            get { return this._keyConditionExpression; }
            set { this._keyConditionExpression = value; }
        }

        // Check to see if KeyConditionExpression property is set
        internal bool IsSetKeyConditionExpression()
        {
            return this._keyConditionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property KeyConditions. 
        /// <para>
        /// This is a legacy parameter. Use <c>KeyConditionExpression</c> instead. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.KeyConditions.html">KeyConditions</a>
        /// in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Condition> KeyConditions
        {
            get { return this._keyConditions; }
            set { this._keyConditions = value; }
        }

        // Check to see if KeyConditions property is set
        internal bool IsSetKeyConditions()
        {
            return this._keyConditions != null && (this._keyConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to evaluate (not necessarily the number of matching items).
        /// If DynamoDB processes the number of items up to the limit while processing the results,
        /// it stops the operation and returns the matching values up to that point, and a key
        /// in <c>LastEvaluatedKey</c> to apply in a subsequent operation, so that you can pick
        /// up where you left off. Also, if the processed dataset size exceeds 1 MB before DynamoDB
        /// reaches this limit, it stops the operation and returns the matching values up to the
        /// limit, and a key in <c>LastEvaluatedKey</c> to apply in a subsequent operation to
        /// continue the operation. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html">Query
        /// and Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="Limit"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="Limit"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsLimitSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._limit);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._limit);
            }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.IsLimitSet; 
        }

        /// <summary>
        /// Gets and sets the property ProjectionExpression. 
        /// <para>
        /// A string that identifies one or more attributes to retrieve from the table. These
        /// attributes can include scalars, sets, or elements of a JSON document. The attributes
        /// in the expression must be separated by commas.
        /// </para>
        ///  
        /// <para>
        /// If no attribute names are specified, then all attributes will be returned. If any
        /// of the requested attributes are not found, they will not appear in the result.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing
        /// Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ProjectionExpression
        {
            get { return this._projectionExpression; }
            set { this._projectionExpression = value; }
        }

        // Check to see if ProjectionExpression property is set
        internal bool IsSetProjectionExpression()
        {
            return this._projectionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property QueryFilter. 
        /// <para>
        /// This is a legacy parameter. Use <c>FilterExpression</c> instead. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.QueryFilter.html">QueryFilter</a>
        /// in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Condition> QueryFilter
        {
            get { return this._queryFilter; }
            set { this._queryFilter = value; }
        }

        // Check to see if QueryFilter property is set
        internal bool IsSetQueryFilter()
        {
            return this._queryFilter != null && (this._queryFilter.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ScanIndexForward. 
        /// <para>
        /// Specifies the order for index traversal: If <c>true</c> (default), the traversal is
        /// performed in ascending order; if <c>false</c>, the traversal is performed in descending
        /// order. 
        /// </para>
        ///  
        /// <para>
        /// Items with the same partition key value are stored in sorted order by sort key. If
        /// the sort key data type is Number, the results are stored in numeric order. For type
        /// String, the results are stored in order of UTF-8 bytes. For type Binary, DynamoDB
        /// treats each byte of the binary data as unsigned.
        /// </para>
        ///  
        /// <para>
        /// If <c>ScanIndexForward</c> is <c>true</c>, DynamoDB returns the results in the order
        /// in which they are stored (by sort key value). This is the default behavior. If <c>ScanIndexForward</c>
        /// is <c>false</c>, DynamoDB reads the results in reverse order by sort key value, and
        /// then returns the results to the client.
        /// </para>
        /// </summary>
        public bool? ScanIndexForward
        {
            get { return this._scanIndexForward; }
            set { this._scanIndexForward = value; }
        }

        // Check to see if ScanIndexForward property is set
        internal bool IsSetScanIndexForward()
        {
            return this._scanIndexForward.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Select. 
        /// <para>
        /// The attributes to be returned in the result. You can retrieve all item attributes,
        /// specific item attributes, the count of matching items, or in the case of an index,
        /// some or all of the attributes projected into the index.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_ATTRIBUTES</c> - Returns all of the item attributes from the specified table
        /// or index. If you query a local secondary index, then for each matching item in the
        /// index, DynamoDB fetches the entire item from the parent table. If the index is configured
        /// to project all item attributes, then all of the data can be obtained from the local
        /// secondary index, and no fetching is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL_PROJECTED_ATTRIBUTES</c> - Allowed only when querying an index. Retrieves
        /// all attributes that have been projected into the index. If the index is configured
        /// to project all attributes, this return value is equivalent to specifying <c>ALL_ATTRIBUTES</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COUNT</c> - Returns the number of matching items, rather than the matching items
        /// themselves. Note that this uses the same quantity of read capacity units as getting
        /// the items, and is subject to the same item size calculations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SPECIFIC_ATTRIBUTES</c> - Returns only the attributes listed in <c>ProjectionExpression</c>.
        /// This return value is equivalent to specifying <c>ProjectionExpression</c> without
        /// specifying any value for <c>Select</c>.
        /// </para>
        ///  
        /// <para>
        /// If you query or scan a local secondary index and request only attributes that are
        /// projected into that index, the operation will read only the index and not the table.
        /// If any of the requested attributes are not projected into the local secondary index,
        /// DynamoDB fetches each of these attributes from the parent table. This extra fetching
        /// incurs additional throughput cost and latency.
        /// </para>
        ///  
        /// <para>
        /// If you query or scan a global secondary index, you can only request attributes that
        /// are projected into the index. Global secondary index queries cannot fetch attributes
        /// from the parent table.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If neither <c>Select</c> nor <c>ProjectionExpression</c> are specified, DynamoDB defaults
        /// to <c>ALL_ATTRIBUTES</c> when accessing a table, and <c>ALL_PROJECTED_ATTRIBUTES</c>
        /// when accessing an index. You cannot use both <c>Select</c> and <c>ProjectionExpression</c>
        /// together in a single request, unless the value for <c>Select</c> is <c>SPECIFIC_ATTRIBUTES</c>.
        /// (This usage is equivalent to specifying <c>ProjectionExpression</c> without any value
        /// for <c>Select</c>.)
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the <c>ProjectionExpression</c> parameter, then the value for <c>Select</c>
        /// can only be <c>SPECIFIC_ATTRIBUTES</c>. Any other value for <c>Select</c> will return
        /// an error.
        /// </para>
        ///  </note>
        /// </summary>
        public Select Select
        {
            get { return this._select; }
            set { this._select = value; }
        }

        // Check to see if Select property is set
        internal bool IsSetSelect()
        {
            return this._select != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table containing the requested items. You can also provide the Amazon
        /// Resource Name (ARN) of the table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}