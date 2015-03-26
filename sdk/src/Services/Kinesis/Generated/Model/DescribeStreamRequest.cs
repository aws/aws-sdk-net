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
    /// Describes the specified stream.
    /// 
    ///  
    /// <para>
    /// The information about the stream includes its current status, its Amazon Resource
    /// Name (ARN), and an array of shard objects. For each shard object, there is information
    /// about the hash key and sequence number ranges that the shard spans, and the IDs of
    /// any earlier shards that played in a role in creating the shard. A sequence number
    /// is the identifier associated with every record ingested in the Amazon Kinesis stream.
    /// The sequence number is assigned when a record is put into the stream.
    /// </para>
    ///  
    /// <para>
    /// You can limit the number of returned shards using the <code>Limit</code> parameter.
    /// The number of shards in a stream may be too large to return from a single call to
    /// <code>DescribeStream</code>. You can detect this by using the <code>HasMoreShards</code>
    /// flag in the returned output. <code>HasMoreShards</code> is set to <code>true</code>
    /// when there is more data available. 
    /// </para>
    ///  
    /// <para>
    /// <code>DescribeStream</code> is a paginated operation. If there are more shards available,
    /// you can request them using the shard ID of the last shard returned. Specify this ID
    /// in the <code>ExclusiveStartShardId</code> parameter in a subsequent request to <code>DescribeStream</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// <code>DescribeStream</code> has a limit of 10 transactions per second per account.
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
        /// The maximum number of shards to return.
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