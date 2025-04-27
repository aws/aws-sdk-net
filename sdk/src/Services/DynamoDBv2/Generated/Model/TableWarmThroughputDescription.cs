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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
        private long? _readUnitsPerSecond;
        private TableStatus _status;
        private long? _writeUnitsPerSecond;

        /// <summary>
        /// Gets and sets the property ReadUnitsPerSecond. 
        /// <para>
        /// Represents the base table's warm throughput value in read units per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ReadUnitsPerSecond
        {
            get { return this._readUnitsPerSecond; }
            set { this._readUnitsPerSecond = value; }
        }

        // Check to see if ReadUnitsPerSecond property is set
        internal bool IsSetReadUnitsPerSecond()
        {
            return this._readUnitsPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Represents warm throughput value of the base table.
        /// </para>
        /// </summary>
        public TableStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WriteUnitsPerSecond. 
        /// <para>
        /// Represents the base table's warm throughput value in write units per second.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? WriteUnitsPerSecond
        {
            get { return this._writeUnitsPerSecond; }
            set { this._writeUnitsPerSecond = value; }
        }

        // Check to see if WriteUnitsPerSecond property is set
        internal bool IsSetWriteUnitsPerSecond()
        {
            return this._writeUnitsPerSecond.HasValue; 
        }

    }
}