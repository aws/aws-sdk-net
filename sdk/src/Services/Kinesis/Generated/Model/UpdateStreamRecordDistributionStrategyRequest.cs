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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
    /// Container for the parameters to the UpdateStreamRecordDistributionStrategy operation.
    /// Updates the record distribution strategy for the specified Amazon Kinesis Data Streams
    /// on-demand data stream. The record distribution strategy determines how Amazon Kinesis
    /// Data Streams distributes records across the shards in a stream.
    /// 
    ///  <note> 
    /// <para>
    /// You must specify the stream using the <c>StreamARN</c> parameter.
    /// </para>
    ///  </note> 
    /// <para>
    /// The record distribution strategy is a stream-level setting. You can switch between
    /// the following strategies at any time, and the change takes effect immediately without
    /// downtime, data loss, or disruption to producer or consumer applications:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>AUTO</c> – Amazon Kinesis Data Streams distributes records evenly across shards
    /// using service-managed algorithms, and ignores any partition key and <c>ExplicitHashKey</c>
    /// that a producer provides. Use this strategy for stateless workloads that do not require
    /// partition-key ordering.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>USER_PARTITION_KEY</c> – Producers must provide a partition key, and Amazon Kinesis
    /// Data Streams uses the partition key to determine shard placement. Records that share
    /// a partition key are sent to the same shard. This is the default strategy.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation is only supported for data streams that use the on-demand capacity
    /// mode. Provisioned capacity mode streams do not support the record distribution strategy
    /// setting. Attempting to set <c>AUTO</c> on a provisioned stream results in an <c>InvalidArgumentException</c>.
    /// </para>
    ///  
    /// <para>
    /// New records that arrive after the change are distributed according to the new strategy.
    /// Records already in the stream keep their original shard assignments and are not redistributed.
    /// </para>
    /// </summary>
    public partial class UpdateStreamRecordDistributionStrategyRequest : AmazonKinesisRequest
    {
        private RecordDistributionStrategy _recordDistributionStrategy;
        private string _streamARN;
        private string _streamId;

        /// <summary>
        /// Gets and sets the property RecordDistributionStrategy. 
        /// <para>
        /// The record distribution strategy to apply to the stream. Specify one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO</c> – Amazon Kinesis Data Streams distributes records evenly across shards
        /// and ignores any partition key and <c>ExplicitHashKey</c> that producers supply.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_PARTITION_KEY</c> – Producers must supply a partition key, which Amazon Kinesis
        /// Data Streams uses to determine shard placement. This is the default.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordDistributionStrategy RecordDistributionStrategy
        {
            get { return this._recordDistributionStrategy; }
            set { this._recordDistributionStrategy = value; }
        }

        // Check to see if RecordDistributionStrategy property is set
        internal bool IsSetRecordDistributionStrategy()
        {
            return this._recordDistributionStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Not Implemented. Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

    }
}