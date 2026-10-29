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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <a>DescribeStreamSummary</a>
    /// </summary>
    public partial class StreamDescriptionSummary
    {
        /// <summary>
        /// Gets and sets the property ChannelCount. 
        /// <para>
        /// The number of channels associated with the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public int? ChannelCount { get; set; }

        /// <summary>
        /// Checks to see if the ChannelCount property is set.
        /// </summary>
        internal bool IsSetChannelCount() => this.ChannelCount.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumerCount. 
        /// <para>
        /// The number of enhanced fan-out consumers registered with the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public int? ConsumerCount { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerCount property is set.
        /// </summary>
        internal bool IsSetConsumerCount() => this.ConsumerCount.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type used. This value is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KMS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property EnhancedMonitoring. 
        /// <para>
        /// Represents the current enhanced monitoring settings of the stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EnhancedMetrics> EnhancedMonitoring { get; set; } = AWSConfigs.InitializeCollections ? new List<EnhancedMetrics>() : null;

        /// <summary>
        /// Checks to see if the EnhancedMonitoring property is set.
        /// </summary>
        internal bool IsSetEnhancedMonitoring() => this.EnhancedMonitoring != null && (this.EnhancedMonitoring.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The GUID for the customer-managed Amazon Web Services KMS key to use for encryption.
        /// This value can be a globally unique identifier, a fully specified ARN to either an
        /// alias or a key, or an alias name prefixed by "alias/".You can also use a master key
        /// owned by Kinesis Data Streams by specifying the alias <c>aws/kinesis</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ARN example: <c>arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN example: <c> arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Globally unique key ID example: <c>12345678-1234-1234-1234-123456789012</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name example: <c>alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Master key owned by Kinesis Data Streams: <c>alias/aws/kinesis</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property MaxRecordSizeInKiB. 
        /// <para>
        /// The maximum record size of a single record in kibibyte (KiB) that you can write to,
        /// and read from a stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024, Max = 10240)]
        public int? MaxRecordSizeInKiB { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecordSizeInKiB property is set.
        /// </summary>
        internal bool IsSetMaxRecordSizeInKiB() => this.MaxRecordSizeInKiB.HasValue;

        /// <summary>
        /// Gets and sets the property OpenShardCount. 
        /// <para>
        /// The number of open shards in the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000000)]
        public int? OpenShardCount { get; set; }

        /// <summary>
        /// Checks to see if the OpenShardCount property is set.
        /// </summary>
        internal bool IsSetOpenShardCount() => this.OpenShardCount.HasValue;

        /// <summary>
        /// Gets and sets the property RecordDistributionStrategy. 
        /// <para>
        /// The record distribution strategy that the stream currently uses. A value of <c>AUTO</c>
        /// indicates that Amazon Kinesis Data Streams distributes records across shards using
        /// service-managed algorithms. A value of <c>USER_PARTITION_KEY</c> indicates that shard
        /// placement is determined by the partition key that producers supply. This field is
        /// only present for streams that use the on-demand capacity mode.
        /// </para>
        /// </summary>
        public RecordDistributionStrategy RecordDistributionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RecordDistributionStrategy property is set.
        /// </summary>
        internal bool IsSetRecordDistributionStrategy() => this.RecordDistributionStrategy != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriodHours. 
        /// <para>
        /// The current retention period, in hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? RetentionPeriodHours { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriodHours property is set.
        /// </summary>
        internal bool IsSetRetentionPeriodHours() => this.RetentionPeriodHours.HasValue;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the stream being described.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string StreamARN { get; set; }

        /// <summary>
        /// Checks to see if the StreamARN property is set.
        /// </summary>
        internal bool IsSetStreamARN() => this.StreamARN != null;

        /// <summary>
        /// Gets and sets the property StreamCreationTimestamp. 
        /// <para>
        /// The approximate time that the stream was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StreamCreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StreamCreationTimestamp property is set.
        /// </summary>
        internal bool IsSetStreamCreationTimestamp() => this.StreamCreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Not Implemented. Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;

        /// <summary>
        /// Gets and sets the property StreamModeDetails. 
        /// <para>
        ///  Specifies the capacity mode to which you want to set your data stream. Currently,
        /// in Kinesis Data Streams, you can choose between an <b>on-demand</b> ycapacity mode
        /// and a <b>provisioned</b> capacity mode for your data streams. 
        /// </para>
        /// </summary>
        public StreamModeDetails StreamModeDetails { get; set; }

        /// <summary>
        /// Checks to see if the StreamModeDetails property is set.
        /// </summary>
        internal bool IsSetStreamModeDetails() => this.StreamModeDetails != null;

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream being described.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The current status of the stream being described. The stream status is one of the
        /// following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The stream is being created. Kinesis Data Streams immediately returns
        /// and sets <c>StreamStatus</c> to <c>CREATING</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The stream is being deleted. The specified stream is in the <c>DELETING</c>
        /// state until Kinesis Data Streams completes the deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The stream exists and is ready for read and write operations or deletion.
        /// You should perform read and write operations only on an <c>ACTIVE</c> stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - Shards in the stream are being merged or split. Read and write
        /// operations continue to work while the stream is in the <c>UPDATING</c> state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamStatus StreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the StreamStatus property is set.
        /// </summary>
        internal bool IsSetStreamStatus() => this.StreamStatus != null;

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// The warm throughput in MB/s for the stream. This represents the throughput capacity
        /// that will be immediately available for write operations.
        /// </para>
        /// </summary>
        public WarmThroughputObject WarmThroughput { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughput property is set.
        /// </summary>
        internal bool IsSetWarmThroughput() => this.WarmThroughput != null;
    }
}
