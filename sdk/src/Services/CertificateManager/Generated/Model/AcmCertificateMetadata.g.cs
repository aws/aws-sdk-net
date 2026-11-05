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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains ACM-specific metadata about a certificate.
    /// </summary>
    public partial class AcmCertificateMetadata
    {
        /// <summary>
        /// Gets and sets the property AcmeAccountId. 
        /// <para>
        /// The ACME account identifier associated with the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AcmeAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AcmeAccountId property is set.
        /// </summary>
        internal bool IsSetAcmeAccountId() => this.AcmeAccountId != null;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The ARN of the ACME endpoint used to issue the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AcmeEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmeEndpointArn property is set.
        /// </summary>
        internal bool IsSetAcmeEndpointArn() => this.AcmeEndpointArn != null;

        /// <summary>
        /// Gets and sets the property CertificateKeyPairOrigin. 
        /// <para>
        /// The origin of the certificate's key pair.
        /// </para>
        /// </summary>
        public CertificateKeyPairOrigin CertificateKeyPairOrigin { get; set; }

        /// <summary>
        /// Checks to see if the CertificateKeyPairOrigin property is set.
        /// </summary>
        internal bool IsSetCertificateKeyPairOrigin() => this.CertificateKeyPairOrigin != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the certificate was requested.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExportOption. 
        /// <para>
        /// Indicates whether the certificate can be exported.
        /// </para>
        /// </summary>
        public CertificateExport ExportOption { get; set; }

        /// <summary>
        /// Checks to see if the ExportOption property is set.
        /// </summary>
        internal bool IsSetExportOption() => this.ExportOption != null;

        /// <summary>
        /// Gets and sets the property Exported. 
        /// <para>
        /// Indicates whether the certificate has been exported.
        /// </para>
        /// </summary>
        public bool? Exported { get; set; }

        /// <summary>
        /// Checks to see if the Exported property is set.
        /// </summary>
        internal bool IsSetExported() => this.Exported.HasValue;

        /// <summary>
        /// Gets and sets the property ImportedAt. 
        /// <para>
        /// The date and time when the certificate was imported. This value exists only when the
        /// certificate type is <c>IMPORTED</c>. 
        /// </para>
        /// </summary>
        public DateTime? ImportedAt { get; set; }

        /// <summary>
        /// Checks to see if the ImportedAt property is set.
        /// </summary>
        internal bool IsSetImportedAt() => this.ImportedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// Indicates whether the certificate is currently in use by an Amazon Web Services service.
        /// </para>
        /// </summary>
        public bool? InUse { get; set; }

        /// <summary>
        /// Checks to see if the InUse property is set.
        /// </summary>
        internal bool IsSetInUse() => this.InUse.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The time at which the certificate was issued. This value exists only when the certificate
        /// type is <c>AMAZON_ISSUED</c>. 
        /// </para>
        /// </summary>
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// Identifies the Amazon Web Services service that manages the certificate issued by
        /// ACM.
        /// </para>
        /// </summary>
        public CertificateManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property RenewalEligibility. 
        /// <para>
        /// Specifies whether the certificate is eligible for renewal. At this time, only exported
        /// private certificates can be renewed with the <a>RenewCertificate</a> command.
        /// </para>
        /// </summary>
        public RenewalEligibility RenewalEligibility { get; set; }

        /// <summary>
        /// Checks to see if the RenewalEligibility property is set.
        /// </summary>
        internal bool IsSetRenewalEligibility() => this.RenewalEligibility != null;

        /// <summary>
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// The renewal status of the certificate.
        /// </para>
        /// </summary>
        public RenewalStatus RenewalStatus { get; set; }

        /// <summary>
        /// Checks to see if the RenewalStatus property is set.
        /// </summary>
        internal bool IsSetRenewalStatus() => this.RenewalStatus != null;

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The time at which the certificate was revoked. This value exists only when the certificate
        /// status is <c>REVOKED</c>. 
        /// </para>
        /// </summary>
        public DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Checks to see if the RevokedAt property is set.
        /// </summary>
        internal bool IsSetRevokedAt() => this.RevokedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the certificate.
        /// </para>
        ///  
        /// <para>
        /// A certificate enters status PENDING_VALIDATION upon being requested, unless it fails
        /// for any of the reasons given in the troubleshooting topic <a href="https://docs.aws.amazon.com/acm/latest/userguide/troubleshooting-failed.html">Certificate
        /// request fails</a>. ACM makes repeated attempts to validate a certificate for 72 hours
        /// and then times out. If a certificate shows status FAILED or VALIDATION_TIMED_OUT,
        /// delete the request, correct the issue with <a href="https://docs.aws.amazon.com/acm/latest/userguide/dns-validation.html">DNS
        /// validation</a> or <a href="https://docs.aws.amazon.com/acm/latest/userguide/email-validation.html">Email
        /// validation</a>, and try again. If validation succeeds, the certificate enters status
        /// ISSUED. 
        /// </para>
        /// </summary>
        public CertificateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The source of the certificate. For certificates provided by ACM, this value is <c>AMAZON_ISSUED</c>.
        /// For certificates that you imported with <a>ImportCertificate</a>, this value is <c>IMPORTED</c>.
        /// ACM does not provide <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for imported certificates. For more information about the differences
        /// between certificates that you import and those that ACM provides, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>Certificate Manager User Guide</i>. 
        /// </para>
        /// </summary>
        public CertificateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// Specifies the domain validation method.
        /// </para>
        /// </summary>
        public ValidationMethod ValidationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMethod property is set.
        /// </summary>
        internal bool IsSetValidationMethod() => this.ValidationMethod != null;
    }
}
