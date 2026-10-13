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
    /// Additional options for the Amazon Kinesis streaming data source.
    /// </summary>
    public partial class KinesisStreamingSourceOptions
    {
        /// <summary>
        /// Gets and sets the property AddIdleTimeBetweenReads. 
        /// <para>
        /// Adds a time delay between two consecutive getRecords operations. The default value
        /// is <c>"False"</c>. This option is only configurable for Glue version 2.0 and above.
        /// </para>
        /// </summary>
        public bool? AddIdleTimeBetweenReads { get; set; }

        /// <summary>
        /// Checks to see if the AddIdleTimeBetweenReads property is set.
        /// </summary>
        internal bool IsSetAddIdleTimeBetweenReads() => this.AddIdleTimeBetweenReads.HasValue;

        /// <summary>
        /// Gets and sets the property AddRecordTimestamp. 
        /// <para>
        /// When this option is set to 'true', the data output will contain an additional column
        /// named "__src_timestamp" that indicates the time when the corresponding record received
        /// by the stream. The default value is 'false'. This option is supported in Glue version
        /// 4.0 or later.
        /// </para>
        /// </summary>
        public string AddRecordTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AddRecordTimestamp property is set.
        /// </summary>
        internal bool IsSetAddRecordTimestamp() => this.AddRecordTimestamp != null;

        /// <summary>
        /// Gets and sets the property AvoidEmptyBatches. 
        /// <para>
        /// Avoids creating an empty microbatch job by checking for unread data in the Kinesis
        /// data stream before the batch is started. The default value is <c>"False"</c>.
        /// </para>
        /// </summary>
        public bool? AvoidEmptyBatches { get; set; }

        /// <summary>
        /// Checks to see if the AvoidEmptyBatches property is set.
        /// </summary>
        internal bool IsSetAvoidEmptyBatches() => this.AvoidEmptyBatches.HasValue;

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
        /// Gets and sets the property DescribeShardInterval. 
        /// <para>
        /// The minimum time interval between two ListShards API calls for your script to consider
        /// resharding. The default value is <c>1s</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? DescribeShardInterval { get; set; }

        /// <summary>
        /// Checks to see if the DescribeShardInterval property is set.
        /// </summary>
        internal bool IsSetDescribeShardInterval() => this.DescribeShardInterval.HasValue;

        /// <summary>
        /// Gets and sets the property EmitConsumerLagMetrics. 
        /// <para>
        /// When this option is set to 'true', for each batch, it will emit the metrics for the
        /// duration between the oldest record received by the stream and the time it arrives
        /// in Glue to CloudWatch. The metric's name is "glue.driver.streaming.maxConsumerLagInMs".
        /// The default value is 'false'. This option is supported in Glue version 4.0 or later.
        /// </para>
        /// </summary>
        public string EmitConsumerLagMetrics { get; set; }

        /// <summary>
        /// Checks to see if the EmitConsumerLagMetrics property is set.
        /// </summary>
        internal bool IsSetEmitConsumerLagMetrics() => this.EmitConsumerLagMetrics != null;

        /// <summary>
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// The URL of the Kinesis endpoint.
        /// </para>
        /// </summary>
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the EndpointUrl property is set.
        /// </summary>
        internal bool IsSetEndpointUrl() => this.EndpointUrl != null;

        /// <summary>
        /// Gets and sets the property FanoutConsumerARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis Data Streams enhanced fan-out consumer.
        /// When specified, enables enhanced fan-out for dedicated throughput and lower latency
        /// data consumption.
        /// </para>
        /// </summary>
        public string FanoutConsumerARN { get; set; }

        /// <summary>
        /// Checks to see if the FanoutConsumerARN property is set.
        /// </summary>
        internal bool IsSetFanoutConsumerARN() => this.FanoutConsumerARN != null;

        /// <summary>
        /// Gets and sets the property IdleTimeBetweenReadsInMs. 
        /// <para>
        /// The minimum time delay between two consecutive getRecords operations, specified in
        /// ms. The default value is <c>1000</c>. This option is only configurable for Glue version
        /// 2.0 and above.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? IdleTimeBetweenReadsInMs { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeBetweenReadsInMs property is set.
        /// </summary>
        internal bool IsSetIdleTimeBetweenReadsInMs() => this.IdleTimeBetweenReadsInMs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFetchRecordsPerShard. 
        /// <para>
        /// The maximum number of records to fetch per shard in the Kinesis data stream per microbatch.
        /// Note: The client can exceed this limit if the streaming job has already read extra
        /// records from Kinesis (in the same get-records call). If <c>MaxFetchRecordsPerShard</c>
        /// needs to be strict then it needs to be a multiple of <c>MaxRecordPerRead</c>. The
        /// default value is <c>100000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MaxFetchRecordsPerShard { get; set; }

        /// <summary>
        /// Checks to see if the MaxFetchRecordsPerShard property is set.
        /// </summary>
        internal bool IsSetMaxFetchRecordsPerShard() => this.MaxFetchRecordsPerShard.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFetchTimeInMs. 
        /// <para>
        /// The maximum time spent for the job executor to read records for the current batch
        /// from the Kinesis data stream, specified in milliseconds (ms). Multiple <c>GetRecords</c>
        /// API calls may be made within this time. The default value is <c>1000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MaxFetchTimeInMs { get; set; }

        /// <summary>
        /// Checks to see if the MaxFetchTimeInMs property is set.
        /// </summary>
        internal bool IsSetMaxFetchTimeInMs() => this.MaxFetchTimeInMs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRecordPerRead. 
        /// <para>
        /// The maximum number of records to fetch from the Kinesis data stream in each getRecords
        /// operation. The default value is <c>10000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MaxRecordPerRead { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecordPerRead property is set.
        /// </summary>
        internal bool IsSetMaxRecordPerRead() => this.MaxRecordPerRead.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetryIntervalMs. 
        /// <para>
        /// The maximum cool-off time period (specified in ms) between two retries of a Kinesis
        /// Data Streams API call. The default value is <c>10000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? MaxRetryIntervalMs { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetryIntervalMs property is set.
        /// </summary>
        internal bool IsSetMaxRetryIntervalMs() => this.MaxRetryIntervalMs.HasValue;

        /// <summary>
        /// Gets and sets the property NumRetries. 
        /// <para>
        /// The maximum number of retries for Kinesis Data Streams API requests. The default value
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
        /// Gets and sets the property RetryIntervalMs. 
        /// <para>
        /// The cool-off time period (specified in ms) before retrying the Kinesis Data Streams
        /// API call. The default value is <c>1000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RetryIntervalMs { get; set; }

        /// <summary>
        /// Checks to see if the RetryIntervalMs property is set.
        /// </summary>
        internal bool IsSetRetryIntervalMs() => this.RetryIntervalMs.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role to assume using AWS Security Token Service
        /// (AWS STS). This role must have permissions for describe or read record operations
        /// for the Kinesis data stream. You must use this parameter when accessing a data stream
        /// in a different account. Used in conjunction with <c>"awsSTSSessionName"</c>.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property RoleSessionName. 
        /// <para>
        /// An identifier for the session assuming the role using AWS STS. You must use this parameter
        /// when accessing a data stream in a different account. Used in conjunction with <c>"awsSTSRoleARN"</c>.
        /// </para>
        /// </summary>
        public string RoleSessionName { get; set; }

        /// <summary>
        /// Checks to see if the RoleSessionName property is set.
        /// </summary>
        internal bool IsSetRoleSessionName() => this.RoleSessionName != null;

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The starting position in the Kinesis data stream to read data from. The possible values
        /// are <c>"latest"</c>, <c>"trim_horizon"</c>, <c>"earliest"</c>, or a timestamp string
        /// in UTC format in the pattern <c>yyyy-mm-ddTHH:MM:SSZ</c> (where <c>Z</c> represents
        /// a UTC timezone offset with a +/-. For example: "2023-04-04T08:00:00-04:00"). The default
        /// value is <c>"latest"</c>.
        /// </para>
        ///  
        /// <para>
        /// Note: Using a value that is a timestamp string in UTC format for "startingPosition"
        /// is supported only for Glue version 4.0 or later.
        /// </para>
        /// </summary>
        public StartingPosition StartingPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartingPosition property is set.
        /// </summary>
        internal bool IsSetStartingPosition() => this.StartingPosition != null;

        /// <summary>
        /// Gets and sets the property StartingTimestamp. 
        /// <para>
        /// The timestamp of the record in the Kinesis data stream to start reading data from.
        /// The possible values are a timestamp string in UTC format of the pattern <c>yyyy-mm-ddTHH:MM:SSZ</c>
        /// (where Z represents a UTC timezone offset with a +/-. For example: "2023-04-04T08:00:00+08:00").
        /// 
        /// </para>
        /// </summary>
        public DateTime? StartingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartingTimestamp property is set.
        /// </summary>
        internal bool IsSetStartingTimestamp() => this.StartingTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis data stream.
        /// </para>
        /// </summary>
        public string StreamArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamArn property is set.
        /// </summary>
        internal bool IsSetStreamArn() => this.StreamArn != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the Kinesis data stream.
        /// </para>
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;
    }
}
