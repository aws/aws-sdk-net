/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the warm throughput value (in read units per second and write units per
    /// second) of the table. Warm throughput is applicable for DynamoDB Standard-IA tables
    /// and specifies the minimum provisioned capacity maintained for immediate data access.
    /// </summary>
    public partial class TableWarmThroughputDescription
    {
        /// <summary>
        /// Gets and sets the property ReadUnitsPerSecond. 
        /// <para>
        /// Represents the base table's warm throughput value in read units per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ReadUnitsPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the ReadUnitsPerSecond property is set.
        /// </summary>
        internal bool IsSetReadUnitsPerSecond() => this.ReadUnitsPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Represents warm throughput value of the base table.
        /// </para>
        /// </summary>
        public TableStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WriteUnitsPerSecond. 
        /// <para>
        /// Represents the base table's warm throughput value in write units per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? WriteUnitsPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the WriteUnitsPerSecond property is set.
        /// </summary>
        internal bool IsSetWriteUnitsPerSecond() => this.WriteUnitsPerSecond.HasValue;
    }
}
