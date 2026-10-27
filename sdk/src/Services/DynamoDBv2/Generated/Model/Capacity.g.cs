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
    /// Represents the amount of provisioned throughput capacity consumed on a table or an
    /// index.
    /// </summary>
    public partial class Capacity
    {
        /// <summary>
        /// Gets and sets the property CapacityUnits. 
        /// <para>
        /// The total number of capacity units consumed on a table or an index.
        /// </para>
        /// </summary>
        public double? CapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the CapacityUnits property is set.
        /// </summary>
        internal bool IsSetCapacityUnits() => this.CapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The total number of read capacity units consumed on a table or an index.
        /// </para>
        /// </summary>
        public double? ReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReadCapacityUnits() => this.ReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property WriteCapacityUnits. 
        /// <para>
        /// The total number of write capacity units consumed on a table or an index.
        /// </para>
        /// </summary>
        public double? WriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the WriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetWriteCapacityUnits() => this.WriteCapacityUnits.HasValue;
    }
}
