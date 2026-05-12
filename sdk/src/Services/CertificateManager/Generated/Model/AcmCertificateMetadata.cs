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
    /// Contains ACM-specific metadata about a certificate.
    /// </summary>
    public partial class AcmCertificateMetadata
    {
        private DateTime? _createdAt;
        private bool? _exported;
        private CertificateExport _exportOption;
        private DateTime? _importedAt;
        private bool? _inUse;
        private DateTime? _issuedAt;
        private CertificateManagedBy _managedBy;
        private RenewalEligibility _renewalEligibility;
        private RenewalStatus _renewalStatus;
        private DateTime? _revokedAt;
        private CertificateStatus _status;
        private CertificateType _type;
        private ValidationMethod _validationMethod;

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
        /// Gets and sets the property Exported. 
        /// <para>
        /// Indicates whether the certificate has been exported.
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
        /// Indicates whether the certificate can be exported.
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
        /// Indicates whether the certificate is currently in use by an Amazon Web Services service.
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
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// The renewal status of the certificate.
        /// </para>
        /// </summary>
        public RenewalStatus RenewalStatus
        {
            get { return this._renewalStatus; }
            set { this._renewalStatus = value; }
        }

        // Check to see if RenewalStatus property is set
        internal bool IsSetRenewalStatus()
        {
            return this._renewalStatus != null;
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

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// Specifies the domain validation method.
        /// </para>
        /// </summary>
        public ValidationMethod ValidationMethod
        {
            get { return this._validationMethod; }
            set { this._validationMethod = value; }
        }

        // Check to see if ValidationMethod property is set
        internal bool IsSetValidationMethod()
        {
            return this._validationMethod != null;
        }

    }
}