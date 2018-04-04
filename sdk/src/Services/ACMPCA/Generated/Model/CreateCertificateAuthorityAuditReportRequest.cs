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
    /// Container for the parameters to the CreateCertificateAuthorityAuditReport operation.
    /// Creates an audit report that lists every time that the your CA private key is used.
    /// The report is saved in the Amazon S3 bucket that you specify on input. The <a>IssueCertificate</a>
    /// and <a>RevokeCertificate</a> functions use the private key. You can generate a new
    /// report every 30 minutes.
    /// </summary>
    public partial class CreateCertificateAuthorityAuditReportRequest : AmazonACMPCARequest
    {
        private AuditReportResponseFormat _auditReportResponseFormat;
        private string _certificateAuthorityArn;
        private string _s3BucketName;

        /// <summary>
        /// Gets and sets the property AuditReportResponseFormat. 
        /// <para>
        /// Format in which to create the report. This can be either <b>JSON</b> or <b>CSV</b>.
        /// </para>
        /// </summary>
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
        /// Amazon Resource Name (ARN) of the CA to be audited. This is of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code>.
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
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// Name of the S3 bucket that will contain the audit report.
        /// </para>
        /// </summary>
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