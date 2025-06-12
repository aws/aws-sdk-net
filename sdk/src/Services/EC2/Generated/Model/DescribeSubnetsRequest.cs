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
    /// Container for the parameters to the DescribeSubnets operation.
    /// Describes your subnets. The default is to describe all your subnets. Alternatively,
    /// you can specify specific subnet IDs or filter the results to include only the subnets
    /// that match specific criteria.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/configure-subnets.html">Subnets</a>
    /// in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeSubnetsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone for the subnet. You can also use
        /// <c>availabilityZone</c> as the filter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone-id</c> - The ID of the Availability Zone for the subnet. You
        /// can also use <c>availabilityZoneId</c> as the filter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available-ip-address-count</c> - The number of IPv4 addresses in the subnet that
        /// are available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cidr-block</c> - The IPv4 CIDR block of the subnet. The CIDR block you specify
        /// must exactly match the subnet's CIDR block for information to be returned for the
        /// subnet. You can also use <c>cidr</c> or <c>cidrBlock</c> as the filter names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>customer-owned-ipv4-pool</c> - The customer-owned IPv4 address pool associated
        /// with the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>default-for-az</c> - Indicates whether this is the default subnet for the Availability
        /// Zone (<c>true</c> | <c>false</c>). You can also use <c>defaultForAz</c> as the filter
        /// name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>enable-dns64</c> - Indicates whether DNS queries made to the Amazon-provided DNS
        /// Resolver in this subnet should return synthetic IPv6 addresses for IPv4-only destinations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>enable-lni-at-device-index</c> - Indicates the device position for local network
        /// interfaces in this subnet. For example, <c>1</c> indicates local network interfaces
        /// in this subnet are the secondary network interface (eth1). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-cidr-block-association.ipv6-cidr-block</c> - An IPv6 CIDR block associated
        /// with the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-cidr-block-association.association-id</c> - An association ID for an IPv6
        /// CIDR block associated with the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-cidr-block-association.state</c> - The state of an IPv6 CIDR block associated
        /// with the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-native</c> - Indicates whether this is an IPv6 only subnet (<c>true</c> |
        /// <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>map-customer-owned-ip-on-launch</c> - Indicates whether a network interface created
        /// in this subnet (including a network interface created by <a>RunInstances</a>) receives
        /// a customer-owned IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>map-public-ip-on-launch</c> - Indicates whether instances launched in this subnet
        /// receive a public IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>outpost-arn</c> - The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private-dns-name-options-on-launch.hostname-type</c> - The type of hostname to
        /// assign to instances in the subnet at launch. For IPv4-only and dual-stack (IPv4 and
        /// IPv6) subnets, an instance DNS name can be based on the instance IPv4 address (ip-name)
        /// or the instance ID (resource-name). For IPv6 only subnets, an instance DNS name must
        /// be based on the instance ID (resource-name).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private-dns-name-options-on-launch.enable-resource-name-dns-a-record</c> - Indicates
        /// whether to respond to DNS queries for instance hostnames with DNS A records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private-dns-name-options-on-launch.enable-resource-name-dns-aaaa-record</c> -
        /// Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the subnet (<c>pending</c> | <c>available</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>subnet-arn</c> - The Amazon Resource Name (ARN) of the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>subnet-id</c> - The ID of the subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c> - The key/value combination of a tag assigned to the resource. Use the
        /// tag key in the filter name and the tag value as the filter value. For example, to
        /// find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-id</c> - The ID of the VPC for the subnet.
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
        /// make another request with the token returned in the output. For more information,
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

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of the subnets.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}