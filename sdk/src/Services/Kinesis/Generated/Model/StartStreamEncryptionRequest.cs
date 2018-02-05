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
    /// Container for the parameters to the StartStreamEncryption operation.
    /// Enables or updates server-side encryption using an AWS KMS key for a specified stream.
    /// 
    /// 
    ///  
    /// <para>
    /// Starting encryption is an asynchronous operation. Upon receiving the request, Kinesis
    /// Data Streams returns immediately and sets the status of the stream to <code>UPDATING</code>.
    /// After the update is complete, Kinesis Data Streams sets the status of the stream back
    /// to <code>ACTIVE</code>. Updating or applying encryption normally takes a few seconds
    /// to complete, but it can take minutes. You can continue to read and write data to your
    /// stream while its status is <code>UPDATING</code>. Once the status of the stream is
    /// <code>ACTIVE</code>, encryption begins for records written to the stream. 
    /// </para>
    ///  
    /// <para>
    /// API Limits: You can successfully apply a new AWS KMS key for server-side encryption
    /// 25 times in a rolling 24-hour period.
    /// </para>
    ///  
    /// <para>
    /// Note: It can take up to five seconds after the stream is in an <code>ACTIVE</code>
    /// status before all records written to the stream are encrypted. After you enable encryption,
    /// you can verify that encryption is applied by inspecting the API response from <code>PutRecord</code>
    /// or <code>PutRecords</code>.
    /// </para>
    /// </summary>
    public partial class StartStreamEncryptionRequest : AmazonKinesisRequest
    {
        private EncryptionType _encryptionType;
        private string _keyId;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type to use. The only valid value is <code>KMS</code>.
        /// </para>
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
        /// The GUID for the customer-managed AWS KMS key to use for encryption. This value can
        /// be a globally unique identifier, a fully specified Amazon Resource Name (ARN) to either
        /// an alias or a key, or an alias name prefixed by "alias/".You can also use a master
        /// key owned by Kinesis Data Streams by specifying the alias <code>aws/kinesis</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ARN example: <code>arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN example: <code>arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Globally unique key ID example: <code>12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name example: <code>alias/MyAliasName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Master key owned by Kinesis Data Streams: <code>alias/aws/kinesis</code> 
        /// </para>
        ///  </li> </ul>
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
        /// The name of the stream for which to start encrypting records.
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