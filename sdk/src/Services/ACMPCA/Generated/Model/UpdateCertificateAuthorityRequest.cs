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
    /// Container for the parameters to the UpdateCertificateAuthority operation.
    /// Updates the status or configuration of a private certificate authority (CA). Your
    /// private CA must be in the <b> <code>ACTIVE</code> </b> or <b> <code>DISABLED</code>
    /// </b> state before you can update it. You can disable a private CA that is in the <b>
    /// <code>ACTIVE</code> </b> state or make a CA that is in the <b> <code>DISABLED</code>
    /// </b> state active again.
    /// </summary>
    public partial class UpdateCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private RevocationConfiguration _revocationConfiguration;
        private CertificateAuthorityStatus _status;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the private CA that issued the certificate to be revoked.
        /// This must be of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code> 
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
        /// Gets and sets the property RevocationConfiguration. 
        /// <para>
        /// Revocation information for your private CA.
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

    }
}