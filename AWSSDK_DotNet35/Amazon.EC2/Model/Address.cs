/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an Elastic IP address.</para>
    /// </summary>
    public class Address
    {
        
        private string instanceId;
        private string publicIp;
        private string allocationId;
        private string associationId;
        private DomainType domain;
        private string networkInterfaceId;
        private string networkInterfaceOwnerId;
        private string privateIpAddress;


        /// <summary>
        /// The ID of the instance the address is associated with (if any).
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The Elastic IP address.
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }

        /// <summary>
        /// The ID representing the allocation of the address for use with EC2-VPC.
        ///  
        /// </summary>
        public string AllocationId
        {
            get { return this.allocationId; }
            set { this.allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this.allocationId != null;
        }

        /// <summary>
        /// The ID representing the association of the address with an instance in a VPC.
        ///  
        /// </summary>
        public string AssociationId
        {
            get { return this.associationId; }
            set { this.associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this.associationId != null;
        }

        /// <summary>
        /// Indicates whether this Elastic IP address is for use with instances in EC2-Classic (<c>standard</c>) or instances in a VPC (<c>vpc</c>).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>vpc, standard</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DomainType Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// The ID of the network interface.
        ///  
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

        /// <summary>
        /// The ID of the AWS account that owns the network interface.
        ///  
        /// </summary>
        public string NetworkInterfaceOwnerId
        {
            get { return this.networkInterfaceOwnerId; }
            set { this.networkInterfaceOwnerId = value; }
        }

        // Check to see if NetworkInterfaceOwnerId property is set
        internal bool IsSetNetworkInterfaceOwnerId()
        {
            return this.networkInterfaceOwnerId != null;
        }

        /// <summary>
        /// The private IP address associated with the Elastic IP address.
        ///  
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }
    }
}
