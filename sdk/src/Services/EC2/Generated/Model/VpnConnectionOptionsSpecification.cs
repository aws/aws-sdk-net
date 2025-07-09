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
    /// Describes VPN connection options.
    /// </summary>
    public partial class VpnConnectionOptionsSpecification
    {
        private bool? _enableAcceleration;
        private string _localIpv4NetworkCidr;
        private string _localIpv6NetworkCidr;
        private string _outsideIpAddressType;
        private string _remoteIpv4NetworkCidr;
        private string _remoteIpv6NetworkCidr;
        private bool? _staticRoutesOnly;
        private string _transportTransitGatewayAttachmentId;
        private TunnelInsideIpVersion _tunnelInsideIpVersion;
        private List<VpnTunnelOptionsSpecification> _tunnelOptions = AWSConfigs.InitializeCollections ? new List<VpnTunnelOptionsSpecification>() : null;

        /// <summary>
        /// Gets and sets the property EnableAcceleration. 
        /// <para>
        /// Indicate whether to enable acceleration for the VPN connection.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? EnableAcceleration
        {
            get { return this._enableAcceleration; }
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
        /// Gets and sets the property OutsideIpAddressType. 
        /// <para>
        /// The type of IP address assigned to the outside interface of the customer gateway device.
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
        public string OutsideIpAddressType
        {
            get { return this._outsideIpAddressType; }
            set { this._outsideIpAddressType = value; }
        }

        // Check to see if OutsideIpAddressType property is set
        internal bool IsSetOutsideIpAddressType()
        {
            return this._outsideIpAddressType != null;
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
        /// Gets and sets the property StaticRoutesOnly. 
        /// <para>
        /// Indicate whether the VPN connection uses static routes only. If you are creating a
        /// VPN connection for a device that does not support BGP, you must specify <c>true</c>.
        /// Use <a>CreateVpnConnectionRoute</a> to create a static route.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? StaticRoutesOnly
        {
            get { return this._staticRoutesOnly; }
            set { this._staticRoutesOnly = value; }
        }

        // Check to see if StaticRoutesOnly property is set
        internal bool IsSetStaticRoutesOnly()
        {
            return this._staticRoutesOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransportTransitGatewayAttachmentId. 
        /// <para>
        /// The transit gateway attachment ID to use for the VPN tunnel.
        /// </para>
        ///  
        /// <para>
        /// Required if <c>OutsideIpAddressType</c> is set to <c>PrivateIpv4</c>.
        /// </para>
        /// </summary>
        public string TransportTransitGatewayAttachmentId
        {
            get { return this._transportTransitGatewayAttachmentId; }
            set { this._transportTransitGatewayAttachmentId = value; }
        }

        // Check to see if TransportTransitGatewayAttachmentId property is set
        internal bool IsSetTransportTransitGatewayAttachmentId()
        {
            return this._transportTransitGatewayAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelInsideIpVersion. 
        /// <para>
        /// Indicate whether the VPN tunnels process IPv4 or IPv6 traffic.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>ipv4</c> 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpnTunnelOptionsSpecification> TunnelOptions
        {
            get { return this._tunnelOptions; }
            set { this._tunnelOptions = value; }
        }

        // Check to see if TunnelOptions property is set
        internal bool IsSetTunnelOptions()
        {
            return this._tunnelOptions != null && (this._tunnelOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}