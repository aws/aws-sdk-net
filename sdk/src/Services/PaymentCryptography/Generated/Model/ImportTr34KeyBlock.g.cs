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
    /// Parameter information for key material import using the asymmetric TR-34 key exchange
    /// method.
    /// </summary>
    public partial class ImportTr34KeyBlock
    {
        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the certificate chain that signs the signing key certificate
        /// during TR-34 key import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string CertificateAuthorityPublicKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityPublicKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityPublicKeyIdentifier() => this.CertificateAuthorityPublicKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property ImportToken. 
        /// <para>
        /// The import token that initiates key import using the asymmetric TR-34 key exchange
        /// method into Amazon Web Services Payment Cryptography. It expires after 30 days. You
        /// can use the same import token to import multiple keys to the same service account.
        /// </para>
        /// </summary>
        public string ImportToken { get; set; }

        /// <summary>
        /// Checks to see if the ImportToken property is set.
        /// </summary>
        internal bool IsSetImportToken() => this.ImportToken != null;

        /// <summary>
        /// Gets and sets the property KeyBlockFormat. 
        /// <para>
        /// The key block format to use during key import. The only value allowed is <c>X9_TR34_2012</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Tr34KeyBlockFormat KeyBlockFormat { get; set; }

        /// <summary>
        /// Checks to see if the KeyBlockFormat property is set.
        /// </summary>
        internal bool IsSetKeyBlockFormat() => this.KeyBlockFormat != null;

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
        /// The public key component in PEM certificate format of the private key that signs the
        /// KDH TR-34 WrappedKeyBlock.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32768)]
        public string SigningKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyCertificate property is set.
        /// </summary>
        internal bool IsSetSigningKeyCertificate() => this.SigningKeyCertificate != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyBlock. 
        /// <para>
        /// The TR-34 wrapped key block to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 4096)]
        public string WrappedKeyBlock { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyBlock property is set.
        /// </summary>
        internal bool IsSetWrappedKeyBlock() => this.WrappedKeyBlock != null;

        /// <summary>
        /// Gets and sets the property WrappingKeyCertificate. 
        /// <para>
        /// The certificate used to wrap the TR-34 key block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string WrappingKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the WrappingKeyCertificate property is set.
        /// </summary>
        internal bool IsSetWrappingKeyCertificate() => this.WrappingKeyCertificate != null;

        /// <summary>
        /// Gets and sets the property WrappingKeyIdentifier. 
        /// <para>
        /// Key Identifier used for unwrapping the import key
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 322)]
        public string WrappingKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the WrappingKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetWrappingKeyIdentifier() => this.WrappingKeyIdentifier != null;
    }
}
