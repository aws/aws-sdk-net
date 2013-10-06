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
    /// Detaches a VPN gateway from a VPC.
    /// </summary>
    /// <remarks>
    /// You do this if you're planning to turn off the VPC and
    /// not use it anymore. You can confirm a VPN gateway has
    /// been completely detached from a VPC by describing the
    /// VPN gateway (any attachments to the VPN gateway are
    /// also described).
    ///
    /// You must wait for the attachment's state to switch
    /// to detached before you can delete the VPC
    /// or attach a different VPC to the VPN gateway.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DetachVpnGatewayRequest : EC2Request
    {    
        private string vpnGatewayIdField;
        private string vpcIdField;

        /// <summary>
        /// The ID of the VPN gateway you want to detach from the VPC
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public string VpnGatewayId
        {
            get { return this.vpnGatewayIdField; }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN gateway you want to detach from the VPC
        /// </summary>
        /// <param name="vpnGatewayId">The ID of the VPN gateway you want to detach
        /// from the VPC</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DetachVpnGatewayRequest WithVpnGatewayId(string vpnGatewayId)
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
        /// The ID of the VPC you want to detach the VPN gateway from.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public string VpcId
        {
            get { return this.vpcIdField; }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPC you want to detach the VPN gateway from.
        /// </summary>
        /// <param name="vpcId">The ID of the VPC you want to detach the VPN
        /// gateway from.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DetachVpnGatewayRequest WithVpcId(string vpcId)
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
