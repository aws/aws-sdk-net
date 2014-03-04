/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Returns information about an HSM client certificate. The certificate is stored in a secure Hardware Storage Module (HSM), and used by
    /// the Amazon Redshift cluster to encrypt data files.</para>
    /// </summary>
    public partial class HsmClientCertificate
    {
        
        private string hsmClientCertificateIdentifier;
        private string hsmClientCertificatePublicKey;

        /// <summary>
        /// The identifier of the HSM client certificate.
        ///  
        /// </summary>
        public string HsmClientCertificateIdentifier
        {
            get { return this.hsmClientCertificateIdentifier; }
            set { this.hsmClientCertificateIdentifier = value; }
        }

        /// <summary>
        /// Sets the HsmClientCertificateIdentifier property
        /// </summary>
        /// <param name="hsmClientCertificateIdentifier">The value to set for the HsmClientCertificateIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HsmClientCertificate WithHsmClientCertificateIdentifier(string hsmClientCertificateIdentifier)
        {
            this.hsmClientCertificateIdentifier = hsmClientCertificateIdentifier;
            return this;
        }
            

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this.hsmClientCertificateIdentifier != null;
        }

        /// <summary>
        /// The public key that the Amazon Redshift cluster will use to retrieve the client certificate from the HSM. You must register the public key
        /// in the HSM.
        ///  
        /// </summary>
        public string HsmClientCertificatePublicKey
        {
            get { return this.hsmClientCertificatePublicKey; }
            set { this.hsmClientCertificatePublicKey = value; }
        }

        /// <summary>
        /// Sets the HsmClientCertificatePublicKey property
        /// </summary>
        /// <param name="hsmClientCertificatePublicKey">The value to set for the HsmClientCertificatePublicKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public HsmClientCertificate WithHsmClientCertificatePublicKey(string hsmClientCertificatePublicKey)
        {
            this.hsmClientCertificatePublicKey = hsmClientCertificatePublicKey;
            return this;
        }
            

        // Check to see if HsmClientCertificatePublicKey property is set
        internal bool IsSetHsmClientCertificatePublicKey()
        {
            return this.hsmClientCertificatePublicKey != null;
        }
    }
}
