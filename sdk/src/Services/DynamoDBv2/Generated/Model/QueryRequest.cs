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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the Query operation.
    /// A <i>Query</i> operation directly accesses items from a table using the table primary
    /// key, or from an index using the index key. You must provide a specific hash key value.
    /// You can narrow the scope of the query by using comparison operators on the range key
    /// value, or on the index key. You can use the <i>ScanIndexForward</i> parameter to get
    /// results in forward or reverse order, by range key or by index key. 
    /// 
    ///  
    /// <para>
    /// Queries that do not return results consume the minimum number of read capacity units
    /// for that type of read operation.
    /// </para>
    ///  
    /// <para>
    /// If the total number of items meeting the query criteria exceeds the result set size
    /// limit of 1 MB, the query stops and results are returned to the user with <i>LastEvaluatedKey</i>
    /// to continue the query in a subsequent operation. Unlike a <i>Scan</i> operation, a
    /// <i>Query</i> operation never returns both an empty result set and a <i>LastEvaluatedKey</i>.
    /// The <i>LastEvaluatedKey</i> is only provided if the results exceed 1 MB, or if you
    /// have used <i>Limit</i>. 
    /// </para>
    ///  
    /// <para>
    /// You can query a table, a local secondary index, or a global secondary index. For a
    /// query on a table or on a local secondary index, you can set <i>ConsistentRead</i>
    /// to true and obtain a strongly consistent result. Global secondary indexes support
    /// eventually consistent reads only, so do not specify <i>ConsistentRead</i> when querying
    /// a global secondary index.
    /// </para>
    /// </summary>
    public partial class QueryRequest : AmazonDynamoDBRequest
    {
        private List<string> _attributesToGet = new List<string>();
        private ConditionalOperator _conditionalOperator;
        private bool? _consistentRead;
        private Dictionary<string, AttributeValue> _exclusiveStartKey = new Dictionary<string, AttributeValue>();
        private Dictionary<string, string> _expressionAttributeNames = new Dictionary<string, string>();
        private Dictionary<string, AttributeValue> _expressionAttributeValues = new Dictionary<string, AttributeValue>();
        private string _filterExpression;
        private string _indexName;
        private Dictionary<string, Condition> _keyConditions = new Dictionary<string, Condition>();
        private int? _limit;
        private string _projectionExpression;
        private Dictionary<string, Condition> _queryFilter = new Dictionary<string, Condition>();
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
        /// <param name="tableName">The name of the table containing the requested items. </param>
        public QueryRequest(string tableName)
        {
            _tableName = tableName;
        }

        /// <summary>
        /// Gets and sets the property AttributesToGet. <important>
        /// <para>
        /// There is a newer parameter available. Use <i>ProjectionExpression</i> instead. Note
        /// that if you use <i>AttributesToGet</i> and <i>ProjectionExpression</i> at the same
        /// time, DynamoDB will return a <i>ValidationException</i> exception.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows you to retrieve attributes of type List or Map; however, it
        /// cannot retrieve individual elements within a List or a Map.
        /// </para>
        /// </important> 
        /// <para>
        /// The names of one or more attributes to retrieve. If no attribute names are provided,
        /// then all attributes will be returned. If any of the requested attributes are not found,
        /// they will not appear in the result.
        /// </para>
        ///  
        /// <para>
        /// Note that <i>AttributesToGet</i> has no effect on provisioned throughput consumption.
        /// DynamoDB determines capacity units consumed based on item size, not on the amount
        /// of data that is returned to an application.
        /// </para>
        ///  
        /// <para>
        /// You cannot use both <i>AttributesToGet</i> and <i>Select</i> together in a <i>Query</i>
        /// request, <i>unless</i> the value for <i>Select</i> is <code>SPECIFIC_ATTRIBUTES</code>.
        /// (This usage is equivalent to specifying <i>AttributesToGet</i> without any value for
        /// <i>Select</i>.)
        /// </para>
        ///  
        /// <para>
        /// If you query a local secondary index and request only attributes that are projected
        /// into that index, the operation will read only the index and not the table. If any
        /// of the requested attributes are not projected into the local secondary index, DynamoDB
        /// will fetch each of these attributes from the parent table. This extra fetching incurs
        /// additional throughput cost and latency.
        /// </para>
        ///  
        /// <para>
        /// If you query a global secondary index, you can only request attributes that are projected
        /// into the index. Global secondary index queries cannot fetch attributes from the parent
        /// table.
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && this._attributesToGet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConditionalOperator. 
        /// <para>
        /// A logical operator to apply to the conditions in a <i>QueryFilter</i> map:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>AND</code> - If all of the conditions evaluate to true, then the entire map
        /// evaluates to true.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>OR</code> - If at least one of the conditions evaluate to true, then the entire
        /// map evaluates to true.
        /// </para>
        /// </li> </ul> 
        /// <para>
        /// If you omit <i>ConditionalOperator</i>, then <code>AND</code> is the default.
        /// </para>
        ///  
        /// <para>
        /// The operation will succeed only if the entire map evaluates to true.
        /// </para>
        ///  <note>
        /// <para>
        /// This parameter does not support attributes of type List or Map.
        /// </para>
        /// </note>
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
        /// A value that if set to <code>true</code>, then the operation uses strongly consistent
        /// reads; otherwise, eventually consistent reads are used.
        /// </para>
        ///  
        /// <para>
        /// Strongly consistent reads are not supported on global secondary indexes. If you query
        /// a global secondary index with <i>ConsistentRead</i> set to <code>true</code>, you
        /// will receive an error message.
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
        /// Gets and sets the property ExclusiveStartKey. 
        /// <para>
        /// The primary key of the first item that this operation will evaluate. Use the value
        /// that was returned for <i>LastEvaluatedKey</i> in the previous operation.
        /// </para>
        ///  
        /// <para>
        /// The data type for <i>ExclusiveStartKey</i> must be String, Number or Binary. No set
        /// data types are allowed.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> ExclusiveStartKey
        {
            get { return this._exclusiveStartKey; }
            set { this._exclusiveStartKey = value; }
        }

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this._exclusiveStartKey != null && this._exclusiveStartKey.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExpressionAttributeNames. 
        /// <para>
        /// One or more substitution tokens for attribute names in an expression. The following
        /// are some use cases for using <i>ExpressionAttributeNames</i>:
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
        ///  <ul><li>
        /// <para>
        /// <code>Percentile</code>
        /// </para>
        /// </li></ul> 
        /// <para>
        /// The name of this attribute conflicts with a reserved word, so it cannot be used directly
        /// in an expression. (For the complete list of reserved words, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ReservedWords.html">Reserved
        /// Words</a> in the <i>Amazon DynamoDB Developer Guide</i>). To work around this, you
        /// could specify the following for <i>ExpressionAttributeNames</i>:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// <code>{"#P":"Percentile"}</code>
        /// </para>
        /// </li></ul> 
        /// <para>
        /// You could then use this substitution in an expression, as in this example:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// <code>#P = :val</code>
        /// </para>
        /// </li></ul> <note>
        /// <para>
        /// Tokens that begin with the <b>:</b> character are <i>expression attribute values</i>,
        /// which are placeholders for the actual value at runtime.
        /// </para>
        /// </note> 
        /// <para>
        /// For more information on expression attribute names, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing
        /// Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ExpressionAttributeNames
        {
            get { return this._expressionAttributeNames; }
            set { this._expressionAttributeNames = value; }
        }

        // Check to see if ExpressionAttributeNames property is set
        internal bool IsSetExpressionAttributeNames()
        {
            return this._expressionAttributeNames != null && this._expressionAttributeNames.Count > 0; 
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
        /// <code>Available | Backordered | Discontinued</code>
        /// </para>
        ///  
        /// <para>
        /// You would first need to specify <i>ExpressionAttributeValues</i> as follows:
        /// </para>
        ///  
        /// <para>
        /// <code>{ ":avail":{"S":"Available"}, ":back":{"S":"Backordered"}, ":disc":{"S":"Discontinued"}
        /// }</code>
        /// </para>
        ///  
        /// <para>
        /// You could then use these values in an expression, such as this:
        /// </para>
        ///  
        /// <para>
        /// <code>ProductStatus IN (:avail, :back, :disc)</code>
        /// </para>
        ///  
        /// <para>
        /// For more information on expression attribute values, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.SpecifyingConditions.html">Specifying
        /// Conditions</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> ExpressionAttributeValues
        {
            get { return this._expressionAttributeValues; }
            set { this._expressionAttributeValues = value; }
        }

        // Check to see if ExpressionAttributeValues property is set
        internal bool IsSetExpressionAttributeValues()
        {
            return this._expressionAttributeValues != null && this._expressionAttributeValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// A string that contains conditions that DynamoDB applies after the <i>Query</i> operation,
        /// but before the data is returned to you. Items that do not satisfy the <i>FilterExpression</i>
        /// criteria are not returned.
        /// </para>
        ///  <note>
        /// <para>
        /// A <i>FilterExpression</i> is applied after the items have already been read; the process
        /// of filtering does not consume any additional read capacity units.
        /// </para>
        /// </note> 
        /// <para>
        /// For more information, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html#FilteringResults">Filter
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
        /// secondary index on the table.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property KeyConditions. 
        /// <para>
        /// The selection criteria for the query. For a query on a table, you can have conditions
        /// only on the table primary key attributes. You must provide the hash key attribute
        /// name and value as an <code>EQ</code> condition. You can optionally provide a second
        /// condition, referring to the range key attribute.
        /// </para>
        ///  <note>
        /// <para>
        /// If you do not provide a range key condition, all of the items that match the hash
        /// key will be retrieved. If a <i>FilterExpression</i> or <i>QueryFilter</i> is present,
        /// it will be applied after the items are retrieved.
        /// </para>
        /// </note> 
        /// <para>
        /// For a query on an index, you can have conditions only on the index key attributes.
        /// You must provide the index hash attribute name and value as an EQ condition. You can
        /// optionally provide a second condition, referring to the index key range attribute.
        /// </para>
        ///  
        /// <para>
        /// Each <i>KeyConditions</i> element consists of an attribute name to compare, along
        /// with the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute.
        /// The number of values in the list depends on the <i>ComparisonOperator</i> being used.
        /// </para>
        ///  
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///  
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        /// character code values. For example, <code>a</code> is greater than <code>A</code>,
        /// and <code>a</code> is greater than <code>B</code>. For a list of code values, see
        /// <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///  
        /// <para>
        /// For Binary, DynamoDB treats each byte of the binary data as unsigned when it compares
        /// binary values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <i>ComparisonOperator</i> - A comparator for evaluating attributes, for example, equals,
        /// greater than, less than, and so on.
        /// </para>
        ///  
        /// <para>
        /// For <i>KeyConditions</i>, only the following comparison operators are supported:
        /// </para>
        ///  
        /// <para>
        ///  <code>EQ | LE | LT | GE | GT | BEGINS_WITH | BETWEEN</code> 
        /// </para>
        ///  
        /// <para>
        /// The following are descriptions of these comparison operators.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>EQ</code> : Equal. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        /// Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i> element
        /// of a different type than the one specified in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code>
        /// does not equal <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  
        /// <para>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>LE</code> : Less than or equal. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>LT</code> : Less than. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String,
        /// Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i> element
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>. Also, <code>{"N":"6"}</code>
        /// does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>GE</code> : Greater than or equal. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>GT</code> : Greater than. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> element of type
        /// String, Number, or Binary (not a set type). If an item contains an <i>AttributeValue</i>
        /// element of a different type than the one provided in the request, the value does not
        /// match. For example, <code>{"S":"6"}</code> does not equal <code>{"N":"6"}</code>.
        /// Also, <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>.
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>BEGINS_WITH</code> : Checks for a prefix. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String
        /// or Binary (not a Number or a set type). The target attribute of the comparison must
        /// be of type String or Binary (not a Number or a set type).
        /// </para>
        ///  <p/> </li> <li> 
        /// <para>
        /// <code>BETWEEN</code> : Greater than or equal to the first value, and less than or
        /// equal to the second value. 
        /// </para>
        ///  
        /// <para>
        /// <i>AttributeValueList</i> must contain two <i>AttributeValue</i> elements of the same
        /// type, either String, Number, or Binary (not a set type). A target attribute matches
        /// if the target value is greater than, or equal to, the first element and less than,
        /// or equal to, the second element. If an item contains an <i>AttributeValue</i> element
        /// of a different type than the one provided in the request, the value does not match.
        /// For example, <code>{"S":"6"}</code> does not compare to <code>{"N":"6"}</code>. Also,
        /// <code>{"N":"6"}</code> does not compare to <code>{"NS":["6", "2", "1"]}</code>
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For usage examples of <i>AttributeValueList</i> and <i>ComparisonOperator</i>, see
        /// <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.html">Legacy
        /// Conditional Parameters</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, Condition> KeyConditions
        {
            get { return this._keyConditions; }
            set { this._keyConditions = value; }
        }

        // Check to see if KeyConditions property is set
        internal bool IsSetKeyConditions()
        {
            return this._keyConditions != null && this._keyConditions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to evaluate (not necessarily the number of matching items).
        /// If DynamoDB processes the number of items up to the limit while processing the results,
        /// it stops the operation and returns the matching values up to that point, and a key
        /// in <i>LastEvaluatedKey</i> to apply in a subsequent operation, so that you can pick
        /// up where you left off. Also, if the processed data set size exceeds 1 MB before DynamoDB
        /// reaches this limit, it stops the operation and returns the matching values up to the
        /// limit, and a key in <i>LastEvaluatedKey</i> to apply in a subsequent operation to
        /// continue the operation. For more information, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html"
        /// >Query and Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
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
        /// For more information, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing
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
        /// Gets and sets the property QueryFilter. <important> 
        /// <para>
        /// There is a newer parameter available. Use <i>FilterExpression</i> instead. Note that
        /// if you use <i>QueryFilter</i> and <i>FilterExpression</i> at the same time, DynamoDB
        /// will return a <i>ValidationException</i> exception.
        /// </para>
        ///  </important> 
        /// <para>
        /// A condition that evaluates the query results after the items are read and returns
        /// only the desired values.
        /// </para>
        ///  
        /// <para>
        /// This parameter does not support attributes of type List or Map.
        /// </para>
        ///  <note>
        /// <para>
        /// A <i>QueryFilter</i> is applied after the items have already been read; the process
        /// of filtering does not consume any additional read capacity units.
        /// </para>
        /// </note> 
        /// <para>
        /// If you provide more than one condition in the <i>QueryFilter</i> map, then by default
        /// all of the conditions must evaluate to true. In other words, the conditions are ANDed
        /// together. (You can use the <i>ConditionalOperator</i> parameter to OR the conditions
        /// instead. If you do this, then at least one of the conditions must evaluate to true,
        /// rather than all of them.)
        /// </para>
        ///  
        /// <para>
        /// Note that <i>QueryFilter</i> does not allow key attributes. You cannot define a filter
        /// condition on a hash key or range key.
        /// </para>
        ///  
        /// <para>
        /// Each <i>QueryFilter</i> element consists of an attribute name to compare, along with
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute.
        /// The number of values in the list depends on the operator specified in <i>ComparisonOperator</i>.
        /// </para>
        ///  
        /// <para>
        /// For type Number, value comparisons are numeric.
        /// </para>
        ///  
        /// <para>
        /// String value comparisons for greater than, equals, or less than are based on ASCII
        /// character code values. For example, <code>a</code> is greater than <code>A</code>,
        /// and <code>a</code> is greater than <code>B</code>. For a list of code values, see
        /// <a href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>.
        /// </para>
        ///  
        /// <para>
        /// For type Binary, DynamoDB treats each byte of the binary data as unsigned when it
        /// compares binary values.
        /// </para>
        ///  
        /// <para>
        /// For information on specifying data types in JSON, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON
        /// Data Format</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <i>ComparisonOperator</i> - A comparator for evaluating attributes. For example, equals,
        /// greater than, less than, etc.
        /// </para>
        ///  
        /// <para>
        /// The following comparison operators are available:
        /// </para>
        ///  
        /// <para>
        /// <code>EQ | NE | LE | LT | GE | GT | NOT_NULL | NULL | CONTAINS | NOT_CONTAINS | BEGINS_WITH
        /// | IN | BETWEEN</code>
        /// </para>
        ///  
        /// <para>
        /// For complete descriptions of all comparison operators, see the <a href="http://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_Condition.html">Condition</a>
        /// data type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, Condition> QueryFilter
        {
            get { return this._queryFilter; }
            set { this._queryFilter = value; }
        }

        // Check to see if QueryFilter property is set
        internal bool IsSetQueryFilter()
        {
            return this._queryFilter != null && this._queryFilter.Count > 0; 
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
        /// A value that specifies ascending (true) or descending (false) traversal of the index.
        /// DynamoDB returns results reflecting the requested order determined by the range key.
        /// If the data type is Number, the results are returned in numeric order. For type String,
        /// the results are returned in order of ASCII character code values. For type Binary,
        /// DynamoDB treats each byte of the binary data as unsigned when it compares binary values.
        /// </para>
        ///  
        /// <para>
        /// If <i>ScanIndexForward</i> is not specified, the results are returned in ascending
        /// order.
        /// </para>
        /// </summary>
        public bool ScanIndexForward
        {
            get { return this._scanIndexForward.GetValueOrDefault(); }
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
        /// <code>ALL_ATTRIBUTES</code> - Returns all of the item attributes from the specified
        /// table or index. If you query a local secondary index, then for each matching item
        /// in the index DynamoDB will fetch the entire item from the parent table. If the index
        /// is configured to project all item attributes, then all of the data can be obtained
        /// from the local secondary index, and no fetching is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>ALL_PROJECTED_ATTRIBUTES</code> - Allowed only when querying an index. Retrieves
        /// all attributes that have been projected into the index. If the index is configured
        /// to project all attributes, this return value is equivalent to specifying <code>ALL_ATTRIBUTES</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>COUNT</code> - Returns the number of matching items, rather than the matching
        /// items themselves.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SPECIFIC_ATTRIBUTES</code> - Returns only the attributes listed in <i>AttributesToGet</i>.
        /// This return value is equivalent to specifying <i>AttributesToGet</i> without specifying
        /// any value for <i>Select</i>.
        /// </para>
        ///  
        /// <para>
        /// If you query a local secondary index and request only attributes that are projected
        /// into that index, the operation will read only the index and not the table. If any
        /// of the requested attributes are not projected into the local secondary index, DynamoDB
        /// will fetch each of these attributes from the parent table. This extra fetching incurs
        /// additional throughput cost and latency.
        /// </para>
        ///  
        /// <para>
        /// If you query a global secondary index, you can only request attributes that are projected
        /// into the index. Global secondary index queries cannot fetch attributes from the parent
        /// table.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If neither <i>Select</i> nor <i>AttributesToGet</i> are specified, DynamoDB defaults
        /// to <code>ALL_ATTRIBUTES</code> when accessing a table, and <code>ALL_PROJECTED_ATTRIBUTES</code>
        /// when accessing an index. You cannot use both <i>Select</i> and <i>AttributesToGet</i>
        /// together in a single request, unless the value for <i>Select</i> is <code>SPECIFIC_ATTRIBUTES</code>.
        /// (This usage is equivalent to specifying <i>AttributesToGet</i> without any value for
        /// <i>Select</i>.)
        /// </para>
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
        /// The name of the table containing the requested items. 
        /// </para>
        /// </summary>
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