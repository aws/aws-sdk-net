/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>A <i>Query</i> operation directly accesses items from a table using the table primary key, or from an index using the index key. You
    /// must provide a specific hash key value. You can narrow the scope of the query by using comparison operators on the range key value, or on
    /// the index key. You can use the <i>ScanIndexForward</i> parameter to get results in forward or reverse order, by range key or by index key.
    /// </para> <para>Queries that do not return results consume the minimum read capacity units according to the type of read.</para> <para>If the
    /// total number of items meeting the query criteria exceeds the result set size limit of 1 MB, the query stops and results are returned to the
    /// user with a <i>LastEvaluatedKey</i> to continue the query in a subsequent operation. Unlike a <i>Scan</i> operation, a <i>Query</i>
    /// operation never returns an empty result set <i>and</i> a
    /// <i>LastEvaluatedKey</i> . The <i>LastEvaluatedKey</i> is only provided if the results exceed 1 MB, or if you have used
    /// <i>Limit</i> . </para> <para>To request a strongly consistent result, set <i>ConsistentRead</i> to true.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.Query"/>
    public class QueryRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private string indexName;
        private string select;
        private List<string> attributesToGet = new List<string>();
        private int? limit;
        private bool? consistentRead;
        private Dictionary<string,Condition> keyConditions = new Dictionary<string,Condition>();
        private bool? scanIndexForward;
        private Dictionary<string,AttributeValue> exclusiveStartKey = new Dictionary<string,AttributeValue>();
        private string returnConsumedCapacity;

        /// <summary>
        /// The name of the table containing the requested items.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this.tableName; }
            set { this.tableName = value; }
        }

        /// <summary>
        /// Sets the TableName property
        /// </summary>
        /// <param name="tableName">The value to set for the TableName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithTableName(string tableName)
        {
            this.tableName = tableName;
            return this;
        }
            

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;
        }

        /// <summary>
        /// The name of an index on the table to query.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string IndexName
        {
            get { return this.indexName; }
            set { this.indexName = value; }
        }

        /// <summary>
        /// Sets the IndexName property
        /// </summary>
        /// <param name="indexName">The value to set for the IndexName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithIndexName(string indexName)
        {
            this.indexName = indexName;
            return this;
        }
            

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this.indexName != null;
        }

        /// <summary>
        /// The attributes to be returned in the result. You can retrieve all item attributes, specific item attributes, the count of matching items, or
        /// in the case of an index, some or all of the attributes projected into the index. <ul> <li> <c>ALL_ATTRIBUTES</c>: Returns all of the item
        /// attributes. For a table, this is the default. For an index, this mode causes Amazon DynamoDB to fetch the full item from the table for each
        /// matching item in the index. If the index is configured to project all item attributes, the matching items will not be fetched from the
        /// table. Fetching items from the table incurs additional throughput cost and latency. </li> <li> <c>ALL_PROJECTED_ATTRIBUTES</c>: Allowed only
        /// when querying an index. Retrieves all attributes which have been projected into the index. If the index is configured to project all
        /// attributes, this is equivalent to specifying <i>ALL_ATTRIBUTES</i>. </li> <li> <c>COUNT</c>: Returns the number of matching items, rather
        /// than the matching items themselves. </li> <li> <c>SPECIFIC_ATTRIBUTES</c> : Returns only the attributes listed in <i>AttributesToGet</i>.
        /// This is equivalent to specifying <i>AttributesToGet</i> without specifying any value for <i>Select</i>. If you are querying an index and
        /// request only attributes that are projected into that index, the operation will read only the index and not the table. If any of the
        /// requested attributes are not projected into the index, Amazon DynamoDB will need to fetch each matching item from the table. This extra
        /// fetching incurs additional throughput cost and latency. </li> </ul> When neither <i>Select</i> nor <i>AttributesToGet</i> are specified,
        /// Amazon DynamoDB defaults to <c>ALL_ATTRIBUTES</c> when accessing a table, and <c>ALL_PROJECTED_ATTRIBUTES</c> when accessing an index. You
        /// cannot use both <i>Select</i> and <i>AttributesToGet</i> together in a single request, <i>unless</i> the value for <i>Select</i> is
        /// <c>SPECIFIC_ATTRIBUTES</c>. (This usage is equivalent to specifying <i>AttributesToGet</i> without any value for <i>Select</i>.)
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ALL_ATTRIBUTES, ALL_PROJECTED_ATTRIBUTES, SPECIFIC_ATTRIBUTES, COUNT</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Select
        {
            get { return this.select; }
            set { this.select = value; }
        }

        /// <summary>
        /// Sets the Select property
        /// </summary>
        /// <param name="select">The value to set for the Select property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithSelect(string select)
        {
            this.select = select;
            return this;
        }
            

        // Check to see if Select property is set
        internal bool IsSetSelect()
        {
            return this.select != null;
        }

        /// <summary>
        /// The names of one or more attributes to retrieve. If no attribute names are specified, then all attributes will be returned. If any of the
        /// requested attributes are not found, they will not appear in the result. If you are querying an index and request only attributes that are
        /// projected into that index, the operation will read only the index and not the table. If any of the requested attributes are not projected
        /// into the index, Amazon DynamoDB will need to fetch each matching item from the table. This extra fetching incurs additional throughput cost
        /// and latency. You cannot use both <i>AttributesToGet</i> and <i>Select</i> together in a <i>Query</i> request, <i>unless</i> the value for
        /// <i>Select</i> is <c>SPECIFIC_ATTRIBUTES</c>. (This usage is equivalent to specifying <i>AttributesToGet</i> without any value for
        /// <i>Select</i>.)
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this.attributesToGet; }
            set { this.attributesToGet = value; }
        }
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithAttributesToGet(params string[] attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithAttributesToGet(IEnumerable<string> attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;
        }

        /// <summary>
        /// The maximum number of items to evaluate (not necessarily the number of matching items). If Amazon DynamoDB processes the number of items up
        /// to the limit while processing the results, it stops the operation and returns the matching values up to that point, and a
        /// <i>LastEvaluatedKey</i> to apply in a subsequent operation, so that you can pick up where you left off. Also, if the processed data set size
        /// exceeds 1 MB before Amazon DynamoDB reaches this limit, it stops the operation and returns the matching values up to the limit, and a
        /// <i>LastEvaluatedKey</i> to apply in a subsequent operation to continue the operation. For more information see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html">Query and Scan</a> in the <i>Amazon DynamoDB
        /// Developer Guide</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithLimit(int limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

        /// <summary>
        /// If set to <c>true</c>, then the operation uses strongly consistent reads; otherwise, eventually consistent reads are used.
        ///  
        /// </summary>
        public bool ConsistentRead
        {
            get { return this.consistentRead ?? default(bool); }
            set { this.consistentRead = value; }
        }

        /// <summary>
        /// Sets the ConsistentRead property
        /// </summary>
        /// <param name="consistentRead">The value to set for the ConsistentRead property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithConsistentRead(bool consistentRead)
        {
            this.consistentRead = consistentRead;
            return this;
        }
            

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this.consistentRead.HasValue;
        }

        /// <summary>
        /// The selection criteria for the query. For a query on a table, you can only have conditions on the table primary key attributes. you must
        /// specify the hash key attribute name and value as an <c>EQ</c> condition. You can optionally specify a second condition, referring to the
        /// range key attribute. For a query on a secondary index, you can only have conditions on the index key attributes. You must specify the index
        /// hash attribute name and value as an EQ condition. You can optionally specify a second condition, referring to the index key range attribute.
        /// Multiple conditions are evaluated using "AND"; in other words, all of the conditions must be met in order for an item to appear in the
        /// results results. Each <i>KeyConditions</i> element consists of an attribute name to compare, along with the following: <ul>
        /// <li><i>AttributeValueList</i> - One or more values to evaluate against the supplied attribute. This list contains exactly one value, except
        /// for a <c>BETWEEN</c> or <c>IN</c> comparison, in which case the list contains two values. <note> For type Number, value comparisons are
        /// numeric. String value comparisons for greater than, equals, or less than are based on ASCII character code values. For example, <c>a</c> is
        /// greater than <c>A</c>, and <c>aa</c> is greater than <c>B</c>. For a list of code values, see <a
        /// href="http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters">http://en.wikipedia.org/wiki/ASCII#ASCII_printable_characters</a>. For
        /// Binary, Amazon DynamoDB treats each byte of the binary data as unsigned when it compares binary values, for example when evaluating query
        /// expressions. </note> </li> <li><i>ComparisonOperator</i> - A comparator for evaluating attributes. For example, equals, greater than, less
        /// than, etc. Valid comparison operators for Query: <c>EQ | LE | LT | GE | GT | BEGINS_WITH | BETWEEN</c> For information on specifying data
        /// types in JSON, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataFormat.html">JSON Data Format</a> in the
        /// <i>Amazon DynamoDB Developer Guide</i>. The following are descriptions of each comparison operator. <ul> <li> <c>EQ</c> : Equal.
        /// <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item contains an
        /// <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c>
        /// does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not equal <c>{"NS":["6", "2", "1"]}</c>. </li> <li> <c>LE</c> : Less than or
        /// equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set). If an item
        /// contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example,
        /// <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. </li> <li>
        /// <c>LT</c> : Less than. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or Binary (not a set).
        /// If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For
        /// example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c>. </li>
        /// <li> <c>GE</c> : Greater than or equal. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number, or
        /// Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value does
        /// not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2",
        /// "1"]}</c>. </li> <li> <c>GT</c> : Greater than. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of type String, Number,
        /// or Binary (not a set). If an item contains an <i>AttributeValue</i> of a different type than the one specified in the request, the value
        /// does not match. For example, <c>{"S":"6"}</c> does not equal <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6",
        /// "2", "1"]}</c>. </li> <li> <c>BEGINS_WITH</c> : checks for a prefix. <i>AttributeValueList</i> can contain only one <i>AttributeValue</i> of
        /// type String or Binary (not a Number or a set). The target attribute of the comparison must be a String or Binary (not a Number or a set).
        /// </li> <li> <c>BETWEEN</c> : Greater than or equal to the first value, and less than or equal to the second value. <i>AttributeValueList</i>
        /// must contain two <i>AttributeValue</i> elements of the same type, either String, Number, or Binary (not a set). A target attribute matches
        /// if the target value is greater than, or equal to, the first element and less than, or equal to, the second element. If an item contains an
        /// <i>AttributeValue</i> of a different type than the one specified in the request, the value does not match. For example, <c>{"S":"6"}</c>
        /// does not compare to <c>{"N":"6"}</c>. Also, <c>{"N":"6"}</c> does not compare to <c>{"NS":["6", "2", "1"]}</c> </li> </ul></li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,Condition> KeyConditions
        {
            get { return this.keyConditions; }
            set { this.keyConditions = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the KeyConditions dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the KeyConditions dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithKeyConditions(params KeyValuePair<string, Condition>[] pairs)
        {
            foreach (KeyValuePair<string, Condition> pair in pairs)
            {
                this.KeyConditions[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if KeyConditions property is set
        internal bool IsSetKeyConditions()
        {
            return this.keyConditions != null;
        }

        /// <summary>
        /// Specifies ascending (true) or descending (false) traversal of the index. Amazon DynamoDB returns results reflecting the requested order
        /// determined by the range key. If the data type is Number, the results are returned in numeric order. For String, the results are returned in
        /// order of ASCII character code values. For Binary, Amazon DynamoDB treats each byte of the binary data as unsigned when it compares binary
        /// values. If <i>ScanIndexForward</i> is not specified, the results are returned in ascending order.
        ///  
        /// </summary>
        public bool ScanIndexForward
        {
            get { return this.scanIndexForward ?? default(bool); }
            set { this.scanIndexForward = value; }
        }

        /// <summary>
        /// Sets the ScanIndexForward property
        /// </summary>
        /// <param name="scanIndexForward">The value to set for the ScanIndexForward property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithScanIndexForward(bool scanIndexForward)
        {
            this.scanIndexForward = scanIndexForward;
            return this;
        }
            

        // Check to see if ScanIndexForward property is set
        internal bool IsSetScanIndexForward()
        {
            return this.scanIndexForward.HasValue;
        }

        /// <summary>
        /// The primary key of the item from which to continue an earlier operation. An earlier operation might provide this value as the
        /// <i>LastEvaluatedKey</i> if that operation was interrupted before completion; either because of the result set size or because of the setting
        /// for <i>Limit</i>. The <i>LastEvaluatedKey</i> can be passed back in a new request to continue the operation from that point. The data type
        /// for <i>ExclusiveStartKey</i> must be String, Number or Binary. No set data types are allowed.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> ExclusiveStartKey
        {
            get { return this.exclusiveStartKey; }
            set { this.exclusiveStartKey = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the ExclusiveStartKey dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the ExclusiveStartKey dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithExclusiveStartKey(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.ExclusiveStartKey[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this.exclusiveStartKey != null;
        }

        /// <summary>
        /// If set to <c>TOTAL</c>, <i>ConsumedCapacity</i> is included in the response; if set to <c>NONE</c> (the default), <i>ConsumedCapacity</i> is
        /// not included.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        /// <summary>
        /// Sets the ReturnConsumedCapacity property
        /// </summary>
        /// <param name="returnConsumedCapacity">The value to set for the ReturnConsumedCapacity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public QueryRequest WithReturnConsumedCapacity(string returnConsumedCapacity)
        {
            this.returnConsumedCapacity = returnConsumedCapacity;
            return this;
        }
            

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }
    }
}
    
