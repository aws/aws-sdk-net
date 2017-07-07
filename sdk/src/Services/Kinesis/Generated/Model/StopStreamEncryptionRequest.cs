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
    /// Container for the parameters to the StopStreamEncryption operation.
    /// Disables server-side encryption for a specified stream. 
    /// 
    ///  
    /// <para>
    /// Stopping encryption is an asynchronous operation. Upon receiving the request, Amazon
    /// Kinesis returns immediately and sets the status of the stream to <code>UPDATING</code>.
    /// After the update is complete, Amazon Kinesis sets the status of the stream back to
    /// <code>ACTIVE</code>. Stopping encryption normally takes a few seconds to complete
    /// but it can take minutes. You can continue to read and write data to your stream while
    /// its status is <code>UPDATING</code>. Once the status of the stream is <code>ACTIVE</code>
    /// records written to the stream will no longer be encrypted by the Amazon Kinesis Streams
    /// service. 
    /// </para>
    ///  
    /// <para>
    /// API Limits: You can successfully disable server-side encryption 25 times in a rolling
    /// 24 hour period. 
    /// </para>
    ///  
    /// <para>
    /// Note: It can take up to 5 seconds after the stream is in an <code>ACTIVE</code> status
    /// before all records written to the stream are no longer subject to encryption. After
    /// you’ve disabled encryption, you can verify encryption was not applied by inspecting
    /// the API response from <code>PutRecord</code> or <code>PutRecords</code>.
    /// </para>
    /// </summary>
    public partial class StopStreamEncryptionRequest : AmazonKinesisRequest
    {
        private EncryptionType _encryptionType;
        private string _keyId;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type. This parameter can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NONE</code>: Not valid for this operation. An <code>InvalidOperationException</code>
        /// will be thrown.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KMS</code>: Use server-side encryption on the records in the stream using a
        /// customer-managed KMS key.
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
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The GUID for the customer-managed key that was used for encryption.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream on which to stop encrypting records.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}