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
    /// Describes a VPN connection.
    /// </summary>
    public partial class VpnConnection
    {
        private string _category;
        private string _coreNetworkArn;
        private string _coreNetworkAttachmentArn;
        private string _customerGatewayConfiguration;
        private string _customerGatewayId;
        private GatewayAssociationState _gatewayAssociationState;
        private VpnConnectionOptions _options;
        private string _preSharedKeyArn;
        private List<VpnStaticRoute> _routes = AWSConfigs.InitializeCollections ? new List<VpnStaticRoute>() : null;
        private VpnState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _transitGatewayId;
        private GatewayType _type;
        private List<VgwTelemetry> _vgwTelemetry = AWSConfigs.InitializeCollections ? new List<VgwTelemetry>() : null;
        private string _vpnConnectionId;
        private string _vpnGatewayId;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the VPN connection. A value of <c>VPN</c> indicates an Amazon Web
        /// Services VPN connection. A value of <c>VPN-Classic</c> indicates an Amazon Web Services
        /// Classic VPN connection.
        /// </para>
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The ARN of the core network.
        /// </para>
        /// </summary>
        public string CoreNetworkArn
        {
            get { return this._coreNetworkArn; }
            set { this._coreNetworkArn = value; }
        }

        // Check to see if CoreNetworkArn property is set
        internal bool IsSetCoreNetworkArn()
        {
            return this._coreNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkAttachmentArn. 
        /// <para>
        /// The ARN of the core network attachment.
        /// </para>
        /// </summary>
        public string CoreNetworkAttachmentArn
        {
            get { return this._coreNetworkAttachmentArn; }
            set { this._coreNetworkAttachmentArn = value; }
        }

        // Check to see if CoreNetworkAttachmentArn property is set
        internal bool IsSetCoreNetworkAttachmentArn()
        {
            return this._coreNetworkAttachmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerGatewayConfiguration. 
        /// <para>
        /// The configuration information for the VPN connection's customer gateway (in the native
        /// XML format). This element is always present in the <a>CreateVpnConnection</a> response;
        /// however, it's present in the <a>DescribeVpnConnections</a> response only if the VPN
        /// connection is in the <c>pending</c> or <c>available</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CustomerGatewayConfiguration
        {
            get { return this._customerGatewayConfiguration; }
            set { this._customerGatewayConfiguration = value; }
        }

        // Check to see if CustomerGatewayConfiguration property is set
        internal bool IsSetCustomerGatewayConfiguration()
        {
            return this._customerGatewayConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway at your end of the VPN connection.
        /// </para>
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this._customerGatewayId; }
            set { this._customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this._customerGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayAssociationState. 
        /// <para>
        /// The current state of the gateway association.
        /// </para>
        /// </summary>
        public GatewayAssociationState GatewayAssociationState
        {
            get { return this._gatewayAssociationState; }
            set { this._gatewayAssociationState = value; }
        }

        // Check to see if GatewayAssociationState property is set
        internal bool IsSetGatewayAssociationState()
        {
            return this._gatewayAssociationState != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The VPN connection options.
        /// </para>
        /// </summary>
        public VpnConnectionOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property PreSharedKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret storing the pre-shared
        /// key(s) for the VPN connection.
        /// </para>
        /// </summary>
        public string PreSharedKeyArn
        {
            get { return this._preSharedKeyArn; }
            set { this._preSharedKeyArn = value; }
        }

        // Check to see if PreSharedKeyArn property is set
        internal bool IsSetPreSharedKeyArn()
        {
            return this._preSharedKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The static routes associated with the VPN connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpnStaticRoute> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && (this._routes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPN connection.
        /// </para>
        /// </summary>
        public VpnState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the VPN connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway associated with the VPN connection.
        /// </para>
        /// </summary>
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection.
        /// </para>
        /// </summary>
        public GatewayType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VgwTelemetry. 
        /// <para>
        /// Information about the VPN tunnel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VgwTelemetry> VgwTelemetry
        {
            get { return this._vgwTelemetry; }
            set { this._vgwTelemetry = value; }
        }

        // Check to see if VgwTelemetry property is set
        internal bool IsSetVgwTelemetry()
        {
            return this._vgwTelemetry != null && (this._vgwTelemetry.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the VPN connection.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway at the Amazon Web Services side of the VPN connection.
        /// </para>
        /// </summary>
        public string VpnGatewayId
        {
            get { return this._vpnGatewayId; }
            set { this._vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this._vpnGatewayId != null;
        }

    }
}