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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the Encrypt operation.
    /// Encrypts plaintext of up to 4,096 bytes using a KMS key. You can use a symmetric or
    /// asymmetric KMS key with a <c>KeyUsage</c> of <c>ENCRYPT_DECRYPT</c>.
    /// 
    ///  
    /// <para>
    /// You can use this operation to encrypt small amounts of arbitrary data, such as a personal
    /// identifier or database password, or other sensitive information. You don't need to
    /// use the <c>Encrypt</c> operation to encrypt a data key. The <a>GenerateDataKey</a>
    /// and <a>GenerateDataKeyPair</a> operations return a plaintext data key and an encrypted
    /// copy of that data key.
    /// </para>
    ///  
    /// <para>
    /// If you use a symmetric encryption KMS key, you can use an encryption context to add
    /// additional security to your encryption operation. If you specify an <c>EncryptionContext</c>
    /// when encrypting data, you must specify the same encryption context (a case-sensitive
    /// exact match) when decrypting the data. Otherwise, the request to decrypt fails with
    /// an <c>InvalidCiphertextException</c>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
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
    ///  <c>SYMMETRIC_DEFAULT</c>: 4096 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>RSA_2048</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>RSAES_OAEP_SHA_1</c>: 214 bytes
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RSAES_OAEP_SHA_256</c>: 190 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>RSA_3072</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>RSAES_OAEP_SHA_1</c>: 342 bytes
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RSAES_OAEP_SHA_256</c>: 318 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>RSA_4096</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>RSAES_OAEP_SHA_1</c>: 470 bytes
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>RSAES_OAEP_SHA_256</c>: 446 bytes
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <c>SM2PKE</c>: 1024 bytes (China Regions only)
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
    /// <c>KeyId</c> parameter.
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
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class EncryptRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _dryRun;
        private EncryptionAlgorithmSpec _encryptionAlgorithm;
        private Dictionary<string, string> _encryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _grantTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyId;
        private MemoryStream _plaintext;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks if your request will succeed. <c>DryRun</c> is an optional parameter. 
        /// </para>
        ///  
        /// <para>
        /// To learn more about how to use this parameter, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/testing-permissions.html">Testing
        /// your permissions</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionAlgorithm. 
        /// <para>
        /// Specifies the encryption algorithm that KMS will use to encrypt the plaintext message.
        /// The algorithm must be compatible with the KMS key that you specify.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only for asymmetric KMS keys. The default value, <c>SYMMETRIC_DEFAULT</c>,
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
        /// context is valid only for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a> with a symmetric encryption KMS key. The standard asymmetric encryption
        /// algorithms and HMAC algorithms that KMS uses do not support an encryption context.
        /// 
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> 
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
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
        /// context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EncryptionContext
        {
            get { return this._encryptionContext; }
            set { this._encryptionContext = value; }
        }

        // Check to see if EncryptionContext property is set
        internal bool IsSetEncryptionContext()
        {
            return this._encryptionContext != null && (this._encryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/using-grant-token.html">Using
        /// a grant token</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._grantTokens != null && (this._grantTokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the KMS key to use in the encryption operation. The KMS key must have a
        /// <c>KeyUsage</c> of <c>ENCRYPT_DECRYPT</c>. To find the <c>KeyUsage</c> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using
        /// an alias name, prefix it with <c>"alias/"</c>. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <c>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</c> 
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