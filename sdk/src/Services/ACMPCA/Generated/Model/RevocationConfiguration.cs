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
    /// Certificate revocation information used by the <a>CreateCertificateAuthority</a> and
    /// <a>UpdateCertificateAuthority</a> functions. Your private certificate authority (CA)
    /// can create and maintain a certificate revocation list (CRL). A CRL contains information
    /// about certificates revoked by your CA. For more information, see <a>RevokeCertificate</a>.
    /// </summary>
    public partial class RevocationConfiguration
    {
        private CrlConfiguration _crlConfiguration;

        /// <summary>
        /// Gets and sets the property CrlConfiguration. 
        /// <para>
        /// Configuration of the certificate revocation list (CRL), if any, maintained by your
        /// private CA.
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

    }
}