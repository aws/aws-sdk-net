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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the ListShards operation.
    /// Lists the shards in a stream and provides information about each shard. This operation
    /// has a limit of 1000 transactions per second per data stream.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter rather than the <code>StreamName</code> input parameter.
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
        /// the shard whose ID immediately follows <code>ExclusiveStartShardId</code>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this parameter, the default behavior is for <code>ListShards</code>
        /// to list the shards starting with the first one in the stream.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter if you specify <code>NextToken</code>.
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
        /// The maximum number of shards to return in a single call to <code>ListShards</code>.
        /// The maximum number of shards to return in a single call. The default value is 1000.
        /// If you specify a value greater than 1000, at most 1000 results are returned. 
        /// </para>
        ///  
        /// <para>
        /// When the number of shards to be listed is greater than the value of <code>MaxResults</code>,
        /// the response contains a <code>NextToken</code> value that you can use in a subsequent
        /// call to <code>ListShards</code> to list the next set of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// the <code>MaxResults</code> parameter, or if you explicitly specify a value for <code>MaxResults</code>
        /// that is less than the number of shards in the data stream, the response includes a
        /// pagination token named <code>NextToken</code>. You can specify this <code>NextToken</code>
        /// value in a subsequent call to <code>ListShards</code> to list the next set of shards.
        /// </para>
        ///  
        /// <para>
        /// Don't specify <code>StreamName</code> or <code>StreamCreationTimestamp</code> if you
        /// specify <code>NextToken</code> because the latter unambiguously identifies the stream.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a value for the <code>MaxResults</code> parameter when
        /// you specify <code>NextToken</code>. If you specify a <code>MaxResults</code> value
        /// that is less than the number of shards that the operation returns if you don't specify
        /// <code>MaxResults</code>, the response will contain a new <code>NextToken</code> value.
        /// You can use the new <code>NextToken</code> value in a subsequent call to the <code>ListShards</code>
        /// operation.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens expire after 300 seconds. When you obtain a value for <code>NextToken</code>
        /// in the response to a call to <code>ListShards</code>, you have 300 seconds to use
        /// that value. If you specify an expired token in a call to <code>ListShards</code>,
        /// you get <code>ExpiredNextTokenException</code>.
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
        /// Enables you to filter out the response of the <code>ListShards</code> API. You can
        /// only specify one filter at a time. 
        /// </para>
        ///  
        /// <para>
        /// If you use the <code>ShardFilter</code> parameter when invoking the ListShards API,
        /// the <code>Type</code> is the required property and must be specified. If you specify
        /// the <code>AT_TRIM_HORIZON</code>, <code>FROM_TRIM_HORIZON</code>, or <code>AT_LATEST</code>
        /// types, you do not need to specify either the <code>ShardId</code> or the <code>Timestamp</code>
        /// optional properties. 
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>AFTER_SHARD_ID</code> type, you must also provide the value
        /// for the optional <code>ShardId</code> property. The <code>ShardId</code> property
        /// is identical in fuctionality to the <code>ExclusiveStartShardId</code> parameter of
        /// the <code>ListShards</code> API. When <code>ShardId</code> property is specified,
        /// the response includes the shards starting with the shard whose ID immediately follows
        /// the <code>ShardId</code> that you provided. 
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>AT_TIMESTAMP</code> or <code>FROM_TIMESTAMP_ID</code> type,
        /// you must also provide the value for the optional <code>Timestamp</code> property.
        /// If you specify the AT_TIMESTAMP type, then all shards that were open at the provided
        /// timestamp are returned. If you specify the FROM_TIMESTAMP type, then all shards starting
        /// from the provided timestamp to TIP are returned. 
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
        /// You cannot specify this parameter if you specify the <code>NextToken</code> parameter.
        /// </para>
        /// </summary>
        public DateTime StreamCreationTimestamp
        {
            get { return this._streamCreationTimestamp.GetValueOrDefault(); }
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
        /// You cannot specify this parameter if you specify the <code>NextToken</code> parameter.
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