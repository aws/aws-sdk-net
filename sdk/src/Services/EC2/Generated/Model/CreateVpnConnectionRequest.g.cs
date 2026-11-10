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
    /// Container for the parameters to the CreateVpnConnection operation. Creates a VPN connection
    /// between an existing virtual private gateway or transit gateway and a customer gateway.
    /// The supported connection type is <c>ipsec.1</c>. <para> The response includes information
    /// that you need to give to your network administrator to configure your customer gateway.
    /// </para> <important> <para> We strongly recommend that you use HTTPS when calling this
    /// operation because the response contains sensitive cryptographic information for configuring
    /// your customer gateway device. </para> </important> <para> If you decide to shut down
    /// your VPN connection for any reason and later create a new VPN connection, you must
    /// reconfigure your customer gateway with the new information returned from this call.
    /// </para> <para> This is an idempotent operation. If you perform the operation more
    /// than once, Amazon EC2 doesn't return an error. </para> <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon Web
    /// Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
    /// Guide</i>. </para>
    /// </summary>
    public partial class CreateVpnConnectionRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateVpnConnectionRequest() { }

        /// <summary>
        /// Instantiates CreateVpnConnectionRequest with the parameterized properties
        /// </summary>
        /// <param name="type">The type of VPN connection (<c>ipsec.1</c>).</param>
        /// <param name="customerGatewayId">The ID of the customer gateway.</param>
        /// <param name="vpnGatewayId">The ID of the virtual private gateway. If you specify a virtual private gateway, you   cannot specify a transit gateway.</param>
        public CreateVpnConnectionRequest(string type, string customerGatewayId, string vpnGatewayId)
        {
            this.Type = type;
            this.CustomerGatewayId = customerGatewayId;
            this.VpnGatewayId = vpnGatewayId;
        }

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayId property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayId() => this.CustomerGatewayId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options for the VPN connection.
        /// </para>
        /// </summary>
        public VpnConnectionOptionsSpecification Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property PreSharedKeyStorage. 
        /// <para>
        /// Specifies the storage mode for the pre-shared key (PSK). Valid values are <c>Standard</c>"
        /// (stored in the Site-to-Site VPN service) or <c>SecretsManager</c> (stored in Amazon
        /// Web Services Secrets Manager).
        /// </para>
        /// </summary>
        public string PreSharedKeyStorage { get; set; }

        /// <summary>
        /// Checks to see if the PreSharedKeyStorage property is set.
        /// </summary>
        internal bool IsSetPreSharedKeyStorage() => this.PreSharedKeyStorage != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the VPN connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway. If you specify a transit gateway, you cannot specify
        /// a virtual private gateway.
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
        /// The type of VPN connection (<c>ipsec.1</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpnConcentratorId. 
        /// <para>
        /// The ID of the VPN concentrator to associate with the VPN connection.
        /// </para>
        /// </summary>
        public string VpnConcentratorId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConcentratorId property is set.
        /// </summary>
        internal bool IsSetVpnConcentratorId() => this.VpnConcentratorId != null;

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway. If you specify a virtual private gateway, you
        /// cannot specify a transit gateway.
        /// </para>
        /// </summary>
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VpnGatewayId property is set.
        /// </summary>
        internal bool IsSetVpnGatewayId() => this.VpnGatewayId != null;
    }
}
