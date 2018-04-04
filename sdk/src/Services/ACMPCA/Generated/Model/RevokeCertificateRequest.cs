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
    /// Container for the parameters to the RevokeCertificate operation.
    /// Revokes a certificate that you issued by calling the <a>IssueCertificate</a> function.
    /// If you enable a certificate revocation list (CRL) when you create or update your private
    /// CA, information about the revoked certificates will be included in the CRL. ACM PCA
    /// writes the CRL to an S3 bucket that you specify. For more information about revocation,
    /// see the <a>CrlConfiguration</a> structure. ACM PCA also writes revocation information
    /// to the audit report. For more information, see <a>CreateCertificateAuthorityAuditReport</a>.
    /// </summary>
    public partial class RevokeCertificateRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private string _certificateSerial;
        private RevocationReason _revocationReason;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the private CA that issued the certificate to be revoked.
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
        /// Gets and sets the property CertificateSerial. 
        /// <para>
        /// Serial number of the certificate to be revoked. This must be in hexadecimal format.
        /// You can retrieve the serial number by calling <a>GetCertificate</a> with the Amazon
        /// Resource Name (ARN) of the certificate you want and the ARN of your private CA. The
        /// <b>GetCertificate</b> function retrieves the certificate in the PEM format. You can
        /// use the following OpenSSL command to list the certificate in text format and copy
        /// the hexadecimal serial number. 
        /// </para>
        ///  
        /// <para>
        ///  <code>openssl x509 -in <i>file_path</i> -text -noout</code> 
        /// </para>
        ///  
        /// <para>
        /// You can also copy the serial number from the console or use the <a href="http://docs.aws.amazon.comacm/latest/APIReferenceAPI_DescribeCertificate.html">DescribeCertificate</a>
        /// function in the <i>AWS Certificate Manager API Reference</i>. 
        /// </para>
        /// </summary>
        public string CertificateSerial
        {
            get { return this._certificateSerial; }
            set { this._certificateSerial = value; }
        }

        // Check to see if CertificateSerial property is set
        internal bool IsSetCertificateSerial()
        {
            return this._certificateSerial != null;
        }

        /// <summary>
        /// Gets and sets the property RevocationReason. 
        /// <para>
        /// Specifies why you revoked the certificate.
        /// </para>
        /// </summary>
        public RevocationReason RevocationReason
        {
            get { return this._revocationReason; }
            set { this._revocationReason = value; }
        }

        // Check to see if RevocationReason property is set
        internal bool IsSetRevocationReason()
        {
            return this._revocationReason != null;
        }

    }
}