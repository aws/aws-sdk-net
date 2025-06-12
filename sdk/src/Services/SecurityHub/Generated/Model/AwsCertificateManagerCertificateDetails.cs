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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _certificateAuthorityArn;
        private string _createdAt;
        private string _domainName;
        private List<AwsCertificateManagerCertificateDomainValidationOption> _domainValidationOptions = AWSConfigs.InitializeCollections ? new List<AwsCertificateManagerCertificateDomainValidationOption>() : null;
        private List<AwsCertificateManagerCertificateExtendedKeyUsage> _extendedKeyUsages = AWSConfigs.InitializeCollections ? new List<AwsCertificateManagerCertificateExtendedKeyUsage>() : null;
        private string _failureReason;
        private string _importedAt;
        private List<string> _inUseBy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _issuedAt;
        private string _issuer;
        private string _keyAlgorithm;
        private List<AwsCertificateManagerCertificateKeyUsage> _keyUsages = AWSConfigs.InitializeCollections ? new List<AwsCertificateManagerCertificateKeyUsage>() : null;
        private string _notAfter;
        private string _notBefore;
        private AwsCertificateManagerCertificateOptions _options;
        private string _renewalEligibility;
        private AwsCertificateManagerCertificateRenewalSummary _renewalSummary;
        private string _serial;
        private string _signatureAlgorithm;
        private string _status;
        private string _subject;
        private List<string> _subjectAlternativeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _type;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The ARN of the private certificate authority (CA) that will be used to issue the certificate.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates when the certificate was requested.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The fully qualified domain name (FQDN), such as www.example.com, that is secured by
        /// the certificate.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCertificateManagerCertificateDomainValidationOption> DomainValidationOptions
        {
            get { return this._domainValidationOptions; }
            set { this._domainValidationOptions = value; }
        }

        // Check to see if DomainValidationOptions property is set
        internal bool IsSetDomainValidationOptions()
        {
            return this._domainValidationOptions != null && (this._domainValidationOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsages. 
        /// <para>
        /// Contains a list of Extended Key Usage X.509 v3 extension objects. Each object specifies
        /// a purpose for which the certificate public key can be used and consists of a name
        /// and an object identifier (OID).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCertificateManagerCertificateExtendedKeyUsage> ExtendedKeyUsages
        {
            get { return this._extendedKeyUsages; }
            set { this._extendedKeyUsages = value; }
        }

        // Check to see if ExtendedKeyUsages property is set
        internal bool IsSetExtendedKeyUsages()
        {
            return this._extendedKeyUsages != null && (this._extendedKeyUsages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedAt. 
        /// <para>
        /// Indicates when the certificate was imported. Provided if the certificate type is <c>IMPORTED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ImportedAt
        {
            get { return this._importedAt; }
            set { this._importedAt = value; }
        }

        // Check to see if ImportedAt property is set
        internal bool IsSetImportedAt()
        {
            return this._importedAt != null;
        }

        /// <summary>
        /// Gets and sets the property InUseBy. 
        /// <para>
        /// The list of ARNs for the Amazon Web Services resources that use the certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InUseBy
        {
            get { return this._inUseBy; }
            set { this._inUseBy = value; }
        }

        // Check to see if InUseBy property is set
        internal bool IsSetInUseBy()
        {
            return this._inUseBy != null && (this._inUseBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// Indicates when the certificate was issued. Provided if the certificate type is <c>AMAZON_ISSUED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string IssuedAt
        {
            get { return this._issuedAt; }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The name of the certificate authority that issued and signed the certificate.
        /// </para>
        /// </summary>
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

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
        public string KeyAlgorithm
        {
            get { return this._keyAlgorithm; }
            set { this._keyAlgorithm = value; }
        }

        // Check to see if KeyAlgorithm property is set
        internal bool IsSetKeyAlgorithm()
        {
            return this._keyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsages. 
        /// <para>
        /// A list of key usage X.509 v3 extension objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCertificateManagerCertificateKeyUsage> KeyUsages
        {
            get { return this._keyUsages; }
            set { this._keyUsages = value; }
        }

        // Check to see if KeyUsages property is set
        internal bool IsSetKeyUsages()
        {
            return this._keyUsages != null && (this._keyUsages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The time after which the certificate becomes invalid.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string NotAfter
        {
            get { return this._notAfter; }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter != null;
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The time before which the certificate is not valid.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string NotBefore
        {
            get { return this._notBefore; }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Provides a value that specifies whether to add the certificate to a transparency log.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

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
        public string RenewalEligibility
        {
            get { return this._renewalEligibility; }
            set { this._renewalEligibility = value; }
        }

        // Check to see if RenewalEligibility property is set
        internal bool IsSetRenewalEligibility()
        {
            return this._renewalEligibility != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalSummary. 
        /// <para>
        /// Information about the status of the Certificate Manager managed renewal for the certificate.
        /// Provided only when the certificate type is <c>AMAZON_ISSUED</c>.
        /// </para>
        /// </summary>
        public AwsCertificateManagerCertificateRenewalSummary RenewalSummary
        {
            get { return this._renewalSummary; }
            set { this._renewalSummary = value; }
        }

        // Check to see if RenewalSummary property is set
        internal bool IsSetRenewalSummary()
        {
            return this._renewalSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Serial. 
        /// <para>
        /// The serial number of the certificate.
        /// </para>
        /// </summary>
        public string Serial
        {
            get { return this._serial; }
            set { this._serial = value; }
        }

        // Check to see if Serial property is set
        internal bool IsSetSerial()
        {
            return this._serial != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        /// The algorithm that was used to sign the certificate.
        /// </para>
        /// </summary>
        public string SignatureAlgorithm
        {
            get { return this._signatureAlgorithm; }
            set { this._signatureAlgorithm = value; }
        }

        // Check to see if SignatureAlgorithm property is set
        internal bool IsSetSignatureAlgorithm()
        {
            return this._signatureAlgorithm != null;
        }

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
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The name of the entity that is associated with the public key contained in the certificate.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null && (this._subjectAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}