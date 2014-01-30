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
    /// Container for the parameters to the AssignPrivateIpAddresses operation.
    /// <para>Assigns one or more secondary private IP addresses to the specified network interface. You can specify one or more specific secondary
    /// IP addresses, or you can specify the number of secondary IP addresses to be automatically assigned within the subnet's CIDR block range. The
    /// number of secondary IP addresses that you can assign to an instance varies by instance type. For information about instance types, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html" >Instance Types</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i> . For more information about Elastic IP addresses, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para> <para>AssignPrivateIpAddresses is available only in EC2-VPC.</para>
    /// </summary>
    public partial class AssignPrivateIpAddressesRequest : AmazonEC2Request
    {
        private string networkInterfaceId;
        private List<string> privateIpAddresses = new List<string>();
        private int? secondaryPrivateIpAddressCount;
        private bool? allowReassignment;


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
        /// One or more IP addresses to be assigned as a secondary private IP address to the network interface. If you don't specify an IP address,
        /// Amazon EC2 automatically selects an IP address within the subnet range.
        ///  
        /// </summary>
        public List<string> PrivateIpAddresses
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
        /// The number of secondary IP addresses to assign to the network interface.
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

        /// <summary>
        /// Indicates whether to allow an IP address that is already assigned to another network interface or instance to be reassigned to the specified
        /// network interface.
        ///  
        /// </summary>
        public bool AllowReassignment
        {
            get { return this.allowReassignment ?? default(bool); }
            set { this.allowReassignment = value; }
        }

        // Check to see if AllowReassignment property is set
        internal bool IsSetAllowReassignment()
        {
            return this.allowReassignment.HasValue;
        }

    }
}
    
