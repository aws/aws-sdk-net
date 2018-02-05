/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStream operation.
    /// Describes the specified Kinesis data stream.
    /// 
    ///  
    /// <para>
    /// The information returned includes the stream name, Amazon Resource Name (ARN), creation
    /// time, enhanced metric configuration, and shard map. The shard map is an array of shard
    /// objects. For each shard object, there is the hash key and sequence number ranges that
    /// the shard spans, and the IDs of any earlier shards that played in a role in creating
    /// the shard. Every record ingested in the stream is identified by a sequence number,
    /// which is assigned when the record is put into the stream.
    /// </para>
    ///  
    /// <para>
    /// You can limit the number of shards returned by each call. For more information, see
    /// <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-retrieve-shards.html">Retrieving
    /// Shards from a Stream</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// There are no guarantees about the chronological order shards returned. To process
    /// shards in chronological order, use the ID of the parent shard to track the lineage
    /// to the oldest shard.
    /// </para>
    ///  
    /// <para>
    /// This operation has a limit of 10 transactions per second per account.
    /// </para>
    /// </summary>
    public partial class DescribeStreamRequest : AmazonKinesisRequest
    {
        private string _exclusiveStartShardId;
        private int? _limit;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ExclusiveStartShardId. 
        /// <para>
        /// The shard ID of the shard to start with.
        /// </para>
        /// </summary>
        public string ExclusiveStartShardId
        {
            get { return this._exclusiveStartShardId; }
            set { this._exclusiveStartShardId = value; }
        }

        // Check to see if ExclusiveStartShardId property is set
        internal bool IsSetExclusiveStartShardId()
        {
            return this._exclusiveStartShardId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of shards to return in a single call. The default value is 100.
        /// If you specify a value greater than 100, at most 100 shards are returned.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream to describe.
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