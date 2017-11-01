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
    /// Imports an SSL/TLS certificate into AWS Certificate Manager (ACM) to use with <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">ACM's
    /// integrated AWS services</a>.
    /// 
    ///  <note> 
    /// <para>
    /// ACM does not provide <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
    /// renewal</a> for certificates that you import.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about importing certificates into ACM, including the differences
    /// between certificates that you import and those that ACM provides, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">
    /// Importing Certificates</a> in the <i>AWS Certificate Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To import a certificate, you must provide the certificate and the matching private
    /// key. When the certificate is not self-signed, you must also provide a certificate
    /// chain. You can omit the certificate chain when importing a self-signed certificate.
    /// </para>
    ///  
    /// <para>
    /// The certificate, private key, and certificate chain must be PEM-encoded. For more
    /// information about converting these items to PEM format, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html#import-certificate-troubleshooting">Importing
    /// Certificates Troubleshooting</a> in the <i>AWS Certificate Manager User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To import a new certificate, omit the <code>CertificateArn</code> field. Include this
    /// field only when you want to replace a previously imported certificate.
    /// </para>
    ///  
    /// <para>
    /// When you import a certificate by using the CLI or one of the SDKs, you must specify
    /// the certificate, chain, and private key parameters as file names preceded by <code>file://</code>.
    /// For example, you can specify a certificate saved in the <code>C:\temp</code> folder
    /// as <code>C:\temp\certificate_to_import.pem</code>. If you are making an HTTP or HTTPS
    /// Query request, include these parameters as BLOBs. 
    /// </para>
    ///  
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
        /// The certificate to import. It must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain a 1024-bit or 2048-bit RSA public key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be valid at the time of import. You cannot import a certificate before its validity
        /// period begins (the certificate's <code>NotBefore</code> date) or after it expires
        /// (the certificate's <code>NotAfter</code> date).
        /// </para>
        ///  </li> </ul>
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
        /// The certificate chain. It must be PEM-encoded.
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
        /// The private key that matches the public key in the certificate. It must meet the following
        /// requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be unencrypted. You cannot import a private key that is protected by a password
        /// or passphrase.
        /// </para>
        ///  </li> </ul>
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