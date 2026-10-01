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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Certificate Manager certificate.
    /// </summary>
    public partial class AwsCertificateManagerCertificateDetails
    {
        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The ARN of the private certificate authority (CA) that will be used to issue the certificate.
        /// </para>
        /// </summary>
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates when the certificate was requested.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The fully qualified domain name (FQDN), such as www.example.com, that is secured by
        /// the certificate.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// Contains information about the initial validation of each domain name that occurs
        /// as a result of the <c>RequestCertificate</c> request.
        /// </para>
        ///  
        /// <para>
        /// Only provided if the certificate type is <c>AMAZON_ISSUED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCertificateManagerCertificateDomainValidationOption> DomainValidationOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCertificateManagerCertificateDomainValidationOption>() : null;

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
        public List<AwsCertificateManagerCertificateExtendedKeyUsage> ExtendedKeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCertificateManagerCertificateExtendedKeyUsage>() : null;

        /// <summary>
        /// Checks to see if the ExtendedKeyUsages property is set.
        /// </summary>
        internal bool IsSetExtendedKeyUsages() => this.ExtendedKeyUsages != null && (this.ExtendedKeyUsages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// For a failed certificate request, the reason for the failure.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>NO_AVAILABLE_CONTACTS</c> | <c>ADDITIONAL_VERIFICATION_REQUIRED</c>
        /// | <c>DOMAIN_NOT_ALLOWED</c> | <c>INVALID_PUBLIC_DOMAIN</c> | <c>DOMAIN_VALIDATION_DENIED</c>
        /// | <c>CAA_ERROR</c> | <c>PCA_LIMIT_EXCEEDED</c> | <c>PCA_INVALID_ARN</c> | <c>PCA_INVALID_STATE</c>
        /// | <c>PCA_REQUEST_FAILED</c> | <c>PCA_NAME_CONSTRAINTS_VALIDATION</c> | <c>PCA_RESOURCE_NOT_FOUND</c>
        /// | <c>PCA_INVALID_ARGS</c> | <c>PCA_INVALID_DURATION</c> | <c>PCA_ACCESS_DENIED</c>
        /// | <c>SLR_NOT_FOUND</c> | <c>OTHER</c> 
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property ImportedAt. 
        /// <para>
        /// Indicates when the certificate was imported. Provided if the certificate type is <c>IMPORTED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ImportedAt { get; set; }

        /// <summary>
        /// Checks to see if the ImportedAt property is set.
        /// </summary>
        internal bool IsSetImportedAt() => this.ImportedAt != null;

        /// <summary>
        /// Gets and sets the property InUseBy. 
        /// <para>
        /// The list of ARNs for the Amazon Web Services resources that use the certificate.
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
        /// Indicates when the certificate was issued. Provided if the certificate type is <c>AMAZON_ISSUED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt != null;

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
        ///  
        /// <para>
        /// Valid values: <c>RSA_2048</c> | <c>RSA_1024</c> |<c> RSA_4096</c> | <c>EC_prime256v1</c>
        /// | <c>EC_secp384r1</c> | <c>EC_secp521r1</c> 
        /// </para>
        /// </summary>
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyUsages. 
        /// <para>
        /// A list of key usage X.509 v3 extension objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCertificateManagerCertificateKeyUsage> KeyUsages { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsCertificateManagerCertificateKeyUsage>() : null;

        /// <summary>
        /// Checks to see if the KeyUsages property is set.
        /// </summary>
        internal bool IsSetKeyUsages() => this.KeyUsages != null && (this.KeyUsages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The time after which the certificate becomes invalid.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string NotAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotAfter property is set.
        /// </summary>
        internal bool IsSetNotAfter() => this.NotAfter != null;

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The time before which the certificate is not valid.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string NotBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotBefore property is set.
        /// </summary>
        internal bool IsSetNotBefore() => this.NotBefore != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Provides a value that specifies whether to add the certificate to a transparency log.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property RenewalEligibility. 
        /// <para>
        /// Whether the certificate is eligible for renewal.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ELIGIBLE</c> | <c>INELIGIBLE</c> 
        /// </para>
        /// </summary>
        public string RenewalEligibility { get; set; }

        /// <summary>
        /// Checks to see if the RenewalEligibility property is set.
        /// </summary>
        internal bool IsSetRenewalEligibility() => this.RenewalEligibility != null;

        /// <summary>
        /// Gets and sets the property RenewalSummary. 
        /// <para>
        /// Information about the status of the Certificate Manager managed renewal for the certificate.
        /// Provided only when the certificate type is <c>AMAZON_ISSUED</c>.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateRenewalSummary RenewalSummary { get; set; }

        /// <summary>
        /// Checks to see if the RenewalSummary property is set.
        /// </summary>
        internal bool IsSetRenewalSummary() => this.RenewalSummary != null;

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
        /// Valid values: <c>PENDING_VALIDATION</c> | <c>ISSUED</c> | <c>INACTIVE</c> | <c>EXPIRED</c>
        /// | <c>VALIDATION_TIMED_OUT</c> | <c>REVOKED</c> | <c>FAILED</c> 
        /// </para>
        /// </summary>
        public string Status { get; set; }

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
        /// in the certificate.
        /// </para>
        ///  
        /// <para>
        /// The subject alternative names include the canonical domain name (CN) of the certificate
        /// and additional domain names that can be used to connect to the website.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubjectAlternativeNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubjectAlternativeNames property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeNames() => this.SubjectAlternativeNames != null && (this.SubjectAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The source of the certificate. For certificates that Certificate Manager provides,
        /// <c>Type</c> is <c>AMAZON_ISSUED</c>. For certificates that are imported with <c>ImportCertificate</c>,
        /// <c>Type</c> is <c>IMPORTED</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>IMPORTED</c> | <c>AMAZON_ISSUED</c> | <c>PRIVATE</c> 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
