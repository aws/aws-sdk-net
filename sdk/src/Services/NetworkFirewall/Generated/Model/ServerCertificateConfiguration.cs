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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Configures the associated Certificate Manager Secure Sockets Layer/Transport Layer
    /// Security (SSL/TLS) server certificates and scope settings Network Firewall uses to
    /// decrypt traffic in a <a>TLSInspectionConfiguration</a>. For information about working
    /// with SSL/TLS certificates for TLS inspection, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection-certificate-requirements.html">
    /// Requirements for using SSL/TLS server certficiates with TLS inspection configurations</a>
    /// in the <i>Network Firewall Developer Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// If a server certificate that's associated with your <a>TLSInspectionConfiguration</a>
    /// is revoked, deleted, or expired it can result in client-side TLS errors.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ServerCertificateConfiguration
    {
        private List<ServerCertificateScope> _scopes = new List<ServerCertificateScope>();
        private List<ServerCertificate> _serverCertificates = new List<ServerCertificate>();

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// A list of a server certificate configuration's scopes.
        /// </para>
        /// </summary>
        public List<ServerCertificateScope> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && this._scopes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServerCertificates. 
        /// <para>
        /// The list of a server certificate configuration's Certificate Manager SSL/TLS certificates.
        /// </para>
        /// </summary>
        public List<ServerCertificate> ServerCertificates
        {
            get { return this._serverCertificates; }
            set { this._serverCertificates = value; }
        }

        // Check to see if ServerCertificates property is set
        internal bool IsSetServerCertificates()
        {
            return this._serverCertificates != null && this._serverCertificates.Count > 0; 
        }

    }
}