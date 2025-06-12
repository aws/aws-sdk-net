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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeNetworkInterfaces operation.
    /// Describes the specified network interfaces or all your network interfaces.
    /// 
    ///  
    /// <para>
    /// If you have a large number of network interfaces, the operation fails unless you use
    /// pagination or one of the following filters: <c>group-id</c>, <c>mac-address</c>, <c>private-dns-name</c>,
    /// <c>private-ip-address</c>, <c>subnet-id</c>, or <c>vpc-id</c>.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly recommend using only paginated requests. Unpaginated requests are susceptible
    /// to throttling and timeouts.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DescribeNetworkInterfacesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private List<string> _networkInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>association.allocation-id</c> - The allocation ID returned when you allocated
        /// the Elastic IP address (IPv4) for your network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.association-id</c> - The association ID returned when the network
        /// interface was associated with an IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>addresses.association.owner-id</c> - The owner ID of the addresses associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>addresses.association.public-ip</c> - The association ID returned when the network
        /// interface was associated with the Elastic IP address (IPv4).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>addresses.primary</c> - Whether the private IPv4 address is the primary IP address
        /// associated with the network interface. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>addresses.private-ip-address</c> - The private IPv4 addresses associated with
        /// the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.ip-owner-id</c> - The owner of the Elastic IP address (IPv4) associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.public-ip</c> - The address of the Elastic IP address (IPv4) bound
        /// to the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.public-dns-name</c> - The public DNS name for the network interface
        /// (IPv4).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.attach-time</c> - The time that the network interface was attached
        /// to an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.attachment-id</c> - The ID of the interface attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.delete-on-termination</c> - Indicates whether the attachment is deleted
        /// when an instance is terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.device-index</c> - The device index to which the network interface
        /// is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.instance-id</c> - The ID of the instance to which the network interface
        /// is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.instance-owner-id</c> - The owner ID of the instance to which the network
        /// interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.status</c> - The status of the attachment (<c>attaching</c> | <c>attached</c>
        /// | <c>detaching</c> | <c>detached</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>description</c> - The description of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>group-id</c> - The ID of a security group associated with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-addresses.ipv6-address</c> - An IPv6 address associated with the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>interface-type</c> - The type of network interface (<c>api_gateway_managed</c>
        /// | <c>aws_codestar_connections_managed</c> | <c>branch</c> | <c>ec2_instance_connect_endpoint</c>
        /// | <c>efa</c> | <c>efa-only</c> | <c>efs</c> | <c>evs</c> | <c>gateway_load_balancer</c>
        /// | <c>gateway_load_balancer_endpoint</c> | <c>global_accelerator_managed</c> | <c>interface</c>
        /// | <c>iot_rules_managed</c> | <c>lambda</c> | <c>load_balancer</c> | <c>nat_gateway</c>
        /// | <c>network_load_balancer</c> | <c>quicksight</c> | <c>transit_gateway</c> | <c>trunk</c>
        /// | <c>vpc_endpoint</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mac-address</c> - The MAC address of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface-id</c> - The ID of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operator.managed</c> - A Boolean that indicates whether this is a managed network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operator.principal</c> - The principal that manages the network interface. Only
        /// valid for managed network interfaces, where <c>managed</c> is <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The Amazon Web Services account ID of the network interface owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private-dns-name</c> - The private DNS name of the network interface (IPv4).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private-ip-address</c> - The private IPv4 address or addresses of the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requester-id</c> - The alias or Amazon Web Services account ID of the principal
        /// or service that created the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requester-managed</c> - Indicates whether the network interface is being managed
        /// by an Amazon Web Services service (for example, Amazon Web Services Management Console,
        /// Auto Scaling, and so on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-dest-check</c> - Indicates whether the network interface performs source/destination
        /// checking. A value of <c>true</c> means checking is enabled, and <c>false</c> means
        /// checking is disabled. The value must be <c>false</c> for the network interface to
        /// perform network address translation (NAT) in your VPC. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - The status of the network interface. If the network interface is
        /// not attached to an instance, the status is <c>available</c>; if a network interface
        /// is attached to an instance the status is <c>in-use</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>subnet-id</c> - The ID of the subnet for the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c>:&lt;key&gt; - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-id</c> - The ID of the VPC for the network interface.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkInterfaceIds
        {
            get { return this._networkInterfaceIds; }
            set { this._networkInterfaceIds = value; }
        }

        // Check to see if NetworkInterfaceIds property is set
        internal bool IsSetNetworkInterfaceIds()
        {
            return this._networkInterfaceIds != null && (this._networkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
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