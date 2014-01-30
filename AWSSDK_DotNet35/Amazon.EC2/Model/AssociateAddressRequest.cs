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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAddress operation.
    /// <para>Associates an Elastic IP address with an instance or a network interface.</para> <para>An Elastic IP address is for use in either the
    /// EC2-Classic platform or in a VPC. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para> <para>[EC2-Classic, default VPC] If the Elastic IP address is already associated with a different
    /// instance, it is disassociated from that instance and associated with the specified instance.</para> <para>[EC2-VPC] If you don't specify a
    /// private IP address, the Elastic IP address is associated with the primary IP address. If the Elastic IP address is already associated with a
    /// different instance or a network interface, you get an error unless you allow reassociation.</para> <para>This is an idempotent operation. If
    /// you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
    /// </summary>
    public partial class AssociateAddressRequest : AmazonEC2Request
    {
        private string instanceId;
        private string publicIp;
        private string allocationId;
        private string networkInterfaceId;
        private string privateIpAddress;
        private bool? allowReassociation;


        /// <summary>
        /// The ID of the instance. The operation fails if you specify an instance ID unless exactly one network interface is attached.
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
        /// [EC2-VPC] The allocation ID. This is required for EC2-VPC.
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
        /// [EC2-VPC] The ID of the network interface. If the instance has more than one network interface, you must specify a network interface ID.
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
        /// [EC2-VPC] The primary or secondary private IP address to associate with the Elastic IP address. If no private IP address is specified, the
        /// Elastic IP address is associated with the primary private IP address.
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

        /// <summary>
        /// [EC2-VPC] Allows an Elastic IP address that is already associated with an instance or network interface to be re-associated with the
        /// specified instance or network interface. Otherwise, the operation fails. Default: <c>false</c>
        ///  
        /// </summary>
        public bool AllowReassociation
        {
            get { return this.allowReassociation ?? default(bool); }
            set { this.allowReassociation = value; }
        }

        // Check to see if AllowReassociation property is set
        internal bool IsSetAllowReassociation()
        {
            return this.allowReassociation.HasValue;
        }

    }
}
    
