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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Additional options for streaming.
    /// </summary>
    public partial class KafkaStreamingSourceOptions
    {
        /// <summary>
        /// Gets and sets the property AddRecordTimestamp. 
        /// <para>
        /// When this option is set to 'true', the data output will contain an additional column
        /// named "__src_timestamp" that indicates the time when the corresponding record received
        /// by the topic. The default value is 'false'. This option is supported in Glue version
        /// 4.0 or later.
        /// </para>
        /// </summary>
        public string AddRecordTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AddRecordTimestamp property is set.
        /// </summary>
        internal bool IsSetAddRecordTimestamp() => this.AddRecordTimestamp != null;

        /// <summary>
        /// Gets and sets the property Assign. 
        /// <para>
        /// The specific <c>TopicPartitions</c> to consume. You must specify at least one of <c>"topicName"</c>,
        /// <c>"assign"</c> or <c>"subscribePattern"</c>.
        /// </para>
        /// </summary>
        public string Assign { get; set; }

        /// <summary>
        /// Checks to see if the Assign property is set.
        /// </summary>
        internal bool IsSetAssign() => this.Assign != null;

        /// <summary>
        /// Gets and sets the property BootstrapServers. 
        /// <para>
        /// A list of bootstrap server URLs, for example, as <c>b-1.vpc-test-2.o4q88o.c6.kafka.us-east-1.amazonaws.com:9094</c>.
        /// This option must be specified in the API call or defined in the table metadata in
        /// the Data Catalog.
        /// </para>
        /// </summary>
        public string BootstrapServers { get; set; }

        /// <summary>
        /// Checks to see if the BootstrapServers property is set.
        /// </summary>
        internal bool IsSetBootstrapServers() => this.BootstrapServers != null;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// An optional classification.
        /// </para>
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Checks to see if the Classification property is set.
        /// </summary>
        internal bool IsSetClassification() => this.Classification != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection.
        /// </para>
        /// </summary>
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// Specifies the delimiter character.
        /// </para>
        /// </summary>
        public string Delimiter { get; set; }

        /// <summary>
        /// Checks to see if the Delimiter property is set.
        /// </summary>
        internal bool IsSetDelimiter() => this.Delimiter != null;

        /// <summary>
        /// Gets and sets the property EmitConsumerLagMetrics. 
        /// <para>
        /// When this option is set to 'true', for each batch, it will emit the metrics for the
        /// duration between the oldest record received by the topic and the time it arrives in
        /// Glue to CloudWatch. The metric's name is "glue.driver.streaming.maxConsumerLagInMs".
        /// The default value is 'false'. This option is supported in Glue version 4.0 or later.
        /// </para>
        /// </summary>
        public string EmitConsumerLagMetrics { get; set; }

        /// <summary>
        /// Checks to see if the EmitConsumerLagMetrics property is set.
        /// </summary>
        internal bool IsSetEmitConsumerLagMetrics() => this.EmitConsumerLagMetrics != null;

        /// <summary>
        /// Gets and sets the property EndingOffsets. 
        /// <para>
        /// The end point when a batch query is ended. Possible values are either <c>"latest"</c>
        /// or a JSON string that specifies an ending offset for each <c>TopicPartition</c>.
        /// </para>
        /// </summary>
        public string EndingOffsets { get; set; }

        /// <summary>
        /// Checks to see if the EndingOffsets property is set.
        /// </summary>
        internal bool IsSetEndingOffsets() => this.EndingOffsets != null;

        /// <summary>
        /// Gets and sets the property IncludeHeaders. 
        /// <para>
        /// Whether to include the Kafka headers. When the option is set to "true", the data output
        /// will contain an additional column named "glue_streaming_kafka_headers" with type <c>Array[Struct(key:
        /// String, value: String)]</c>. The default value is "false". This option is available
        /// in Glue version 3.0 or later only.
        /// </para>
        /// </summary>
        public bool? IncludeHeaders { get; set; }

        /// <summary>
        /// Checks to see if the IncludeHeaders property is set.
        /// </summary>
        internal bool IsSetIncludeHeaders() => this.IncludeHeaders.HasValue;

        /// <summary>
        /// Gets and sets the property MaxOffsetsPerTrigger. 
        /// <para>
        /// The rate limit on the maximum number of offsets that are processed per trigger interval.
        /// The specified total number of offsets is proportionally split across <c>topicPartitions</c>
        /// of different volumes. The default value is null, which means that the consumer reads
        /// all offsets until the known latest offset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MaxOffsetsPerTrigger { get; set; }

        /// <summary>
        /// Checks to see if the MaxOffsetsPerTrigger property is set.
        /// </summary>
        internal bool IsSetMaxOffsetsPerTrigger() => this.MaxOffsetsPerTrigger.HasValue;

        /// <summary>
        /// Gets and sets the property MinPartitions. 
        /// <para>
        /// The desired minimum number of partitions to read from Kafka. The default value is
        /// null, which means that the number of spark partitions is equal to the number of Kafka
        /// partitions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MinPartitions { get; set; }

        /// <summary>
        /// Checks to see if the MinPartitions property is set.
        /// </summary>
        internal bool IsSetMinPartitions() => this.MinPartitions.HasValue;

        /// <summary>
        /// Gets and sets the property NumRetries. 
        /// <para>
        /// The number of times to retry before failing to fetch Kafka offsets. The default value
        /// is <c>3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? NumRetries { get; set; }

        /// <summary>
        /// Checks to see if the NumRetries property is set.
        /// </summary>
        internal bool IsSetNumRetries() => this.NumRetries.HasValue;

        /// <summary>
        /// Gets and sets the property PollTimeoutMs. 
        /// <para>
        /// The timeout in milliseconds to poll data from Kafka in Spark job executors. The default
        /// value is <c>512</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? PollTimeoutMs { get; set; }

        /// <summary>
        /// Checks to see if the PollTimeoutMs property is set.
        /// </summary>
        internal bool IsSetPollTimeoutMs() => this.PollTimeoutMs.HasValue;

        /// <summary>
        /// Gets and sets the property RetryIntervalMs. 
        /// <para>
        /// The time in milliseconds to wait before retrying to fetch Kafka offsets. The default
        /// value is <c>10</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RetryIntervalMs { get; set; }

        /// <summary>
        /// Checks to see if the RetryIntervalMs property is set.
        /// </summary>
        internal bool IsSetRetryIntervalMs() => this.RetryIntervalMs.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityProtocol. 
        /// <para>
        /// The protocol used to communicate with brokers. The possible values are <c>"SSL"</c>
        /// or <c>"PLAINTEXT"</c>.
        /// </para>
        /// </summary>
        public string SecurityProtocol { get; set; }

        /// <summary>
        /// Checks to see if the SecurityProtocol property is set.
        /// </summary>
        internal bool IsSetSecurityProtocol() => this.SecurityProtocol != null;

        /// <summary>
        /// Gets and sets the property StartingOffsets. 
        /// <para>
        /// The starting position in the Kafka topic to read data from. The possible values are
        /// <c>"earliest"</c> or <c>"latest"</c>. The default value is <c>"latest"</c>.
        /// </para>
        /// </summary>
        public string StartingOffsets { get; set; }

        /// <summary>
        /// Checks to see if the StartingOffsets property is set.
        /// </summary>
        internal bool IsSetStartingOffsets() => this.StartingOffsets != null;

        /// <summary>
        /// Gets and sets the property StartingTimestamp. 
        /// <para>
        /// The timestamp of the record in the Kafka topic to start reading data from. The possible
        /// values are a timestamp string in UTC format of the pattern <c>yyyy-mm-ddTHH:MM:SSZ</c>
        /// (where Z represents a UTC timezone offset with a +/-. For example: "2023-04-04T08:00:00+08:00").
        /// 
        /// </para>
        ///  
        /// <para>
        /// Only one of <c>StartingTimestamp</c> or <c>StartingOffsets</c> must be set.
        /// </para>
        /// </summary>
        public DateTime? StartingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartingTimestamp property is set.
        /// </summary>
        internal bool IsSetStartingTimestamp() => this.StartingTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SubscribePattern. 
        /// <para>
        /// A Java regex string that identifies the topic list to subscribe to. You must specify
        /// at least one of <c>"topicName"</c>, <c>"assign"</c> or <c>"subscribePattern"</c>.
        /// </para>
        /// </summary>
        public string SubscribePattern { get; set; }

        /// <summary>
        /// Checks to see if the SubscribePattern property is set.
        /// </summary>
        internal bool IsSetSubscribePattern() => this.SubscribePattern != null;

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The topic name as specified in Apache Kafka. You must specify at least one of <c>"topicName"</c>,
        /// <c>"assign"</c> or <c>"subscribePattern"</c>.
        /// </para>
        /// </summary>
        public string TopicName { get; set; }

        /// <summary>
        /// Checks to see if the TopicName property is set.
        /// </summary>
        internal bool IsSetTopicName() => this.TopicName != null;
    }
}
