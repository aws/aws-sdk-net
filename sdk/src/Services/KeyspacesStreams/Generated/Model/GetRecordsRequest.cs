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
    /// Container for the parameters to the GetRecords operation.
    /// Retrieves data records from a specified shard in an Amazon Keyspaces data stream.
    /// This operation returns a collection of data records from the shard, including the
    /// primary key columns and information about modifications made to the captured table
    /// data. Each record represents a single data modification in the Amazon Keyspaces table
    /// and includes metadata about when the change occurred.
    /// </summary>
    public partial class GetRecordsRequest : AmazonKeyspacesStreamsRequest
    {
        private int? _maxResults;
        private string _shardIterator;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of records to return in a single <c>GetRecords</c> request. Default
        /// value is 1000. You can specify a limit between 1 and 1000, but the actual number returned
        /// might be less than the specified maximum if the size of the data for the returned
        /// records exceeds the internal size limit. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShardIterator. 
        /// <para>
        ///  The unique identifier of the shard iterator. A shard iterator specifies the position
        /// in the shard from which you want to start reading data records sequentially. You obtain
        /// this value by calling the <c>GetShardIterator</c> operation. Each shard iterator is
        /// valid for 15 minutes after creation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
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