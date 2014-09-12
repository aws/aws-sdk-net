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
    /// Represents the output for <code>GetShardIterator</code>.
    /// </summary>
    public partial class GetShardIteratorResult : AmazonWebServiceResponse
    {
        private string _shardIterator;

        /// <summary>
        /// Gets and sets the property ShardIterator. 
        /// <para>
        /// The position in the shard from which to start reading data records sequentially. A
        /// shard iterator specifies this position using the sequence number of a data record
        /// in a shard.
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