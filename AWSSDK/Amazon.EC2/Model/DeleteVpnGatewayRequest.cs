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
    /// Deletes a VPN gateway.
    /// </summary>
    /// <remarks>
    /// Use this when you want to delete a VPC and all its
    /// associated components because you no longer need them. We recommend
    /// that before you delete a VPN gateway, you detach it from the VPC
    /// and delete the VPN connection. Note that you don't need to delete
    /// the VPN gateway if you just want to delete and re-create the VPN
    /// connection between your VPC and data center.
    ///
    /// AWS might delete any VPN gateway if you leave it inactive for an
    /// extended period of time (inactive means that there's no VPN
    /// connection in use with the VPN gateway).
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteVpnGatewayRequest
    {    
        private string vpnGatewayIdField;

        /// <summary>
        /// The ID of the VPN gateway you want to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public string VpnGatewayId
        {
            get { return this.vpnGatewayIdField; }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN gateway you want to delete.
        /// </summary>
        /// <param name="vpnGatewayId">The ID of the VPN gateway you want to delete.</param>
        /// <returns>this instance</returns>
        public DeleteVpnGatewayRequest WithVpnGatewayId(string vpnGatewayId)
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

    }
}
