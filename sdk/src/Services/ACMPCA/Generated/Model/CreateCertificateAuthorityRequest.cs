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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
    /// Container for the parameters to the CreateCertificateAuthority operation.
    /// Creates a root or subordinate private certificate authority (CA). You must specify
    /// the CA configuration, an optional configuration for Online Certificate Status Protocol
    /// (OCSP) and/or a certificate revocation list (CRL), the CA type, and an optional idempotency
    /// token to avoid accidental creation of multiple CAs. The CA configuration specifies
    /// the name of the algorithm and key size to be used to create the CA private key, the
    /// type of signing algorithm that the CA uses, and X.500 subject information. The OCSP
    /// configuration can optionally specify a custom URL for the OCSP responder. The CRL
    /// configuration specifies the CRL expiration period in days (the validity period of
    /// the CRL), the Amazon S3 bucket that will contain the CRL, and a CNAME alias for the
    /// S3 bucket that is included in certificates issued by the CA. If successful, this action
    /// returns the Amazon Resource Name (ARN) of the CA.
    /// 
    ///  <note> 
    /// <para>
    /// Both Amazon Web Services Private CA and the IAM principal must have permission to
    /// write to the S3 bucket that you specify. If the IAM principal making the call does
    /// not have permission to write to the bucket, then an exception is thrown. For more
    /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#s3-policies">Access
    /// policies for CRLs in Amazon S3</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Amazon Web Services Private CA assets that are stored in Amazon S3 can be protected
    /// with encryption. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#crl-encryption">Encrypting
    /// Your CRLs</a>.
    /// </para>
    /// </summary>
    public partial class CreateCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private CertificateAuthorityConfiguration _certificateAuthorityConfiguration;
        private CertificateAuthorityType _certificateAuthorityType;
        private string _idempotencyToken;
        private KeyStorageSecurityStandard _keyStorageSecurityStandard;
        private RevocationConfiguration _revocationConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private CertificateAuthorityUsageMode _usageMode;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityConfiguration. 
        /// <para>
        /// Name and bit size of the private key algorithm, the name of the signing algorithm,
        /// and X.500 certificate subject information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CertificateAuthorityType. 
        /// <para>
        /// The type of the certificate authority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateAuthorityType CertificateAuthorityType
        {
            get { return this._certificateAuthorityType; }
            set { this._certificateAuthorityType = value; }
        }

        // Check to see if CertificateAuthorityType property is set
        internal bool IsSetCertificateAuthorityType()
        {
            return this._certificateAuthorityType != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// Custom string that can be used to distinguish between calls to the <b>CreateCertificateAuthority</b>
        /// action. Idempotency tokens for <b>CreateCertificateAuthority</b> time out after five
        /// minutes. Therefore, if you call <b>CreateCertificateAuthority</b> multiple times with
        /// the same idempotency token within five minutes, Amazon Web Services Private CA recognizes
        /// that you are requesting only certificate authority and will issue only one. If you
        /// change the idempotency token for each call, Amazon Web Services Private CA recognizes
        /// that you are requesting multiple certificate authorities.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property KeyStorageSecurityStandard. 
        /// <para>
        /// Specifies a cryptographic key management compliance standard for handling and protecting
        /// CA keys.
        /// </para>
        ///  
        /// <para>
        /// Default: FIPS_140_2_LEVEL_3_OR_HIGHER
        /// </para>
        ///  <note> 
        /// <para>
        /// Some Amazon Web Services Regions don't support the default value. When you create
        /// a CA in these Regions, you must use <c>CCPC_LEVEL_1_OR_HIGHER</c> for the <c>KeyStorageSecurityStandard</c>
        /// parameter. If you don't, the operation returns an <c>InvalidArgsException</c> with
        /// this message: "A certificate authority cannot be created in this region with the specified
        /// security standard."
        /// </para>
        ///  
        /// <para>
        /// For information about security standard support in different Amazon Web Services Regions,
        /// see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/data-protection.html#private-keys">Storage
        /// and security compliance of Amazon Web Services Private CA private keys</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public KeyStorageSecurityStandard KeyStorageSecurityStandard
        {
            get { return this._keyStorageSecurityStandard; }
            set { this._keyStorageSecurityStandard = value; }
        }

        // Check to see if KeyStorageSecurityStandard property is set
        internal bool IsSetKeyStorageSecurityStandard()
        {
            return this._keyStorageSecurityStandard != null;
        }

        /// <summary>
        /// Gets and sets the property RevocationConfiguration. 
        /// <para>
        /// Contains information to enable support for Online Certificate Status Protocol (OCSP),
        /// certificate revocation list (CRL), both protocols, or neither. By default, both certificate
        /// validation mechanisms are disabled.
        /// </para>
        ///  
        /// <para>
        /// The following requirements apply to revocation configurations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A configuration disabling CRLs or OCSP must contain only the <c>Enabled=False</c>
        /// parameter, and will fail if other parameters such as <c>CustomCname</c> or <c>ExpirationInDays</c>
        /// are included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In a CRL configuration, the <c>S3BucketName</c> parameter must conform to <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html">Amazon
        /// S3 bucket naming rules</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A configuration containing a custom Canonical Name (CNAME) parameter for CRLs or OCSP
        /// must conform to <a href="https://www.ietf.org/rfc/rfc2396.txt">RFC2396</a> restrictions
        /// on the use of special characters in a CNAME. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In a CRL or OCSP configuration, the value of a CNAME parameter must not include a
        /// protocol prefix such as "http://" or "https://".
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_OcspConfiguration.html">OcspConfiguration</a>
        /// and <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CrlConfiguration.html">CrlConfiguration</a>
        /// types.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that will be attached to the new private CA. You can associate up
        /// to 50 tags with a private CA. For information using tags with IAM to manage permissions,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html">Controlling
        /// Access Using IAM Tags</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public CertificateAuthorityUsageMode UsageMode
        {
            get { return this._usageMode; }
            set { this._usageMode = value; }
        }

        // Check to see if UsageMode property is set
        internal bool IsSetUsageMode()
        {
            return this._usageMode != null;
        }

    }
}