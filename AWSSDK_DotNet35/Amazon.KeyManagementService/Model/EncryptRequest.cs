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
    /// Container for the parameters to the Encrypt operation.
    /// Encrypts plaintext into ciphertext by using a customer master key. The <code>Encrypt</code>
    /// function has two primary use cases: <ul> <li>You can encrypt up to 4 KB of arbitrary
    /// data such as an RSA key, a database password, or other sensitive customer information.</li>
    /// <li>If you are moving encrypted data from one region to another, you can use this
    /// API to encrypt in the new region the plaintext data key that was used to encrypt the
    /// data in the original region. This provides you with an encrypted copy of the data
    /// key that can be decrypted in the new region and used there to decrypt the encrypted
    /// data. </li> </ul> 
    /// 
    ///  
    /// <para>
    /// Unless you are moving encrypted data from one region to another, you don't use this
    /// function to encrypt a generated data key within a region. You retrieve data keys already
    /// encrypted by calling the <a>GenerateDataKey</a> or <a>GenerateDataKeyWithoutPlaintext</a>
    /// function. Data keys don't need to be encrypted again by calling <code>Encrypt</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// If you want to encrypt data locally in your application, you can use the <code>GenerateDataKey</code>
    /// function to return a plaintext data encryption key and a copy of the key encrypted
    /// under the customer master key (CMK) of your choosing. 
    /// </para>
    /// </summary>
    public partial class EncryptRequest : AmazonKeyManagementServiceRequest
    {
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private MemoryStream _plaintext;

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Name/value pair that specifies the encryption context to be used for authenticated
        /// encryption. If used here, the same value must be supplied to the <code>Decrypt</code>
        /// API or decryption will fail. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encrypt-context.html">Encryption
        /// Context</a>. 
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
        /// Gets and sets the property Plaintext. 
        /// <para>
        /// Data to be encrypted.
        /// </para>
        /// </summary>
        public MemoryStream Plaintext
        {
            get { return this._plaintext; }
            set { this._plaintext = value; }
        }

        // Check to see if Plaintext property is set
        internal bool IsSetPlaintext()
        {
            return this._plaintext != null;
        }

    }
}