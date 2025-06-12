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
    /// Container for the parameters to the PutItem operation.
    /// Creates a new item, or replaces an old item with a new item. If an item that has the
    /// same primary key as the new item already exists in the specified table, the new item
    /// completely replaces the existing item. You can perform a conditional put operation
    /// (add a new item if one with the specified primary key doesn't exist), or replace an
    /// existing item if it has certain attribute values. You can return the item's attribute
    /// values in the same operation, using the <c>ReturnValues</c> parameter.
    /// 
    ///  
    /// <para>
    /// When you add an item, the primary key attributes are the only required attributes.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Empty String and Binary attribute values are allowed. Attribute values of type String
    /// and Binary must have a length greater than zero if the attribute is used as a key
    /// attribute for a table or index. Set type attributes cannot be empty. 
    /// </para>
    ///  
    /// <para>
    /// Invalid Requests with empty values will be rejected with a <c>ValidationException</c>
    /// exception.
    /// </para>
    ///  <note> 
    /// <para>
    /// To prevent a new item from replacing an existing item, use a conditional expression
    /// that contains the <c>attribute_not_exists</c> function with the name of the attribute
    /// being used as the partition key for the table. Since every record must contain that
    /// attribute, the <c>attribute_not_exists</c> function will only succeed if no matching
    /// item exists.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about <c>PutItem</c>, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
    /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutItemRequest : AmazonDynamoDBRequest
    {
        private ConditionalOperator _conditionalOperator;
        private string _conditionExpression;
        private Dictionary<string, ExpectedAttributeValue> _expected = AWSConfigs.InitializeCollections ? new Dictionary<string, ExpectedAttributeValue>() : null;
        private Dictionary<string, string> _expressionAttributeNames = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, AttributeValue> _expressionAttributeValues = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private Dictionary<string, AttributeValue> _item = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private ReturnItemCollectionMetrics _returnItemCollectionMetrics;
        private ReturnValue _returnValues;
        private ReturnValuesOnConditionCheckFailure _returnValuesOnConditionCheckFailure;
        private string _tableName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PutItemRequest() { }

        /// <summary>
        /// Instantiates PutItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide both values for both the partition key and the sort key. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. Empty String and Binary attribute values are allowed. Attribute values of type String and Binary must have a length greater than zero if the attribute is used as a key attribute for a table or index. For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.CoreComponents.html#HowItWorks.CoreComponents.PrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <c>Item</c> map is an <c>AttributeValue</c> object.</param>
        public PutItemRequest(string tableName, Dictionary<string, AttributeValue> item)
        {
            _tableName = tableName;
            _item = item;
        }

        /// <summary>
        /// Instantiates PutItemRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide both values for both the partition key and the sort key. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. Empty String and Binary attribute values are allowed. Attribute values of type String and Binary must have a length greater than zero if the attribute is used as a key attribute for a table or index. For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.CoreComponents.html#HowItWorks.CoreComponents.PrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <c>Item</c> map is an <c>AttributeValue</c> object.</param>
        /// <param name="returnValues">Use <c>ReturnValues</c> if you want to get the item attributes as they appeared before they were updated with the <c>PutItem</c> request. For <c>PutItem</c>, the valid values are: <ul> <li>  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This setting is the default for <c>ReturnValues</c>.) </li> <li>  <c>ALL_OLD</c> - If <c>PutItem</c> overwrote an attribute name-value pair, then the content of the old item is returned. </li> </ul> The values returned are strongly consistent. There is no additional cost associated with requesting a return value aside from the small network and processing overhead of receiving a larger response. No read capacity units are consumed. <note> The <c>ReturnValues</c> parameter is used by several DynamoDB operations; however, <c>PutItem</c> does not recognize any values other than <c>NONE</c> or <c>ALL_OLD</c>. </note></param>
        public PutItemRequest(string tableName, Dictionary<string, AttributeValue> item, ReturnValue returnValues)
        {
            _tableName = tableName;
            _item = item;
            _returnValues = returnValues;
        }

        /// <summary>
        /// Gets and sets the property ConditionalOperator. 
        /// <para>
        /// This is a legacy parameter. Use <c>ConditionExpression</c> instead. For more information,
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
        /// Gets and sets the property ConditionExpression. 
        /// <para>
        /// A condition that must be satisfied in order for a conditional <c>PutItem</c> operation
        /// to succeed.
        /// </para>
        ///  
        /// <para>
        /// An expression can contain any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Functions: <c>attribute_exists | attribute_not_exists | attribute_type | contains
        /// | begins_with | size</c> 
        /// </para>
        ///  
        /// <para>
        /// These function names are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Comparison operators: <c>= | &lt;&gt; | &lt; | &gt; | &lt;= | &gt;= | BETWEEN | IN
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Logical operators: <c>AND | OR | NOT</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on condition expressions, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.SpecifyingConditions.html">Condition
        /// Expressions</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ConditionExpression
        {
            get { return this._conditionExpression; }
            set { this._conditionExpression = value; }
        }

        // Check to see if ConditionExpression property is set
        internal bool IsSetConditionExpression()
        {
            return this._conditionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Expected. 
        /// <para>
        /// This is a legacy parameter. Use <c>ConditionExpression</c> instead. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.Expected.html">Expected</a>
        /// in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ExpectedAttributeValue> Expected
        {
            get { return this._expected; }
            set { this._expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this._expected != null && (this._expected.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// For more information on expression attribute values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.SpecifyingConditions.html">Condition
        /// Expressions</a> in the <i>Amazon DynamoDB Developer Guide</i>.
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
        /// Gets and sets the property Item. 
        /// <para>
        /// A map of attribute name/value pairs, one for each attribute. Only the primary key
        /// attributes are required; you can optionally provide other attribute name-value pairs
        /// for the item.
        /// </para>
        ///  
        /// <para>
        /// You must provide all of the attributes for the primary key. For example, with a simple
        /// primary key, you only need to provide a value for the partition key. For a composite
        /// primary key, you must provide both values for both the partition key and the sort
        /// key.
        /// </para>
        ///  
        /// <para>
        /// If you specify any attributes that are part of an index key, then the data types for
        /// those attributes must match those of the schema in the table's attribute definition.
        /// </para>
        ///  
        /// <para>
        /// Empty String and Binary attribute values are allowed. Attribute values of type String
        /// and Binary must have a length greater than zero if the attribute is used as a key
        /// attribute for a table or index.
        /// </para>
        ///  
        /// <para>
        /// For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.CoreComponents.html#HowItWorks.CoreComponents.PrimaryKey">Primary
        /// Key</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each element in the <c>Item</c> map is an <c>AttributeValue</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, AttributeValue> Item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this._item != null && (this._item.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ReturnItemCollectionMetrics. 
        /// <para>
        /// Determines whether item collection metrics are returned. If set to <c>SIZE</c>, the
        /// response includes statistics about item collections, if any, that were modified during
        /// the operation are returned in the response. If set to <c>NONE</c> (the default), no
        /// statistics are returned.
        /// </para>
        /// </summary>
        public ReturnItemCollectionMetrics ReturnItemCollectionMetrics
        {
            get { return this._returnItemCollectionMetrics; }
            set { this._returnItemCollectionMetrics = value; }
        }

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this._returnItemCollectionMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnValues. 
        /// <para>
        /// Use <c>ReturnValues</c> if you want to get the item attributes as they appeared before
        /// they were updated with the <c>PutItem</c> request. For <c>PutItem</c>, the valid values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>,
        /// then nothing is returned. (This setting is the default for <c>ReturnValues</c>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL_OLD</c> - If <c>PutItem</c> overwrote an attribute name-value pair, then the
        /// content of the old item is returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The values returned are strongly consistent.
        /// </para>
        ///  
        /// <para>
        /// There is no additional cost associated with requesting a return value aside from the
        /// small network and processing overhead of receiving a larger response. No read capacity
        /// units are consumed.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>ReturnValues</c> parameter is used by several DynamoDB operations; however,
        /// <c>PutItem</c> does not recognize any values other than <c>NONE</c> or <c>ALL_OLD</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ReturnValue ReturnValues
        {
            get { return this._returnValues; }
            set { this._returnValues = value; }
        }

        // Check to see if ReturnValues property is set
        internal bool IsSetReturnValues()
        {
            return this._returnValues != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnValuesOnConditionCheckFailure. 
        /// <para>
        /// An optional parameter that returns the item attributes for a <c>PutItem</c> operation
        /// that failed a condition check.
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to contain the item. You can also provide the Amazon Resource
        /// Name (ARN) of the table in this parameter.
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