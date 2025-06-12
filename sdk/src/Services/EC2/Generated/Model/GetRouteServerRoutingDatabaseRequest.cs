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
    /// Container for the parameters to the GetRouteServerRoutingDatabase operation.
    /// Gets the routing database for the specified route server. The <a href="https://en.wikipedia.org/wiki/Routing_table">Routing
    /// Information Base (RIB)</a> serves as a database that stores all the routing information
    /// and network topology data collected by a router or routing system, such as routes
    /// learned from BGP peers. The RIB is constantly updated as new routing information is
    /// received or existing routes change. This ensures that the route server always has
    /// the most current view of the network topology and can make optimal routing decisions.
    /// 
    ///  
    /// <para>
    /// Amazon VPC Route Server simplifies routing for traffic between workloads that are
    /// deployed within a VPC and its internet gateways. With this feature, VPC Route Server
    /// dynamically updates VPC and internet gateway route tables with your preferred IPv4
    /// or IPv6 routes to achieve routing fault tolerance for those workloads. This enables
    /// you to automatically reroute traffic within a VPC, which increases the manageability
    /// of VPC routing and interoperability with third-party workloads.
    /// </para>
    ///  
    /// <para>
    /// Route server supports the follow route table types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// VPC route tables not associated with subnets
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Subnet route tables
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Internet gateway route tables
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Route server does not support route tables associated with virtual private gateways.
    /// To propagate routes into a transit gateway route table, use <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-connect.html">Transit
    /// Gateway Connect</a>.
    /// </para>
    /// </summary>
    public partial class GetRouteServerRoutingDatabaseRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _routeServerId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
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
        /// Filters to apply to the routing database query.
        /// </para>
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
        /// The maximum number of routing database entries to return in a single response.
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
        /// The token for the next page of results.
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
        /// Gets and sets the property RouteServerId. 
        /// <para>
        /// The ID of the route server for which to get the routing database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RouteServerId
        {
            get { return this._routeServerId; }
            set { this._routeServerId = value; }
        }

        // Check to see if RouteServerId property is set
        internal bool IsSetRouteServerId()
        {
            return this._routeServerId != null;
        }

    }
}