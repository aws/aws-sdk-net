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
    /// This is the response object from the GetShardIterator operation.
    /// </summary>
    public partial class GetShardIteratorResponse : AmazonWebServiceResponse
    {
        private string _shardIterator;

        /// <summary>
        /// Gets and sets the property ShardIterator. 
        /// <para>
        ///  The unique identifier for the shard iterator. This value is used in the <c>GetRecords</c>
        /// operation to retrieve data records from the specified shard. Each shard iterator expires
        /// 15 minutes after it is returned to the requester. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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