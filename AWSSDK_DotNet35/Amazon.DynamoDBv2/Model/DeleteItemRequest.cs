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
    /// Container for the parameters to the DeleteItem operation.
    /// <para>Deletes a single item in a table by primary key. You can perform a conditional delete operation that deletes the item if it exists, or
    /// if it has an expected attribute value.</para> <para>In addition to deleting an item, you can also return the item's attribute values in the
    /// same operation, using the <i>ReturnValues</i> parameter.</para> <para>Unless you specify conditions, the <i>DeleteItem</i> is an idempotent
    /// operation; running it multiple times on the same item or attribute does <i>not</i> result in an error response.</para> <para>Conditional
    /// deletes are useful for only deleting items if specific conditions are met. If those conditions are met, DynamoDB performs the delete.
    /// Otherwise, the item is not deleted. </para>
    /// </summary>
    public partial class DeleteItemRequest : AmazonDynamoDBv2Request
    {
        private string tableName;
        private Dictionary<string,AttributeValue> key = new Dictionary<string,AttributeValue>();
        private Dictionary<string,ExpectedAttributeValue> expected = new Dictionary<string,ExpectedAttributeValue>();
        private ConditionalOperator conditionalOperator;
        private ReturnValue returnValues;
        private ReturnConsumedCapacity returnConsumedCapacity;
        private ReturnItemCollectionMetrics returnItemCollectionMetrics;


        /// <summary>
        /// The name of the table from which to delete the item.
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

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;
        }

        /// <summary>
        /// A map of attribute names to <i>AttributeValue</i> objects, representing the primary key of the item to delete.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// A map of attribute/condition pairs. This is the conditional block for the <i>DeleteItem</i> operation. <i>Expected</i> allows you to provide
        /// an attribute name, and whether or not DynamoDB should check to see if the attribute value already exists; or if the attribute value exists
        /// and has a particular value before changing it. Each item in <i>Expected</i> represents an attribute name for DynamoDB to check, along with
        /// the following: <ul> <li> <i>Value</i> - A value for DynamoDB to compare with an attribute. When performing the comparison, strongly
        /// consistent reads are used. </li> <li> <i>Exists</i> - Causes DynamoDB to evaluate the value before attempting a conditional operation: <ul>
        /// <li> If <i>Exists</i> is <c>true</c>, DynamoDB will check to see if that attribute value already exists in the table. If it is found, then
        /// the operation succeeds. If it is not found, the operation fails with a <i>ConditionalCheckFailedException</i>. </li> <li> If <i>Exists</i>
        /// is <c>false</c>, DynamoDB assumes that the attribute value does <i>not</i> exist in the table. If in fact the value does not exist, then the
        /// assumption is valid and the operation succeeds. If the value is found, despite the assumption that it does not exist, the operation fails
        /// with a <i>ConditionalCheckFailedException</i>. </li> </ul> The default setting for <i>Exists</i> is <c>true</c>. If you supply a
        /// <i>Value</i> all by itself, DynamoDB assumes the attribute exists: You don't have to set <i>Exists</i> to <c>true</c>, because it is
        /// implied. DynamoDB returns a <i>ValidationException</i> if: <ul> <li> <i>Exists</i> is <c>true</c> but there is no <i>Value</i> to check.
        /// (You expect a value to exist, but don't specify what that value is.) </li> <li> <i>Exists</i> is <c>false</c> but you also specify a
        /// <i>Value</i>. (You cannot expect an attribute to have a value, while also expecting it not to exist.) </li> </ul> </li> </ul> If you specify
        /// more than one condition in the <i>Expected</i> map, then by default all of the conditions must evaluate to true. In other words, the
        /// conditions are ANDed together. (You can use the <i>ConditionalOperator</i> parameter to OR the conditions instead. If you do this, then at
        /// least one of the conditions must evaluate to true, rather than all of them.) If <i>Expected</i> evaluates to true, then the conditional
        /// operation succeeds; otherwise, it fails.
        ///  
        /// </summary>
        public Dictionary<string,ExpectedAttributeValue> Expected
        {
            get { return this.expected; }
            set { this.expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this.expected != null;
        }

        /// <summary>
        /// A logical operator to apply to the conditions in the <i>Expected</i> map: <ul> <li><c>AND</c> - If <i>all</i> of the conditions evaluate to
        /// true, then the entire map evaluates to true.</li> <li><c>OR</c> - If <i>at least one</i> of the conditions evaluate to true, then the entire
        /// map evaluates to true.</li> </ul> If you omit <i>ConditionalOperator</i>, then <c>AND</c> is used as the default. The operation will succeed
        /// only if the entire map evaluates to true.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AND, OR</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ConditionalOperator ConditionalOperator
        {
            get { return this.conditionalOperator; }
            set { this.conditionalOperator = value; }
        }

        // Check to see if ConditionalOperator property is set
        internal bool IsSetConditionalOperator()
        {
            return this.conditionalOperator != null;
        }

        /// <summary>
        /// Use <i>ReturnValues</i> if you want to get the item attributes as they appeared before they were deleted. For <i>DeleteItem</i>, the valid
        /// values are: <ul> <li> <c>NONE</c> - If <i>ReturnValues</i> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This
        /// is the default for <i>ReturnValues</i>.) </li> <li> <c>ALL_OLD</c> - The content of the old item is returned. </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>NONE, ALL_OLD, UPDATED_OLD, ALL_NEW, UPDATED_NEW</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnValue ReturnValues
        {
            get { return this.returnValues; }
            set { this.returnValues = value; }
        }

        // Check to see if ReturnValues property is set
        internal bool IsSetReturnValues()
        {
            return this.returnValues != null;
        }

        /// <summary>
        /// If set to <c>TOTAL</c>, the response includes <i>ConsumedCapacity</i> data for tables and indexes. If set to <c>INDEXES</c>, the response
        /// includes <i>ConsumedCapacity</i> for indexes. If set to <c>NONE</c> (the default), <i>ConsumedCapacity</i> is not included in the response.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>INDEXES, TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

        /// <summary>
        /// If set to <c>SIZE</c>, statistics about item collections, if any, that were modified during the operation are returned in the response. If
        /// set to <c>NONE</c> (the default), no statistics are returned.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>SIZE, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnItemCollectionMetrics ReturnItemCollectionMetrics
        {
            get { return this.returnItemCollectionMetrics; }
            set { this.returnItemCollectionMetrics = value; }
        }

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this.returnItemCollectionMetrics != null;
        }

    }
}
    
