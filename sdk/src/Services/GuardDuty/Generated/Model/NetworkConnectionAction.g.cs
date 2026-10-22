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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the NETWORK_CONNECTION action described in the finding.
    /// </summary>
    public partial class NetworkConnectionAction
    {
        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether EC2 blocked the network connection to your instance.
        /// </para>
        /// </summary>
        public bool? Blocked { get; set; }

        /// <summary>
        /// Checks to see if the Blocked property is set.
        /// </summary>
        internal bool IsSetBlocked() => this.Blocked.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectionDirection. 
        /// <para>
        /// The network connection direction.
        /// </para>
        /// </summary>
        public string ConnectionDirection { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionDirection property is set.
        /// </summary>
        internal bool IsSetConnectionDirection() => this.ConnectionDirection != null;

        /// <summary>
        /// Gets and sets the property LocalIpDetails. 
        /// <para>
        /// The local IP information of the connection.
        /// </para>
        /// </summary>
        public LocalIpDetails LocalIpDetails { get; set; }

        /// <summary>
        /// Checks to see if the LocalIpDetails property is set.
        /// </summary>
        internal bool IsSetLocalIpDetails() => this.LocalIpDetails != null;

        /// <summary>
        /// Gets and sets the property LocalNetworkInterface. 
        /// <para>
        /// The EC2 instance's local elastic network interface utilized for the connection.
        /// </para>
        /// </summary>
        public string LocalNetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the LocalNetworkInterface property is set.
        /// </summary>
        internal bool IsSetLocalNetworkInterface() => this.LocalNetworkInterface != null;

        /// <summary>
        /// Gets and sets the property LocalPortDetails. 
        /// <para>
        /// The local port information of the connection.
        /// </para>
        /// </summary>
        public LocalPortDetails LocalPortDetails { get; set; }

        /// <summary>
        /// Checks to see if the LocalPortDetails property is set.
        /// </summary>
        internal bool IsSetLocalPortDetails() => this.LocalPortDetails != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network connection protocol.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// The remote IP information of the connection.
        /// </para>
        /// </summary>
        public RemoteIpDetails RemoteIpDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIpDetails property is set.
        /// </summary>
        internal bool IsSetRemoteIpDetails() => this.RemoteIpDetails != null;

        /// <summary>
        /// Gets and sets the property RemotePortDetails. 
        /// <para>
        /// The remote port information of the connection.
        /// </para>
        /// </summary>
        public RemotePortDetails RemotePortDetails { get; set; }

        /// <summary>
        /// Checks to see if the RemotePortDetails property is set.
        /// </summary>
        internal bool IsSetRemotePortDetails() => this.RemotePortDetails != null;
    }
}
