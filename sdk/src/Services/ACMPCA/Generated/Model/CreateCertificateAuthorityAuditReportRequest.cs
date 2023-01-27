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
    /// Container for the parameters to the CreateCertificateAuthorityAuditReport operation.
    /// Creates an audit report that lists every time that your CA private key is used. The
    /// report is saved in the Amazon S3 bucket that you specify on input. The <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_IssueCertificate.html">IssueCertificate</a>
    /// and <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_RevokeCertificate.html">RevokeCertificate</a>
    /// actions use the private key. 
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
    /// Amazon Web Services Private CA assets that are stored in Amazon S3 can be protected
    /// with encryption. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaAuditReport.html#audit-report-encryption">Encrypting
    /// Your Audit Reports</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can generate a maximum of one report every 30 minutes.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateCertificateAuthorityAuditReportRequest : AmazonACMPCARequest
    {
        private AuditReportResponseFormat _auditReportResponseFormat;
        private string _certificateAuthorityArn;
        private string _s3BucketName;

        /// <summary>
        /// Gets and sets the property AuditReportResponseFormat. 
        /// <para>
        /// The format in which to create the report. This can be either <b>JSON</b> or <b>CSV</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuditReportResponseFormat AuditReportResponseFormat
        {
            get { return this._auditReportResponseFormat; }
            set { this._auditReportResponseFormat = value; }
        }

        // Check to see if AuditReportResponseFormat property is set
        internal bool IsSetAuditReportResponseFormat()
        {
            return this._auditReportResponseFormat != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CA to be audited. This is of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code>.
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
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket that will contain the audit report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

    }
}