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
    /// Key derivation parameter information for key material import using asymmetric ECDH
    /// key exchange method.
    /// </summary>
    public partial class ImportDiffieHellmanTr31KeyBlock
    {
        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the CA that signed the <c>PublicKeyCertificate</c> for the client's
        /// receiving ECC key pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string CertificateAuthorityPublicKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityPublicKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityPublicKeyIdentifier() => this.CertificateAuthorityPublicKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property DerivationData. 
        /// <para>
        /// The shared information used when deriving a key using ECDH.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DiffieHellmanDerivationData DerivationData { get; set; }

        /// <summary>
        /// Checks to see if the DerivationData property is set.
        /// </summary>
        internal bool IsSetDerivationData() => this.DerivationData != null;

        /// <summary>
        /// Gets and sets the property DeriveKeyAlgorithm. 
        /// <para>
        /// The key algorithm of the shared derived ECDH key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SymmetricKeyAlgorithm DeriveKeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the DeriveKeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetDeriveKeyAlgorithm() => this.DeriveKeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyDerivationFunction. 
        /// <para>
        /// The key derivation function to use when deriving a key using ECDH.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyDerivationFunction KeyDerivationFunction { get; set; }

        /// <summary>
        /// Checks to see if the KeyDerivationFunction property is set.
        /// </summary>
        internal bool IsSetKeyDerivationFunction() => this.KeyDerivationFunction != null;

        /// <summary>
        /// Gets and sets the property KeyDerivationHashAlgorithm. 
        /// <para>
        /// The hash type to use when deriving a key using ECDH.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyDerivationHashAlgorithm KeyDerivationHashAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyDerivationHashAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyDerivationHashAlgorithm() => this.KeyDerivationHashAlgorithm != null;

        /// <summary>
        /// Gets and sets the property PrivateKeyIdentifier. 
        /// <para>
        /// The <c>keyARN</c> of the asymmetric ECC key created within Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string PrivateKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetPrivateKeyIdentifier() => this.PrivateKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property PublicKeyCertificate. 
        /// <para>
        /// The public key certificate of the client's receiving ECC key pair, in PEM format (base64
        /// encoded), to use for ECDH key derivation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32768)]
        public string PublicKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the PublicKeyCertificate property is set.
        /// </summary>
        internal bool IsSetPublicKeyCertificate() => this.PublicKeyCertificate != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyBlock. 
        /// <para>
        /// The ECDH wrapped key block to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 56, Max = 9984)]
        public string WrappedKeyBlock { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyBlock property is set.
        /// </summary>
        internal bool IsSetWrappedKeyBlock() => this.WrappedKeyBlock != null;
    }
}
