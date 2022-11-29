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
    /// A mapping between an Amazon Web Services resource and a Lambda function. For details,
    /// see <a>CreateEventSourceMapping</a>.
    /// </summary>
    public partial class GetEventSourceMappingResponse : AmazonWebServiceResponse
    {
        private AmazonManagedKafkaEventSourceConfig _amazonManagedKafkaEventSourceConfig;
        private int? _batchSize;
        private bool? _bisectBatchOnFunctionError;
        private DestinationConfig _destinationConfig;
        private string _eventSourceArn;
        private FilterCriteria _filterCriteria;
        private string _functionArn;
        private List<string> _functionResponseTypes = new List<string>();
        private DateTime? _lastModified;
        private string _lastProcessingResult;
        private int? _maximumBatchingWindowInSeconds;
        private int? _maximumRecordAgeInSeconds;
        private int? _maximumRetryAttempts;
        private int? _parallelizationFactor;
        private List<string> _queues = new List<string>();
        private SelfManagedEventSource _selfManagedEventSource;
        private SelfManagedKafkaEventSourceConfig _selfManagedKafkaEventSourceConfig;
        private List<SourceAccessConfiguration> _sourceAccessConfigurations = new List<SourceAccessConfiguration>();
        private EventSourcePosition _startingPosition;
        private DateTime? _startingPositionTimestamp;
        private string _state;
        private string _stateTransitionReason;
        private List<string> _topics = new List<string>();
        private int? _tumblingWindowInSeconds;
        private string _uuid;

        /// <summary>
        /// Gets and sets the property AmazonManagedKafkaEventSourceConfig. 
        /// <para>
        /// Specific configuration settings for an Amazon Managed Streaming for Apache Kafka (Amazon
        /// MSK) event source.
        /// </para>
        /// </summary>
        public AmazonManagedKafkaEventSourceConfig AmazonManagedKafkaEventSourceConfig
        {
            get { return this._amazonManagedKafkaEventSourceConfig; }
            set { this._amazonManagedKafkaEventSourceConfig = value; }
        }

        // Check to see if AmazonManagedKafkaEventSourceConfig property is set
        internal bool IsSetAmazonManagedKafkaEventSourceConfig()
        {
            return this._amazonManagedKafkaEventSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property BatchSize. 
        /// <para>
        /// The maximum number of records in each batch that Lambda pulls from your stream or
        /// queue and sends to your function. Lambda passes all of the records in the batch to
        /// the function in a single call, up to the payload limit for synchronous invocation
        /// (6 MB).
        /// </para>
        ///  
        /// <para>
        /// Default value: Varies by service. For Amazon SQS, the default is 10. For all other
        /// services, the default is 100.
        /// </para>
        ///  
        /// <para>
        /// Related setting: When you set <code>BatchSize</code> to a value greater than 10, you
        /// must set <code>MaximumBatchingWindowInSeconds</code> to at least 1.
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
        /// (Streams only) If the function returns an error, split the batch in two and retry.
        /// The default value is false.
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
        /// (Streams only) An Amazon SQS queue or Amazon SNS topic destination for discarded records.
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
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// An object that defines the filter criteria that determine whether Lambda should process
        /// an event. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventfiltering.html">Lambda
        /// event filtering</a>.
        /// </para>
        /// </summary>
        public FilterCriteria FilterCriteria
        {
            get { return this._filterCriteria; }
            set { this._filterCriteria = value; }
        }

        // Check to see if FilterCriteria property is set
        internal bool IsSetFilterCriteria()
        {
            return this._filterCriteria != null;
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
        /// Gets and sets the property FunctionResponseTypes. 
        /// <para>
        /// (Streams and Amazon SQS) A list of current response type enums applied to the event
        /// source mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> FunctionResponseTypes
        {
            get { return this._functionResponseTypes; }
            set { this._functionResponseTypes = value; }
        }

        // Check to see if FunctionResponseTypes property is set
        internal bool IsSetFunctionResponseTypes()
        {
            return this._functionResponseTypes != null && this._functionResponseTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date that the event source mapping was last updated or that its state changed.
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
        /// The result of the last Lambda invocation of your function.
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
        /// The maximum amount of time, in seconds, that Lambda spends gathering records before
        /// invoking the function. You can configure <code>MaximumBatchingWindowInSeconds</code>
        /// to any value from 0 seconds to 300 seconds in increments of seconds.
        /// </para>
        ///  
        /// <para>
        /// For streams and Amazon SQS event sources, the default batching window is 0 seconds.
        /// For Amazon MSK, Self-managed Apache Kafka, and Amazon MQ event sources, the default
        /// batching window is 500 ms. Note that because you can only change <code>MaximumBatchingWindowInSeconds</code>
        /// in increments of seconds, you cannot revert back to the 500 ms default batching window
        /// after you have changed it. To restore the default batching window, you must create
        /// a new event source mapping.
        /// </para>
        ///  
        /// <para>
        /// Related setting: For streams and Amazon SQS event sources, when you set <code>BatchSize</code>
        /// to a value greater than 10, you must set <code>MaximumBatchingWindowInSeconds</code>
        /// to at least 1.
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
        /// -1, which sets the maximum age to infinite. When the value is set to infinite, Lambda
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
        /// is infinite, Lambda retries failed records until the record expires in the event source.
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

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        ///  (Amazon MQ) The name of the Amazon MQ broker destination queue to consume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && this._queues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SelfManagedEventSource. 
        /// <para>
        /// The self-managed Apache Kafka cluster for your event source.
        /// </para>
        /// </summary>
        public SelfManagedEventSource SelfManagedEventSource
        {
            get { return this._selfManagedEventSource; }
            set { this._selfManagedEventSource = value; }
        }

        // Check to see if SelfManagedEventSource property is set
        internal bool IsSetSelfManagedEventSource()
        {
            return this._selfManagedEventSource != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedKafkaEventSourceConfig. 
        /// <para>
        /// Specific configuration settings for a self-managed Apache Kafka event source.
        /// </para>
        /// </summary>
        public SelfManagedKafkaEventSourceConfig SelfManagedKafkaEventSourceConfig
        {
            get { return this._selfManagedKafkaEventSourceConfig; }
            set { this._selfManagedKafkaEventSourceConfig = value; }
        }

        // Check to see if SelfManagedKafkaEventSourceConfig property is set
        internal bool IsSetSelfManagedKafkaEventSourceConfig()
        {
            return this._selfManagedKafkaEventSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccessConfigurations. 
        /// <para>
        /// An array of the authentication protocol, VPC components, or virtual host to secure
        /// and define your event source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public List<SourceAccessConfiguration> SourceAccessConfigurations
        {
            get { return this._sourceAccessConfigurations; }
            set { this._sourceAccessConfigurations = value; }
        }

        // Check to see if SourceAccessConfigurations property is set
        internal bool IsSetSourceAccessConfigurations()
        {
            return this._sourceAccessConfigurations != null && this._sourceAccessConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The position in a stream from which to start reading. Required for Amazon Kinesis,
        /// Amazon DynamoDB, and Amazon MSK stream sources. <code>AT_TIMESTAMP</code> is supported
        /// only for Amazon Kinesis streams.
        /// </para>
        /// </summary>
        public EventSourcePosition StartingPosition
        {
            get { return this._startingPosition; }
            set { this._startingPosition = value; }
        }

        // Check to see if StartingPosition property is set
        internal bool IsSetStartingPosition()
        {
            return this._startingPosition != null;
        }

        /// <summary>
        /// Gets and sets the property StartingPositionTimestamp. 
        /// <para>
        /// With <code>StartingPosition</code> set to <code>AT_TIMESTAMP</code>, the time from
        /// which to start reading.
        /// </para>
        /// </summary>
        public DateTime StartingPositionTimestamp
        {
            get { return this._startingPositionTimestamp.GetValueOrDefault(); }
            set { this._startingPositionTimestamp = value; }
        }

        // Check to see if StartingPositionTimestamp property is set
        internal bool IsSetStartingPositionTimestamp()
        {
            return this._startingPositionTimestamp.HasValue; 
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
        /// Indicates whether a user or Lambda made the last change to the event source mapping.
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
        /// The name of the Kafka topic.
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
        /// Gets and sets the property TumblingWindowInSeconds. 
        /// <para>
        /// (Streams only) The duration in seconds of a processing window. The range is 1–900
        /// seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=900)]
        public int TumblingWindowInSeconds
        {
            get { return this._tumblingWindowInSeconds.GetValueOrDefault(); }
            set { this._tumblingWindowInSeconds = value; }
        }

        // Check to see if TumblingWindowInSeconds property is set
        internal bool IsSetTumblingWindowInSeconds()
        {
            return this._tumblingWindowInSeconds.HasValue; 
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