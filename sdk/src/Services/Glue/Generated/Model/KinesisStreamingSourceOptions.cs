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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Additional options for the Amazon Kinesis streaming data source.
    /// </summary>
    public partial class KinesisStreamingSourceOptions
    {
        private bool? _addIdleTimeBetweenReads;
        private string _addRecordTimestamp;
        private bool? _avoidEmptyBatches;
        private string _classification;
        private string _delimiter;
        private long? _describeShardInterval;
        private string _emitConsumerLagMetrics;
        private string _endpointUrl;
        private long? _idleTimeBetweenReadsInMs;
        private long? _maxFetchRecordsPerShard;
        private long? _maxFetchTimeInMs;
        private long? _maxRecordPerRead;
        private long? _maxRetryIntervalMs;
        private int? _numRetries;
        private long? _retryIntervalMs;
        private string _roleArn;
        private string _roleSessionName;
        private StartingPosition _startingPosition;
        private string _streamArn;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property AddIdleTimeBetweenReads. 
        /// <para>
        /// Adds a time delay between two consecutive getRecords operations. The default value
        /// is <code>"False"</code>. This option is only configurable for Glue version 2.0 and
        /// above.
        /// </para>
        /// </summary>
        public bool AddIdleTimeBetweenReads
        {
            get { return this._addIdleTimeBetweenReads.GetValueOrDefault(); }
            set { this._addIdleTimeBetweenReads = value; }
        }

        // Check to see if AddIdleTimeBetweenReads property is set
        internal bool IsSetAddIdleTimeBetweenReads()
        {
            return this._addIdleTimeBetweenReads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AddRecordTimestamp. 
        /// <para>
        /// When this option is set to 'true', the data output will contain an additional column
        /// named "__src_timestamp" that indicates the time when the corresponding record received
        /// by the stream. The default value is 'false'. This option is supported in Glue version
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
        /// Gets and sets the property AvoidEmptyBatches. 
        /// <para>
        /// Avoids creating an empty microbatch job by checking for unread data in the Kinesis
        /// data stream before the batch is started. The default value is <code>"False"</code>.
        /// </para>
        /// </summary>
        public bool AvoidEmptyBatches
        {
            get { return this._avoidEmptyBatches.GetValueOrDefault(); }
            set { this._avoidEmptyBatches = value; }
        }

        // Check to see if AvoidEmptyBatches property is set
        internal bool IsSetAvoidEmptyBatches()
        {
            return this._avoidEmptyBatches.HasValue; 
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
        /// Gets and sets the property DescribeShardInterval. 
        /// <para>
        /// The minimum time interval between two ListShards API calls for your script to consider
        /// resharding. The default value is <code>1s</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long DescribeShardInterval
        {
            get { return this._describeShardInterval.GetValueOrDefault(); }
            set { this._describeShardInterval = value; }
        }

        // Check to see if DescribeShardInterval property is set
        internal bool IsSetDescribeShardInterval()
        {
            return this._describeShardInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EmitConsumerLagMetrics. 
        /// <para>
        /// When this option is set to 'true', for each batch, it will emit the metrics for the
        /// duration between the oldest record received by the stream and the time it arrives
        /// in Glue to CloudWatch. The metric's name is "glue.driver.streaming.maxConsumerLagInMs".
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
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// The URL of the Kinesis endpoint.
        /// </para>
        /// </summary>
        public string EndpointUrl
        {
            get { return this._endpointUrl; }
            set { this._endpointUrl = value; }
        }

        // Check to see if EndpointUrl property is set
        internal bool IsSetEndpointUrl()
        {
            return this._endpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property IdleTimeBetweenReadsInMs. 
        /// <para>
        /// The minimum time delay between two consecutive getRecords operations, specified in
        /// ms. The default value is <code>1000</code>. This option is only configurable for Glue
        /// version 2.0 and above.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long IdleTimeBetweenReadsInMs
        {
            get { return this._idleTimeBetweenReadsInMs.GetValueOrDefault(); }
            set { this._idleTimeBetweenReadsInMs = value; }
        }

        // Check to see if IdleTimeBetweenReadsInMs property is set
        internal bool IsSetIdleTimeBetweenReadsInMs()
        {
            return this._idleTimeBetweenReadsInMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFetchRecordsPerShard. 
        /// <para>
        /// The maximum number of records to fetch per shard in the Kinesis data stream. The default
        /// value is <code>100000</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long MaxFetchRecordsPerShard
        {
            get { return this._maxFetchRecordsPerShard.GetValueOrDefault(); }
            set { this._maxFetchRecordsPerShard = value; }
        }

        // Check to see if MaxFetchRecordsPerShard property is set
        internal bool IsSetMaxFetchRecordsPerShard()
        {
            return this._maxFetchRecordsPerShard.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFetchTimeInMs. 
        /// <para>
        /// The maximum time spent in the job executor to fetch a record from the Kinesis data
        /// stream per shard, specified in milliseconds (ms). The default value is <code>1000</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long MaxFetchTimeInMs
        {
            get { return this._maxFetchTimeInMs.GetValueOrDefault(); }
            set { this._maxFetchTimeInMs = value; }
        }

        // Check to see if MaxFetchTimeInMs property is set
        internal bool IsSetMaxFetchTimeInMs()
        {
            return this._maxFetchTimeInMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecordPerRead. 
        /// <para>
        /// The maximum number of records to fetch from the Kinesis data stream in each getRecords
        /// operation. The default value is <code>10000</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long MaxRecordPerRead
        {
            get { return this._maxRecordPerRead.GetValueOrDefault(); }
            set { this._maxRecordPerRead = value; }
        }

        // Check to see if MaxRecordPerRead property is set
        internal bool IsSetMaxRecordPerRead()
        {
            return this._maxRecordPerRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetryIntervalMs. 
        /// <para>
        /// The maximum cool-off time period (specified in ms) between two retries of a Kinesis
        /// Data Streams API call. The default value is <code>10000</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long MaxRetryIntervalMs
        {
            get { return this._maxRetryIntervalMs.GetValueOrDefault(); }
            set { this._maxRetryIntervalMs = value; }
        }

        // Check to see if MaxRetryIntervalMs property is set
        internal bool IsSetMaxRetryIntervalMs()
        {
            return this._maxRetryIntervalMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumRetries. 
        /// <para>
        /// The maximum number of retries for Kinesis Data Streams API requests. The default value
        /// is <code>3</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int NumRetries
        {
            get { return this._numRetries.GetValueOrDefault(); }
            set { this._numRetries = value; }
        }

        // Check to see if NumRetries property is set
        internal bool IsSetNumRetries()
        {
            return this._numRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryIntervalMs. 
        /// <para>
        /// The cool-off time period (specified in ms) before retrying the Kinesis Data Streams
        /// API call. The default value is <code>1000</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long RetryIntervalMs
        {
            get { return this._retryIntervalMs.GetValueOrDefault(); }
            set { this._retryIntervalMs = value; }
        }

        // Check to see if RetryIntervalMs property is set
        internal bool IsSetRetryIntervalMs()
        {
            return this._retryIntervalMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to assume using AWS Security Token Service
        /// (AWS STS). This role must have permissions for describe or read record operations
        /// for the Kinesis data stream. You must use this parameter when accessing a data stream
        /// in a different account. Used in conjunction with <code>"awsSTSSessionName"</code>.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleSessionName. 
        /// <para>
        /// An identifier for the session assuming the role using AWS STS. You must use this parameter
        /// when accessing a data stream in a different account. Used in conjunction with <code>"awsSTSRoleARN"</code>.
        /// </para>
        /// </summary>
        public string RoleSessionName
        {
            get { return this._roleSessionName; }
            set { this._roleSessionName = value; }
        }

        // Check to see if RoleSessionName property is set
        internal bool IsSetRoleSessionName()
        {
            return this._roleSessionName != null;
        }

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The starting position in the Kinesis data stream to read data from. The possible values
        /// are <code>"latest"</code>, <code>"trim_horizon"</code>, or <code>"earliest"</code>.
        /// The default value is <code>"latest"</code>.
        /// </para>
        /// </summary>
        public StartingPosition StartingPosition
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
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis data stream.
        /// </para>
        /// </summary>
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the Kinesis data stream.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}