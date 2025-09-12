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
    /// Parameter information for key material import using the asymmetric TR-34 key exchange
    /// method.
    /// </summary>
    public partial class ImportTr34KeyBlock
    {
        private string _certificateAuthorityPublicKeyIdentifier;
        private string _importToken;
        private Tr34KeyBlockFormat _keyBlockFormat;
        private string _randomNonce;
        private string _signingKeyCertificate;
        private string _wrappedKeyBlock;
        private string _wrappingKeyCertificate;
        private string _wrappingKeyIdentifier;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the certificate chain that signs the signing key certificate
        /// during TR-34 key import.
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
        /// Gets and sets the property ImportToken. 
        /// <para>
        /// The import token that initiates key import using the asymmetric TR-34 key exchange
        /// method into Amazon Web Services Payment Cryptography. It expires after 30 days. You
        /// can use the same import token to import multiple keys to the same service account.
        /// </para>
        /// </summary>
        public string ImportToken
        {
            get { return this._importToken; }
            set { this._importToken = value; }
        }

        // Check to see if ImportToken property is set
        internal bool IsSetImportToken()
        {
            return this._importToken != null;
        }

        /// <summary>
        /// Gets and sets the property KeyBlockFormat. 
        /// <para>
        /// The key block format to use during key import. The only value allowed is <c>X9_TR34_2012</c>.
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
        /// The public key component in PEM certificate format of the private key that signs the
        /// KDH TR-34 WrappedKeyBlock.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
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
        /// Gets and sets the property WrappedKeyBlock. 
        /// <para>
        /// The TR-34 wrapped key block to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=4096)]
        public string WrappedKeyBlock
        {
            get { return this._wrappedKeyBlock; }
            set { this._wrappedKeyBlock = value; }
        }

        // Check to see if WrappedKeyBlock property is set
        internal bool IsSetWrappedKeyBlock()
        {
            return this._wrappedKeyBlock != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyCertificate. 
        /// <para>
        /// Key Identifier used for unwrapping the import key
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
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

        /// <summary>
        /// Gets and sets the property WrappingKeyIdentifier. 
        /// <para>
        /// Key Identifier used for unwrapping the import key
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=322)]
        public string WrappingKeyIdentifier
        {
            get { return this._wrappingKeyIdentifier; }
            set { this._wrappingKeyIdentifier = value; }
        }

        // Check to see if WrappingKeyIdentifier property is set
        internal bool IsSetWrappingKeyIdentifier()
        {
            return this._wrappingKeyIdentifier != null;
        }

    }
}