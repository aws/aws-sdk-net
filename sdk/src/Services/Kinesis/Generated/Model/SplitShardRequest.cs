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
    /// Container for the parameters to the SplitShard operation.
    /// Splits a shard into two new shards in the Kinesis data stream, to increase the stream's
    /// capacity to ingest and transport data. <c>SplitShard</c> is called when there is a
    /// need to increase the overall capacity of a stream because of an expected increase
    /// in the volume of data records being ingested. This API is only supported for the data
    /// streams with the provisioned capacity mode.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
    /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
    /// when you invoke this API.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can also use <c>SplitShard</c> when a shard appears to be approaching its maximum
    /// utilization; for example, the producers sending data into the specific shard are suddenly
    /// sending more than previously anticipated. You can also call <c>SplitShard</c> to increase
    /// stream capacity, so that more Kinesis Data Streams applications can simultaneously
    /// read data from the stream for real-time processing. 
    /// </para>
    ///  
    /// <para>
    /// You must specify the shard to be split and the new hash key, which is the position
    /// in the shard where the shard gets split in two. In many cases, the new hash key might
    /// be the average of the beginning and ending hash key, but it can be any hash key value
    /// in the range being mapped into the shard. For more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-sdk-java-resharding-split.html">Split
    /// a Shard</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can use <a>DescribeStreamSummary</a> and the <a>ListShards</a> APIs to determine
    /// the shard ID and hash key values for the <c>ShardToSplit</c> and <c>NewStartingHashKey</c>
    /// parameters that are specified in the <c>SplitShard</c> request.
    /// </para>
    ///  
    /// <para>
    ///  <c>SplitShard</c> is an asynchronous operation. Upon receiving a <c>SplitShard</c>
    /// request, Kinesis Data Streams immediately returns a response and sets the stream status
    /// to <c>UPDATING</c>. After the operation is completed, Kinesis Data Streams sets the
    /// stream status to <c>ACTIVE</c>. Read and write operations continue to work while the
    /// stream is in the <c>UPDATING</c> state. 
    /// </para>
    ///  
    /// <para>
    /// You can use <a>DescribeStreamSummary</a> to check the status of the stream, which
    /// is returned in <c>StreamStatus</c>. If the stream is in the <c>ACTIVE</c> state, you
    /// can call <c>SplitShard</c>. 
    /// </para>
    ///  
    /// <para>
    /// If the specified stream does not exist, <a>DescribeStreamSummary</a> returns a <c>ResourceNotFoundException</c>.
    /// If you try to create more shards than are authorized for your account, you receive
    /// a <c>LimitExceededException</c>. 
    /// </para>
    ///  
    /// <para>
    /// For the default shard limit for an Amazon Web Services account, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Kinesis
    /// Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// To increase this limit, <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
    /// Amazon Web Services Support</a>.
    /// </para>
    ///  
    /// <para>
    /// If you try to operate on too many streams simultaneously using <a>CreateStream</a>,
    /// <a>DeleteStream</a>, <a>MergeShards</a>, and/or <a>SplitShard</a>, you receive a <c>LimitExceededException</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>SplitShard</c> has a limit of five transactions per second per account.
    /// </para>
    /// </summary>
    public partial class SplitShardRequest : AmazonKinesisRequest
    {
        private string _newStartingHashKey;
        private string _shardToSplit;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property NewStartingHashKey. 
        /// <para>
        /// A hash key value for the starting hash key of one of the child shards created by the
        /// split. The hash key range for a given shard constitutes a set of ordered contiguous
        /// positive integers. The value for <c>NewStartingHashKey</c> must be in the range of
        /// hash keys being mapped into the shard. The <c>NewStartingHashKey</c> hash key value
        /// and all higher hash key values in hash key range are distributed to one of the child
        /// shards. All the lower hash key values in the range are distributed to the other child
        /// shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NewStartingHashKey
        {
            get { return this._newStartingHashKey; }
            set { this._newStartingHashKey = value; }
        }

        // Check to see if NewStartingHashKey property is set
        internal bool IsSetNewStartingHashKey()
        {
            return this._newStartingHashKey != null;
        }

        /// <summary>
        /// Gets and sets the property ShardToSplit. 
        /// <para>
        /// The shard ID of the shard to split.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ShardToSplit
        {
            get { return this._shardToSplit; }
            set { this._shardToSplit = value; }
        }

        // Check to see if ShardToSplit property is set
        internal bool IsSetShardToSplit()
        {
            return this._shardToSplit != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream for the shard split.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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