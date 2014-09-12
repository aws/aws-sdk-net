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
    /// You specify a shard iterator for the shard using the <code>ShardIterator</code> parameter.
    /// The shard iterator specifies the position in the shard from which you want to start
    /// reading data records sequentially. <code>GetRecords</code> returns a new shard iterator
    /// in <code>NextShardIterator</code>. If the shard has been closed, the shard iterator
    /// can't return more data and <code>GetRecords</code> returns <code>null</code> in <code>NextShardIterator</code>.
    /// To read from an Amazon Kinesis stream continually, use <a>GetShardIterator</a> to
    /// get the shard iterator to specify in the first <code>GetRecords</code> call, and then
    /// specify the shard iterator returned in <code>NextShardIterator</code> in subsequent
    /// calls.
    /// </para>
    ///  
    /// <para>
    /// If there are no records available, <code>GetRecords</code> returns an empty list.
    /// </para>
    ///  
    /// <para>
    /// The size of the data returned by <code>GetRecords</code> will vary, but the maximum
    /// size is 10 MB. Each data record can be up to 50 KB in size, and each shard can read
    /// up to 2 MB per second. You can ensure that your calls don't exceed the maximum size
    /// or throughput by using the <code>Limit</code> parameter to specify the maximum number
    /// of records that <code>GetRecords</code> can return. Consider your average record size
    /// when specifying a limit. For example, if your average record size is 40 KB, you can
    /// limit the data returned to about 1 MB per call using a limit of 25.
    /// </para>
    ///  
    /// <para>
    /// If there is insufficient provisioned throughput on the shard involved in the request,
    /// subsequent calls to <code>GetRecords</code> made within the next one second throw
    /// <code>ProvisionedThroughputExceededException</code>. <code>GetRecords</code> won't
    /// return data when it throws an exception, so wait one second before making another
    /// call or the application won't get any records. Also, you can scale by provisioning
    /// multiple shards.
    /// </para>
    ///  
    /// <para>
    /// To detect whether you are falling behind in processing, add a timestamp to your records
    /// and note how long it takes to process them.
    /// </para>
    /// </summary>
    public partial class GetRecordsRequest : AmazonKinesisRequest
    {
        private int? _limit;
        private string _shardIterator;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum size of data to return, in MB. Specify a value of up to 10,000. If you
        /// specify a value that is greater than 10,000, <code>GetRecords</code> throws <code>InvalidArgumentException</code>.
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