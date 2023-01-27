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
    /// Container for the parameters to the RevokeCertificate operation.
    /// Revokes a certificate that was issued inside Amazon Web Services Private CA. If you
    /// enable a certificate revocation list (CRL) when you create or update your private
    /// CA, information about the revoked certificates will be included in the CRL. Amazon
    /// Web Services Private CA writes the CRL to an S3 bucket that you specify. A CRL is
    /// typically updated approximately 30 minutes after a certificate is revoked. If for
    /// any reason the CRL update fails, Amazon Web Services Private CA attempts makes further
    /// attempts every 15 minutes. With Amazon CloudWatch, you can create alarms for the metrics
    /// <code>CRLGenerated</code> and <code>MisconfiguredCRLBucket</code>. For more information,
    /// see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaCloudWatch.html">Supported
    /// CloudWatch Metrics</a>.
    /// 
    ///  <note> 
    /// <para>
    /// Both Amazon Web Services Private CA and the IAM principal must have permission to
    /// write to the S3 bucket that you specify. If the IAM principal making the call does
    /// not have permission to write to the bucket, then an exception is thrown. For more
    /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#s3-policies">Access
    /// policies for CRLs in Amazon S3</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Web Services Private CA also writes revocation information to the audit report.
    /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthorityAuditReport.html">CreateCertificateAuthorityAuditReport</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You cannot revoke a root CA self-signed certificate.
    /// </para>
    ///  </note>
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
        /// Gets and sets the property CertificateSerial. 
        /// <para>
        /// Serial number of the certificate to be revoked. This must be in hexadecimal format.
        /// You can retrieve the serial number by calling <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificate.html">GetCertificate</a>
        /// with the Amazon Resource Name (ARN) of the certificate you want and the ARN of your
        /// private CA. The <b>GetCertificate</b> action retrieves the certificate in the PEM
        /// format. You can use the following OpenSSL command to list the certificate in text
        /// format and copy the hexadecimal serial number. 
        /// </para>
        ///  
        /// <para>
        ///  <code>openssl x509 -in <i>file_path</i> -text -noout</code> 
        /// </para>
        ///  
        /// <para>
        /// You can also copy the serial number from the console or use the <a href="https://docs.aws.amazon.com/acm/latest/APIReference/API_DescribeCertificate.html">DescribeCertificate</a>
        /// action in the <i>Certificate Manager API Reference</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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
        [AWSProperty(Required=true)]
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