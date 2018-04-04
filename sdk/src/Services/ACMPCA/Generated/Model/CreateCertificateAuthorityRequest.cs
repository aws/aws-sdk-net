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
    /// Container for the parameters to the CreateCertificateAuthority operation.
    /// Creates a private subordinate certificate authority (CA). You must specify the CA
    /// configuration, the revocation configuration, the CA type, and an optional idempotency
    /// token. The CA configuration specifies the name of the algorithm and key size to be
    /// used to create the CA private key, the type of signing algorithm that the CA uses
    /// to sign, and X.500 subject information. The CRL (certificate revocation list) configuration
    /// specifies the CRL expiration period in days (the validity period of the CRL), the
    /// Amazon S3 bucket that will contain the CRL, and a CNAME alias for the S3 bucket that
    /// is included in certificates issued by the CA. If successful, this function returns
    /// the Amazon Resource Name (ARN) of the CA.
    /// </summary>
    public partial class CreateCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private CertificateAuthorityConfiguration _certificateAuthorityConfiguration;
        private CertificateAuthorityType _certificateAuthorityType;
        private string _idempotencyToken;
        private RevocationConfiguration _revocationConfiguration;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityConfiguration. 
        /// <para>
        /// Name and bit size of the private key algorithm, the name of the signing algorithm,
        /// and X.500 certificate subject information.
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
        /// Gets and sets the property CertificateAuthorityType. 
        /// <para>
        /// The type of the certificate authority. Currently, this must be <b>SUBORDINATE</b>.
        /// </para>
        /// </summary>
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
        /// Alphanumeric string that can be used to distinguish between calls to <b>CreateCertificateAuthority</b>.
        /// Idempotency tokens time out after five minutes. Therefore, if you call <b>CreateCertificateAuthority</b>
        /// multiple times with the same idempotency token within a five minute period, ACM PCA
        /// recognizes that you are requesting only one certificate and will issue only one. If
        /// you change the idempotency token for each call, however, ACM PCA recognizes that you
        /// are requesting multiple certificates.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RevocationConfiguration. 
        /// <para>
        /// Contains a Boolean value that you can use to enable a certification revocation list
        /// (CRL) for the CA, the name of the S3 bucket to which ACM PCA will write the CRL, and
        /// an optional CNAME alias that you can use to hide the name of your bucket in the <b>CRL
        /// Distribution Points</b> extension of your CA certificate. For more information, see
        /// the <a>CrlConfiguration</a> structure. 
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

    }
}