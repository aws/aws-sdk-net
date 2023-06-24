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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private CsrExtensions _csrExtensions;
        private KeyAlgorithm _keyAlgorithm;
        private SigningAlgorithm _signingAlgorithm;
        private ASN1Subject _subject;

        /// <summary>
        /// Gets and sets the property CsrExtensions. 
        /// <para>
        /// Specifies information to be added to the extension section of the certificate signing
        /// request (CSR).
        /// </para>
        /// </summary>
        public CsrExtensions CsrExtensions
        {
            get { return this._csrExtensions; }
            set { this._csrExtensions = value; }
        }

        // Check to see if CsrExtensions property is set
        internal bool IsSetCsrExtensions()
        {
            return this._csrExtensions != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// Type of the public key algorithm and size, in bits, of the key pair that your CA creates
        /// when it issues a certificate. When you create a subordinate CA, you must use a key
        /// algorithm supported by the parent CA.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAlgorithm KeyAlgorithm
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
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// Name of the algorithm your private CA uses to sign certificate requests.
        /// </para>
        ///  
        /// <para>
        /// This parameter should not be confused with the <code>SigningAlgorithm</code> parameter
        /// used to sign certificates when they are issued.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningAlgorithm SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// Structure that contains X.500 distinguished name information for your private CA.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ASN1Subject Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}