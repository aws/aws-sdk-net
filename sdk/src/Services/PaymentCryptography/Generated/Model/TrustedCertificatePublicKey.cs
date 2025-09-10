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
    /// Parameter information for trusted public key certificate import.
    /// </summary>
    public partial class TrustedCertificatePublicKey
    {
        private string _certificateAuthorityPublicKeyIdentifier;
        private KeyAttributes _keyAttributes;
        private string _publicKeyCertificate;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the root public key certificate or certificate chain that signs
        /// the trusted public key certificate import.
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
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The role of the key, the algorithm it supports, and the cryptographic operations allowed
        /// with the key. This data is immutable after a trusted public key is imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAttributes KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeyCertificate. 
        /// <para>
        /// Parameter information for trusted public key certificate import.
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