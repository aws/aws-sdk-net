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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a DynamoDB stream as a source.
    /// </summary>
    public partial class PipeSourceDynamoDBStreamParameters
    {
        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of records to include in each batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Checks to see if the BatchSize property is set.
        /// </summary>
        internal bool IsSetBatchSize() => this.BatchSize.HasValue;

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// Define the target queue to send dead-letter queue events to.
        /// </para>
        /// </summary>
        public DeadLetterConfig DeadLetterConfig { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterConfig property is set.
        /// </summary>
        internal bool IsSetDeadLetterConfig() => this.DeadLetterConfig != null;

        /// <summary>
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// The maximum length of a time to wait for events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public int? MaximumBatchingWindowInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBatchingWindowInSeconds property is set.
        /// </summary>
        internal bool IsSetMaximumBatchingWindowInSeconds() => this.MaximumBatchingWindowInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumRecordAgeInSeconds. 
        /// <para>
        /// Discard records older than the specified age. The default value is -1, which sets
        /// the maximum age to infinite. When the value is set to infinite, EventBridge never
        /// discards old records. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 604800)]
        public int? MaximumRecordAgeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaximumRecordAgeInSeconds property is set.
        /// </summary>
        internal bool IsSetMaximumRecordAgeInSeconds() => this.MaximumRecordAgeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumRetryAttempts. 
        /// <para>
        /// Discard records after the specified number of retries. The default value is -1, which
        /// sets the maximum number of retries to infinite. When MaximumRetryAttempts is infinite,
        /// EventBridge retries failed records until the record expires in the event source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 10000)]
        public int? MaximumRetryAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaximumRetryAttempts property is set.
        /// </summary>
        internal bool IsSetMaximumRetryAttempts() => this.MaximumRetryAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property OnPartialBatchItemFailure. 
        /// <para>
        /// Define how to handle item process failures. <c>AUTOMATIC_BISECT</c> halves each batch
        /// and retry each half until all the records are processed or there is one failed message
        /// left in the batch.
        /// </para>
        /// </summary>
        public OnPartialBatchItemFailureStreams OnPartialBatchItemFailure { get; set; }

        /// <summary>
        /// Checks to see if the OnPartialBatchItemFailure property is set.
        /// </summary>
        internal bool IsSetOnPartialBatchItemFailure() => this.OnPartialBatchItemFailure != null;

        /// <summary>
        /// Gets and sets the property ParallelizationFactor. 
        /// <para>
        /// The number of batches to process concurrently from each shard. The default value is
        /// 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? ParallelizationFactor { get; set; }

        /// <summary>
        /// Checks to see if the ParallelizationFactor property is set.
        /// </summary>
        internal bool IsSetParallelizationFactor() => this.ParallelizationFactor.HasValue;

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The position in a stream from which to start reading.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DynamoDBStreamStartPosition StartingPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartingPosition property is set.
        /// </summary>
        internal bool IsSetStartingPosition() => this.StartingPosition != null;
    }
}
