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
    /// Describes VPN connection options.
    /// </summary>
    public partial class VpnConnectionOptionsSpecification
    {
        private bool? _enableAcceleration;
        private string _localIpv4NetworkCidr;
        private string _localIpv6NetworkCidr;
        private string _remoteIpv4NetworkCidr;
        private string _remoteIpv6NetworkCidr;
        private bool? _staticRoutesOnly;
        private TunnelInsideIpVersion _tunnelInsideIpVersion;
        private List<VpnTunnelOptionsSpecification> _tunnelOptions = new List<VpnTunnelOptionsSpecification>();

        /// <summary>
        /// Gets and sets the property EnableAcceleration. 
        /// <para>
        /// Indicate whether to enable acceleration for the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool EnableAcceleration
        {
            get { return this._enableAcceleration.GetValueOrDefault(); }
            set { this._enableAcceleration = value; }
        }

        // Check to see if EnableAcceleration property is set
        internal bool IsSetEnableAcceleration()
        {
            return this._enableAcceleration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalIpv4NetworkCidr. 
        /// <para>
        /// The IPv4 CIDR on the customer gateway (on-premises) side of the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>0.0.0.0/0</code> 
        /// </para>
        /// </summary>
        public string LocalIpv4NetworkCidr
        {
            get { return this._localIpv4NetworkCidr; }
            set { this._localIpv4NetworkCidr = value; }
        }

        // Check to see if LocalIpv4NetworkCidr property is set
        internal bool IsSetLocalIpv4NetworkCidr()
        {
            return this._localIpv4NetworkCidr != null;
        }

        /// <summary>
        /// Gets and sets the property LocalIpv6NetworkCidr. 
        /// <para>
        /// The IPv6 CIDR on the customer gateway (on-premises) side of the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>::/0</code> 
        /// </para>
        /// </summary>
        public string LocalIpv6NetworkCidr
        {
            get { return this._localIpv6NetworkCidr; }
            set { this._localIpv6NetworkCidr = value; }
        }

        // Check to see if LocalIpv6NetworkCidr property is set
        internal bool IsSetLocalIpv6NetworkCidr()
        {
            return this._localIpv6NetworkCidr != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIpv4NetworkCidr. 
        /// <para>
        /// The IPv4 CIDR on the AWS side of the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>0.0.0.0/0</code> 
        /// </para>
        /// </summary>
        public string RemoteIpv4NetworkCidr
        {
            get { return this._remoteIpv4NetworkCidr; }
            set { this._remoteIpv4NetworkCidr = value; }
        }

        // Check to see if RemoteIpv4NetworkCidr property is set
        internal bool IsSetRemoteIpv4NetworkCidr()
        {
            return this._remoteIpv4NetworkCidr != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIpv6NetworkCidr. 
        /// <para>
        /// The IPv6 CIDR on the AWS side of the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>::/0</code> 
        /// </para>
        /// </summary>
        public string RemoteIpv6NetworkCidr
        {
            get { return this._remoteIpv6NetworkCidr; }
            set { this._remoteIpv6NetworkCidr = value; }
        }

        // Check to see if RemoteIpv6NetworkCidr property is set
        internal bool IsSetRemoteIpv6NetworkCidr()
        {
            return this._remoteIpv6NetworkCidr != null;
        }

        /// <summary>
        /// Gets and sets the property StaticRoutesOnly. 
        /// <para>
        /// Indicate whether the VPN connection uses static routes only. If you are creating a
        /// VPN connection for a device that does not support BGP, you must specify <code>true</code>.
        /// Use <a>CreateVpnConnectionRoute</a> to create a static route.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool StaticRoutesOnly
        {
            get { return this._staticRoutesOnly.GetValueOrDefault(); }
            set { this._staticRoutesOnly = value; }
        }

        // Check to see if StaticRoutesOnly property is set
        internal bool IsSetStaticRoutesOnly()
        {
            return this._staticRoutesOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TunnelInsideIpVersion. 
        /// <para>
        /// Indicate whether the VPN tunnels process IPv4 or IPv6 traffic.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>ipv4</code> 
        /// </para>
        /// </summary>
        public TunnelInsideIpVersion TunnelInsideIpVersion
        {
            get { return this._tunnelInsideIpVersion; }
            set { this._tunnelInsideIpVersion = value; }
        }

        // Check to see if TunnelInsideIpVersion property is set
        internal bool IsSetTunnelInsideIpVersion()
        {
            return this._tunnelInsideIpVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelOptions. 
        /// <para>
        /// The tunnel options for the VPN connection.
        /// </para>
        /// </summary>
        public List<VpnTunnelOptionsSpecification> TunnelOptions
        {
            get { return this._tunnelOptions; }
            set { this._tunnelOptions = value; }
        }

        // Check to see if TunnelOptions property is set
        internal bool IsSetTunnelOptions()
        {
            return this._tunnelOptions != null && this._tunnelOptions.Count > 0; 
        }

    }
}