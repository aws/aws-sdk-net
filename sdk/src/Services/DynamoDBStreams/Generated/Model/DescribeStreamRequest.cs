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
 * Do not modify this file. This file is generated from the streams.dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStream operation.
    /// Returns information about a stream, including the current status of the stream, its
    /// Amazon Resource Name (ARN), the composition of its shards, and its corresponding DynamoDB
    /// table.
    /// 
    ///  <note> 
    /// <para>
    /// You can call <c>DescribeStream</c> at a maximum rate of 10 times per second.
    /// </para>
    ///  </note> 
    /// <para>
    /// Each shard in the stream has a <c>SequenceNumberRange</c> associated with it. If the
    /// <c>SequenceNumberRange</c> has a <c>StartingSequenceNumber</c> but no <c>EndingSequenceNumber</c>,
    /// then the shard is still open (able to receive more stream records). If both <c>StartingSequenceNumber</c>
    /// and <c>EndingSequenceNumber</c> are present, then that shard is closed and can no
    /// longer receive more data.
    /// </para>
    /// </summary>
    public partial class DescribeStreamRequest : AmazonDynamoDBStreamsRequest
    {
        private string _exclusiveStartShardId;
        private int? _limit;
        private ShardFilter _shardFilter;
        private string _streamArn;

        /// <summary>
        /// Gets and sets the property ExclusiveStartShardId. 
        /// <para>
        /// The shard ID of the first item that this operation will evaluate. Use the value that
        /// was returned for <c>LastEvaluatedShardId</c> in the previous operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=28, Max=65)]
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
        /// The maximum number of shard objects to return. The upper limit is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShardFilter. 
        /// <para>
        /// This optional field contains the filter definition for the <c>DescribeStream</c> API.
        /// </para>
        /// </summary>
        public ShardFilter ShardFilter
        {
            get { return this._shardFilter; }
            set { this._shardFilter = value; }
        }

        // Check to see if ShardFilter property is set
        internal bool IsSetShardFilter()
        {
            return this._shardFilter != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=37, Max=1024)]
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

    }
}