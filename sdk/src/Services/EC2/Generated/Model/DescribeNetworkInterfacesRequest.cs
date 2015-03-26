/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Describes one or more of your network interfaces.
    /// </summary>
    public partial class DescribeNetworkInterfacesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _networkInterfaceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>addresses.private-ip-address</code> - The private IP addresses associated with
        /// the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>addresses.primary</code> - Whether the private IP address is the primary IP
        /// address associated with the network interface. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>addresses.association.public-ip</code> - The association ID returned when the
        /// network interface was associated with the Elastic IP address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>addresses.association.owner-id</code> - The owner ID of the addresses associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.association-id</code> - The association ID returned when the network
        /// interface was associated with an IP address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.allocation-id</code> - The allocation ID returned when you allocated
        /// the Elastic IP address for your network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.ip-owner-id</code> - The owner of the Elastic IP address associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.public-ip</code> - The address of the Elastic IP address bound to
        /// the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.public-dns-name</code> - The public DNS name for the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.attachment-id</code> - The ID of the interface attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.instance-id</code> - The ID of the instance to which the network
        /// interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.instance-owner-id</code> - The owner ID of the instance to which
        /// the network interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.device-index</code> - The device index to which the network interface
        /// is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.status</code> - The status of the attachment (<code>attaching</code>
        /// | <code>attached</code> | <code>detaching</code> | <code>detached</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.attach.time</code> - The time that the network interface was attached
        /// to an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>attachment.delete-on-termination</code> - Indicates whether the attachment is
        /// deleted when an instance is terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>availability-zone</code> - The Availability Zone of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>description</code> - The description of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>group-id</code> - The ID of a security group associated with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>group-name</code> - The name of a security group associated with the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>mac-address</code> - The MAC address of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>network-interface-id</code> - The ID of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>owner-id</code> - The AWS account ID of the network interface owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>private-ip-address</code> - The private IP address or addresses of the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>private-dns-name</code> - The private DNS name of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>requester-id</code> - The ID of the entity that launched the instance on your
        /// behalf (for example, AWS Management Console, Auto Scaling, and so on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>requester-managed</code> - Indicates whether the network interface is being
        /// managed by an AWS service (for example, AWS Management Console, Auto Scaling, and
        /// so on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>source-desk-check</code> - Indicates whether the network interface performs
        /// source/destination checking. A value of <code>true</code> means checking is enabled,
        /// and <code>false</code> means checking is disabled. The value must be <code>false</code>
        /// for the network interface to perform Network Address Translation (NAT) in your VPC.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>status</code> - The status of the network interface. If the network interface
        /// is not attached to an instance, the status is <code>available</code>; if a network
        /// interface is attached to an instance the status is <code>in-use</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>subnet-id</code> - The ID of the subnet for the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the resource. This filter is independent
        /// of the <code>tag-value</code> filter. For example, if you use both the filter "tag-key=Purpose"
        /// and the filter "tag-value=X", you get any resources assigned both the tag key Purpose
        /// (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-id</code> - The ID of the VPC for the network interface.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. 
        /// <para>
        /// One or more network interface IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your network interfaces.
        /// </para>
        /// </summary>
        public List<string> NetworkInterfaceIds
        {
            get { return this._networkInterfaceIds; }
            set { this._networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this._networkInterfaceIds != null && this._networkInterfaceIds.Count > 0; 
        }

    }
}