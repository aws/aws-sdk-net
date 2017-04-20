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
    /// Container for the parameters to the GenerateDataKey operation.
    /// Returns a data encryption key that you can use in your application to encrypt data
    /// locally.
    /// 
    ///  
    /// <para>
    /// You must specify the customer master key (CMK) under which to generate the data key.
    /// You must also specify the length of the data key using either the <code>KeySpec</code>
    /// or <code>NumberOfBytes</code> field. You must specify one field or the other, but
    /// not both. For common key lengths (128-bit and 256-bit symmetric keys), we recommend
    /// that you use <code>KeySpec</code>.
    /// </para>
    ///  
    /// <para>
    /// This operation returns a plaintext copy of the data key in the <code>Plaintext</code>
    /// field of the response, and an encrypted copy of the data key in the <code>CiphertextBlob</code>
    /// field. The data key is encrypted under the CMK specified in the <code>KeyId</code>
    /// field of the request.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you use the following pattern to encrypt data locally in your application:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use this operation (<code>GenerateDataKey</code>) to retrieve a data encryption key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the plaintext data encryption key (returned in the <code>Plaintext</code> field
    /// of the response) to encrypt data locally, then erase the plaintext data key from memory.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Store the encrypted data key (returned in the <code>CiphertextBlob</code> field of
    /// the response) alongside the locally encrypted data.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// To decrypt data locally:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key into a plaintext
    /// copy of the data key.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the plaintext data key to decrypt data locally, then erase the plaintext data
    /// key from memory.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// To return only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
    /// To return a random byte string that is cryptographically secure, use <a>GenerateRandom</a>.
    /// </para>
    ///  
    /// <para>
    /// If you use the optional <code>EncryptionContext</code> field, you must store at least
    /// enough information to be able to reconstruct the full encryption context when you
    /// later send the ciphertext to the <a>Decrypt</a> operation. It is a good practice to
    /// choose an encryption context that you can reconstruct on the fly to better secure
    /// the ciphertext. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html">Encryption
    /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GenerateDataKeyRequest : AmazonKeyManagementServiceRequest
    {
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private DataKeySpec _keySpec;
        private int? _numberOfBytes;

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// A set of key-value pairs that represents additional authenticated data.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// The identifier of the CMK under which to generate and encrypt the data encryption
        /// key.
        /// </para>
        ///  
        /// <para>
        /// A valid identifier is the unique key ID or the Amazon Resource Name (ARN) of the CMK,
        /// or the alias name or ARN of an alias that refers to the CMK. Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Unique key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CMK ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code> 
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
        /// Gets and sets the property KeySpec. 
        /// <para>
        /// The length of the data encryption key. Use <code>AES_128</code> to generate a 128-bit
        /// symmetric key, or <code>AES_256</code> to generate a 256-bit symmetric key.
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
        /// The length of the data encryption key in bytes. For example, use the value 64 to generate
        /// a 512-bit data key (64 bytes is 512 bits). For common key lengths (128-bit and 256-bit
        /// symmetric keys), we recommend that you use the <code>KeySpec</code> field instead
        /// of this one.
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