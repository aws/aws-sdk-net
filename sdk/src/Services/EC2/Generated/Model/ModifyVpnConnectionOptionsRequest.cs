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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpnConnectionOptions operation.
    /// Modifies the connection options for your Site-to-Site VPN connection.
    /// 
    ///  
    /// <para>
    /// When you modify the VPN connection options, the VPN endpoint IP addresses on the Amazon
    /// Web Services side do not change, and the tunnel options do not change. Your VPN connection
    /// will be temporarily unavailable for a brief period while the VPN connection is updated.
    /// </para>
    /// </summary>
    public partial class ModifyVpnConnectionOptionsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _localIpv4NetworkCidr;
        private string _localIpv6NetworkCidr;
        private string _remoteIpv4NetworkCidr;
        private string _remoteIpv6NetworkCidr;
        private string _vpnConnectionId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalIpv4NetworkCidr. 
        /// <para>
        /// The IPv4 CIDR on the customer gateway (on-premises) side of the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0.0.0.0/0</c> 
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
        /// Default: <c>::/0</c> 
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
        /// The IPv4 CIDR on the Amazon Web Services side of the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0.0.0.0/0</c> 
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
        /// The IPv6 CIDR on the Amazon Web Services side of the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>::/0</c> 
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
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the Site-to-Site VPN connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpnConnectionId
        {
            get { return this._vpnConnectionId; }
            set { this._vpnConnectionId = value; }
        }

        // Check to see if VpnConnectionId property is set
        internal bool IsSetVpnConnectionId()
        {
            return this._vpnConnectionId != null;
        }

    }
}