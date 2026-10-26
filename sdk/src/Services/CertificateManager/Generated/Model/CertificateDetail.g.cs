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
    /// Contains metadata about an ACM certificate. This structure is returned in the response
    /// to a <a>DescribeCertificate</a> request.
    /// </summary>
    public partial class CertificateDetail
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
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate. For more information about ARNs,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the private certificate authority (CA) that issued
        /// the certificate. This has the following format: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

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
        /// The fully qualified domain name for the certificate, such as www.example.com or example.com.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// Contains information about the initial validation of each domain name that occurs
        /// as a result of the <a>RequestCertificate</a> request. This field exists only when
        /// the certificate type is <c>AMAZON_ISSUED</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public List<DomainValidation> DomainValidationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainValidation>() : null;

        /// <summary>
        /// Checks to see if the DomainValidationOptions property is set.
        /// </summary>
        internal bool IsSetDomainValidationOptions() => this.DomainValidationOptions != null && (this.DomainValidationOptions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public List<ExtendedKeyUsage> ExtendedKeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<ExtendedKeyUsage>() : null;

        /// <summary>
        /// Checks to see if the ExtendedKeyUsages property is set.
        /// </summary>
        internal bool IsSetExtendedKeyUsages() => this.ExtendedKeyUsages != null && (this.ExtendedKeyUsages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the certificate request failed. This value exists only when the certificate
        /// status is <c>FAILED</c>. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/troubleshooting.html#troubleshooting-failed">Certificate
        /// Request Failed</a> in the <i>Certificate Manager User Guide</i>. 
        /// </para>
        /// </summary>
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

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
        /// Gets and sets the property InUseBy. 
        /// <para>
        /// A list of ARNs for the Amazon Web Services resources that are using the certificate.
        /// A certificate can be used by multiple Amazon Web Services resources. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InUseBy { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InUseBy property is set.
        /// </summary>
        internal bool IsSetInUseBy() => this.InUseBy != null && (this.InUseBy.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The name of the certificate authority that issued and signed the certificate.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

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
        public List<KeyUsage> KeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<KeyUsage>() : null;

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
        /// Gets and sets the property Options. 
        /// <para>
        /// Contains the certificate options. Certificate transparency logging opt-out is no longer
        /// available. All public certificates are recorded in a certificate transparency log.
        /// </para>
        /// </summary>
        public CertificateOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

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
        /// Gets and sets the property RenewalSummary. 
        /// <para>
        /// Contains information about the status of ACM's <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for the certificate. This field exists only when the certificate type
        /// is <c>AMAZON_ISSUED</c>.
        /// </para>
        /// </summary>
        public RenewalSummary RenewalSummary { get; set; }

        /// <summary>
        /// Checks to see if the RenewalSummary property is set.
        /// </summary>
        internal bool IsSetRenewalSummary() => this.RenewalSummary != null;

        /// <summary>
        /// Gets and sets the property RevocationReason. 
        /// <para>
        /// The reason the certificate was revoked. This value exists only when the certificate
        /// status is <c>REVOKED</c>. 
        /// </para>
        /// </summary>
        public RevocationReason RevocationReason { get; set; }

        /// <summary>
        /// Checks to see if the RevocationReason property is set.
        /// </summary>
        internal bool IsSetRevocationReason() => this.RevocationReason != null;

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
        /// Gets and sets the property Serial. 
        /// <para>
        /// The serial number of the certificate.
        /// </para>
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Checks to see if the Serial property is set.
        /// </summary>
        internal bool IsSetSerial() => this.Serial != null;

        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        /// The algorithm that was used to sign the certificate.
        /// </para>
        /// </summary>
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SignatureAlgorithm property is set.
        /// </summary>
        internal bool IsSetSignatureAlgorithm() => this.SignatureAlgorithm != null;

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
        /// Gets and sets the property Subject. 
        /// <para>
        /// The name of the entity that is associated with the public key contained in the certificate.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// One or more domain names (subject alternative names) included in the certificate.
        /// This list contains the domain names that are bound to the public key that is contained
        /// in the certificate. The subject alternative names include the canonical domain name
        /// (CN) of the certificate and additional domain names that can be used to connect to
        /// the website. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> SubjectAlternativeNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubjectAlternativeNames property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeNames() => this.SubjectAlternativeNames != null && (this.SubjectAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property UpdateSummary. 
        /// <para>
        /// Contains information about the most recent update to the certificate. This field exists
        /// only when the certificate type is <c>AMAZON_ISSUED</c> and a certificate update has
        /// been requested.
        /// </para>
        /// </summary>
        public UpdateSummary UpdateSummary { get; set; }

        /// <summary>
        /// Checks to see if the UpdateSummary property is set.
        /// </summary>
        internal bool IsSetUpdateSummary() => this.UpdateSummary != null;
    }
}
