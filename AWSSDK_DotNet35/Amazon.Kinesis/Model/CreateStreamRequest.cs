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
    /// Container for the parameters to the CreateStream operation.
    /// <para>This operation adds a new Amazon Kinesis stream to your AWS account. A stream captures and transports data records that are
    /// continuously emitted from different data sources or <i>producers</i> .
    /// Scale-out within an Amazon Kinesis stream is explicitly supported by means of shards, which are uniquely identified groups of
    /// data records in an Amazon Kinesis stream.</para> <para>You specify and control the number of shards that a stream is composed of. Each shard
    /// can support up to 5 read transactions per second up to a maximum total of 2 MB of data read per second. Each shard can support up to 1000
    /// write transactions per second up to a maximum total of 1 MB data written per second. You can add shards to a stream if the amount of data
    /// input increases and you can remove shards if the amount of data input decreases.</para> <para>The stream name identifies the stream. The
    /// name is scoped to the AWS account used by the application. It is also scoped by region. That is, two streams in two different accounts can
    /// have the same name, and two streams in the same account, but in two different regions, can have the same name. </para> <para>
    /// <c>CreateStream</c> is an asynchronous operation. Upon receiving a <c>CreateStream</c> request, Amazon Kinesis immediately returns and sets
    /// the stream status to CREATING. After the stream is created, Amazon Kinesis sets the stream status to ACTIVE. You should perform read and
    /// write operations only on an ACTIVE stream. </para> <para>You receive a <c>LimitExceededException</c> when making a <c>CreateStream</c>
    /// request if you try to do one of the following:</para>
    /// <ul>
    /// <li>Have more than five streams in the CREATING state at any point in time.</li>
    /// <li>Create more shards than are authorized for your account.</li>
    /// 
    /// </ul>
    /// <para> <b>Note:</b> The default limit for an AWS account is two shards per stream. If you need to create a stream with more than two
    /// shards, contact AWS Support to increase the limit on your account.</para> <para>You can use the <c>DescribeStream</c> operation to check the
    /// stream status, which is returned in <c>StreamStatus</c> .</para> <para> <c>CreateStream</c> has a limit of 5 transactions per second per
    /// account.</para>
    /// </summary>
    public partial class CreateStreamRequest : AmazonKinesisRequest
    {
        private string streamName;
        private int? shardCount;


        /// <summary>
        /// A name to identify the stream. The stream name is scoped to the AWS account used by the application that creates the stream. It is also
        /// scoped by region. That is, two streams in two different AWS accounts can have the same name, and two streams in the same AWS account, but in
        /// two different regions, can have the same name.
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
        /// The number of shards that the stream will use. The throughput of the stream is a function of the number of shards; more shards are required
        /// for greater provisioned throughput. <b>Note:</b> The default limit for an AWS account is two shards per stream. If you need to create a
        /// stream with more than two shards, contact AWS Support to increase the limit on your account.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int ShardCount
        {
            get { return this.shardCount ?? default(int); }
            set { this.shardCount = value; }
        }

        // Check to see if ShardCount property is set
        internal bool IsSetShardCount()
        {
            return this.shardCount.HasValue;
        }

    }
}
    
