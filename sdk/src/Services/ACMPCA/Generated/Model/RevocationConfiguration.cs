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
    /// Certificate revocation information used by the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
    /// and <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UpdateCertificateAuthority.html">UpdateCertificateAuthority</a>
    /// actions. Your private certificate authority (CA) can configure Online Certificate
    /// Status Protocol (OCSP) support and/or maintain a certificate revocation list (CRL).
    /// OCSP returns validation information about certificates as requested by clients, and
    /// a CRL contains an updated list of certificates revoked by your CA. For more information,
    /// see <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_RevokeCertificate.html">RevokeCertificate</a>
    /// and <a href="https://docs.aws.amazon.com/privateca/latest/userguide/revocation-setup.html">Setting
    /// up a certificate revocation method</a> in the <i>Amazon Web Services Private Certificate
    /// Authority User Guide</i>.
    /// </summary>
    public partial class RevocationConfiguration
    {
        private CrlConfiguration _crlConfiguration;
        private OcspConfiguration _ocspConfiguration;

        /// <summary>
        /// Gets and sets the property CrlConfiguration. 
        /// <para>
        /// Configuration of the certificate revocation list (CRL), if any, maintained by your
        /// private CA. A CRL is typically updated approximately 30 minutes after a certificate
        /// is revoked. If for any reason a CRL update fails, Amazon Web Services Private CA makes
        /// further attempts every 15 minutes.
        /// </para>
        /// </summary>
        public CrlConfiguration CrlConfiguration
        {
            get { return this._crlConfiguration; }
            set { this._crlConfiguration = value; }
        }

        // Check to see if CrlConfiguration property is set
        internal bool IsSetCrlConfiguration()
        {
            return this._crlConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OcspConfiguration. 
        /// <para>
        /// Configuration of Online Certificate Status Protocol (OCSP) support, if any, maintained
        /// by your private CA. When you revoke a certificate, OCSP responses may take up to 60
        /// minutes to reflect the new status.
        /// </para>
        /// </summary>
        public OcspConfiguration OcspConfiguration
        {
            get { return this._ocspConfiguration; }
            set { this._ocspConfiguration = value; }
        }

        // Check to see if OcspConfiguration property is set
        internal bool IsSetOcspConfiguration()
        {
            return this._ocspConfiguration != null;
        }

    }
}