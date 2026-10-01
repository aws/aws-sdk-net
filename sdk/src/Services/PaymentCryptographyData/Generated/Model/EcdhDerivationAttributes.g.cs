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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters required to establish ECDH based key exchange.
    /// </summary>
    public partial class EcdhDerivationAttributes
    {
        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>keyArn</c> of the certificate that signed the client's <c>PublicKeyCertificate</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string CertificateAuthorityPublicKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityPublicKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityPublicKeyIdentifier() => this.CertificateAuthorityPublicKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The key algorithm of the derived ECDH key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SymmetricKeyAlgorithm KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyDerivationFunction. 
        /// <para>
        /// The key derivation function to use for deriving a key using ECDH.
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
        /// The hash type to use for deriving a key using ECDH.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyDerivationHashAlgorithm KeyDerivationHashAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyDerivationHashAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyDerivationHashAlgorithm() => this.KeyDerivationHashAlgorithm != null;

        /// <summary>
        /// Gets and sets the property PublicKeyCertificate. 
        /// <para>
        /// The client's public key certificate in PEM format (base64 encoded) to use for ECDH
        /// key derivation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32768)]
        public string PublicKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the PublicKeyCertificate property is set.
        /// </summary>
        internal bool IsSetPublicKeyCertificate() => this.PublicKeyCertificate != null;

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
        [AWSProperty(Required = true, Min = 2, Max = 2048)]
        public string SharedInformation { get; set; }

        /// <summary>
        /// Checks to see if the SharedInformation property is set.
        /// </summary>
        internal bool IsSetSharedInformation() => this.SharedInformation != null;
    }
}
