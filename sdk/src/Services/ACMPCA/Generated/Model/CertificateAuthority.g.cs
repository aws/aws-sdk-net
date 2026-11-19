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
    /// Contains information about your private certificate authority (CA). Your private CA
    /// can issue and revoke X.509 digital certificates. Digital certificates verify that
    /// the entity named in the certificate <b>Subject</b> field owns or controls the public
    /// key contained in the <b>Subject Public Key Info</b> field. Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
    /// action to create your private CA. You must then call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificateAuthorityCertificate.html">GetCertificateAuthorityCertificate</a>
    /// action to retrieve a private CA certificate signing request (CSR). Sign the CSR with
    /// your Amazon Web Services Private CA-hosted or on-premises root or subordinate CA certificate.
    /// Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ImportCertificateAuthorityCertificate.html">ImportCertificateAuthorityCertificate</a>
    /// action to import the signed certificate into Certificate Manager (ACM).
    /// </summary>
    public partial class CertificateAuthority
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for your private certificate authority (CA). The format
        /// is <c> <i>12345678-1234-1234-1234-123456789012</i> </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityConfiguration. 
        /// <para>
        /// Your private CA configuration.
        /// </para>
        /// </summary>
        public CertificateAuthorityConfiguration CertificateAuthorityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityConfiguration property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityConfiguration() => this.CertificateAuthorityConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date and time at which your private CA was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Reason the request to create your private CA failed.
        /// </para>
        /// </summary>
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property KeyStorageSecurityStandard. 
        /// <para>
        /// Defines a cryptographic key management compliance standard for handling and protecting
        /// CA keys.
        /// </para>
        ///  
        /// <para>
        /// Default: FIPS_140_2_LEVEL_3_OR_HIGHER
        /// </para>
        ///  <note> 
        /// <para>
        /// Starting January 26, 2023, Amazon Web Services Private CA protects all CA private
        /// keys in non-China regions using hardware security modules (HSMs) that comply with
        /// FIPS PUB 140-2 Level 3.
        /// </para>
        ///  
        /// <para>
        /// For information about security standard support in different Amazon Web Services Regions,
        /// see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/data-protection.html#private-keys">Storage
        /// and security compliance of Amazon Web Services Private CA private keys</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public KeyStorageSecurityStandard KeyStorageSecurityStandard { get; set; }

        /// <summary>
        /// Checks to see if the KeyStorageSecurityStandard property is set.
        /// </summary>
        internal bool IsSetKeyStorageSecurityStandard() => this.KeyStorageSecurityStandard != null;

        /// <summary>
        /// Gets and sets the property LastStateChangeAt. 
        /// <para>
        /// Date and time at which your private CA was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastStateChangeAt { get; set; }

        /// <summary>
        /// Checks to see if the LastStateChangeAt property is set.
        /// </summary>
        internal bool IsSetLastStateChangeAt() => this.LastStateChangeAt.HasValue;

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// Date and time after which your private CA certificate is not valid.
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
        /// Date and time before which your private CA certificate is not valid.
        /// </para>
        /// </summary>
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotBefore property is set.
        /// </summary>
        internal bool IsSetNotBefore() => this.NotBefore.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The Amazon Web Services account ID that owns the certificate authority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property RestorableUntil. 
        /// <para>
        /// The period during which a deleted CA can be restored. For more information, see the
        /// <c>PermanentDeletionTimeInDays</c> parameter of the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeleteCertificateAuthorityRequest.html">DeleteCertificateAuthorityRequest</a>
        /// action. 
        /// </para>
        /// </summary>
        public DateTime? RestorableUntil { get; set; }

        /// <summary>
        /// Checks to see if the RestorableUntil property is set.
        /// </summary>
        internal bool IsSetRestorableUntil() => this.RestorableUntil.HasValue;

        /// <summary>
        /// Gets and sets the property RevocationConfiguration. 
        /// <para>
        /// Information about the Online Certificate Status Protocol (OCSP) configuration or certificate
        /// revocation list (CRL) created and maintained by your private CA. 
        /// </para>
        /// </summary>
        public RevocationConfiguration RevocationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RevocationConfiguration property is set.
        /// </summary>
        internal bool IsSetRevocationConfiguration() => this.RevocationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Serial. 
        /// <para>
        /// Serial number of your private CA.
        /// </para>
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Checks to see if the Serial property is set.
        /// </summary>
        internal bool IsSetSerial() => this.Serial != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of your private CA.
        /// </para>
        /// </summary>
        public CertificateAuthorityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of your private CA.
        /// </para>
        /// </summary>
        public CertificateAuthorityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UsageMode. 
        /// <para>
        /// Specifies whether the CA issues general-purpose certificates that typically require
        /// a revocation mechanism, or short-lived certificates that may optionally omit revocation
        /// because they expire quickly. Short-lived certificate validity is limited to seven
        /// days.
        /// </para>
        ///  
        /// <para>
        /// The default value is GENERAL_PURPOSE.
        /// </para>
        /// </summary>
        public CertificateAuthorityUsageMode UsageMode { get; set; }

        /// <summary>
        /// Checks to see if the UsageMode property is set.
        /// </summary>
        internal bool IsSetUsageMode() => this.UsageMode != null;
    }
}
