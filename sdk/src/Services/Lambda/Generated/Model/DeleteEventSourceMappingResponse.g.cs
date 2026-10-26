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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the DeleteEventSourceMapping operation.
    /// </summary>
    public partial class DeleteEventSourceMappingResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AmazonManagedKafkaEventSourceConfig. 
        /// <para>
        /// Specific configuration settings for an Amazon Managed Streaming for Apache Kafka (Amazon
        /// MSK) event source.
        /// </para>
        /// </summary>
        public AmazonManagedKafkaEventSourceConfig AmazonManagedKafkaEventSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the AmazonManagedKafkaEventSourceConfig property is set.
        /// </summary>
        internal bool IsSetAmazonManagedKafkaEventSourceConfig() => this.AmazonManagedKafkaEventSourceConfig != null;

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
        [AWSProperty(Min = 1, Max = 10000)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Checks to see if the BatchSize property is set.
        /// </summary>
        internal bool IsSetBatchSize() => this.BatchSize.HasValue;

        /// <summary>
        /// Gets and sets the property BisectBatchOnFunctionError. 
        /// <para>
        /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) If the function
        /// returns an error, split the batch in two and retry. The default value is false.
        /// </para>
        /// </summary>
        public bool? BisectBatchOnFunctionError { get; set; }

        /// <summary>
        /// Checks to see if the BisectBatchOnFunctionError property is set.
        /// </summary>
        internal bool IsSetBisectBatchOnFunctionError() => this.BisectBatchOnFunctionError.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationConfig. 
        /// <para>
        /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) A configuration
        /// object that specifies the destination of an event after Lambda processes it.
        /// </para>
        /// </summary>
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfig property is set.
        /// </summary>
        internal bool IsSetDestinationConfig() => this.DestinationConfig != null;

        /// <summary>
        /// Gets and sets the property DocumentDBEventSourceConfig. 
        /// <para>
        /// Specific configuration settings for a DocumentDB event source.
        /// </para>
        /// </summary>
        public DocumentDBEventSourceConfig DocumentDBEventSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDBEventSourceConfig property is set.
        /// </summary>
        internal bool IsSetDocumentDBEventSourceConfig() => this.DocumentDBEventSourceConfig != null;

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string EventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceArn property is set.
        /// </summary>
        internal bool IsSetEventSourceArn() => this.EventSourceArn != null;

        /// <summary>
        /// Gets and sets the property EventSourceMappingArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event source mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 85, Max = 120)]
        public string EventSourceMappingArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceMappingArn property is set.
        /// </summary>
        internal bool IsSetEventSourceMappingArn() => this.EventSourceMappingArn != null;

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
        public FilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FilterCriteria property is set.
        /// </summary>
        internal bool IsSetFilterCriteria() => this.FilterCriteria != null;

        /// <summary>
        /// Gets and sets the property FilterCriteriaError. 
        /// <para>
        /// An object that contains details about an error related to filter criteria encryption.
        /// </para>
        /// </summary>
        public FilterCriteriaError FilterCriteriaError { get; set; }

        /// <summary>
        /// Checks to see if the FilterCriteriaError property is set.
        /// </summary>
        internal bool IsSetFilterCriteriaError() => this.FilterCriteriaError != null;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The ARN of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property FunctionResponseTypes. 
        /// <para>
        /// (Kinesis, DynamoDB Streams, Amazon MSK, self-managed Apache Kafka, and Amazon SQS)
        /// A list of current response type enums applied to the event source mapping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> FunctionResponseTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FunctionResponseTypes property is set.
        /// </summary>
        internal bool IsSetFunctionResponseTypes() => this.FunctionResponseTypes != null && (this.FunctionResponseTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        ///  The ARN of the Key Management Service (KMS) customer managed key that Lambda uses
        /// to encrypt your function's <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventfiltering.html#filtering-basics">filter
        /// criteria</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string KMSKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyArn property is set.
        /// </summary>
        internal bool IsSetKMSKeyArn() => this.KMSKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date that the event source mapping was last updated or that its state changed.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property LastProcessingResult. 
        /// <para>
        /// The result of the event source mapping's last processing attempt.
        /// </para>
        /// </summary>
        public string LastProcessingResult { get; set; }

        /// <summary>
        /// Checks to see if the LastProcessingResult property is set.
        /// </summary>
        internal bool IsSetLastProcessingResult() => this.LastProcessingResult != null;

        /// <summary>
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// (Amazon MSK, and self-managed Apache Kafka only) The logging configuration for your
        /// event source. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/esm-logging.html">Event
        /// source mapping logging</a>.
        /// </para>
        /// </summary>
        public EventSourceMappingLoggingConfig LoggingConfig { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfig property is set.
        /// </summary>
        internal bool IsSetLoggingConfig() => this.LoggingConfig != null;

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
        [AWSProperty(Min = 0, Max = 300)]
        public int? MaximumBatchingWindowInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBatchingWindowInSeconds property is set.
        /// </summary>
        internal bool IsSetMaximumBatchingWindowInSeconds() => this.MaximumBatchingWindowInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumRecordAgeInSeconds. 
        /// <para>
        /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) Discard records
        /// older than the specified age. The default value is -1, which sets the maximum age
        /// to infinite. When the value is set to infinite, Lambda never discards old records.
        /// </para>
        ///  <note> 
        /// <para>
        /// The minimum valid value for maximum record age is 60s. Although values less than 60
        /// and greater than -1 fall within the parameter's absolute range, they are not allowed
        /// </para>
        ///  </note>
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
        /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) Discard records
        /// after the specified number of retries. The default value is -1, which sets the maximum
        /// number of retries to infinite. When MaximumRetryAttempts is infinite, Lambda retries
        /// failed records until the record expires in the event source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 10000)]
        public int? MaximumRetryAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaximumRetryAttempts property is set.
        /// </summary>
        internal bool IsSetMaximumRetryAttempts() => this.MaximumRetryAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property MetricsConfig. 
        /// <para>
        /// The metrics configuration for your event source. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/monitoring-metrics-types.html#event-source-mapping-metrics">Event
        /// source mapping metrics</a>.
        /// </para>
        /// </summary>
        public EventSourceMappingMetricsConfig MetricsConfig { get; set; }

        /// <summary>
        /// Checks to see if the MetricsConfig property is set.
        /// </summary>
        internal bool IsSetMetricsConfig() => this.MetricsConfig != null;

        /// <summary>
        /// Gets and sets the property ParallelizationFactor. 
        /// <para>
        /// (Kinesis and DynamoDB Streams only) The number of batches to process concurrently
        /// from each shard. The default value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? ParallelizationFactor { get; set; }

        /// <summary>
        /// Checks to see if the ParallelizationFactor property is set.
        /// </summary>
        internal bool IsSetParallelizationFactor() => this.ParallelizationFactor.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedPollerConfig. 
        /// <para>
        /// (Amazon SQS, Amazon MSK, and self-managed Apache Kafka only) The provisioned mode
        /// configuration for the event source. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventsourcemapping.html#invocation-eventsourcemapping-provisioned-mode">provisioned
        /// mode</a>.
        /// </para>
        /// </summary>
        public ProvisionedPollerConfig ProvisionedPollerConfig { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedPollerConfig property is set.
        /// </summary>
        internal bool IsSetProvisionedPollerConfig() => this.ProvisionedPollerConfig != null;

        /// <summary>
        /// Gets and sets the property Queues. 
        /// <para>
        ///  (Amazon MQ) The name of the Amazon MQ broker destination queue to consume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> Queues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Queues property is set.
        /// </summary>
        internal bool IsSetQueues() => this.Queues != null && (this.Queues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// (Amazon SQS only) The scaling configuration for the event source. For more information,
        /// see <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-max-concurrency">Configuring
        /// maximum concurrency for Amazon SQS event sources</a>.
        /// </para>
        /// </summary>
        public ScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfig property is set.
        /// </summary>
        internal bool IsSetScalingConfig() => this.ScalingConfig != null;

        /// <summary>
        /// Gets and sets the property SelfManagedEventSource. 
        /// <para>
        /// The self-managed Apache Kafka cluster for your event source.
        /// </para>
        /// </summary>
        public SelfManagedEventSource SelfManagedEventSource { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedEventSource property is set.
        /// </summary>
        internal bool IsSetSelfManagedEventSource() => this.SelfManagedEventSource != null;

        /// <summary>
        /// Gets and sets the property SelfManagedKafkaEventSourceConfig. 
        /// <para>
        /// Specific configuration settings for a self-managed Apache Kafka event source.
        /// </para>
        /// </summary>
        public SelfManagedKafkaEventSourceConfig SelfManagedKafkaEventSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedKafkaEventSourceConfig property is set.
        /// </summary>
        internal bool IsSetSelfManagedKafkaEventSourceConfig() => this.SelfManagedKafkaEventSourceConfig != null;

        /// <summary>
        /// Gets and sets the property SourceAccessConfigurations. 
        /// <para>
        /// An array of the authentication protocol, VPC components, or virtual host to secure
        /// and define your event source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 23)]
        public List<SourceAccessConfiguration> SourceAccessConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceAccessConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SourceAccessConfigurations property is set.
        /// </summary>
        internal bool IsSetSourceAccessConfigurations() => this.SourceAccessConfigurations != null && (this.SourceAccessConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The position in a stream from which to start reading. Required for Amazon Kinesis
        /// and Amazon DynamoDB Stream event sources. <c>AT_TIMESTAMP</c> is supported only for
        /// Amazon Kinesis streams, Amazon DocumentDB, Amazon MSK, and self-managed Apache Kafka.
        /// </para>
        /// </summary>
        public EventSourcePosition StartingPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartingPosition property is set.
        /// </summary>
        internal bool IsSetStartingPosition() => this.StartingPosition != null;

        /// <summary>
        /// Gets and sets the property StartingPositionTimestamp. 
        /// <para>
        /// With <c>StartingPosition</c> set to <c>AT_TIMESTAMP</c>, the time from which to start
        /// reading. <c>StartingPositionTimestamp</c> cannot be in the future.
        /// </para>
        /// </summary>
        public DateTime? StartingPositionTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartingPositionTimestamp property is set.
        /// </summary>
        internal bool IsSetStartingPositionTimestamp() => this.StartingPositionTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the event source mapping. It can be one of the following: <c>Creating</c>,
        /// <c>Enabling</c>, <c>Enabled</c>, <c>Disabling</c>, <c>Disabled</c>, <c>Updating</c>,
        /// or <c>Deleting</c>.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// Indicates whether a user or Lambda made the last change to the event source mapping.
        /// </para>
        /// </summary>
        public string StateTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the StateTransitionReason property is set.
        /// </summary>
        internal bool IsSetStateTransitionReason() => this.StateTransitionReason != null;

        /// <summary>
        /// Gets and sets the property Topics. 
        /// <para>
        /// The name of the Kafka topic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> Topics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Topics property is set.
        /// </summary>
        internal bool IsSetTopics() => this.Topics != null && (this.Topics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TumblingWindowInSeconds. 
        /// <para>
        /// (Kinesis and DynamoDB Streams only) The duration in seconds of a processing window
        /// for DynamoDB and Kinesis Streams event sources. A value of 0 seconds indicates no
        /// tumbling window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 900)]
        public int? TumblingWindowInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TumblingWindowInSeconds property is set.
        /// </summary>
        internal bool IsSetTumblingWindowInSeconds() => this.TumblingWindowInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The identifier of the event source mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string UUID { get; set; }

        /// <summary>
        /// Checks to see if the UUID property is set.
        /// </summary>
        internal bool IsSetUUID() => this.UUID != null;
    }
}
