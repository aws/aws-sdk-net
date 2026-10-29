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
    /// Container for the parameters to the SubscribeToShard operation. This operation establishes
    /// an HTTP/2 connection between the consumer you specify in the <c>ConsumerARN</c> parameter
    /// and the shard you specify in the <c>ShardId</c> parameter. After the connection is
    /// successfully established, Kinesis Data Streams pushes records from the shard to the
    /// consumer over this connection. Before you call this operation, call <a>RegisterStreamConsumer</a>
    /// to register the consumer with Kinesis Data Streams. <para> When the <c>SubscribeToShard</c>
    /// call succeeds, your consumer starts receiving events of type <a>SubscribeToShardEvent</a>
    /// over the HTTP/2 connection for up to 5 minutes, after which time you need to call
    /// <c>SubscribeToShard</c> again to renew the subscription if you want to continue to
    /// receive records. </para> <para> You can make one call to <c>SubscribeToShard</c> per
    /// second per registered consumer per shard. For example, if you have a 4000 shard stream
    /// and two registered stream consumers, you can make one <c>SubscribeToShard</c> request
    /// per second for each combination of shard and registered consumer, allowing you to
    /// subscribe both consumers to all 4000 shards in one second. </para> <para> If you call
    /// <c>SubscribeToShard</c> again with the same <c>ConsumerARN</c> and <c>ShardId</c>
    /// within 5 seconds of a successful call, you'll get a <c>ResourceInUseException</c>.
    /// If you call <c>SubscribeToShard</c> 5 seconds or more after a successful call, the
    /// second call takes over the subscription and the previous connection expires or fails
    /// with a <c>ResourceInUseException</c>. </para> <para> For an example of how to use
    /// this operation, see <a href="https://docs.aws.amazon.com/streams/latest/dev/building-enhanced-consumers-api.html">Enhanced
    /// Fan-Out Using the Kinesis Data Streams API</a>. </para>
    /// </summary>
    public partial class SubscribeToShardRequest : AmazonKinesisRequest
    {
        /// <summary>
        /// Gets and sets the property ConsumerARN. 
        /// <para>
        /// For this parameter, use the value you obtained when you called <a>RegisterStreamConsumer</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ConsumerARN { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerARN property is set.
        /// </summary>
        internal bool IsSetConsumerARN() => this.ConsumerARN != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks if your request will succeed. <c>DryRun</c> is an optional parameter.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The ID of the shard you want to subscribe to. To see a list of all the shards for
        /// a given stream, use <a>ListShards</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ShardId { get; set; }

        /// <summary>
        /// Checks to see if the ShardId property is set.
        /// </summary>
        internal bool IsSetShardId() => this.ShardId != null;

        /// <summary>
        /// Gets and sets the property StartingPosition. 
        /// <para>
        /// The starting position in the data stream from which to start streaming.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StartingPosition StartingPosition { get; set; }

        /// <summary>
        /// Checks to see if the StartingPosition property is set.
        /// </summary>
        internal bool IsSetStartingPosition() => this.StartingPosition != null;

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
    }
}
