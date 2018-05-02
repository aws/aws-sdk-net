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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains metadata about an ACM certificate. This structure is returned in the response
    /// to a <a>DescribeCertificate</a> request.
    /// </summary>
    public partial class CertificateDetail
    {
        private string _certificateArn;
        private string _certificateAuthorityArn;
        private DateTime? _createdAt;
        private string _domainName;
        private List<DomainValidation> _domainValidationOptions = new List<DomainValidation>();
        private List<ExtendedKeyUsage> _extendedKeyUsages = new List<ExtendedKeyUsage>();
        private FailureReason _failureReason;
        private DateTime? _importedAt;
        private List<string> _inUseBy = new List<string>();
        private DateTime? _issuedAt;
        private string _issuer;
        private KeyAlgorithm _keyAlgorithm;
        private List<KeyUsage> _keyUsages = new List<KeyUsage>();
        private DateTime? _notAfter;
        private DateTime? _notBefore;
        private CertificateOptions _options;
        private RenewalEligibility _renewalEligibility;
        private RenewalSummary _renewalSummary;
        private RevocationReason _revocationReason;
        private DateTime? _revokedAt;
        private string _serial;
        private string _signatureAlgorithm;
        private CertificateStatus _status;
        private string _subject;
        private List<string> _subjectAlternativeNames = new List<string>();
        private CertificateType _type;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate. For more information about ARNs,
        /// see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACM PCA private certificate authority (CA) that
        /// issued the certificate. This has the following format: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012</code>
        /// 
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
        /// The time at which the certificate was requested. This value exists only when the certificate
        /// type is <code>AMAZON_ISSUED</code>. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// The fully qualified domain name for the certificate, such as www.example.com or example.com.
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
        /// as a result of the <a>RequestCertificate</a> request. This field exists only when
        /// the certificate type is <code>AMAZON_ISSUED</code>. 
        /// </para>
        /// </summary>
        public List<DomainValidation> DomainValidationOptions
        {
            get { return this._domainValidationOptions; }
            set { this._domainValidationOptions = value; }
        }

        // Check to see if DomainValidationOptions property is set
        internal bool IsSetDomainValidationOptions()
        {
            return this._domainValidationOptions != null && this._domainValidationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExtendedKeyUsages. 
        /// <para>
        /// Contains a list of Extended Key Usage X.509 v3 extension objects. Each object specifies
        /// a purpose for which the certificate public key can be used and consists of a name
        /// and an object identifier (OID). 
        /// </para>
        /// </summary>
        public List<ExtendedKeyUsage> ExtendedKeyUsages
        {
            get { return this._extendedKeyUsages; }
            set { this._extendedKeyUsages = value; }
        }

        // Check to see if ExtendedKeyUsages property is set
        internal bool IsSetExtendedKeyUsages()
        {
            return this._extendedKeyUsages != null && this._extendedKeyUsages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the certificate request failed. This value exists only when the certificate
        /// status is <code>FAILED</code>. For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/troubleshooting.html#troubleshooting-failed">Certificate
        /// Request Failed</a> in the <i>AWS Certificate Manager User Guide</i>. 
        /// </para>
        /// </summary>
        public FailureReason FailureReason
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
        /// The date and time at which the certificate was imported. This value exists only when
        /// the certificate type is <code>IMPORTED</code>. 
        /// </para>
        /// </summary>
        public DateTime ImportedAt
        {
            get { return this._importedAt.GetValueOrDefault(); }
            set { this._importedAt = value; }
        }

        // Check to see if ImportedAt property is set
        internal bool IsSetImportedAt()
        {
            return this._importedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InUseBy. 
        /// <para>
        /// A list of ARNs for the AWS resources that are using the certificate. A certificate
        /// can be used by multiple AWS resources. 
        /// </para>
        /// </summary>
        public List<string> InUseBy
        {
            get { return this._inUseBy; }
            set { this._inUseBy = value; }
        }

        // Check to see if InUseBy property is set
        internal bool IsSetInUseBy()
        {
            return this._inUseBy != null && this._inUseBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The time at which the certificate was issued. This value exists only when the certificate
        /// type is <code>AMAZON_ISSUED</code>. 
        /// </para>
        /// </summary>
        public DateTime IssuedAt
        {
            get { return this._issuedAt.GetValueOrDefault(); }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt.HasValue; 
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
        /// </summary>
        public List<KeyUsage> KeyUsages
        {
            get { return this._keyUsages; }
            set { this._keyUsages = value; }
        }

        // Check to see if KeyUsages property is set
        internal bool IsSetKeyUsages()
        {
            return this._keyUsages != null && this._keyUsages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The time after which the certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime NotAfter
        {
            get { return this._notAfter.GetValueOrDefault(); }
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
        public DateTime NotBefore
        {
            get { return this._notBefore.GetValueOrDefault(); }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Value that specifies whether to add the certificate to a transparency log. Certificate
        /// transparency makes it possible to detect SSL certificates that have been mistakenly
        /// or maliciously issued. A browser might respond to certificate that has not been logged
        /// by showing an error message. The logs are cryptographically secure. 
        /// </para>
        /// </summary>
        public CertificateOptions Options
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
        /// Specifies whether the certificate is eligible for renewal.
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
        /// Gets and sets the property RenewalSummary. 
        /// <para>
        /// Contains information about the status of ACM's <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for the certificate. This field exists only when the certificate type
        /// is <code>AMAZON_ISSUED</code>.
        /// </para>
        /// </summary>
        public RenewalSummary RenewalSummary
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
        /// Gets and sets the property RevocationReason. 
        /// <para>
        /// The reason the certificate was revoked. This value exists only when the certificate
        /// status is <code>REVOKED</code>. 
        /// </para>
        /// </summary>
        public RevocationReason RevocationReason
        {
            get { return this._revocationReason; }
            set { this._revocationReason = value; }
        }

        // Check to see if RevocationReason property is set
        internal bool IsSetRevocationReason()
        {
            return this._revocationReason != null;
        }

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The time at which the certificate was revoked. This value exists only when the certificate
        /// status is <code>REVOKED</code>. 
        /// </para>
        /// </summary>
        public DateTime RevokedAt
        {
            get { return this._revokedAt.GetValueOrDefault(); }
            set { this._revokedAt = value; }
        }

        // Check to see if RevokedAt property is set
        internal bool IsSetRevokedAt()
        {
            return this._revokedAt.HasValue; 
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
        /// in the certificate. The subject alternative names include the canonical domain name
        /// (CN) of the certificate and additional domain names that can be used to connect to
        /// the website. 
        /// </para>
        /// </summary>
        public List<string> SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null && this._subjectAlternativeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The source of the certificate. For certificates provided by ACM, this value is <code>AMAZON_ISSUED</code>.
        /// For certificates that you imported with <a>ImportCertificate</a>, this value is <code>IMPORTED</code>.
        /// ACM does not provide <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for imported certificates. For more information about the differences
        /// between certificates that you import and those that ACM provides, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>AWS Certificate Manager User Guide</i>. 
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