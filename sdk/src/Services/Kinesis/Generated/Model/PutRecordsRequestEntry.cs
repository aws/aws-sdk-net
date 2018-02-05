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
    /// Represents the output for <code>PutRecords</code>.
    /// </summary>
    public partial class PutRecordsRequestEntry
    {
        private MemoryStream _data;
        private string _explicitHashKey;
        private string _partitionKey;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data blob to put into the record, which is base64-encoded when the blob is serialized.
        /// When the data blob (the payload before base64-encoding) is added to the partition
        /// key size, the total size must not exceed the maximum record size (1 MB).
        /// </para>
        /// </summary>
        public MemoryStream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property ExplicitHashKey. 
        /// <para>
        /// The hash value used to determine explicitly the shard that the data record is assigned
        /// to by overriding the partition key hash.
        /// </para>
        /// </summary>
        public string ExplicitHashKey
        {
            get { return this._explicitHashKey; }
            set { this._explicitHashKey = value; }
        }

        // Check to see if ExplicitHashKey property is set
        internal bool IsSetExplicitHashKey()
        {
            return this._explicitHashKey != null;
        }

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