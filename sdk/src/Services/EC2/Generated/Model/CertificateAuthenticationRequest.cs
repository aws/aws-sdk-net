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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the client certificate to be used for authentication.
    /// </summary>
    public partial class CertificateAuthenticationRequest
    {
        private string _clientRootCertificateChainArn;

        /// <summary>
        /// Gets and sets the property ClientRootCertificateChainArn. 
        /// <para>
        /// The ARN of the client certificate. The certificate must be signed by a certificate
        /// authority (CA) and it must be provisioned in AWS Certificate Manager (ACM).
        /// </para>
        /// </summary>
        public string ClientRootCertificateChainArn
        {
            get { return this._clientRootCertificateChainArn; }
            set { this._clientRootCertificateChainArn = value; }
        }

        // Check to see if ClientRootCertificateChainArn property is set
        internal bool IsSetClientRootCertificateChainArn()
        {
            return this._clientRootCertificateChainArn != null;
        }

    }
}