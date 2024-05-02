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
    /// Represents the output for <c>PutRecord</c>.
    /// </summary>
    public partial class PutRecordResponse : AmazonWebServiceResponse
    {
        private EncryptionType _encryptionType;
        private string _sequenceNumber;
        private string _shardId;

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
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number identifier that was assigned to the put data record. The sequence
        /// number for the record is unique across all records in the stream. A sequence number
        /// is the identifier associated with every record put into the stream.
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

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The shard ID of the shard where the data record was placed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

    }
}