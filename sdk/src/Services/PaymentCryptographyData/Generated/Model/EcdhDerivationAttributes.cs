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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters required to establish ECDH based key exchange.
    /// </summary>
    public partial class EcdhDerivationAttributes
    {
        private string _certificateAuthorityPublicKeyIdentifier;
        private SymmetricKeyAlgorithm _keyAlgorithm;
        private KeyDerivationFunction _keyDerivationFunction;
        private KeyDerivationHashAlgorithm _keyDerivationHashAlgorithm;
        private string _publicKeyCertificate;
        private string _sharedInformation;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>keyArn</c> of the certificate that signed the client's <c>PublicKeyCertificate</c>.
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
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The key algorithm of the derived ECDH key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SymmetricKeyAlgorithm KeyAlgorithm
        {
            get { return this._keyAlgorithm; }
            set { this._keyAlgorithm = value; }
        }

        // Check to see if KeyAlgorithm property is set
        internal bool IsSetKeyAlgorithm()
        {
            return this._keyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyDerivationFunction. 
        /// <para>
        /// The key derivation function to use for deriving a key using ECDH.
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
        /// The hash type to use for deriving a key using ECDH.
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
        /// Gets and sets the property PublicKeyCertificate. 
        /// <para>
        /// The client's public key certificate in PEM format (base64 encoded) to use for ECDH
        /// key derivation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=32768)]
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

        /// <summary>
        /// Gets and sets the property SharedInformation. 
        /// <para>
        /// A byte string containing information that binds the ECDH derived key to the two parties
        /// involved or to the context of the key.
        /// </para>
        ///  
        /// <para>
        /// It may include details like identities of the two parties deriving the key, context
        /// of the operation, session IDs, and optionally a nonce. It must not contain zero bytes,
        /// and re-using shared information for multiple ECDH key derivations is not recommended.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2048)]
        public string SharedInformation
        {
            get { return this._sharedInformation; }
            set { this._sharedInformation = value; }
        }

        // Check to see if SharedInformation property is set
        internal bool IsSetSharedInformation()
        {
            return this._sharedInformation != null;
        }

    }
}