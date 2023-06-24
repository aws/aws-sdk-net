/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private int? _maxResults;
        private List<string> _networkInterfaceIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>addresses.private-ip-address</code> - The private IPv4 addresses associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>addresses.primary</code> - Whether the private IPv4 address is the primary
        /// IP address associated with the network interface. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>addresses.association.public-ip</code> - The association ID returned when the
        /// network interface was associated with the Elastic IP address (IPv4).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>addresses.association.owner-id</code> - The owner ID of the addresses associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.association-id</code> - The association ID returned when the network
        /// interface was associated with an IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.allocation-id</code> - The allocation ID returned when you allocated
        /// the Elastic IP address (IPv4) for your network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.ip-owner-id</code> - The owner of the Elastic IP address (IPv4)
        /// associated with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.public-ip</code> - The address of the Elastic IP address (IPv4)
        /// bound to the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.public-dns-name</code> - The public DNS name for the network interface
        /// (IPv4).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.attachment-id</code> - The ID of the interface attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.attach-time</code> - The time that the network interface was attached
        /// to an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.delete-on-termination</code> - Indicates whether the attachment
        /// is deleted when an instance is terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.device-index</code> - The device index to which the network interface
        /// is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.instance-id</code> - The ID of the instance to which the network
        /// interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.instance-owner-id</code> - The owner ID of the instance to which
        /// the network interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.status</code> - The status of the attachment (<code>attaching</code>
        /// | <code>attached</code> | <code>detaching</code> | <code>detached</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>description</code> - The description of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>group-id</code> - The ID of a security group associated with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>group-name</code> - The name of a security group associated with the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-addresses.ipv6-address</code> - An IPv6 address associated with the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>interface-type</code> - The type of network interface (<code>api_gateway_managed</code>
        /// | <code>aws_codestar_connections_managed</code> | <code>branch</code> | <code>efa</code>
        /// | <code>gateway_load_balancer</code> | <code>gateway_load_balancer_endpoint</code>
        /// | <code>global_accelerator_managed</code> | <code>interface</code> | <code>iot_rules_managed</code>
        /// | <code>lambda</code> | <code>load_balancer</code> | <code>nat_gateway</code> | <code>network_load_balancer</code>
        /// | <code>quicksight</code> | <code>transit_gateway</code> | <code>trunk</code> | <code>vpc_endpoint</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mac-address</code> - The MAC address of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-id</code> - The ID of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The Amazon Web Services account ID of the network interface
        /// owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>private-ip-address</code> - The private IPv4 address or addresses of the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>private-dns-name</code> - The private DNS name of the network interface (IPv4).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>requester-id</code> - The alias or Amazon Web Services account ID of the principal
        /// or service that created the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>requester-managed</code> - Indicates whether the network interface is being
        /// managed by an Amazon Web Service (for example, Amazon Web Services Management Console,
        /// Auto Scaling, and so on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>source-dest-check</code> - Indicates whether the network interface performs
        /// source/destination checking. A value of <code>true</code> means checking is enabled,
        /// and <code>false</code> means checking is disabled. The value must be <code>false</code>
        /// for the network interface to perform network address translation (NAT) in your VPC.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status</code> - The status of the network interface. If the network interface
        /// is not attached to an instance, the status is <code>available</code>; if a network
        /// interface is attached to an instance the status is <code>in-use</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>subnet-id</code> - The ID of the subnet for the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-id</code> - The ID of the VPC for the network interface.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. You cannot specify this
        /// parameter and the network interface IDs parameter in the same request. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. 
        /// <para>
        /// The network interface IDs.
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

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}