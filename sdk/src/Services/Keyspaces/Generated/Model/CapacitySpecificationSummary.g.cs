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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The read/write throughput capacity mode for a table. The options are:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>throughputMode:PAY_PER_REQUEST</c> and 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>throughputMode:PROVISIONED</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html">Read/write
    /// capacity modes</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CapacitySpecificationSummary
    {
        /// <summary>
        /// Gets and sets the property LastUpdateToPayPerRequestTimestamp. 
        /// <para>
        /// The timestamp of the last operation that changed the provisioned throughput capacity
        /// of a table.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateToPayPerRequestTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateToPayPerRequestTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateToPayPerRequestTimestamp() => this.LastUpdateToPayPerRequestTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The throughput capacity specified for <c>read</c> operations defined in <c>read capacity
        /// units</c> <c>(RCUs)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the ReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetReadCapacityUnits() => this.ReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ThroughputMode. 
        /// <para>
        /// The read/write throughput capacity mode for a table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>throughputMode:PAY_PER_REQUEST</c> and 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>throughputMode:PROVISIONED</c> - Provisioned capacity mode requires <c>readCapacityUnits</c>
        /// and <c>writeCapacityUnits</c> as input. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>throughput_mode:PAY_PER_REQUEST</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html">Read/write
        /// capacity modes</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ThroughputMode ThroughputMode { get; set; }

        /// <summary>
        /// Checks to see if the ThroughputMode property is set.
        /// </summary>
        internal bool IsSetThroughputMode() => this.ThroughputMode != null;

        /// <summary>
        /// Gets and sets the property WriteCapacityUnits. 
        /// <para>
        /// The throughput capacity specified for <c>write</c> operations defined in <c>write
        /// capacity units</c> <c>(WCUs)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? WriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the WriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetWriteCapacityUnits() => this.WriteCapacityUnits.HasValue;
    }
}
