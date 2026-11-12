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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateCertificateAuthorityAuditReport operation.
    /// Creates an audit report that lists every time that your CA private key is used to
    /// issue a certificate. The <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_IssueCertificate.html">IssueCertificate</a>
    /// and <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_RevokeCertificate.html">RevokeCertificate</a>
    /// actions use the private key. <para> To save the audit report to your designated Amazon
    /// S3 bucket, you must create a bucket policy that grants Amazon Web Services Private
    /// CA permission to access and write to it. For an example policy, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaAuditReport.html#s3-access">Prepare
    /// an Amazon S3 bucket for audit reports</a>. </para> <para> Amazon Web Services Private
    /// CA assets that are stored in Amazon S3 can be protected with encryption. For more
    /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaAuditReport.html#audit-report-encryption">Encrypting
    /// Your Audit Reports</a>. </para> <note> <para> You can generate a maximum of one report
    /// every 30 minutes. </para> </note>
    /// </summary>
    public partial class CreateCertificateAuthorityAuditReportRequest : AmazonACMPCARequest
    {
        /// <summary>
        /// Gets and sets the property AuditReportResponseFormat. 
        /// <para>
        /// The format in which to create the report. This can be either <b>JSON</b> or <b>CSV</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuditReportResponseFormat AuditReportResponseFormat { get; set; }

        /// <summary>
        /// Checks to see if the AuditReportResponseFormat property is set.
        /// </summary>
        internal bool IsSetAuditReportResponseFormat() => this.AuditReportResponseFormat != null;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the CA to be audited. This is of the form:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 200)]
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket that will contain the audit report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;
    }
}
