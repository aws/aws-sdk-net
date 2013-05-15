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
    /// <para>The table name that consumed provisioned throughput, and the number of capacity units consumed by it. <i>ConsumedCapacity</i> is only
    /// returned if it was asked for in the request. For more information, see Provisioned Throughput in the <i>Amazon DynamoDB Developer Guide</i>
    /// .</para>
    /// </summary>
    public class ConsumedCapacity
    {
        
        private string tableName;
        private double? capacityUnits;

        /// <summary>
        /// The table that consumed the provisioned throughput.
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
        public ConsumedCapacity WithTableName(string tableName)
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
        /// The total number of capacity units consumed.
        ///  
        /// </summary>
        public double CapacityUnits
        {
            get { return this.capacityUnits ?? default(double); }
            set { this.capacityUnits = value; }
        }

        /// <summary>
        /// Sets the CapacityUnits property
        /// </summary>
        /// <param name="capacityUnits">The value to set for the CapacityUnits property </param>
        /// <returns>this instance</returns>
        public ConsumedCapacity WithCapacityUnits(double capacityUnits)
        {
            this.capacityUnits = capacityUnits;
            return this;
        }
            

        // Check to see if CapacityUnits property is set
        internal bool IsSetCapacityUnits()
        {
            return this.capacityUnits.HasValue;
        }
    }
}
