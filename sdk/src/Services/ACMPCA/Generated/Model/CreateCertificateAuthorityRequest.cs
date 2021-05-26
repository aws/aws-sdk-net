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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCertificateAuthority operation.
    /// Creates a root or subordinate private certificate authority (CA). You must specify
    /// the CA configuration, the certificate revocation list (CRL) configuration, the CA
    /// type, and an optional idempotency token to avoid accidental creation of multiple CAs.
    /// The CA configuration specifies the name of the algorithm and key size to be used to
    /// create the CA private key, the type of signing algorithm that the CA uses, and X.500
    /// subject information. The CRL configuration specifies the CRL expiration period in
    /// days (the validity period of the CRL), the Amazon S3 bucket that will contain the
    /// CRL, and a CNAME alias for the S3 bucket that is included in certificates issued by
    /// the CA. If successful, this action returns the Amazon Resource Name (ARN) of the CA.
    /// 
    ///  
    /// <para>
    /// ACM Private CA assets that are stored in Amazon S3 can be protected with encryption.
    /// For more information, see <a href="https://docs.aws.amazon.com/acm-pca/latest/userguide/PcaCreateCa.html#crl-encryption">Encrypting
    /// Your CRLs</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Both PCA and the IAM principal must have permission to write to the S3 bucket that
    /// you specify. If the IAM principal making the call does not have permission to write
    /// to the bucket, then an exception is thrown. For more information, see <a href="https://docs.aws.amazon.com/acm-pca/latest/userguide/PcaAuthAccess.html">Configure
    /// Access to ACM Private CA</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private CertificateAuthorityConfiguration _certificateAuthorityConfiguration;
        private CertificateAuthorityType _certificateAuthorityType;
        private string _idempotencyToken;
        private KeyStorageSecurityStandard _keyStorageSecurityStandard;
        private RevocationConfiguration _revocationConfiguration;
        private List<Tag> _tags = new List<Tag>();

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
        /// the same idempotency token within five minutes, ACM Private CA recognizes that you
        /// are requesting only certificate authority and will issue only one. If you change the
        /// idempotency token for each call, PCA recognizes that you are requesting multiple certificate
        /// authorities.
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
        /// Specifies a cryptographic key management compliance standard used for handling CA
        /// keys.
        /// </para>
        ///  
        /// <para>
        /// Default: FIPS_140_2_LEVEL_3_OR_HIGHER
        /// </para>
        ///  
        /// <para>
        /// Note: <code>FIPS_140_2_LEVEL_3_OR_HIGHER</code> is not supported in Region ap-northeast-3.
        /// When creating a CA in the ap-northeast-3, you must provide <code>FIPS_140_2_LEVEL_2_OR_HIGHER</code>
        /// as the argument for <code>KeyStorageSecurityStandard</code>. Failure to do this results
        /// in an <code>InvalidArgsException</code> with the message, "A certificate authority
        /// cannot be created in this region with the specified security standard."
        /// </para>
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
        /// Contains a Boolean value that you can use to enable a certification revocation list
        /// (CRL) for the CA, the name of the S3 bucket to which ACM Private CA will write the
        /// CRL, and an optional CNAME alias that you can use to hide the name of your bucket
        /// in the <b>CRL Distribution Points</b> extension of your CA certificate. For more information,
        /// see the <a href="https://docs.aws.amazon.com/acm-pca/latest/APIReference/API_CrlConfiguration.html">CrlConfiguration</a>
        /// structure. 
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}