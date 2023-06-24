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
    /// Container for the parameters to the DescribeRouteTables operation.
    /// Describes one or more of your route tables.
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
    /// tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeRouteTablesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _routeTableIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>association.route-table-association-id</code> - The ID of an association ID
        /// for the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.route-table-id</code> - The ID of the route table involved in the
        /// association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.subnet-id</code> - The ID of the subnet involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association.main</code> - Indicates whether the route table is the main route
        /// table for the VPC (<code>true</code> | <code>false</code>). Route tables that do not
        /// have an association ID are not returned in the response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The ID of the Amazon Web Services account that owns the route
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-table-id</code> - The ID of the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.destination-cidr-block</code> - The IPv4 CIDR range specified in a route
        /// in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.destination-ipv6-cidr-block</code> - The IPv6 CIDR range specified in
        /// a route in the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.destination-prefix-list-id</code> - The ID (prefix) of the Amazon Web
        /// Service specified in a route in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.egress-only-internet-gateway-id</code> - The ID of an egress-only Internet
        /// gateway specified in a route in the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.gateway-id</code> - The ID of a gateway specified in a route in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.instance-id</code> - The ID of an instance specified in a route in the
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.nat-gateway-id</code> - The ID of a NAT gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.transit-gateway-id</code> - The ID of a transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.origin</code> - Describes how the route was created. <code>CreateRouteTable</code>
        /// indicates that the route was automatically created when the route table was created;
        /// <code>CreateRoute</code> indicates that the route was manually added to the route
        /// table; <code>EnableVgwRoutePropagation</code> indicates that the route was propagated
        /// by route propagation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.state</code> - The state of a route in the route table (<code>active</code>
        /// | <code>blackhole</code>). The blackhole state indicates that the route's target isn't
        /// available (for example, the specified gateway isn't attached to the VPC, the specified
        /// NAT instance has been terminated, and so on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.vpc-peering-connection-id</code> - The ID of a VPC peering connection
        /// specified in a route in the table.
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
        ///  <code>vpc-id</code> - The ID of the VPC for the route table.
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
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=100)]
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
        /// One or more route table IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your route tables.
        /// </para>
        /// </summary>
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && this._routeTableIds.Count > 0; 
        }

    }
}