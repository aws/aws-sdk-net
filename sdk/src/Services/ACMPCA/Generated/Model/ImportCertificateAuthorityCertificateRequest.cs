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
    /// Container for the parameters to the ImportCertificateAuthorityCertificate operation.
    /// Imports your signed private CA certificate into ACM PCA. Before you can call this
    /// function, you must create the private certificate authority by calling the <a>CreateCertificateAuthority</a>
    /// function. You must then generate a certificate signing request (CSR) by calling the
    /// <a>GetCertificateAuthorityCsr</a> function. Take the CSR to your on-premises CA and
    /// use the root certificate or a subordinate certificate to sign it. Create a certificate
    /// chain and copy the signed certificate and the certificate chain to your working directory.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// Your certificate chain must not include the private CA certificate that you are importing.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Your on-premises CA certificate must be the last certificate in your chain. The subordinate
    /// certificate, if any, that your root CA signed must be next to last. The subordinate
    /// certificate signed by the preceding subordinate CA must come next, and so on until
    /// your chain is built. 
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// The chain must be PEM-encoded.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ImportCertificateAuthorityCertificateRequest : AmazonACMPCARequest
    {
        private MemoryStream _certificate;
        private string _certificateAuthorityArn;
        private MemoryStream _certificateChain;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The PEM-encoded certificate for your private CA. This must be signed by using your
        /// on-premises CA.
        /// </para>
        /// </summary>
        public MemoryStream Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

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
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// A PEM-encoded file that contains all of your certificates, other than the certificate
        /// you're importing, chaining up to your root CA. Your on-premises root certificate is
        /// the last in the chain, and each certificate in the chain signs the one preceding.
        /// 
        /// </para>
        /// </summary>
        public MemoryStream CertificateChain
        {
            get { return this._certificateChain; }
            set { this._certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this._certificateChain != null;
        }

    }
}