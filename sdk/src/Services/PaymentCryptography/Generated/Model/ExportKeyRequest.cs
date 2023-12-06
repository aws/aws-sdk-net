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
    /// Container for the parameters to the ExportKey operation.
    /// Exports a key from Amazon Web Services Payment Cryptography.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography simplifies key exchange by replacing the
    /// existing paper-based approach with a modern electronic approach. With <code>ExportKey</code>
    /// you can export symmetric keys using either symmetric and asymmetric key exchange mechanisms.
    /// Using this operation, you can share your Amazon Web Services Payment Cryptography
    /// generated keys with other service partners to perform cryptographic operations outside
    /// of Amazon Web Services Payment Cryptography 
    /// </para>
    ///  
    /// <para>
    /// For symmetric key exchange, Amazon Web Services Payment Cryptography uses the ANSI
    /// X9 TR-31 norm in accordance with PCI PIN guidelines. And for asymmetric key exchange,
    /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm . Asymmetric
    /// key exchange methods are typically used to establish bi-directional trust between
    /// the two parties exhanging keys and are used for initial key exchange such as Key Encryption
    /// Key (KEK). After which you can export working keys using symmetric method to perform
    /// various cryptographic operations within Amazon Web Services Payment Cryptography.
    /// </para>
    ///  
    /// <para>
    /// The TR-34 norm is intended for exchanging 3DES keys only and keys are imported in
    /// a WrappedKeyBlock format. Key attributes (such as KeyUsage, KeyAlgorithm, KeyModesOfUse,
    /// Exportability) are contained within the key block.
    /// </para>
    ///  
    /// <para>
    /// You can also use <code>ExportKey</code> functionality to generate and export an IPEK
    /// (Initial Pin Encryption Key) from Amazon Web Services Payment Cryptography using either
    /// TR-31 or TR-34 export key exchange. IPEK is generated from BDK (Base Derivation Key)
    /// and <code>ExportDukptInitialKey</code> attribute KSN (<code>KeySerialNumber</code>).
    /// The generated IPEK does not persist within Amazon Web Services Payment Cryptography
    /// and has to be re-generated each time during export.
    /// </para>
    ///  
    /// <para>
    ///  <b>To export KEK or IPEK using TR-34</b> 
    /// </para>
    ///  
    /// <para>
    /// Using this operation, you can export initial key using TR-34 asymmetric key exchange.
    /// You can only export KEK generated within Amazon Web Services Payment Cryptography.
    /// In TR-34 terminology, the sending party of the key is called Key Distribution Host
    /// (KDH) and the receiving party of the key is called Key Receiving Device (KRD). During
    /// key export process, KDH is Amazon Web Services Payment Cryptography which initiates
    /// key export and KRD is the user receiving the key.
    /// </para>
    ///  
    /// <para>
    /// To initiate TR-34 key export, the KRD must obtain an export token by calling <a>GetParametersForExport</a>.
    /// This operation also generates a key pair for the purpose of key export, signs the
    /// key and returns back the signing public key certificate (also known as KDH signing
    /// certificate) and root certificate chain. The KDH uses the private key to sign the
    /// the export payload and the signing public key certificate is provided to KRD to verify
    /// the signature. The KRD can import the root certificate into its Hardware Security
    /// Module (HSM), as required. The export token and the associated KDH signing certificate
    /// expires after 7 days. 
    /// </para>
    ///  
    /// <para>
    /// Next the KRD generates a key pair for the the purpose of encrypting the KDH key and
    /// provides the public key cerificate (also known as KRD wrapping certificate) back to
    /// KDH. The KRD will also import the root cerificate chain into Amazon Web Services Payment
    /// Cryptography by calling <a>ImportKey</a> for <code>RootCertificatePublicKey</code>.
    /// The KDH, Amazon Web Services Payment Cryptography, will use the KRD wrapping cerificate
    /// to encrypt (wrap) the key under export and signs it with signing private key to generate
    /// a TR-34 WrappedKeyBlock. For more information on TR-34 key export, see section <a
    /// href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-export.html">Exporting
    /// symmetric keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Set the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>ExportAttributes</code>: Specify export attributes in case of IPEK export.
    /// This parameter is optional for KEK export.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ExportKeyIdentifier</code>: The <code>KeyARN</code> of the KEK or BDK (in case
    /// of IPEK) under export.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KeyMaterial</code>: Use <code>Tr34KeyBlock</code> parameters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CertificateAuthorityPublicKeyIdentifier</code>: The <code>KeyARN</code> of
    /// the certificate chain that signed the KRD wrapping key certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ExportToken</code>: Obtained from KDH by calling <a>GetParametersForImport</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>WrappingKeyCertificate</code>: The public key certificate in PEM format (base64
    /// encoded) of the KRD wrapping key Amazon Web Services Payment Cryptography uses for
    /// encryption of the TR-34 export payload. This certificate must be signed by the root
    /// certificate (CertificateAuthorityPublicKeyIdentifier) imported into Amazon Web Services
    /// Payment Cryptography.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When this operation is successful, Amazon Web Services Payment Cryptography returns
    /// the KEK or IPEK as a TR-34 WrappedKeyBlock. 
    /// </para>
    ///  
    /// <para>
    ///  <b>To export WK (Working Key) or IPEK using TR-31</b> 
    /// </para>
    ///  
    /// <para>
    /// Using this operation, you can export working keys or IPEK using TR-31 symmetric key
    /// exchange. In TR-31, you must use an initial key such as KEK to encrypt or wrap the
    /// key under export. To establish a KEK, you can use <a>CreateKey</a> or <a>ImportKey</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Set the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>ExportAttributes</code>: Specify export attributes in case of IPEK export.
    /// This parameter is optional for KEK export.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ExportKeyIdentifier</code>: The <code>KeyARN</code> of the KEK or BDK (in case
    /// of IPEK) under export.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>KeyMaterial</code>: Use <code>Tr31KeyBlock</code> parameters.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When this operation is successful, Amazon Web Services Payment Cryptography returns
    /// the WK or IPEK as a TR-31 WrappedKeyBlock.
    /// </para>
    ///  
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
    ///  <a>GetParametersForExport</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ImportKey</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ExportKeyRequest : AmazonPaymentCryptographyRequest
    {
        private ExportAttributes _exportAttributes;
        private string _exportKeyIdentifier;
        private ExportKeyMaterial _keyMaterial;

        /// <summary>
        /// Gets and sets the property ExportAttributes. 
        /// <para>
        /// The attributes for IPEK generation during export.
        /// </para>
        /// </summary>
        public ExportAttributes ExportAttributes
        {
            get { return this._exportAttributes; }
            set { this._exportAttributes = value; }
        }

        // Check to see if ExportAttributes property is set
        internal bool IsSetExportAttributes()
        {
            return this._exportAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ExportKeyIdentifier. 
        /// <para>
        /// The <code>KeyARN</code> of the key under export from Amazon Web Services Payment Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string ExportKeyIdentifier
        {
            get { return this._exportKeyIdentifier; }
            set { this._exportKeyIdentifier = value; }
        }

        // Check to see if ExportKeyIdentifier property is set
        internal bool IsSetExportKeyIdentifier()
        {
            return this._exportKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMaterial. 
        /// <para>
        /// The key block format type, for example, TR-34 or TR-31, to use during key material
        /// export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportKeyMaterial KeyMaterial
        {
            get { return this._keyMaterial; }
            set { this._keyMaterial = value; }
        }

        // Check to see if KeyMaterial property is set
        internal bool IsSetKeyMaterial()
        {
            return this._keyMaterial != null;
        }

    }
}