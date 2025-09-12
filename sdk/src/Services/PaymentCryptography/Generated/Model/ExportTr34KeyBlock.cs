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
    /// Parameter information for key material export using the asymmetric TR-34 key exchange
    /// method.
    /// </summary>
    public partial class ExportTr34KeyBlock
    {
        private string _certificateAuthorityPublicKeyIdentifier;
        private string _exportToken;
        private Tr34KeyBlockFormat _keyBlockFormat;
        private KeyBlockHeaders _keyBlockHeaders;
        private string _randomNonce;
        private string _signingKeyCertificate;
        private string _signingKeyIdentifier;
        private string _wrappingKeyCertificate;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the certificate chain that signs the wrapping key certificate
        /// during TR-34 key export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string CertificateAuthorityPublicKeyIdentifier
        {
            get { return this._certificateAuthorityPublicKeyIdentifier; }
            set { this._certificateAuthorityPublicKeyIdentifier = value; }
        }

        // Check to see if CertificateAuthorityPublicKeyIdentifier property is set
        internal bool IsSetCertificateAuthorityPublicKeyIdentifier()
        {
            return this._certificateAuthorityPublicKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToken. 
        /// <para>
        /// The export token to initiate key export from Amazon Web Services Payment Cryptography.
        /// It also contains the signing key certificate that will sign the wrapped key during
        /// TR-34 key block generation. Call <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForExport.html">GetParametersForExport</a>
        /// to receive an export token. It expires after 30 days. You can use the same export
        /// token to export multiple keys from the same service account.
        /// </para>
        /// </summary>
        public string ExportToken
        {
            get { return this._exportToken; }
            set { this._exportToken = value; }
        }

        // Check to see if ExportToken property is set
        internal bool IsSetExportToken()
        {
            return this._exportToken != null;
        }

        /// <summary>
        /// Gets and sets the property KeyBlockFormat. 
        /// <para>
        /// The format of key block that Amazon Web Services Payment Cryptography will use during
        /// key export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Tr34KeyBlockFormat KeyBlockFormat
        {
            get { return this._keyBlockFormat; }
            set { this._keyBlockFormat = value; }
        }

        // Check to see if KeyBlockFormat property is set
        internal bool IsSetKeyBlockFormat()
        {
            return this._keyBlockFormat != null;
        }

        /// <summary>
        /// Gets and sets the property KeyBlockHeaders. 
        /// <para>
        /// Optional metadata for export associated with the key material. This data is signed
        /// but transmitted in clear text.
        /// </para>
        /// </summary>
        public KeyBlockHeaders KeyBlockHeaders
        {
            get { return this._keyBlockHeaders; }
            set { this._keyBlockHeaders = value; }
        }

        // Check to see if KeyBlockHeaders property is set
        internal bool IsSetKeyBlockHeaders()
        {
            return this._keyBlockHeaders != null;
        }

        /// <summary>
        /// Gets and sets the property RandomNonce. 
        /// <para>
        /// A random number value that is unique to the TR-34 key block generated using 2 pass.
        /// The operation will fail, if a random nonce value is not provided for a TR-34 key block
        /// generated using 2 pass.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=32)]
        public string RandomNonce
        {
            get { return this._randomNonce; }
            set { this._randomNonce = value; }
        }

        // Check to see if RandomNonce property is set
        internal bool IsSetRandomNonce()
        {
            return this._randomNonce != null;
        }

        /// <summary>
        /// Gets and sets the property SigningKeyCertificate. 
        /// <para>
        /// Certificate used for signing the export key
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
        public string SigningKeyCertificate
        {
            get { return this._signingKeyCertificate; }
            set { this._signingKeyCertificate = value; }
        }

        // Check to see if SigningKeyCertificate property is set
        internal bool IsSetSigningKeyCertificate()
        {
            return this._signingKeyCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property SigningKeyIdentifier. 
        /// <para>
        /// Key Identifier used for signing the export key
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=322)]
        public string SigningKeyIdentifier
        {
            get { return this._signingKeyIdentifier; }
            set { this._signingKeyIdentifier = value; }
        }

        // Check to see if SigningKeyIdentifier property is set
        internal bool IsSetSigningKeyIdentifier()
        {
            return this._signingKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyCertificate. 
        /// <para>
        /// The <c>KeyARN</c> of the wrapping key certificate. Amazon Web Services Payment Cryptography
        /// uses this certificate to wrap the key under export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
        public string WrappingKeyCertificate
        {
            get { return this._wrappingKeyCertificate; }
            set { this._wrappingKeyCertificate = value; }
        }

        // Check to see if WrappingKeyCertificate property is set
        internal bool IsSetWrappingKeyCertificate()
        {
            return this._wrappingKeyCertificate != null;
        }

    }
}