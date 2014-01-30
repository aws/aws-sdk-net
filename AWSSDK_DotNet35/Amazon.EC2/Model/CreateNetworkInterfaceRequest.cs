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
    /// Container for the parameters to the CreateNetworkInterface operation.
    /// <para>Creates a network interface in the specified subnet.</para> <para>For more information about network interfaces, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html" >Elastic Network Interfaces</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateNetworkInterfaceRequest : AmazonEC2Request
    {
        private string subnetId;
        private string description;
        private string privateIpAddress;
        private List<string> groups = new List<string>();
        private List<PrivateIpAddressSpecification> privateIpAddresses = new List<PrivateIpAddressSpecification>();
        private int? secondaryPrivateIpAddressCount;


        /// <summary>
        /// The ID of the subnet to associate with the network interface.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// A description for the network interface.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The primary private IP address of the network interface. If you don't specify an IP address, Amazon EC2 selects one for you from the subnet
        /// range.
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
        /// The IDs of one or more security groups.
        ///  
        /// </summary>
        public List<string> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }

        /// <summary>
        /// One or more private IP addresses.
        ///  
        /// </summary>
        public List<PrivateIpAddressSpecification> PrivateIpAddresses
        {
            get { return this.privateIpAddresses; }
            set { this.privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this.privateIpAddresses.Count > 0;
        }

        /// <summary>
        /// The number of secondary private IP addresses to assign to a network interface. When you specify a number of secondary IP addresses, Amazon
        /// EC2 selects these IP addresses within the subnet range. The number of IP addresses you can assign to a network interface varies by instance
        /// type. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html#AvailableIpPerENI">Private IP
        /// Addresses Per ENI Per Instance Type</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        ///  
        /// </summary>
        public int SecondaryPrivateIpAddressCount
        {
            get { return this.secondaryPrivateIpAddressCount ?? default(int); }
            set { this.secondaryPrivateIpAddressCount = value; }
        }

        // Check to see if SecondaryPrivateIpAddressCount property is set
        internal bool IsSetSecondaryPrivateIpAddressCount()
        {
            return this.secondaryPrivateIpAddressCount.HasValue;
        }

    }
}
    
