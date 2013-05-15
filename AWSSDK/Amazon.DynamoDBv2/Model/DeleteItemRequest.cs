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
    /// Container for the parameters to the DeleteItem operation.
    /// <para>Deletes a single item in a table by primary key. You can perform a conditional delete operation that deletes the item if it exists, or
    /// if it has an expected attribute value.</para> <para>In addition to deleting an item, you can also return the item's attribute values in the
    /// same operation, using the <i>ReturnValues</i> parameter.</para> <para>Unless you specify conditions, the <i>DeleteItem</i> is an idempotent
    /// operation; running it multiple times on the same item or attribute does <i>not</i> result in an error response.</para> <para>Conditional
    /// deletes are useful for only deleting items if specific conditions are met. If those conditions are met, Amazon DynamoDB performs the delete.
    /// Otherwise, the item is not deleted. </para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.DeleteItem"/>
    public class DeleteItemRequest : AmazonWebServiceRequest
    {
        private string tableName;
        private Dictionary<string,AttributeValue> key = new Dictionary<string,AttributeValue>();
        private Dictionary<string,ExpectedAttributeValue> expected = new Dictionary<string,ExpectedAttributeValue>();
        private string returnValues;
        private string returnConsumedCapacity;
        private string returnItemCollectionMetrics;

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

        /// <summary>
        /// Sets the TableName property
        /// </summary>
        /// <param name="tableName">The value to set for the TableName property </param>
        /// <returns>this instance</returns>
        public DeleteItemRequest WithTableName(string tableName)
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
        /// A map of attribute names to <i>AttributeValue</i> objects, representing the primary key of the item to delete.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Key dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Key dictionary.</param>
        /// <returns>this instance</returns>
        public DeleteItemRequest WithKey(params KeyValuePair<string, AttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, AttributeValue> pair in pairs)
            {
                this.Key[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// A map of attribute/condition pairs. This is the conditional block for the <i>DeleteItem</i>operation. All the conditions must be met for the
        /// operation to succeed. <i>Expected</i> allows you to provide an attribute name, and whether or not Amazon DynamoDB should check to see if the
        /// attribute value already exists; or if the attribute value exists and has a particular value before changing it. Each item in <i>Expected</i>
        /// represents an attribute name for Amazon DynamoDB to check, along with the following: <ul> <li> <i>Value</i> - The attribute value for Amazon
        /// DynamoDB to check. </li> <li> <i>Exists</i> - Causes Amazon DynamoDB to evaluate the value before attempting a conditional operation: <ul>
        /// <li> If <i>Exists</i> is <c>true</c>, Amazon DynamoDB will check to see if that attribute value already exists in the table. If it is found,
        /// then the operation succeeds. If it is not found, the operation fails with a <i>ConditionalCheckFailedException</i>. </li> <li> If
        /// <i>Exists</i> is <c>false</c>, Amazon DynamoDB assumes that the attribute value does <i>not</i> exist in the table. If in fact the value
        /// does not exist, then the assumption is valid and the operation succeeds. If the value is found, despite the assumption that it does not
        /// exist, the operation fails with a <i>ConditionalCheckFailedException</i>. </li> </ul> The default setting for <i>Exists</i> is <c>true</c>.
        /// If you supply a <i>Value</i> all by itself, Amazon DynamoDB assumes the attribute exists: You don't have to set <i>Exists</i> to
        /// <c>true</c>, because it is implied. Amazon DynamoDB returns a <i>ValidationException</i> if: <ul> <li> <i>Exists</i> is <c>true</c> but
        /// there is no <i>Value</i> to check. (You expect a value to exist, but don't specify what that value is.) </li> <li> <i>Exists</i> is
        /// <c>false</c> but you also specify a <i>Value</i>. (You cannot expect an attribute to have a value, while also expecting it not to exist.)
        /// </li> </ul> </li> </ul> If you specify more than one condition for <i>Exists</i>, then all of the conditions must evaluate to true. (In
        /// other words, the conditions are ANDed together.) Otherwise, the conditional operation will fail.
        ///  
        /// </summary>
        public Dictionary<string,ExpectedAttributeValue> Expected
        {
            get { return this.expected; }
            set { this.expected = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Expected dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Expected dictionary.</param>
        /// <returns>this instance</returns>
        public DeleteItemRequest WithExpected(params KeyValuePair<string, ExpectedAttributeValue>[] pairs)
        {
            foreach (KeyValuePair<string, ExpectedAttributeValue> pair in pairs)
            {
                this.Expected[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this.expected != null;
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
        public string ReturnValues
        {
            get { return this.returnValues; }
            set { this.returnValues = value; }
        }

        /// <summary>
        /// Sets the ReturnValues property
        /// </summary>
        /// <param name="returnValues">The value to set for the ReturnValues property </param>
        /// <returns>this instance</returns>
        public DeleteItemRequest WithReturnValues(string returnValues)
        {
            this.returnValues = returnValues;
            return this;
        }
            

        // Check to see if ReturnValues property is set
        internal bool IsSetReturnValues()
        {
            return this.returnValues != null;
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
        public DeleteItemRequest WithReturnConsumedCapacity(string returnConsumedCapacity)
        {
            this.returnConsumedCapacity = returnConsumedCapacity;
            return this;
        }
            

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

        /// <summary>
        /// If set to <c>SIZE</c>, statistics about item collections, if any, that were modified during the operation are returned in the response. If
        /// set to <c>NONE</c> (the default), no statistics are returned..
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
        public string ReturnItemCollectionMetrics
        {
            get { return this.returnItemCollectionMetrics; }
            set { this.returnItemCollectionMetrics = value; }
        }

        /// <summary>
        /// Sets the ReturnItemCollectionMetrics property
        /// </summary>
        /// <param name="returnItemCollectionMetrics">The value to set for the ReturnItemCollectionMetrics property </param>
        /// <returns>this instance</returns>
        public DeleteItemRequest WithReturnItemCollectionMetrics(string returnItemCollectionMetrics)
        {
            this.returnItemCollectionMetrics = returnItemCollectionMetrics;
            return this;
        }
            

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this.returnItemCollectionMetrics != null;
        }
    }
}
    
