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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Amazon EC2 VPN connection.
    /// </summary>
    public partial class AwsEc2VpnConnectionDetails
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the VPN connection. <c>VPN</c> indicates an Amazon Web Services VPN
        /// connection. <c>VPN-Classic</c> indicates an Amazon Web Services Classic VPN connection.
        /// </para>
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CustomerGatewayConfiguration. 
        /// <para>
        /// The configuration information for the VPN connection's customer gateway, in the native
        /// XML format.
        /// </para>
        /// </summary>
        public string CustomerGatewayConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayConfiguration() => this.CustomerGatewayConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The identifier of the customer gateway that is at your end of the VPN connection.
        /// </para>
        /// </summary>
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayId property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayId() => this.CustomerGatewayId != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The VPN connection options.
        /// </para>
        /// </summary>
        public AwsEc2VpnConnectionOptionsDetails Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The static routes that are associated with the VPN connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2VpnConnectionRoutesDetails> Routes { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2VpnConnectionRoutesDetails>() : null;

        /// <summary>
        /// Checks to see if the Routes property is set.
        /// </summary>
        internal bool IsSetRoutes() => this.Routes != null && (this.Routes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPN connection. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>available</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The identifier of the transit gateway that is associated with the VPN connection.
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
        public string Type { get; set; }

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
        public List<AwsEc2VpnConnectionVgwTelemetryDetails> VgwTelemetry { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2VpnConnectionVgwTelemetryDetails>() : null;

        /// <summary>
        /// Checks to see if the VgwTelemetry property is set.
        /// </summary>
        internal bool IsSetVgwTelemetry() => this.VgwTelemetry != null && (this.VgwTelemetry.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The identifier of the VPN connection.
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
        /// The identifier of the virtual private gateway that is at the Amazon Web Services side
        /// of the VPN connection.
        /// </para>
        /// </summary>
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VpnGatewayId property is set.
        /// </summary>
        internal bool IsSetVpnGatewayId() => this.VpnGatewayId != null;
    }
}
