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
    /// Container for the parameters to the CreateStream operation.
    /// Creates a Kinesis data stream. A stream captures and transports data records that
    /// are continuously emitted from different data sources or <i>producers</i>. Scale-out
    /// within a stream is explicitly supported by means of shards, which are uniquely identified
    /// groups of data records in a stream.
    /// 
    ///  
    /// <para>
    /// You specify and control the number of shards that a stream is composed of. Each shard
    /// can support reads up to five transactions per second, up to a maximum data read total
    /// of 2 MB per second. Each shard can support writes up to 1,000 records per second,
    /// up to a maximum data write total of 1 MB per second. If the amount of data input increases
    /// or decreases, you can add or remove shards.
    /// </para>
    ///  
    /// <para>
    /// The stream name identifies the stream. The name is scoped to the AWS account used
    /// by the application. It is also scoped by AWS Region. That is, two streams in two different
    /// accounts can have the same name, and two streams in the same account, but in two different
    /// Regions, can have the same name.
    /// </para>
    ///  
    /// <para>
    ///  <code>CreateStream</code> is an asynchronous operation. Upon receiving a <code>CreateStream</code>
    /// request, Kinesis Data Streams immediately returns and sets the stream status to <code>CREATING</code>.
    /// After the stream is created, Kinesis Data Streams sets the stream status to <code>ACTIVE</code>.
    /// You should perform read and write operations only on an <code>ACTIVE</code> stream.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You receive a <code>LimitExceededException</code> when making a <code>CreateStream</code>
    /// request when you try to do one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Have more than five streams in the <code>CREATING</code> state at any point in time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create more shards than are authorized for your account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the default shard limit for an AWS account, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
    /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>.
    /// To increase this limit, <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
    /// AWS Support</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use <code>DescribeStream</code> to check the stream status, which is returned
    /// in <code>StreamStatus</code>.
    /// </para>
    ///  
    /// <para>
    ///  <a>CreateStream</a> has a limit of five transactions per second per account.
    /// </para>
    /// </summary>
    public partial class CreateStreamRequest : AmazonKinesisRequest
    {
        private int? _shardCount;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ShardCount. 
        /// <para>
        /// The number of shards that the stream will use. The throughput of the stream is a function
        /// of the number of shards; more shards are required for greater provisioned throughput.
        /// </para>
        ///  
        /// <para>
        /// DefaultShardLimit;
        /// </para>
        /// </summary>
        public int ShardCount
        {
            get { return this._shardCount.GetValueOrDefault(); }
            set { this._shardCount = value; }
        }

        // Check to see if ShardCount property is set
        internal bool IsSetShardCount()
        {
            return this._shardCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// A name to identify the stream. The stream name is scoped to the AWS account used by
        /// the application that creates the stream. It is also scoped by AWS Region. That is,
        /// two streams in two different AWS accounts can have the same name. Two streams in the
        /// same AWS account but in two different Regions can also have the same name.
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