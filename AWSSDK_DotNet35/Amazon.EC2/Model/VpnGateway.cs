/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The VpnGateway data type. </para>
    /// </summary>
    public class VpnGateway
    {
        
        private string vpnGatewayId;
        private VpnState state;
        private GatewayType type;
        private string availabilityZone;
        private List<VpcAttachment> vpcAttachments = new List<VpcAttachment>();
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// Specifies the ID of the VPN gateway.
        ///  
        /// </summary>
        public string VpnGatewayId
        {
            get { return this.vpnGatewayId; }
            set { this.vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this.vpnGatewayId != null;
        }

        /// <summary>
        /// Describes the current state of the VPN gateway. Valid values are <c>pending</c>, <c>available</c>, <c>deleting</c>, and <c>deleted</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, available, deleting, deleted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VpnState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// Specifies the type of VPN connection the VPN gateway supports.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ipsec.1</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public GatewayType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// Specifies the Availability Zone where the VPN gateway was created.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// Contains information about the VPCs attached to the VPN gateway.
        ///  
        /// </summary>
        public List<VpcAttachment> VpcAttachments
        {
            get { return this.vpcAttachments; }
            set { this.vpcAttachments = value; }
        }

        // Check to see if VpcAttachments property is set
        internal bool IsSetVpcAttachments()
        {
            return this.vpcAttachments.Count > 0;
        }

        /// <summary>
        /// A list of tags for the VpnGateway.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
