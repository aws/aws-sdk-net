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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateDataKeyWithoutPlaintext operation.
    /// Returns a data key encrypted by a customer master key without the plaintext copy of
    /// that key. Otherwise, this API functions exactly like <a>GenerateDataKey</a>. You can
    /// use this API to, for example, satisfy an audit requirement that an encrypted key be
    /// made available without exposing the plaintext copy of that key.
    /// </summary>
    public partial class GenerateDataKeyWithoutPlaintextRequest : AmazonKeyManagementServiceRequest
    {
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private DataKeySpec _keySpec;
        private int? _numberOfBytes;

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Name:value pair that contains additional data to be authenticated during the encryption
        /// and decryption processes. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> EncryptionContext
        {
            get { return this._encryptionContext; }
            set { this._encryptionContext = value; }
        }

        // Check to see if EncryptionContext property is set
        internal bool IsSetEncryptionContext()
        {
            return this._encryptionContext != null && this._encryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a>. 
        /// </para>
        /// </summary>
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// A unique identifier for the customer master key. This value can be a globally unique
        /// identifier, a fully specified ARN to either an alias or a key, or an alias name prefixed
        /// by "alias/". <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li>
        /// <li>Alias ARN Example - arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</li>
        /// <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> <li>Alias
        /// Name Example - alias/MyAliasName</li> </ul> 
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
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// Value that identifies the encryption algorithm and key size. Currently this can be
        /// AES_128 or AES_256. 
        /// </para>
        /// </summary>
        public DataKeySpec KeySpec
        {
            get { return this._keySpec; }
            set { this._keySpec = value; }
        }

        // Check to see if KeySpec property is set
        internal bool IsSetKeySpec()
        {
            return this._keySpec != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBytes. 
        /// <para>
        /// Integer that contains the number of bytes to generate. Common values are 128, 256,
        /// 512, 1024 and so on. We recommend that you use the <code>KeySpec</code> parameter
        /// instead. 
        /// </para>
        /// </summary>
        public int NumberOfBytes
        {
            get { return this._numberOfBytes.GetValueOrDefault(); }
            set { this._numberOfBytes = value; }
        }

        // Check to see if NumberOfBytes property is set
        internal bool IsSetNumberOfBytes()
        {
            return this._numberOfBytes.HasValue; 
        }

    }
}