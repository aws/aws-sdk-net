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

namespace Amazon.DynamoDB.Model
{
    /// <summary>Table Description
    /// </summary>
    public class TableDescription  
    {
        
        private string tableName;
        private KeySchema keySchema;
        private string tableStatus;
        private DateTime? creationDateTime;
        private ProvisionedThroughputDescription provisionedThroughput;
        private long? tableSizeBytes;
        private long? itemCount;

        /// <summary>
        /// The name of the table being described.
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
        public TableDescription WithTableName(string tableName)
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
        /// The KeySchema identifies the primary key as a one attribute primary key (hash) or a composite two attribute (hash-and-range) primary key.
        /// Single attribute primary keys have one index value: a <c>HashKeyElement</c>. A composite hash-and-range primary key contains two attribute
        /// values: a <c>HashKeyElement</c> and a <c>RangeKeyElement</c>.
        ///  
        /// </summary>
        public KeySchema KeySchema
        {
            get { return this.keySchema; }
            set { this.keySchema = value; }
        }

        /// <summary>
        /// Sets the KeySchema property
        /// </summary>
        /// <param name="keySchema">The value to set for the KeySchema property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TableDescription WithKeySchema(KeySchema keySchema)
        {
            this.keySchema = keySchema;
            return this;
        }
            

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this.keySchema != null;       
        }
        public string TableStatus
        {
            get { return this.tableStatus; }
            set { this.tableStatus = value; }
        }

        /// <summary>
        /// Sets the TableStatus property
        /// </summary>
        /// <param name="tableStatus">The value to set for the TableStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TableDescription WithTableStatus(string tableStatus)
        {
            this.tableStatus = tableStatus;
            return this;
        }
            

        // Check to see if TableStatus property is set
        internal bool IsSetTableStatus()
        {
            return this.tableStatus != null;       
        }
        public DateTime CreationDateTime
        {
            get { return this.creationDateTime ?? default(DateTime); }
            set { this.creationDateTime = value; }
        }

        /// <summary>
        /// Sets the CreationDateTime property
        /// </summary>
        /// <param name="creationDateTime">The value to set for the CreationDateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TableDescription WithCreationDateTime(DateTime creationDateTime)
        {
            this.creationDateTime = creationDateTime;
            return this;
        }
            

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this.creationDateTime.HasValue;       
        }
        public ProvisionedThroughputDescription ProvisionedThroughput
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
        public TableDescription WithProvisionedThroughput(ProvisionedThroughputDescription provisionedThroughput)
        {
            this.provisionedThroughput = provisionedThroughput;
            return this;
        }
            

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this.provisionedThroughput != null;       
        }
        public long TableSizeBytes
        {
            get { return this.tableSizeBytes ?? default(long); }
            set { this.tableSizeBytes = value; }
        }

        /// <summary>
        /// Sets the TableSizeBytes property
        /// </summary>
        /// <param name="tableSizeBytes">The value to set for the TableSizeBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TableDescription WithTableSizeBytes(long tableSizeBytes)
        {
            this.tableSizeBytes = tableSizeBytes;
            return this;
        }
            

        // Check to see if TableSizeBytes property is set
        internal bool IsSetTableSizeBytes()
        {
            return this.tableSizeBytes.HasValue;       
        }
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
        public TableDescription WithItemCount(long itemCount)
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
