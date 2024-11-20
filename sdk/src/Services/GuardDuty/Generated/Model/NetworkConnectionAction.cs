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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private bool? _blocked;
        private string _connectionDirection;
        private LocalIpDetails _localIpDetails;
        private string _localNetworkInterface;
        private LocalPortDetails _localPortDetails;
        private string _protocol;
        private RemoteIpDetails _remoteIpDetails;
        private RemotePortDetails _remotePortDetails;

        /// <summary>
        /// Gets and sets the property Blocked. 
        /// <para>
        /// Indicates whether EC2 blocked the network connection to your instance.
        /// </para>
        /// </summary>
        public bool? Blocked
        {
            get { return this._blocked; }
            set { this._blocked = value; }
        }

        // Check to see if Blocked property is set
        internal bool IsSetBlocked()
        {
            return this._blocked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionDirection. 
        /// <para>
        /// The network connection direction.
        /// </para>
        /// </summary>
        public string ConnectionDirection
        {
            get { return this._connectionDirection; }
            set { this._connectionDirection = value; }
        }

        // Check to see if ConnectionDirection property is set
        internal bool IsSetConnectionDirection()
        {
            return this._connectionDirection != null;
        }

        /// <summary>
        /// Gets and sets the property LocalIpDetails. 
        /// <para>
        /// The local IP information of the connection.
        /// </para>
        /// </summary>
        public LocalIpDetails LocalIpDetails
        {
            get { return this._localIpDetails; }
            set { this._localIpDetails = value; }
        }

        // Check to see if LocalIpDetails property is set
        internal bool IsSetLocalIpDetails()
        {
            return this._localIpDetails != null;
        }

        /// <summary>
        /// Gets and sets the property LocalNetworkInterface. 
        /// <para>
        /// The EC2 instance's local elastic network interface utilized for the connection.
        /// </para>
        /// </summary>
        public string LocalNetworkInterface
        {
            get { return this._localNetworkInterface; }
            set { this._localNetworkInterface = value; }
        }

        // Check to see if LocalNetworkInterface property is set
        internal bool IsSetLocalNetworkInterface()
        {
            return this._localNetworkInterface != null;
        }

        /// <summary>
        /// Gets and sets the property LocalPortDetails. 
        /// <para>
        /// The local port information of the connection.
        /// </para>
        /// </summary>
        public LocalPortDetails LocalPortDetails
        {
            get { return this._localPortDetails; }
            set { this._localPortDetails = value; }
        }

        // Check to see if LocalPortDetails property is set
        internal bool IsSetLocalPortDetails()
        {
            return this._localPortDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The network connection protocol.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIpDetails. 
        /// <para>
        /// The remote IP information of the connection.
        /// </para>
        /// </summary>
        public RemoteIpDetails RemoteIpDetails
        {
            get { return this._remoteIpDetails; }
            set { this._remoteIpDetails = value; }
        }

        // Check to see if RemoteIpDetails property is set
        internal bool IsSetRemoteIpDetails()
        {
            return this._remoteIpDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RemotePortDetails. 
        /// <para>
        /// The remote port information of the connection.
        /// </para>
        /// </summary>
        public RemotePortDetails RemotePortDetails
        {
            get { return this._remotePortDetails; }
            set { this._remotePortDetails = value; }
        }

        // Check to see if RemotePortDetails property is set
        internal bool IsSetRemotePortDetails()
        {
            return this._remotePortDetails != null;
        }

    }
}