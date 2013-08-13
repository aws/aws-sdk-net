/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// VPN Gateway
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class VpnGateway
    {    
        private string vpnGatewayIdField;
        private string vpnGatewayStateField;
        private string typeField;
        private string availabilityZoneField;
        private List<VpcAttachment> vpcAttachmentField;
        private List<Tag> tagField;

        /// <summary>
        /// The ID of the VPN gateway
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public string VpnGatewayId
        {
            get { return this.vpnGatewayIdField; }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN gateway
        /// </summary>
        /// <param name="vpnGatewayId">The ID of the VPN gateway</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnGateway WithVpnGatewayId(string vpnGatewayId)
        {
            this.vpnGatewayIdField = vpnGatewayId;
            return this;
        }

        /// <summary>
        /// Checks if VpnGatewayId property is set
        /// </summary>
        /// <returns>true if VpnGatewayId property is set</returns>
        public bool IsSetVpnGatewayId()
        {
            return this.vpnGatewayIdField != null;
        }

        /// <summary>
        /// The current state of the VPN gateway.
        /// Valid values: pending, available, deleting, deleted
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayState")]
        public string VpnGatewayState
        {
            get { return this.vpnGatewayStateField; }
            set { this.vpnGatewayStateField = value; }
        }

        /// <summary>
        /// Sets the current state of the VPN gateway.
        /// </summary>
        /// <param name="vpnGatewayState">The current state of the VPN gateway (pending,
        /// available, deleting, deleted)</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnGateway WithVpnGatewayState(string vpnGatewayState)
        {
            this.vpnGatewayStateField = vpnGatewayState;
            return this;
        }

        /// <summary>
        /// Checks if VpnGatewayState property is set
        /// </summary>
        /// <returns>true if VpnGatewayState property is set</returns>
        public bool IsSetVpnGatewayState()
        {
            return this.vpnGatewayStateField != null;
        }

        /// <summary>
        /// The type of VPN connection the VPN gateway supports (ipsec.1)
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the type of VPN connection the VPN gateway supports
        /// </summary>
        /// <param name="type">The type of VPN connection the VPN gateway supports (ipsec.1)</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnGateway WithType(string type)
        {
            this.typeField = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public bool IsSetType()
        {
            return this.typeField != null;
        }

        /// <summary>
        /// The Availability Zone where the VPN gateway was created
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone where the VPN gateway was created
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone where the VPN gateway was created</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnGateway WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// List of VPC attachments.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcAttachment")]
        public List<VpcAttachment> VpcAttachment
        {
            get
            {
                if (this.vpcAttachmentField == null)
                {
                    this.vpcAttachmentField = new List<VpcAttachment>();
                }
                return this.vpcAttachmentField;
            }
            set { this.vpcAttachmentField = value; }
        }

        /// <summary>
        /// Sets the list of VPC attachments.
        /// </summary>
        /// <param name="list">list of VPC attachments</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnGateway WithVpcAttachment(params VpcAttachment[] list)
        {
            foreach (VpcAttachment item in list)
            {
                VpcAttachment.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VpcAttachment property is set
        /// </summary>
        /// <returns>true if VpcAttachment property is set</returns>
        public bool IsSetVpcAttachment()
        {
            return (VpcAttachment.Count > 0);
        }

        /// <summary>
        /// A list of tags for the VpnGateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets a list of tags for the VpnGateway.
        /// </summary>
        /// <param name="list">A list of tags for the VpnGateway.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnGateway WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

    }
}
