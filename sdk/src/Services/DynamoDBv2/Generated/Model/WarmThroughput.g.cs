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
    /// Provides visibility into the number of read and write operations your table or secondary
    /// index can instantaneously support. The settings can be modified using the <c>UpdateTable</c>
    /// operation to meet the throughput requirements of an upcoming peak event.
    /// </summary>
    public partial class WarmThroughput
    {
        /// <summary>
        /// Gets and sets the property ReadUnitsPerSecond. 
        /// <para>
        /// Represents the number of read operations your base table can instantaneously support.
        /// </para>
        /// </summary>
        public long? ReadUnitsPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the ReadUnitsPerSecond property is set.
        /// </summary>
        internal bool IsSetReadUnitsPerSecond() => this.ReadUnitsPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property WriteUnitsPerSecond. 
        /// <para>
        /// Represents the number of write operations your base table can instantaneously support.
        /// </para>
        /// </summary>
        public long? WriteUnitsPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the WriteUnitsPerSecond property is set.
        /// </summary>
        internal bool IsSetWriteUnitsPerSecond() => this.WriteUnitsPerSecond.HasValue;
    }
}
