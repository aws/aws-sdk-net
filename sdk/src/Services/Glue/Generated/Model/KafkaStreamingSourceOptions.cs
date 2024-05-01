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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private string _addRecordTimestamp;
        private string _assign;
        private string _bootstrapServers;
        private string _classification;
        private string _connectionName;
        private string _delimiter;
        private string _emitConsumerLagMetrics;
        private string _endingOffsets;
        private bool? _includeHeaders;
        private long? _maxOffsetsPerTrigger;
        private int? _minPartitions;
        private int? _numRetries;
        private long? _pollTimeoutMs;
        private long? _retryIntervalMs;
        private string _securityProtocol;
        private string _startingOffsets;
        private DateTime? _startingTimestamp;
        private string _subscribePattern;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property AddRecordTimestamp. 
        /// <para>
        /// When this option is set to 'true', the data output will contain an additional column
        /// named "__src_timestamp" that indicates the time when the corresponding record received
        /// by the topic. The default value is 'false'. This option is supported in Glue version
        /// 4.0 or later.
        /// </para>
        /// </summary>
        public string AddRecordTimestamp
        {
            get { return this._addRecordTimestamp; }
            set { this._addRecordTimestamp = value; }
        }

        // Check to see if AddRecordTimestamp property is set
        internal bool IsSetAddRecordTimestamp()
        {
            return this._addRecordTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property Assign. 
        /// <para>
        /// The specific <c>TopicPartitions</c> to consume. You must specify at least one of <c>"topicName"</c>,
        /// <c>"assign"</c> or <c>"subscribePattern"</c>.
        /// </para>
        /// </summary>
        public string Assign
        {
            get { return this._assign; }
            set { this._assign = value; }
        }

        // Check to see if Assign property is set
        internal bool IsSetAssign()
        {
            return this._assign != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapServers. 
        /// <para>
        /// A list of bootstrap server URLs, for example, as <c>b-1.vpc-test-2.o4q88o.c6.kafka.us-east-1.amazonaws.com:9094</c>.
        /// This option must be specified in the API call or defined in the table metadata in
        /// the Data Catalog.
        /// </para>
        /// </summary>
        public string BootstrapServers
        {
            get { return this._bootstrapServers; }
            set { this._bootstrapServers = value; }
        }

        // Check to see if BootstrapServers property is set
        internal bool IsSetBootstrapServers()
        {
            return this._bootstrapServers != null;
        }

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// An optional classification.
        /// </para>
        /// </summary>
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection.
        /// </para>
        /// </summary>
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// Specifies the delimiter character.
        /// </para>
        /// </summary>
        public string Delimiter
        {
            get { return this._delimiter; }
            set { this._delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this._delimiter != null;
        }

        /// <summary>
        /// Gets and sets the property EmitConsumerLagMetrics. 
        /// <para>
        /// When this option is set to 'true', for each batch, it will emit the metrics for the
        /// duration between the oldest record received by the topic and the time it arrives in
        /// Glue to CloudWatch. The metric's name is "glue.driver.streaming.maxConsumerLagInMs".
        /// The default value is 'false'. This option is supported in Glue version 4.0 or later.
        /// </para>
        /// </summary>
        public string EmitConsumerLagMetrics
        {
            get { return this._emitConsumerLagMetrics; }
            set { this._emitConsumerLagMetrics = value; }
        }

        // Check to see if EmitConsumerLagMetrics property is set
        internal bool IsSetEmitConsumerLagMetrics()
        {
            return this._emitConsumerLagMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property EndingOffsets. 
        /// <para>
        /// The end point when a batch query is ended. Possible values are either <c>"latest"</c>
        /// or a JSON string that specifies an ending offset for each <c>TopicPartition</c>.
        /// </para>
        /// </summary>
        public string EndingOffsets
        {
            get { return this._endingOffsets; }
            set { this._endingOffsets = value; }
        }

        // Check to see if EndingOffsets property is set
        internal bool IsSetEndingOffsets()
        {
            return this._endingOffsets != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeHeaders. 
        /// <para>
        /// Whether to include the Kafka headers. When the option is set to "true", the data output
        /// will contain an additional column named "glue_streaming_kafka_headers" with type <c>Array[Struct(key:
        /// String, value: String)]</c>. The default value is "false". This option is available
        /// in Glue version 3.0 or later only.
        /// </para>
        /// </summary>
        public bool? IncludeHeaders
        {
            get { return this._includeHeaders; }
            set { this._includeHeaders = value; }
        }

        // Check to see if IncludeHeaders property is set
        internal bool IsSetIncludeHeaders()
        {
            return this._includeHeaders.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxOffsetsPerTrigger. 
        /// <para>
        /// The rate limit on the maximum number of offsets that are processed per trigger interval.
        /// The specified total number of offsets is proportionally split across <c>topicPartitions</c>
        /// of different volumes. The default value is null, which means that the consumer reads
        /// all offsets until the known latest offset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? MaxOffsetsPerTrigger
        {
            get { return this._maxOffsetsPerTrigger; }
            set { this._maxOffsetsPerTrigger = value; }
        }

        // Check to see if MaxOffsetsPerTrigger property is set
        internal bool IsSetMaxOffsetsPerTrigger()
        {
            return this._maxOffsetsPerTrigger.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinPartitions. 
        /// <para>
        /// The desired minimum number of partitions to read from Kafka. The default value is
        /// null, which means that the number of spark partitions is equal to the number of Kafka
        /// partitions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MinPartitions
        {
            get { return this._minPartitions; }
            set { this._minPartitions = value; }
        }

        // Check to see if MinPartitions property is set
        internal bool IsSetMinPartitions()
        {
            return this._minPartitions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumRetries. 
        /// <para>
        /// The number of times to retry before failing to fetch Kafka offsets. The default value
        /// is <c>3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumRetries
        {
            get { return this._numRetries; }
            set { this._numRetries = value; }
        }

        // Check to see if NumRetries property is set
        internal bool IsSetNumRetries()
        {
            return this._numRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PollTimeoutMs. 
        /// <para>
        /// The timeout in milliseconds to poll data from Kafka in Spark job executors. The default
        /// value is <c>512</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? PollTimeoutMs
        {
            get { return this._pollTimeoutMs; }
            set { this._pollTimeoutMs = value; }
        }

        // Check to see if PollTimeoutMs property is set
        internal bool IsSetPollTimeoutMs()
        {
            return this._pollTimeoutMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryIntervalMs. 
        /// <para>
        /// The time in milliseconds to wait before retrying to fetch Kafka offsets. The default
        /// value is <c>10</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? RetryIntervalMs
        {
            get { return this._retryIntervalMs; }
            set { this._retryIntervalMs = value; }
        }

        // Check to see if RetryIntervalMs property is set
        internal bool IsSetRetryIntervalMs()
        {
            return this._retryIntervalMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityProtocol. 
        /// <para>
        /// The protocol used to communicate with brokers. The possible values are <c>"SSL"</c>
        /// or <c>"PLAINTEXT"</c>.
        /// </para>
        /// </summary>
        public string SecurityProtocol
        {
            get { return this._securityProtocol; }
            set { this._securityProtocol = value; }
        }

        // Check to see if SecurityProtocol property is set
        internal bool IsSetSecurityProtocol()
        {
            return this._securityProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property StartingOffsets. 
        /// <para>
        /// The starting position in the Kafka topic to read data from. The possible values are
        /// <c>"earliest"</c> or <c>"latest"</c>. The default value is <c>"latest"</c>.
        /// </para>
        /// </summary>
        public string StartingOffsets
        {
            get { return this._startingOffsets; }
            set { this._startingOffsets = value; }
        }

        // Check to see if StartingOffsets property is set
        internal bool IsSetStartingOffsets()
        {
            return this._startingOffsets != null;
        }

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
        public DateTime? StartingTimestamp
        {
            get { return this._startingTimestamp; }
            set { this._startingTimestamp = value; }
        }

        // Check to see if StartingTimestamp property is set
        internal bool IsSetStartingTimestamp()
        {
            return this._startingTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubscribePattern. 
        /// <para>
        /// A Java regex string that identifies the topic list to subscribe to. You must specify
        /// at least one of <c>"topicName"</c>, <c>"assign"</c> or <c>"subscribePattern"</c>.
        /// </para>
        /// </summary>
        public string SubscribePattern
        {
            get { return this._subscribePattern; }
            set { this._subscribePattern = value; }
        }

        // Check to see if SubscribePattern property is set
        internal bool IsSetSubscribePattern()
        {
            return this._subscribePattern != null;
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The topic name as specified in Apache Kafka. You must specify at least one of <c>"topicName"</c>,
        /// <c>"assign"</c> or <c>"subscribePattern"</c>.
        /// </para>
        /// </summary>
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

    }
}