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
    /// Container for the parameters to the ListShards operation.
    /// Lists the shards in a stream and provides information about each shard. This operation
    /// has a limit of 1000 transactions per second per data stream.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
    /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
    /// when you invoke this API.
    /// </para>
    ///  </note> 
    /// <para>
    /// This action does not list expired shards. For information about expired shards, see
    /// <a href="https://docs.aws.amazon.com/streams/latest/dev/kinesis-using-sdk-java-after-resharding.html#kinesis-using-sdk-java-resharding-data-routing">Data
    /// Routing, Data Persistence, and Shard State after a Reshard</a>. 
    /// </para>
    ///  <important> 
    /// <para>
    /// This API is a new operation that is used by the Amazon Kinesis Client Library (KCL).
    /// If you have a fine-grained IAM policy that only allows specific operations, you must
    /// update your policy to allow calls to this API. For more information, see <a href="https://docs.aws.amazon.com/streams/latest/dev/controlling-access.html">Controlling
    /// Access to Amazon Kinesis Data Streams Resources Using IAM</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListShardsRequest : AmazonKinesisRequest
    {
        private string _exclusiveStartShardId;
        private int? _maxResults;
        private string _nextToken;
        private ShardFilter _shardFilter;
        private string _streamARN;
        private DateTime? _streamCreationTimestamp;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ExclusiveStartShardId. 
        /// <para>
        /// Specify this parameter to indicate that you want to list the shards starting with
        /// the shard whose ID immediately follows <c>ExclusiveStartShardId</c>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, the default behavior is for <c>ListShards</c>
        /// to list the shards starting with the first one in the stream.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter if you specify <c>NextToken</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of shards to return in a single call to <c>ListShards</c>. The
        /// maximum number of shards to return in a single call. The default value is 1000. If
        /// you specify a value greater than 1000, at most 1000 results are returned. 
        /// </para>
        ///  
        /// <para>
        /// When the number of shards to be listed is greater than the value of <c>MaxResults</c>,
        /// the response contains a <c>NextToken</c> value that you can use in a subsequent call
        /// to <c>ListShards</c> to list the next set of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of shards in the data stream is greater than the default value for
        /// the <c>MaxResults</c> parameter, or if you explicitly specify a value for <c>MaxResults</c>
        /// that is less than the number of shards in the data stream, the response includes a
        /// pagination token named <c>NextToken</c>. You can specify this <c>NextToken</c> value
        /// in a subsequent call to <c>ListShards</c> to list the next set of shards.
        /// </para>
        ///  
        /// <para>
        /// Don't specify <c>StreamName</c> or <c>StreamCreationTimestamp</c> if you specify <c>NextToken</c>
        /// because the latter unambiguously identifies the stream.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a value for the <c>MaxResults</c> parameter when you specify
        /// <c>NextToken</c>. If you specify a <c>MaxResults</c> value that is less than the number
        /// of shards that the operation returns if you don't specify <c>MaxResults</c>, the response
        /// will contain a new <c>NextToken</c> value. You can use the new <c>NextToken</c> value
        /// in a subsequent call to the <c>ListShards</c> operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens expire after 300 seconds. When you obtain a value for <c>NextToken</c> in the
        /// response to a call to <c>ListShards</c>, you have 300 seconds to use that value. If
        /// you specify an expired token in a call to <c>ListShards</c>, you get <c>ExpiredNextTokenException</c>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=1048576)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ShardFilter. 
        /// <para>
        /// Enables you to filter out the response of the <c>ListShards</c> API. You can only
        /// specify one filter at a time. 
        /// </para>
        ///  
        /// <para>
        /// If you use the <c>ShardFilter</c> parameter when invoking the ListShards API, the
        /// <c>Type</c> is the required property and must be specified. If you specify the <c>AT_TRIM_HORIZON</c>,
        /// <c>FROM_TRIM_HORIZON</c>, or <c>AT_LATEST</c> types, you do not need to specify either
        /// the <c>ShardId</c> or the <c>Timestamp</c> optional properties. 
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>AFTER_SHARD_ID</c> type, you must also provide the value for
        /// the optional <c>ShardId</c> property. The <c>ShardId</c> property is identical in
        /// fuctionality to the <c>ExclusiveStartShardId</c> parameter of the <c>ListShards</c>
        /// API. When <c>ShardId</c> property is specified, the response includes the shards starting
        /// with the shard whose ID immediately follows the <c>ShardId</c> that you provided.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>AT_TIMESTAMP</c> or <c>FROM_TIMESTAMP_ID</c> type, you must
        /// also provide the value for the optional <c>Timestamp</c> property. If you specify
        /// the AT_TIMESTAMP type, then all shards that were open at the provided timestamp are
        /// returned. If you specify the FROM_TIMESTAMP type, then all shards starting from the
        /// provided timestamp to TIP are returned. 
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
        /// Gets and sets the property StreamCreationTimestamp. 
        /// <para>
        /// Specify this input parameter to distinguish data streams that have the same name.
        /// For example, if you create a data stream and then delete it, and you later create
        /// another data stream with the same name, you can use this input parameter to specify
        /// which of the two streams you want to list the shards for.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter if you specify the <c>NextToken</c> parameter.
        /// </para>
        /// </summary>
        public DateTime? StreamCreationTimestamp
        {
            get { return this._streamCreationTimestamp; }
            set { this._streamCreationTimestamp = value; }
        }

        // Check to see if StreamCreationTimestamp property is set
        internal bool IsSetStreamCreationTimestamp()
        {
            return this._streamCreationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the data stream whose shards you want to list. 
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter if you specify the <c>NextToken</c> parameter.
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