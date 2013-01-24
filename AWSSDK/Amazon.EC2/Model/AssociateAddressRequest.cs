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
    /// Associates an elastic IP address with an instance. If the IP address is
    /// currently assigned to another instance, the IP address is assigned
    /// to the new instance.
    /// </summary>
    /// <remarks>
    /// This is an idempotent operation. If you call it more than once, Amazon EC2 does not return an error.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class AssociateAddressRequest
    {    
        private string instanceIdField;
        private string publicIpField;
        private string allocationIdField;
        private string networkInterfaceIdField;
        private string privateIpAddressField;
        private bool? allowReassociationField;

        /// <summary>
        /// The instance to associate with the IP address.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the instance to associate with the IP address.
        /// </summary>
        /// <param name="instanceId">The instance to associate with the IP address.</param>
        /// <returns>this instance</returns>
        public AssociateAddressRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// The Elastic IP address to assign to the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the Elastic IP address to assign to the instance.
        /// </summary>
        /// <param name="publicIp">IP address that you are assigning to the
        /// instance.</param>
        /// <returns>this instance</returns>
        public AssociateAddressRequest WithPublicIp(string publicIp)
        {
            this.publicIpField = publicIp;
            return this;
        }

        /// <summary>
        /// Checks if PublicIp property is set
        /// </summary>
        /// <returns>true if PublicIp property is set</returns>
        public bool IsSetPublicIp()
        {
            return this.publicIpField != null;
        }

        /// <summary>
        /// The allocation ID that AWS returned when you allocated
        /// the elastic IP address for use with Amazon VPC.
        ///
        /// Condition: Required for VPC elastic IP addresses
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocationId")]
        public string AllocationId
        {
            get { return this.allocationIdField; }
            set { this.allocationIdField = value; }
        }

        /// <summary>
        /// Sets the allocation ID for use with Amazon VPC.
        /// </summary>
        /// <param name="allocationId">The allocation ID that AWS returned when you allocated
        /// the elastic IP address for use with Amazon VPC.</param>
        /// <returns>this instance</returns>
        public AssociateAddressRequest WithAllocationId(string allocationId)
        {
            this.allocationIdField = allocationId;
            return this;
        }

        /// <summary>
        /// Checks if AllocationId property is set
        /// </summary>
        /// <returns>true if AllocationId property is set</returns>
        public bool IsSetAllocationId()
        {
            return this.allocationIdField != null;
        }

        /// <summary>
        /// The network interface ID to associate with an instance.
        /// Association fails when specifying an instance ID unless exactly one interface is attached.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the network interface ID to associate with an instance.
        /// </summary>
        /// <param name="networkInterfaceId">Network interface ID</param>
        /// <returns>this instance</returns>
        public AssociateAddressRequest WithNetworkInterfaceId(string networkInterfaceId)
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
        /// The primary or secondary private IP address to associate with the Elastic IP address.
        /// If no private IP is specified, the Elastic IP address is associated with the primary 
        /// private IP address. This is only available in Amazon VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the primary or secondary private IP address to associate with the Elastic IP address.
        /// </summary>
        /// <param name="privateIpAddress">Private IP address.</param>
        /// <returns>this instance</returns>
        public AssociateAddressRequest WithPrivateIpAddress(string privateIpAddress)
        {
            this.privateIpAddressField = privateIpAddress;
            return this;
        }

        /// <summary>
        /// Checks if the PrivateIpAddress property is set
        /// </summary>
        /// <returns>true if the PrivateIpAddress property is set</returns>
        public bool IsSetPrivateIpAddress()
        {
            return !string.IsNullOrEmpty(this.privateIpAddressField);
        }


        /// <summary>
        /// Specify whether to allow an Elastic IP address that is already associated with another 
        /// network interface or instance to be re-associated with the specified instance or interface. 
        /// If the Elastic IP address is associated, and this option is not specified, the operation will 
        /// fail. This is only available in Amazon VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllowReassociation")]
        public bool AllowReassociation
        {
            get { return this.allowReassociationField.GetValueOrDefault(); }
            set { this.allowReassociationField = value; }
        }

        /// <summary>
        /// Sets whether to allow an Elastic IP address that is already associated with another 
        /// network interface or instance to be re-associated with the specified instance or interface. 
        /// </summary>
        /// <param name="allowReassociation">Whether reassociation is allowed.</param>
        /// <returns>this instance</returns>
        public AssociateAddressRequest WithAllowReassociation(bool allowReassociation)
        {
            this.allowReassociationField = allowReassociation;
            return this;
        }

        /// <summary>
        /// Checks if the AllowReassociation property is set
        /// </summary>
        /// <returns>true if the AllowReassociation property is set</returns>
        public bool IsSetAllowReassociation()
        {
            return this.allowReassociationField != null;
        }
    }
}
