/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Attaches a VPN gateway to a VPC. This is the last step
    /// required to get your VPC fully connected to your data center
    /// before launching instances in it. For more information, go to
    /// Process for Using Amazon VPC in the Amazon Virtual Private Cloud
    /// Developer Guide.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AttachVpnGatewayRequest
    {    
        private string vpnGatewayIdField;
        private string vpcIdField;

        /// <summary>
        /// Gets and sets the VpnGatewayId property.
        /// The ID of the VPN gateway you want to attach
        /// to the VPC.
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
        /// <param name="vpnGatewayId">The ID of the VPN gateway you want to attach
        /// to the VPC.</param>
        /// <returns>this instance</returns>
        public AttachVpnGatewayRequest WithVpnGatewayId(string vpnGatewayId)
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
        /// Gets and sets the VpcId property.
        /// The ID of the VPC you want to attach to the
        /// VPN gateway
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The ID of the VPC you want to attach to the
        /// VPN gateway</param>
        /// <returns>this instance</returns>
        public AttachVpnGatewayRequest WithVpcId(string vpcId)
        {
            this.vpcIdField = vpcId;
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return this.vpcIdField != null;
        }

    }
}
