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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The protocol settings that are configured for your server.
    /// </summary>
    public partial class ProtocolDetails
    {
        private string _passiveIp;
        private TlsSessionResumptionMode _tlsSessionResumptionMode;

        /// <summary>
        /// Gets and sets the property PassiveIp. 
        /// <para>
        ///  Indicates passive mode, for FTP and FTPS protocols. Enter a single dotted-quad IPv4
        /// address, such as the external IP address of a firewall, router, or load balancer.
        /// For example: 
        /// </para>
        ///  
        /// <para>
        ///  <code> aws transfer update-server --protocol-details PassiveIp=<i>0.0.0.0</i> </code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Replace <code> <i>0.0.0.0</i> </code> in the example above with the actual IP address
        /// you want to use.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you change the <code>PassiveIp</code> value, you must stop and then restart your
        /// Transfer server for the change to take effect. For details on using Passive IP (PASV)
        /// in a NAT environment, see <a href="http://aws.amazon.com/blogs/storage/configuring-your-ftps-server-behind-a-firewall-or-nat-with-aws-transfer-family/">Configuring
        /// your FTPS server behind a firewall or NAT with Amazon Web Services Transfer Family</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=15)]
        public string PassiveIp
        {
            get { return this._passiveIp; }
            set { this._passiveIp = value; }
        }

        // Check to see if PassiveIp property is set
        internal bool IsSetPassiveIp()
        {
            return this._passiveIp != null;
        }

        /// <summary>
        /// Gets and sets the property TlsSessionResumptionMode. 
        /// <para>
        /// A property used with Transfer servers that use the FTPS protocol. TLS Session Resumption
        /// provides a mechanism to resume or share a negotiated secret key between the control
        /// and data connection for an FTPS session. <code>TlsSessionResumptionMode</code> determines
        /// whether or not the server resumes recent, negotiated sessions through a unique session
        /// ID. This property is available during <code>CreateServer</code> and <code>UpdateServer</code>
        /// calls. If a <code>TlsSessionResumptionMode</code> value is not specified during CreateServer,
        /// it is set to <code>ENFORCED</code> by default.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DISABLED</code>: the server does not process TLS session resumption client
        /// requests and creates a new TLS session for each request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED</code>: the server processes and accepts clients that are performing
        /// TLS session resumption. The server doesn't reject client data connections that do
        /// not perform the TLS session resumption client processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENFORCED</code>: the server processes and accepts clients that are performing
        /// TLS session resumption. The server rejects client data connections that do not perform
        /// the TLS session resumption client processing. Before you set the value to <code>ENFORCED</code>,
        /// test your clients.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not all FTPS clients perform TLS session resumption. So, if you choose to enforce
        /// TLS session resumption, you prevent any connections from FTPS clients that don't perform
        /// the protocol negotiation. To determine whether or not you can use the <code>ENFORCED</code>
        /// value, you need to test your clients.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        public TlsSessionResumptionMode TlsSessionResumptionMode
        {
            get { return this._tlsSessionResumptionMode; }
            set { this._tlsSessionResumptionMode = value; }
        }

        // Check to see if TlsSessionResumptionMode property is set
        internal bool IsSetTlsSessionResumptionMode()
        {
            return this._tlsSessionResumptionMode != null;
        }

    }
}