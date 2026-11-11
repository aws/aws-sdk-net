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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApproximateArrivalTimestamp. 
        /// <para>
        /// The approximate time that the record was inserted into the stream.
        /// </para>
        /// </summary>
        public DateTime? ApproximateArrivalTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateArrivalTimestamp property is set.
        /// </summary>
        internal bool IsSetApproximateArrivalTimestamp() => this.ApproximateArrivalTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data blob. The data in the blob is both opaque and immutable to Kinesis Data Streams,
        /// which does not inspect, interpret, or change the data in the blob in any way. When
        /// the data blob (the payload before base64-encoding) is added to the partition key size,
        /// the total size must not exceed the maximum record size (10 MiB).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10485760)]
        public MemoryStream Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

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
        public EncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property PartitionKey. 
        /// <para>
        /// Identifies which shard in the stream the data record is assigned to.
        /// </para>
        ///  
        /// <para>
        /// For a stream that uses the <c>AUTO</c> record distribution strategy, this value is
        /// not returned if the producer did not provide a partition key when writing the record.
        /// If the producer provided a partition key, the original value is returned even though
        /// it was not used to determine shard placement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PartitionKey { get; set; }

        /// <summary>
        /// Checks to see if the PartitionKey property is set.
        /// </summary>
        internal bool IsSetPartitionKey() => this.PartitionKey != null;

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The unique identifier of the record within its shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;
    }
}
