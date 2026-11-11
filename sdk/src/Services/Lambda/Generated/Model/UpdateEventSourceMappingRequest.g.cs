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
    /// Container for the parameters to the UpdateEventSourceMapping operation. Updates an
    /// event source mapping. You can change the function that Lambda invokes, or pause invocation
    /// and resume later from the same location. <para> For details about how to configure
    /// different event sources, see the following topics. </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-dynamodb-eventsourcemapping">
    /// Amazon DynamoDB Streams</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-eventsourcemapping">
    /// Amazon Kinesis</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#events-sqs-eventsource">
    /// Amazon SQS</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-eventsourcemapping">
    /// Amazon MQ and RabbitMQ</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html">
    /// Amazon MSK</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/kafka-smaa.html">
    /// Apache Kafka</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-documentdb.html">
    /// Amazon DocumentDB</a> </para> </li> </ul> <para> The following error handling options
    /// are available for stream sources (DynamoDB, Kinesis, Amazon MSK, and self-managed
    /// Apache Kafka): </para> <ul> <li> <para> <c>BisectBatchOnFunctionError</c> – If the
    /// function returns an error, split the batch in two and retry. </para> </li> <li> <para>
    /// <c>MaximumRecordAgeInSeconds</c> – Discard records older than the specified age. The
    /// default value is infinite (-1). When set to infinite (-1), failed records are retried
    /// until the record expires </para> </li> <li> <para> <c>MaximumRetryAttempts</c> – Discard
    /// records after the specified number of retries. The default value is infinite (-1).
    /// When set to infinite (-1), failed records are retried until the record expires. </para>
    /// </li> <li> <para> <c>OnFailure</c> – Send discarded records to an Amazon SQS queue,
    /// Amazon SNS topic, Kafka topic, or Amazon S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-async-retain-records.html#invocation-async-destinations">Adding
    /// a destination</a>. </para> </li> </ul> <para> The following option is available only
    /// for DynamoDB and Kinesis event sources: </para> <ul> <li> <para> <c>ParallelizationFactor</c>
    /// – Process multiple batches from each shard concurrently. </para> </li> </ul> <para>
    /// For information about which configuration parameters apply to each event source, see
    /// the following topics. </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-ddb.html#services-ddb-params">
    /// Amazon DynamoDB Streams</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kinesis.html#services-kinesis-params">
    /// Amazon Kinesis</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-sqs.html#services-sqs-params">
    /// Amazon SQS</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-mq.html#services-mq-params">
    /// Amazon MQ and RabbitMQ</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-msk.html#services-msk-parms">
    /// Amazon MSK</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-kafka.html#services-kafka-parms">
    /// Apache Kafka</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/lambda/latest/dg/with-documentdb.html#docdb-configuration">
    /// Amazon DocumentDB</a> </para> </li> </ul>
    /// </summary>
    public partial class UpdateEventSourceMappingRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property AmazonManagedKafkaEventSourceConfig.
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
        /// returns an error, split the batch in two and retry.
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
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// An object that defines the filter criteria that determine whether Lambda should process
        /// an event. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-eventfiltering.html">Lambda
        /// event filtering</a>.
        /// </para>
        /// </summary>
        public FilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FilterCriteria property is set.
        /// </summary>
        internal bool IsSetFilterCriteria() => this.FilterCriteria != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

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
        /// criteria</a>. By default, Lambda does not encrypt your filter criteria object. Specify
        /// this property to encrypt data using your own customer managed key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string KMSKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KMSKeyArn property is set.
        /// </summary>
        internal bool IsSetKMSKeyArn() => this.KMSKeyArn != null;

        /// <summary>
        /// Gets and sets the property LoggingConfig.
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
        ///  
        /// <para>
        /// Not supported for Kafka event source mappings when <c>ConsumptionMode</c> is <c>Queue</c>.
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
        /// older than the specified age. The default value is infinite (-1).
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
        /// (Kinesis, DynamoDB Streams, Amazon MSK, and self-managed Apache Kafka) Discard records
        /// after the specified number of retries. The default value is infinite (-1). When set
        /// to infinite (-1), failed records are retried until the record expires.
        /// </para>
        ///  
        /// <para>
        /// For Kafka <c>Stream</c> consumption mode, the default is <c>-1</c> (infinite retries;
        /// capped at 10 when an on-failure destination is configured). For Kafka <c>Queue</c>
        /// consumption mode, the default is <c>0</c>, and if no on-failure destination is configured
        /// the Kafka broker performs retries.
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
        /// (Kinesis and DynamoDB Streams only) The number of batches to process from each shard
        /// concurrently.
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
        /// Gets and sets the property SelfManagedKafkaEventSourceConfig.
        /// </summary>
        public SelfManagedKafkaEventSourceConfig SelfManagedKafkaEventSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the SelfManagedKafkaEventSourceConfig property is set.
        /// </summary>
        internal bool IsSetSelfManagedKafkaEventSourceConfig() => this.SelfManagedKafkaEventSourceConfig != null;

        /// <summary>
        /// Gets and sets the property SourceAccessConfigurations. 
        /// <para>
        /// An array of authentication protocols or VPC components required to secure your event
        /// source.
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
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string UUID { get; set; }

        /// <summary>
        /// Checks to see if the UUID property is set.
        /// </summary>
        internal bool IsSetUUID() => this.UUID != null;
    }
}
