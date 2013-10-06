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
    /// Deletes a VPN connection.
    /// </summary>
    /// <remarks>
    /// This operation will delete a VPC and all its associated components.
    /// Another reason to use this operation is if you believe the tunnel
    /// credentials for your VPN connection have been compromised.
    ///
    /// In that situation, you can delete the VPN connection and create a
    /// new one that has new keys, without needing to delete
    /// the VPC or VPN gateway. If you create a new VPN
    /// connection, you must reconfigure the customer
    /// gateway using the new configuration information returned
    /// with the new VPN connection ID.
    ///
    /// If you're deleting the VPC and all its associated parts, we
    /// recommend you detach the VPN gateway from the
    /// VPC and delete the VPC before deleting the VPN
    /// connection.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DeleteVpnConnectionRequest : EC2Request
    {    
        private string vpnConnectionIdField;

        /// <summary>
        /// The ID of the VPN connection you want to delete.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnectionId")]
        public string VpnConnectionId
        {
            get { return this.vpnConnectionIdField; }
            set { this.vpnConnectionIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN connection you want to delete.
        /// </summary>
        /// <param name="vpnConnectionId">The ID of the VPN connection you want to
        /// delete.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteVpnConnectionRequest WithVpnConnectionId(string vpnConnectionId)
        {
            this.vpnConnectionIdField = vpnConnectionId;
            return this;
        }

        /// <summary>
        /// Checks if VpnConnectionId property is set
        /// </summary>
        /// <returns>true if VpnConnectionId property is set</returns>
        public bool IsSetVpnConnectionId()
        {
            return this.vpnConnectionIdField != null;
        }

    }
}
