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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// A mapping between an AWS resource and an AWS Lambda function. See <a>CreateEventSourceMapping</a>
    /// for details.
    /// </summary>
    public partial class EventSourceMappingConfiguration
    {
        private int? _batchSize;
        private bool? _bisectBatchOnFunctionError;
        private DestinationConfig _destinationConfig;
        private string _eventSourceArn;
        private string _functionArn;
        private DateTime? _lastModified;
        private string _lastProcessingResult;
        private int? _maximumBatchingWindowInSeconds;
        private int? _maximumRecordAgeInSeconds;
        private int? _maximumRetryAttempts;
        private int? _parallelizationFactor;
        private string _state;
        private string _stateTransitionReason;
        private List<string> _topics = new List<string>();
        private string _uuid;

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of items to retrieve in a single batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
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
        /// Gets and sets the property BisectBatchOnFunctionError. 
        /// <para>
        /// (Streams) If the function returns an error, split the batch in two and retry.
        /// </para>
        /// </summary>
        public bool BisectBatchOnFunctionError
        {
            get { return this._bisectBatchOnFunctionError.GetValueOrDefault(); }
            set { this._bisectBatchOnFunctionError = value; }
        }

        // Check to see if BisectBatchOnFunctionError property is set
        internal bool IsSetBisectBatchOnFunctionError()
        {
            return this._bisectBatchOnFunctionError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// (Streams) An Amazon SQS queue or Amazon SNS topic destination for discarded records.
        /// </para>
        /// </summary>
        public DestinationConfig DestinationConfig
        {
            get { return this._destinationConfig; }
            set { this._destinationConfig = value; }
        }

        // Check to see if DestinationConfig property is set
        internal bool IsSetDestinationConfig()
        {
            return this._destinationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event source.
        /// </para>
        /// </summary>
        public string EventSourceArn
        {
            get { return this._eventSourceArn; }
            set { this._eventSourceArn = value; }
        }

        // Check to see if EventSourceArn property is set
        internal bool IsSetEventSourceArn()
        {
            return this._eventSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The ARN of the Lambda function.
        /// </para>
        /// </summary>
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date that the event source mapping was last updated, or its state changed.
        /// </para>
        /// </summary>
        public DateTime LastModified
        {
            get { return this._lastModified.GetValueOrDefault(); }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastProcessingResult. 
        /// <para>
        /// The result of the last AWS Lambda invocation of your Lambda function.
        /// </para>
        /// </summary>
        public string LastProcessingResult
        {
            get { return this._lastProcessingResult; }
            set { this._lastProcessingResult = value; }
        }

        // Check to see if LastProcessingResult property is set
        internal bool IsSetLastProcessingResult()
        {
            return this._lastProcessingResult != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// (Streams) The maximum amount of time to gather records before invoking the function,
        /// in seconds.
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
        /// (Streams) The maximum age of a record that Lambda sends to a function for processing.
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
        /// (Streams) The maximum number of times to retry when the function returns an error.
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
        /// Gets and sets the property ParallelizationFactor. 
        /// <para>
        /// (Streams) The number of batches to process from each shard concurrently.
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

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the event source mapping. It can be one of the following: <code>Creating</code>,
        /// <code>Enabling</code>, <code>Enabled</code>, <code>Disabling</code>, <code>Disabled</code>,
        /// <code>Updating</code>, or <code>Deleting</code>.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// Indicates whether the last change to the event source mapping was made by a user,
        /// or by the Lambda service.
        /// </para>
        /// </summary>
        public string StateTransitionReason
        {
            get { return this._stateTransitionReason; }
            set { this._stateTransitionReason = value; }
        }

        // Check to see if StateTransitionReason property is set
        internal bool IsSetStateTransitionReason()
        {
            return this._stateTransitionReason != null;
        }

        /// <summary>
        /// Gets and sets the property Topics. 
        /// <para>
        ///  (MSK) The name of the Kafka topic. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Topics
        {
            get { return this._topics; }
            set { this._topics = value; }
        }

        // Check to see if Topics property is set
        internal bool IsSetTopics()
        {
            return this._topics != null && this._topics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The identifier of the event source mapping.
        /// </para>
        /// </summary>
        public string UUID
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if UUID property is set
        internal bool IsSetUUID()
        {
            return this._uuid != null;
        }

    }
}