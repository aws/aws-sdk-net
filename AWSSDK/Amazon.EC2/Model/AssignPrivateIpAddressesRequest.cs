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
    /// Assigns one or more secondary private IP addresses to a network interface in Amazon VPC.
    /// </summary>
    /// <remarks>
    /// You can specify one or more specific secondary IP addresses that you want to assign,
    /// or you can specify a number of secondary IP addresses to be automatically assigned
    /// within the subnet’s CIDR block range.
    /// The number of secondary IP addresses that you can assign to an instance varies by instance type.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class AssignPrivateIpAddressesRequest : EC2Request
    {
        private string networkInterfaceIdField;
        private List<string> privateIpAddressesField;
        private int? secondaryPrivateIpAddressCountField;
        private bool? allowReassignmentField;

        /// <summary>
        /// The network interface to which the IP address will be assigned.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the network interface to which the IP address will be assigned.
        /// </summary>
        /// <param name="networkInterfaceId">Network interface ID.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssignPrivateIpAddressesRequest WithNetworkInterfaceId(string networkInterfaceId)
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
        /// The number of secondary IP addresses to assign to the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecondaryPrivateIpAddressCount")]
        public int SecondaryPrivateIpAddressCount
        {
            get { return this.secondaryPrivateIpAddressCountField.GetValueOrDefault(); }
            set { this.secondaryPrivateIpAddressCountField = value; }
        }

        /// <summary>
        /// Sets the number of secondary IP addresses to assign to the network interface.
        /// You cannot specify this parameter when also specifying multiple PrivateIPAddresses for the same network interface.
        /// </summary>
        /// <param name="secondaryPrivateIpAddressCount">Instance Network Interface Association.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssignPrivateIpAddressesRequest WithSecondaryPrivateIpAddressCount(int secondaryPrivateIpAddressCount)
        {
            this.secondaryPrivateIpAddressCountField = secondaryPrivateIpAddressCount;
            return this;
        }

        /// <summary>
        /// Checks if the SecondaryPrivateIpAddressCount property is set
        /// </summary>
        /// <returns>true if the SecondaryPrivateIpAddressCount property is set</returns>
        public bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this.secondaryPrivateIpAddressCountField != null;
        }


        /// <summary>
        /// Specifies whether to allow an IP address that is already assigned to another network interface or 
        /// instance to be reassigned to the specified network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllowReassignment")]
        public bool AllowReassignment
        {
            get { return this.allowReassignmentField.GetValueOrDefault(); }
            set { this.allowReassignmentField = value; }
        }

        /// <summary>
        /// Sets whether to allow an IP address that is already assigned to another network interface or 
        /// instance to be reassigned to the specified network interface.
        /// </summary>
        /// <param name="allowReassignment">Whether reassignment is allowed.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssignPrivateIpAddressesRequest WithAllowReassignment(bool allowReassignment)
        {
            this.allowReassignmentField = allowReassignment;
            return this;
        }

        /// <summary>
        /// Checks if the AllowReassignment property is set
        /// </summary>
        /// <returns>true if the AllowReassignment property is set</returns>
        public bool IsSetAllowReassignment()
        {
            return this.allowReassignmentField != null;
        }


        /// <summary>
        /// Assigns the specified IP addresses as secondary IP address to the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddresses")]
        public List<string> PrivateIpAddresses
        {
            get
            {
                if (this.privateIpAddressesField == null)
                {
                    this.privateIpAddressesField = new List<string>();
                }
                return this.privateIpAddressesField;
            }
            set { this.privateIpAddressesField = value; }
        }

        /// <summary>
        /// Sets the specified IP addresses as secondary IP address to the network interface.
        /// </summary>
        /// <param name="privateIpAddresses">List of private IP addresses.</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AssignPrivateIpAddressesRequest WithPrivateIpAddresses(params string[] privateIpAddresses)
        {
            foreach (string privateIpAddress in privateIpAddresses)
            {
                PrivateIpAddresses.Add(privateIpAddress);
            }
            return this;
        }

        /// <summary>
        /// Checks if the PrivateIpAddresses property is set
        /// </summary>
        /// <returns>true if the PrivateIpAddresses property is set</returns>
        public bool IsSetPrivateIpAddresses()
        {
            return PrivateIpAddresses.Count > 0;
        }
    }
}
