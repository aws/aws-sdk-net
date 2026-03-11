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
    /// Parameter information for key material export using asymmetric RSA wrap and unwrap
    /// key exchange method.
    /// </summary>
    public partial class ExportKeyCryptogram
    {
        private string _certificateAuthorityPublicKeyIdentifier;
        private string _wrappingKeyCertificate;
        private WrappingKeySpec _wrappingSpec;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the certificate chain that signs the wrapping key certificate
        /// during RSA wrap and unwrap key export.
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
        /// Gets and sets the property WrappingKeyCertificate. 
        /// <para>
        /// The wrapping key certificate in PEM format (base64 encoded). Amazon Web Services Payment
        /// Cryptography uses this certificate to wrap the key under export.
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

        /// <summary>
        /// Gets and sets the property WrappingSpec. 
        /// <para>
        /// The wrapping spec for the key under export.
        /// </para>
        /// </summary>
        public WrappingKeySpec WrappingSpec
        {
            get { return this._wrappingSpec; }
            set { this._wrappingSpec = value; }
        }

        // Check to see if WrappingSpec property is set
        internal bool IsSetWrappingSpec()
        {
            return this._wrappingSpec != null;
        }

    }
}