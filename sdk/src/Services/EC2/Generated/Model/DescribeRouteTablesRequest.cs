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
    /// Container for the parameters to the DescribeRouteTables operation.
    /// Describes your route tables. The default is to describe all your route tables. Alternatively,
    /// you can specify specific route table IDs or filter the results to include only the
    /// route tables that match specific criteria.
    /// 
    ///  
    /// <para>
    /// Each subnet in your VPC must be associated with a route table. If a subnet is not
    /// explicitly associated with any route table, it is implicitly associated with the main
    /// route table. This command does not return the subnet ID for implicit associations.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
    /// tables</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeRouteTablesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _routeTableIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        ///  <c>association.gateway-id</c> - The ID of the gateway involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.route-table-association-id</c> - The ID of an association ID for the
        /// route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.route-table-id</c> - The ID of the route table involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.subnet-id</c> - The ID of the subnet involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.main</c> - Indicates whether the route table is the main route table
        /// for the VPC (<c>true</c> | <c>false</c>). Route tables that do not have an association
        /// ID are not returned in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route-table-id</c> - The ID of the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.destination-cidr-block</c> - The IPv4 CIDR range specified in a route in
        /// the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.destination-ipv6-cidr-block</c> - The IPv6 CIDR range specified in a route
        /// in the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.destination-prefix-list-id</c> - The ID (prefix) of the Amazon Web Services
        /// service specified in a route in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.egress-only-internet-gateway-id</c> - The ID of an egress-only Internet
        /// gateway specified in a route in the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.gateway-id</c> - The ID of a gateway specified in a route in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.instance-id</c> - The ID of an instance specified in a route in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.nat-gateway-id</c> - The ID of a NAT gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.transit-gateway-id</c> - The ID of a transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.origin</c> - Describes how the route was created. <c>CreateRouteTable</c>
        /// indicates that the route was automatically created when the route table was created;
        /// <c>CreateRoute</c> indicates that the route was manually added to the route table;
        /// <c>EnableVgwRoutePropagation</c> indicates that the route was propagated by route
        /// propagation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.state</c> - The state of a route in the route table (<c>active</c> | <c>blackhole</c>).
        /// The blackhole state indicates that the route's target isn't available (for example,
        /// the specified gateway isn't attached to the VPC, the specified NAT instance has been
        /// terminated, and so on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.vpc-peering-connection-id</c> - The ID of a VPC peering connection specified
        /// in a route in the table.
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
        ///  <c>vpc-id</c> - The ID of the VPC for the route table.
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
        [AWSProperty(Min=5, Max=100)]
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
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// The IDs of the route tables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && (this._routeTableIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}