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
    /// Describes a VPN connection.
    /// </summary>
    public partial class VpnConnection
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the VPN connection. A value of <c>VPN</c> indicates an Amazon Web
        /// Services VPN connection. A value of <c>VPN-Classic</c> indicates an Amazon Web Services
        /// Classic VPN connection.
        /// </para>
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The ARN of the core network.
        /// </para>
        /// </summary>
        public string CoreNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkArn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkArn() => this.CoreNetworkArn != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkAttachmentArn. 
        /// <para>
        /// The ARN of the core network attachment.
        /// </para>
        /// </summary>
        public string CoreNetworkAttachmentArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkAttachmentArn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkAttachmentArn() => this.CoreNetworkAttachmentArn != null;

        /// <summary>
        /// Gets and sets the property CustomerGatewayConfiguration. 
        /// <para>
        /// The configuration information for the VPN connection's customer gateway (in the native
        /// XML format). This element is always present in the <a>CreateVpnConnection</a> response;
        /// however, it's present in the <a>DescribeVpnConnections</a> response only if the VPN
        /// connection is in the <c>pending</c> or <c>available</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string CustomerGatewayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayConfiguration() => this.CustomerGatewayConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway at your end of the VPN connection.
        /// </para>
        /// </summary>
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayId property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayId() => this.CustomerGatewayId != null;

        /// <summary>
        /// Gets and sets the property GatewayAssociationState. 
        /// <para>
        /// The current state of the gateway association.
        /// </para>
        /// </summary>
        public GatewayAssociationState GatewayAssociationState { get; set; }

        /// <summary>
        /// Checks to see if the GatewayAssociationState property is set.
        /// </summary>
        internal bool IsSetGatewayAssociationState() => this.GatewayAssociationState != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The VPN connection options.
        /// </para>
        /// </summary>
        public VpnConnectionOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property PreSharedKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret storing the pre-shared
        /// key(s) for the VPN connection.
        /// </para>
        /// </summary>
        public string PreSharedKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the PreSharedKeyArn property is set.
        /// </summary>
        internal bool IsSetPreSharedKeyArn() => this.PreSharedKeyArn != null;

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The static routes associated with the VPN connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpnStaticRoute> Routes { get; set; } = AWSConfigs.InitializeCollections ? new List<VpnStaticRoute>() : null;

        /// <summary>
        /// Checks to see if the Routes property is set.
        /// </summary>
        internal bool IsSetRoutes() => this.Routes != null && (this.Routes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPN connection.
        /// </para>
        /// </summary>
        public VpnState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the VPN connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway associated with the VPN connection.
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection.
        /// </para>
        /// </summary>
        public GatewayType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VgwTelemetry. 
        /// <para>
        /// Information about the VPN tunnel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VgwTelemetry> VgwTelemetry { get; set; } = AWSConfigs.InitializeCollections ? new List<VgwTelemetry>() : null;

        /// <summary>
        /// Checks to see if the VgwTelemetry property is set.
        /// </summary>
        internal bool IsSetVgwTelemetry() => this.VgwTelemetry != null && (this.VgwTelemetry.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpnConcentratorId. 
        /// <para>
        /// The ID of the VPN concentrator associated with the VPN connection.
        /// </para>
        /// </summary>
        public string VpnConcentratorId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConcentratorId property is set.
        /// </summary>
        internal bool IsSetVpnConcentratorId() => this.VpnConcentratorId != null;

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the VPN connection.
        /// </para>
        /// </summary>
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnectionId property is set.
        /// </summary>
        internal bool IsSetVpnConnectionId() => this.VpnConnectionId != null;

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway at the Amazon Web Services side of the VPN connection.
        /// </para>
        /// </summary>
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VpnGatewayId property is set.
        /// </summary>
        internal bool IsSetVpnGatewayId() => this.VpnGatewayId != null;
    }
}
