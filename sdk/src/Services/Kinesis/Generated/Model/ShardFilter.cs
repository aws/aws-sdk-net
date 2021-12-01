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
    /// The request parameter used to filter out the response of the <code>ListShards</code>
    /// API.
    /// </summary>
    public partial class ShardFilter
    {
        private string _shardId;
        private DateTime? _timestamp;
        private ShardFilterType _type;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The exclusive start <code>shardID</code> speified in the <code>ShardFilter</code>
        /// parameter. This property can only be used if the <code>AFTER_SHARD_ID</code> shard
        /// type is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamps specified in the <code>ShardFilter</code> parameter. A timestamp is
        /// a Unix epoch date with precision in milliseconds. For example, 2016-04-04T19:58:46.480-00:00
        /// or 1459799926.480. This property can only be used if <code>FROM_TIMESTAMP</code> or
        /// <code>AT_TIMESTAMP</code> shard types are specified.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The shard type specified in the <code>ShardFilter</code> parameter. This is a required
        /// property of the <code>ShardFilter</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// You can specify the following valid values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AFTER_SHARD_ID</code> - the response includes all the shards, starting with
        /// the shard whose ID immediately follows the <code>ShardId</code> that you provided.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AT_TRIM_HORIZON</code> - the response includes all the shards that were open
        /// at <code>TRIM_HORIZON</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FROM_TRIM_HORIZON</code> - (default), the response includes all the shards
        /// within the retention period of the data stream (trim to tip).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AT_LATEST</code> - the response includes only the currently open shards of
        /// the data stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AT_TIMESTAMP</code> - the response includes all shards whose start timestamp
        /// is less than or equal to the given timestamp and end timestamp is greater than or
        /// equal to the given timestamp or still open. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FROM_TIMESTAMP</code> - the response incldues all closed shards whose end timestamp
        /// is greater than or equal to the given timestamp and also all open shards. Corrected
        /// to <code>TRIM_HORIZON</code> of the data stream if <code>FROM_TIMESTAMP</code> is
        /// less than the <code>TRIM_HORIZON</code> value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ShardFilterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}