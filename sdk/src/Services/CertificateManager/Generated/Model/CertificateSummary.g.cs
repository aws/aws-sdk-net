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
    /// This structure is returned in the response object of <a>ListCertificates</a> action.
    /// </summary>
    public partial class CertificateSummary
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the certificate. This is of the form:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Fully qualified domain name (FQDN), such as www.example.com or example.com, for the
        /// certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ExportOption. 
        /// <para>
        /// Indicates if export is enabled for the certificate.
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
        /// Gets and sets the property ExtendedKeyUsages. 
        /// <para>
        /// Contains a list of Extended Key Usage X.509 v3 extension objects. Each object specifies
        /// a purpose for which the certificate public key can be used and consists of a name
        /// and an object identifier (OID). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExtendedKeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExtendedKeyUsages property is set.
        /// </summary>
        internal bool IsSetExtendedKeyUsages() => this.ExtendedKeyUsages != null && (this.ExtendedKeyUsages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HasAdditionalSubjectAlternativeNames. 
        /// <para>
        /// When called by <a href="https://docs.aws.amazon.com/acm/latest/APIReference/API_ListCertificates.html">ListCertificates</a>,
        /// indicates whether the full list of subject alternative names has been included in
        /// the response. If false, the response includes all of the subject alternative names
        /// included in the certificate. If true, the response only includes the first 100 subject
        /// alternative names included in the certificate. To display the full list of subject
        /// alternative names, use <a href="https://docs.aws.amazon.com/acm/latest/APIReference/API_DescribeCertificate.html">DescribeCertificate</a>.
        /// </para>
        /// </summary>
        public bool? HasAdditionalSubjectAlternativeNames { get; set; }

        /// <summary>
        /// Checks to see if the HasAdditionalSubjectAlternativeNames property is set.
        /// </summary>
        internal bool IsSetHasAdditionalSubjectAlternativeNames() => this.HasAdditionalSubjectAlternativeNames.HasValue;

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
        /// Indicates whether the certificate is currently in use by any Amazon Web Services resources.
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
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The algorithm that was used to generate the public-private key pair.
        /// </para>
        /// </summary>
        public KeyAlgorithm KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyUsages. 
        /// <para>
        /// A list of Key Usage X.509 v3 extension objects. Each object is a string value that
        /// identifies the purpose of the public key contained in the certificate. Possible extension
        /// values include DIGITAL_SIGNATURE, KEY_ENCHIPHERMENT, NON_REPUDIATION, and more.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the KeyUsages property is set.
        /// </summary>
        internal bool IsSetKeyUsages() => this.KeyUsages != null && (this.KeyUsages.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The time after which the certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotAfter property is set.
        /// </summary>
        internal bool IsSetNotAfter() => this.NotAfter.HasValue;

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The time before which the certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotBefore property is set.
        /// </summary>
        internal bool IsSetNotBefore() => this.NotBefore.HasValue;

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
        /// Gets and sets the property SubjectAlternativeNameSummaries. 
        /// <para>
        /// One or more domain names (subject alternative names) included in the certificate.
        /// This list contains the domain names that are bound to the public key that is contained
        /// in the certificate. The subject alternative names include the canonical domain name
        /// (CN) of the certificate and additional domain names that can be used to connect to
        /// the website. 
        /// </para>
        ///  
        /// <para>
        /// When called by <a href="https://docs.aws.amazon.com/acm/latest/APIReference/API_ListCertificates.html">ListCertificates</a>,
        /// this parameter will only return the first 100 subject alternative names included in
        /// the certificate. To display the full list of subject alternative names, use <a href="https://docs.aws.amazon.com/acm/latest/APIReference/API_DescribeCertificate.html">DescribeCertificate</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> SubjectAlternativeNameSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubjectAlternativeNameSummaries property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeNameSummaries() => this.SubjectAlternativeNameSummaries != null && (this.SubjectAlternativeNameSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

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
    }
}
