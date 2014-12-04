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
    /// The unit of data of the Amazon Kinesis stream, which is composed of a sequence number,
    /// a partition key, and a data blob.
    /// </summary>
    public partial class Record
    {
        private MemoryStream _data;
        private string _partitionKey;
        private string _sequenceNumber;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data blob. The data in the blob is both opaque and immutable to the Amazon Kinesis
        /// service, which does not inspect, interpret, or change the data in the blob in any
        /// way. The maximum size of the data blob (the payload before base64-encoding) is 50
        /// kilobytes (KB) 
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
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// Identifies which shard in the stream the data record is assigned to.
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

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The unique identifier for the record in the Amazon Kinesis stream.
        /// </para>
        /// </summary>
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

    }
}