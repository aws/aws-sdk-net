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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Container for the parameters to the GetShardIterator operation.
    /// Returns a shard iterator that serves as a bookmark for reading data from a specific
    /// position in an Amazon Keyspaces data stream's shard. The shard iterator specifies
    /// the shard position from which to start reading data records sequentially. You can
    /// specify whether to begin reading at the latest record, the oldest record, or at a
    /// particular sequence number within the shard.
    /// </summary>
    public partial class GetShardIteratorRequest : AmazonKeyspacesStreamsRequest
    {
        private string _sequenceNumber;
        private string _shardId;
        private ShardIteratorType _shardIteratorType;
        private string _streamArn;

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        ///  The sequence number of the data record in the shard from which to start reading.
        /// Required if <c>ShardIteratorType</c> is <c>AT_SEQUENCE_NUMBER</c> or <c>AFTER_SEQUENCE_NUMBER</c>.
        /// This parameter is ignored for other iterator types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=48)]
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        ///  The identifier of the shard within the stream. The shard ID uniquely identifies a
        /// subset of the stream's data records that you want to access. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=28, Max=65)]
        public string ShardId
        {
            get { return this._shardId; }
            set { this._shardId = value; }
        }

        // Check to see if ShardId property is set
        internal bool IsSetShardId()
        {
            return this._shardId != null;
        }

        /// <summary>
        /// Gets and sets the property ShardIteratorType. 
        /// <para>
        ///  Determines how the shard iterator is positioned. Must be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TRIM_HORIZON</c> - Start reading at the last untrimmed record in the shard, which
        /// is the oldest data record in the shard.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AT_SEQUENCE_NUMBER</c> - Start reading exactly from the specified sequence number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AFTER_SEQUENCE_NUMBER</c> - Start reading right after the specified sequence number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LATEST</c> - Start reading just after the most recent record in the shard, so
        /// that you always read the most recent data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ShardIteratorType ShardIteratorType
        {
            get { return this._shardIteratorType; }
            set { this._shardIteratorType = value; }
        }

        // Check to see if ShardIteratorType property is set
        internal bool IsSetShardIteratorType()
        {
            return this._shardIteratorType != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the stream for which to get the shard iterator.
        /// The ARN uniquely identifies the stream within Amazon Keyspaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=37, Max=1024)]
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

    }
}