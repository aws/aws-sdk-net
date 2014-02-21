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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the properties of a global secondary index.</para>
    /// </summary>
    public class GlobalSecondaryIndexDescription
    {
        
        private string indexName;
        private List<KeySchemaElement> keySchema = new List<KeySchemaElement>();
        private Projection projection;
        private IndexStatus indexStatus;
        private ProvisionedThroughputDescription provisionedThroughput;
        private long? indexSizeBytes;
        private long? itemCount;


        /// <summary>
        /// The name of the global secondary index.
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

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this.indexName != null;
        }

        /// <summary>
        /// The complete key schema for the global secondary index, consisting of one or more pairs of attribute names and key types (<c>HASH</c> or
        /// <c>RANGE</c>).
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
        /// Represents attributes that are copied (projected) from the table into an index. These are in addition to the primary key attributes and
        /// index key attributes, which are automatically projected.
        ///  
        /// </summary>
        public Projection Projection
        {
            get { return this.projection; }
            set { this.projection = value; }
        }

        // Check to see if Projection property is set
        internal bool IsSetProjection()
        {
            return this.projection != null;
        }

        /// <summary>
        /// The current state of the global secondary index: <ul> <li> <i>CREATING</i> - The index is being created, as the result of a
        /// <i>CreateTable</i> or <i>UpdateTable</i> operation. </li> <li> <i>UPDATING</i> - The index is being updated, as the result of a
        /// <i>CreateTable</i> or <i>UpdateTable</i> operation. </li> <li> <i>DELETING</i> - The index is being deleted, as the result of a
        /// <i>DeleteTable</i> operation. </li> <li> <i>ACTIVE</i> - The index is ready for use. </li> </ul>
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
        public IndexStatus IndexStatus
        {
            get { return this.indexStatus; }
            set { this.indexStatus = value; }
        }

        // Check to see if IndexStatus property is set
        internal bool IsSetIndexStatus()
        {
            return this.indexStatus != null;
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
        /// The total size of the specified index, in bytes. DynamoDB updates this value approximately every six hours. Recent changes might not be
        /// reflected in this value.
        ///  
        /// </summary>
        public long IndexSizeBytes
        {
            get { return this.indexSizeBytes ?? default(long); }
            set { this.indexSizeBytes = value; }
        }

        // Check to see if IndexSizeBytes property is set
        internal bool IsSetIndexSizeBytes()
        {
            return this.indexSizeBytes.HasValue;
        }

        /// <summary>
        /// The number of items in the specified index. DynamoDB updates this value approximately every six hours. Recent changes might not be reflected
        /// in this value.
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
    }
}
