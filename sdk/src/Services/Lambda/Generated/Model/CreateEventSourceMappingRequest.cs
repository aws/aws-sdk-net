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
    /// Container for the parameters to the CreateEventSourceMapping operation.
    /// Creates a mapping between an event source and an Lambda function. Lambda reads items
    /// from the event source and invokes the function.
    /// 
    ///  
    /// <para>
    /// For details about how to configure different event sources, see the following topics.
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
    /// Amazon DynamoDB Streams</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
    /// Amazon Kinesis</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
    /// Amazon SQS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
    /// Amazon MQ and RabbitMQ</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html"> Amazon MSK</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html"> Apache Kafka</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-documentdb.html"> Amazon
    /// DocumentDB</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following error handling options are available only for DynamoDB and Kinesis event
    /// sources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>BisectBatchOnFunctionError</c> – If the function returns an error, split the batch
    /// in two and retry.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MaximumRecordAgeInSeconds</c> – Discard records older than the specified age.
    /// The default value is infinite (-1). When set to infinite (-1), failed records are
    /// retried until the record expires
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MaximumRetryAttempts</c> – Discard records after the specified number of retries.
    /// The default value is infinite (-1). When set to infinite (-1), failed records are
    /// retried until the record expires.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ParallelizationFactor</c> – Process multiple batches from each shard concurrently.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For stream sources (DynamoDB, Kinesis, Amazon MSK, and self-managed Apache Kafka),
    /// the following option is also available:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>OnFailure</c> – Send discarded records to an Amazon SQS queue, Amazon SNS topic,
    /// or Amazon S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations">Adding
    /// a destination</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about which configuration parameters apply to each event source, see
    /// the following topics.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
    /// Amazon DynamoDB Streams</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
    /// Amazon Kinesis</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
    /// Amazon SQS</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
    /// Amazon MQ and RabbitMQ</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
    /// Amazon MSK</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
    /// Apache Kafka</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-documentdb.html#docdb-configuration">
    /// Amazon DocumentDB</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateEventSourceMappingRequest : AmazonLambdaRequest
    {
        private AmazonManagedKafkaEventSourceConfig _amazonManagedKafkaEventSourceConfig;
        private int? _batchSize;
        private bool? _bisectBatchOnFunctionError;
        private DestinationConfig _destinationConfig;
        private DocumentDBEventSourceConfig _documentDBEventSourceConfig;
        private bool? _enabled;
        private string _eventSourceArn;
        private FilterCriteria _filterCriteria;
        private string _functionName;
        private List<string> _functionResponseTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _kmsKeyArn;
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
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _topics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _tumblingWindowInSeconds;

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
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Kinesis</b> – Default 100. Max 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon DynamoDB Streams</b> – Default 100. Max 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Simple Queue Service</b> – Default 10. For standard queues the max is 10,000.
        /// For FIFO queues the max is 10.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Managed Streaming for Apache Kafka</b> – Default 100. Max 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Self-managed Apache Kafka</b> – Default 100. Max 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon MQ (ActiveMQ and RabbitMQ)</b> – Default 100. Max 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DocumentDB</b> – Default 100. Max 10,000.
        /// </para>
        ///  </li> </ul>
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
        /// in two and retry.
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
        /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Kafka only) A configuration
        /// object that specifies the destination of an event after Lambda processes it.
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// When true, the event source mapping is active. When false, Lambda pauses polling and
        /// invocation.
        /// </para>
        ///  
        /// <para>
        /// Default: True
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event source.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Amazon Kinesis</b> – The ARN of the data stream or a stream consumer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon DynamoDB Streams</b> – The ARN of the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Simple Queue Service</b> – The ARN of the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon Managed Streaming for Apache Kafka</b> – The ARN of the cluster or the
        /// ARN of the VPC connection (for <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#msk-multi-vpc">cross-account
        /// event source mappings</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon MQ</b> – The ARN of the broker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon DocumentDB</b> – The ARN of the DocumentDB change stream.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <c>MyFunction</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <c>arn:aws:lambda:us-west-2:123456789012:function:MyFunction</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Version or Alias ARN</b> – <c>arn:aws:lambda:us-west-2:123456789012:function:MyFunction:PROD</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <c>123456789012:function:MyFunction</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it's limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
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
        /// criteria</a>. By default, Lambda does not encrypt your filter criteria object. Specify
        /// this property to encrypt data using your own customer managed key. 
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
        /// Gets and sets the property MaximumBatchingWindowInSeconds. 
        /// <para>
        /// The maximum amount of time, in seconds, that Lambda spends gathering records before
        /// invoking the function. You can configure <c>MaximumBatchingWindowInSeconds</c> to
        /// any value from 0 seconds to 300 seconds in increments of seconds.
        /// </para>
        ///  
        /// <para>
        /// For Kinesis, DynamoDB, and Amazon SQS event sources, the default batching window is
        /// 0 seconds. For Amazon MSK, Self-managed Apache Kafka, Amazon MQ, and DocumentDB event
        /// sources, the default batching window is 500 ms. Note that because you can only change
        /// <c>MaximumBatchingWindowInSeconds</c> in increments of seconds, you cannot revert
        /// back to the 500 ms default batching window after you have changed it. To restore the
        /// default batching window, you must create a new event source mapping.
        /// </para>
        ///  
        /// <para>
        /// Related setting: For Kinesis, DynamoDB, and Amazon SQS event sources, when you set
        /// <c>BatchSize</c> to a value greater than 10, you must set <c>MaximumBatchingWindowInSeconds</c>
        /// to at least 1.
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
        /// The default value is infinite (-1).
        /// </para>
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
        /// retries. The default value is infinite (-1). When set to infinite (-1), failed records
        /// are retried until the record expires.
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
        /// (Kinesis and DynamoDB Streams only) The number of batches to process from each shard
        /// concurrently.
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
        ///  (MQ) The name of the Amazon MQ broker destination queue to consume. 
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
        /// The self-managed Apache Kafka cluster to receive records from.
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
        /// An array of authentication protocols or VPC components required to secure your event
        /// source.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to apply to the event source mapping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
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

    }
}