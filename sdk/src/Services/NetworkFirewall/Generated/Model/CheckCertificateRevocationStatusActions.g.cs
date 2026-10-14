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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public RevocationCheckAction RevokedStatusAction { get; set; }

        /// <summary>
        /// Checks to see if the RevokedStatusAction property is set.
        /// </summary>
        internal bool IsSetRevokedStatusAction() => this.RevokedStatusAction != null;

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
        public RevocationCheckAction UnknownStatusAction { get; set; }

        /// <summary>
        /// Checks to see if the UnknownStatusAction property is set.
        /// </summary>
        internal bool IsSetUnknownStatusAction() => this.UnknownStatusAction != null;
    }
}
