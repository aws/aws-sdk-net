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
    /// Container for the parameters to the ImportCertificateAuthorityCertificate operation.
    /// Imports a signed private CA certificate into Amazon Web Services Private CA. This
    /// action is used when you are using a chain of trust whose root is located outside Amazon
    /// Web Services Private CA. Before you can call this action, the following preparations
    /// must in place:
    /// 
    ///  <ol> <li> 
    /// <para>
    /// In Amazon Web Services Private CA, call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
    /// action to create the private CA that you plan to back with the imported certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificateAuthorityCsr.html">GetCertificateAuthorityCsr</a>
    /// action to generate a certificate signing request (CSR).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sign the CSR using a root or intermediate CA hosted by either an on-premises PKI hierarchy
    /// or by a commercial CA.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a certificate chain and copy the signed certificate and the certificate chain
    /// to your working directory.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// Amazon Web Services Private CA supports three scenarios for installing a CA certificate:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Installing a certificate for a root CA hosted by Amazon Web Services Private CA.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Installing a subordinate CA certificate whose parent authority is hosted by Amazon
    /// Web Services Private CA.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Installing a subordinate CA certificate whose parent authority is externally hosted.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following additional requirements apply when you import a CA certificate.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Only a self-signed certificate can be imported as a root CA.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A self-signed certificate cannot be imported as a subordinate CA.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your certificate chain must not include the private CA certificate that you are importing.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your root CA must be the last certificate in your chain. The subordinate certificate,
    /// if any, that your root CA signed must be next to last. The subordinate certificate
    /// signed by the preceding subordinate CA must come next, and so on until your chain
    /// is built. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The chain must be PEM-encoded.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum allowed size of a certificate is 32 KB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum allowed size of a certificate chain is 2 MB.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>Enforcement of Critical Constraints</i> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Private CA allows the following extensions to be marked critical
    /// in the imported CA certificate or chain.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Basic constraints (<i>must</i> be marked critical)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Subject alternative names
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Key usage
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Extended key usage
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Authority key identifier
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Subject key identifier
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Issuer alternative name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Subject directory attributes
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Subject information access
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Certificate policies
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Policy mappings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Inhibit anyPolicy
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon Web Services Private CA rejects the following extensions when they are marked
    /// critical in an imported CA certificate or chain.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Name constraints
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Policy constraints
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CRL distribution points
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Authority information access
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Freshest CRL
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any other extension
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ImportCertificateAuthorityCertificateRequest : AmazonACMPCARequest
    {
        private MemoryStream _certificate;
        private string _certificateAuthorityArn;
        private MemoryStream _certificateChain;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The PEM-encoded certificate for a private CA. This may be a self-signed certificate
        /// in the case of a root CA, or it may be signed by another CA that you control.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32768)]
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
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>.
        /// This must be of the form: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=200)]
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
        /// you're importing, chaining up to your root CA. Your Amazon Web Services Private CA-hosted
        /// or on-premises root certificate is the last in the chain, and each certificate in
        /// the chain signs the one preceding. 
        /// </para>
        ///  
        /// <para>
        /// This parameter must be supplied when you import a subordinate CA. When you import
        /// a root CA, there is no chain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2097152)]
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