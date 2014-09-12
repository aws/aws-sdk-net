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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about an HSM client certificate. The certificate is stored in
    /// a secure            Hardware Storage Module (HSM), and used by the Amazon Redshift
    /// cluster to            encrypt data files.
    /// </summary>
    public partial class HsmClientCertificate
    {
        private string _hsmClientCertificateIdentifier;
        private string _hsmClientCertificatePublicKey;

        /// <summary>
        /// Gets and sets the property HsmClientCertificateIdentifier. 
        /// <para>
        /// The identifier of the HSM client certificate.
        /// </para>
        /// </summary>
        public string HsmClientCertificateIdentifier
        {
            get { return this._hsmClientCertificateIdentifier; }
            set { this._hsmClientCertificateIdentifier = value; }
        }

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this._hsmClientCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property HsmClientCertificatePublicKey. 
        /// <para>
        /// The public key that the Amazon Redshift cluster will use to connect to the HSM.  
        ///          You must register the public key in the HSM.
        /// </para>
        /// </summary>
        public string HsmClientCertificatePublicKey
        {
            get { return this._hsmClientCertificatePublicKey; }
            set { this._hsmClientCertificatePublicKey = value; }
        }

        // Check to see if HsmClientCertificatePublicKey property is set
        internal bool IsSetHsmClientCertificatePublicKey()
        {
            return this._hsmClientCertificatePublicKey != null;
        }

    }
}