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
    /// Container for the parameters to the GetRecords operation.
    /// Gets data records from a shard.
    /// 
    ///  
    /// <para>
    /// Specify a shard iterator using the <code>ShardIterator</code> parameter. The shard
    /// iterator specifies the position in the shard from which you want to start reading
    /// data records sequentially. If there are no records available in the portion of the
    /// shard that the iterator points to, <code>GetRecords</code> returns an empty list.
    /// Note that it might take multiple calls to get to a portion of the shard that contains
    /// records.
    /// </para>
    ///  
    /// <para>
    /// You can scale by provisioning multiple shards. Your application should have one thread
    /// per shard, each reading continuously from its stream. To read from a stream continually,
    /// call <code>GetRecords</code> in a loop. Use <a>GetShardIterator</a> to get the shard
    /// iterator to specify in the first <code>GetRecords</code> call. <code>GetRecords</code>
    /// returns a new shard iterator in <code>NextShardIterator</code>. Specify the shard
    /// iterator returned in <code>NextShardIterator</code> in subsequent calls to <code>GetRecords</code>.
    /// Note that if the shard has been closed, the shard iterator can't return more data
    /// and <code>GetRecords</code> returns <code>null</code> in <code>NextShardIterator</code>.
    /// You can terminate the loop when the shard is closed, or when the shard iterator reaches
    /// the record with the sequence number or other attribute that marks it as the last record
    /// to process.
    /// </para>
    ///  
    /// <para>
    /// Each data record can be up to 50 KB in size, and each shard can read up to 2 MB per
    /// second. You can ensure that your calls don't exceed the maximum supported size or
    /// throughput by using the <code>Limit</code> parameter to specify the maximum number
    /// of records that <code>GetRecords</code> can return. Consider your average record size
    /// when determining this limit. For example, if your average record size is 40 KB, you
    /// can limit the data returned to about 1 MB per call by specifying 25 as the limit.
    /// </para>
    ///  
    /// <para>
    /// The size of the data returned by <code>GetRecords</code> will vary depending on the
    /// utilization of the shard. The maximum size of data that <code>GetRecords</code> can
    /// return is 10 MB. If a call returns 10 MB of data, subsequent calls made within the
    /// next 5 seconds throw <code>ProvisionedThroughputExceededException</code>. If there
    /// is insufficient provisioned throughput on the shard, subsequent calls made within
    /// the next 1 second throw <code>ProvisionedThroughputExceededException</code>. Note
    /// that <code>GetRecords</code> won't return any data when it throws an exception. For
    /// this reason, we recommend that you wait one second between calls to <code>GetRecords</code>;
    /// however, it's possible that the application will get exceptions for longer than 1
    /// second.
    /// </para>
    ///  
    /// <para>
    /// To detect whether the application is falling behind in processing, add a timestamp
    /// to your records and note how long it takes to process them. You can also monitor how
    /// much data is in a stream using the CloudWatch metrics for write operations (<code>PutRecord</code>
    /// and <code>PutRecords</code>). For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/monitoring_with_cloudwatch.html">Monitoring
    /// Amazon Kinesis with Amazon CloudWatch</a> in the <i>Amazon Kinesis Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetRecordsRequest : AmazonKinesisRequest
    {
        private int? _limit;
        private string _shardIterator;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of records to return. Specify a value of up to 10,000. If you specify
        /// a value that is greater than 10,000, <code>GetRecords</code> throws <code>InvalidArgumentException</code>.
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
        /// Gets and sets the property ShardIterator. 
        /// <para>
        /// The position in the shard from which you want to start sequentially reading data records.
        /// A shard iterator specifies this position using the sequence number of a data record
        /// in the shard.
        /// </para>
        /// </summary>
        public string ShardIterator
        {
            get { return this._shardIterator; }
            set { this._shardIterator = value; }
        }

        // Check to see if ShardIterator property is set
        internal bool IsSetShardIterator()
        {
            return this._shardIterator != null;
        }

    }
}