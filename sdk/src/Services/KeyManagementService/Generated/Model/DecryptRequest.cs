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
    /// Container for the parameters to the Decrypt operation.
    /// Decrypts ciphertext that was encrypted by a KMS key using any of the following operations:
    /// 
    ///  <ul> <li> 
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
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use this operation to decrypt ciphertext that was encrypted under a symmetric
    /// encryption KMS key or an asymmetric encryption KMS key. When the KMS key is asymmetric,
    /// you must specify the KMS key and the encryption algorithm that was used to encrypt
    /// the ciphertext. For information about asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
    /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The <c>Decrypt</c> operation also decrypts ciphertext that was encrypted outside of
    /// KMS by the public key in an KMS asymmetric KMS key. However, it cannot decrypt symmetric
    /// ciphertext produced by other libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
    /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
    /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
    /// incompatible with KMS.
    /// </para>
    ///  
    /// <para>
    /// If the ciphertext was encrypted under a symmetric encryption KMS key, the <c>KeyId</c>
    /// parameter is optional. KMS can get this information from metadata that it adds to
    /// the symmetric ciphertext blob. This feature adds durability to your implementation
    /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
    /// even if they've lost track of the key ID. However, specifying the KMS key is always
    /// recommended as a best practice. When you use the <c>KeyId</c> parameter to specify
    /// a KMS key, KMS only uses the KMS key you specify. If the ciphertext was encrypted
    /// under a different KMS key, the <c>Decrypt</c> operation fails. This practice ensures
    /// that you use the KMS key that you intend.
    /// </para>
    ///  
    /// <para>
    /// Whenever possible, use key policies to give users permission to call the <c>Decrypt</c>
    /// operation on a particular KMS key, instead of using IAM policies. Otherwise, you might
    /// create an IAM policy that gives the user <c>Decrypt</c> permission on all KMS keys.
    /// This user could decrypt ciphertext that was encrypted by KMS keys in other accounts
    /// if the key policy for the cross-account KMS key permits it. If you must use an IAM
    /// policy for <c>Decrypt</c> permissions, limit the user to particular KMS keys or particular
    /// trusted accounts. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/iam-policies.html#iam-policies-best-practices">Best
    /// practices for IAM policies</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <c>Decrypt</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
    /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
    /// Amazon EC2. To call <c>Decrypt</c> for a Nitro enclave, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
    /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
    /// parameter to provide the attestation document for the enclave. Instead of the plaintext
    /// data, the response includes the plaintext data encrypted with the public key from
    /// the attestation document (<c>CiphertextForRecipient</c>). For information about the
    /// interaction between KMS and Amazon Web Services Nitro Enclaves, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
    /// Amazon Web Services Nitro Enclaves uses KMS</a> in the <i>Key Management Service Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. If you use the <c>KeyId</c> parameter to identify
    /// a KMS key in a different Amazon Web Services account, specify the key ARN or the alias
    /// ARN of the KMS key.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Decrypt</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
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
    ///  </li> <li> 
    /// <para>
    ///  <a>ReEncrypt</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class DecryptRequest : AmazonKeyManagementServiceRequest
    {
        private MemoryStream _ciphertextBlob;
        private bool? _dryRun;
        private EncryptionAlgorithmSpec _encryptionAlgorithm;
        private Dictionary<string, string> _encryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _grantTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyId;
        private RecipientInfo _recipient;

        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// Ciphertext to be decrypted. The blob includes metadata.
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
        /// Specifies the encryption algorithm that will be used to decrypt the ciphertext. Specify
        /// the same algorithm that was used to encrypt the data. If you specify a different algorithm,
        /// the <c>Decrypt</c> operation fails.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the ciphertext was encrypted under an asymmetric
        /// KMS key. The default value, <c>SYMMETRIC_DEFAULT</c>, represents the only supported
        /// algorithm that is valid for symmetric encryption KMS keys.
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
        /// Specifies the encryption context to use when decrypting the data. An encryption context
        /// is valid only for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a> with a symmetric encryption KMS key. The standard asymmetric encryption
        /// algorithms and HMAC algorithms that KMS uses do not support an encryption context.
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
        /// Specifies the KMS key that KMS uses to decrypt the ciphertext.
        /// </para>
        ///  
        /// <para>
        /// Enter a key ID of the KMS key that was used to encrypt the ciphertext. If you identify
        /// a different KMS key, the <c>Decrypt</c> operation throws an <c>IncorrectKeyException</c>.
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
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Recipient. 
        /// <para>
        /// A signed <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave-concepts.html#term-attestdoc">attestation
        /// document</a> from an Amazon Web Services Nitro enclave and the encryption algorithm
        /// to use with the enclave's public key. The only valid encryption algorithm is <c>RSAES_OAEP_SHA_256</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This parameter only supports attestation documents for Amazon Web Services Nitro Enclaves.
        /// To include this parameter, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK.
        /// </para>
        ///  
        /// <para>
        /// When you use this parameter, instead of returning the plaintext data, KMS encrypts
        /// the plaintext data with the public key in the attestation document, and returns the
        /// resulting ciphertext in the <c>CiphertextForRecipient</c> field in the response. This
        /// ciphertext can be decrypted only with the private key in the enclave. The <c>Plaintext</c>
        /// field in the response is null or empty.
        /// </para>
        ///  
        /// <para>
        /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves uses KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public RecipientInfo Recipient
        {
            get { return this._recipient; }
            set { this._recipient = value; }
        }

        // Check to see if Recipient property is set
        internal bool IsSetRecipient()
        {
            return this._recipient != null;
        }

    }
}