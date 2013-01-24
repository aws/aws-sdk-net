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

namespace Amazon.DynamoDB.Model
{
    /// <summary>
    /// Container for the parameters to the Query operation.
    /// <para>Gets the values of one or more items and its attributes by primary key (composite primary key, only).</para> <para>Narrow the scope of
    /// the query using comparison operators on the <c>RangeKeyValue</c> of the composite key. Use the <c>ScanIndexForward</c> parameter to get
    /// results in forward or reverse order by range key.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.Query"/>
    public class QueryRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private List<string> attributesToGet = new List<string>();
        private int? limit;
        private bool? consistentRead;
        private bool? count;
        private AttributeValue hashKeyValue;
        private Condition rangeKeyCondition;
        private bool? scanIndexForward;
        private Key exclusiveStartKey;

        /// <summary>
        /// The name of the table in which you want to query. Allowed characters are <c>a-z</c>, <c>A-Z</c>, <c>0-9</c>, <c>_</c> (underscore), <c>-</c>
        /// (hyphen) and <c>.</c> (period).
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
        /// List of <c>Attribute</c> names. If attribute names are not specified then all attributes will be returned. If some attributes are not found,
        /// they will not appear in the result.
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
        /// The maximum number of items to return. If Amazon DynamoDB hits this limit while querying the table, it stops the query and returns the
        /// matching values up to the limit, and a <c>LastEvaluatedKey</c> to apply in a subsequent operation to continue the query. Also, if the result
        /// set size exceeds 1MB before Amazon DynamoDB hits this limit, it stops the query and returns the matching values, and a
        /// <c>LastEvaluatedKey</c> to apply in a subsequent operation to continue the query.
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
        /// If set to <c>true</c>, then a consistent read is issued. Otherwise eventually-consistent is used.
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
        /// If set to <c>true</c>, Amazon DynamoDB returns a total number of items that match the query parameters, instead of a list of the matching
        /// items and their attributes. Do not set <c>Count</c> to <c>true</c> while providing a list of <c>AttributesToGet</c>, otherwise Amazon
        /// DynamoDB returns a validation error.
        ///  
        /// </summary>
        public bool Count
        {
            get { return this.count ?? default(bool); }
            set { this.count = value; }
        }

        /// <summary>
        /// Sets the Count property
        /// </summary>
        /// <param name="count">The value to set for the Count property </param>
        /// <returns>this instance</returns>
        public QueryRequest WithCount(bool count)
        {
            this.count = count;
            return this;
        }
            

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this.count.HasValue;       
        }

        /// <summary>
        /// Attribute value of the hash component of the composite primary key.
        ///  
        /// </summary>
        public AttributeValue HashKeyValue
        {
            get { return this.hashKeyValue; }
            set { this.hashKeyValue = value; }
        }

        /// <summary>
        /// Sets the HashKeyValue property
        /// </summary>
        /// <param name="hashKeyValue">The value to set for the HashKeyValue property </param>
        /// <returns>this instance</returns>
        public QueryRequest WithHashKeyValue(AttributeValue hashKeyValue)
        {
            this.hashKeyValue = hashKeyValue;
            return this;
        }
            

        // Check to see if HashKeyValue property is set
        internal bool IsSetHashKeyValue()
        {
            return this.hashKeyValue != null;       
        }

        /// <summary>
        /// A container for the attribute values and comparison operators to use for the query.
        ///  
        /// </summary>
        public Condition RangeKeyCondition
        {
            get { return this.rangeKeyCondition; }
            set { this.rangeKeyCondition = value; }
        }

        /// <summary>
        /// Sets the RangeKeyCondition property
        /// </summary>
        /// <param name="rangeKeyCondition">The value to set for the RangeKeyCondition property </param>
        /// <returns>this instance</returns>
        public QueryRequest WithRangeKeyCondition(Condition rangeKeyCondition)
        {
            this.rangeKeyCondition = rangeKeyCondition;
            return this;
        }
            

        // Check to see if RangeKeyCondition property is set
        internal bool IsSetRangeKeyCondition()
        {
            return this.rangeKeyCondition != null;       
        }

        /// <summary>
        /// Specifies forward or backward traversal of the index. Amazon DynamoDB returns results reflecting the requested order, determined by the
        /// range key. The default value is <c>true</c> (forward).
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
        /// Primary key of the item from which to continue an earlier query. An earlier query might provide this value as the <c>LastEvaluatedKey</c> if
        /// that query operation was interrupted before completing the query; either because of the result set size or the <c>Limit</c> parameter. The
        /// <c>LastEvaluatedKey</c> can be passed back in a new query request to continue the operation from that point.
        ///  
        /// </summary>
        public Key ExclusiveStartKey
        {
            get { return this.exclusiveStartKey; }
            set { this.exclusiveStartKey = value; }
        }

        /// <summary>
        /// Sets the ExclusiveStartKey property
        /// </summary>
        /// <param name="exclusiveStartKey">The value to set for the ExclusiveStartKey property </param>
        /// <returns>this instance</returns>
        public QueryRequest WithExclusiveStartKey(Key exclusiveStartKey)
        {
            this.exclusiveStartKey = exclusiveStartKey;
            return this;
        }
            

        // Check to see if ExclusiveStartKey property is set
        internal bool IsSetExclusiveStartKey()
        {
            return this.exclusiveStartKey != null;       
        }
    }
}
    
