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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The unit of data of the Kinesis data stream, which is composed of a sequence number,
    /// a partition key, and a data blob.
    /// </summary>
    public partial class Record
    {
        private DateTime? _approximateArrivalTimestamp;
        private MemoryStream _data;
        private EncryptionType _encryptionType;
        private string _partitionKey;
        private string _sequenceNumber;

        /// <summary>
        /// Gets and sets the property ApproximateArrivalTimestamp. 
        /// <para>
        /// The approximate time that the record was inserted into the stream.
        /// </para>
        /// </summary>
        public DateTime? ApproximateArrivalTimestamp
        {
            get { return this._approximateArrivalTimestamp; }
            set { this._approximateArrivalTimestamp = value; }
        }

        // Check to see if ApproximateArrivalTimestamp property is set
        internal bool IsSetApproximateArrivalTimestamp()
        {
            return this._approximateArrivalTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data blob. The data in the blob is both opaque and immutable to Kinesis Data Streams,
        /// which does not inspect, interpret, or change the data in the blob in any way. When
        /// the data blob (the payload before base64-encoding) is added to the partition key size,
        /// the total size must not exceed the maximum record size (1 MiB).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1048576)]
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
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type used on the record. This parameter can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: Do not encrypt the records in the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KMS</c>: Use server-side encryption on the records in the stream using a customer-managed
        /// Amazon Web Services KMS key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// Identifies which shard in the stream the data record is assigned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// The unique identifier of the record within its shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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