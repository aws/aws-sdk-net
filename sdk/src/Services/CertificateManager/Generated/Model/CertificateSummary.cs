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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
        private string _certificateArn;
        private DateTime? _createdAt;
        private string _domainName;
        private bool? _exported;
        private CertificateExport _exportOption;
        private List<string> _extendedKeyUsages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _hasAdditionalSubjectAlternativeNames;
        private DateTime? _importedAt;
        private bool? _inUse;
        private DateTime? _issuedAt;
        private KeyAlgorithm _keyAlgorithm;
        private List<string> _keyUsages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CertificateManagedBy _managedBy;
        private DateTime? _notAfter;
        private DateTime? _notBefore;
        private RenewalEligibility _renewalEligibility;
        private DateTime? _revokedAt;
        private CertificateStatus _status;
        private List<string> _subjectAlternativeNameSummaries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CertificateType _type;

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
        [AWSProperty(Min=20, Max=2048)]
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the certificate was requested.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Fully qualified domain name (FQDN), such as www.example.com or example.com, for the
        /// certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
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
        /// Gets and sets the property Exported. 
        /// <para>
        /// Indicates whether the certificate has been exported. This value exists only when the
        /// certificate type is <c>PRIVATE</c>.
        /// </para>
        /// </summary>
        public bool? Exported
        {
            get { return this._exported; }
            set { this._exported = value; }
        }

        // Check to see if Exported property is set
        internal bool IsSetExported()
        {
            return this._exported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportOption. 
        /// <para>
        /// Indicates if export is enabled for the certificate.
        /// </para>
        /// </summary>
        public CertificateExport ExportOption
        {
            get { return this._exportOption; }
            set { this._exportOption = value; }
        }

        // Check to see if ExportOption property is set
        internal bool IsSetExportOption()
        {
            return this._exportOption != null;
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
        public List<string> ExtendedKeyUsages
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
        /// Gets and sets the property HasAdditionalSubjectAlternativeNames. 
        /// <para>
        /// When called by <a href="https://docs.aws.amazon.com/acm/latestAPIReference/API_ListCertificates.html">ListCertificates</a>,
        /// indicates whether the full list of subject alternative names has been included in
        /// the response. If false, the response includes all of the subject alternative names
        /// included in the certificate. If true, the response only includes the first 100 subject
        /// alternative names included in the certificate. To display the full list of subject
        /// alternative names, use <a href="https://docs.aws.amazon.com/acm/latestAPIReference/API_DescribeCertificate.html">DescribeCertificate</a>.
        /// </para>
        /// </summary>
        public bool? HasAdditionalSubjectAlternativeNames
        {
            get { return this._hasAdditionalSubjectAlternativeNames; }
            set { this._hasAdditionalSubjectAlternativeNames = value; }
        }

        // Check to see if HasAdditionalSubjectAlternativeNames property is set
        internal bool IsSetHasAdditionalSubjectAlternativeNames()
        {
            return this._hasAdditionalSubjectAlternativeNames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportedAt. 
        /// <para>
        /// The date and time when the certificate was imported. This value exists only when the
        /// certificate type is <c>IMPORTED</c>. 
        /// </para>
        /// </summary>
        public DateTime? ImportedAt
        {
            get { return this._importedAt; }
            set { this._importedAt = value; }
        }

        // Check to see if ImportedAt property is set
        internal bool IsSetImportedAt()
        {
            return this._importedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// Indicates whether the certificate is currently in use by any Amazon Web Services resources.
        /// </para>
        /// </summary>
        public bool? InUse
        {
            get { return this._inUse; }
            set { this._inUse = value; }
        }

        // Check to see if InUse property is set
        internal bool IsSetInUse()
        {
            return this._inUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The time at which the certificate was issued. This value exists only when the certificate
        /// type is <c>AMAZON_ISSUED</c>. 
        /// </para>
        /// </summary>
        public DateTime? IssuedAt
        {
            get { return this._issuedAt; }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The algorithm that was used to generate the public-private key pair.
        /// </para>
        /// </summary>
        public KeyAlgorithm KeyAlgorithm
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
        /// A list of Key Usage X.509 v3 extension objects. Each object is a string value that
        /// identifies the purpose of the public key contained in the certificate. Possible extension
        /// values include DIGITAL_SIGNATURE, KEY_ENCHIPHERMENT, NON_REPUDIATION, and more.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> KeyUsages
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
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// Identifies the Amazon Web Services service that manages the certificate issued by
        /// ACM.
        /// </para>
        /// </summary>
        public CertificateManagedBy ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The time after which the certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime? NotAfter
        {
            get { return this._notAfter; }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The time before which the certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime? NotBefore
        {
            get { return this._notBefore; }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RenewalEligibility. 
        /// <para>
        /// Specifies whether the certificate is eligible for renewal. At this time, only exported
        /// private certificates can be renewed with the <a>RenewCertificate</a> command.
        /// </para>
        /// </summary>
        public RenewalEligibility RenewalEligibility
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
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The time at which the certificate was revoked. This value exists only when the certificate
        /// status is <c>REVOKED</c>. 
        /// </para>
        /// </summary>
        public DateTime? RevokedAt
        {
            get { return this._revokedAt; }
            set { this._revokedAt = value; }
        }

        // Check to see if RevokedAt property is set
        internal bool IsSetRevokedAt()
        {
            return this._revokedAt.HasValue; 
        }

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
        public CertificateStatus Status
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
        /// When called by <a href="https://docs.aws.amazon.com/acm/latestAPIReference/API_ListCertificates.html">ListCertificates</a>,
        /// this parameter will only return the first 100 subject alternative names included in
        /// the certificate. To display the full list of subject alternative names, use <a href="https://docs.aws.amazon.com/acm/latestAPIReference/API_DescribeCertificate.html">DescribeCertificate</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> SubjectAlternativeNameSummaries
        {
            get { return this._subjectAlternativeNameSummaries; }
            set { this._subjectAlternativeNameSummaries = value; }
        }

        // Check to see if SubjectAlternativeNameSummaries property is set
        internal bool IsSetSubjectAlternativeNameSummaries()
        {
            return this._subjectAlternativeNameSummaries != null && (this._subjectAlternativeNameSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public CertificateType Type
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