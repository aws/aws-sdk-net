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
    /// Container for the parameters to the CreateTransitGateway operation. Creates a transit
    /// gateway. <para> You can use a transit gateway to interconnect your virtual private
    /// clouds (VPC) and on-premises networks. After the transit gateway enters the <c>available</c>
    /// state, you can attach your VPCs and VPN connections to the transit gateway. </para>
    /// <para> To attach your VPCs, use <a>CreateTransitGatewayVpcAttachment</a>. </para>
    /// <para> To attach a VPN connection, use <a>CreateCustomerGateway</a> to create a customer
    /// gateway and specify the ID of the customer gateway and the ID of the transit gateway
    /// in a call to <a>CreateVpnConnection</a>. </para> <para> When you create a transit
    /// gateway, we create a default transit gateway route table and use it as the default
    /// association route table and the default propagation route table. You can use <a>CreateTransitGatewayRouteTable</a>
    /// to create additional transit gateway route tables. If you disable automatic route
    /// propagation, we do not create a default transit gateway route table. You can use <a>EnableTransitGatewayRouteTablePropagation</a>
    /// to propagate routes from a resource attachment to a transit gateway route table. If
    /// you disable automatic associations, you can use <a>AssociateTransitGatewayRouteTable</a>
    /// to associate a resource attachment with a transit gateway route table. </para>
    /// </summary>
    public partial class CreateTransitGatewayRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the transit gateway.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// The transit gateway options.
        /// </para>
        /// </summary>
        public TransitGatewayRequestOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the transit gateway.
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
    }
}
