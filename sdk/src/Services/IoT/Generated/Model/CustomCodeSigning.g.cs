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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes a custom method used to code sign a file.
    /// </summary>
    public partial class CustomCodeSigning
    {
        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The certificate chain.
        /// </para>
        /// </summary>
        public CodeSigningCertificateChain CertificateChain { get; set; }

        /// <summary>
        /// Checks to see if the CertificateChain property is set.
        /// </summary>
        internal bool IsSetCertificateChain() => this.CertificateChain != null;

        /// <summary>
        /// Gets and sets the property HashAlgorithm. 
        /// <para>
        /// The hash algorithm used to code sign the file. You can use a string as the algorithm
        /// name if the target over-the-air (OTA) update devices are able to verify the signature
        /// that was generated using the same signature algorithm. For example, FreeRTOS uses
        /// <c>SHA256</c> or <c>SHA1</c>, so you can pass either of them based on which was used
        /// for generating the signature.
        /// </para>
        /// </summary>
        public string HashAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the HashAlgorithm property is set.
        /// </summary>
        internal bool IsSetHashAlgorithm() => this.HashAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The signature for the file.
        /// </para>
        /// </summary>
        public CodeSigningSignature Signature { get; set; }

        /// <summary>
        /// Checks to see if the Signature property is set.
        /// </summary>
        internal bool IsSetSignature() => this.Signature != null;

        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        /// The signature algorithm used to code sign the file. You can use a string as the algorithm
        /// name if the target over-the-air (OTA) update devices are able to verify the signature
        /// that was generated using the same signature algorithm. For example, FreeRTOS uses
        /// <c>ECDSA</c> or <c>RSA</c>, so you can pass either of them based on which was used
        /// for generating the signature.
        /// </para>
        /// </summary>
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SignatureAlgorithm property is set.
        /// </summary>
        internal bool IsSetSignatureAlgorithm() => this.SignatureAlgorithm != null;
    }
}
