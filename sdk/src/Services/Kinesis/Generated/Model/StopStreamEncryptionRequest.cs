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
    /// Container for the parameters to the StopStreamEncryption operation.
    /// Disables server-side encryption for a specified stream. 
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, you must use either the <c>StreamARN</c> or the <c>StreamName</c>
    /// parameter, or both. It is recommended that you use the <c>StreamARN</c> input parameter
    /// when you invoke this API.
    /// </para>
    ///  </note> 
    /// <para>
    /// Stopping encryption is an asynchronous operation. Upon receiving the request, Kinesis
    /// Data Streams returns immediately and sets the status of the stream to <c>UPDATING</c>.
    /// After the update is complete, Kinesis Data Streams sets the status of the stream back
    /// to <c>ACTIVE</c>. Stopping encryption normally takes a few seconds to complete, but
    /// it can take minutes. You can continue to read and write data to your stream while
    /// its status is <c>UPDATING</c>. Once the status of the stream is <c>ACTIVE</c>, records
    /// written to the stream are no longer encrypted by Kinesis Data Streams. 
    /// </para>
    ///  
    /// <para>
    /// API Limits: You can successfully disable server-side encryption 25 times in a rolling
    /// 24-hour period. 
    /// </para>
    ///  
    /// <para>
    /// Note: It can take up to 5 seconds after the stream is in an <c>ACTIVE</c> status before
    /// all records written to the stream are no longer subject to encryption. After you disabled
    /// encryption, you can verify that encryption is not applied by inspecting the API response
    /// from <c>PutRecord</c> or <c>PutRecords</c>.
    /// </para>
    /// </summary>
    public partial class StopStreamEncryptionRequest : AmazonKinesisRequest
    {
        private EncryptionType _encryptionType;
        private string _keyId;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type. The only valid value is <c>KMS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The GUID for the customer-managed Amazon Web Services KMS key to use for encryption.
        /// This value can be a globally unique identifier, a fully specified Amazon Resource
        /// Name (ARN) to either an alias or a key, or an alias name prefixed by "alias/".You
        /// can also use a master key owned by Kinesis Data Streams by specifying the alias <c>aws/kinesis</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ARN example: <c>arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN example: <c>arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Globally unique key ID example: <c>12345678-1234-1234-1234-123456789012</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name example: <c>alias/MyAliasName</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Master key owned by Kinesis Data Streams: <c>alias/aws/kinesis</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream on which to stop encrypting records.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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