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
    /// Parameter information for key material export using asymmetric RSA wrap and unwrap
    /// key exchange method.
    /// </summary>
    public partial class ExportKeyCryptogram
    {
        /// <summary>
        /// Gets and sets the property CertificateAuthorityPublicKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the certificate chain that signs the wrapping key certificate
        /// during RSA wrap and unwrap key export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string CertificateAuthorityPublicKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityPublicKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityPublicKeyIdentifier() => this.CertificateAuthorityPublicKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property WrappingKeyCertificate. 
        /// <para>
        /// The wrapping key certificate in PEM format (base64 encoded). Amazon Web Services Payment
        /// Cryptography uses this certificate to wrap the key under export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32768)]
        public string WrappingKeyCertificate { get; set; }

        /// <summary>
        /// Checks to see if the WrappingKeyCertificate property is set.
        /// </summary>
        internal bool IsSetWrappingKeyCertificate() => this.WrappingKeyCertificate != null;

        /// <summary>
        /// Gets and sets the property WrappingSpec. 
        /// <para>
        /// The wrapping spec for the key under export.
        /// </para>
        /// </summary>
        public WrappingKeySpec WrappingSpec { get; set; }

        /// <summary>
        /// Checks to see if the WrappingSpec property is set.
        /// </summary>
        internal bool IsSetWrappingSpec() => this.WrappingSpec != null;
    }
}
