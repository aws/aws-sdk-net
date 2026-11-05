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
    /// This is the response object from the PutRecord operation.
    /// </summary>
    public partial class PutRecordResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type to use on the record. This parameter can be one of the following
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
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number identifier that was assigned to the put data record. The sequence
        /// number for the record is unique across all records in the stream. A sequence number
        /// is the identifier associated with every record put into the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The shard ID of the shard where the data record was placed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ShardId { get; set; }

        /// <summary>
        /// Checks to see if the ShardId property is set.
        /// </summary>
        internal bool IsSetShardId() => this.ShardId != null;
    }
}
