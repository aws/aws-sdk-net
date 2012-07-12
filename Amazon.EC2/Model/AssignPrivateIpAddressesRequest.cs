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
 *  API Version: 2012-06-15
 */

using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Assigns one or more secondary private IP addresses to a network interface in Amazon VPC.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-06-15/", IsNullable = false)]
    public class AssignPrivateIpAddressesRequest
    {
        private string networkInterfaceIdField;
        private List<string> privateIpAddressesField;
        private int? secondaryPrivateIpAddressCountField;
        private bool? allowReassignmentField;

        /// <summary>
        /// Gets and sets the NetworkInterfaceId property.
        /// Network interface ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the NetworkInterfaceId property
        /// </summary>
        /// <param name="networkInterfaceId">Network interface ID.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the SecondaryPrivateIpAddressCount property.
        /// Instance Network Interface Association.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecondaryPrivateIpAddressCount")]
        public int SecondaryPrivateIpAddressCount
        {
            get { return this.secondaryPrivateIpAddressCountField.GetValueOrDefault(); }
            set { this.secondaryPrivateIpAddressCountField = value; }
        }

        /// <summary>
        /// Sets the SecondaryPrivateIpAddressCount property.
        /// The number of secondary IP addresses to assign to the network interface. You cannot specify this 
        /// parameter when also specifying multiple PrivateIPAddresses for the same network interface.
        /// </summary>
        /// <param name="secondaryPrivateIpAddressCount">Instance Network Interface Association.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the AllowReassignment property.
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
        /// Sets the AllowReassignment property
        /// </summary>
        /// <param name="allowReassignment">Whether reassignment is allowed.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the PrivateIpAddresses property.
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
        /// Sets the PrivateIpAddresses property
        /// </summary>
        /// <param name="privateIpAddresses">List of private IP addresses.</param>
        /// <returns>this instance</returns>
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
