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
    /// Container for the parameters to the DeriveSharedSecret operation.
    /// Derives a shared secret using a key agreement algorithm.
    /// 
    ///  <note> 
    /// <para>
    /// You must use an asymmetric NIST-recommended elliptic curve (ECC) or SM2 (China Regions
    /// only) KMS key pair with a <c>KeyUsage</c> value of <c>KEY_AGREEMENT</c> to call DeriveSharedSecret.
    /// </para>
    ///  </note> 
    /// <para>
    /// DeriveSharedSecret uses the <a href="https://nvlpubs.nist.gov/nistpubs/SpecialPublications/NIST.SP.800-56Ar3.pdf#page=60">Elliptic
    /// Curve Cryptography Cofactor Diffie-Hellman Primitive</a> (ECDH) to establish a key
    /// agreement between two peers by deriving a shared secret from their elliptic curve
    /// public-private key pairs. You can use the raw shared secret that DeriveSharedSecret
    /// returns to derive a symmetric key that can encrypt and decrypt data that is sent between
    /// the two peers, or that can generate and verify HMACs. KMS recommends that you follow
    /// <a href="https://nvlpubs.nist.gov/nistpubs/SpecialPublications/NIST.SP.800-56Cr2.pdf">NIST
    /// recommendations for key derivation</a> when using the raw shared secret to derive
    /// a symmetric key.
    /// </para>
    ///  
    /// <para>
    /// The following workflow demonstrates how to establish key agreement over an insecure
    /// communication channel using DeriveSharedSecret.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    ///  <b>Alice</b> calls <a>CreateKey</a> to create an asymmetric KMS key pair with a <c>KeyUsage</c>
    /// value of <c>KEY_AGREEMENT</c>.
    /// </para>
    ///  
    /// <para>
    /// The asymmetric KMS key must use a NIST-recommended elliptic curve (ECC) or SM2 (China
    /// Regions only) key spec.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Bob</b> creates an elliptic curve key pair.
    /// </para>
    ///  
    /// <para>
    /// Bob can call <a>CreateKey</a> to create an asymmetric KMS key pair or generate a key
    /// pair outside of KMS. Bob's key pair must use the same NIST-recommended elliptic curve
    /// (ECC) or SM2 (China Regions ony) curve as Alice.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Alice and Bob <b>exchange their public keys</b> through an insecure communication
    /// channel (like the internet).
    /// </para>
    ///  
    /// <para>
    /// Use <a>GetPublicKey</a> to download the public key of your asymmetric KMS key pair.
    /// </para>
    ///  <note> 
    /// <para>
    /// KMS strongly recommends verifying that the public key you receive came from the expected
    /// party before using it to derive a shared secret.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    ///  <b>Alice</b> calls DeriveSharedSecret.
    /// </para>
    ///  
    /// <para>
    /// KMS uses the private key from the KMS key pair generated in <b>Step 1</b>, Bob's public
    /// key, and the Elliptic Curve Cryptography Cofactor Diffie-Hellman Primitive to derive
    /// the shared secret. The private key in your KMS key pair never leaves KMS unencrypted.
    /// DeriveSharedSecret returns the raw shared secret.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Bob</b> uses the Elliptic Curve Cryptography Cofactor Diffie-Hellman Primitive
    /// to calculate the same raw secret using his private key and Alice's public key.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// To derive a shared secret you must provide a key agreement algorithm, the private
    /// key of the caller's asymmetric NIST-recommended elliptic curve or SM2 (China Regions
    /// only) KMS key pair, and the public key from your peer's NIST-recommended elliptic
    /// curve or SM2 (China Regions only) key pair. The public key can be from another asymmetric
    /// KMS key pair or from a key pair generated outside of KMS, but both key pairs must
    /// be on the same elliptic curve.
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
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeriveSharedSecret</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPublicKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeKey</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class DeriveSharedSecretRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _dryRun;
        private List<string> _grantTokens = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private KeyAgreementAlgorithmSpec _keyAgreementAlgorithm;
        private string _keyId;
        private MemoryStream _publicKey;
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
        /// Gets and sets the property KeyAgreementAlgorithm. 
        /// <para>
        /// Specifies the key agreement algorithm used to derive the shared secret. The only valid
        /// value is <c>ECDH</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAgreementAlgorithmSpec KeyAgreementAlgorithm
        {
            get { return this._keyAgreementAlgorithm; }
            set { this._keyAgreementAlgorithm = value; }
        }

        // Check to see if KeyAgreementAlgorithm property is set
        internal bool IsSetKeyAgreementAlgorithm()
        {
            return this._keyAgreementAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies an asymmetric NIST-recommended ECC or SM2 (China Regions only) KMS key.
        /// KMS uses the private key in the specified key pair to derive the shared secret. The
        /// key usage of the KMS key must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
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
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// Specifies the public key in your peer's NIST-recommended elliptic curve (ECC) or SM2
        /// (China Regions only) key pair.
        /// </para>
        ///  
        /// <para>
        /// The public key must be a DER-encoded X.509 public key, also known as <c>SubjectPublicKeyInfo</c>
        /// (SPKI), as defined in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>.
        /// </para>
        ///  
        /// <para>
        ///  <a>GetPublicKey</a> returns the public key of an asymmetric KMS key pair in the required
        /// DER-encoded format.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use <a href="https://docs.aws.amazon.com/cli/v1/userguide/cli-chap-welcome.html">Amazon
        /// Web Services CLI version 1</a>, you must provide the DER-encoded X.509 public key
        /// in a file. Otherwise, the Amazon Web Services CLI Base64-encodes the public key a
        /// second time, resulting in a <c>ValidationException</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify the public key as binary data in a file using fileb (<c>fileb://&lt;path-to-file&gt;</c>)
        /// or in-line using a Base64 encoded string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public MemoryStream PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
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
        /// or Amazon Web Services NitroTPM. To call DeriveSharedSecret generate an attestation
        /// document use either <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> for an Amazon Web Services Nitro Enclaves or <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/attestation-get-doc.html">Amazon
        /// Web Services NitroTPM tools</a> for Amazon Web Services NitroTPM. Then use the Recipient
        /// parameter from any Amazon Web Services SDK to provide the attestation document for
        /// the attested environment.
        /// </para>
        ///  
        /// <para>
        /// When you use this parameter, instead of returning a plaintext copy of the shared secret,
        /// KMS encrypts the plaintext shared secret under the public key in the attestation document,
        /// and returns the resulting ciphertext in the <c>CiphertextForRecipient</c> field in
        /// the response. This ciphertext can be decrypted only with the private key in the attested
        /// environment. The <c>CiphertextBlob</c> field in the response contains the encrypted
        /// shared secret derived from the KMS key specified by the <c>KeyId</c> parameter and
        /// public key specified by the <c>PublicKey</c> parameter. The <c>SharedSecret</c> field
        /// in the response is null or empty.
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