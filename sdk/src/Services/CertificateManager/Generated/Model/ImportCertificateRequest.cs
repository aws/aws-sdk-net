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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the ImportCertificate operation.
    /// Imports a certificate into AWS Certificate Manager (ACM) to use with services that
    /// are integrated with ACM. Note that <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">integrated
    /// services</a> allow only certificate types and keys they support to be associated with
    /// their resources. Further, their support differs depending on whether the certificate
    /// is imported into IAM or into ACM. For more information, see the documentation for
    /// each service. For more information about importing certificates into ACM, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
    /// Certificates</a> in the <i>AWS Certificate Manager User Guide</i>. 
    /// 
    ///  <note> 
    /// <para>
    /// ACM does not provide <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
    /// renewal</a> for certificates that you import.
    /// </para>
    ///  </note> 
    /// <para>
    /// Note the following guidelines when importing third party certificates:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must enter the private key that matches the certificate you are importing.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The private key must be unencrypted. You cannot import a private key that is protected
    /// by a password or a passphrase.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the certificate you are importing is not self-signed, you must enter its certificate
    /// chain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If a certificate chain is included, the issuer must be the subject of one of the certificates
    /// in the chain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The certificate, private key, and certificate chain must be PEM-encoded.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The current time must be between the <code>Not Before</code> and <code>Not After</code>
    /// certificate fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Issuer</code> field must not be empty.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The OCSP authority URL, if present, must not exceed 1000 characters.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To import a new certificate, omit the <code>CertificateArn</code> argument. Include
    /// this argument only when you want to replace a previously imported certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you import a certificate by using the CLI, you must specify the certificate,
    /// the certificate chain, and the private key by their file names preceded by <code>file://</code>.
    /// For example, you can specify a certificate saved in the <code>C:\temp</code> folder
    /// as <code>file://C:\temp\certificate_to_import.pem</code>. If you are making an HTTP
    /// or HTTPS Query request, include these arguments as BLOBs. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you import a certificate by using an SDK, you must specify the certificate, the
    /// certificate chain, and the private key files in the manner required by the programming
    /// language you're using. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation returns the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
    /// Resource Name (ARN)</a> of the imported certificate.
    /// </para>
    /// </summary>
    public partial class ImportCertificateRequest : AmazonCertificateManagerRequest
    {
        private MemoryStream _certificate;
        private string _certificateArn;
        private MemoryStream _certificateChain;
        private MemoryStream _privateKey;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The certificate to import.
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
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of an imported certificate to replace. To import a new certificate,
        /// omit this field. 
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The PEM encoded certificate chain.
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

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The private key that matches the public key in the certificate.
        /// </para>
        /// </summary>
        public MemoryStream PrivateKey
        {
            get { return this._privateKey; }
            set { this._privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

    }
}