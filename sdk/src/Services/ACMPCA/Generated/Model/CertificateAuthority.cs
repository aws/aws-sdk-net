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
    /// Contains information about your private certificate authority (CA). Your private CA
    /// can issue and revoke X.509 digital certificates. Digital certificates verify that
    /// the entity named in the certificate <b>Subject</b> field owns or controls the public
    /// key contained in the <b>Subject Public Key Info</b> field. Call the <a>CreateCertificateAuthority</a>
    /// function to create your private CA. You must then call the <a>GetCertificateAuthorityCertificate</a>
    /// function to retrieve a private CA certificate signing request (CSR). Take the CSR
    /// to your on-premises CA and sign it with the root CA certificate or a subordinate certificate.
    /// Call the <a>ImportCertificateAuthorityCertificate</a> function to import the signed
    /// certificate into AWS Certificate Manager (ACM).
    /// </summary>
    public partial class CertificateAuthority
    {
        private string _arn;
        private CertificateAuthorityConfiguration _certificateAuthorityConfiguration;
        private DateTime? _createdAt;
        private FailureReason _failureReason;
        private DateTime? _lastStateChangeAt;
        private DateTime? _notAfter;
        private DateTime? _notBefore;
        private RevocationConfiguration _revocationConfiguration;
        private string _serial;
        private CertificateAuthorityStatus _status;
        private CertificateAuthorityType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for your private certificate authority (CA). The format
        /// is <code> <i>12345678-1234-1234-1234-123456789012</i> </code>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthorityConfiguration. 
        /// <para>
        /// Your private CA configuration.
        /// </para>
        /// </summary>
        public CertificateAuthorityConfiguration CertificateAuthorityConfiguration
        {
            get { return this._certificateAuthorityConfiguration; }
            set { this._certificateAuthorityConfiguration = value; }
        }

        // Check to see if CertificateAuthorityConfiguration property is set
        internal bool IsSetCertificateAuthorityConfiguration()
        {
            return this._certificateAuthorityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date and time at which your private CA was created.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Reason the request to create your private CA failed.
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
        /// Gets and sets the property LastStateChangeAt. 
        /// <para>
        /// Date and time at which your private CA was last updated.
        /// </para>
        /// </summary>
        public DateTime LastStateChangeAt
        {
            get { return this._lastStateChangeAt.GetValueOrDefault(); }
            set { this._lastStateChangeAt = value; }
        }

        // Check to see if LastStateChangeAt property is set
        internal bool IsSetLastStateChangeAt()
        {
            return this._lastStateChangeAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// Date and time after which your private CA certificate is not valid.
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
        /// Date and time before which your private CA certificate is not valid.
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
        /// Gets and sets the property RevocationConfiguration. 
        /// <para>
        /// Information about the certificate revocation list (CRL) created and maintained by
        /// your private CA. 
        /// </para>
        /// </summary>
        public RevocationConfiguration RevocationConfiguration
        {
            get { return this._revocationConfiguration; }
            set { this._revocationConfiguration = value; }
        }

        // Check to see if RevocationConfiguration property is set
        internal bool IsSetRevocationConfiguration()
        {
            return this._revocationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Serial. 
        /// <para>
        /// Serial number of your private CA.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of your private CA.
        /// </para>
        /// </summary>
        public CertificateAuthorityStatus Status
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
        /// Type of your private CA.
        /// </para>
        /// </summary>
        public CertificateAuthorityType Type
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