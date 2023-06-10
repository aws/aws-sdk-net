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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Container for the parameters to the ImportKey operation.
    /// Imports keys and public key certificates into Amazon Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography simplifies main or root key exchange process
    /// by eliminating the need of a paper-based key exchange process. It takes a modern and
    /// secure approach based of the ANSI X9 TR-34 key exchange standard. 
    /// </para>
    ///  
    /// <para>
    /// You can use <code>ImportKey</code> to import main or root keys such as KEK (Key Encryption
    /// Key) using asymmetric key exchange technique following the ANSI X9 TR-34 standard.
    /// The ANSI X9 TR-34 standard uses asymmetric keys to establishes bi-directional trust
    /// between the two parties exchanging keys. 
    /// </para>
    ///  
    /// <para>
    /// After you have imported a main or root key, you can import working keys to perform
    /// various cryptographic operations within Amazon Web Services Payment Cryptography using
    /// the ANSI X9 TR-31 symmetric key exchange standard as mandated by PCI PIN.
    /// </para>
    ///  
    /// <para>
    /// You can also import a <i>root public key certificate</i>, a self-signed certificate
    /// used to sign other public key certificates, or a <i>trusted public key certificate</i>
    /// under an already established root public key certificate. 
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
    ///  <code>KeyMaterial</code>: <code>RootCertificatePublicKey</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KeyClass</code>: <code>PUBLIC_KEY</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KeyModesOfUse</code>: <code>Verify</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KeyUsage</code>: <code>TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PublicKeyCertificate</code>: The certificate authority used to sign the root
    /// public key certificate.
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
    ///  <code>KeyMaterial</code>: <code>TrustedCertificatePublicKey</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CertificateAuthorityPublicKeyIdentifier</code>: <code>KeyArn</code> of the
    /// <code>RootCertificatePublicKey</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KeyModesOfUse</code> and <code>KeyUsage</code>: Corresponding to the cryptographic
    /// operations such as wrap, sign, or encrypt that you will allow the trusted public key
    /// certificate to perform.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PublicKeyCertificate</code>: The certificate authority used to sign the trusted
    /// public key certificate.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Import main keys</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography uses TR-34 asymmetric key exchange standard
    /// to import main keys such as KEK. In TR-34 terminology, the sending party of the key
    /// is called Key Distribution Host (KDH) and the receiving party of the key is called
    /// Key Receiving Host (KRH). During the key import process, KDH is the user who initiates
    /// the key import and KRH is Amazon Web Services Payment Cryptography who receives the
    /// key. Before initiating TR-34 key import, you must obtain an import token by calling
    /// <a>GetParametersForImport</a>. This operation also returns the wrapping key certificate
    /// that KDH uses wrap key under import to generate a TR-34 wrapped key block. The import
    /// token expires after 7 days.
    /// </para>
    ///  
    /// <para>
    /// Set the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CertificateAuthorityPublicKeyIdentifier</code>: The <code>KeyArn</code> of
    /// the certificate chain that will sign the signing key certificate and should exist
    /// within Amazon Web Services Payment Cryptography before initiating TR-34 key import.
    /// If it does not exist, you can import it by calling by calling <code>ImportKey</code>
    /// for <code>RootCertificatePublicKey</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ImportToken</code>: Obtained from KRH by calling <a>GetParametersForImport</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WrappedKeyBlock</code>: The TR-34 wrapped key block from KDH. It contains the
    /// KDH key under import, wrapped with KRH provided wrapping key certificate and signed
    /// by the KDH private signing key. This TR-34 key block is generated by the KDH Hardware
    /// Security Module (HSM) outside of Amazon Web Services Payment Cryptography.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>SigningKeyCertificate</code>: The public component of the private key that
    /// signed the KDH TR-34 wrapped key block. In PEM certificate format.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// TR-34 is intended primarily to exchange 3DES keys. Your ability to export AES-128
    /// and larger AES keys may be dependent on your source system.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Import working keys</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange standard
    /// to import working keys. A KEK must be established within Amazon Web Services Payment
    /// Cryptography by using TR-34 key import. To initiate a TR-31 key import, set the following
    /// parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>WrappedKeyBlock</code>: The key under import and encrypted using KEK. The TR-31
    /// key block generated by your HSM outside of Amazon Web Services Payment Cryptography.
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WrappingKeyIdentifier</code>: The <code>KeyArn</code> of the KEK that Amazon
    /// Web Services Payment Cryptography uses to decrypt or unwrap the key under import.
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
    ///  <a>ExportKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetParametersForImport</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ImportKeyRequest : AmazonPaymentCryptographyRequest
    {
        private bool? _enabled;
        private KeyCheckValueAlgorithm _keyCheckValueAlgorithm;
        private ImportKeyMaterial _keyMaterial;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether import key is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
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
        /// key check value (KCV) for DES and AES keys.
        /// </para>
        ///  
        /// <para>
        /// For DES key, the KCV is computed by encrypting 8 bytes, each with value '00', with
        /// the key to be checked and retaining the 3 highest order bytes of the encrypted result.
        /// For AES key, the KCV is computed by encrypting 8 bytes, each with value '01', with
        /// the key to be checked and retaining the 3 highest order bytes of the encrypted result.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the key. Each tag consists of a tag key and a tag value. Both
        /// the tag key and the tag value are required, but the tag value can be an empty (null)
        /// string. You can't have more than one tag on an Amazon Web Services Payment Cryptography
        /// key with the same tag key. 
        /// </para>
        ///  
        /// <para>
        /// You can't have more than one tag on an Amazon Web Services Payment Cryptography key
        /// with the same tag key. If you specify an existing tag key with a different tag value,
        /// Amazon Web Services Payment Cryptography replaces the current tag value with the specified
        /// one.
        /// </para>
        ///  
        /// <para>
        /// To use this parameter, you must have <code>TagResource</code> permission.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Tagging or untagging an Amazon Web Services Payment Cryptography key can allow or
        /// deny permission to the key.
        /// </para>
        ///  </note>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}