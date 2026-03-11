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
    /// Container for the parameters to the GenerateDataKeyPair operation.
    /// Returns a unique asymmetric data key pair for use outside of KMS. This operation returns
    /// a plaintext public key, a plaintext private key, and a copy of the private key that
    /// is encrypted under the symmetric encryption KMS key you specify. You can use the data
    /// key pair to perform asymmetric cryptography and implement digital signatures outside
    /// of KMS. The bytes in the keys are random; they are not related to the caller or to
    /// the KMS key that is used to encrypt the private key. 
    /// 
    ///  
    /// <para>
    /// You can use the public key that <c>GenerateDataKeyPair</c> returns to encrypt data
    /// or verify a signature outside of KMS. Then, store the encrypted private key with the
    /// data. When you are ready to decrypt data or sign a message, you can use the <a>Decrypt</a>
    /// operation to decrypt the encrypted private key.
    /// </para>
    ///  
    /// <para>
    /// To generate a data key pair, you must specify a symmetric encryption KMS key to encrypt
    /// the private key in a data key pair. You cannot use an asymmetric KMS key or a KMS
    /// key in a custom key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
    /// operation. 
    /// </para>
    ///  
    /// <para>
    /// Use the <c>KeyPairSpec</c> parameter to choose an RSA or Elliptic Curve (ECC) data
    /// key pair. In China Regions, you can also choose an SM2 data key pair. KMS recommends
    /// that you use ECC key pairs for signing, and use RSA and SM2 key pairs for either encryption
    /// or signing, but not both. However, KMS cannot enforce any restrictions on the use
    /// of data key pairs outside of KMS.
    /// </para>
    ///  
    /// <para>
    /// If you are using the data key pair to encrypt data, or for any operation where you
    /// don't immediately need a private key, consider using the <a>GenerateDataKeyPairWithoutPlaintext</a>
    /// operation. <c>GenerateDataKeyPairWithoutPlaintext</c> returns a plaintext public key
    /// and an encrypted private key, but omits the plaintext private key that you need only
    /// to decrypt ciphertext or sign a message. Later, when you need to decrypt the data
    /// or sign a message, use the <a>Decrypt</a> operation to decrypt the encrypted private
    /// key in the data key pair.
    /// </para>
    ///  
    /// <para>
    ///  <c>GenerateDataKeyPair</c> returns a unique data key pair for each request. The bytes
    /// in the keys are random; they are not related to the caller or the KMS key that is
    /// used to encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
    /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>. The private
    /// key is a DER-encoded PKCS8 PrivateKeyInfo, as specified in <a href="https://tools.ietf.org/html/rfc5958">RFC
    /// 5958</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>GenerateDataKeyPair</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
    /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
    /// Amazon EC2. To call <c>GenerateDataKeyPair</c> for an Amazon Web Services Nitro enclave
    /// or NitroTPM, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
    /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
    /// parameter to provide the attestation document for the attested environment. <c>GenerateDataKeyPair</c>
    /// returns the public data key and a copy of the private data key encrypted under the
    /// specified KMS key, as usual. But instead of a plaintext copy of the private data key
    /// (<c>PrivateKeyPlaintext</c>), the response includes a copy of the private data key
    /// encrypted under the public key from the attestation document (<c>CiphertextForRecipient</c>).
    /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves
    /// or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
    /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can use an optional encryption context to add additional security to the encryption
    /// operation. If you specify an <c>EncryptionContext</c>, you must specify the same encryption
    /// context (a case-sensitive exact match) when decrypting the encrypted data key. Otherwise,
    /// the request to decrypt fails with an <c>InvalidCiphertextException</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
    /// Context</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPair</a>
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
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class GenerateDataKeyPairRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _dryRun;
        private Dictionary<string, string> _encryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _grantTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyId;
        private DataKeyPairSpec _keyPairSpec;
        private RecipientInfo _recipient;

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
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Specifies the encryption context that will be used when encrypting the private key
        /// in the data key pair.
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
        /// Specifies the symmetric encryption KMS key that encrypts the private key in the data
        /// key pair. You cannot specify an asymmetric KMS key or a KMS key in a custom key store.
        /// To get the type and origin of your KMS key, use the <a>DescribeKey</a> operation.
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
        /// Gets and sets the property KeyPairSpec. 
        /// <para>
        /// Determines the type of data key pair that is generated. 
        /// </para>
        ///  
        /// <para>
        /// The KMS rule that restricts the use of asymmetric RSA and SM2 KMS keys to encrypt
        /// and decrypt or to sign and verify (but not both), the rule that permits you to use
        /// ECC KMS keys only to sign and verify, and the rule that permits you to use ML-DSA
        /// key pairs to sign and verify only are not effective on data key pairs, which are used
        /// outside of KMS. The SM2 key spec is only available in China Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataKeyPairSpec KeyPairSpec
        {
            get { return this._keyPairSpec; }
            set { this._keyPairSpec = value; }
        }

        // Check to see if KeyPairSpec property is set
        internal bool IsSetKeyPairSpec()
        {
            return this._keyPairSpec != null;
        }

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// A signed <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave-how.html#term-attestdoc">attestation
        /// document</a> from an Amazon Web Services Nitro enclave or NitroTPM, and the encryption
        /// algorithm to use with the public key in the attestation document. The only valid encryption
        /// algorithm is <c>RSAES_OAEP_SHA_256</c>. 
        /// </para>
        ///  
        /// <para>
        /// This parameter only supports attestation documents for Amazon Web Services Nitro Enclaves
        /// or Amazon Web Services NitroTPM. To call GenerateDataKeyPair generate an attestation
        /// document use either <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> for an Amazon Web Services Nitro Enclaves or <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/attestation-get-doc.html">Amazon
        /// Web Services NitroTPM tools</a> for Amazon Web Services NitroTPM. Then use the Recipient
        /// parameter from any Amazon Web Services SDK to provide the attestation document for
        /// the attested environment.
        /// </para>
        ///  
        /// <para>
        /// When you use this parameter, instead of returning a plaintext copy of the private
        /// data key, KMS encrypts the plaintext private data key under the public key in the
        /// attestation document, and returns the resulting ciphertext in the <c>CiphertextForRecipient</c>
        /// field in the response. This ciphertext can be decrypted only with the private key
        /// in the attested environment. The <c>CiphertextBlob</c> field in the response contains
        /// a copy of the private data key encrypted under the KMS key specified by the <c>KeyId</c>
        /// parameter. The <c>PrivateKeyPlaintext</c> field in the response is null or empty.
        /// </para>
        ///  
        /// <para>
        /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves
        /// or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
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