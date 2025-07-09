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

#pragma warning disable CS0612,CS0618,CS1570
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
        private DocumentDBEventSourceConfig _documentDBEventSourceConfig;
        private string _eventSourceArn;
        private string _eventSourceMappingArn;
        private FilterCriteria _filterCriteria;
        private FilterCriteriaError _filterCriteriaError;
        private string _functionArn;
        private List<string> _functionResponseTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _kmsKeyArn;
        private DateTime? _lastModified;
        private string _lastProcessingResult;
        private int? _maximumBatchingWindowInSeconds;
        private int? _maximumRecordAgeInSeconds;
        private int? _maximumRetryAttempts;
        private EventSourceMappingMetricsConfig _metricsConfig;
        private int? _parallelizationFactor;
        private ProvisionedPollerConfig _provisionedPollerConfig;
        private List<string> _queues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ScalingConfig _scalingConfig;
        private SelfManagedEventSource _selfManagedEventSource;
        private SelfManagedKafkaEventSourceConfig _selfManagedKafkaEventSourceConfig;
        private List<SourceAccessConfiguration> _sourceAccessConfigurations = AWSConfigs.InitializeCollections ? new List<SourceAccessConfiguration>() : null;
        private EventSourcePosition _startingPosition;
        private DateTime? _startingPositionTimestamp;
        private string _state;
        private string _stateTransitionReason;
        private List<string> _topics = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// Related setting: When you set <c>BatchSize</c> to a value greater than 10, you must
        /// set <c>MaximumBatchingWindowInSeconds</c> to at least 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? BatchSize
        {
            get { return this._batchSize; }
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
        /// (Kinesis and DynamoDB Streams only) If the function returns an error, split the batch
        /// in two and retry. The default value is false.
        /// </para>
        /// </summary>
        public bool? BisectBatchOnFunctionError
        {
            get { return this._bisectBatchOnFunctionError; }
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
        /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka event sources
        /// only) A configuration object that specifies the destination of an event after Lambda
        /// processes it.
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
        /// Gets and sets the property DocumentDBEventSourceConfig. 
        /// <para>
        /// Specific configuration settings for a DocumentDB event source.
        /// </para>
        /// </summary>
        public DocumentDBEventSourceConfig DocumentDBEventSourceConfig
        {
            get { return this._documentDBEventSourceConfig; }
            set { this._documentDBEventSourceConfig = value; }
        }

        // Check to see if DocumentDBEventSourceConfig property is set
        internal bool IsSetDocumentDBEventSourceConfig()
        {
            return this._documentDBEventSourceConfig != null;
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
        /// Gets and sets the property EventSourceMappingArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event source mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min=85, Max=120)]
        public string EventSourceMappingArn
        {
            get { return this._eventSourceMappingArn; }
            set { this._eventSourceMappingArn = value; }
        }

        // Check to see if EventSourceMappingArn property is set
        internal bool IsSetEventSourceMappingArn()
        {
            return this._eventSourceMappingArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// An object that defines the filter criteria that determine whether Lambda should process
        /// an event. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventfiltering.html">Lambda
        /// event filtering</a>.
        /// </para>
        ///  
        /// <para>
        /// If filter criteria is encrypted, this field shows up as <c>null</c> in the response
        /// of ListEventSourceMapping API calls. You can view this field in plaintext in the response
        /// of GetEventSourceMapping and DeleteEventSourceMapping calls if you have <c>kms:Decrypt</c>
        /// permissions for the correct KMS key.
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
        /// Gets and sets the property FilterCriteriaError. 
        /// <para>
        /// An object that contains details about an error related to filter criteria encryption.
        /// </para>
        /// </summary>
        public FilterCriteriaError FilterCriteriaError
        {
            get { return this._filterCriteriaError; }
            set { this._filterCriteriaError = value; }
        }

        // Check to see if FilterCriteriaError property is set
        internal bool IsSetFilterCriteriaError()
        {
            return this._filterCriteriaError != null;
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
        /// (Kinesis, DynamoDB Streams, and Amazon SQS) A list of current response type enums
        /// applied to the event source mapping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._functionResponseTypes != null && (this._functionResponseTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        ///  The ARN of the Key Management Service (KMS) customer managed key that Lambda uses
        /// to encrypt your function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventfiltering.html#filtering-basics">filter
        /// criteria</a>.
        /// </para>
        /// </summary>
        public string KMSKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KMSKeyArn property is set
        internal bool IsSetKMSKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date that the event source mapping was last updated or that its state changed.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
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
        /// The result of the event source mapping's last processing attempt.
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
        /// invoking the function. You can configure <c>MaximumBatchingWindowInSeconds</c> to
        /// any value from 0 seconds to 300 seconds in increments of seconds.
        /// </para>
        ///  
        /// <para>
        /// For streams and Amazon SQS event sources, the default batching window is 0 seconds.
        /// For Amazon MSK, Self-managed Apache Kafka, Amazon MQ, and DocumentDB event sources,
        /// the default batching window is 500 ms. Note that because you can only change <c>MaximumBatchingWindowInSeconds</c>
        /// in increments of seconds, you cannot revert back to the 500 ms default batching window
        /// after you have changed it. To restore the default batching window, you must create
        /// a new event source mapping.
        /// </para>
        ///  
        /// <para>
        /// Related setting: For streams and Amazon SQS event sources, when you set <c>BatchSize</c>
        /// to a value greater than 10, you must set <c>MaximumBatchingWindowInSeconds</c> to
        /// at least 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public int? MaximumBatchingWindowInSeconds
        {
            get { return this._maximumBatchingWindowInSeconds; }
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
        /// (Kinesis and DynamoDB Streams only) Discard records older than the specified age.
        /// The default value is -1, which sets the maximum age to infinite. When the value is
        /// set to infinite, Lambda never discards old records.
        /// </para>
        ///  <note> 
        /// <para>
        /// The minimum valid value for maximum record age is 60s. Although values less than 60
        /// and greater than -1 fall within the parameter's absolute range, they are not allowed
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=-1, Max=604800)]
        public int? MaximumRecordAgeInSeconds
        {
            get { return this._maximumRecordAgeInSeconds; }
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
        /// (Kinesis and DynamoDB Streams only) Discard records after the specified number of
        /// retries. The default value is -1, which sets the maximum number of retries to infinite.
        /// When MaximumRetryAttempts is infinite, Lambda retries failed records until the record
        /// expires in the event source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=10000)]
        public int? MaximumRetryAttempts
        {
            get { return this._maximumRetryAttempts; }
            set { this._maximumRetryAttempts = value; }
        }

        // Check to see if MaximumRetryAttempts property is set
        internal bool IsSetMaximumRetryAttempts()
        {
            return this._maximumRetryAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricsConfig. 
        /// <para>
        /// The metrics configuration for your event source. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/monitoring-metrics-types.html#event-source-mapping-metrics">Event
        /// source mapping metrics</a>.
        /// </para>
        /// </summary>
        public EventSourceMappingMetricsConfig MetricsConfig
        {
            get { return this._metricsConfig; }
            set { this._metricsConfig = value; }
        }

        // Check to see if MetricsConfig property is set
        internal bool IsSetMetricsConfig()
        {
            return this._metricsConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelizationFactor. 
        /// <para>
        /// (Kinesis and DynamoDB Streams only) The number of batches to process concurrently
        /// from each shard. The default value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? ParallelizationFactor
        {
            get { return this._parallelizationFactor; }
            set { this._parallelizationFactor = value; }
        }

        // Check to see if ParallelizationFactor property is set
        internal bool IsSetParallelizationFactor()
        {
            return this._parallelizationFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedPollerConfig. 
        /// <para>
        /// (Amazon MSK and self-managed Apache Kafka only) The provisioned mode configuration
        /// for the event source. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventsourcemapping.html#invocation-eventsourcemapping-provisioned-mode">provisioned
        /// mode</a>.
        /// </para>
        /// </summary>
        public ProvisionedPollerConfig ProvisionedPollerConfig
        {
            get { return this._provisionedPollerConfig; }
            set { this._provisionedPollerConfig = value; }
        }

        // Check to see if ProvisionedPollerConfig property is set
        internal bool IsSetProvisionedPollerConfig()
        {
            return this._provisionedPollerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        ///  (Amazon MQ) The name of the Amazon MQ broker destination queue to consume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._queues != null && (this._queues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// (Amazon SQS only) The scaling configuration for the event source. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-max-concurrency">Configuring
        /// maximum concurrency for Amazon SQS event sources</a>.
        /// </para>
        /// </summary>
        public ScalingConfig ScalingConfig
        {
            get { return this._scalingConfig; }
            set { this._scalingConfig = value; }
        }

        // Check to see if ScalingConfig property is set
        internal bool IsSetScalingConfig()
        {
            return this._scalingConfig != null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._sourceAccessConfigurations != null && (this._sourceAccessConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The position in a stream from which to start reading. Required for Amazon Kinesis
        /// and Amazon DynamoDB Stream event sources. <c>AT_TIMESTAMP</c> is supported only for
        /// Amazon Kinesis streams, Amazon DocumentDB, Amazon MSK, and self-managed Apache Kafka.
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
        /// With <c>StartingPosition</c> set to <c>AT_TIMESTAMP</c>, the time from which to start
        /// reading. <c>StartingPositionTimestamp</c> cannot be in the future.
        /// </para>
        /// </summary>
        public DateTime? StartingPositionTimestamp
        {
            get { return this._startingPositionTimestamp; }
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
        /// The state of the event source mapping. It can be one of the following: <c>Creating</c>,
        /// <c>Enabling</c>, <c>Enabled</c>, <c>Disabling</c>, <c>Disabled</c>, <c>Updating</c>,
        /// or <c>Deleting</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._topics != null && (this._topics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TumblingWindowInSeconds. 
        /// <para>
        /// (Kinesis and DynamoDB Streams only) The duration in seconds of a processing window
        /// for DynamoDB and Kinesis Streams event sources. A value of 0 seconds indicates no
        /// tumbling window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=900)]
        public int? TumblingWindowInSeconds
        {
            get { return this._tumblingWindowInSeconds; }
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