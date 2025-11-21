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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the ImportKey operation.
    /// Imports symmetric keys and public key certificates in PEM format (base64 encoded)
    /// into Amazon Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography simplifies key exchange by replacing the
    /// existing paper-based approach with a modern electronic approach. With <c>ImportKey</c>
    /// you can import symmetric keys using either symmetric and asymmetric key exchange mechanisms.
    /// </para>
    ///  
    /// <para>
    /// For symmetric key exchange, Amazon Web Services Payment Cryptography uses the ANSI
    /// X9 TR-31 norm in accordance with PCI PIN guidelines. And for asymmetric key exchange,
    /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm, RSA unwrap,
    /// and ECDH (Elliptic Curve Diffie-Hellman) key exchange mechanisms. Asymmetric key exchange
    /// methods are typically used to establish bi-directional trust between the two parties
    /// exhanging keys and are used for initial key exchange such as Key Encryption Key (KEK)
    /// or Zone Master Key (ZMK). After which you can import working keys using symmetric
    /// method to perform various cryptographic operations within Amazon Web Services Payment
    /// Cryptography.
    /// </para>
    ///  
    /// <para>
    /// PCI requires specific minimum key strength of wrapping keys used to protect the keys
    /// being exchanged electronically. These requirements can change when PCI standards are
    /// revised. The rules specify that wrapping keys used for transport must be at least
    /// as strong as the key being protected. For more information on recommended key strength
    /// of wrapping keys and key exchange mechanism, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-importexport.html">Importing
    /// and exporting keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can also import a <i>root public key certificate</i>, used to sign other public
    /// key certificates, or a <i>trusted public key certificate</i> under an already established
    /// root public key certificate.
    /// </para>
    ///  
    /// <para>
    ///  <b>To import a public root key certificate</b> 
    /// </para>
    ///  
    /// <para>
    /// Using this operation, you can import the public component (in PEM cerificate format)
    /// of your private root key. You can use the imported public root key certificate for
    /// digital signatures, for example signing wrapping key or signing key in TR-34, within
    /// your Amazon Web Services Payment Cryptography account.
    /// </para>
    ///  
    /// <para>
    /// Set the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>KeyMaterial</c>: <c>RootCertificatePublicKey</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>KeyClass</c>: <c>PUBLIC_KEY</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>KeyModesOfUse</c>: <c>Verify</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>KeyUsage</c>: <c>TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PublicKeyCertificate</c>: The public key certificate in PEM format (base64 encoded)
    /// of the private root key under import.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To import a trusted public key certificate</b> 
    /// </para>
    ///  
    /// <para>
    /// The root public key certificate must be in place and operational before you import
    /// a trusted public key certificate. Set the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>KeyMaterial</c>: <c>TrustedCertificatePublicKey</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: <c>KeyArn</c> of the <c>RootCertificatePublicKey</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>KeyModesOfUse</c> and <c>KeyUsage</c>: Corresponding to the cryptographic operations
    /// such as wrap, sign, or encrypt that you will allow the trusted public key certificate
    /// to perform.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PublicKeyCertificate</c>: The trusted public key certificate in PEM format (base64
    /// encoded) under import.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To import initial keys (KEK or ZMK or similar) using TR-34</b> 
    /// </para>
    ///  
    /// <para>
    /// Using this operation, you can import initial key using TR-34 asymmetric key exchange.
    /// In TR-34 terminology, the sending party of the key is called Key Distribution Host
    /// (KDH) and the receiving party of the key is called Key Receiving Device (KRD). During
    /// the key import process, KDH is the user who initiates the key import and KRD is Amazon
    /// Web Services Payment Cryptography who receives the key.
    /// </para>
    ///  
    /// <para>
    /// To initiate TR-34 key import, the KDH must obtain an import token by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>.
    /// This operation generates an encryption keypair for the purpose of key import, signs
    /// the key and returns back the wrapping key certificate (also known as KRD wrapping
    /// certificate) and the root certificate chain. The KDH must trust and install the KRD
    /// wrapping certificate on its HSM and use it to encrypt (wrap) the KDH key during TR-34
    /// WrappedKeyBlock generation. The import token and associated KRD wrapping certificate
    /// expires after 30 days.
    /// </para>
    ///  
    /// <para>
    /// Next the KDH generates a key pair for the purpose of signing the encrypted KDH key
    /// and provides the public certificate of the signing key to Amazon Web Services Payment
    /// Cryptography. The KDH will also need to import the root certificate chain of the KDH
    /// signing certificate by calling <c>ImportKey</c> for <c>RootCertificatePublicKey</c>.
    /// For more information on TR-34 key import, see section <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-import.html">Importing
    /// symmetric keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Set the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>KeyMaterial</c>: Use <c>Tr34KeyBlock</c> parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>KeyARN</c> of the certificate
    /// chain that signed the KDH signing key certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ImportToken</c>: Obtained from KRD by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WrappedKeyBlock</c>: The TR-34 wrapped key material from KDH. It contains the
    /// KDH key under import, wrapped with KRD wrapping certificate and signed by KDH signing
    /// private key. This TR-34 key block is typically generated by the KDH Hardware Security
    /// Module (HSM) outside of Amazon Web Services Payment Cryptography.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>SigningKeyCertificate</c>: The public key certificate in PEM format (base64 encoded)
    /// of the KDH signing key generated under the root certificate (CertificateAuthorityPublicKeyIdentifier)
    /// imported in Amazon Web Services Payment Cryptography.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To import initial keys (KEK or ZMK or similar) using RSA Wrap and Unwrap</b> 
    /// </para>
    ///  
    /// <para>
    /// Using this operation, you can import initial key using asymmetric RSA wrap and unwrap
    /// key exchange method. To initiate import, call <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>
    /// with <c>KeyMaterial</c> set to <c>KEY_CRYPTOGRAM</c> to generate an import token.
    /// This operation also generates an encryption keypair for the purpose of key import,
    /// signs the key and returns back the wrapping key certificate in PEM format (base64
    /// encoded) and its root certificate chain. The import token and associated KRD wrapping
    /// certificate expires after 30 days. 
    /// </para>
    ///  
    /// <para>
    /// You must trust and install the wrapping certificate and its certificate chain on the
    /// sending HSM and use it to wrap the key under export for WrappedKeyCryptogram generation.
    /// Next call <c>ImportKey</c> with <c>KeyMaterial</c> set to <c>KEY_CRYPTOGRAM</c> and
    /// provide the <c>ImportToken</c> and <c>KeyAttributes</c> for the key under import.
    /// </para>
    ///  
    /// <para>
    ///  <b>To import working keys using TR-31</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange norm to
    /// import working keys. A KEK must be established within Amazon Web Services Payment
    /// Cryptography by using TR-34 key import or by using <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
    /// To initiate a TR-31 key import, set the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>KeyMaterial</c>: Use <c>Tr31KeyBlock</c> parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WrappedKeyBlock</c>: The TR-31 wrapped key material. It contains the key under
    /// import, encrypted using KEK. The TR-31 key block is typically generated by a HSM outside
    /// of Amazon Web Services Payment Cryptography. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>WrappingKeyIdentifier</c>: The <c>KeyArn</c> of the KEK that Amazon Web Services
    /// Payment Cryptography uses to decrypt or unwrap the key under import.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To import working keys using ECDH</b> 
    /// </para>
    ///  
    /// <para>
    /// You can also use ECDH key agreement to import working keys as a TR-31 keyblock, where
    /// the wrapping key is an ECDH derived key.
    /// </para>
    ///  
    /// <para>
    /// To initiate a TR-31 key import using ECDH, both sides must create an ECC key pair
    /// with key usage K3 and exchange public key certificates. In Amazon Web Services Payment
    /// Cryptography, you can do this by calling <c>CreateKey</c> and then <c>GetPublicKeyCertificate</c>
    /// to retrieve its public key certificate. Next, you can then generate a TR-31 WrappedKeyBlock
    /// using your own ECC key pair, the public certificate of the service's ECC key pair,
    /// and the key derivation parameters including key derivation function, hash algorithm,
    /// derivation data, and key algorithm. If you have not already done so, you must import
    /// the CA chain that issued the receiving public key certificate by calling <c>ImportKey</c>
    /// with input <c>RootCertificatePublicKey</c> for root CA or <c>TrustedPublicKey</c>
    /// for intermediate CA. To complete the TR-31 key import, you can use the following parameters.
    /// It is important that the ECDH key derivation parameters you use should match those
    /// used during import to derive the same shared wrapping key within Amazon Web Services
    /// Payment Cryptography.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>KeyMaterial</c>: Use <c>DiffieHellmanTr31KeyBlock</c> parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PrivateKeyIdentifier</c>: The <c>KeyArn</c> of the ECC key pair created within
    /// Amazon Web Services Payment Cryptography to derive a shared KEK.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PublicKeyCertificate</c>: The public key certificate of the receiving ECC key
    /// pair in PEM format (base64 encoded) to derive a shared KEK.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>keyARN</c> of the CA that
    /// signed the public key certificate of the receiving ECC key pair.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ImportKeyRequest : AmazonPaymentCryptographyRequest
    {
        private bool? _enabled;
        private KeyCheckValueAlgorithm _keyCheckValueAlgorithm;
        private ImportKeyMaterial _keyMaterial;
        private List<string> _replicationRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether import key is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyCheckValueAlgorithm. 
        /// <para>
        /// The algorithm that Amazon Web Services Payment Cryptography uses to calculate the
        /// key check value (KCV). It is used to validate the key integrity.
        /// </para>
        ///  
        /// <para>
        /// For TDES keys, the KCV is computed by encrypting 8 bytes, each with value of zero,
        /// with the key to be checked and retaining the 3 highest order bytes of the encrypted
        /// result. For AES keys, the KCV is computed using a CMAC algorithm where the input data
        /// is 16 bytes of zero and retaining the 3 highest order bytes of the encrypted result.
        /// </para>
        /// </summary>
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm
        {
            get { return this._keyCheckValueAlgorithm; }
            set { this._keyCheckValueAlgorithm = value; }
        }

        // Check to see if KeyCheckValueAlgorithm property is set
        internal bool IsSetKeyCheckValueAlgorithm()
        {
            return this._keyCheckValueAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMaterial. 
        /// <para>
        /// The key or public key certificate type to use during key material import, for example
        /// TR-34 or RootCertificatePublicKey.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportKeyMaterial KeyMaterial
        {
            get { return this._keyMaterial; }
            set { this._keyMaterial = value; }
        }

        // Check to see if KeyMaterial property is set
        internal bool IsSetKeyMaterial()
        {
            return this._keyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationRegions.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplicationRegions
        {
            get { return this._replicationRegions; }
            set { this._replicationRegions = value; }
        }

        // Check to see if ReplicationRegions property is set
        internal bool IsSetReplicationRegions()
        {
            return this._replicationRegions != null && (this._replicationRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags to the Amazon Web Services Payment Cryptography key. Use
        /// this parameter to tag a key when it is imported. To tag an existing Amazon Web Services
        /// Payment Cryptography key, use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_TagResource.html">TagResource</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Both the tag key and the tag value
        /// are required, but the tag value can be an empty (null) string. You can't have more
        /// than one tag on an Amazon Web Services Payment Cryptography key with the same tag
        /// key. If you specify an existing tag key with a different tag value, Amazon Web Services
        /// Payment Cryptography replaces the current tag value with the specified one.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't include personal, confidential or sensitive information in this field. This
        /// field may be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Tagging or untagging an Amazon Web Services Payment Cryptography key can allow or
        /// deny permission to the key.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}