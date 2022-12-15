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
    /// Container for the parameters to the GetRecords operation.
    /// Gets data records from a Kinesis data stream's shard.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter in addition to the <code>ShardIterator</code> parameter.
    /// </para>
    ///  </note> 
    /// <para>
    /// Specify a shard iterator using the <code>ShardIterator</code> parameter. The shard
    /// iterator specifies the position in the shard from which you want to start reading
    /// data records sequentially. If there are no records available in the portion of the
    /// shard that the iterator points to, <a>GetRecords</a> returns an empty list. It might
    /// take multiple calls to get to a portion of the shard that contains records.
    /// </para>
    ///  
    /// <para>
    /// You can scale by provisioning multiple shards per stream while considering service
    /// limits (for more information, see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/service-sizes-and-limits.html">Amazon
    /// Kinesis Data Streams Limits</a> in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
    /// Your application should have one thread per shard, each reading continuously from
    /// its stream. To read from a stream continually, call <a>GetRecords</a> in a loop. Use
    /// <a>GetShardIterator</a> to get the shard iterator to specify in the first <a>GetRecords</a>
    /// call. <a>GetRecords</a> returns a new shard iterator in <code>NextShardIterator</code>.
    /// Specify the shard iterator returned in <code>NextShardIterator</code> in subsequent
    /// calls to <a>GetRecords</a>. If the shard has been closed, the shard iterator can't
    /// return more data and <a>GetRecords</a> returns <code>null</code> in <code>NextShardIterator</code>.
    /// You can terminate the loop when the shard is closed, or when the shard iterator reaches
    /// the record with the sequence number or other attribute that marks it as the last record
    /// to process.
    /// </para>
    ///  
    /// <para>
    /// Each data record can be up to 1 MiB in size, and each shard can read up to 2 MiB per
    /// second. You can ensure that your calls don't exceed the maximum supported size or
    /// throughput by using the <code>Limit</code> parameter to specify the maximum number
    /// of records that <a>GetRecords</a> can return. Consider your average record size when
    /// determining this limit. The maximum number of records that can be returned per call
    /// is 10,000.
    /// </para>
    ///  
    /// <para>
    /// The size of the data returned by <a>GetRecords</a> varies depending on the utilization
    /// of the shard. It is recommended that consumer applications retrieve records via the
    /// <code>GetRecords</code> command using the 5 TPS limit to remain caught up. Retrieving
    /// records less frequently can lead to consumer applications falling behind. The maximum
    /// size of data that <a>GetRecords</a> can return is 10 MiB. If a call returns this amount
    /// of data, subsequent calls made within the next 5 seconds throw <code>ProvisionedThroughputExceededException</code>.
    /// If there is insufficient provisioned throughput on the stream, subsequent calls made
    /// within the next 1 second throw <code>ProvisionedThroughputExceededException</code>.
    /// <a>GetRecords</a> doesn't return any data when it throws an exception. For this reason,
    /// we recommend that you wait 1 second between calls to <a>GetRecords</a>. However, it's
    /// possible that the application will get exceptions for longer than 1 second.
    /// </para>
    ///  
    /// <para>
    /// To detect whether the application is falling behind in processing, you can use the
    /// <code>MillisBehindLatest</code> response attribute. You can also monitor the stream
    /// using CloudWatch metrics and other mechanisms (see <a href="https://docs.aws.amazon.com/kinesis/latest/dev/monitoring.html">Monitoring</a>
    /// in the <i>Amazon Kinesis Data Streams Developer Guide</i>).
    /// </para>
    ///  
    /// <para>
    /// Each Amazon Kinesis record includes a value, <code>ApproximateArrivalTimestamp</code>,
    /// that is set when a stream successfully receives and stores a record. This is commonly
    /// referred to as a server-side time stamp, whereas a client-side time stamp is set when
    /// a data producer creates or sends the record to a stream (a data producer is any data
    /// source putting data records into a stream, for example with <a>PutRecords</a>). The
    /// time stamp has millisecond precision. There are no guarantees about the time stamp
    /// accuracy, or that the time stamp is always increasing. For example, records in a shard
    /// or across a stream might have time stamps that are out of order.
    /// </para>
    ///  
    /// <para>
    /// This operation has a limit of five transactions per second per shard.
    /// </para>
    /// </summary>
    public partial class GetRecordsRequest : AmazonKinesisRequest
    {
        private int? _limit;
        private string _shardIterator;
        private string _streamARN;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of records to return. Specify a value of up to 10,000. If you specify
        /// a value that is greater than 10,000, <a>GetRecords</a> throws <code>InvalidArgumentException</code>.
        /// The default value is 10,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
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
        [AWSProperty(Required=true, Min=1, Max=512)]
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

    }
}