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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains configuration information for your private certificate authority (CA). This
    /// includes information about the class of public key algorithm and the key pair that
    /// your private CA creates when it issues a certificate. It also includes the signature
    /// algorithm that it uses when issuing certificates, and its X.500 distinguished name.
    /// You must specify this information when you call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
    /// action.
    /// </summary>
    public partial class CertificateAuthorityConfiguration
    {
        /// <summary>
        /// Gets and sets the property CsrExtensions. 
        /// <para>
        /// Specifies information to be added to the extension section of the certificate signing
        /// request (CSR).
        /// </para>
        /// </summary>
        public CsrExtensions CsrExtensions { get; set; }

        /// <summary>
        /// Checks to see if the CsrExtensions property is set.
        /// </summary>
        internal bool IsSetCsrExtensions() => this.CsrExtensions != null;

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// Type of the public key algorithm and size, in bits, of the key pair that your CA creates
        /// when it issues a certificate. When you create a subordinate CA, you must use a key
        /// algorithm supported by the parent CA.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyAlgorithm KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// Name of the algorithm your private CA uses to sign certificate requests.
        /// </para>
        ///  
        /// <para>
        /// This parameter should not be confused with the <c>SigningAlgorithm</c> parameter of
        /// the <c>IssueCertificate</c> API action, which is used to sign certificates when they
        /// are issued.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SigningAlgorithm SigningAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithm() => this.SigningAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// Structure that contains X.500 distinguished name information for your private CA.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ASN1Subject Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
