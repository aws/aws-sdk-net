/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>This operation returns the following information about the stream: the current status of the stream, the stream Amazon Resource Name
    /// (ARN), and an array of shard objects that comprise the stream. For each shard object there is information about the hash key and sequence
    /// number ranges that the shard spans, and the IDs of any earlier shards that played in a role in a MergeShards or SplitShard operation that
    /// created the shard. A sequence number is the identifier associated with every record ingested in the Amazon Kinesis stream. The sequence
    /// number is assigned by the Amazon Kinesis service when a record is put into the stream. </para> <para>You can limit the number of returned
    /// shards using the <c>Limit</c> parameter. The number of shards in a stream may be too large to return from a single call to
    /// <c>DescribeStream</c> .
    /// You can detect this by using the <c>HasMoreShards</c> flag in the returned output. <c>HasMoreShards</c> is set to <c>true</c>
    /// when there is more data available. </para> <para>If there are more shards available, you can request more shards by using the shard ID of
    /// the last shard returned by the <c>DescribeStream</c> request, in the <c>ExclusiveStartShardId</c> parameter in a subsequent request to
    /// <c>DescribeStream</c> .
    /// 
    /// <c>DescribeStream</c> is a paginated operation. </para> <para> <c>DescribeStream</c> has a limit of 10 transactions per
    /// second per account.</para>
    /// </summary>
    public partial class DescribeStreamRequest : AmazonKinesisRequest
    {
        private string streamName;
        private int? limit;
        private string exclusiveStartShardId;


        /// <summary>
        /// The name of the stream to describe.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this.streamName; }
            set { this.streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this.streamName != null;
        }

        /// <summary>
        /// The maximum number of shards to return.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 10000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this.limit ?? default(int); }
            set { this.limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit.HasValue;
        }

        /// <summary>
        /// The shard ID of the shard to start with for the stream description.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ExclusiveStartShardId
        {
            get { return this.exclusiveStartShardId; }
            set { this.exclusiveStartShardId = value; }
        }

        // Check to see if ExclusiveStartShardId property is set
        internal bool IsSetExclusiveStartShardId()
        {
            return this.exclusiveStartShardId != null;
        }

    }
}
    
