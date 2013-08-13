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
    /// Container for the parameters to the CreateTable operation.
    /// <para>The <i>CreateTable</i> operation adds a new table to your account. In an AWS account, table names must be unique within each region.
    /// That is, you can have two tables with same name if you create the tables in different regions.</para> <para> <i>CreateTable</i> is an
    /// asynchronous operation. Upon receiving a <i>CreateTable</i> request, Amazon DynamoDB immediately returns a response with a
    /// <i>TableStatus</i> of <c>CREATING</c> . After the table is created, Amazon DynamoDB sets the <i>TableStatus</i> to <c>ACTIVE</c> . You can
    /// perform read and write operations only on an <c>ACTIVE</c> table. </para> <para>If you want to create multiple tables with local secondary
    /// indexes on them, you must create them sequentially. Only one table with local secondary indexes can be in the <c>CREATING</c> state at any
    /// given time.</para> <para>You can use the <i>DescribeTable</i> API to check the table status.</para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.CreateTable"/>
    public class CreateTableRequest : AmazonWebServiceRequest
    {
        private List<AttributeDefinition> attributeDefinitions = new List<AttributeDefinition>();
        private string tableName;
        private List<KeySchemaElement> keySchema = new List<KeySchemaElement>();
        private List<LocalSecondaryIndex> localSecondaryIndexes = new List<LocalSecondaryIndex>();
        private ProvisionedThroughput provisionedThroughput;

        /// <summary>
        /// An array of attributes that describe the key schema for the table and indexes.
        ///  
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions
        {
            get { return this.attributeDefinitions; }
            set { this.attributeDefinitions = value; }
        }
        /// <summary>
        /// Adds elements to the AttributeDefinitions collection
        /// </summary>
        /// <param name="attributeDefinitions">The values to add to the AttributeDefinitions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTableRequest WithAttributeDefinitions(params AttributeDefinition[] attributeDefinitions)
        {
            foreach (AttributeDefinition element in attributeDefinitions)
            {
                this.attributeDefinitions.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AttributeDefinitions collection
        /// </summary>
        /// <param name="attributeDefinitions">The values to add to the AttributeDefinitions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTableRequest WithAttributeDefinitions(IEnumerable<AttributeDefinition> attributeDefinitions)
        {
            foreach (AttributeDefinition element in attributeDefinitions)
            {
                this.attributeDefinitions.Add(element);
            }

            return this;
        }

        // Check to see if AttributeDefinitions property is set
        internal bool IsSetAttributeDefinitions()
        {
            return this.attributeDefinitions.Count > 0;
        }

        /// <summary>
        /// The name of the table to create.
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
        public CreateTableRequest WithTableName(string tableName)
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
        /// Specifies the attributes that make up the primary key for the table. The attributes in <i>KeySchema</i> must also be defined in the
        /// <i>AttributeDefinitions</i> array. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html">Data Model</a> in the <i>Amazon DynamoDB Developer
        /// Guide</i>. Each <i>KeySchemaElement</i> in the array is composed of: <ul> <li> <i>AttributeName</i> - The name of this key attribute. </li>
        /// <li> <i>KeyType</i> - Determines whether the key attribute is <c>HASH</c> or <c>RANGE</c>. </li> </ul> For a primary key that consists of a
        /// hash attribute, you must specify exactly one element with a <i>KeyType</i> of <c>HASH</c>. For a primary key that consists of hash and range
        /// attributes, you must specify exactly two elements, in this order: The first element must have a <i>KeyType</i> of <c>HASH</c>, and the
        /// second element must have a <i>KeyType</i> of <c>RANGE</c>. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithDDTables.html#WorkingWithDDTables.primary.key">Specifying
        /// the Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 2</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<KeySchemaElement> KeySchema
        {
            get { return this.keySchema; }
            set { this.keySchema = value; }
        }
        /// <summary>
        /// Adds elements to the KeySchema collection
        /// </summary>
        /// <param name="keySchema">The values to add to the KeySchema collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTableRequest WithKeySchema(params KeySchemaElement[] keySchema)
        {
            foreach (KeySchemaElement element in keySchema)
            {
                this.keySchema.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the KeySchema collection
        /// </summary>
        /// <param name="keySchema">The values to add to the KeySchema collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTableRequest WithKeySchema(IEnumerable<KeySchemaElement> keySchema)
        {
            foreach (KeySchemaElement element in keySchema)
            {
                this.keySchema.Add(element);
            }

            return this;
        }

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this.keySchema.Count > 0;
        }

        /// <summary>
        /// One or more secondary indexes (the maximum is five) to be created on the table. Each index is scoped to a given hash key value. There is a
        /// 10 gigabyte size limit per hash key; otherwise, the size of a local secondary index is unconstrained. Each secondary index in the array
        /// includes the following: <ul> <li> <i>IndexName</i> - The name of the secondary index. Must be unique only for this table. </li> <li>
        /// <i>KeySchema</i> - Specifies the key schema for the index. The key schema must begin with the same hash key attribute as the table. </li>
        /// <li> <i>Projection</i> - Specifies attributes that are copied (projected) from the table into the index. These are in addition to the
        /// primary key attributes and index key attributes, which are automatically projected. Each attribute specification is composed of: <ul> <li>
        /// <i>ProjectionType</i> - One of the following: <ul> <li> <c>KEYS_ONLY</c> - Only the index and primary keys are projected into the index.
        /// </li> <li> <c>INCLUDE</c> - Only the specified table attributes are projected into the index. The list of projected attributes are in
        /// <i>NonKeyAttributes</i>. </li> <li> <c>ALL</c> - All of the table attributes are projected into the index. </li> </ul> </li> <li>
        /// <i>NonKeyAttributes</i> - A list of one or more non-key attribute names that are projected into the index. The total count of attributes
        /// specified in <i>NonKeyAttributes</i>, summed across all of the local secondary indexes, must not exceed 20. If you project the same
        /// attribute into two different indexes, this counts as two distinct attributes when determining the total. </li> </ul> </li> </ul>
        ///  
        /// </summary>
        public List<LocalSecondaryIndex> LocalSecondaryIndexes
        {
            get { return this.localSecondaryIndexes; }
            set { this.localSecondaryIndexes = value; }
        }
        /// <summary>
        /// Adds elements to the LocalSecondaryIndexes collection
        /// </summary>
        /// <param name="localSecondaryIndexes">The values to add to the LocalSecondaryIndexes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTableRequest WithLocalSecondaryIndexes(params LocalSecondaryIndex[] localSecondaryIndexes)
        {
            foreach (LocalSecondaryIndex element in localSecondaryIndexes)
            {
                this.localSecondaryIndexes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the LocalSecondaryIndexes collection
        /// </summary>
        /// <param name="localSecondaryIndexes">The values to add to the LocalSecondaryIndexes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTableRequest WithLocalSecondaryIndexes(IEnumerable<LocalSecondaryIndex> localSecondaryIndexes)
        {
            foreach (LocalSecondaryIndex element in localSecondaryIndexes)
            {
                this.localSecondaryIndexes.Add(element);
            }

            return this;
        }

        // Check to see if LocalSecondaryIndexes property is set
        internal bool IsSetLocalSecondaryIndexes()
        {
            return this.localSecondaryIndexes.Count > 0;
        }

        /// <summary>
        /// The provisioned throughput settings for the specified table. The settings can be modified using the <i>UpdateTable</i> operation. For
        /// current minimum and maximum provisioned throughput values, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Limits</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        ///  
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get { return this.provisionedThroughput; }
            set { this.provisionedThroughput = value; }
        }

        /// <summary>
        /// Sets the ProvisionedThroughput property
        /// </summary>
        /// <param name="provisionedThroughput">The value to set for the ProvisionedThroughput property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateTableRequest WithProvisionedThroughput(ProvisionedThroughput provisionedThroughput)
        {
            this.provisionedThroughput = provisionedThroughput;
            return this;
        }
            

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this.provisionedThroughput != null;
        }
    }
}
    
