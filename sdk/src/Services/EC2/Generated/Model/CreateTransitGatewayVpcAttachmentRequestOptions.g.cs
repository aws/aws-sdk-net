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
    /// Describes the options for a VPC attachment.
    /// </summary>
    public partial class CreateTransitGatewayVpcAttachmentRequestOptions
    {
        /// <summary>
        /// Gets and sets the property ApplianceModeSupport. 
        /// <para>
        /// Enable or disable support for appliance mode. If enabled, a traffic flow between a
        /// source and destination uses the same Availability Zone for the VPC attachment for
        /// the lifetime of that flow. The default is <c>disable</c>.
        /// </para>
        /// </summary>
        public ApplianceModeSupportValue ApplianceModeSupport { get; set; }

        /// <summary>
        /// Checks to see if the ApplianceModeSupport property is set.
        /// </summary>
        internal bool IsSetApplianceModeSupport() => this.ApplianceModeSupport != null;

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Enable or disable DNS support. The default is <c>enable</c>.
        /// </para>
        /// </summary>
        public DnsSupportValue DnsSupport { get; set; }

        /// <summary>
        /// Checks to see if the DnsSupport property is set.
        /// </summary>
        internal bool IsSetDnsSupport() => this.DnsSupport != null;

        /// <summary>
        /// Gets and sets the property Ipv6Support. 
        /// <para>
        /// Specifies whether IPv6 support is enabled for the attachment. When enabled, the transit
        /// gateway network interface receives an IPv6 address. When you enable route propagation,
        /// IPv6 VPC CIDRs propagate to the transit gateway route tables. When disabled, the network
        /// interface does not receive an IPv6 address, and IPv6 routes do not propagate. The
        /// setting does not filter IPv6 traffic. The default is <c>disable</c>.
        /// </para>
        /// </summary>
        public Ipv6SupportValue Ipv6Support { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Support property is set.
        /// </summary>
        internal bool IsSetIpv6Support() => this.Ipv6Support != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupReferencingSupport. 
        /// <para>
        /// Enables you to reference a security group across VPCs attached to a transit gateway
        /// to simplify security group management.
        /// </para>
        ///  
        /// <para>
        /// This option is set to <c>enable</c> by default. However, at the transit gateway level
        /// the default is set to <c>disable</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about security group referencing, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-vpc-attachments.html#vpc-attachment-security">Security
        /// group referencing </a> in the <i>Amazon Web Services Transit Gateways Guide</i>.
        /// </para>
        /// </summary>
        public SecurityGroupReferencingSupportValue SecurityGroupReferencingSupport { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupReferencingSupport property is set.
        /// </summary>
        internal bool IsSetSecurityGroupReferencingSupport() => this.SecurityGroupReferencingSupport != null;
    }
}
