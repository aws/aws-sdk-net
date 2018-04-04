/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the IssueCertificate operation.
    /// Uses your private certificate authority (CA) to issue a client certificate. This function
    /// returns the Amazon Resource Name (ARN) of the certificate. You can retrieve the certificate
    /// by calling the <a>GetCertificate</a> function and specifying the ARN. 
    /// 
    ///  <note> 
    /// <para>
    /// You cannot use the ACM <b>ListCertificateAuthorities</b> function to retrieve the
    /// ARNs of the certificates that you issue by using ACM PCA.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class IssueCertificateRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private MemoryStream _csr;
        private string _idempotencyToken;
        private SigningAlgorithm _signingAlgorithm;
        private Validity _validity;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a>CreateCertificateAuthority</a>.
        /// This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code> 
        /// </para>
        /// </summary>
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property Csr. 
        /// <para>
        /// The certificate signing request (CSR) for the certificate you want to issue. You can
        /// use the following OpenSSL command to create the CSR and a 2048 bit RSA private key.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>openssl req -new -newkey rsa:2048 -days 365 -keyout private/test_cert_priv_key.pem
        /// -out csr/test_cert_.csr</code> 
        /// </para>
        ///  
        /// <para>
        /// If you have a configuration file, you can use the following OpenSSL command. The <code>usr_cert</code>
        /// block in the configuration file contains your X509 version 3 extensions. 
        /// </para>
        ///  
        /// <para>
        ///  <code>openssl req -new -config openssl_rsa.cnf -extensions usr_cert -newkey rsa:2048
        /// -days -365 -keyout private/test_cert_priv_key.pem -out csr/test_cert_.csr</code> 
        /// </para>
        /// </summary>
        public MemoryStream Csr
        {
            get { return this._csr; }
            set { this._csr = value; }
        }

        // Check to see if Csr property is set
        internal bool IsSetCsr()
        {
            return this._csr != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// Custom string that can be used to distinguish between calls to the <b>IssueCertificate</b>
        /// function. Idempotency tokens time out after one hour. Therefore, if you call <b>IssueCertificate</b>
        /// multiple times with the same idempotency token within 5 minutes, ACM PCA recognizes
        /// that you are requesting only one certificate and will issue only one. If you change
        /// the idempotency token for each call, PCA recognizes that you are requesting multiple
        /// certificates.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The name of the algorithm that will be used to sign the certificate to be issued.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Validity. 
        /// <para>
        /// The type of the validity period.
        /// </para>
        /// </summary>
        public Validity Validity
        {
            get { return this._validity; }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity != null;
        }

    }
}