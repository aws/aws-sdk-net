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

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Unassigns one or more secondary private IP addresses from a network
    /// interface in Amazon VPC.
    /// This command is only available in Amazon VPC
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class UnassignPrivateIpAddressesRequest
    {
        private string networkInterfaceIdField;
        private List<string> privateIpAddressesField;

        /// <summary>
        /// The network interface from which the secondary private IP address will be unassigned. 
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the network interface from which the secondary private IP address will be unassigned. 
        /// </summary>
        /// <param name="networkInterfaceId">Network interface ID.</param>
        /// <returns>this instance</returns>
        public UnassignPrivateIpAddressesRequest WithNetworkInterfaceId(string networkInterfaceId)
        {
            this.networkInterfaceIdField = networkInterfaceId;
            return this;
        }

        /// <summary>
        /// Checks if the NetworkInterfaceId property is set
        /// </summary>
        /// <returns>true if the NetworkInterfaceId property is set</returns>
        public bool IsSetNetworkInterfaceId()
        {
            return !string.IsNullOrEmpty(this.networkInterfaceIdField);
        }


        /// <summary>
        /// The secondary private IP addresses that you want to unassign from the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddresses")]
        public List<string> PrivateIpAddresses
        {
            get { return this.privateIpAddressesField; }
            set { this.privateIpAddressesField = value; }
        }

        /// <summary>
        /// Sets the secondary private IP addresses that you want to unassign from the network interface.
        /// </summary>
        /// <param name="privateIpAddresses">List of private IP addresses.</param>
        /// <returns>this instance</returns>
        public UnassignPrivateIpAddressesRequest WithPrivateIpAddresses(List<string> privateIpAddresses)
        {
            this.privateIpAddressesField = privateIpAddresses;
            return this;
        }

        /// <summary>
        /// Checks if the PrivateIpAddresses property is set
        /// </summary>
        /// <returns>true if the PrivateIpAddresses property is set</returns>
        public bool IsSetPrivateIpAddresses()
        {
            return this.privateIpAddressesField != null;
        }
    }
}
