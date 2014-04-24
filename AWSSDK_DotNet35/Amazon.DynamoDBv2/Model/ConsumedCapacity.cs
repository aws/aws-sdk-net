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
    /// <para>Represents the capacity units consumed by an operation. The data returned includes the total provisioned throughput consumed, along
    /// with statistics for the table and any indexes involved in the operation. <i>ConsumedCapacity</i> is only returned if it was asked for in the
    /// request. For more information, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughputIntro.html"
    /// >Provisioned Throughput</a> in the Amazon DynamoDB Developer Guide.</para>
    /// </summary>
    public partial class ConsumedCapacity
    {
        
        private string tableName;
        private double? capacityUnits;
        private Capacity table;
        private Dictionary<string,Capacity> localSecondaryIndexes = new Dictionary<string,Capacity>();
        private Dictionary<string,Capacity> globalSecondaryIndexes = new Dictionary<string,Capacity>();


        /// <summary>
        /// The name of the table that was affected by the operation.
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
        /// The total number of capacity units consumed by the operation.
        ///  
        /// </summary>
        public double CapacityUnits
        {
            get { return this.capacityUnits ?? default(double); }
            set { this.capacityUnits = value; }
        }

        // Check to see if CapacityUnits property is set
        internal bool IsSetCapacityUnits()
        {
            return this.capacityUnits.HasValue;
        }

        /// <summary>
        /// The amount of throughput consumed on the table affected by the operation.
        ///  
        /// </summary>
        public Capacity Table
        {
            get { return this.table; }
            set { this.table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this.table != null;
        }

        /// <summary>
        /// The amount of throughput consumed on each local index affected by the operation.
        ///  
        /// </summary>
        public Dictionary<string,Capacity> LocalSecondaryIndexes
        {
            get { return this.localSecondaryIndexes; }
            set { this.localSecondaryIndexes = value; }
        }

        // Check to see if LocalSecondaryIndexes property is set
        internal bool IsSetLocalSecondaryIndexes()
        {
            return this.localSecondaryIndexes != null;
        }

        /// <summary>
        /// The amount of throughput consumed on each global index affected by the operation.
        ///  
        /// </summary>
        public Dictionary<string,Capacity> GlobalSecondaryIndexes
        {
            get { return this.globalSecondaryIndexes; }
            set { this.globalSecondaryIndexes = value; }
        }

        // Check to see if GlobalSecondaryIndexes property is set
        internal bool IsSetGlobalSecondaryIndexes()
        {
            return this.globalSecondaryIndexes != null;
        }
    }
}
