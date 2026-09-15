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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Contains configuration for PROXY protocol version 2 (PPv2) support on an Transfer
    /// Family server. When enabled, Transfer Family reads the added PPv2 header from incoming
    /// connections to extract the original client IP address. This address is then available
    /// in Amazon CloudWatch Logs entries and is passed to custom identity providers during
    /// authentication, enabling IP-based access policies. For more information, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/working-with-nlb.html">Working
    /// with Network Load Balancers</a>.
    /// </summary>
    public partial class ProxyConfig
    {
        private ProxyMode _sftpMode;

        /// <summary>
        /// Gets and sets the property SftpMode. 
        /// <para>
        /// Specifies whether the Transfer Family server requires or ignores a PPv2 header containing
        /// the original client IP address on incoming SFTP connections. If you don't specify
        /// a value, the default is <c>NONE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: the server reads and ignores any PPv2 header on incoming SFTP connections.
        /// This is the default value. Use this value when your SFTP server is not behind an NLB,
        /// or when you do not need to preserve client source IP addresses through an NLB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROXY_PROTOCOL_V2_ENFORCED</c>: the server requires a valid PPv2 header on every
        /// incoming SFTP connection. When a valid header is present, the server applies it and
        /// uses the client IP address from the header. If a connection arrives without a PPv2
        /// header, the server refuses the connection and logs an error to Amazon CloudWatch Logs
        /// indicating that the expected PPv2 header was missing. Use this value when your SFTP
        /// server is behind an NLB with PPv2 enabled on the target group.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you enable <c>PROXY_PROTOCOL_V2_ENFORCED</c>, the server trusts the source IP
        /// address in the PPv2 header. You must configure security groups on your server's VPC
        /// endpoint to restrict inbound traffic to only the NLB's private IP addresses. For the
        /// full requirements, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/working-with-nlb.html">Working
        /// with Network Load Balancers</a>.
        /// </para>
        ///  </important> </li> </ul>
        /// </summary>
        public ProxyMode SftpMode
        {
            get { return this._sftpMode; }
            set { this._sftpMode = value; }
        }

        // Check to see if SftpMode property is set
        internal bool IsSetSftpMode()
        {
            return this._sftpMode != null;
        }

    }
}