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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Network Interface Association
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class NetworkInterfaceAssociation
    {
        private string publicIpField;
        private string publicDnsNameField;
        private string ipOwnerIdField;
        private string allocationIdField;
        private string associationIdField;

        /// <summary>
        /// The address of the Elastic IP address bound to the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicIp")]
        public string PublicIp
        {
            get { return this.publicIpField; }
            set { this.publicIpField = value; }
        }

        /// <summary>
        /// Sets the address of the Elastic IP address bound to the network interface.
        /// </summary>
        /// <param name="publicIp">Public Ip</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfaceAssociation WithPublicIp(string publicIp)
        {
            this.publicIpField = publicIp;
            return this;
        }

        /// <summary>
        /// Checks if the PublicIp property is set
        /// </summary>
        /// <returns>true if the PublicIp property is set</returns>
        public bool IsSetPublicIp()
        {
            return !string.IsNullOrEmpty(this.publicIpField);
        }

        /// <summary>
        /// The DNS name for the network interface.
        /// </summary>
        [XmlElementAttribute(ElementName = "PublicDnsName")]
        public string PublicDnsName
        {
            get { return this.publicDnsNameField; }
            set { this.publicDnsNameField = value; }
        }

        /// <summary>
        /// Sets the DNS name for the network interface.
        /// </summary>
        /// <param name="publicDnsName">PublicDnsName</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfaceAssociation WithPublicDnsName(string publicDnsName)
        {
            this.publicDnsNameField = publicDnsName;
            return this;
        }

        /// <summary>
        /// Checks if the PublicDnsName property is set
        /// </summary>
        /// <returns>true if the PublicDnsName property is set</returns>
        public bool IsSetPublicDnsName()
        {
            return !string.IsNullOrEmpty(this.publicDnsNameField);
        }

        /// <summary>
        /// The ID of the Elastic IP address owner.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpOwnerId")]
        public string IpOwnerId
        {
            get { return this.ipOwnerIdField; }
            set { this.ipOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Elastic IP address owner.
        /// </summary>
        /// <param name="ipOwnerId">Ip Owner Id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfaceAssociation WithIpOwnerId(string ipOwnerId)
        {
            this.ipOwnerIdField = ipOwnerId;
            return this;
        }

        /// <summary>
        /// Checks if the IpOwnerId property is set
        /// </summary>
        /// <returns>true if the IpOwnerId property is set</returns>
        public bool IsSetIpOwnerId()
        {
            return !string.IsNullOrEmpty(this.ipOwnerIdField);
        }

        /// <summary>
        /// The ID representing the allocation of the address for use with Amazon VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocationId")]
        public string AllocationId
        {
            get { return this.allocationIdField; }
            set { this.allocationIdField = value; }
        }

        /// <summary>
        /// Sets the ID representing the allocation of the address for use with Amazon VPC.
        /// </summary>
        /// <param name="allocationId">Allocation Id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfaceAssociation WithAllocationId(string allocationId)
        {
            this.allocationIdField = allocationId;
            return this;
        }

        /// <summary>
        /// Checks if the AllocationId property is set
        /// </summary>
        /// <returns>true if the AllocationId property is set</returns>
        public bool IsSetAllocationId()
        {
            return !string.IsNullOrEmpty(this.allocationIdField);
        }

        /// <summary>
        /// The association ID corresponding to the VPC Elastic IP Conditional address.
        /// </summary>
        [XmlElementAttribute(ElementName = "AssociationId")]
        public string AssociationId
        {
            get { return this.associationIdField; }
            set { this.associationIdField = value; }
        }

        /// <summary>
        /// Sets the association ID corresponding to the VPC Elastic IP Conditional address.
        /// </summary>
        /// <param name="associationId">Association Id</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NetworkInterfaceAssociation WithAssociationId(string associationId)
        {
            this.associationIdField = associationId;
            return this;
        }

        /// <summary>
        /// Checks if the AssocationId property is set
        /// </summary>
        /// <returns>true if the AssociationId property is set</returns>
        public bool IsSetAssociationId()
        {
            return !string.IsNullOrEmpty(this.associationIdField);
        }
    }
}
