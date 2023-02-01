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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the Encrypt operation.
    /// Encrypts plaintext of up to 4,096 bytes using a KMS key. You can use a symmetric or
    /// asymmetric KMS key with a <code>KeyUsage</code> of <code>ENCRYPT_DECRYPT</code>.
    /// 
    ///  
    /// <para>
    /// You can use this operation to encrypt small amounts of arbitrary data, such as a personal
    /// identifier or database password, or other sensitive information. You don't need to
    /// use the <code>Encrypt</code> operation to encrypt a data key. The <a>GenerateDataKey</a>
    /// and <a>GenerateDataKeyPair</a> operations return a plaintext data key and an encrypted
    /// copy of that data key.
    /// </para>
    ///  
    /// <para>
    /// If you use a symmetric encryption KMS key, you can use an encryption context to add
    /// additional security to your encryption operation. If you specify an <code>EncryptionContext</code>
    /// when encrypting data, you must specify the same encryption context (a case-sensitive
    /// exact match) when decrypting the data. Otherwise, the request to decrypt fails with
    /// an <code>InvalidCiphertextException</code>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
    /// Context</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you specify an asymmetric KMS key, you must also specify the encryption algorithm.
    /// The algorithm must be compatible with the KMS key spec.
    /// </para>
    ///  <important> 
    /// <para>
    /// When you use an asymmetric KMS key to encrypt or reencrypt data, be sure to record
    /// the KMS key and encryption algorithm that you choose. You will be required to provide
    /// the same KMS key and encryption algorithm when you decrypt the data. If the KMS key
    /// and algorithm do not match the values used to encrypt the data, the decrypt operation
    /// fails.
    /// </para>
    ///  
    /// <para>
    /// You are not required to supply the key ID and encryption algorithm when you decrypt
    /// with symmetric encryption KMS keys because KMS stores this information in the ciphertext
    /// blob. KMS cannot store metadata in ciphertext generated with asymmetric keys. The
    /// standard format for asymmetric key ciphertext does not include configurable fields.
    /// </para>
    ///  </important> 
    /// <para>
    /// The maximum size of the data that you can encrypt varies with the type of KMS key
    /// and the encryption algorithm that you choose.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Symmetric encryption KMS keys
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>SYMMETRIC_DEFAULT</code>: 4096 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <code>RSA_2048</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>RSAES_OAEP_SHA_1</code>: 214 bytes
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RSAES_OAEP_SHA_256</code>: 190 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <code>RSA_3072</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>RSAES_OAEP_SHA_1</code>: 342 bytes
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RSAES_OAEP_SHA_256</code>: 318 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <code>RSA_4096</code> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>RSAES_OAEP_SHA_1</code>: 470 bytes
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RSAES_OAEP_SHA_256</code>: 446 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <code>SM2PKE</code>: 1024 bytes (China Regions only)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
    /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
    /// <code>KeyId</code> parameter.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Encrypt</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyPair</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EncryptRequest : AmazonKeyManagementServiceRequest
    {
        private EncryptionAlgorithmSpec _encryptionAlgorithm;
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private MemoryStream _plaintext;

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithm. 
        /// <para>
        /// Specifies the encryption algorithm that KMS will use to encrypt the plaintext message.
        /// The algorithm must be compatible with the KMS key that you specify.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only for asymmetric KMS keys. The default value, <code>SYMMETRIC_DEFAULT</code>,
        /// is the algorithm used for symmetric encryption KMS keys. If you are using an asymmetric
        /// KMS key, we recommend RSAES_OAEP_SHA_256.
        /// </para>
        ///  
        /// <para>
        /// The SM2PKE algorithm is only available in China Regions.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec EncryptionAlgorithm
        {
            get { return this._encryptionAlgorithm; }
            set { this._encryptionAlgorithm = value; }
        }

        // Check to see if EncryptionAlgorithm property is set
        internal bool IsSetEncryptionAlgorithm()
        {
            return this._encryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Specifies the encryption context that will be used to encrypt the data. An encryption
        /// context is valid only for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a> with a symmetric encryption KMS key. The standard asymmetric encryption
        /// algorithms and HMAC algorithms that KMS uses do not support an encryption context.
        /// 
        /// </para>
        ///  
        /// <para>
        /// An <i>encryption context</i> is a collection of non-secret key-value pairs that represent
        /// additional authenticated data. When you use an encryption context to encrypt data,
        /// you must specify the same (an exact case-sensitive match) encryption context to decrypt
        /// the data. An encryption context is supported only on operations with symmetric encryption
        /// KMS keys. On operations with symmetric encryption KMS keys, an encryption context
        /// is optional, but it is strongly recommended.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// context</a> in the <i>Key Management Service Developer Guide</i>.
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
        /// Use a grant token when your permission to call this operation comes from a new grant
        /// that has not yet achieved <i>eventual consistency</i>. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant
        /// token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token">Using
        /// a grant token</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
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
        /// Identifies the KMS key to use in the encryption operation. The KMS key must have a
        /// <code>KeyUsage</code> of <code>ENCRYPT_DECRYPT</code>. To find the <code>KeyUsage</code>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using
        /// an alias name, prefix it with <code>"alias/"</code>. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
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
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
        /// </para>
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
        /// Gets and sets the property Plaintext. 
        /// <para>
        /// Data to be encrypted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
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