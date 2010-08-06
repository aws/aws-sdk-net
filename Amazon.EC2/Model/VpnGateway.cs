/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///VPN Gateway
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class VpnGateway
    {    
        private string vpnGatewayIdField;
        private string vpnGatewayStateField;
        private string typeField;
        private string availabilityZoneField;
        private List<VpcAttachment> vpcAttachmentField;

        /// <summary>
        /// Gets and sets the VpnGatewayId property.
        /// The ID of the VPN gateway
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public string VpnGatewayId
        {
            get { return this.vpnGatewayIdField; }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the VpnGatewayId property
        /// </summary>
        /// <param name="vpnGatewayId">The ID of the VPN gateway</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the VpnGatewayState property.
        /// The current state of the VPN gateway (pending,
        /// available, deleting, deleted)
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayState")]
        public string VpnGatewayState
        {
            get { return this.vpnGatewayStateField; }
            set { this.vpnGatewayStateField = value; }
        }

        /// <summary>
        /// Sets the VpnGatewayState property
        /// </summary>
        /// <param name="vpnGatewayState">The current state of the VPN gateway (pending,
        /// available, deleting, deleted)</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Type property.
        /// The type of VPN connection the VPN gateway supports (ipsec.1)
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The type of VPN connection the VPN gateway supports (ipsec.1)</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the AvailabilityZone property.
        /// The Availability Zone where the VPN gateway was created
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone where the VPN gateway was created</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the VpcAttachment property.
        /// list of VPC attachments
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
        /// Sets the VpcAttachment property
        /// </summary>
        /// <param name="list">list of VPC attachments</param>
        /// <returns>this instance</returns>
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

    }
}
