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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCertificateAuthority operation.
    /// Updates the status or configuration of a private certificate authority (CA). Your
    /// private CA must be in the <c>ACTIVE</c> or <c>DISABLED</c> state before you can update
    /// it. You can disable a private CA that is in the <c>ACTIVE</c> state or make a CA that
    /// is in the <c>DISABLED</c> state active again.
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
    /// </summary>
    public partial class UpdateCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private RevocationConfiguration _revocationConfiguration;
        private CertificateAuthorityStatus _status;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the private CA that issued the certificate to be revoked.
        /// This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </c> 
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
        /// Gets and sets the property RevocationConfiguration. 
        /// <para>
        /// Contains information to enable support for Online Certificate Status Protocol (OCSP),
        /// certificate revocation list (CRL), both protocols, or neither. If you don't supply
        /// this parameter, existing capibilites remain unchanged. For more information, see the
        /// <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_OcspConfiguration.html">OcspConfiguration</a>
        /// and <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CrlConfiguration.html">CrlConfiguration</a>
        /// types.
        /// </para>
        ///  
        /// <para>
        /// The following requirements apply to revocation configurations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A configuration disabling CRLs or OCSP must contain only the <c>Enabled=False</c>
        /// parameter, and will fail if other parameters such as <c>CustomCname</c> or <c>ExpirationInDays</c>
        /// are included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In a CRL configuration, the <c>S3BucketName</c> parameter must conform to <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html">Amazon
        /// S3 bucket naming rules</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A configuration containing a custom Canonical Name (CNAME) parameter for CRLs or OCSP
        /// must conform to <a href="https://www.ietf.org/rfc/rfc2396.txt">RFC2396</a> restrictions
        /// on the use of special characters in a CNAME. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In a CRL or OCSP configuration, the value of a CNAME parameter must not include a
        /// protocol prefix such as "http://" or "https://".
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        ///  If you update the <c>S3BucketName</c> of <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CrlConfiguration.html">CrlConfiguration</a>,
        /// you can break revocation for existing certificates. In other words, if you call <a
        /// href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UpdateCertificateAuthority.html">UpdateCertificateAuthority</a>
        /// to update the CRL configuration's S3 bucket name, Amazon Web Services Private CA only
        /// writes CRLs to the new S3 bucket. Certificates issued prior to this point will have
        /// the old S3 bucket name in your CRL Distribution Point (CDP) extension, essentially
        /// breaking revocation. If you must update the S3 bucket, you'll need to reissue old
        /// certificates to keep the revocation working. Alternatively, you can use a <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CrlConfiguration.html#privateca-Type-CrlConfiguration-CustomCname">CustomCname</a>
        /// in your CRL configuration if you might need to change the S3 bucket name in the future.
        /// </para>
        ///  </important>
        /// </summary>
        public RevocationConfiguration RevocationConfiguration
        {
            get { return this._revocationConfiguration; }
            set { this._revocationConfiguration = value; }
        }

        // Check to see if RevocationConfiguration property is set
        internal bool IsSetRevocationConfiguration()
        {
            return this._revocationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of your private CA.
        /// </para>
        /// </summary>
        public CertificateAuthorityStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}