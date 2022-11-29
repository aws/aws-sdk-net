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
    /// Container for the parameters to the ReEncrypt operation.
    /// Decrypts ciphertext and then reencrypts it entirely within KMS. You can use this operation
    /// to change the KMS key under which data is encrypted, such as when you <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-manually">manually
    /// rotate</a> a KMS key or change the KMS key that protects a ciphertext. You can also
    /// use it to reencrypt ciphertext under the same KMS key, such as to change the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">encryption
    /// context</a> of a ciphertext.
    /// 
    ///  
    /// <para>
    /// The <code>ReEncrypt</code> operation can decrypt ciphertext that was encrypted by
    /// using a KMS key in an KMS operation, such as <a>Encrypt</a> or <a>GenerateDataKey</a>.
    /// It can also decrypt ciphertext that was encrypted by using the public key of an <a
    /// href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
    /// KMS key</a> outside of KMS. However, it cannot decrypt ciphertext produced by other
    /// libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
    /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
    /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
    /// incompatible with KMS.
    /// </para>
    ///  
    /// <para>
    /// When you use the <code>ReEncrypt</code> operation, you need to provide information
    /// for the decrypt operation and the subsequent encrypt operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If your ciphertext was encrypted under an asymmetric KMS key, you must use the <code>SourceKeyId</code>
    /// parameter to identify the KMS key that encrypted the ciphertext. You must also supply
    /// the encryption algorithm that was used. This information is required to decrypt the
    /// data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your ciphertext was encrypted under a symmetric encryption KMS key, the <code>SourceKeyId</code>
    /// parameter is optional. KMS can get this information from metadata that it adds to
    /// the symmetric ciphertext blob. This feature adds durability to your implementation
    /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
    /// even if they've lost track of the key ID. However, specifying the source KMS key is
    /// always recommended as a best practice. When you use the <code>SourceKeyId</code> parameter
    /// to specify a KMS key, KMS uses only the KMS key you specify. If the ciphertext was
    /// encrypted under a different KMS key, the <code>ReEncrypt</code> operation fails. This
    /// practice ensures that you use the KMS key that you intend.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To reencrypt the data, you must use the <code>DestinationKeyId</code> parameter to
    /// specify the KMS key that re-encrypts the data after it is decrypted. If the destination
    /// KMS key is an asymmetric KMS key, you must also provide the encryption algorithm.
    /// The algorithm that you choose must be compatible with the KMS key.
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
    ///  </important> </li> </ul> 
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. The source KMS key and destination KMS key can be
    /// in different Amazon Web Services accounts. Either or both KMS keys can be in a different
    /// account than the caller. To specify a KMS key in a different account, you must use
    /// its key ARN or alias ARN.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptFrom</a>
    /// permission on the source KMS key (key policy)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptTo</a>
    /// permission on the destination KMS key (key policy)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To permit reencryption from or to a KMS key, include the <code>"kms:ReEncrypt*"</code>
    /// permission in your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
    /// policy</a>. This permission is automatically included in the key policy when you use
    /// the console to create a KMS key. But you must include it manually when you create
    /// a KMS key programmatically or when you use the <a>PutKeyPolicy</a> operation to set
    /// a key policy.
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
    ///  <a>Encrypt</a> 
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
    public partial class ReEncryptRequest : AmazonKeyManagementServiceRequest
    {
        private MemoryStream _ciphertextBlob;
        private EncryptionAlgorithmSpec _destinationEncryptionAlgorithm;
        private Dictionary<string, string> _destinationEncryptionContext = new Dictionary<string, string>();
        private string _destinationKeyId;
        private List<string> _grantTokens = new List<string>();
        private EncryptionAlgorithmSpec _sourceEncryptionAlgorithm;
        private Dictionary<string, string> _sourceEncryptionContext = new Dictionary<string, string>();
        private string _sourceKeyId;

        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// Ciphertext of the data to reencrypt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6144)]
        public MemoryStream CiphertextBlob
        {
            get { return this._ciphertextBlob; }
            set { this._ciphertextBlob = value; }
        }

        // Check to see if CiphertextBlob property is set
        internal bool IsSetCiphertextBlob()
        {
            return this._ciphertextBlob != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEncryptionAlgorithm. 
        /// <para>
        /// Specifies the encryption algorithm that KMS will use to reecrypt the data after it
        /// has decrypted it. The default value, <code>SYMMETRIC_DEFAULT</code>, represents the
        /// encryption algorithm used for symmetric encryption KMS keys.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the destination KMS key is an asymmetric KMS
        /// key.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec DestinationEncryptionAlgorithm
        {
            get { return this._destinationEncryptionAlgorithm; }
            set { this._destinationEncryptionAlgorithm = value; }
        }

        // Check to see if DestinationEncryptionAlgorithm property is set
        internal bool IsSetDestinationEncryptionAlgorithm()
        {
            return this._destinationEncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEncryptionContext. 
        /// <para>
        /// Specifies that encryption context to use when the reencrypting the data.
        /// </para>
        ///  
        /// <para>
        /// A destination encryption context is valid only when the destination KMS key is a symmetric
        /// encryption KMS key. The standard ciphertext format for asymmetric KMS keys does not
        /// include fields for metadata.
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
        public Dictionary<string, string> DestinationEncryptionContext
        {
            get { return this._destinationEncryptionContext; }
            set { this._destinationEncryptionContext = value; }
        }

        // Check to see if DestinationEncryptionContext property is set
        internal bool IsSetDestinationEncryptionContext()
        {
            return this._destinationEncryptionContext != null && this._destinationEncryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DestinationKeyId. 
        /// <para>
        /// A unique identifier for the KMS key that is used to reencrypt the data. Specify a
        /// symmetric encryption KMS key or an asymmetric KMS key with a <code>KeyUsage</code>
        /// value of <code>ENCRYPT_DECRYPT</code>. To find the <code>KeyUsage</code> value of
        /// a KMS key, use the <a>DescribeKey</a> operation.
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
        public string DestinationKeyId
        {
            get { return this._destinationKeyId; }
            set { this._destinationKeyId = value; }
        }

        // Check to see if DestinationKeyId property is set
        internal bool IsSetDestinationKeyId()
        {
            return this._destinationKeyId != null;
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
        /// Gets and sets the property SourceEncryptionAlgorithm. 
        /// <para>
        /// Specifies the encryption algorithm that KMS will use to decrypt the ciphertext before
        /// it is reencrypted. The default value, <code>SYMMETRIC_DEFAULT</code>, represents the
        /// algorithm used for symmetric encryption KMS keys.
        /// </para>
        ///  
        /// <para>
        /// Specify the same algorithm that was used to encrypt the ciphertext. If you specify
        /// a different algorithm, the decrypt attempt fails.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the ciphertext was encrypted under an asymmetric
        /// KMS key.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec SourceEncryptionAlgorithm
        {
            get { return this._sourceEncryptionAlgorithm; }
            set { this._sourceEncryptionAlgorithm = value; }
        }

        // Check to see if SourceEncryptionAlgorithm property is set
        internal bool IsSetSourceEncryptionAlgorithm()
        {
            return this._sourceEncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEncryptionContext. 
        /// <para>
        /// Specifies the encryption context to use to decrypt the ciphertext. Enter the same
        /// encryption context that was used to encrypt the ciphertext.
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
        public Dictionary<string, string> SourceEncryptionContext
        {
            get { return this._sourceEncryptionContext; }
            set { this._sourceEncryptionContext = value; }
        }

        // Check to see if SourceEncryptionContext property is set
        internal bool IsSetSourceEncryptionContext()
        {
            return this._sourceEncryptionContext != null && this._sourceEncryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceKeyId. 
        /// <para>
        /// Specifies the KMS key that KMS will use to decrypt the ciphertext before it is re-encrypted.
        /// </para>
        ///  
        /// <para>
        /// Enter a key ID of the KMS key that was used to encrypt the ciphertext. If you identify
        /// a different KMS key, the <code>ReEncrypt</code> operation throws an <code>IncorrectKeyException</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the ciphertext was encrypted under an asymmetric
        /// KMS key. If you used a symmetric encryption KMS key, KMS can get the KMS key from
        /// metadata that it adds to the symmetric ciphertext blob. However, it is always recommended
        /// as a best practice. This practice ensures that you use the KMS key that you intend.
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
        [AWSProperty(Min=1, Max=2048)]
        public string SourceKeyId
        {
            get { return this._sourceKeyId; }
            set { this._sourceKeyId = value; }
        }

        // Check to see if SourceKeyId property is set
        internal bool IsSetSourceKeyId()
        {
            return this._sourceKeyId != null;
        }

    }
}