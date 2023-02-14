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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using a Kinesis stream as a source.
    /// </summary>
    public partial class PipeTargetKinesisStreamParameters
    {
        private string _partitionKey;

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// Determines which shard in the stream the data record is assigned to. Partition keys
        /// are Unicode strings with a maximum length limit of 256 characters for each key. Amazon
        /// Kinesis Data Streams uses the partition key as input to a hash function that maps
        /// the partition key and associated data to a specific shard. Specifically, an MD5 hash
        /// function is used to map partition keys to 128-bit integer values and to map associated
        /// data records to shards. As a result of this hashing mechanism, all data records with
        /// the same partition key map to the same shard within the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=256)]
        public string PartitionKey
        {
            get { return this._partitionKey; }
            set { this._partitionKey = value; }
        }

        // Check to see if PartitionKey property is set
        internal bool IsSetPartitionKey()
        {
            return this._partitionKey != null;
        }

    }
}