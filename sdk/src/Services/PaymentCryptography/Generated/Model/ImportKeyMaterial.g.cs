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
    /// Parameter information for key material import into Amazon Web Services Payment Cryptography
    /// using TR-31 or TR-34 or RSA wrap and unwrap key exchange method.
    /// </summary>
    public partial class ImportKeyMaterial
    {
        /// <summary>
        /// Gets and sets the property As2805KeyCryptogram. 
        /// <para>
        /// Parameter information for key material import using AS2805 key cryptogram format.
        /// </para>
        /// </summary>
        public ImportAs2805KeyCryptogram As2805KeyCryptogram { get; set; }

        /// <summary>
        /// Checks to see if the As2805KeyCryptogram property is set.
        /// </summary>
        internal bool IsSetAs2805KeyCryptogram() => this.As2805KeyCryptogram != null;

        /// <summary>
        /// Gets and sets the property DiffieHellmanTr31KeyBlock. 
        /// <para>
        /// Key derivation parameter information for key material import using asymmetric ECDH
        /// key exchange method.
        /// </para>
        /// </summary>
        public ImportDiffieHellmanTr31KeyBlock DiffieHellmanTr31KeyBlock { get; set; }

        /// <summary>
        /// Checks to see if the DiffieHellmanTr31KeyBlock property is set.
        /// </summary>
        internal bool IsSetDiffieHellmanTr31KeyBlock() => this.DiffieHellmanTr31KeyBlock != null;

        /// <summary>
        /// Gets and sets the property KeyCryptogram. 
        /// <para>
        /// Parameter information for key material import using asymmetric RSA wrap and unwrap
        /// key exchange method.
        /// </para>
        /// </summary>
        public ImportKeyCryptogram KeyCryptogram { get; set; }

        /// <summary>
        /// Checks to see if the KeyCryptogram property is set.
        /// </summary>
        internal bool IsSetKeyCryptogram() => this.KeyCryptogram != null;

        /// <summary>
        /// Gets and sets the property RootCertificatePublicKey. 
        /// <para>
        /// Parameter information for root public key certificate import.
        /// </para>
        /// </summary>
        public RootCertificatePublicKey RootCertificatePublicKey { get; set; }

        /// <summary>
        /// Checks to see if the RootCertificatePublicKey property is set.
        /// </summary>
        internal bool IsSetRootCertificatePublicKey() => this.RootCertificatePublicKey != null;

        /// <summary>
        /// Gets and sets the property Tr31KeyBlock. 
        /// <para>
        /// Parameter information for key material import using symmetric TR-31 key exchange method.
        /// </para>
        /// </summary>
        public ImportTr31KeyBlock Tr31KeyBlock { get; set; }

        /// <summary>
        /// Checks to see if the Tr31KeyBlock property is set.
        /// </summary>
        internal bool IsSetTr31KeyBlock() => this.Tr31KeyBlock != null;

        /// <summary>
        /// Gets and sets the property Tr34KeyBlock. 
        /// <para>
        /// Parameter information for key material import using the asymmetric TR-34 key exchange
        /// method.
        /// </para>
        /// </summary>
        public ImportTr34KeyBlock Tr34KeyBlock { get; set; }

        /// <summary>
        /// Checks to see if the Tr34KeyBlock property is set.
        /// </summary>
        internal bool IsSetTr34KeyBlock() => this.Tr34KeyBlock != null;

        /// <summary>
        /// Gets and sets the property TrustedCertificatePublicKey. 
        /// <para>
        /// Parameter information for trusted public key certificate import.
        /// </para>
        /// </summary>
        public TrustedCertificatePublicKey TrustedCertificatePublicKey { get; set; }

        /// <summary>
        /// Checks to see if the TrustedCertificatePublicKey property is set.
        /// </summary>
        internal bool IsSetTrustedCertificatePublicKey() => this.TrustedCertificatePublicKey != null;
    }
}
