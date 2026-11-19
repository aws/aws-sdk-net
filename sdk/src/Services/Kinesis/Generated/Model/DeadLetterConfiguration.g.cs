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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The dead-letter handling configuration for a queue. Each queue has built-in dead-letter
    /// handling. When a record has been received <c>MaxReceiveCount</c> times without being
    /// acknowledged, it becomes a dead-letter record, and <a>ReceiveQueueRecords</a> no longer
    /// returns it. The dead-letter record stays in the same queue, and you work with it through
    /// <a>ReceiveDeadLetterQueueRecords</a>, <a>AcknowledgeDeadLetterQueueRecords</a>, <a>UpdateDeadLetterQueueRecordsVisibility</a>,
    /// and <a>RestoreDeadLetterQueueRecords</a>, which use the same queue ARN.
    /// 
    ///  
    /// <para>
    /// Dead-letter handling is enabled by default, with a <c>MaxReceiveCount</c> of 6. To
    /// use a different value, or to turn dead-letter handling off, specify this configuration
    /// in <c>QueueAttributes</c>.
    /// </para>
    /// </summary>
    public partial class DeadLetterConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxReceiveCount. 
        /// <para>
        /// The number of times a record can be received without being acknowledged before it
        /// becomes a dead-letter record. Required when <c>TargetType</c> is <c>BUILT_IN</c>.
        /// A queue that you create without <c>DeadLetterConfiguration</c> gets a <c>MaxReceiveCount</c>
        /// of 6.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxReceiveCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxReceiveCount property is set.
        /// </summary>
        internal bool IsSetMaxReceiveCount() => this.MaxReceiveCount.HasValue;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// Whether dead-letter handling is enabled for the queue. <c>BUILT_IN</c> enables it:
        /// when a record has been received <c>MaxReceiveCount</c> times without being acknowledged,
        /// it becomes a dead-letter record and <a>ReceiveQueueRecords</a> no longer returns it.
        /// <c>NONE</c> disables it, and an unacknowledged record continues to be redelivered
        /// until it is acknowledged or its retention period ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
