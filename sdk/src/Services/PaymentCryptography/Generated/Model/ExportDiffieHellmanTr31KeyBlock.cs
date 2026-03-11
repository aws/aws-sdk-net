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
    /// Key derivation parameter information for key material export using asymmetric ECDH
    /// key exchange method.
    /// </summary>
    public partial class ExportDiffieHellmanTr31KeyBlock
    {
        private string _certificateAuthorityPublicKeyIdentifier;
        private DiffieHellmanDerivationData _derivationData;
        private SymmetricKeyAlgorithm _deriveKeyAlgorithm;
        private KeyBlockHeaders _keyBlockHeaders;
        private KeyDerivationFunction _keyDerivationFunction;
        private KeyDerivationHashAlgorithm _keyDerivationHashAlgorithm;
        private string _privateKeyIdentifier;
        private string _publicKeyCertificate;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the CA that signed the <c>PublicKeyCertificate</c> for the client's
        /// receiving ECC key pair.
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
        /// Gets and sets the property DerivationData. 
        /// <para>
        /// The shared information used when deriving a key using ECDH.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiffieHellmanDerivationData DerivationData
        {
            get { return this._derivationData; }
            set { this._derivationData = value; }
        }

        // Check to see if DerivationData property is set
        internal bool IsSetDerivationData()
        {
            return this._derivationData != null;
        }

        /// <summary>
        /// Gets and sets the property DeriveKeyAlgorithm. 
        /// <para>
        /// The key algorithm of the shared derived ECDH key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SymmetricKeyAlgorithm DeriveKeyAlgorithm
        {
            get { return this._deriveKeyAlgorithm; }
            set { this._deriveKeyAlgorithm = value; }
        }

        // Check to see if DeriveKeyAlgorithm property is set
        internal bool IsSetDeriveKeyAlgorithm()
        {
            return this._deriveKeyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyBlockHeaders.
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
        /// Gets and sets the property KeyDerivationFunction. 
        /// <para>
        /// The key derivation function to use when deriving a key using ECDH.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyDerivationFunction KeyDerivationFunction
        {
            get { return this._keyDerivationFunction; }
            set { this._keyDerivationFunction = value; }
        }

        // Check to see if KeyDerivationFunction property is set
        internal bool IsSetKeyDerivationFunction()
        {
            return this._keyDerivationFunction != null;
        }

        /// <summary>
        /// Gets and sets the property KeyDerivationHashAlgorithm. 
        /// <para>
        /// The hash type to use when deriving a key using ECDH.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyDerivationHashAlgorithm KeyDerivationHashAlgorithm
        {
            get { return this._keyDerivationHashAlgorithm; }
            set { this._keyDerivationHashAlgorithm = value; }
        }

        // Check to see if KeyDerivationHashAlgorithm property is set
        internal bool IsSetKeyDerivationHashAlgorithm()
        {
            return this._keyDerivationHashAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the asymmetric ECC key created within Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string PrivateKeyIdentifier
        {
            get { return this._privateKeyIdentifier; }
            set { this._privateKeyIdentifier = value; }
        }

        // Check to see if PrivateKeyIdentifier property is set
        internal bool IsSetPrivateKeyIdentifier()
        {
            return this._privateKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeyCertificate. 
        /// <para>
        /// The public key certificate of the client's receiving ECC key pair, in PEM format (base64
        /// encoded), to use for ECDH key derivation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
        public string PublicKeyCertificate
        {
            get { return this._publicKeyCertificate; }
            set { this._publicKeyCertificate = value; }
        }

        // Check to see if PublicKeyCertificate property is set
        internal bool IsSetPublicKeyCertificate()
        {
            return this._publicKeyCertificate != null;
        }

    }
}