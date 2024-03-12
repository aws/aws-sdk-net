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
    /// Describes the options for a VPC attachment.
    /// </summary>
    public partial class CreateTransitGatewayVpcAttachmentRequestOptions
    {
        private ApplianceModeSupportValue _applianceModeSupport;
        private DnsSupportValue _dnsSupport;
        private Ipv6SupportValue _ipv6Support;
        private SecurityGroupReferencingSupportValue _securityGroupReferencingSupport;

        /// <summary>
        /// Gets and sets the property ApplianceModeSupport. 
        /// <para>
        /// Enable or disable support for appliance mode. If enabled, a traffic flow between a
        /// source and destination uses the same Availability Zone for the VPC attachment for
        /// the lifetime of that flow. The default is <c>disable</c>.
        /// </para>
        /// </summary>
        public ApplianceModeSupportValue ApplianceModeSupport
        {
            get { return this._applianceModeSupport; }
            set { this._applianceModeSupport = value; }
        }

        // Check to see if ApplianceModeSupport property is set
        internal bool IsSetApplianceModeSupport()
        {
            return this._applianceModeSupport != null;
        }

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Enable or disable DNS support. The default is <c>enable</c>.
        /// </para>
        /// </summary>
        public DnsSupportValue DnsSupport
        {
            get { return this._dnsSupport; }
            set { this._dnsSupport = value; }
        }

        // Check to see if DnsSupport property is set
        internal bool IsSetDnsSupport()
        {
            return this._dnsSupport != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Support. 
        /// <para>
        /// Enable or disable IPv6 support. The default is <c>disable</c>.
        /// </para>
        /// </summary>
        public Ipv6SupportValue Ipv6Support
        {
            get { return this._ipv6Support; }
            set { this._ipv6Support = value; }
        }

        // Check to see if Ipv6Support property is set
        internal bool IsSetIpv6Support()
        {
            return this._ipv6Support != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupReferencingSupport. <note> 
        /// <para>
        /// This parameter is in preview and may not be available for your account.
        /// </para>
        ///  </note> 
        /// <para>
        /// Enables you to reference a security group across VPCs attached to a transit gateway.
        /// Use this option to simplify security group management and control of instance-to-instance
        /// traffic across VPCs that are connected by transit gateway. You can also use this option
        /// to migrate from VPC peering (which was the only option that supported security group
        /// referencing) to transit gateways (which now also support security group referencing).
        /// This option is disabled by default and there are no additional costs to use this feature.
        /// </para>
        ///  
        /// <para>
        /// If you don't enable or disable SecurityGroupReferencingSupport in the request, the
        /// attachment will inherit the security group referencing support setting on the transit
        /// gateway.
        /// </para>
        /// </summary>
        public SecurityGroupReferencingSupportValue SecurityGroupReferencingSupport
        {
            get { return this._securityGroupReferencingSupport; }
            set { this._securityGroupReferencingSupport = value; }
        }

        // Check to see if SecurityGroupReferencingSupport property is set
        internal bool IsSetSecurityGroupReferencingSupport()
        {
            return this._securityGroupReferencingSupport != null;
        }

    }
}