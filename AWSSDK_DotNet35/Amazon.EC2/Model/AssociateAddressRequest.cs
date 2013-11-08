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
    /// <para> The AssociateAddress operation associates an elastic IP address with an instance. </para> <para> If the IP address is currently
    /// assigned to another instance, the IP address is assigned to the new instance. This is an idempotent operation. If you enter it more than
    /// once, Amazon EC2 does not return an error. </para>
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
        /// The instance to associate with the IP address.
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
        /// IP address that you are assigning to the instance.
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
        /// The allocation ID that AWS returned when you allocated the elastic IP address for use with Amazon VPC.
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
    
