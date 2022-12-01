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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a DynamoDB stream as a source.
    /// </summary>
    public partial class UpdatePipeSourceDynamoDBStreamParameters
    {
        private int? _batchSize;
        private DeadLetterConfig _deadLetterConfig;
        private int? _maximumBatchingWindowInSeconds;
        private int? _maximumRecordAgeInSeconds;
        private int? _maximumRetryAttempts;
        private OnPartialBatchItemFailureStreams _onPartialBatchItemFailure;
        private int? _parallelizationFactor;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of records to include in each batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeadLetterConfig. 
        /// <para>
        /// Define the target queue to send dead-letter queue events to.
        /// </para>
        /// </summary>
        public DeadLetterConfig DeadLetterConfig
        {
            get { return this._deadLetterConfig; }
            set { this._deadLetterConfig = value; }
        }

        // Check to see if DeadLetterConfig property is set
        internal bool IsSetDeadLetterConfig()
        {
            return this._deadLetterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// The maximum length of a time to wait for events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int MaximumBatchingWindowInSeconds
        {
            get { return this._maximumBatchingWindowInSeconds.GetValueOrDefault(); }
            set { this._maximumBatchingWindowInSeconds = value; }
        }

        // Check to see if MaximumBatchingWindowInSeconds property is set
        internal bool IsSetMaximumBatchingWindowInSeconds()
        {
            return this._maximumBatchingWindowInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumRecordAgeInSeconds. 
        /// <para>
        /// (Streams only) Discard records older than the specified age. The default value is
        /// -1, which sets the maximum age to infinite. When the value is set to infinite, EventBridge
        /// never discards old records. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=604800)]
        public int MaximumRecordAgeInSeconds
        {
            get { return this._maximumRecordAgeInSeconds.GetValueOrDefault(); }
            set { this._maximumRecordAgeInSeconds = value; }
        }

        // Check to see if MaximumRecordAgeInSeconds property is set
        internal bool IsSetMaximumRecordAgeInSeconds()
        {
            return this._maximumRecordAgeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumRetryAttempts. 
        /// <para>
        /// (Streams only) Discard records after the specified number of retries. The default
        /// value is -1, which sets the maximum number of retries to infinite. When MaximumRetryAttempts
        /// is infinite, EventBridge retries failed records until the record expires in the event
        /// source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=10000)]
        public int MaximumRetryAttempts
        {
            get { return this._maximumRetryAttempts.GetValueOrDefault(); }
            set { this._maximumRetryAttempts = value; }
        }

        // Check to see if MaximumRetryAttempts property is set
        internal bool IsSetMaximumRetryAttempts()
        {
            return this._maximumRetryAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnPartialBatchItemFailure. 
        /// <para>
        /// (Streams only) Define how to handle item process failures. <code>AUTOMATIC_BISECT</code>
        /// halves each batch and retry each half until all the records are processed or there
        /// is one failed message left in the batch.
        /// </para>
        /// </summary>
        public OnPartialBatchItemFailureStreams OnPartialBatchItemFailure
        {
            get { return this._onPartialBatchItemFailure; }
            set { this._onPartialBatchItemFailure = value; }
        }

        // Check to see if OnPartialBatchItemFailure property is set
        internal bool IsSetOnPartialBatchItemFailure()
        {
            return this._onPartialBatchItemFailure != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelizationFactor. 
        /// <para>
        /// (Streams only) The number of batches to process concurrently from each shard. The
        /// default value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int ParallelizationFactor
        {
            get { return this._parallelizationFactor.GetValueOrDefault(); }
            set { this._parallelizationFactor = value; }
        }

        // Check to see if ParallelizationFactor property is set
        internal bool IsSetParallelizationFactor()
        {
            return this._parallelizationFactor.HasValue; 
        }

    }
}