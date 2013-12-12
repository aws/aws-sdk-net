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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Contains the properties of a table.</para>
    /// </summary>
    public class TableDescription
    {
        
        private List<AttributeDefinition> attributeDefinitions = new List<AttributeDefinition>();
        private string tableName;
        private List<KeySchemaElement> keySchema = new List<KeySchemaElement>();
        private TableStatus tableStatus;
        private DateTime? creationDateTime;
        private ProvisionedThroughputDescription provisionedThroughput;
        private long? tableSizeBytes;
        private long? itemCount;
        private List<LocalSecondaryIndexDescription> localSecondaryIndexes = new List<LocalSecondaryIndexDescription>();
        private List<GlobalSecondaryIndexDescription> globalSecondaryIndexes = new List<GlobalSecondaryIndexDescription>();


        /// <summary>
        /// An array of <i>AttributeDefinition</i> objects. Each of these objects describes one attribute in the table and index key schema. Each
        /// <i>AttributeDefinition</i> object in this array is composed of: <ul> <li> <i>AttributeName</i> - The name of the attribute. </li> <li>
        /// <i>AttributeType</i> - The data type for the attribute. </li> </ul>
        ///  
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions
        {
            get { return this.attributeDefinitions; }
            set { this.attributeDefinitions = value; }
        }

        // Check to see if AttributeDefinitions property is set
        internal bool IsSetAttributeDefinitions()
        {
            return this.attributeDefinitions.Count > 0;
        }

        /// <summary>
        /// The name of the table.
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
        /// The primary key structure for the table. Each <i>KeySchemaElement</i> consists of: <ul> <li> <i>AttributeName</i> - The name of the
        /// attribute. </li> <li> <i>KeyType</i> - The key type for the attribute. Can be either <c>HASH</c> or <c>RANGE</c>. </li> </ul> For more
        /// information about primary keys, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html#DataModelPrimaryKey">Primary Key</a> in the Amazon
        /// DynamoDB Developer Guide.
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

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this.keySchema.Count > 0;
        }

        /// <summary>
        /// Represents the current state of the table: <ul> <li> <i>CREATING</i> - The table is being created, as the result of a <i>CreateTable</i>
        /// operation. </li> <li> <i>UPDATING</i> - The table is being updated, as the result of an <i>UpdateTable</i> operation. </li> <li>
        /// <i>DELETING</i> - The table is being deleted, as the result of a <i>DeleteTable</i> operation. </li> <li> <i>ACTIVE</i> - The table is ready
        /// for use. </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>CREATING, UPDATING, DELETING, ACTIVE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public TableStatus TableStatus
        {
            get { return this.tableStatus; }
            set { this.tableStatus = value; }
        }

        // Check to see if TableStatus property is set
        internal bool IsSetTableStatus()
        {
            return this.tableStatus != null;
        }

        /// <summary>
        /// Represents the date and time when the table was created, in <a href="http://www.epochconverter.com/">UNIX epoch time</a> format.
        ///  
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this.creationDateTime ?? default(DateTime); }
            set { this.creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this.creationDateTime.HasValue;
        }

        /// <summary>
        /// Represents the provisioned throughput settings for the table, consisting of read and write capacity units, along with data about increases
        /// and decreases.
        ///  
        /// </summary>
        public ProvisionedThroughputDescription ProvisionedThroughput
        {
            get { return this.provisionedThroughput; }
            set { this.provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this.provisionedThroughput != null;
        }

        /// <summary>
        /// Represents the total size of the specified table, in bytes. Amazon DynamoDB updates this value approximately every six hours. Recent changes
        /// might not be reflected in this value.
        ///  
        /// </summary>
        public long TableSizeBytes
        {
            get { return this.tableSizeBytes ?? default(long); }
            set { this.tableSizeBytes = value; }
        }

        // Check to see if TableSizeBytes property is set
        internal bool IsSetTableSizeBytes()
        {
            return this.tableSizeBytes.HasValue;
        }

        /// <summary>
        /// Represents the number of items in the specified table. Amazon DynamoDB updates this value approximately every six hours. Recent changes
        /// might not be reflected in this value.
        ///  
        /// </summary>
        public long ItemCount
        {
            get { return this.itemCount ?? default(long); }
            set { this.itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this.itemCount.HasValue;
        }

        /// <summary>
        /// Represents one or more secondary indexes on the table. Each index is scoped to a given hash key value. Tables with one or more local
        /// secondary indexes are subject to an item collection size limit, where the amount of data within a given item collection cannot exceed 10 GB.
        /// Each element is composed of: <ul> <li> <i>IndexName</i> - The name of the secondary index. </li> <li> <i>KeySchema</i> - Specifies the
        /// complete index key schema. The attribute names in the key schema must be between 1 and 255 characters (inclusive). The key schema must begin
        /// with the same hash key attribute as the table. </li> <li> <i>Projection</i> - Specifies attributes that are copied (projected) from the
        /// table into the index. These are in addition to the primary key attributes and index key attributes, which are automatically projected. Each
        /// attribute specification is composed of: <ul> <li> <i>ProjectionType</i> - One of the following: <ul> <li> <c>KEYS_ONLY</c> - Only the index
        /// and primary keys are projected into the index. </li> <li> <c>INCLUDE</c> - Only the specified table attributes are projected into the index.
        /// The list of projected attributes are in <i>NonKeyAttributes</i>. </li> <li> <c>ALL</c> - All of the table attributes are projected into the
        /// index. </li> </ul> </li> <li> <i>NonKeyAttributes</i> - A list of one or more non-key attribute names that are projected into the index. The
        /// total count of attributes specified in <i>NonKeyAttributes</i>, summed across all of the local secondary indexes, must not exceed 20. If you
        /// project the same attribute into two different indexes, this counts as two distinct attributes when determining the total. </li> </ul> </li>
        /// <li> <i>IndexSizeBytes</i> - Represents the total size of the index, in bytes. Amazon DynamoDB updates this value approximately every six
        /// hours. Recent changes might not be reflected in this value.</li> <li> <i>ItemCount</i> - Represents the number of items in the index. Amazon
        /// DynamoDB updates this value approximately every six hours. Recent changes might not be reflected in this value. </li> </ul> If the table is
        /// in the <c>DELETING</c> state, no information about indexes will be returned.
        ///  
        /// </summary>
        public List<LocalSecondaryIndexDescription> LocalSecondaryIndexes
        {
            get { return this.localSecondaryIndexes; }
            set { this.localSecondaryIndexes = value; }
        }

        // Check to see if LocalSecondaryIndexes property is set
        internal bool IsSetLocalSecondaryIndexes()
        {
            return this.localSecondaryIndexes.Count > 0;
        }
        public List<GlobalSecondaryIndexDescription> GlobalSecondaryIndexes
        {
            get { return this.globalSecondaryIndexes; }
            set { this.globalSecondaryIndexes = value; }
        }

        // Check to see if GlobalSecondaryIndexes property is set
        internal bool IsSetGlobalSecondaryIndexes()
        {
            return this.globalSecondaryIndexes.Count > 0;
        }
    }
}
