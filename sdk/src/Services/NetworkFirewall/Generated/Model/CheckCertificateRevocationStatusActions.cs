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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Defines the actions to take on the SSL/TLS connection if the certificate presented
    /// by the server in the connection has a revoked or unknown status.
    /// </summary>
    public partial class CheckCertificateRevocationStatusActions
    {
        private RevocationCheckAction _revokedStatusAction;
        private RevocationCheckAction _unknownStatusAction;

        /// <summary>
        /// Gets and sets the property RevokedStatusAction. 
        /// <para>
        /// Configures how Network Firewall processes traffic when it determines that the certificate
        /// presented by the server in the SSL/TLS connection has a revoked status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PASS</b> - Allow the connection to continue, and pass subsequent packets to the
        /// stateful engine for inspection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DROP</b> - Network Firewall closes the connection and drops subsequent packets
        /// for that connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REJECT</b> - Network Firewall sends a TCP reject packet back to your client. The
        /// service closes the connection and drops subsequent packets for that connection. <c>REJECT</c>
        /// is available only for TCP traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RevocationCheckAction RevokedStatusAction
        {
            get { return this._revokedStatusAction; }
            set { this._revokedStatusAction = value; }
        }

        // Check to see if RevokedStatusAction property is set
        internal bool IsSetRevokedStatusAction()
        {
            return this._revokedStatusAction != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownStatusAction. 
        /// <para>
        /// Configures how Network Firewall processes traffic when it determines that the certificate
        /// presented by the server in the SSL/TLS connection has an unknown status, or a status
        /// that cannot be determined for any other reason, including when the service is unable
        /// to connect to the OCSP and CRL endpoints for the certificate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PASS</b> - Allow the connection to continue, and pass subsequent packets to the
        /// stateful engine for inspection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DROP</b> - Network Firewall closes the connection and drops subsequent packets
        /// for that connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REJECT</b> - Network Firewall sends a TCP reject packet back to your client. The
        /// service closes the connection and drops subsequent packets for that connection. <c>REJECT</c>
        /// is available only for TCP traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RevocationCheckAction UnknownStatusAction
        {
            get { return this._unknownStatusAction; }
            set { this._unknownStatusAction = value; }
        }

        // Check to see if UnknownStatusAction property is set
        internal bool IsSetUnknownStatusAction()
        {
            return this._unknownStatusAction != null;
        }

    }
}