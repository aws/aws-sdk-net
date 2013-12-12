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
    /// Container for the parameters to the GetRecords operation.
    /// <para>This operation returns one or more data records from a shard. A <c>GetRecords</c> operation request can retrieve up to 10 MB of
    /// data.</para> <para>You specify a shard iterator for the shard that you want to read data from in the <c>ShardIterator</c> parameter. The
    /// shard iterator specifies the position in the shard from which you want to start reading data records sequentially. A shard iterator
    /// specifies this position using the sequence number of a data record in the shard. For more information about the shard iterator, see
    /// GetShardIterator.</para> <para> <c>GetRecords</c> may return a partial result if the response size limit is exceeded. You will get an error,
    /// but not a partial result if the shard's provisioned throughput is exceeded, the shard iterator has expired, or an internal processing
    /// failure has occurred. Clients can request a smaller amount of data by specifying a maximum number of returned records using the <c>Limit</c>
    /// parameter. The <c>Limit</c> parameter can be set to an integer value of up to 10,000. If you set the value to an integer greater than
    /// 10,000, you will receive <c>InvalidArgumentException</c> .</para> <para>A new shard iterator is returned by every <c>GetRecords</c> request
    /// in <c>NextShardIterator</c> ,
    /// which you use in the <c>ShardIterator</c> parameter of the next <c>GetRecords</c> request. When you repeatedly read from an
    /// Amazon Kinesis stream use a GetShardIterator request to get the first shard iterator to use in your first <c>GetRecords</c> request and then
    /// use the shard iterator returned in <c>NextShardIterator</c> for subsequent reads.</para> <para> <c>GetRecords</c> can return <c>null</c> for
    /// the <c>NextShardIterator</c> to reflect that the shard has been closed and that the requested shard iterator would never have returned more
    /// data. </para> <para>If no items can be processed because of insufficient provisioned throughput on the shard involved in the request,
    /// <c>GetRecords</c> throws <c>ProvisionedThroughputExceededException</c> .</para>
    /// </summary>
    public partial class GetRecordsRequest : AmazonKinesisRequest
    {
        private string shardIterator;
        private int? limit;


        /// <summary>
        /// The position in the shard from which you want to start sequentially reading data records.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ShardIterator
        {
            get { return this.shardIterator; }
            set { this.shardIterator = value; }
        }

        // Check to see if ShardIterator property is set
        internal bool IsSetShardIterator()
        {
            return this.shardIterator != null;
        }

        /// <summary>
        /// The maximum number of records to return, which can be set to a value of up to 10,000.
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

    }
}
    
