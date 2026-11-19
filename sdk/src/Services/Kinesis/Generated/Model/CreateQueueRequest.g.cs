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
    /// Container for the parameters to the CreateQueue operation. Creates a queue on the
    /// specified data stream. A queue delivers records from the stream to a queue consumer,
    /// tracks the delivery state of each record, and redelivers any record that is not acknowledged
    /// before its visibility timeout expires. <para> A queue does not extend how long the
    /// stream keeps a record. When a record reaches the end of the data stream's retention
    /// period, the queue stops delivering it. </para> <para> Your queue consumer calls <a>ReceiveQueueRecords</a>
    /// to receive up to 10 records at a time. After it processes records, it calls <a>AcknowledgeQueueRecords</a>
    /// so the queue does not deliver them again. </para> <para> Queues are supported only
    /// on data streams in on-demand capacity mode. </para> <para> Creating a queue does not
    /// change how producers write to the stream, and it does not change how existing stream
    /// consumers read from it. A queue counts as a registered consumer on the stream and
    /// shares the stream's registered consumer limit with enhanced fan-out consumers: 20
    /// on On-demand Standard and 50 on On-demand Advantage. </para> <para> Use <c>StartingPosition</c>
    /// to set the position in the stream where delivery begins. The default is <c>LATEST</c>.
    /// </para> <para> <c>CreateQueue</c> is an asynchronous operation. Upon receiving a <c>CreateQueue</c>
    /// request, Amazon Kinesis Data Streams immediately returns a queue description with
    /// a <c>QueueStatus</c> of <c>CREATING</c>. After the queue is created, Kinesis Data
    /// Streams sets the <c>QueueStatus</c> to <c>ACTIVE</c>. You can begin receiving records
    /// after the queue is <c>ACTIVE</c>. Use <a>DescribeQueue</a> to check the status of
    /// the queue. </para> <para> Each queue has built-in dead-letter handling. When a record
    /// has been received <c>MaxReceiveCount</c> times without being acknowledged, it becomes
    /// a dead-letter record, and <a>ReceiveQueueRecords</a> no longer returns it. You work
    /// with dead-letter records through a separate set of operations that use the same queue
    /// ARN: <a>ReceiveDeadLetterQueueRecords</a>, <a>AcknowledgeDeadLetterQueueRecords</a>,
    /// <a>UpdateDeadLetterQueueRecordsVisibility</a>, and <a>RestoreDeadLetterQueueRecords</a>.
    /// </para> <para> Dead-letter handling is enabled by default, with a <c>MaxReceiveCount</c>
    /// of 6. To use a different value, or to turn dead-letter handling off, specify <c>DeadLetterConfiguration</c>
    /// in <c>QueueAttributes</c>. </para>
    /// </summary>
    public partial class CreateQueueRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property QueueAttributes. 
        /// <para>
        /// The configuration attributes for the queue, including its visibility timeout and its
        /// dead-letter handling configuration.
        /// </para>
        /// </summary>
        public QueueAttributes QueueAttributes { get; set; }

        /// <summary>
        /// Checks to see if the QueueAttributes property is set.
        /// </summary>
        internal bool IsSetQueueAttributes() => this.QueueAttributes != null;

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// A name for the queue. The name is scoped to the Amazon Web Services account and Region
        /// used by the request, so two queues in different accounts, or in the same account and
        /// different Regions, can have the same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string QueueName { get; set; }

        /// <summary>
        /// Checks to see if the QueueName property is set.
        /// </summary>
        internal bool IsSetQueueName() => this.QueueName != null;

        /// <summary>
        /// Gets and sets the property StreamConfigurationList. 
        /// <para>
        /// The data stream the queue delivers records from, and the position in that stream where
        /// delivery begins. The list must contain exactly one entry, because a queue delivers
        /// records from a single data stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public List<QueueStreamConfiguration> StreamConfigurationList { get; set; } = AWSConfigs.InitializeCollections ? new List<QueueStreamConfiguration>() : null;

        /// <summary>
        /// Checks to see if the StreamConfigurationList property is set.
        /// </summary>
        internal bool IsSetStreamConfigurationList() => this.StreamConfigurationList != null && (this.StreamConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of up to 50 key-value pairs to apply to the queue. You can also add, change,
        /// and remove tags after the queue is created with <a>TagResource</a> and <a>UntagResource</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
