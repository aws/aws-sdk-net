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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the certificate chain that signs the wrapping key certificate
        /// during TR-34 key export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string CertificateAuthorityPublicKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityPublicKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityPublicKeyIdentifier() => this.CertificateAuthorityPublicKeyIdentifier != null;

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
        public string ExportToken { get; set; }

        /// <summary>
        /// Checks to see if the ExportToken property is set.
        /// </summary>
        internal bool IsSetExportToken() => this.ExportToken != null;

        /// <summary>
        /// Gets and sets the property KeyBlockFormat. 
        /// <para>
        /// The format of key block that Amazon Web Services Payment Cryptography will use during
        /// key export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Tr34KeyBlockFormat KeyBlockFormat { get; set; }

        /// <summary>
        /// Checks to see if the KeyBlockFormat property is set.
        /// </summary>
        internal bool IsSetKeyBlockFormat() => this.KeyBlockFormat != null;

        /// <summary>
        /// Gets and sets the property KeyBlockHeaders. 
        /// <para>
        /// Optional metadata for export associated with the key material. This data is signed
        /// but transmitted in clear text.
        /// </para>
        /// </summary>
        public KeyBlockHeaders KeyBlockHeaders { get; set; }

        /// <summary>
        /// Checks to see if the KeyBlockHeaders property is set.
        /// </summary>
        internal bool IsSetKeyBlockHeaders() => this.KeyBlockHeaders != null;

        /// <summary>
        /// Gets and sets the property RandomNonce. 
        /// <para>
        /// A random number value that is unique to the TR-34 key block generated using 2 pass.
        /// The operation will fail, if a random nonce value is not provided for a TR-34 key block
        /// generated using 2 pass.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 16, Max = 32)]
        public string RandomNonce { get; set; }

        /// <summary>
        /// Checks to see if the RandomNonce property is set.
        /// </summary>
        internal bool IsSetRandomNonce() => this.RandomNonce != null;

        /// <summary>
        /// Gets and sets the property SigningKeyCertificate. 
        /// <para>
        /// The certificate used to sign the TR-34 key block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string SigningKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyCertificate property is set.
        /// </summary>
        internal bool IsSetSigningKeyCertificate() => this.SigningKeyCertificate != null;

        /// <summary>
        /// Gets and sets the property SigningKeyIdentifier. 
        /// <para>
        /// Key Identifier used for signing the export key
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 322)]
        public string SigningKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetSigningKeyIdentifier() => this.SigningKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property WrappingKeyCertificate. 
        /// <para>
        /// The <c>KeyARN</c> of the wrapping key certificate. Amazon Web Services Payment Cryptography
        /// uses this certificate to wrap the key under export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32768)]
        public string WrappingKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the WrappingKeyCertificate property is set.
        /// </summary>
        internal bool IsSetWrappingKeyCertificate() => this.WrappingKeyCertificate != null;
    }
}
