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
    /// Exports a key from Amazon Web Services Payment Cryptography using either ANSI X9 TR-34
    /// or TR-31 key export standard.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography simplifies main or root key exchange process
    /// by eliminating the need of a paper-based key exchange process. It takes a modern and
    /// secure approach based of the ANSI X9 TR-34 key exchange standard.
    /// </para>
    ///  
    /// <para>
    /// You can use <code>ExportKey</code> to export main or root keys such as KEK (Key Encryption
    /// Key), using asymmetric key exchange technique following ANSI X9 TR-34 standard. The
    /// ANSI X9 TR-34 standard uses asymmetric keys to establishes bi-directional trust between
    /// the two parties exchanging keys. After which you can export working keys using the
    /// ANSI X9 TR-31 symmetric key exchange standard as mandated by PCI PIN. Using this operation,
    /// you can share your Amazon Web Services Payment Cryptography generated keys with other
    /// service partners to perform cryptographic operations outside of Amazon Web Services
    /// Payment Cryptography 
    /// </para>
    ///  
    /// <para>
    ///  <b>TR-34 key export</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography uses TR-34 asymmetric key exchange standard
    /// to export main keys such as KEK. In TR-34 terminology, the sending party of the key
    /// is called Key Distribution Host (KDH) and the receiving party of the key is called
    /// Key Receiving Host (KRH). In key export process, KDH is Amazon Web Services Payment
    /// Cryptography which initiates key export. KRH is the user receiving the key. Before
    /// you initiate TR-34 key export, you must obtain an export token by calling <a>GetParametersForExport</a>.
    /// This operation also returns the signing key certificate that KDH uses to sign the
    /// wrapped key to generate a TR-34 wrapped key block. The export token expires after
    /// 7 days.
    /// </para>
    ///  
    /// <para>
    /// Set the following parameters:
    /// </para>
    ///  <dl> <dt>CertificateAuthorityPublicKeyIdentifier</dt> <dd> 
    /// <para>
    /// The <code>KeyARN</code> of the certificate chain that will sign the wrapping key certificate.
    /// This must exist within Amazon Web Services Payment Cryptography before you initiate
    /// TR-34 key export. If it does not exist, you can import it by calling <a>ImportKey</a>
    /// for <code>RootCertificatePublicKey</code>.
    /// </para>
    ///  </dd> <dt>ExportToken</dt> <dd> 
    /// <para>
    /// Obtained from KDH by calling <a>GetParametersForExport</a>.
    /// </para>
    ///  </dd> <dt>WrappingKeyCertificate</dt> <dd> 
    /// <para>
    /// Amazon Web Services Payment Cryptography uses this to wrap the key under export.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// When this operation is successful, Amazon Web Services Payment Cryptography returns
    /// the TR-34 wrapped key block. 
    /// </para>
    ///  
    /// <para>
    ///  <b>TR-31 key export</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange standard
    /// to export working keys. In TR-31, you must use a main key such as KEK to encrypt or
    /// wrap the key under export. To establish a KEK, you can use <a>CreateKey</a> or <a>ImportKey</a>.
    /// When this operation is successful, Amazon Web Services Payment Cryptography returns
    /// a TR-31 wrapped key block. 
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
        private string _exportKeyIdentifier;
        private ExportKeyMaterial _keyMaterial;

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