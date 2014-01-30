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
    /// Container for the parameters to the DescribeNetworkInterfaces operation.
    /// <para>Describes one or more of your network interfaces.</para>
    /// </summary>
    public partial class DescribeNetworkInterfacesRequest : AmazonEC2Request
    {
        private List<string> networkInterfaceIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more network interface IDs. Default: Describes all your network interfaces.
        ///  
        /// </summary>
        public List<string> NetworkInterfaceIds
        {
            get { return this.networkInterfaceIds; }
            set { this.networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this.networkInterfaceIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>addresses.private-ip-address</c> - The private IP addresses associated with the network interface. </li>
        /// <li> <c>addresses.primary</c> - Whether the private IP address is the primary IP address associated with the network interface. </li> <li>
        /// <c>addresses.association.public-ip</c> - The association ID returned when the network interface was associated with the Elastic IP address.
        /// </li> <li> <c>addresses.association.owner-id</c> - The owner ID of the addresses associated with the network interface. </li> <li>
        /// <c>association.association-id</c> - The association ID returned when the network interface was associated with an IP address. </li> <li>
        /// <c>association.allocation-id</c> - The allocation ID returned when you allocated the Elastic IP address for your network interface. </li>
        /// <li> <c>association.ip-owner-id</c> - The owner of the Elastic IP address associated with the network interface. </li> <li>
        /// <c>association.public-ip</c> - The address of the Elastic IP address bound to the network interface. </li> <li>
        /// <c>attachment.attachment-id</c> - The ID of the interface attachment. </li> <li> <c>attachment.instance-id</c> - The ID of the instance to
        /// which the network interface is attached. </li> <li> <c>attachment.instance-owner-id</c> - The owner ID of the instance to which the network
        /// interface is attached. </li> <li> <c>attachment.device-index</c> - The device index to which the network interface is attached. </li> <li>
        /// <c>attachment.status</c> - The status of the attachment (<c>attaching</c> | <c>attached</c> | <c>detaching</c> | <c>detached</c>). </li>
        /// <li> <c>attachment.attach.time</c> - The time that the network interface was attached to an instance. </li> <li>
        /// <c>attachment.delete-on-termination</c> - Indicates whether the attachment is deleted when an instance is terminated. </li> <li>
        /// <c>availability-zone</c> - The Availability Zone of the network interface. </li> <li> <c>description</c> - The description of the network
        /// interface. </li> <li> <c>group-id</c> - The ID of a security group associated with the network interface. </li> <li> <c>group-name</c> - The
        /// name of a security group associated with the network interface. </li> <li> <c>mac-address</c> - The MAC address of the network interface.
        /// </li> <li> <c>network-interface-id</c> - The ID of the network interface. </li> <li> <c>owner-id</c> - The AWS account ID of the network
        /// interface owner. </li> <li> <c>private-ip-address</c> - The private IP address or addresses of the network interface. </li> <li>
        /// <c>private-dns-name</c> - The private DNS name of the network interface. </li> <li> <c>requester-id</c> - The ID of the entity that launched
        /// the instance on your behalf (for example, AWS Management Console, Auto Scaling, and so on). </li> <li> <c>requester-managed</c> - Indicates
        /// whether the network interface is being managed by an AWS service (for example, AWS Management Console, Auto Scaling, and so on). </li> <li>
        /// <c>source-desk-check</c> - Indicates whether the network interface performs source/destination checking. A value of <c>true</c> means
        /// checking is enabled, and <c>false</c> means checking is disabled. The value must be <c>false</c> for the network interface to perform
        /// Network Address Translation (NAT) in your VPC. </li> <li> <c>status</c> - The status of the network interface. If the network interface is
        /// not attached to an instance, the status is <c>available</c>; if a network interface is attached to an instance the status is <c>in-use</c>.
        /// </li> <li> <c>subnet-id</c> - The ID of the subnet for the network interface. </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The key/value
        /// combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter "tag-value=X", you get
        /// any resources assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X (regardless of what the tag's
        /// key is). If you want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li>
        /// <c>tag-value</c> - The value of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter. </li> <li>
        /// <c>vpc-id</c> - The ID of the VPC for the network interface. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
