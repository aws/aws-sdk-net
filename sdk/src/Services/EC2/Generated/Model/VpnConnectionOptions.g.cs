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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes VPN connection options.
    /// </summary>
    public partial class VpnConnectionOptions
    {
        /// <summary>
        /// Gets and sets the property EnableAcceleration. 
        /// <para>
        /// Indicates whether acceleration is enabled for the VPN connection.
        /// </para>
        /// </summary>
        public bool? EnableAcceleration { get; set; }

        /// <summary>
        /// Checks to see if the EnableAcceleration property is set.
        /// </summary>
        internal bool IsSetEnableAcceleration() => this.EnableAcceleration.HasValue;

        /// <summary>
        /// Gets and sets the property LocalIpv4NetworkCidr. 
        /// <para>
        /// The IPv4 CIDR on the customer gateway (on-premises) side of the VPN connection.
        /// </para>
        /// </summary>
        public string LocalIpv4NetworkCidr { get; set; }

        /// <summary>
        /// Checks to see if the LocalIpv4NetworkCidr property is set.
        /// </summary>
        internal bool IsSetLocalIpv4NetworkCidr() => this.LocalIpv4NetworkCidr != null;

        /// <summary>
        /// Gets and sets the property LocalIpv6NetworkCidr. 
        /// <para>
        /// The IPv6 CIDR on the customer gateway (on-premises) side of the VPN connection.
        /// </para>
        /// </summary>
        public string LocalIpv6NetworkCidr { get; set; }

        /// <summary>
        /// Checks to see if the LocalIpv6NetworkCidr property is set.
        /// </summary>
        internal bool IsSetLocalIpv6NetworkCidr() => this.LocalIpv6NetworkCidr != null;

        /// <summary>
        /// Gets and sets the property OutsideIpAddressType. 
        /// <para>
        /// The type of IPv4 address assigned to the outside interface of the customer gateway.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>PrivateIpv4</c> | <c>PublicIpv4</c> | <c>Ipv6</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>PublicIpv4</c> 
        /// </para>
        /// </summary>
        public string OutsideIpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the OutsideIpAddressType property is set.
        /// </summary>
        internal bool IsSetOutsideIpAddressType() => this.OutsideIpAddressType != null;

        /// <summary>
        /// Gets and sets the property RemoteIpv4NetworkCidr. 
        /// <para>
        /// The IPv4 CIDR on the Amazon Web Services side of the VPN connection.
        /// </para>
        /// </summary>
        public string RemoteIpv4NetworkCidr { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIpv4NetworkCidr property is set.
        /// </summary>
        internal bool IsSetRemoteIpv4NetworkCidr() => this.RemoteIpv4NetworkCidr != null;

        /// <summary>
        /// Gets and sets the property RemoteIpv6NetworkCidr. 
        /// <para>
        /// The IPv6 CIDR on the Amazon Web Services side of the VPN connection.
        /// </para>
        /// </summary>
        public string RemoteIpv6NetworkCidr { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIpv6NetworkCidr property is set.
        /// </summary>
        internal bool IsSetRemoteIpv6NetworkCidr() => this.RemoteIpv6NetworkCidr != null;

        /// <summary>
        /// Gets and sets the property StaticRoutesOnly. 
        /// <para>
        /// Indicates whether the VPN connection uses static routes only. Static routes must be
        /// used for devices that don't support BGP.
        /// </para>
        /// </summary>
        public bool? StaticRoutesOnly { get; set; }

        /// <summary>
        /// Checks to see if the StaticRoutesOnly property is set.
        /// </summary>
        internal bool IsSetStaticRoutesOnly() => this.StaticRoutesOnly.HasValue;

        /// <summary>
        /// Gets and sets the property TransportTransitGatewayAttachmentId. 
        /// <para>
        /// The transit gateway attachment ID in use for the VPN tunnel.
        /// </para>
        /// </summary>
        public string TransportTransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the TransportTransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetTransportTransitGatewayAttachmentId() => this.TransportTransitGatewayAttachmentId != null;

        /// <summary>
        /// Gets and sets the property TunnelBandwidth. 
        /// <para>
        ///  The configured bandwidth for the VPN tunnel. Represents the current throughput capacity
        /// setting for the tunnel connection. <c>standard</c> tunnel bandwidth supports up to
        /// 1.25 Gbps per tunnel while <c>large</c> supports up to 5 Gbps per tunnel. If no tunnel
        /// bandwidth was specified for the connection, <c>standard</c> is used as the default
        /// value. 
        /// </para>
        /// </summary>
        public VpnTunnelBandwidth TunnelBandwidth { get; set; }

        /// <summary>
        /// Checks to see if the TunnelBandwidth property is set.
        /// </summary>
        internal bool IsSetTunnelBandwidth() => this.TunnelBandwidth != null;

        /// <summary>
        /// Gets and sets the property TunnelInsideIpVersion. 
        /// <para>
        /// Indicates whether the VPN tunnels process IPv4 or IPv6 traffic.
        /// </para>
        /// </summary>
        public TunnelInsideIpVersion TunnelInsideIpVersion { get; set; }

        /// <summary>
        /// Checks to see if the TunnelInsideIpVersion property is set.
        /// </summary>
        internal bool IsSetTunnelInsideIpVersion() => this.TunnelInsideIpVersion != null;

        /// <summary>
        /// Gets and sets the property TunnelOptions. 
        /// <para>
        /// Indicates the VPN tunnel options.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TunnelOption> TunnelOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<TunnelOption>() : null;

        /// <summary>
        /// Checks to see if the TunnelOptions property is set.
        /// </summary>
        internal bool IsSetTunnelOptions() => this.TunnelOptions != null && (this.TunnelOptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
