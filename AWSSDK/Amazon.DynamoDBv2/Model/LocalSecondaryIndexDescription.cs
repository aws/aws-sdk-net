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
    /// <para>Represents the properties of a secondary index.</para>
    /// </summary>
    public class LocalSecondaryIndexDescription
    {
        
        private string indexName;
        private List<KeySchemaElement> keySchema = new List<KeySchemaElement>();
        private Projection projection;
        private long? indexSizeBytes;
        private long? itemCount;

        /// <summary>
        /// Represents the name of the secondary index.
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
        public LocalSecondaryIndexDescription WithIndexName(string indexName)
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
        /// Represents the complete index key schema, which consists of one or more pairs of attribute names and key types (<c>HASH</c> or
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
        /// <summary>
        /// Adds elements to the KeySchema collection
        /// </summary>
        /// <param name="keySchema">The values to add to the KeySchema collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LocalSecondaryIndexDescription WithKeySchema(params KeySchemaElement[] keySchema)
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
        public LocalSecondaryIndexDescription WithKeySchema(IEnumerable<KeySchemaElement> keySchema)
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
        /// Represents attributes that are copied (projected) from the table into the index. These are in addition to the primary key attributes and
        /// index key attributes, which are automatically projected.
        ///  
        /// </summary>
        public Projection Projection
        {
            get { return this.projection; }
            set { this.projection = value; }
        }

        /// <summary>
        /// Sets the Projection property
        /// </summary>
        /// <param name="projection">The value to set for the Projection property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LocalSecondaryIndexDescription WithProjection(Projection projection)
        {
            this.projection = projection;
            return this;
        }
            

        // Check to see if Projection property is set
        internal bool IsSetProjection()
        {
            return this.projection != null;
        }

        /// <summary>
        /// Represents the total size of the index, in bytes. Amazon DynamoDB updates this value approximately every six hours. Recent changes might not
        /// be reflected in this value.
        ///  
        /// </summary>
        public long IndexSizeBytes
        {
            get { return this.indexSizeBytes ?? default(long); }
            set { this.indexSizeBytes = value; }
        }

        /// <summary>
        /// Sets the IndexSizeBytes property
        /// </summary>
        /// <param name="indexSizeBytes">The value to set for the IndexSizeBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LocalSecondaryIndexDescription WithIndexSizeBytes(long indexSizeBytes)
        {
            this.indexSizeBytes = indexSizeBytes;
            return this;
        }
            

        // Check to see if IndexSizeBytes property is set
        internal bool IsSetIndexSizeBytes()
        {
            return this.indexSizeBytes.HasValue;
        }

        /// <summary>
        /// Represents the number of items in the index. Amazon DynamoDB updates this value approximately every six hours. Recent changes might not be
        /// reflected in this value.
        ///  
        /// </summary>
        public long ItemCount
        {
            get { return this.itemCount ?? default(long); }
            set { this.itemCount = value; }
        }

        /// <summary>
        /// Sets the ItemCount property
        /// </summary>
        /// <param name="itemCount">The value to set for the ItemCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public LocalSecondaryIndexDescription WithItemCount(long itemCount)
        {
            this.itemCount = itemCount;
            return this;
        }
            

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this.itemCount.HasValue;
        }
    }
}
